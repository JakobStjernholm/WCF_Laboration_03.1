<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipperClient.Default" %>

<%@ Import Namespace="ShipperClient.ServiceReference1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="shipperIdText" runat="server"></asp:TextBox>
            <asp:Button ID="getShipperButton" runat="server" OnClick="getShipperButton_Click1" Text="Get shipper"></asp:Button>
        </div>
        <div>
             <asp:Label ID="Label1" runat="server" Text="Shipper ID"></asp:Label>
             <asp:TextBox ID="shipperIdTextResult" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label2" runat="server" Text="Company name"></asp:Label>
             <asp:TextBox ID="shipperCompanyNameText" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
             <asp:TextBox ID="shipperPhoneText" runat="server"></asp:TextBox>
             <br />
            <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click"></asp:Button>

            
             <br />
             <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
             <br />
             <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>

            
        </div>
    </form>
</body>
</html>
