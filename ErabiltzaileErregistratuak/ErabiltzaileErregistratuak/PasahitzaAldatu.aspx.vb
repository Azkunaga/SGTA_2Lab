Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class WebForm7
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DatuAtzipenekoak.DatuAtzipena.Konektatu()
    End Sub

    Protected Sub btnPasaAlda_Click(sender As Object, e As EventArgs) Handles btnPasaAlda.Click
        Dim drErabiltzaileak As SqlDataReader
        drErabiltzaileak = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Session.Contents("emaila").ToString)
        If drErabiltzaileak.Read() Then
            If String.Equals(drErabiltzaileak.Item("pasahitza"), txtOldPass.Text) Then
                If String.Equals(txtNewPass.Text, txtNewPass2.Text) Then
                    DatuAtzipenekoak.DatuAtzipena.ErabiltzailearenPasahitzaAldatu(Session.Contents("emaila").ToString, txtNewPass.Text)
                    DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                Else
                    MessageBox.Show("Pasahitz berriak ez dira berdinak")
                    DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
                End If
            Else
                MessageBox.Show("Pasahitz zaharra ez da datubasekoaren berdina")
                DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()
            End If
        End If
    End Sub

    Protected Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class