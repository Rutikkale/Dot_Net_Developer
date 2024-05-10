<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="My_First_Project.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" Text="Click" OnClick="Button_Click"></asp:Button><asp:Label runat="server" Text="Label" ID="Label1" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
