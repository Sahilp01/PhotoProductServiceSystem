﻿
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
        /*CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != 1)
            {
                DisplayProduct();
            }
        }

        clsSignUp AnSignUp = new clsSignUp();
        AnSignUp = (clsSignUp)Session["AnSignUp"];

        string CustomerID = AnSignUp.CustomerID.ToString();
        string Address = AnSignUp.Address.ToString();

       txtCustomerID1.Text = CustomerID;
         txtAddress.Text = Address;
         */

 












    }
    /*
    void DisplayProduct()
    {
        clsSignUpCollection SignUpList = new clsSignUpCollection();
        SignUpList.ThisSignUp.Find(CustomerID);

        txtCustomerID1.Text = SignUpList.ThisSignUp.CustomerID.ToString();
       // txtAddress.Text = SignUpList.ThisSignUp.Address.ToString();

    }*/




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

    protected void txtCustomerID1_TextChanged(object sender, EventArgs e)
    {
        SqlConnection sqlcon = new SqlConnection("Server=tcp:photoproductserver.database.windows.net,1433;Initial Catalog=AddressBook;Persist Security Info=False;User ID=photoproduct;Password=Fyproject123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ");
        SqlDataAdapter SQLadapter = new SqlDataAdapter("SELECT CustomerID from tblSignUp ", sqlcon);
        DataTable DT = new DataTable();

        SQLadapter.Fill(DT);
        txtCustomerID1.Text = DT.ToString();
        txtCustomerID1.DataBind();
    }
}
