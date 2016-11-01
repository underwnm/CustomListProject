using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddItemToList()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            int first = 1;
            int second = 2;
            int third = 3;
            //Act
            customList.Add(first);
            customList.Add(second);
            customList.Add(third);
            //Assert
            Assert.AreEqual(first, customList.ReturnAt(0));
            Assert.AreEqual(second, customList.ReturnAt(1));
            Assert.AreEqual(third, customList.ReturnAt(2));
        }
        [TestMethod]
        public void RemoveAllOfItemInList()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            customList.Add(2);
            customList.Add(2);
            customList.Add(1);
            customList.Add(2);
            //Act
            customList.Remove(2);
            //Assert
            Assert.AreEqual(1, customList.ReturnAt(0));
        }
        [TestMethod]
        public void RemoveAtIndexInList()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            //Act
            customList.RemoveAt(0);
            //Assert
            Assert.AreEqual(2, customList.ReturnAt(0));
        }
        [TestMethod]
        public void GetCountOfList()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            //Act
            int count = customList.Count();
            //Assert
            Assert.AreEqual(3, count);
        }
        [TestMethod]
        public void ListToString()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            //Act
            string results = customList.ToString();
            //Assert
            Assert.AreEqual("123", results);
        }
        [TestMethod]
        public void ZipperTwoLists()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            //Arrange
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList.Add(7);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            customList2.Add(8);
            customList2.Add(9);
            //Act
            customList3 = customList.Zipper(customList2);
            //Assert
            Assert.AreEqual(1, customList3.ReturnAt(0));
            Assert.AreEqual(2, customList3.ReturnAt(1));
            Assert.AreEqual(3, customList3.ReturnAt(2));
            Assert.AreEqual(4, customList3.ReturnAt(3));
            Assert.AreEqual(5, customList3.ReturnAt(4));
            Assert.AreEqual(6, customList3.ReturnAt(5));
            Assert.AreEqual(7, customList3.ReturnAt(6));
            Assert.AreEqual(8, customList3.ReturnAt(7));
        }
        [TestMethod]
        public void OverloadPlusOperator()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            //Arrange
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList.Add(7);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            customList2.Add(8);
            customList2.Add(9);
            //Act
            customList3 = customList + customList2;
            //Assert
            Assert.AreEqual(1, customList3.ReturnAt(0));
            Assert.AreEqual(3, customList3.ReturnAt(1));
            Assert.AreEqual(5, customList3.ReturnAt(2));
            Assert.AreEqual(7, customList3.ReturnAt(3));
            Assert.AreEqual(2, customList3.ReturnAt(4));
            Assert.AreEqual(4, customList3.ReturnAt(5));
            Assert.AreEqual(6, customList3.ReturnAt(6));
            Assert.AreEqual(8, customList3.ReturnAt(7));
            Assert.AreEqual(9, customList3.ReturnAt(8));
        }
        [TestMethod]
        public void OverloadMinusOperator()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            //Arrange
            customList.Add(1);
            customList.Add(1);
            customList.Add(5);
            customList.Add(7);
            customList2.Add(1);
            customList2.Add(4);
            customList2.Add(1);
            customList2.Add(8);
            customList2.Add(1);
            //Act
            customList3 = customList - customList2;
            //Assert
            Assert.AreEqual(5, customList3.ReturnAt(0));
            Assert.AreEqual(7, customList3.ReturnAt(1));
        }
    }
}
