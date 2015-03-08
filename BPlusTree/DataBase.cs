using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public abstract class DataBase
    {
        public DataBase(int maxDataBlockItemCount)
        {
            _MaxDataBlockItemCount = maxDataBlockItemCount;
        }
        readonly int _MaxDataBlockItemCount;
        public int MaxDataBlockItemCount
        {
            get
            {
                return _MaxDataBlockItemCount;
            }
        }
        private List<IndexItem> _IndexItemList = new List<IndexItem>();
        public List<IndexItem> IndexItemList
        {
            get { return _IndexItemList; }
            set { _IndexItemList = value; }
        }

        

        public int DataItemCount
        {
            get
            {
                int count = 0;
                foreach(var index in this.IndexItemList)
                {
                    count += index.DataBlock.DataItemList.Count;
                }
                return count;
            }
        }

        public int IndexLeafItemCount
        {
            get
            {
                return this.IndexItemList.Count;
            }
        }

        public InsertResult Insert(DataItem dataItem)
        {
            IndexItem indexItem = GetIndexItem(dataItem);
            if (indexItem != null)
            {
                if (indexItem.DataItem.Equals(dataItem))
                {
                    return InsertResult.Repeate;//重复的不插入
                }
                else
                {
                   
                    if (indexItem.DataBlock.DataItemList.Count < indexItem.DataBlock.MaxItemCount)
                    {
                        indexItem.DataBlock.DataItemList.Add(dataItem);
                        indexItem.DataBlock.DataItemList = Order(indexItem.DataBlock.DataItemList);//重新排序 todo
                        indexItem.DataItem = indexItem.DataBlock.DataItemList.Last();
                    }
                    else
                    {
                        //分裂
                        indexItem.DataBlock.DataItemList.Add(dataItem);
                        indexItem.DataBlock.DataItemList = Order(indexItem.DataBlock.DataItemList);//重新排序 todo

                        int sourceCount = indexItem.DataBlock.DataItemList.Count;
                        var sourceList = indexItem.DataBlock.DataItemList;

                        int half = (int)(sourceCount / 2);
                        var part1 = sourceList.Take(half).ToList();
                        var part2 = sourceList.Skip(half).Take(sourceCount - half).ToList();
                        indexItem.DataBlock.DataItemList = part1;
                        indexItem.DataItem = part1.Last();

                        //新增的                    
                        IndexItemList.Add(
                            new IndexItem(this
                                , new DataBlock(this, part2)
                                , part2.Last()
                            )
                        );

                        //保证索引是排序的
                        this.IndexItemList = Order(IndexItemList);
                    }
                }
            }
            else
            {
               
                IndexItemList.Add(
                    new IndexItem(this
                        , new DataBlock(this, new List<DataItem> { dataItem })
                        , dataItem
                    )
                );
            }
            return InsertResult.Success;
        }

        /// <summary>
        /// 删除后可能导致数据页变得极少，最后数据分散
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        public DeleteResult Delete(DataItem dataItem)
        {
            IndexItem targetIndexItem = GetIndexItem(dataItem);
            if (targetIndexItem == null)
            {
                return DeleteResult.NotFound;//找不到
            }
            else
            {
                DataItem targetDataItem = null;
                foreach (var item in targetIndexItem.DataBlock.DataItemList)
                {
                    if (item.Equals(dataItem))
                    {
                        targetDataItem = item;
                        break;
                    }
                }
                if (targetDataItem != null)
                {
                   
                    var sourceDataItemList = targetIndexItem.DataBlock.DataItemList;
                    //删除操作
                    var afterDelDataItemList = sourceDataItemList.Where(d => d.Equals(dataItem) == false).ToList();
                    if (afterDelDataItemList != null && afterDelDataItemList.Count > 0)
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
                    return DeleteResult.NotFound;//找不到
                }
                return DeleteResult.Success;
            }
        }

        List<DataItem> _DataItemList = new List<DataItem>();
        public List<DataItem> DataItemList
        {
            get
            {                
                foreach(var item in this.IndexItemList)
                {
                    _DataItemList.AddRange(item.DataBlock.DataItemList);
                }
                return _DataItemList;
            }
        }

        protected abstract IndexItem GetIndexItem(DataItem dataItem);

        protected abstract List<IndexItem> Order(List<IndexItem> list);
        protected abstract List<DataItem> Order(List<DataItem> list);
    }

    public enum InsertResult
    {
        Success,
        Repeate
    }

    public enum DeleteResult
    {
        Success,
        NotFound
    }

   //public interface IDataBase
   //{
   //    InsertResult Insert(DataItem dataItem);
   //    DeleteResult Delete(DataItem dataItem);
   //    IndexItem GetIndexItem(DataItem dataItem);
   //}

  
}
