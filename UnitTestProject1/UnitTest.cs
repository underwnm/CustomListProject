using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddIntItemToList()
        {
            CustomList<int> results = new CustomList<int>();
            //Arrange
            int first = 1;
            int second = 2;
            int third = 3;
            //Act
            results.Add(first);
            results.Add(second);
            results.Add(third);
            //Assert
            Assert.AreEqual(first, results[0]);
            Assert.AreEqual(second, results[1]);
            Assert.AreEqual(third, results[2]);
        }
        [TestMethod]
        public void AddStringItemToList()
        {
            CustomList<string> results = new CustomList<string>();
            //Arrange
            string first = "1";
            string second = "2";
            string third = "3";
            //Act
            results.Add(first);
            results.Add(second);
            results.Add(third);
            //Assert
            Assert.AreEqual(first, results[0]);
            Assert.AreEqual(second, results[1]);
            Assert.AreEqual(third, results[2]);
        }
        [TestMethod]
        public void AddCustomObjectItemToList()
        {
            CustomList<Item> results = new CustomList<Item>();
            //Arrange
            Item first = new Item("first");
            Item second = new Item("second");
            Item third = new Item("third");
            //Act
            results.Add(first);
            results.Add(second);
            results.Add(third);
            //Assert
            Assert.AreEqual(first, results[0]);
            Assert.AreEqual(second, results[1]);
            Assert.AreEqual(third, results[2]);
        }
        [TestMethod]
        public void RemoveAllOfItemInIntList()
        {
            //Arrange
            CustomList<int> results = new CustomList<int>() { 2, 2, 1, 2 };
            int expected = 1;
            //Act
            results.Remove(2);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveAllOfItemInStringList()
        {
            //Arrange
            CustomList<string> results = new CustomList<string>() { "2", "2", "1", "2" };
            string expected = "1";
            //Act
            results.Remove("2");
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveAllOfItemInCustomObjectList()
        {
            //Arrange
            CustomList<Item> results = new CustomList<Item>() { new Item("first"), new Item("second"), new Item("third"), new Item("fourth") };
            Item expected = results[3];
            //Act
            results.Remove(results[2]);
            //Assert
            Assert.AreEqual(expected, results[2]);
        }
        [TestMethod]
        public void RemoveAtIndexOfIntList()
        {
            //Arrange
            CustomList<int> results = new CustomList<int>() { 1, 2, 3 };
            int expected = 2;
            //Act
            results.RemoveAt(0);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveAtIndexOfStringList()
        {
            //Arrange
            CustomList<string> results = new CustomList<string>() { "1", "2", "3" };
            string expected = "2";
            //Act
            results.RemoveAt(0);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveAtIndexOfCustomObjectList()
        {
            //Arrange
            CustomList<Item> results = new CustomList<Item>() { new Item("first"), new Item("second"), new Item("third") };
            Item expected = results[1];
            //Act
            results.RemoveAt(0);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void GetCountOfIntList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            int expected = 3;
            //Act
            int results = customList.Count();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void GetCountOfStringList()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "1", "2", "3", "4" };
            int expected = 4;
            //Act
            int results = customList.Count();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void GetCountOfCustomObjectList()
        {
            //Arrange
            CustomList<Item> customList = new CustomList<Item>() { new Item("first"), new Item("second"), new Item("third"), new Item("fourth"), new Item("fifth") };
            int expected = 5;
            //Act
            int results = customList.Count();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void ToStringAnIntList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            string expected = "123";
            //Act
            string results = customList.ToString();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void ToStringAStringList()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "1", "2", "3" };
            string expected = "123";
            //Act
            string results = customList.ToString();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void ToStringACustomObjectList()
        {
            //Arrange
            CustomList<Item> customList = new CustomList<Item>() { new Item("first"), new Item("second") };
            string expected = "UnitTestProject.ItemUnitTestProject.Item";
            //Act
            string results = customList.ToString();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void ZipperTwoIntLists()
        {
            CustomList<int> results = new CustomList<int>();
            //Arrange
            int expectedValue1 = 1;
            int expectedValue2 = 2;
            int expectedValue3 = 3;
            int expectedValue4 = 4;
            int expectedValue5 = 5;
            int expectedValue6 = 6;
            int expectedValue7 = 7;
            int expectedValue8 = 8;
            CustomList<int> oddList = new CustomList<int>() { expectedValue1, expectedValue3, expectedValue5, expectedValue7 };
            CustomList<int> evenList = new CustomList<int>() { expectedValue2, expectedValue4, expectedValue6, expectedValue8 };
            //Act
            results = oddList.Zipper(evenList);
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
        }
        [TestMethod]
        public void ZipperTwoStringLists()
        {
            CustomList<string> results = new CustomList<string>();
            //Arrange
            string expectedValue1 = "1";
            string expectedValue2 = "2";
            string expectedValue3 = "3";
            string expectedValue4 = "4";
            string expectedValue5 = "5";
            string expectedValue6 = "6";
            string expectedValue7 = "7";
            string expectedValue8 = "8";
            CustomList<string> oddList = new CustomList<string>() { expectedValue1, expectedValue3, expectedValue5, expectedValue7 };
            CustomList<string> evenList = new CustomList<string>() { expectedValue2, expectedValue4, expectedValue6, expectedValue8 };
            //Act
            results = oddList.Zipper(evenList);
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
        }
        [TestMethod]
        public void ZipperTwoCustomObjectLists()
        {
            CustomList<Item> results = new CustomList<Item>();
            //Arrange
            Item expectedValue1 = new Item("1");
            Item expectedValue2 = new Item("2");
            Item expectedValue3 = new Item("3");
            Item expectedValue4 = new Item("4");
            Item expectedValue5 = new Item("5");
            Item expectedValue6 = new Item("6");
            Item expectedValue7 = new Item("7");
            Item expectedValue8 = new Item("8");
            CustomList<Item> oddList = new CustomList<Item>() { expectedValue1, expectedValue3, expectedValue5, expectedValue7 };
            CustomList<Item> evenList = new CustomList<Item>() { expectedValue2, expectedValue4, expectedValue6, expectedValue8 };
            //Act
            results = oddList.Zipper(evenList);
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
        }
        [TestMethod]
        public void OverloadPlusOperatorForIntLists()
        {
            CustomList<int> results = new CustomList<int>();
            //Arrange
            int expectedValue1 = 1;
            int expectedValue2 = 3;
            int expectedValue3 = 5;
            int expectedValue4 = 7;
            int expectedValue5 = 2;
            int expectedValue6 = 4;
            int expectedValue7 = 6;
            int expectedValue8 = 8;
            int expectedValue9 = 10;
            CustomList<int> oddList = new CustomList<int>() { expectedValue1, expectedValue2, expectedValue3, expectedValue4 };
            CustomList<int> evenList = new CustomList<int>() { expectedValue5, expectedValue6, expectedValue7, expectedValue8, expectedValue9 };
            //Act
            results = oddList + evenList;
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
            Assert.AreEqual(expectedValue9, results[8]);
        }
        [TestMethod]
        public void OverloadPlusOperatorForStringLists()
        {
            CustomList<string> results = new CustomList<string>();
            //Arrange
            string expectedValue1 = "1";
            string expectedValue2 = "3";
            string expectedValue3 = "5";
            string expectedValue4 = "7";
            string expectedValue5 = "2";
            string expectedValue6 = "4";
            string expectedValue7 = "6";
            string expectedValue8 = "8";
            string expectedValue9 = "10";
            CustomList<string> oddList = new CustomList<string>() { expectedValue1, expectedValue2, expectedValue3, expectedValue4 };
            CustomList<string> evenList = new CustomList<string>() { expectedValue5, expectedValue6, expectedValue7, expectedValue8, expectedValue9 };
            //Act
            results = oddList + evenList;
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
            Assert.AreEqual(expectedValue9, results[8]);
        }
        [TestMethod]
        public void OverloadPlusOperatorForCustomObjectLists()
        {
            CustomList<Item> results = new CustomList<Item>();
            //Arrange
            Item expectedValue1 = new Item("1");
            Item expectedValue2 = new Item("2");
            Item expectedValue3 = new Item("3");
            Item expectedValue4 = new Item("4");
            Item expectedValue5 = new Item("5");
            Item expectedValue6 = new Item("6");
            Item expectedValue7 = new Item("7");
            Item expectedValue8 = new Item("8");
            CustomList<Item> oddList = new CustomList<Item>() { expectedValue1, expectedValue3, expectedValue5, expectedValue7 };
            CustomList<Item> evenList = new CustomList<Item>() { expectedValue2, expectedValue4, expectedValue6, expectedValue8 };
            //Act
            results = oddList + evenList;
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue3, results[1]);
            Assert.AreEqual(expectedValue5, results[2]);
            Assert.AreEqual(expectedValue7, results[3]);
            Assert.AreEqual(expectedValue2, results[4]);
            Assert.AreEqual(expectedValue4, results[5]);
            Assert.AreEqual(expectedValue6, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
        }
        [TestMethod]
        public void OverloadMinusOperatorForIntLists()
        {
            CustomList<int> results = new CustomList<int>();
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 1, 5, 7 };
            CustomList<int> customList2 = new CustomList<int>() { 1, 4, 8 };
            int expectedValue1 = 5;
            int expectedValue2 = 7;
            //Act
            results = customList - customList2;
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
        }
        [TestMethod]
        public void OverloadMinusOperatorForStringLists()
        {
            CustomList<string> results = new CustomList<string>();
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "1", "1", "5", "7" };
            CustomList<string> customList2 = new CustomList<string>() { "1", "4", "8" };
            string expectedValue1 = "5";
            string expectedValue2 = "7";
            //Act
            results = customList - customList2;
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
        }
        [TestMethod]
        public void OverloadMinusOperatorForCustomObjectLists()
        {
            CustomList<Item> results = new CustomList<Item>();
            //Arrange
            Item expectedValue1 = new Item("1");
            Item expectedValue2 = new Item("2");
            Item expectedValue3 = new Item("3");
            Item expectedValue4 = new Item("4");
            CustomList<Item> customList = new CustomList<Item>() { expectedValue1, expectedValue2, expectedValue3, expectedValue4 };
            CustomList<Item> customList2 = new CustomList<Item>() { expectedValue1, expectedValue2, expectedValue3 };
            //Act
            results = customList - customList2;
            //Assert
            Assert.AreEqual(expectedValue4, results[0]);
        }
        [TestMethod]
        public void SortIntList()
        {
            //Arrange
            CustomList<int> results = new CustomList<int>() { 2, 3, 5, 4, 8, 7, 6, 1 };
            int expectedValue1 = 1;
            int expectedValue2 = 2;
            int expectedValue3 = 3;
            int expectedValue4 = 4;
            int expectedValue5 = 5;
            int expectedValue6 = 6;
            int expectedValue7 = 7;
            int expectedValue8 = 8;
            //Act
            results.Sort();
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
        }
        [TestMethod]
        public void SortStringList()
        {
            //Arrange
            CustomList<string> results = new CustomList<string>() { "abcdefg", "abc", "a", "abcd", "abcdef", "abcde", "abcdefgh", "ab" };
            string expectedValue1 = "a";
            string expectedValue2 = "ab";
            string expectedValue3 = "abc";
            string expectedValue4 = "abcd";
            string expectedValue5 = "abcde";
            string expectedValue6 = "abcdef";
            string expectedValue7 = "abcdefg";
            string expectedValue8 = "abcdefgh";
            //Act
            results.Sort();
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
        }
        [TestMethod]
        public void SortCustomObjectList()
        {
            //Arrange
            Item expectedValue1 = new Item("1");
            Item expectedValue2 = new Item("2");
            Item expectedValue3 = new Item("3");
            Item expectedValue4 = new Item("4");
            Item expectedValue5 = new Item("5");
            Item expectedValue6 = new Item("6");
            Item expectedValue7 = new Item("7");
            Item expectedValue8 = new Item("8");
            CustomList<Item> results = new CustomList<Item>() { expectedValue4, expectedValue2, expectedValue3, expectedValue1, expectedValue8, expectedValue7, expectedValue5, expectedValue6 };
            //Act
            results.Sort();
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
            Assert.AreEqual(expectedValue3, results[2]);
            Assert.AreEqual(expectedValue4, results[3]);
            Assert.AreEqual(expectedValue5, results[4]);
            Assert.AreEqual(expectedValue6, results[5]);
            Assert.AreEqual(expectedValue7, results[6]);
            Assert.AreEqual(expectedValue8, results[7]);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OutOfRangeIndex()
        {
            //Assert
            CustomList<int> results = new CustomList<int>() { 0, 4, 8, 12, 16 };
            //Act
            int result = results[10];
        }
    }
}
