using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstCheckout
    {

        string CustomerID = "1";
        string FirstName = "Sahil";
        string LastName = "Patel";
        string NameOnCard = "SAHIL PATEL";
        string CardNumber = "123456";
        string ExpiryDate = "2022/12";
        string CVV = "123";
        string Address = "1 Test Street";

       

        [TestMethod]
        public void InstanceOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            Assert.IsNotNull(AnCheckout);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            Int32 TestData = 1;
            AnCheckout.CustomerID = TestData;
            Assert.AreEqual(AnCheckout.CustomerID, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            string TestData = "Sahil";
            AnCheckout.FirstName = TestData;
            Assert.AreEqual(AnCheckout.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            string TestData = "Patel";
            AnCheckout.LastName = TestData;
            Assert.AreEqual(AnCheckout.LastName, TestData);
        }

        [TestMethod]
        public void NameOnCardOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            string TestData = "SAHIL PATEL";
            AnCheckout.NameOnCard = TestData;
            Assert.AreEqual(AnCheckout.NameOnCard, TestData);
        }

        [TestMethod]
        public void CardNumberOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            Int32 TestData = 123456;
            AnCheckout.CardNumber = TestData;
            Assert.AreEqual(AnCheckout.CardNumber, TestData);
        }

        [TestMethod]
        public void ExpiryDateOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            DateTime TestData = DateTime.Now.Date;
            AnCheckout.ExpiryDate = TestData;
            Assert.AreEqual(AnCheckout.ExpiryDate, TestData);
        }

        [TestMethod]
        public void CVVOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            Int32 TestData = 123;
            AnCheckout.CVV = TestData;
            Assert.AreEqual(AnCheckout.CVV, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            string TestData = "1 Test Street";
            AnCheckout.Address = TestData;
            Assert.AreEqual(AnCheckout.Address, TestData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");

        }

    }
}
