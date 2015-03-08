using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPlusTree;
namespace BPlusTreeUnitTestProject.KVOTest
{
    [TestClass]
    public class Insert_Test
    {
        [TestMethod]
        public void KVO_Insert_Check_Order()
        {
            int maxDataBlockItemCount = 2;
            DataBase db = new KVO(maxDataBlockItemCount);

            var input1 = new DataItem { ID = "1", Key = "2", Value = "3" };
            db.Insert(input1);

            var input2 = new DataItem { ID = "2", Key = "1", Value = "3" };
            db.Insert(input2);

            var input3 = new DataItem { ID = "3", Key = "2", Value = "1" };
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input2));
            Assert.IsTrue(db.DataItemList[1].Equals(input3));
            Assert.IsTrue(db.DataItemList[2].Equals(input1));
        }
    }
}
