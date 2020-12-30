using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstSignUp
    {
        string FirstName = "Sahil";
        string LastName = "Patel";
        string EmailAddress = "shl@hotmail.com";
        string Password = "Sahil1";
        string Address = "12 Dmu road";
        string PostCode = "LE4 6QQ";

        [TestMethod]
        public void InstanceOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            Assert.IsNotNull(AnSignUp);
        }

        [TestMethod]
        public void FirstNameOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            string TestData = "Sahil";
            AnSignUp.FirstName = TestData;
            Assert.AreEqual(AnSignUp.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            string TestData = "Patel";
            AnSignUp.LastName = TestData;
            Assert.AreEqual(AnSignUp.LastName, TestData);
        }

        [TestMethod]
        public void EmailAddressOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            string TestData = "shl@hotmail.com";
            AnSignUp.EmailAddress = TestData;
            Assert.AreEqual(AnSignUp.EmailAddress, TestData);
        }

        [TestMethod]
        public void PasswordOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            string TestData = "Sahil1";
            AnSignUp.Password = TestData;
            Assert.AreEqual(AnSignUp.Password, TestData);
        }

        [TestMethod]
        public void AddressOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            string TestData = "12 Dmu road";
            AnSignUp.Address = TestData;
            Assert.AreEqual(AnSignUp.Address, TestData);
        }

        [TestMethod]
        public void PostCodeOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            string TestData = "LE4 6QQ";
            AnSignUp.PostCode = TestData;
            Assert.AreEqual(AnSignUp.PostCode, TestData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsSignUp AnSignUp = new clsSignUp();
            String Error = "";
            Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsSignUp AnSignUp = new clsSignUp();
            String Error = "";
            string FirstName = "";
            Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsSignUp AnSignUp = new clsSignUp();
            String Error = "";
            string LastName = "";
            Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsSignUp AnSignUp = new clsSignUp();
            String Error = "";
            string EmailAddress = "";
            Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsSignUp AnSignUp = new clsSignUp();
            String Error = "";
            string Password = "";
            Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsSignUp AnSignUp = new clsSignUp();
            String Error = "";
            string Address = "";
            Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            clsSignUp AnSignUp = new clsSignUp();
            String Error = "";
            string PostCode = "";
            Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
            Assert.AreNotEqual(Error, "");
        }
    }
}
