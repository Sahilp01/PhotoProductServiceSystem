using System;

namespace PhotoProductClasses
{
    public class clsSignUp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }

        public string Valid(string firstName, string lastName, string emailAddress, string password, string address, string postCode)
        {
            String Error = "";
            if (firstName.Length == 0)
            {
                Error = Error + "Please Enter your First Name :";
            }
            if (lastName.Length == 0)
            {
                Error = Error + "Please Enter your Last Name :";
            }
            if (emailAddress.Length == 0)
            {
                Error = Error + "Please Enter your Email Address :";
            }
            if (password.Length == 0)
            {
                Error = Error + "Please Enter a Password :";
            }
            if (address.Length == 0)
            {
                Error = Error + "Please Enter your Adrress :";
            }
            if  (postCode.Length == 0)
            {
                Error = Error + "Please Enter yout PostCode :";
            }
            if (postCode.Length > 9)
            {
                Error = Error + "The Post code must be less than 9 Characters :";
            }
        
            return Error;
        }
    }
}