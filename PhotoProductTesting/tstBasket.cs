using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstBasket
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBasket AnBasket = new clsBasket();
            Assert.IsNotNull(AnBasket);
        }
    }
}
