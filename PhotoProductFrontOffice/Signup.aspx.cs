using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSignUp AnSignUp = new clsSignUp();
        AnSignUp = (clsSignUp)Session["AnSignup"];
        //Response.Write(AnSignUp.CustomerID);
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        clsSignUp AnSignUp = new clsSignUp();
        clsLogin AnLogin = new clsLogin();
        string FirstName = txtFirstName.Text;
        string LastName = txtLastname.Text;
        string EmailAddress = txtEmailaddress.Text;
        string Password = txtPassword.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostcode.Text;
   
       
        string Error = "";
        Error = AnSignUp.Valid(FirstName, LastName, EmailAddress, Password, Address, PostCode);
        if (Error == "")
        {
            AnSignUp.FirstName = FirstName;
            AnSignUp.LastName = LastName;
            AnSignUp.EmailAddress = EmailAddress;
            AnSignUp.Password = Password;
            AnSignUp.Address = Address;
            AnSignUp.PostCode = PostCode;
            //AnLogin.Username = EmailAddress;
            //AnLogin.Password = Password;

            clsSignUpCollection SignUpList = new clsSignUpCollection();
            SignUpList.ThisSignUp = AnSignUp;
            //SignUpList.ThisLogin = AnLogin;
            SignUpList.Add();
            SignUpList.AddLogin();
            Session["AnSignUp"] = AnSignUp;


            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError1.Text = Error;
        }
    }
}