using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class IndexItem
    {
        public IndexItem(DataBase dataBase, DataBlock dataBlock, DataItem dataItem)
        {
            _DataBase = dataBase;
            _DataBlock = dataBlock;
            _DataItem = dataItem;
        }

        readonly DataBase _DataBase;
        public DataBase DataBase
        {
            get
            {
                return _DataBase;
            }
        }

        readonly DataBlock _DataBlock;
        public DataBlock DataBlock
        {
            get
            {
                return _DataBlock;
            }
        }
        DataItem _DataItem;
        public DataItem DataItem
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
