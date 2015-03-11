using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public abstract class DataBase<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        public DataBase(int maxDataBlockItemCount,int maxIndexBlockItemCount)
        {
            _MaxDataBlockItemCount = maxDataBlockItemCount;
            _MaxIndexBlockItemCount = maxIndexBlockItemCount;
            _IndexPath = "index";
            _DataPath = "data";
            _IndexBlockSize = 128;
            _DataBlockSize = 128;
        }
        readonly int _MaxDataBlockItemCount;
        public int MaxDataBlockItemCount
        {
            get
            {
                return _MaxDataBlockItemCount;
            }
        }
        readonly int _MaxIndexBlockItemCount;
        public int MaxIndexBlockItemCount
        {
            get
            {
                return _MaxIndexBlockItemCount;
            }
        }
        private List<IndexItem<O, K, V>> _IndexItemList;
        public List<IndexItem<O, K, V>> IndexItemList
        {
            get 
            {
                _IndexItemList = new List<IndexItem<O, K, V>>();
                foreach(var item in this.IndexBlockList)
                {
                    _IndexItemList.AddRange(item.IndexItemList);
                }
                return _IndexItemList; 
            }
        }

        List<IndexBlock<O, K, V>> _IndexBlockList=new List<IndexBlock<O,K,V>>();

        /// <summary>
        /// 实际上无法初始化全部的块list，一般用next
        /// </summary>
        public List<IndexBlock<O, K, V>> IndexBlockList
        {
            get 
            {
                _IndexBlockList = new List<IndexBlock<O, K, V>>();
                //从文件读取数据
                using (FileStream fs = new FileStream(this.IndexPath, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    //todo:块大小IndexBlockList
                    //读一块数据
                }
                return _IndexBlockList; 
            }
        }

        readonly IndexBlock<O, K, V> _RootIndexBlock;

        /// <summary>
        /// 根索引块,数据访问的入口
        /// </summary>
        public IndexBlock<O, K, V> RootIndexBlock
        {
            get 
            {
                //todo:从文件中读取数据初始化，根索引块，所有数据查询都是从这里开始的
                return _RootIndexBlock; 
            }
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

        public InsertResult Insert(DataItem<O, K, V> dataItem)
        {
            IndexItem<O, K, V> indexItem = GetIndexItem(dataItem);
            if (indexItem != null)
            {
                //数据块有数据
                if (indexItem.DataItem.Equals(dataItem))
                {
                    return InsertResult.Repeate;//重复的不插入
                }
                else
                {
                   
                    if (indexItem.DataBlock.DataItemList.Count < indexItem.DataBlock.MaxItemCount)
                    {
                        //数据块没满
                        indexItem.DataBlock.DataItemList.Add(dataItem);
                        indexItem.DataBlock.DataItemList = Order(indexItem.DataBlock.DataItemList);//重新排序 todo
                        indexItem.DataItem = indexItem.DataBlock.DataItemList.Last();
                    }
                    else
                    {
                        //数据块已经满，分裂数据块
                        indexItem.DataBlock.DataItemList.Add(dataItem);
                        indexItem.DataBlock.DataItemList = Order(indexItem.DataBlock.DataItemList);//重新排序 todo

                        int sourceCount = indexItem.DataBlock.DataItemList.Count;
                        var sourceList = indexItem.DataBlock.DataItemList;

                        int half = (int)(sourceCount / 2);
                        var part1 = sourceList.Take(half).ToList();
                        var part2 = sourceList.Skip(half).Take(sourceCount - half).ToList();
                        indexItem.DataBlock.DataItemList = part1;
                        indexItem.DataItem = part1.Last();

                        //新建索引
                        IndexBlock<O, K, V> indexBlock;
                       
                        if(indexItem.IndexBlock.IndexItemList.Count==this.MaxIndexBlockItemCount)
                        {
                            //索引块已满，新增索引块
                            indexBlock = new IndexBlock<O, K, V>(this
                                , new List<IndexItem<O, K, V>>()
                                , indexItem.IndexBlock.Position + 1);
                            this.IndexBlockList.Add(indexBlock);
                        }
                        else
                        {
                            //索引块没满，获取当前索引块
                            indexBlock = indexItem.IndexBlock;
                            ////保证索引是排序的
                            //this.IndexItemList = Order(IndexItemList);
                        }

                        //新建数据块
                        var dataBlock = new DataBlock<O, K, V>(this
                            , part2
                            , indexItem.DataBlock.Position + 1);

                        var dataItemForIndex = Order(part2).Last();
                        //新建索引
                        var newIndexItem = new IndexItem<O, K, V>(this, dataBlock, dataItemForIndex, indexBlock);
                        indexBlock.IndexItemList.Add(newIndexItem);

                        //保存
                        WriteIndex(indexBlock);
                        WriteData(newIndexItem.DataBlock);
                    }
                }
            }
            else
            {//数据库没有数据                

                //新建数据块
                var newDataBlock = new DataBlock<O, K, V>(this, new List<DataItem<O, K, V>> { dataItem }, 0);

                //新建索引块
                var newIndexBlock = new IndexBlock<O, K, V>(this,new List<IndexItem<O,K,V>>(),0);
                
                //新建索引
                indexItem = new IndexItem<O, K, V>(this,newDataBlock,dataItem,newIndexBlock);

                //指定关系
                this.IndexBlockList.Add(newIndexBlock);
                newIndexBlock.IndexItemList.Add(indexItem);

                //持久化
                WriteIndex(newIndexBlock);
                WriteData(newDataBlock);
            }
            return InsertResult.Success;
        }

        readonly string _IndexPath;

        public string IndexPath
        {
            get { return _IndexPath; }
        }

        readonly int _IndexBlockSize;

        public int IndexBlockSize
        {
            get { return _IndexBlockSize; }
        }

        readonly int _DataBlockSize;
        public int DataBlockSize
        {
            get { return _DataBlockSize; }
        } 


        readonly string _DataPath;

        public string DataPath
        {
            get { return _DataPath; }
        }

        void WriteData(DataBlock<O, K, V> block)
        {
            byte[] bs = block.ToBytes();
            using (FileStream fs = new FileStream(this.DataPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(block.Position, SeekOrigin.Begin);
                fs.Write(bs, 0, bs.Length);
            }
        }

        void WriteIndex(IndexBlock<O, K, V> block)
        {
            byte[] bs = block.ToBytes();
            using (FileStream fs = new FileStream(this.IndexPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(block.Position, SeekOrigin.Begin);
                fs.Write(bs, 0, bs.Length);
            }
        }

        /// <summary>
        /// 删除后可能导致数据页变得极少，最后数据分散
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        public DeleteResult Delete(DataItem<O, K, V> dataItem)
        {
            IndexItem<O, K, V> targetIndexItem = GetIndexItem(dataItem);
            if (targetIndexItem == null)
            {
                return DeleteResult.NotFound;//找不到
            }
            else
            {
                DataItem<O, K, V> targetDataItem = null;//find the target to delete
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
                    DataBlock<O,K,V> targetDataBlock = targetIndexItem.DataBlock;
                    IndexBlock<O, K, V> targetIndexBlock = targetIndexItem.IndexBlock;
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
                        targetIndexBlock.IndexItemList.Remove(targetIndexItem);
                    }
                    WriteIndex(targetIndexBlock);
                    WriteData(targetDataBlock);
                }
                else
                {
                    return DeleteResult.NotFound;//找不到
                }
                return DeleteResult.Success;
            }
        }

        List<DataItem<O, K, V>> _DataItemList = null;
        public List<DataItem<O, K, V>> DataItemList
        {
            get
            {
                _DataItemList = new List<DataItem<O, K, V>>();
                foreach(var item in this.IndexItemList)
                {
                    _DataItemList.AddRange(item.DataBlock.DataItemList);
                }
                return _DataItemList;
            }
        }

        protected abstract IndexItem<O, K, V> GetIndexItem(DataItem<O, K, V> dataItem);

        protected abstract List<IndexItem<O, K, V>> Order(List<IndexItem<O, K, V>> list);
        protected abstract List<DataItem<O, K, V>> Order(List<DataItem<O, K, V>> list);
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
}
