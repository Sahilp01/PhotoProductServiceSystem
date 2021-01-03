using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsLogin AnLogin = new clsLogin();
        AnLogin = (clsLogin)Session["Default"];
       // Response.Write(AnLogin.Username);
        // Response.Write(AnLogin.Password);

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



        SqlConnection con = new SqlConnection(@"Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Prisha16;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblLogin WHERE Username = '" + txtUsername.Text + "' AND Password= '" + txtPassword.Text + "'", con);
        DataTable dt = new DataTable(); //this is creating a virtual table  
        sda.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
            //If the user is successfully authenticated then the form will be moved to the next form */
            Response.Redirect("HomePage1.aspx");
            
        }
        
        else
        {
            
            lblLabel3.Text = "The Login that you have entered is inccorect";
          
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
}