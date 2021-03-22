<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDescription.aspx.cs" Inherits="ProductDescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 673px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProductID:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProductName:&nbsp;
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProductDescription:&nbsp;
            <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp; ProductQuantity:&nbsp;
            <asp:TextBox ID="txtProductQuantity" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp; ProductPrice:&nbsp;&nbsp;
            <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
