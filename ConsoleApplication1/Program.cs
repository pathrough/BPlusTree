using BPlusTree;
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
            DataBase db = new DataBase();
            for (; ; )
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(',');
                db.Insert(new DataItem { ID = inputs[0],Key=inputs[1],Value=inputs[2]});
            }                
        }
    }
}
