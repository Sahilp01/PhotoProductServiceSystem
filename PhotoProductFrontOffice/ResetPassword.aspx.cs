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



        SqlConnection con = new SqlConnection(@"Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Prisha16;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblLogin WHERE Password = '" + txtUsername1.Text + "'", con);
        DataTable dt = new DataTable(); //this is creating a virtual table  
        sda.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
            //If the user is successfully authenticated then the form will be moved to the next form */
            //Response.Redirect("Default.aspx");

            if (txtNewPassword.Text == txtNewPassword1.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update tblLogin set Password = '" + txtNewPassword.Text + "' WHERE Password = '" + txtUsername1 + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();
                lblErrorPass.Text = "Successfull";

            }





            else
            {

                lblErrorPass.Text = "The username that you have entered is incorrect";


            }


            

        }

    }
}
