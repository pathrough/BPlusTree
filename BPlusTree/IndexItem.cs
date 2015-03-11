using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class IndexItem<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        public IndexItem(DataBase<O, K, V> dataBase, DataBlock<O, K, V> dataBlock, DataItem<O, K, V> dataItem, IndexBlock<O, K, V> indexBlock)
        {
            _DataBase = dataBase;
            _DataBlock = dataBlock;
            _DataItem = dataItem;
            _IndexBlock = indexBlock;
        }

        readonly DataBase<O, K, V> _DataBase;
        public DataBase<O, K, V> DataBase
        {
            get
            {
                return _DataBase;
            }
        }

        readonly DataBlock<O, K, V> _DataBlock;
        public DataBlock<O, K, V> DataBlock
        {
            get
            {
                return _DataBlock;
            }
        }

        readonly IndexBlock<O, K, V> _IndexBlock;
        public IndexBlock<O, K, V> IndexBlock
        {
            get
            {
                return _IndexBlock;
            }
        }

        readonly IndexBlock<O, K, V> _TargetIndexBlock;

        /// <summary>
        /// 如果不是叶索引，指向的不是数据块，而是索引块，就用这个
        /// </summary>
        public IndexBlock<O, K, V> TargetIndexBlock
        {
            get 
            { 
                //todo:TargetIndexBlock
                return _TargetIndexBlock;
            }
        } 


        DataItem<O, K, V> _DataItem;
        public DataItem<O, K, V> DataItem
        {
            get
            {
                return _DataItem;
            }
            set
            {
                _DataItem = value;
            }
        }//最大值

        public byte[] ToBytes()
        {
            List<byte> bsList = new List<byte>();
            bsList.AddRange(this.DataBlock.Position.ToBytes());
            bsList.AddRange(this.DataItem.ToBytes());
            return new byte[0];
        }
    }

    public class IndexBlock<O,K,V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        public IndexBlock(DataBase<O, K, V> dataBase, List<IndexItem<O, K, V>> indexItemList,long position)
        {
            this._DataBase = dataBase;
            _IndexItemList = indexItemList;
            _Position = position;
        }

        IndexBlock<O, K, V> _Next;

        public IndexBlock<O, K, V> Next
        {
            get 
            {
                //todo:Next IndexBlock
                return _Next; 
            }
        }

        private List<IndexItem<O, K, V>> _IndexItemList = new List<IndexItem<O, K, V>>();
        public List<IndexItem<O, K, V>> IndexItemList
        {
            get { return _IndexItemList; }
            set { _IndexItemList = value; }
        }

        public int MaxItemCount
        {
            get
            {
                return this.DataBase.MaxIndexBlockItemCount;
            }
        }

        readonly DataBase<O, K, V> _DataBase;
        public DataBase<O, K, V> DataBase
        {
            get
            {
                return _DataBase;
            }
        }

        public int Count
        {
            get
            {
                return this.IndexItemList.Count;
            }
        }

        long _Position;
        public long Position
        {
            get
            {
                return _Position;
            }
        }

        public byte[] ToBytes()
        {
            List<byte> bsList = new List<byte>();
            
            foreach(var index in this.IndexItemList)
            {
                bsList.AddRange(index.ToBytes());
            }
            return new byte[0];
        }
    }
}
