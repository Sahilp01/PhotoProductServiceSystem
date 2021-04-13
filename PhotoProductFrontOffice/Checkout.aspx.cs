
using PhotoProductClasses;
using System;
using System.Collections.Generic;
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
        CustomerID = Convert.ToInt32(Session["CustomerID"]);

    

        if (IsPostBack == false)
        {
            if (CustomerID != 1)
            {
                DisplayProduct();
            }
        }
    }

    void DisplayProduct()
    {
        clsSignUpCollection SignUpList = new clsSignUpCollection();
        SignUpList.ThisSignUp.Find(CustomerID);

        txtCustomerID1.Text = SignUpList.ThisSignUp.CustomerID.ToString();
       // txtAddress.Text = SignUpList.ThisSignUp.Address.ToString();

    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCheckout AnCheckout = new clsCheckout();
        string CustomerID = txtCustomerID1.Text;
        string FirstName = txtFirstN.Text;
        string LastName = txtLastN.Text;
        string NameOnCard = txtNameOnCard.Text;
        string CardNumber = txtCardNumber.Text;
        string ExpiryDate = txtExpiryDate.Text;
        string CVV = txtCVV.Text;
        string Address = txtAddress.Text;

        string Error = "";
        Error = AnCheckout.Valid(CustomerID, FirstName, LastName, NameOnCard, CardNumber, ExpiryDate, CVV, Address);
        if (Error == "")
        {
            AnCheckout.CustomerID = int.Parse(CustomerID);
            AnCheckout.FirstName = FirstName;
            AnCheckout.LastName = LastName;
            AnCheckout.NameOnCard = NameOnCard;
            AnCheckout.CardNumber = Convert.ToInt64(CardNumber);
            AnCheckout.ExpiryDate = DateTime.Parse(ExpiryDate);
            AnCheckout.CVV = int.Parse(CVV);
            AnCheckout.Address = Address;

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
}
