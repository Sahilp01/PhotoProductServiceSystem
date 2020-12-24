using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstLogin
    {
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
    public void Password()
        {
            clsLogin AnLogin = new clsLogin();
            string TestData = "Sahil";
            AnLogin.Password = TestData;
            Assert.AreEqual(AnLogin.Password, TestData);
        }


    }
}
