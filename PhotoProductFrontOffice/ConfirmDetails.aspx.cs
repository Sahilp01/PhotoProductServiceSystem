using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConfirmDetails : System.Web.UI.Page
{

    string str;
    int RowCount;
    SqlCommand com;

    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection("Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Fyproject123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ");
        con.Open();
        str = "select * from tblSignUp where EmailAddress='" + Session["Username"] + "'";
        com = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds);
        txtcid.Text = ds.Tables[0].Rows[0]["CustomerID"].ToString();
        txtfn.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
        txtln.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
        txtea.Text = ds.Tables[0].Rows[0]["EmailAddress"].ToString();
        txta.Text = ds.Tables[0].Rows[0]["Address"].ToString();
        txtPC.Text = ds.Tables[0].Rows[0]["PostCode"].ToString();


    }

      /*  SqlConnection connection = new SqlConnection(@"Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Fyproject123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblSignUp WHERE CustomerID = '" + txtcid.Text + "'", connection); // selects the username from the login table 
        DataTable dt = new DataTable(); //this is creating a virtual table  
        sda.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update tblSignUp set FirstName = '" + txtfn.Text + "'", "LastName = '" + txtln.Text  + "'", " EmailAddress = '" + txtea.Text + "'", " Address = '" + txta.Text + "'", " PostCode = '" + txtPC.Text + "'", " WHERE CustomerID = '" + txtcid.Text + "'", connection); // updates the password in the login table by finding the username of the user
            cmd.ExecuteNonQuery(); //excutes the sql command 'cmd' query.

            connection.Close();
        }
    }*/
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Checkout.aspx");
    }
}