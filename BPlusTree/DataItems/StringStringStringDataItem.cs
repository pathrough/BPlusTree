using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree.DataItems
{
    public class StringStringStringDataItem : DataItem<string, string, string>
    {
        public override byte[] ToBytes()
        {
            List<byte> bsList = new List<byte>();
            bsList.AddRange(ID.ToBytes());
            bsList.AddRange(Key.ToBytes());
            bsList.AddRange(Value.ToBytes());
            return bsList.ToArray();
        }

        //public override DataItem<string, string, string> ToDataItem(byte[] bs)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
