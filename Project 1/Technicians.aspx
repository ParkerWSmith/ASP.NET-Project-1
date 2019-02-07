<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Technicians.aspx.cs" Inherits="Project_1.Technicians" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 139px;
            left: 51px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 177px;
            left: 41px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 257px;
            left: 36px;
            z-index: 1;
            margin-bottom: 0px;
        }
        .auto-style4 {
            position: absolute;
            top: 219px;
            left: 41px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 297px;
            left: 84px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 334px;
            left: 40px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 377px;
            left: 70px;
            z-index: 1;
            bottom: 670px;
        }
        .auto-style8 {
            position: absolute;
            top: 419px;
            left: 39px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 468px;
            left: 35px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 582px;
            left: 28px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 515px;
            left: 48px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 515px;
            left: 136px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 516px;
            left: 216px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 517px;
            left: 309px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 179px;
            left: 133px;
            z-index: 1;
            width: 168px;
        }
        .auto-style17 {
            position: absolute;
            top: 257px;
            left: 138px;
            z-index: 1;
            width: 168px;
        }
        .auto-style18 {
            position: absolute;
            top: 217px;
            left: 137px;
            z-index: 1;
            width: 24px;
        }
        .auto-style20 {
            position: absolute;
            top: 334px;
            left: 137px;
            z-index: 1;
            width: 150px;
        }
        .auto-style21 {
            position: absolute;
            top: 377px;
            left: 135px;
            z-index: 1;
            width: 193px;
        }
        .auto-style22 {
            position: absolute;
            top: 417px;
            left: 137px;
            z-index: 1;
            width: 122px;
        }
        .auto-style23 {
            position: absolute;
            top: 140px;
            left: 133px;
            z-index: 1;
            width: 175px;
        }
        .auto-style24 {
            position: absolute;
            top: 132px;
            left: 335px;
            z-index: 1;
        }
        .auto-style25 {
            position: absolute;
            top: 295px;
            left: 137px;
            z-index: 1;
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Techlbl" runat="server" CssClass="auto-style1" Text="Technician:"></asp:Label>
            <asp:Label ID="FirstNlbl" runat="server" CssClass="auto-style2" Text="*First Name:"></asp:Label>
            <asp:Label ID="LastNlbl" runat="server" CssClass="auto-style3" Text="*Last Name:"></asp:Label>
            <asp:Label ID="Middlelbl" runat="server" CssClass="auto-style4" Text="Middle Initial:"></asp:Label>
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Names="Arial" 
            Font-Size="XX-Large" 
            style="z-index: 1; left: 373px; top: 15px; position: absolute; width: 428px; height: 37px;" 
            Text="Technician Maintenance"></asp:Label>
        <asp:Button ID="btnInfo" runat="server" Font-Bold="True" Font-Names="Arial" 
            Font-Size="Small" 
            style="z-index: 1; left: 70px; top: 75px; position: absolute; width: 200px" 
            TabIndex="1" Text="Return to Maintenance Menu" 
            ToolTip="Return to Main Menu" Width="250px" OnClick="btnInfo_Click" />
        </div>
        <asp:Label ID="Emaillbl" runat="server" CssClass="auto-style5" Text="Email:"></asp:Label>
        <asp:Label ID="Departmentlbl" runat="server" CssClass="auto-style6" Text="Department:"></asp:Label>
        <asp:Label ID="Phonelbl" runat="server" CssClass="auto-style7" Text="*Phone:"></asp:Label>
        <asp:Label ID="Ratelbl" runat="server" CssClass="auto-style8" Text="*Hourly Rate:"></asp:Label>
        <asp:Label ID="Requiredlbl" runat="server" CssClass="auto-style9" Text="*indicates required information"></asp:Label>
        <asp:Label ID="Errorlbl" runat="server" CssClass="auto-style10" Text="(error message)"></asp:Label>
        <asp:Button ID="AcceptBtn" runat="server" CssClass="auto-style11" Enabled="False" Text="Accept" />
        <asp:Button ID="CancelBtn" runat="server" CssClass="auto-style12" Enabled="False" Text="Cancel" />
        <asp:Button ID="RemoveBtn" runat="server" CssClass="auto-style13" Enabled="False" Text="Remove" />
        <asp:Button ID="ClearBtn" runat="server" CssClass="auto-style14" Enabled="False" Text="Clear" />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style23">
        </asp:DropDownList>
        <asp:Button ID="NewBtn" runat="server" CssClass="auto-style24" Enabled="False" Text="New Technician" />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style16"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style17"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style18"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" CssClass="auto-style25"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style20"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style21"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" CssClass="auto-style22"></asp:TextBox>
    </form>
</body>
</html>
