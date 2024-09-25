<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomeValidator.aspx.cs" Inherits="Custome_Validator.CustomeValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 145px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <table class="auto-style1">
        <tr>
            <td class="auto-style2">Enter Even Number:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*Please Enter even Number" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*Please enter Even Number" ForeColor="Red" OnServerValidate="EvenNumberCutomValidator" SetFocusOnError="True"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            </td>
        </tr>
    </table>
        </div>
    </form>
</body>
</html>
