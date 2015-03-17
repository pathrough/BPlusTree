using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree.DataItems
{
    public class StringStringStringIndexBlock : IndexBlock<string, string, string>
    {
        public StringStringStringIndexBlock(DataBase<string, string, string> dataBase, List<IndexItem<string, string, string>> indexItemList)
            : base(dataBase, indexItemList)
        {
        }
        public StringStringStringIndexBlock(long position, DataBase<string, string, string> dataBase):base(position,dataBase)
        {
        }
        protected override IndexItem<string, string, string> CreateIndexItem(byte[] bs)
        {
            return new StringStringStringIndexItem(bs);
        }
    }
}
