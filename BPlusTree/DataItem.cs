using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class DataItem:IEquatable<DataItem>
    {
        public string ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public bool Equals(DataItem other)
        {
            return this.ID.Equals(other.ID) && this.Key.Equals(other.Key) && this.Value.Equals(other.Value);
        }
    }

    public enum OperationType
    {
        Insert,
        Delete
    }
    public class DataItemLog
    {
        public OperationType Operation { get; set; }
        public DataItem DataItem { get; set; }
        public DataItemLog(DataItem dataItem, OperationType operation)
        {
            this.Operation = operation;
            this.DataItem = dataItem;
        }
    }

   
    public class DataBlock
    {
        public DataBlock(DataBase dataBase,List<DataItem> dataItemList)
        {
            this._DataBase = dataBase;
            _DataItemList = dataItemList;
        }
        private List<DataItem> _DataItemList = new List<DataItem>();
        public List<DataItem> DataItemList
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

        readonly DataBase _DataBase;
        public DataBase DataBase
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
    }
    
}
