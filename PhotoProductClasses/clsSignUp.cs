using System;
using System.Collections.Generic;

namespace PhotoProductClasses
{
    public class clsSignUp
    {
       // List<clsSignUp> mSignUpList = new List<clsSignUp>();
       // clsSignUp mthisSignUp = new clsSignUp();

 
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }

        public bool Find(int CustomerID)
        {
            return true;
        }

        /* public clsSignUp ThisSignUp
{
    get
    {
        return mthisSignUp;
    }
    set
    {
        mthisSignUp = value;
    }
}

public Int32 mCustmerID;

public Int32 CustomerID
{
    get
    {
        return mCustmerID;
    }
    set
    {
        mCustmerID = value;
    }
}

public string mFirsrtName;

public string FirstName
{
    get
    {
        return mFirsrtName;
    }
    set
    {
        mFirsrtName = value;
    }
}

public string mLastName;

public string LastName
{
    get
    {
        return mLastName;
    }
    set
    {
        mFirsrtName = value;
    }
}

public string mEmailAddress;

public string EmailAddress
{
    get
    {
        return mEmailAddress;
    }
    set
    {
        mEmailAddress = value;
    }
}

public string mPassword;

public string Password
{
    get
    {
        return mPassword;
    }
    set
    {
        mPassword = value;
    }
}

public string mAddress;

public string Address
{
    get
    {
        return mAddress;
    }
    set
    {
        mAddress = value;
    }
}

public string mPostCode;

public string PostCode
{
    get
    {
        return mPostCode;
    }
    set
    {
        mPostCode = value;
    }
}*/



        public string Valid(string firstName, string lastName, string emailAddress, string password, string address, string postCode)
        {
            String Error = "";
            if (firstName.Length == 0)
            {
                Error = Error + "Please Enter your First Name || ";
            }
            if (lastName.Length == 0)
            {
                Error = Error + "Please Enter your Last Name || ";
            }
            if (emailAddress.Length == 0)
            {
                Error = Error + "Please Enter your Email Address || ";
            }
            if (password.Length == 0)
            {
                Error = Error + "Please Enter a Password || ";
            }
            if (address.Length == 0)
            {
                Error = Error + "Please Enter your Adrress || ";
            }
            if (postCode.Length == 0)
            {
                Error = Error + "Please Enter yout PostCode || ";
            }
            if (postCode.Length > 9)
            {
                Error = Error + "The Post code must be less than 9 Characters || ";
            }

            return Error;
        }

      
    }

}