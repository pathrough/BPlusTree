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
}
