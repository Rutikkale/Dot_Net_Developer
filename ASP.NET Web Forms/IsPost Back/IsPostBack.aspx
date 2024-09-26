<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IsPostBack.aspx.cs" Inherits="IsPost_Back.IsPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="102px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            <br />
<asp:Button ID="Button1" runat="server" Text="Click" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

