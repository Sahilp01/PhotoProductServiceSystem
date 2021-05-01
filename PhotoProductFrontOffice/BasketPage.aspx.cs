using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class BasketPage : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        txtTotal.Visible = false;
        lblTotal.Visible = false;
    }



    protected void btnView_Click(object sender, EventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection("Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Fyproject123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ");
        SqlDataAdapter SQLadapter = new SqlDataAdapter("SELECT * from tblBasket ", sqlcon);
        DataTable DT = new DataTable();

        SQLadapter.Fill(DT);
        GridView1.DataSource = DT;
        GridView1.DataBind();

        lblTotal.Visible = true;
        txtTotal.Visible = true;
        decimal total = DT.AsEnumerable().Sum(row => row.Field<decimal>("Price"));
        txtTotal.Text = total.ToString();

        decimal TotalPoints = DT.AsEnumerable().Sum(row => row.Field<int>("PointsReceived"));
        txtPointsTotal.Text = TotalPoints.ToString();
    }

    protected void btnContinueShopping_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage1.aspx");
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        // Response.Redirect("Checkout.aspx");
        Response.Redirect("ConfirmDetails.aspx");
    }
}