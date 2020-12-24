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
    }
}
