using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstProducts
    {
        string ProductID = "1";
        string ProductName = "Standard 6 x 4 Photo Prints";
        string ProductDescription = "Standard 6 x 4 sized photo prints";
        string ProductQuantity = "0";
        string ProductPrice = "0";

        [TestMethod]
        public void InstanceOK()
        {
            clsProducts AnProducts = new clsProducts();
            Assert.IsNotNull(AnProducts);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            clsProducts AnProducts = new clsProducts();
            Int32 TestData = 1;
            AnProducts.ProductID = TestData;
            Assert.AreEqual(AnProducts.ProductID, TestData);
        }

        [TestMethod]
        public void ProductNameOk()
        {
            clsProducts AnProducts = new clsProducts();
            string TestData = "Standard 6 x 4 Photo Prints";
            AnProducts.ProductName = TestData;
            Assert.AreEqual(AnProducts.ProductName, TestData);
        }

        [TestMethod]
        public void ProductDescriptionOk()
        {
            clsProducts AnProducts = new clsProducts();
            string TestData = "Standard 6 x 4 sized photo prints";
            AnProducts.ProductDescription = TestData;
            Assert.AreEqual(AnProducts.ProductDescription, TestData);
        }

        [TestMethod]
        public void ProductQuantityOk()
        {
            clsProducts AnProducts = new clsProducts();
            Int32 TestData = 0;
            AnProducts.ProductQuantity = TestData;
            Assert.AreEqual(AnProducts.ProductQuantity, TestData);
        }

        [TestMethod]
        public void ProductPriceOk()
        {
            clsProducts AnProducts = new clsProducts();
            Decimal TestData = 0;
            AnProducts.ProductPrice = TestData;
            Assert.AreEqual(AnProducts.ProductPrice, TestData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsProducts AnProducts = new clsProducts();
            String Error = "";
            Error = AnProducts.Valid(ProductID, ProductName, ProductDescription, ProductQuantity, ProductPrice);
            Assert.AreEqual(Error, "");
        
        }

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            clsProducts AnProducts = new clsProducts();
            String Error = "";
            string ProductID = "";
            Error = AnProducts.Valid(ProductID, ProductName, ProductDescription, ProductQuantity, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsProducts AnProducts = new clsProducts();
            String Error = "";
            string ProductName = "";
            Error = AnProducts.Valid(ProductID, ProductName, ProductDescription, ProductQuantity, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsProducts AnProducts = new clsProducts();
            String Error = "";
            string ProductDescription = "";
            Error = AnProducts.Valid(ProductID, ProductName, ProductDescription, ProductQuantity, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuanitityMinLessOne()
        {
            clsProducts AnProducts = new clsProducts();
            String Error = "";
            string Quantity = "";
            Error = AnProducts.Valid(ProductID, ProductName, ProductDescription, ProductQuantity, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinLessOne()
        {
            clsProducts AnProducts = new clsProducts();
            String Error = "";
            string ProductPrice = "";
            Error = AnProducts.Valid(ProductID, ProductName, ProductDescription, ProductQuantity, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }





    }
}
