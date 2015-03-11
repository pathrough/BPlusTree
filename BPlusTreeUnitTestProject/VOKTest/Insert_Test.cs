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
            DataBase<string, string, string> db = new VOK<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "2", Value = "3" };
            db.Insert(input1);

            var input2 = new StringStringStringItem { ID = "2", Key = "1", Value = "3" };
            db.Insert(input2);

            var input3 = new StringStringStringItem { ID = "3", Key = "2", Value = "1" };
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input3));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }
    }
}
