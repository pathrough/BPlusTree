using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class IndexItem
    {
        public DataBlock DataBlock { get; set; }
        public DataItem DataItem { get; set; }//最大值
    }
}
