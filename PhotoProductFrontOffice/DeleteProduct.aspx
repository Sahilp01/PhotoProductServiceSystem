<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteProduct.aspx.cs" Inherits="DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 714px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="text-align: center; font-size: large;">
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="188px" ImageUrl="~/Logo for website.JPG" Width="376px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp; <asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            Are you sure that you want to delete this product from the basket?<br />
            <br />
&nbsp;&nbsp;&nbsp;<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" BackColor="#CCFFFF" Font-Size="X-Large" Height="62px" Width="164px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNO" runat="server" Text="No" BackColor="#CCFFFF" Font-Size="X-Large" Height="62px" Width="164px" OnClick="btnNO_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
