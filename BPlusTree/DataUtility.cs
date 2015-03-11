using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public static class DataUtility
    {
        public static byte[] ToBytes(this long input)
        {
            return BitConverter.GetBytes(input);
        }

        public static byte[] ToBytes(this int input)
        {
            return BitConverter.GetBytes(input);
        }

        public static byte[] ToBytes(this string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        public static string ToUTF8String(this byte[] input)
        {
            return Encoding.UTF8.GetString(input);
        }
        //public static List<DataItem> OrderASC(this List<DataItem> dataItemList)
        //{
        //    return dataItemList.OrderBy(d => d.ID).ThenBy(d => d.Key).ThenBy(d => d.Value).ToList();
        //}

        //public static List<IndexItem> OrderASC(this List<IndexItem> indexItemList)
        //{
        //    return indexItemList.OrderBy(d => d.DataItem.ID).ThenBy(d => d.DataItem.Key).ThenBy(d => d.DataItem.Value).ToList();
        //}

    }
}
