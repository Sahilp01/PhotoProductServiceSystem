using System;

namespace PhotoProductClasses
{
    public class clsCheckout
    {
        public string NameOnCard { get; set; }
        public Int64 CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CVV { get; set; }

        public bool Find(int CardNumber)
        {
            return true;
        }

        public string Valid(string nameOnCard, string cardNumber, string expiryDate, string cVV)
        {
            String Error = "";

            if (nameOnCard.Length == 0)
            {
                Error = Error + "Please Enter your Last Name || ";
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
        }

        /* public string Valid(string nameOnCard, string cardNumber, string expiryDate, string cVV)
         {
             String Error = "";

             if (nameOnCard.Length == 0)
             {
                 Error = Error + "Please Enter your Last Name || ";
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
    }
    }
  



  
