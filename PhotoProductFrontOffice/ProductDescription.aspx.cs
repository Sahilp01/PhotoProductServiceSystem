using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDescription : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductID != 1)
            {
                DisplayProduct();
            }
        }
    }

        void DisplayProduct()
        {
            clsProductsCollection ProductsList = new clsProductsCollection();

            ProductsList.ThisProduct.Find(ProductID);

            txtProductID.Text = ProductsList.ThisProduct.ProductID.ToString();
            txtProductName.Text = ProductsList.ThisProduct.ProductName;
            txtProductDescription.Text = ProductsList.ThisProduct.ProductDescription;
            txtProductQuantity.Text = ProductsList.ThisProduct.ProductQuantity.ToString();
            txtProductPrice.Text = ProductsList.ThisProduct.ProductPrice.ToString();



        }
    }
