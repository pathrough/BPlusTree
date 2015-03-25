using BPlusTree;
using BPlusTree.DataItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Host<string, string, string> host = new StringStringStringHost(2, 2);
            for (; ; )
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(',');
                host.Insert(new StringStringStringDataItem(inputs[0], inputs[1], inputs[2]));
                Console.WriteLine("----------------------------");
                foreach(var db in host.DataBases)
                {
                    foreach(var item in db.DataItemList )
                    {
                        Console.WriteLine(item.ID+"-"+item.Key+"-"+item.Value);
                    }
                    Console.WriteLine("------------dd----------------");
                }
            }                
        }
    }
}
