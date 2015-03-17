using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPlusTree;
using BPlusTree.DataItems;

namespace BPlusTreeUnitTestProject.OKVTest
{
    [TestClass]
    public class Insert_Test
    {

        [TestMethod]
        public void Insert_First_Data()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new OKV<string, string, string>(2,2);
            var input = new StringStringStringDataItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);
            Assert.AreEqual(1, db.IndexLeafItemCount);//索引数量
            Assert.AreEqual(1, db.DataItemCount);//数据总量
            Assert.AreEqual(input, db.IndexItemList[0].DataItem);//输入==保存的
            Assert.AreEqual(input, db.IndexItemList[0].DataBlock.DataItemList[0]);//输入值就是索引的值
        }

        [TestMethod]
        public void Insert_Repeate()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new OKV<string, string, string>(2,2);
            var input = new StringStringStringDataItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);

            var input2 = new StringStringStringDataItem { ID = "0", Key = "0", Value = "0" };
            InsertResult result = db.Insert(input2);
            Assert.AreEqual(InsertResult.Repeate, result);

            Assert.AreEqual(1, db.IndexLeafItemCount);//索引数量
            Assert.AreEqual(1, db.DataItemCount);//数据总量
            Assert.AreEqual(input, db.IndexItemList[0].DataItem);//输入==保存的
            Assert.AreEqual(input, db.IndexItemList[0].DataBlock.DataItemList[0]);//输入值就是索引的值
        }

        [TestMethod]
        public void Insert_Change_IndexValue()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new OKV<string, string, string>(2,2);
            var input = new StringStringStringDataItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);
            Assert.AreEqual(1, db.IndexLeafItemCount);//索引数量
            Assert.AreEqual(1, db.DataItemCount);//数据总量
            Assert.AreEqual(input, db.IndexItemList[0].DataItem);//输入==保存的

            var input2 = new StringStringStringDataItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input2);
            Assert.AreEqual(1, db.IndexLeafItemCount);//索引数量
            Assert.AreEqual(2, db.DataItemCount);//数据总量
            Assert.AreEqual(input2, db.IndexItemList[0].DataItem);//输入==保存的
        }

        //插入重复

        [TestMethod]
        public void Insert_Splite_Into_Two_Blocks()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new OKV<string, string, string>(2,2);
            var input = new StringStringStringDataItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);
            db.Insert(new StringStringStringDataItem { ID = "1", Key = "1", Value = "1" });
            db.Insert(new StringStringStringDataItem { ID = "2", Key = "2", Value = "2" });

            Assert.AreEqual(2, db.IndexLeafItemCount);//索引数量
            Assert.AreEqual(3, db.DataItemCount);//数据总量
        }

        [TestMethod]
        public void OKV_Insert_Check_Order()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new OKV<string, string, string>(2,2);

            var input1 = new StringStringStringDataItem { ID = "1", Key = "2", Value = "3" };
            db.Insert(input1);

            var input2 = new StringStringStringDataItem { ID = "2", Key = "1", Value = "3" };
            db.Insert(input2);

            var input3 = new StringStringStringDataItem { ID = "3", Key = "2", Value = "1" };
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input1));
            Assert.IsTrue(db.DataItemList[1].Equals(input2));
            Assert.IsTrue(db.DataItemList[2].Equals(input3));
        }
    }
}
