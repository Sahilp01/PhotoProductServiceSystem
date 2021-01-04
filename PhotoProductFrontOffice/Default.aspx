<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 900px">
    <form id="form1" runat="server">
        <div style="height: 845px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblLogin" runat="server" BackColor="#CCFFFF" Font-Bold="False" Font-Italic="False" Font-Size="X-Large" Text="Login to PhotoPerfect and Experience the perfect picture" Font-Names="Lucida Handwriting"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Username" Font-Size="Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server" Height="29px" Width="287px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password" Font-Size="Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server" Height="26px" Width="291px"></asp:TextBox>
&nbsp;<br />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" BackColor="#CCFFFF" OnClick="btnLogin_Click" Text="Login" Font-Size="X-Large" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnForgetPassword" runat="server" BackColor="#CCFFFF" Font-Size="Large" Height="42px" OnClick="btnForgetPassword_Click" Text="Forgot Password?" Width="248px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblLabel3" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
