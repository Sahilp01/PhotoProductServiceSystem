using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstBasketCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBasketCollection AllBaskets = new clsBasketCollection();
            Assert.IsNotNull(AllBaskets);
        }

        [TestMethod]
        public void ProductsListOK()
        {
            clsBasketCollection AllBaskets = new clsBasketCollection();
            List<clsBasket> TestList = new List<clsBasket>();
            clsBasket TestItem = new clsBasket();
            TestItem.ProductID = 2;
            TestItem.Name = "Standard 6 x 4 Photo Prints";
            TestItem.Quantity = 1;
            TestItem.Price = 0;

            TestItem.Add(TestItem);
            AllBaskets.BasketList = TestList;
            Assert.AreEqual(AllBaskets.BasketList, TestList);
        }

        [TestMethod]
        public void ThisProductsListOK()
        {
            clsBasketCollection AllBaskets = new clsBasketCollection();
            clsBasket TestProduct = new clsBasket();
            TestProduct.ProductID = 2;
            TestProduct.Name = "Standard 6 x 4 Photo Prints";
            TestProduct.Quantity = 1;
            TestProduct.Price = 0;
            AllBaskets.ThisBasket = TestProduct;
            Assert.AreEqual(AllBaskets.ThisBasket, TestProduct);

        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsBasketCollection AllBaskets = new clsBasketCollection();
            clsBasket TestItem = new clsBasket();
            Int32 PrimaryKey = 0;
            TestItem.ProductID = 2;
            TestItem.Name = "Standard 6 x 4 Photo Prints";
            TestItem.Quantity = 1;
            TestItem.Price = 0;
            AllBaskets.ThisBasket = TestItem;
            PrimaryKey = AllBaskets.Add();
            TestItem.ProductID = PrimaryKey;

            AllBaskets.ThisBasket.Find(PrimaryKey);
            Assert.AreEqual(AllBaskets.ThisBasket, TestItem);
        }
    }
}
