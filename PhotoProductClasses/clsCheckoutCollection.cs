using System;
using System.Collections.Generic;

namespace PhotoProductClasses
{
    public class clsCheckoutCollection
    {

        List<clsCheckout> mCheckoutList = new List<clsCheckout>();
        clsCheckout mThisCheckout = new clsCheckout();

        public List<clsCheckout> CheckoutList
        {
            get
            {
                return mCheckoutList;
            }
            set
            {
                mCheckoutList = value;
            }
        }
        public clsCheckout ThisCheckout
        {
            get
            {
                return mThisCheckout;
            }
            set
            {
                mThisCheckout = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@NameOnCard", mThisCheckout.NameOnCard);
            DB.AddParameter("@CardNumber", mThisCheckout.CardNumber);
            DB.AddParameter("@ExpiryDate", mThisCheckout.ExpiryDate);
            DB.AddParameter("@CVV", mThisCheckout.CVV);
           


            return DB.Execute("sproc_tblCheckout_Insert");
        }
    }
}