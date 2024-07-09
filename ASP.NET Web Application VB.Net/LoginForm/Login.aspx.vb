Imports System.Data.SqlClient
Imports System.Configuration

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TxtUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = TxtUsername.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()

    End Sub
End Class