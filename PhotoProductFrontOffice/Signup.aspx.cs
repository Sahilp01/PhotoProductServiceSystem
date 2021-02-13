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
       

            clsSignUpCollection SignUpList = new clsSignUpCollection();
            SignUpList.ThisSignUp = AnSignUp;
           
            SignUpList.Add(); // Adds the data to the sign up table
            SignUpList.AddLogin(); // Adds the email address and passsword from sign up page to the login table
            Session["AnSignUp"] = AnSignUp;


            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError1.Text = Error;
        }
    }



    protected void txtEmailaddress_TextChanged(object sender, EventArgs e)
    {

    }
}