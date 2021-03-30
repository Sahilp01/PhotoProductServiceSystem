using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;
using System.Collections.Generic;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstProductsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductsCollection AllProducts = new clsProductsCollection();
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductsListOK()
        {
            clsProductsCollection AllProducts = new clsProductsCollection();
            List<clsProducts> TestList = new List<clsProducts>();
            clsProducts TestItem = new clsProducts();
            TestItem.ProductID = 2;
            TestItem.ProductName = "Standard 6 x 4 Photo Prints";
            TestItem.ProductDescription = "Standard 6 x 4 sized photo prints";
            TestItem.ProductQuantity = 1;
            TestItem.ProductPrice = 0;

            TestItem.Add(TestItem);
            AllProducts.ProductsList = TestList;
            Assert.AreEqual(AllProducts.ProductsList, TestList);
        }
        [TestMethod]
        public void ThisProductsListOK()
        {
            clsProductsCollection AllProducts = new clsProductsCollection();
            clsProducts TestProduct = new clsProducts();
            TestProduct.ProductID = 2;
            TestProduct.ProductName = "Standard 6 x 4 Photo Prints";
            TestProduct.ProductDescription = "Standard 6 x 4 sized photo prints";
            TestProduct.ProductQuantity = 1;
            TestProduct.ProductPrice = 0;
            AllProducts.ThisProduct = TestProduct;
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);

        }

    }
}
