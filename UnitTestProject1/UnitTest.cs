using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddIntItemToList()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            int value1 = customList.ReturnAt(0);
            int value2 = customList.ReturnAt(1);
            int value3 = customList.ReturnAt(2);
            Assert.AreEqual(1, value1);
            Assert.AreEqual(2, value2);
            Assert.AreEqual(3, value3);
        }
        [TestMethod]
        public void RemoveAllOfItemInList()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(2);
            customList.Add(2);
            customList.Add(1);
            customList.Add(2);
            customList.Add(2);
            customList.Add(2);
            customList.Remove(2);
            Assert.AreEqual(1, customList.ReturnAt(0));
        }
        [TestMethod]
        public void RemoveAtIndexInList()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.RemoveAt(0);
            Assert.AreEqual(2, customList.ReturnAt(0));
        }
        [TestMethod]
        public void GetCountOfList()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            Assert.AreEqual(3, customList.Count());
        }
        [TestMethod]
        public void GetListToString()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            Assert.AreEqual("123", customList.ToString());
        }
        [TestMethod]
        public void ZipperTwoLists()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList.Add(7);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            customList2.Add(8);
            customList2.Add(9);
            customList.Zipper(customList2);
            Assert.AreEqual(1, customList.ReturnAt(0));
            Assert.AreEqual(2, customList.ReturnAt(1));
            Assert.AreEqual(3, customList.ReturnAt(2));
            Assert.AreEqual(4, customList.ReturnAt(3));
            Assert.AreEqual(5, customList.ReturnAt(4));
            Assert.AreEqual(6, customList.ReturnAt(5));
            Assert.AreEqual(7, customList.ReturnAt(6));
            Assert.AreEqual(8, customList.ReturnAt(7));
            Assert.AreEqual(9, customList.ReturnAt(8));
        }
    }
}
