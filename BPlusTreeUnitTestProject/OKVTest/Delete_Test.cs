using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPlusTree;

namespace BPlusTreeUnitTestProject.OKVTest
{
    [TestClass]
    public class Delete_Test
    {
        [TestMethod]
        public void Delete_The_Only_Data()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new OKV<string, string, string>(maxDataBlockItemCount);
            var input = new DataItem<string, string, string> { ID = "0", Key = "0", Value = "0" };
            db.Insert(input);
            db.Delete(input);
            Assert.AreEqual(0, db.DataItemCount);
            Assert.AreEqual(0, db.IndexLeafItemCount);
        }

        [TestMethod]
        public void Delete_Not_Exists_Data()
        {
            int maxDataBlockItemCount = 2;
            DataBase<string, string, string> db = new OKV<string, string, string>(maxDataBlockItemCount);

            db.Insert(new DataItem<string, string, string> { ID = "0", Key = "0", Value = "0" });
            var result = db.Delete(new DataItem<string, string, string> { ID = "1", Key = "1", Value = "1" });
            Assert.AreEqual(DeleteResult.NotFound, result);
            Assert.AreEqual(1, db.DataItemCount);
            Assert.AreEqual(1, db.IndexLeafItemCount);
        }
    }
}
