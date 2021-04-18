using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstBasket
    {
        string ProductID = "1";
        string Name = "Standard 6 x 4 Photo Prints";
        string Quantity = "1";
        string Price = "0";
        string PointsReceived = "5";

        [TestMethod]
        public void InstanceOK()
        {
            clsBasket AnBasket = new clsBasket();
            Assert.IsNotNull(AnBasket);
        }
        [TestMethod]
        public void ProductIDOK()
        {
            clsBasket AnBasket = new clsBasket();
            Int32 TestData = 2;
            AnBasket.ProductID = TestData;
            Assert.AreEqual(AnBasket.ProductID, TestData);
        }

        [TestMethod]
        public void ProductNameOk()
        {
            clsBasket AnBasket = new clsBasket();
            string TestData = "Standard 6 x 4 Photo Prints";
            AnBasket.Name = TestData;
            Assert.AreEqual(AnBasket.Name, TestData);
        }

        [TestMethod]
        public void ProductQuantityOk()
        {
            clsBasket AnBasket = new clsBasket();
            Int32 TestData = 1;
            AnBasket.Quantity = TestData;
            Assert.AreEqual(AnBasket.Quantity, TestData);
        }

        [TestMethod]
        public void ProductPriceOk()
        {
            clsBasket AnBasket = new clsBasket();
            Decimal TestData = 0;
            AnBasket.Price = TestData;
            Assert.AreEqual(AnBasket.Price, TestData);
        }


        [TestMethod]
        public void PointsReceivedOK()
        {
            clsBasket AnBasket = new clsBasket();
            Int32 TestData = 5;
            AnBasket.PointsReceived = TestData;
            Assert.AreEqual(AnBasket.PointsReceived, TestData);
        }


        /* [TestMethod]
         public void ImageOK()
         {
             clsBasket AnBasket = new clsBasket();
              TestData = "":
             AnBasket.Image = TestData;
             Assert.AreEqual(AnBasket.Image, TestData);
         }*/

        [TestMethod]
        public void ValidMethodOk()
        {
            clsBasket AnBasket = new clsBasket();
            String Error = "";
            Error = AnBasket.Valid(ProductID, Name, Quantity, Price, PointsReceived);
            Assert.AreEqual(Error, "");

        }
    }
}
