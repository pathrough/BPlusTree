using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class DataItem
    {
        public string ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class DataBlock
    {
        private List<DataItem> _DataItemList = new List<DataItem>();
        public List<DataItem> DataItemList
        {
            get { return _DataItemList; }
            set { _DataItemList = value; }
        }

        public static int MaxItemCount
        {
            get
            {
                return 2;
            }
        }
    }

    public class IndexItem
    {
        public DataBlock DataBlock { get; set; }
        public DataItem DataItem { get; set; }//最大值
    }

    public class DataBase
    {
        private List<IndexItem> _IndexItemList = new List<IndexItem>();
        public List<IndexItem> IndexItemList
        {
            get { return _IndexItemList; }
            set { _IndexItemList = value; }
        }

        public int Insert(DataItem dataItem)
        {
            if(IndexItemList!=null && IndexItemList.Count>0)
            {
                //定位到块
                IndexItem indexItem = null;
                foreach (var index in this.IndexItemList)
                {
                    if (index.DataItem.ID.CompareTo(dataItem.ID) > 0)
                    {
                        //小于当前
                        indexItem = index;
                        break;
                    }
                    else if (dataItem.ID == index.DataItem.ID)
                    {
                        //等于当前
                        if (dataItem.Key.CompareTo(index.DataItem.Key) > 0)
                        {
                            indexItem = index;
                            break;
                        }
                        else if (dataItem.Key == index.DataItem.Key)
                        {
                            if (dataItem.Value.CompareTo(index.DataItem.Value) > 0)
                            {
                                indexItem = index;
                                break;
                            }
                            else if (dataItem.Value == index.DataItem.Value)
                            {
                                return 1;//重复了
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        //大于当前,继续，如果都找不到，确保保留最后一个
                        indexItem = index;
                    }
                }

                if (indexItem.DataBlock.DataItemList.Count < DataBlock.MaxItemCount)
                {
                    indexItem.DataBlock.DataItemList.Add(dataItem);
                    indexItem.DataBlock.DataItemList = indexItem.DataBlock.DataItemList.OrderBy(d => d.ID).ThenBy(d => d.Key).ThenBy(d => d.Value).ToList();//重新排序 todo
                    indexItem.DataItem = indexItem.DataBlock.DataItemList.Last();
                }
                else
                {
                    //分裂
                    indexItem.DataBlock.DataItemList.Add(dataItem);
                    indexItem.DataBlock.DataItemList = indexItem.DataBlock.DataItemList.OrderBy(d => d.ID).ThenBy(d => d.Key).ThenBy(d => d.Value).ToList();//重新排序 todo

                    int sourceCount = indexItem.DataBlock.DataItemList.Count;
                    var sourceList = indexItem.DataBlock.DataItemList;

                    int half = (int)(sourceCount / 2);
                    var part1 = sourceList.Take(half).ToList();
                    var part2 = sourceList.Skip(half).Take(sourceCount - half).ToList();
                    indexItem.DataBlock.DataItemList = part1;
                    indexItem.DataItem = part1.Last();

                    //新增的                    
                    IndexItemList.Add(new IndexItem
                    {
                        DataBlock = new DataBlock
                        {
                            DataItemList = part2
                        }
                        ,
                        DataItem = part2.Last()
                    });

                    //保证索引是排序的
                    this.IndexItemList = IndexItemList.OrderBy(d => d.DataItem.ID).ThenBy(d => d.DataItem.Key).ThenBy(d => d.DataItem.Value).ToList();
                }
            }
            else
            {
                IndexItemList.Add(new IndexItem
                {
                    DataBlock = new DataBlock
                    {
                        DataItemList = new List<DataItem> { dataItem}
                    }
                    ,
                    DataItem = dataItem
                });
            }
            return 0;
        }
    }
}
