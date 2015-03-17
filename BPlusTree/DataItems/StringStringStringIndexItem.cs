using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree.DataItems
{
    public class StringStringStringIndexItem : IndexItem<string, string, string>
    {
        public StringStringStringIndexItem(byte[] bsIndexItem)
            : base(bsIndexItem)
        {
        }
        public StringStringStringIndexItem(DataBase<string, string, string> dataBase, DataBlock<string, string, string> dataBlock, DataItem<string, string, string> dataItem, IndexBlock<string, string, string> indexBlock)
            : base(dataBase, dataBlock, dataItem, indexBlock)
        {
        }
        protected override DataItem<string, string, string> ToDataItem(byte[] bs)
        {
            //int index = 0;
            //int iLen = bs.GetSubArray(ref index, 4).ToInt32();
            //string id = bs.GetSubArray(ref index, iLen).ToUTF8String();
            //iLen = bs.GetSubArray(ref index, 4).ToInt32();
            //string key = bs.GetSubArray(ref index, iLen).ToUTF8String();
            //iLen = bs.GetSubArray(ref index, 4).ToInt32();
            //string value = bs.GetSubArray(ref index, iLen).ToUTF8String();
            //return new StringStringStringDataItem(id, key, value);
            return new StringStringStringDataItem(bs);
        }
    }
}
