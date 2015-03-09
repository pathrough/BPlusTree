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
        public IndexItem(DataBase<O, K, V> dataBase, DataBlock<O, K, V> dataBlock, DataItem<O, K, V> dataItem)
        {
            _DataBase = dataBase;
            _DataBlock = dataBlock;
            _DataItem = dataItem;
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
    }
}
