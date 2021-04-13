using System;

namespace PhotoProductClasses
{
    public class clsCheckout
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameOnCard { get; set; }
        public Int64 CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CVV { get; set; }
        public string Address { get; set; }

        public string Valid(string customerID, string firstName, string lastName, string nameOnCard, string cardNumber, string expiryDate, string cVV, string address)
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
            if (nameOnCard.Length == 0)
            {
                Error = Error + "Please Enter your Last Name || ";
            }
            /*if (cardNumber.Length == 0)
            {
                Error = Error + "Please Enter your Card Number || ";
            }
            if (cardNumber.Length != 16)
            {
                Error = Error + "Please Enter correct Card Number || ";
            }*/
            if (expiryDate.Length == 0)
            {
                Error = Error + "Please Enter the expiry date of your card || ";
            }
            if (cVV.Length == 0)
            {
                Error = Error + "Please Enter your security Number || ";
            }
            if (cVV.Length != 3)
            {
                Error = Error + "Please Enter your 3 digit security Number || ";
            }
            
            return Error;
        }

        /*public string Valid(string firstName, string lastName, string nameOnCard, string cardNumber, string expiryDate, string cVV, string address)
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
            if (nameOnCard.Length == 0)
            {
                Error = Error + "Please Enter your Last Name || ";
            }
            if (cardNumber.Length == 0)
            {
                Error = Error + "Please Enter your  Card Number || ";
            }
            if (cardNumber.Length != 16)
            {
                Error = Error + "Please Enter correct Card Number || ";
            }
            if (expiryDate.Length == 0)
            {
                Error = Error + "Please Enter the expiry date of your card || ";
            }
            if (cVV.Length == 0)
            {
                Error = Error + "Please Enter your security Number || ";
            }
            if (cVV.Length != 3)
            {
                Error = Error + "Please Enter your 3 digit security Number || ";
            }

            return Error;
        }*/

        public bool Find(int CustomerID)
        {
            return true;
        }
    }
}