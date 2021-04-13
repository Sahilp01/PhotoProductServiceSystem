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

    protected void txtProductDescription_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnAddtoBasket_Click(object sender, EventArgs e)
    {
        clsBasket AnBasket = new clsBasket();

        string ProductID = txtProductID.Text;
        string Name = txtProductName.Text;
        string Description = txtProductDescription.Text;
        string Quantity = txtProductQuantity.Text;
        string Price = txtProductPrice.Text;
       // byte Image = FileUpload1;

        string Error = "";
        Error = AnBasket.Valid(ProductID, Name, Quantity, Price);
        if (Error == "")
        {
            AnBasket.ProductID = int.Parse(ProductID);
            AnBasket.Name = Name;
            AnBasket.Quantity = int.Parse(Quantity); ;
            AnBasket.Price = int.Parse(Price);
          //  AnBasket.Image = Image;

            clsBasketCollection BasketList = new clsBasketCollection();
            BasketList.ThisBasket = AnBasket;
            BasketList.Add();
            Response.Redirect("BasketPage.aspx");
        }
       
    }
}
