using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPlusTree;

namespace BPlusTreeUnitTestProject.HostTest
{
    [TestClass]
    public class Host_Insert_Test
    {
        [TestMethod]
        public void Host_Insert_First_Data()
        {
            int maxDataBlockItemCount = 2;
            Host host = new Host(maxDataBlockItemCount);
             var input = new DataItem { ID = "1", Key = "2", Value = "3" };
             host.Insert(input);
           
             foreach (var db in host.DataBases)
             {
                 Assert.AreEqual(1, db.IndexLeafItemCount);//索引数量
                 Assert.AreEqual(1, db.DataItemCount);//数据总量
                 Assert.AreEqual(input, db.IndexItemList[0].DataItem);//输入==保存的
                 Assert.AreEqual(input, db.IndexItemList[0].DataBlock.DataItemList[0]);//输入值就是索引的值
             }
        }

        [TestMethod]
        public void Host_Insert_Check_Order()
        {
            int maxDataBlockItemCount = 2;
            Host host = new Host(maxDataBlockItemCount);
            var input = new DataItem { ID = "1", Key = "2", Value = "3" };
            host.Insert(input);
            host.Insert(new DataItem { ID = "2", Key = "1", Value = "3" });
            host.Insert(new DataItem { ID = "3", Key = "2", Value = "1" });

            foreach (var db in host.DataBases)
            {
                //Assert.AreEqual(1, db.IndexLeafItemCount);//索引数量
                //Assert.AreEqual(1, db.DataItemCount);//数据总量
                //Assert.AreEqual(input, db.IndexItemList[0].DataItem);//输入==保存的
                //Assert.AreEqual(input, db.IndexItemList[0].DataBlock.DataItemList[0]);//输入值就是索引的值
            }
        }
    }
}
