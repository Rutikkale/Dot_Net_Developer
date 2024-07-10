<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginstudent.aspx.cs" Inherits="Validation_Controals.loginstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="Center"><h1>Student Login</h1>
            <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Student Name:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="*please Enter Name" ControlToValidate="txtName" ForeColor="Red"> </asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Student Email:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="*please Enter Email" ControlToValidate="txtEmail" ForeColor="Red"> </asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Student ReEnter Email:"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtReEnter" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="*please Enter ReEnter" ControlToValidate="txtReEnter" ForeColor="Red"> </asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" /></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
