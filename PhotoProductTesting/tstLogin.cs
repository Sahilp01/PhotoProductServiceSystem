using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstLogin
    {
        String Username = "P123";
        String Password = "Sahil";


        [TestMethod]
        public void InstanceOK()
        {
            clsLogin AnLogin = new clsLogin();
            Assert.IsNotNull(AnLogin);
        }
    [TestMethod]
    public void UsernameOK()
        {
            clsLogin AnLogin = new clsLogin();
            string TestData = "P123";
            AnLogin.Username = TestData;
            Assert.AreEqual(AnLogin.Username, TestData);
        }
    [TestMethod]
    public void PasswordOk()
        {
            clsLogin AnLogin = new clsLogin();
            string TestData = "Sahil";
            AnLogin.Password = TestData;
            Assert.AreEqual(AnLogin.Password, TestData);
        }

    [TestMethod]
    public void ValidMethodOK()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            Error = AnLogin.Valid(Username, Password);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinlessOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string Username = "";
            Error = AnLogin.Valid(Username, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinlessOne()
        {
            clsLogin AnLogin = new clsLogin();
            String Error = "";
            string Password = "";
            Error = AnLogin.Valid(Username, Password);
            Assert.AreNotEqual(Error, "");
        }

    }
}
