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
        string CardNumber = "1234567890987654";
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
            Int64 TestData = 1234567890987654;
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

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string CustomerID = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string FirstName = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string LastName = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameOnCardMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string NameOnCard = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string CardNumber = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string ExpiryDate = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVVMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string CVV = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string Address = "";
            Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
            Assert.AreEqual(Error, "");
        }
    }

 }
