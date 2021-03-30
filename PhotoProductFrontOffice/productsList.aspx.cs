using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhotoProductClasses;

public partial class productsList : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        PhotoProductClasses.clsProductsCollection Products = new PhotoProductClasses.clsProductsCollection();
        lstListProducts.DataSource = Products.ProductsList;
        lstListProducts.DataValueField = "ProductID";
        lstListProducts.DataTextField = "ProductName";
        lstListProducts.DataBind();

    }

    protected void btnSelect_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if (lstListProducts.SelectedIndex != 1)
        {
            ProductID = Convert.ToInt32(lstListProducts.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("ProductDescription.aspx");
        }
        else
        {
            lblErrorP.Text = "Please Select a Product that you would like to see";
        }
    }
}