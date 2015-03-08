using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
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
            IndexItem indexItem = GetIndexItem(dataItem);
            if (indexItem != null)
            {
                if (indexItem.DataItem.Equals(dataItem))
                {
                    return 1;//重复的不插入
                }
                else
                {
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
            }
            else
            {
                IndexItemList.Add(new IndexItem
                {
                    DataBlock = new DataBlock
                    {
                        DataItemList = new List<DataItem> { dataItem }
                    }
                    ,
                    DataItem = dataItem
                });
            }
            return 0;
        }

        /// <summary>
        /// 获取指定的DataItem可能归属的IndexItem
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns>返回null表示此数据库完全没有索引和数据</returns>
        IndexItem GetIndexItem(DataItem dataItem)
        {
            if (IndexItemList != null && IndexItemList.Count > 0)
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
                                indexItem = index;
                                break;
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
                return indexItem;
            }
            else
            {
                return null;//找不到
            }
        }

        /// <summary>
        /// 删除后可能导致数据页变得极少，最后数据分散
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        public int Delete(DataItem dataItem)
        {            
            IndexItem targetIndexItem = GetIndexItem(dataItem);
            if (targetIndexItem == null)
            {
                return 2;//找不到
            }
            else
            {
                DataItem targetDataItem = null;
                foreach(var item in targetIndexItem.DataBlock.DataItemList)
                {
                    if(item.Equals(dataItem))
                    {
                        targetDataItem = item;
                        break;
                    }
                }
                if(targetDataItem!=null)
                {                    
                    var sourceDataItemList = targetIndexItem.DataBlock.DataItemList;
                    //删除操作
                    var afterDelDataItemList = sourceDataItemList.Where(d => d.Equals(dataItem)).ToList();
                    if (afterDelDataItemList != null && afterDelDataItemList.Count>0)
                    {
                        targetIndexItem.DataBlock.DataItemList = afterDelDataItemList;
                        if (targetIndexItem.DataItem.Equals(dataItem))//删除的就是索引值时,重新赋值
                        {
                            targetIndexItem.DataItem = afterDelDataItemList.Last();
                        }
                        else
                        {
                            //索引值不变
                        }
                    }   
                    else
                    {
                        //删除后，数据页已经没有数据了，索引项也应该删掉
                        this.IndexItemList.Remove(targetIndexItem);
                    }
                }
                else
                {
                    return 2;//找不到
                }
                return 0;
            }
        }
    }
}
