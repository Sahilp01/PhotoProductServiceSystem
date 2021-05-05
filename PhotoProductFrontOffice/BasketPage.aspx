<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BasketPage.aspx.cs" Inherits="BasketPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 2191px;
        }
        .auto-style2 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="text-align: center">
            <br />
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="188px" ImageUrl="~/Logo for website.JPG" Width="422px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;<asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Summary of your Order:"></asp:Label>
            &nbsp;
            <asp:Button ID="btnView" runat="server" Height="46px" OnClick="btnView_Click" Text="View Summary" Width="178px" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style2" Height="280px" Width="1203px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTotal" runat="server" Font-Size="X-Large" Text="TotalPrice :"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtTotal" runat="server" Font-Size="X-Large" Height="42px" Width="307px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblTotal0" runat="server" Font-Size="X-Large" Text="TotalPointsReceived: "></asp:Label>
&nbsp;<asp:TextBox ID="txtPointsTotal" runat="server" Height="33px" Width="253px" ReadOnly="True"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Text="To Continue Shopping, Please click on This Button:"></asp:Label>
&nbsp;<asp:Button ID="btnContinueShopping" runat="server" Height="48px" OnClick="btnContinueShopping_Click" Text="Continue Shopping" Width="190px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnCheckout" runat="server" BackColor="#CCFFFF" Font-Size="X-Large" Height="69px" Text="Checkout" Width="338px" OnClick="btnCheckout_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:ListBox ID="lstDelete" runat="server" Height="288px" Width="331px" Font-Size="X-Large"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" BackColor="#CCFFFF" Font-Size="X-Large" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblDelete" runat="server" Font-Size="X-Large"></asp:Label>
        </div>
    </form>
</body>
</html>
