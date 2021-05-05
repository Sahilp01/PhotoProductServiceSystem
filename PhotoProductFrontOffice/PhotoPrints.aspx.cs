using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PhotoPrints : System.Web.UI.Page
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
        lstProductsList.DataSource = Products.ProductsList;
        lstProductsList.DataValueField = "ProductID";
        lstProductsList.DataTextField = "ProductName";
        lstProductsList.DataBind();

    }


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }



    protected void btnSelectList_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if (lstProductsList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstProductsList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("ProductDescription.aspx");
        }
        else
        {
            lblerrorList.Text = "Please Select a Product that you would like to see";
        }
    }



   protected void btnApply_Click(object sender, EventArgs e)
    {
        clsProductsCollection Products = new clsProductsCollection();
        Products.ReportByProductName(txtFilter.Text);
        lstProductsList.DataSource = Products.ProductsList;
        lstProductsList.DataValueField = "ProductID";
        lstProductsList.DataTextField = "ProductName";
        lstProductsList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsProductsCollection Products = new clsProductsCollection();
        Products.ReportByProductName("");
        txtFilter.Text = "";
        lstProductsList.DataSource = Products.ProductsList;
        lstProductsList.DataValueField = "ProductID";
        lstProductsList.DataTextField = "ProductName";
        lstProductsList.DataBind();
    }
}