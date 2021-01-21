


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoProductClasses;
using System.Collections.Generic;

namespace PhotoProductTesting
{
    [TestClass]
    public class tstSignUpCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSignUpCollection AllSignup = new clsSignUpCollection();
            Assert.IsNotNull(AllSignup);
        }

        [TestMethod]
        public void SignUpListOk()
        {
            clsSignUpCollection AllSignup = new clsSignUpCollection();
            List<clsSignUp> TestList = new List<clsSignUp>();
            clsSignUp TestItem = new clsSignUp();
           // TestItem.CustomerID = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Testp";
            TestItem.EmailAddress = "Test@gmail.com";
            TestItem.Password = "Test1";
            TestItem.Address = "1 Test Road";
            TestItem.PostCode = "LE4 6TT";
            TestList.Add(TestItem);
            AllSignup.SignUpList = TestList;
            Assert.AreEqual(AllSignup.SignUpList, TestList);

        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsSignUpCollection AllSignup = new clsSignUpCollection();
            clsSignUp TestItem = new clsSignUp();
            Int32 PrimaryKey = 0;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Testp";
            TestItem.EmailAddress = "Test@gmail.com";
            TestItem.Password = "Test1";
            TestItem.Address = "1 Test Road";
            TestItem.PostCode = "LE4 6TT";
            AllSignup.ThisSignUp = TestItem;
            PrimaryKey = AllSignup.Add();
            TestItem.CustomerID = PrimaryKey;

            AllSignup.ThisSignUp.Find(PrimaryKey);
            Assert.AreEqual(AllSignup.ThisSignUp, TestItem);
        }

      /*  [TestMethod]
        public void AddMethod1Ok()
        {
            clsSignUpCollection AllSignup = new clsSignUpCollection();
            clsLogin TestItem = new clsLogin();
           // Int32 PrimaryKey = 0;
            TestItem.Username = "Test1";
            TestItem.Password = "Test1";
            
            AllSignup.ThisLogin = TestItem;
            AllSignup.Add1();
            

            
            Assert.AreEqual(AllSignup.ThisSignUp, TestItem);
        }*/

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsSignUpCollection AllSignup = new clsSignUpCollection();
            clsSignUp TestItem = new clsSignUp();
            Int32 PrimaryKey = 0;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Testp";
            TestItem.EmailAddress = "Test@gmail.com";
            TestItem.Password = "Test1";
            TestItem.Address = "1 Test Road";
            TestItem.PostCode = "LE4 6TT";
            AllSignup.ThisSignUp = TestItem;
            PrimaryKey = AllSignup.Add();
            TestItem.CustomerID = PrimaryKey;

            TestItem.FirstName = "TestUpdate";
            TestItem.LastName = "TestpUpdate";
            TestItem.EmailAddress = "TestUpdate@gmail.com";
            TestItem.Password = "Test1Update";
            TestItem.Address = "1 TestUpdate Road";
            TestItem.PostCode = "LE4 6UP";
            AllSignup.ThisSignUp = TestItem;
            AllSignup.Update();
            AllSignup.ThisSignUp.Find(PrimaryKey);
            Assert.AreEqual(AllSignup.ThisSignUp, TestItem);
        }
    }
}
