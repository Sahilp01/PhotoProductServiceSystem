using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteProduct : System.Web.UI.Page
{
    Int32 ProductID;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

 
    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsBasketCollection BasketBook = new clsBasketCollection();
        BasketBook.ThisBasket.Find(ProductID);
        BasketBook.Delete();
        Response.Redirect("BasketPage.aspx");
        
    }

    protected void btnNO_Click(object sender, EventArgs e)
    {
        Response.Redirect("BasketPage.aspx");
    }
}