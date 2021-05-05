
using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCheckout AnCheckout = new clsCheckout();
        string NameOnCard = txtNameOnCard.Text;
        string CardNumber = txtCardNumber.Text;
        string ExpiryDate = txtExpiryDate.Text;
        string CVV = txtCVV.Text;

        string Error = "";
        Error = AnCheckout.Valid(NameOnCard, CardNumber, ExpiryDate, CVV);

        if (Error == "")
        {
            AnCheckout.NameOnCard = NameOnCard;
            AnCheckout.CardNumber = Convert.ToInt64(CardNumber);
            AnCheckout.ExpiryDate = DateTime.Parse(ExpiryDate);
            AnCheckout.CVV = int.Parse(CVV);


            clsCheckoutCollection CheckoutList = new clsCheckoutCollection();
            CheckoutList.ThisCheckout = AnCheckout;
            CheckoutList.Add();
            Response.Redirect("OrderConfirmed.aspx");
        }
        else
        {
            lblCheckoutError.Text = Error;
        }
        
    }

  /*  protected void txtCustomerID1_TextChanged(object sender, EventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection("Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Fyproject123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ");
        SqlDataAdapter SQLadapter = new SqlDataAdapter("SELECT CustomerID from tblSignUp ", sqlcon);
        DataTable DT = new DataTable();

        SQLadapter.Fill(DT);
        txtCustomerID1.Text = DT.ToString();
        txtCustomerID1.DataBind();
    }*/
}
