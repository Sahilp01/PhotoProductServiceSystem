using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstCheckoutCollection
    {
        
        public void InstanceOk()
        {
            clsCheckoutCollection AllCheckout = new clsCheckoutCollection();
            Assert.IsNotNull(AllCheckout);
        }

        [TestMethod]
        public void CheckoutListOk()
        {
            clsCheckoutCollection AllCheckout = new clsCheckoutCollection();
            List<clsCheckout> TestList = new List<clsCheckout>();
            clsCheckout TestItem = new clsCheckout();
            TestItem.NameOnCard = "SAHIL PATEL";
            TestItem.CardNumber = 123456;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.CVV = 123;
           
            TestList.Add(TestItem);
            AllCheckout.CheckoutList = TestList;
            Assert.AreEqual(AllCheckout.CheckoutList, TestList);

        }
    

    [TestMethod]
    public void ThisCheckoutListOK()
    {
            clsCheckoutCollection AllCheckout = new clsCheckoutCollection();
            clsCheckout TestCheckout = new clsCheckout();
            TestCheckout.NameOnCard = "SAHIL PATEL";
            TestCheckout.CardNumber = 123456;
            TestCheckout.ExpiryDate = DateTime.Now.Date;
            TestCheckout.CVV = 123;
            AllCheckout.ThisCheckout = TestCheckout;
        Assert.AreEqual(AllCheckout.ThisCheckout, TestCheckout);

    }

        [TestMethod]
        public void AddMethodOk()
        {
            clsCheckoutCollection AllCheckout = new clsCheckoutCollection();
            clsCheckout TestItem = new clsCheckout();
            Int32 PrimaryKey = 0;
            TestItem.NameOnCard = "SAHIL PATEL";
            TestItem.CardNumber = 123456;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.CVV = 123;
            AllCheckout.ThisCheckout = TestItem;
            PrimaryKey = AllCheckout.Add();
            TestItem.CardNumber = PrimaryKey;

            AllCheckout.ThisCheckout.Find(PrimaryKey);
            Assert.AreEqual(AllCheckout.ThisCheckout, TestItem);
        }
    }
}
