<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" style="z-index: 1; left: 276px; top: 339px; position: absolute" Text="Enter" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 134px; top: 123px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 104px; top: 197px; position: absolute; height: 19px" Text="Order Information"></asp:Label>
        <asp:Label ID="O_date" runat="server" style="z-index: 1; left: 155px; top: 267px; position: absolute" Text="Order Date"></asp:Label>
        <asp:DropDownList ID="dboxStatus" runat="server" style="z-index: 1; left: 270px; top: 263px; position: absolute">
        </asp:DropDownList>
        <asp:TextBox ID="txtOrder_ID" runat="server" style="z-index: 1; left: 265px; top: 124px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtInfo" runat="server" style="z-index: 1; left: 266px; top: 196px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Button" />
        </p>
    </form>
</body>
</html>
