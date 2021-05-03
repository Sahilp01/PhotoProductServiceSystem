<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmed.aspx.cs" Inherits="OrderConfirmed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 684px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="text-align: center">
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="194px" ImageUrl="~/Logo for website.JPG" Width="393px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp; <asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Congratulations, Your order has been confirmed. "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Text="Thank You for shopping with PhotoPerfect. We hope to see you soon. "></asp:Label>
        </div>
    </form>
</body>
</html>
