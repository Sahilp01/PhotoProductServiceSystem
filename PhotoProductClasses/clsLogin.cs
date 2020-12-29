using System;

namespace PhotoProductClasses
{
    public class clsLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string Valid(string username, string password)
        {
            String Error = "";
            if (username.Length == 0)
            {
                Error = Error + "The Username should not be left blank :";
            }
            if (password.Length == 0)
            {
                Error = Error + "The Password should not be left blank :";
            }
            return Error;
        }

    
    }
}