using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstCheckout
    {

        string NameOnCard = "SAHIL PATEL";
        string CardNumber = "1234567890987654";
        string ExpiryDate = "2022/12";
        string CVV = "123";
        



        [TestMethod]
        public void InstanceOK()
        {
            clsCheckout AnCheckout = new clsCheckout();
            Assert.IsNotNull(AnCheckout);
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
        public void ValidMethodOk()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            Error = AnCheckout.Valid(NameOnCard, CardNumber, ExpiryDate, CVV );
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void NameOnCardMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string NameOnCard = "";
            Error = AnCheckout.Valid(NameOnCard, CardNumber, ExpiryDate, CVV);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string CardNumber = "";
            Error = AnCheckout.Valid(NameOnCard, CardNumber, ExpiryDate, CVV);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string ExpiryDate = "";
            Error = AnCheckout.Valid(NameOnCard, CardNumber, ExpiryDate, CVV);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CVVMinLessOne()
        {
            clsCheckout AnCheckout = new clsCheckout();
            String Error = "";
            string CVV = "";
            Error = AnCheckout.Valid(NameOnCard, CardNumber, ExpiryDate, CVV);
            Assert.AreEqual(Error, "");
        }

      
    }

 }
