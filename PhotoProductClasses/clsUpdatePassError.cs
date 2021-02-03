using System;

namespace PhotoProductClasses
{
    public class clsUpdatePassError
    {

        public string EmailAddress { get; set; }
        public string NewPassword { get; set; }
        public string ReenterNewPassword { get; set; }

        public string Valid(string emailAddress, string newPassword, string reenterNewPassword)
        {
            String Error = "";
            if (emailAddress.Length == 0)
            {
                Error = Error + "The Email Address should not be left blank || ";
            }
            if (newPassword.Length == 0)
            {
                Error = Error + "The Password should not be left blank || ";
            }
            if (reenterNewPassword.Length == 0)
            {
                Error = Error + "The Password should not be left blank || ";
            }
            if (newPassword != reenterNewPassword)
            {
                Error = Error + "The Password doesn't match. Please enter the same password || ";
            }
            return Error;
        }

    }
}