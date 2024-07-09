

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="LoginForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>login</h1>
    <table>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
        <td>
            <asp:TextBox ID="TxtUsername" runat="server" OnTextChanged="TxtUsername_TextChanged"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="*Please Enter Username" ForeColor="Red" ControlToValidate="TxtUsername"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
        <td>
            <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="*please Enter Password" ForeColor="Red" ControlToValidate="TxtUsername"></asp:RequiredFieldValidator></td>
    </tr>
</table>
        </div>
        <div>
            <asp:Button ID="btnlogin" runat="server" Text="Login" />
        </div>
    </form>
</body>
</html>
