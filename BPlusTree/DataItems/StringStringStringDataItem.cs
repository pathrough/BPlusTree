using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree.DataItems
{
    public class StringStringStringDataItem : DataItem<string, string, string>
    {
        public StringStringStringDataItem(string id,string key,string value):base(id,key,value)
        {            
        }
        public StringStringStringDataItem(byte[] bs)
            : base(bs)
        {
        }
        public override byte[] ToBytes()
        {
            List<byte> bsList = new List<byte>();
            var bsID = ID.ToBytes();
            bsList.AddRange(bsID.Length.ToBytes());
            bsList.AddRange(bsID);

            var bsKey = Key.ToBytes();
            bsList.AddRange(bsKey.Length.ToBytes());
            bsList.AddRange(bsKey);

            var bsValue = Value.ToBytes();
            bsList.AddRange(bsValue.Length.ToBytes());
            bsList.AddRange(bsValue);
            return bsList.ToArray();
        }

        protected override void InitDataItem(byte[] bs)
        {
            int index = 0;

            int iLen = bs.GetSubArray(ref index, 4).ToInt32();
            this.ID = bs.GetSubArray(ref index, iLen).ToUTF8String();

            iLen = bs.GetSubArray(ref index, 4).ToInt32();
            this.Key = bs.GetSubArray(ref index, iLen).ToUTF8String();

            iLen = bs.GetSubArray(ref index, 4).ToInt32();
            this.Value = bs.GetSubArray(ref index, iLen).ToUTF8String();
        }
    }
}
