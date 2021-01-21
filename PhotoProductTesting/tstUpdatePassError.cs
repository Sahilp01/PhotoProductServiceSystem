using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstUpdatePassError
    {
        String EmailAddress = "";
        String NewPassword = "";
        String ReenterNewPassword = "";


        [TestMethod]
        public void InstanceOK()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            Assert.IsNotNull(AnUpdatepass);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            string TestData = "1";
            AnUpdatepass.EmailAddress = TestData;
            Assert.AreEqual(AnUpdatepass.EmailAddress, TestData);
        }

        [TestMethod]
        public void NewPasswordOK()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            string TestData = "1";
            AnUpdatepass.NewPassword = TestData;
            Assert.AreEqual(AnUpdatepass.NewPassword, TestData);
        }

        [TestMethod]
        public void ReenterNewPasswordOK()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            string TestData = "1";
            AnUpdatepass.ReenterNewPassword = TestData;
            Assert.AreEqual(AnUpdatepass.ReenterNewPassword, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            String Error = "";
            Error = AnUpdatepass.Valid(EmailAddress, NewPassword, ReenterNewPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            String Error = "";
            string EmailAddress = "";
            Error = AnUpdatepass.Valid(EmailAddress, NewPassword, ReenterNewPassword);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NewPasswordMinLessOne()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            String Error = "";
            string NewPassword = "";
            Error = AnUpdatepass.Valid(EmailAddress, NewPassword, ReenterNewPassword);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReenterNewPasswordMinLessOne()
        {
            clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
            String Error = "";
            string ReenterNewPassword = "";
            Error = AnUpdatepass.Valid(EmailAddress, NewPassword, ReenterNewPassword);
            Assert.AreNotEqual(Error, "");
        }

    }
}