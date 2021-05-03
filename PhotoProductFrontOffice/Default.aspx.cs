using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsLogin AnLogin = new clsLogin();
        AnLogin = (clsLogin)Session["AnLogin"];
        // Response.Write(AnLogin.Username);
        // Response.Write(AnLogin.Password);

        txtPassword.TextMode = TextBoxMode.Password;



    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsLogin AnLogin = new clsLogin();
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        String Error = "";
        Error = AnLogin.Valid(Username, Password);
        if (Error == "")
        {
            AnLogin.Username = Username;
            AnLogin.Password = Password;
            Session["AnLogin"] = AnLogin;
            /// Response.Redirect("HomePage1.aspx");

        }
        else
        {
            lblError.Text = Error;

            // lblLabel3.Visible = false;
        }



        SqlConnection con = new SqlConnection("Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Fyproject123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblLogin WHERE Username = '" + txtUsername.Text + "' AND Password= '" + txtPassword.Text + "'", con); // checks that the username and password that the user entered is there in login table or not.
        DataTable dt = new DataTable(); //this is creating a virtual table  
        sda.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
            Session["UserName"] = Username;
            Response.Redirect("PhotoPrints.aspx"); //If the user is successfully authenticated then the form will be moved to the homepage

        }

        else
        {
            lblError.Visible = true;
            lblLabel3.Text = "The Login that you have entered is incorrect"; // if the details that the user enters is not in the login table then they wull get an error.


        }
    }

    protected void btnshowpass_Click(object sender, EventArgs e)
    {
        txtPassword.TextMode = TextBoxMode.SingleLine;
        this.txtPassword.Text = txtPassword.Text;
    }





    protected void btnForgetPassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResetPassword.aspx");
    }


}
 

   
    
