using PhotoProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsLogin AnLogin = new clsLogin();
        AnLogin = (clsLogin)Session["AnLogin"];
       // Response.Write(AnLogin.Username);
    }

    protected void btnPrints_Click(object sender, EventArgs e)
    {
        Response.Redirect("PhotoPrints.aspx");
    }

    protected void btncanvas_Click(object sender, EventArgs e)
    {
        Response.Redirect("CanvasPrints.aspx");
    }
}

