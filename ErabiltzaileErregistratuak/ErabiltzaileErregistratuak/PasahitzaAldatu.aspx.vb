Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class WebForm7
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnPasaAlda_Click(sender As Object, e As EventArgs) Handles btnPasaAlda.Click
        Dim drErabiltzaileak As SqlDataReader
        drErabiltzaileak = DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu(Session.Contents("emaila").ToString)
        If String.Equals(drErabiltzaileak.Item("pasahitza"), txtOldPass.Text) Then
            If String.Equals(txtNewPass.Text, txtNewPass2.Text) Then
                DatuAtzipenekoak.DatuAtzipena.ErabiltzailearenPasahitzaAldatu(Session.Contents("emaila").ToString, txtNewPass.Text)
            Else
                MessageBox.Show("Pasahitz berriak ez dira berdinak")
            End If
        Else
            MessageBox.Show("Pasahitz zaharra ez da datubasekoaren berdina")
        End If
    End Sub
End Class