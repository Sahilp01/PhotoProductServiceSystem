<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhotoPrints.aspx.cs" Inherits="PhotoPrints" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box}
        .auto-style2 {
            width: 100%;
            margin-top: 0px;
        }
        .auto-style3 {
            height: 183px;
            width: 452px;
        }
        .auto-style4 {
            width: 452px;
        }
        .auto-style5 {
            height: 183px;
            width: 465px;
        }
        .auto-style6 {
            width: 465px;
        }
        .auto-style7 {
            margin-top: 0px;
        }
        .auto-style10 {
            height: 183px;
            width: 459px;
        }
        .auto-style11 {
            width: 459px;
        }
        .auto-style12 {
            width: 452px;
            height: 188px;
        }
        .auto-style13 {
            width: 465px;
            position: inherit;
            height: 188px;
        }
        .auto-style14 {
            width: 459px;
            height: 188px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" BackColor="#CCFFFF" Font-Size="XX-Large" Text="Photo Prints"></asp:Label>
            <br />
            <br />
&nbsp;<br />
&nbsp;<asp:Image ID="Image1" runat="server" Height="359px" ImageUrl="~/Gear-Photo-Prints-1226265565.jpg" Width="736px" />
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Font-Names="Arial" Font-Size="Large" Height="350px" OnTextChanged="TextBox1_TextChanged" ReadOnly="True" TextMode="MultiLine" Width="384px">Photo Prints

I am sure you must have many different photos  that best describes your moments. Why not hold those precious captures in your hand with our high quality photo prints. It is very simple now, all you need to do is pick the print and upload your photo. </asp:TextBox>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" BackColor="#CCFFFF" Font-Names="Lucida Handwriting" Font-Size="X-Large" Text="Browse the photo prints that best suits you"></asp:Label>
            <br />
            <br />
            <table class="auto-style2" border="0">
                <tr>
                    <td class="auto-style3">
                        <asp:Image ID="Image2" runat="server" Height="251px" ImageUrl="~/6 times 4.PNG" Width="419px" />
                    &nbsp;&nbsp;
                    </td>
                    <td class="auto-style5">&nbsp;&nbsp; <asp:Image ID="Image3" runat="server" CssClass="auto-style7" Height="239px" Width="410px" ImageUrl="~/square prints.PNG" />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style10">
                        <asp:Image ID="Image4" runat="server" Height="271px" ImageUrl="~/collage prints.jpg" Width="455px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12" style="font-size: larger; text-align: center; color: #000000;">&nbsp;
                        <br />
                        Standard 6 x 4 Photo Prints<br />
                        <br />
                        From: £0.20<br />
                       
                    </td>
                    <td class="auto-style13" style="font-size: large; text-align: center;">
                        <br />
                        Standard Square Prints<br />
                        <br />
                        From: £0.20<br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td class="auto-style14" style="font-size: large; text-align: center;">Collage Prints
                        <br />
                        <br />
                        From: £6.99<br />
                        <br />
                    </td>
                </tr>
                </table>
            <br />
            <br />
         
            <asp:ListBox ID="lstProductsList" runat="server" Font-Overline="True" Font-Size="XX-Large" Height="474px" Width="495px"></asp:ListBox>
         
            <br />
            <br />
            <br />
            <asp:Button ID="btnSelectList" runat="server" BackColor="#CCFFFF" Font-Size="X-Large" Height="71px" OnClick="btnSelectList_Click" Text="Select" Width="209px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblerrorList" runat="server"></asp:Label>
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
