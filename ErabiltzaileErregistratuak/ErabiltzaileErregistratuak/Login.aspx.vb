Imports System.Data.SqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn2Login_Click(sender As Object, e As EventArgs) Handles btn2Login.Click
        Dim drErabiltzaileak As SqlDataReader
        Try
            DatuAtzipenekoak.DatuAtzipena.Konektatu()
            drErabiltzaileak = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(txtEmail.Text)
        Catch ex As DatuAtzipenekoak.DatuAtzipena.Salbuespenak.ErroreaIrakurtzean
            lblErrMezua.Text = ex.Message
            Exit Sub
        End Try

        If String.Compare(drErabiltzaileak.Item("email"), txtEmail.Text) And String.Compare(drErabiltzaileak.Item("pasahitza"), txtPasahitza.Text) Then
            Session.Contents("emaila") = txtEmail.Text
            Response.Redirect("Menua.aspx")
        Else
            lblErrMezua.Text = "Emaila edo pasahitza ez da zuzena"
        End If
    End Sub

    Protected Sub btn2Erregistratu_Click(sender As Object, e As EventArgs) Handles btn2Erregistratu.Click
        Response.Redirect("Erregistratu.aspx")
    End Sub

    Protected Sub btnPasaBerr_Click(sender As Object, e As EventArgs) Handles btnPasaBerr.Click
        Response.Redirect(String.Concat("PasahitzaBerreskuratu.aspx?emaila=", txtEmail.Text))
    End Sub
End Class