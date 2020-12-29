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
            Response.Redirect("HomePage1.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

       /* SqlConnection sqlcol = new SqlConnection("Data Source=PhotoProductServer.database.windows.net;User ID=PhotoProduct;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        string query = "Select * from tblLogin where Username = '" + txtUsername.Text.Trim() + "'  and Password = '" + txtPassword.Text.Trim() + "'";
        SqlDataAdapter sda = new SqlDataAdapter(query, sqlcol);
        DataTable dtbl = new DataTable();
        sda.Fill(dtbl);
        if (dtbl.Rows.Count == 1)
        {
            Response.Redirect("HomePage1.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
        */



    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
}