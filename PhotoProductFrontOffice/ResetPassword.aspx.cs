using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
        AnUpdatepass = (clsUpdatePassError)Session["AnUpdatepass"];
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        clsUpdatePassError AnUpdatepass = new clsUpdatePassError();
        string EmailAddress = txtUsername1.Text;
        string NewPassword = txtNewPassword.Text;
        string RenenterNewPassword = txtNewPassword1.Text;

        string Error = "";
        Error = AnUpdatepass.Valid(EmailAddress, NewPassword, RenenterNewPassword);
        if (Error == "")
        {
            AnUpdatepass.EmailAddress = EmailAddress;
            AnUpdatepass.NewPassword = NewPassword;
            AnUpdatepass.ReenterNewPassword = RenenterNewPassword;
            Session["AnUpdatePass"] = AnUpdatepass;
            // Response.Redirect("Default.aspx");
        }
        else
        {
            lblErrorPass.Text = Error;
        }



        SqlConnection con = new SqlConnection(@"Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Fyproject123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblLogin WHERE Username = '" + txtUsername1.Text + "'", con); // selects the username from the login table 
        DataTable dt = new DataTable(); //this is creating a virtual table  
        sda.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
 
            if (txtNewPassword.Text == txtNewPassword1.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update tblLogin set Password = '" + txtNewPassword.Text + "' WHERE Username = '" + txtUsername1.Text + "' ", con); // updates the password in the login table by finding the username of the user
                cmd.ExecuteNonQuery(); //excutes the sql command 'cmd' query.

                con.Close();
                lblsuccess.Text = "Your password has successfully changed."; // if the usernmae is correct and both password field matches, then it will tell user that the opassword chnage is successful. 
                

            }

            else 
            {
                lblErrorPass.Text = "The Password that you have entered doesn't match"; 

            }

        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
