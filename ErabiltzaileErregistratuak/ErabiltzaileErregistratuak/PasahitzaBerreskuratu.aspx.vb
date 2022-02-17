Imports System.Data.SqlClient

Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim drErabiltzailea As SqlDataReader
        drErabiltzailea = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Request.QueryString(“emaila”))
        lblGalEzk.Text = drErabiltzailea.Item("galderaEzkutua")
    End Sub

    Protected Sub btnPasaBerr_Click(sender As Object, e As EventArgs) Handles btnPasaBerr.Click
        Dim drErabiltzailea As SqlDataReader
        drErabiltzailea = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Request.QueryString(“emaila”))
        If String.IsNullOrEmpty(txtErantzuna.Text) Then
            lblEmaitza.Text = "Erantzuna hutsik dago"
        ElseIf String.Equals(drErabiltzailea.Item("erantzuna"), txtErantzuna.Text) Then
            lblEmaitza.Text = drErabiltzailea.Item("pasahitza")
        Else
            lblEmaitza.Text = "Erantzuna ez da zuzena"
        End If
    End Sub

    Protected Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class