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
        public void RemoveAllOfSpecificIntItemInList()
        {
            CustomList<int> results = new CustomList<int>() { 2, 2, 1, 2 };
            //Arrange
            int expected = 1;
            //Act
            results.Remove(2);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveAllOfSpecificStringItemInList()
        {
            CustomList<string> results = new CustomList<string>() { "2", "2", "1", "2" };
            //Arrange
            string expected = "1";
            //Act
            results.Remove("2");
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveAllOfSpecificCustomObjectItemInList()
        {
            CustomList<Item> results = new CustomList<Item>() { new Item("first"), new Item("second"), new Item("third"), new Item("fourth") };
            //Arrange
            Item expected = results[3];
            //Act
            results.Remove(results[2]);
            //Assert
            Assert.AreEqual(expected, results[2]);
        }
        [TestMethod]
        public void RemoveIntAtIndexInList()
        {
            CustomList<int> results = new CustomList<int>() { 1, 2, 3 };
            //Arrange
            int expected = 2;
            //Act
            results.RemoveAt(0);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveStringAtIndexInList()
        {
            CustomList<string> results = new CustomList<string>() { "1", "2", "3" };
            //Arrange
            string expected = "2";
            //Act
            results.RemoveAt(0);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void RemoveCustomObjectAtIndexInList()
        {
            CustomList<Item> results = new CustomList<Item>() { new Item("first"), new Item("second"), new Item("third") };
            //Arrange
            Item expected = results[1];
            //Act
            results.RemoveAt(0);
            //Assert
            Assert.AreEqual(expected, results[0]);
        }
        [TestMethod]
        public void GetCountOfIntList()
        {
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            //Arrange
            int expected = 3;
            //Act
            int results = customList.Count();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void GetCountOfStringList()
        {
            CustomList<string> customList = new CustomList<string>() { "1", "2", "3", "4" };
            //Arrange
            int expected = 4;
            //Act
            int results = customList.Count();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void GetCountOfCustomObjectList()
        {
            CustomList<Item> customList = new CustomList<Item>() { new Item("first"), new Item("second"), new Item("third"), new Item("fourth"), new Item("fifth") };
            //Arrange
            int expected = 5;
            //Act
            int results = customList.Count();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void IntListToString()
        {
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            //Arrange
            string expected = "123";
            //Act
            string results = customList.ToString();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void StringListToString()
        {
            CustomList<string> customList = new CustomList<string>() { "1", "2", "3" };
            //Arrange
            string expected = "123";
            //Act
            string results = customList.ToString();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void CustomObjectListToString()
        {
            CustomList<Item> customList = new CustomList<Item>() { new Item("first"), new Item("second"), new Item("third"), new Item("fourth") };
            //Arrange
            string expected = "UnitTestProject1.ItemUnitTestProject1.ItemUnitTestProject1.ItemUnitTestProject1.Item";
            //Act
            string results = customList.ToString();
            //Assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void ZipperTwoIntLists()
        {
            CustomList<int> oddList = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> evenList = new CustomList<int>() { 2, 4, 6, 8 };
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
            CustomList<string> oddList = new CustomList<string>() { "1", "3", "5", "7" };
            CustomList<string> evenList = new CustomList<string>() { "2", "4", "6", "8" };
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
        public void OverloadPlusOperatorForIntList()
        {
            CustomList<int> oddList = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> evenList = new CustomList<int>() { 2, 4, 6, 8, 10 };
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
            int expectedValue10 = 10;
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
            Assert.AreEqual(expectedValue10, results[8]);
        }
        [TestMethod]
        public void OverloadPlusOperatorForStringList()
        {
            CustomList<string> oddList = new CustomList<string>() { "1", "3", "5", "7" };
            CustomList<string> evenList = new CustomList<string>() { "2", "4", "6", "8", "10" };
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
            string expectedValue10 = "10";
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
            Assert.AreEqual(expectedValue10, results[8]);
        }
        [TestMethod]
        public void OverloadPlusOperatorForCustomObjectList()
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
        public void OverloadMinusOperatorForIntList()
        {
            CustomList<int> customList = new CustomList<int>() { 1, 1, 5, 7 };
            CustomList<int> customList2 = new CustomList<int>() { 1, 4, 8 };
            CustomList<int> results = new CustomList<int>();
            //Arrange
            int expectedValue1 = 5;
            int expectedValue2 = 7;
            //Act
            results = customList - customList2;
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
        }
        [TestMethod]
        public void OverloadMinusOperatorForStringList()
        {
            CustomList<string> customList = new CustomList<string>() { "1", "1", "5", "7" };
            CustomList<string> customList2 = new CustomList<string>() { "1", "4", "8" };
            CustomList<string> results = new CustomList<string>();
            //Arrange
            string expectedValue1 = "5";
            string expectedValue2 = "7";
            //Act
            results = customList - customList2;
            //Assert
            Assert.AreEqual(expectedValue1, results[0]);
            Assert.AreEqual(expectedValue2, results[1]);
        }
        [TestMethod]
        public void OverloadMinusOperatorForCustomObjectList()
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
        public void SortListOfInt()
        {
            CustomList<int> results = new CustomList<int>() { 2, 3, 5, 4, 8, 7, 6, 1 };
            //Arrange
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
        public void SortListOfString()
        {
            CustomList<string> results = new CustomList<string>() { "abcdefg", "abc", "a", "abcd", "abcdef", "abcde", "abcdefgh", "ab" };
            //Arrange
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
        public void SortListOfItem()
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
    }
}
