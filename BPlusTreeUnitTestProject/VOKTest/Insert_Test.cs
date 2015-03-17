using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPlusTree;
using BPlusTree.DataItems;

namespace BPlusTreeUnitTestProject.VOKTest
{
    [TestClass]
    public class Insert_Test
    {
        [TestMethod]
        public void VOK_Insert_Check_Order()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new VOK<string, string, string>(2,2,new StringStringStringHost(2,2));

            var input1 = new StringStringStringDataItem("1","2","3") ;
            db.Insert(input1);

            var input2 = new StringStringStringDataItem("2","1","3") ;
            db.Insert(input2);

            var input3 = new StringStringStringDataItem("3","2","1") ;
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input3));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }
    }
}
