<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhotoPrints.aspx.cs" Inherits="PhotoPrints" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box}
        .auto-style1 {
            height: 183px;
        }
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
            width: 448px;
        }
        .auto-style6 {
            width: 448px;
        }
        .auto-style7 {
            margin-top: 0px;
        }
        .auto-style8 {
            width: 453px;
        }
        .auto-style9 {
            width: 447px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
&nbsp;<br />
&nbsp;<asp:Image ID="Image1" runat="server" Height="359px" ImageUrl="~/Gear-Photo-Prints-1226265565.jpg" Width="736px" />
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Font-Names="Arial" Font-Size="Large" Height="350px" OnTextChanged="TextBox1_TextChanged" ReadOnly="True" TextMode="MultiLine" Width="384px">
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
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style4" style="font-size: larger">&nbsp;
                        <br />
                        Standard 6 * 4 Photo Prints<br />
                        <br />
                        From: £0.20<br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSelect" runat="server" BackColor="#CCFFFF" Font-Size="Large" Height="47px" Text="Select" Width="199px" />
                        <br />
                    </td>
                    <td class="auto-style6" style="font-size: large">Standard Square Prints<br />
                        <br />
                        From: £0.20<br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSelectSqaure" runat="server" BackColor="#CCFFFF" Font-Size="Large" Height="47px" Text="Select" Width="199px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
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
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
