<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 1360px;
        }
    </style>
</head>
<body style="height: 1299px">
    <form id="form1" runat="server">
        <div class="auto-style1" style="text-align: center">
            &nbsp;<br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;<asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Checkout"></asp:Label>
            <br />
            <br />
            CustomerID:&nbsp;
            <asp:TextBox ID="txtCustomerID1" runat="server"></asp:TextBox>
            <br />
            <br />
            First Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirstN" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLastN" runat="server"></asp:TextBox>
            <br />
            <br />
            Name on Card:
            <asp:TextBox ID="txtNameOnCard" runat="server" Height="43px" Width="238px"></asp:TextBox>
            <br />
            <br />
            Card Number:
            <asp:TextBox ID="txtCardNumber" runat="server" Height="39px" Width="330px"></asp:TextBox>
            <br />
            <br />
            Expiry Date:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtExpiryDate" runat="server"></asp:TextBox>
            <br />
            <br />CVV:
            <asp:TextBox ID="txtCVV" runat="server"></asp:TextBox>
            <br />
            <br />
           Address:
            <asp:TextBox ID="txtAddress" runat="server" Height="38px" Width="317px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="60px" Text="Confirm Order" Width="213px" />
        </div>
    </form>
</body>
</html>
