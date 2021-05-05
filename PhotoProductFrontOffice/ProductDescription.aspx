<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDescription.aspx.cs" Inherits="ProductDescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 1605px;
        }
    *{box-sizing:border-box}
        *{text-shadow:none!important;box-shadow:none!important}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="font-size: x-large; text-align: center;">
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="188px" ImageUrl="~/Logo for website.JPG" Width="424px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Names="Lucida Calligraphy" Font-Size="XX-Large" Text="Product Details:"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProductID:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProductID" runat="server" Enabled="False" Font-Size="Medium" Height="52px" Width="284px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProductName:&nbsp;
            <asp:TextBox ID="txtProductName" runat="server" Enabled="False" Font-Size="Medium" Height="52px" Width="249px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProductDescription:&nbsp;
            <asp:TextBox ID="txtProductDescription" runat="server" Height="75px" Width="494px" Enabled="False" Font-Size="Medium" OnTextChanged="txtProductDescription_TextChanged"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; ProductQuantity:&nbsp;
            <asp:TextBox ID="txtProductQuantity" runat="server" Font-Size="Medium" Height="55px" Width="209px"></asp:TextBox>
            &nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProductPrice (£):&nbsp;&nbsp; <asp:TextBox ID="txtProductPrice" runat="server" Font-Size="Medium" Height="50px" Width="213px"></asp:TextBox>
            <br />
            &nbsp;<br />
            Upload your Picture:
            <asp:FileUpload ID="FileUpload1" runat="server" Height="45px" Width="327px" />
            <br />
            <br />
            PointsReceived:
            <asp:TextBox ID="txtPointsReceived" runat="server" Height="35px" Width="204px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddtoBasket" runat="server" Text="Add to Basket" BackColor="#CCFFFF" Font-Size="X-Large" OnClick="btnAddtoBasket_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
