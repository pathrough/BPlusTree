﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPlusTree;

namespace BPlusTreeUnitTestProject.OKVTest
{
    [TestClass]
    public class Insert_Test
    {

        [TestMethod]
        public void Insert_First_Data()
        {
            int maxDataBlockItemCount = 2;
            DataBase db = new OKV(maxDataBlockItemCount);
            var input = new DataItem { ID = "0", Key = "0", Value = "0" };
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
            DataBase db = new OKV(maxDataBlockItemCount);
            var input = new DataItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);

            var input2 = new DataItem { ID = "0", Key = "0", Value = "0" };
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
            DataBase db = new OKV(maxDataBlockItemCount);
            var input = new DataItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);
            Assert.AreEqual(1, db.IndexLeafItemCount);//索引数量
            Assert.AreEqual(1, db.DataItemCount);//数据总量
            Assert.AreEqual(input, db.IndexItemList[0].DataItem);//输入==保存的

            var input2 = new DataItem { ID = "1", Key = "1", Value = "1" };
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
            DataBase db = new OKV(maxDataBlockItemCount);
            var input = new DataItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);
            db.Insert(new DataItem { ID = "1", Key = "1", Value = "1" });
            db.Insert(new DataItem { ID = "2", Key = "2", Value = "2" });

            Assert.AreEqual(2, db.IndexLeafItemCount);//索引数量
            Assert.AreEqual(3, db.DataItemCount);//数据总量
        }
    }
}
