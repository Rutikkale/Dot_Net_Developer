<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RangValidator.aspx.cs" Inherits="Rang_Validator.RangValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Studenent Registration Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 131px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Studenent Registration</h1>

            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Silver" Font-Size="Large" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Name :&nbsp;</td>
                    <td>
                        <asp:TextBox ID="uxStudentName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Please Enter Name" ControlToValidate="uxStudentName" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email :&nbsp;</td>
                    <td>
                        <asp:TextBox ID="uxEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Enter Email" ControlToValidate="uxEmail" ForeColor="Red" SetFocusOnError="True" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="uxEmail" Display="Dynamic" EnableTheming="True" ErrorMessage="*Please Enter Email in Right format" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Re-Enter Email :&nbsp;</td>
                    <td>
                        <asp:TextBox ID="uxReEnterEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Re-Enter Email" ControlToValidate="uxReEnterEmail" ForeColor="Red" SetFocusOnError="True" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="uxReEnterEmail" Display="Dynamic" ErrorMessage="*Please  ReEnter Email in Right format" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="uxEmail" ControlToValidate="uxReEnterEmail" Display="Dynamic" ErrorMessage="*Email is not Identical" ForeColor="Red">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Class:&nbsp;</td>
                    <td>
                        <asp:TextBox ID="uxClasstextbox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="uxClasstextbox" Display="Dynamic" ErrorMessage="*please enter Class" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="uxClasstextbox" Display="Dynamic" ErrorMessage="*class should be from 1 to 12" ForeColor="Red" MaximumValue="12" MinimumValue="1" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Fees:</td>
                    <td>
                        <asp:TextBox ID="uxFeestextbox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uxFeestextbox" Display="Dynamic" ErrorMessage="*please enter Fees" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="uxFeestextbox" Display="Dynamic" ErrorMessage="*Fees Should be from 2000.00 To 5000.00" ForeColor="Red" MaximumValue="5000.00" MinimumValue="2000.00" SetFocusOnError="True" Type="Double">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="UxSubmit" runat="server" Text="Submit" OnClick="UxSubmit_Click" />&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
 
</body>
</html>