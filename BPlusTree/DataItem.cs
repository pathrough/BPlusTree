using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public abstract class DataItem<O, K, V> : IEquatable<DataItem<O, K, V>>
        where O : IComparable<O>
        where K : IComparable<K>
        where V : IComparable<V>
        //where O : IEquatable<O>
        //where K : IEquatable<K>
        //where V : IEquatable<V>
    {
        public O ID { get; set; }
        public K Key { get; set; }
        public V Value { get; set; }

        public bool Equals(DataItem<O, K, V> other)
        {
            return this.ID.Equals(other.ID) && this.Key.Equals(other.Key) && this.Value.Equals(other.Value);
        }

        public abstract byte[] ToBytes();
        //public abstract DataItem<O, K, V> ToDataItem(byte[] bs);
    }

    public enum OperationType
    {
        Insert,
        Delete
    }
    public class DataItemLog<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        public OperationType Operation { get; set; }
        public DataItem<O, K, V> DataItem { get; set; }
        public DataItemLog(DataItem<O, K, V> dataItem, OperationType operation)
        {
            this.Operation = operation;
            this.DataItem = dataItem;
        }
    }


    public class DataBlock<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        public DataBlock(DataBase<O, K, V> dataBase, List<DataItem<O, K, V>> dataItemList,long position)
        {
            this._DataBase = dataBase;
            _DataItemList = dataItemList;
            _Position = position;
        }
        private List<DataItem<O, K, V>> _DataItemList = new List<DataItem<O, K, V>>();
        public List<DataItem<O, K, V>> DataItemList
        {
            get { return _DataItemList; }
            set { _DataItemList = value; }
        }

        public int MaxItemCount
        {
            get
            {
                return this.DataBase.MaxDataBlockItemCount;
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
                return this.DataItemList.Count;
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
            foreach (var data in DataItemList)
            {
                bsList.AddRange(data.ToBytes());
            }
            return bsList.ToArray();
        }
    }
    
}
