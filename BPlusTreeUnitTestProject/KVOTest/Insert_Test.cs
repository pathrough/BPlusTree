using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPlusTree;
using BPlusTree.DataItems;
namespace BPlusTreeUnitTestProject.KVOTest
{
    [TestClass]
    public class Insert_Test
    {
        [TestMethod]
        public void KVO_Insert_Check_Order_1()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);
            Assert.IsTrue(db.DataItemList[0].Equals(input0));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_2_1()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);
            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);
            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_2_2()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_3_0_1()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }


        [TestMethod]
        public void KVO_Insert_Check_Order_3_0_2()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_3_1_0()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_3_1_2()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_3_2_0()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_3_2_1()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_0_1_2_3()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_0_1_3_2()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }


        [TestMethod]
        public void KVO_Insert_Check_Order_4_0_2_1_3()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);


            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_0_2_3_1()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_0312()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);
            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);
            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);
            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_0321()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);
            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);
            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);


            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_1023()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);
            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_1032()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);


            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_1203()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_1230()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_2013()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);
            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        [TestMethod]
        public void KVO_Insert_Check_Order_4_2031()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new KVO<string, string, string>(2,2);

            var input2 = new StringStringStringItem { ID = "2", Key = "2", Value = "2" };
            db.Insert(input2);
            var input0 = new StringStringStringItem { ID = "0", Key = "0", Value = "0" };
            db.Insert(input0);
            var input3 = new StringStringStringItem { ID = "3", Key = "3", Value = "3" };
            db.Insert(input3);
            var input1 = new StringStringStringItem { ID = "1", Key = "1", Value = "1" };
            db.Insert(input1);

            Assert.IsTrue(db.DataItemList[0].Equals(input0));
            Assert.IsTrue(db.DataItemList[1].Equals(input1));
            Assert.IsTrue(db.DataItemList[2].Equals(input2));
            Assert.IsTrue(db.DataItemList[3].Equals(input3));
        }

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_2103()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_2130()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_3012()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);


        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_3021()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);


        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_3102()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);


        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_3120()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);


        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_3201()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);


        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_3210()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);


        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_01234()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_01243()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_01324()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_01342()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_01423()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_01432()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_02134()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_02143()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_02314()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_02341()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_02413()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_02431()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_03124()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_03142()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_03214()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_03241()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_03412()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_03421()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_04123()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_04132()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_04213()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_04231()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);



        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_04312()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_04321()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_10234()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_10243()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_10324()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_10342()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_10423()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_10432()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_12034()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_12043()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_12304()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_12340()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);



        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_12403()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_12430()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_13024()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_13042()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_13204()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_13240()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_13402()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);


        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_13420()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);


        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_14023()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_14032()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_14203()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
            
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_14230()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
           

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_14302()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
            
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_14320()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
            
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_20134()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_20143()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
            
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_20314()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
            

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_20341()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_20413()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
            
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_20431()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
           
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_21034()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
          
            

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_21043()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
            
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_21304()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
            

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_21340()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_21403()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
            
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_21430()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
            
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_23014()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
            

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_23041()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_23104()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
           

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_23140()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
           


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_23401()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
           
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_23410()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
           

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_30124()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
            
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_30142()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
          
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_30214()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
            

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_30241()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_30412()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
           

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_30421()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_31024()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
           
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
           

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_31042()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_31204()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);

            

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_31240()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
           
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_31402()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
           

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_31420()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_32014()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
            
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_32041()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
           

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}

        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_32104()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
           


        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_32140()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
            

        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_32401()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);
           
        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);

        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        //[TestMethod]
        //public void KVO_Insert_Check_Order_4_32410()
        //{
        //    int maxDataBlockItemCount = 2;
        //    DataBase db = new KVO(2,2);
        //    var input3 = new DataItem { ID = "3", Key = "3", Value = "3" };
        //    db.Insert(input3);
        //    var input2 = new DataItem { ID = "2", Key = "2", Value = "2" };
        //    db.Insert(input2);

        //    var input4 = new DataItem { ID = "4", Key = "4", Value = "4" };
        //    db.Insert(input4);
        //    var input1 = new DataItem { ID = "1", Key = "1", Value = "1" };
        //    db.Insert(input1);
        //    var input0 = new DataItem { ID = "0", Key = "0", Value = "0" };
        //    db.Insert(input0);
            
        //    Assert.IsTrue(db.DataItemList[0].Equals(input0));
        //    Assert.IsTrue(db.DataItemList[1].Equals(input1));
        //    Assert.IsTrue(db.DataItemList[2].Equals(input2));
        //    Assert.IsTrue(db.DataItemList[3].Equals(input3));
        //    Assert.IsTrue(db.DataItemList[4].Equals(input4));
        //}
        
    }
}
