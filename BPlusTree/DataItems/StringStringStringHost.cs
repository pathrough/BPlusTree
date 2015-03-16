using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree.DataItems
{
    public class StringStringStringHost : Host<string, string, string>
    {
        public StringStringStringHost(int maxDataBlockItemCount, int maxIndexBlockItemCount)
            : base(maxDataBlockItemCount, maxIndexBlockItemCount)
        {
        }
        public override IndexBlock<string, string, string> CreateIndexBlock(DataBase<string, string, string> dataBase, List<IndexItem<string, string, string>> indexItemList)
        {
            return new StringStringStringIndexBlock(dataBase, indexItemList);
        }

        public override IndexItem<string, string, string> CreateIndexItem(DataBase<string, string, string> dataBase, DataBlock<string, string, string> dataBlock, DataItem<string, string, string> dataItem, IndexBlock<string, string, string> indexBlock)
        {
            return new StringStringStringIndexItem(dataBase, dataBlock, dataItem, indexBlock);
        }
    }
}
