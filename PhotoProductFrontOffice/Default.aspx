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
            <asp:Label ID="lblLogin" runat="server" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Login to PhotoPerfect"></asp:Label>
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" BackColor="#CCFFCC" OnClick="btnLogin_Click" Text="Login" Font-Size="X-Large" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Error"></asp:Label>
        </div>
    </form>
</body>
</html>
