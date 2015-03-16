using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public abstract class IndexItem<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        //DataItem长度

        //DataItem

        //DataBlock位置
        //
        public IndexItem(DataBase<O, K, V> dataBase, DataBlock<O, K, V> dataBlock, DataItem<O, K, V> dataItem, IndexBlock<O, K, V> indexBlock)
        {
            _DataBase = dataBase;
            _DataBlock = dataBlock;
            _DataItem = dataItem;
            _IndexBlock = indexBlock;
        }

        public IndexItem(byte[] bsIndexItem) 
        {
            int index = 0;
            //DataItem长度
            byte[] bsLen = bsIndexItem.GetSubArray(ref index, 4);
            int len = bsLen.ToInt32();

            //DataItem
            byte[] bsDataItem = bsIndexItem.GetSubArray(ref index, len);
            this._DataItem = ToDataItem(bsDataItem);

            //DataBlock位置
            byte[] bsDataBlockPosition = bsIndexItem.GetSubArray(ref index, 8);
        }

        protected abstract DataItem<O, K, V> ToDataItem(byte[] bs);

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
            return bsList.ToArray();
        }
    }

   
}
