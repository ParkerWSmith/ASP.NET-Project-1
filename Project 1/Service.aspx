<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Service.aspx.cs" Inherits="Project_1.Service" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 149px;
            left: 22px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 190px;
            left: 48px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 230px;
            left: 34px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 274px;
            left: 47px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 398px;
            left: 46px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 325px;
            left: 50px;
            z-index: 1;
            width: 80px;
        }
        .auto-style7 {
            position: absolute;
            top: 325px;
            left: 156px;
            z-index: 1;
            width: 93px;
        }
        .auto-style8 {
            position: absolute;
            top: 187px;
            left: 112px;
            z-index: 1;
            width: 274px;
        }
        .auto-style9 {
            position: absolute;
            top: 228px;
            left: 112px;
            z-index: 1;
            width: 274px;
            right: 1551px;
        }
        .auto-style10 {
            position: absolute;
            top: 272px;
            left: 112px;
            z-index: 1;
            width: 275px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Names="Arial" 
            Font-Size="XX-Large" 
            style="z-index: 1; left: 373px; top: 15px; position: absolute; width: 428px; height: 37px;" 
            Text="Service Event Entry"></asp:Label>
        <asp:Button ID="btnInfo" runat="server" Font-Bold="True" Font-Names="Arial" 
            Font-Size="Small" 
            style="z-index: 1; left: 70px; top: 75px; position: absolute; width: 200px" 
            TabIndex="1" Text="Return to Maintenance Menu" 
            ToolTip="Return to Main Menu" Width="250px" OnClick="btnInfo_Click" />
            <asp:Label ID="Eventlbl" runat="server" CssClass="auto-style1" Text="Event Date"></asp:Label>
        </div>
        <asp:Label ID="Clientlbl" runat="server" CssClass="auto-style2" Text="*Client:"></asp:Label>
        <asp:Label ID="Contactlbl" runat="server" CssClass="auto-style3" Text="*Contact:"></asp:Label>
        <asp:Label ID="Phonelbl" runat="server" CssClass="auto-style4" Text="*Phone:"></asp:Label>
        <asp:Label ID="Errorlbl" runat="server" CssClass="auto-style5" Text="(error message)"></asp:Label>
        <asp:Button ID="NextBtn" runat="server" CssClass="auto-style6" Enabled="False" Text="Next" />
        <asp:Button ID="ClearBtn" runat="server" CssClass="auto-style7" Enabled="False" Text="Clear" />
        <asp:TextBox ID="ClientTxt" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="ContactTxt" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="PhoneTxt" runat="server" CssClass="auto-style10"></asp:TextBox>
    </form>
</body>
</html>
