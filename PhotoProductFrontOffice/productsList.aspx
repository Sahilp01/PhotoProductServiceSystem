<%@ Page Language="C#" AutoEventWireup="true" CodeFile="productsList.aspx.cs" Inherits="productsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:ListBox ID="lstListProducts" runat="server" Height="468px" Width="587px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblErrorP" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
