<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CanvasPrints.aspx.cs" Inherits="CanvasPrints" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        *{box-sizing:border-box}
        *{text-shadow:none!important;box-shadow:none!important}
        .auto-style2 {
            height: 1348px;
        }
        .auto-style3 {
            width: 100%;
            height: 259px;
        }
        .auto-style8 {
            width: 550px;
        }
        .auto-style9 {
            width: 547px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center" class="auto-style2">
        &nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Welcome to PhotoPerfect" BackColor="#CCFFFF" Font-Bold="True" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSubtitle" runat="server" BackColor="#CCFFFF" Font-Italic="True" Font-Names="Lucida Handwriting" Font-Size="Medium" Text="A place for your perfect pictures"></asp:Label>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="359px" ImageUrl="~/canvas prints main.jpg" Width="736px" />
            <asp:TextBox ID="TextBox1" runat="server" Font-Names="Arial" Font-Size="Large" Height="353px" OnTextChanged="TextBox1_TextChanged" ReadOnly="True" TextMode="MultiLine" Width="330px">CANVAS PRINTS

Brighten up your plain wall by showcasing your favourite memory everyday by high-quality Canvas Print. Whether it’s any of your favourite or family pictures for the living room or a perfect scenery in the hall, we provide the best quality Canvas Prints to ensure that you relive that memory. 

</asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" BackColor="#CCFFFF" Font-Names="Lucida Handwriting" Font-Size="X-Large" Text="Browse the Canvas Print that best suits you"></asp:Label>
            <br />
            <br />
            <table class="auto-style3">
                <tr>
                    <td class="auto-style9">
                        <br />
                        <asp:Image ID="Image2" runat="server" Height="250px" ImageUrl="~/simple canvas prints.jpg" Width="467px" />
                        <br />
                    </td>
                    <td class="auto-style8">
                        <br />
                        <asp:Image ID="Image3" runat="server" Height="296px" ImageUrl="~/collage canvas (3).jpg" Width="466px" />
                        <br />
                    </td>
                    <td>
                        <asp:Image ID="Image4" runat="server" Height="310px" ImageUrl="~/Desk Canvas.jpg" Width="436px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="font-size: large; text-align: center;">
                        <br />
                        Simple Canvas Prints<br />
                        <br />
                        From: £13.99<br />
                        <br />
                        <asp:Button ID="btnSimpleCanvas" runat="server" BackColor="#CCFFFF" Font-Size="Large" Height="47px" Text="Select" Width="199px" />
                        <br />
                    </td>
                    <td class="auto-style8" style="font-size: large; text-align: center">Collage Canvas Prints<br />
                        <br />
                        From: £17.99<br />
                        <br />
                        <asp:Button ID="btnCollageCanvas" runat="server" BackColor="#CCFFFF" Font-Size="Large" Height="47px" Text="Select" Width="199px" />
                    </td>
                    <td style="font-size: large; text-align: center">Desk Canvas Prints<br />
                        <br />
                        From: £13.99<br />
                        <br />
                        <asp:Button ID="btnDeskCanvas" runat="server" BackColor="#CCFFFF" Font-Size="Large" Height="47px" Text="Select" Width="199px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
