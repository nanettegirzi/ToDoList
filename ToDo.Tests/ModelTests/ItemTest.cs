using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);

            string result = newItem.GetDescription();

            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
            string description01 = "Walk the dog";
            string description02 = "Wash the dishes";
            Item newItem1 = new Item(description01);
            Item newItem2 = new Item(description02);
            List<Item> newList = new List<Item> { newItem1, newItem2 };

            List<Item> result = Item.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }
    }
}
