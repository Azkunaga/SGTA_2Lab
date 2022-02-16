﻿Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnErregistratu_Click(sender As Object, e As EventArgs) Handles btnErregistratu.Click
        If String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtIzena.Text) Or String.IsNullOrEmpty(txtAbizena.Text) Or String.IsNullOrEmpty(txtNAN.Text) Or String.IsNullOrEmpty(txtGalderaEzkutua.Text) Or String.IsNullOrEmpty(txtErantzuna.Text) Or String.IsNullOrEmpty(txtErabMota.Text) Or String.IsNullOrEmpty(txtAzpiKodea.Text) Or String.IsNullOrEmpty(txtLanKodea.Text) Then
            lblErrMezu.Text = "Eremu guztiak bete behar dira"
        Else
            Dim egiaztatzeZenbakia As Integer = CLng(Rnd() * 9000000) + 1000000
            DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaTxertatu(txtEmail.Text, txtIzena.Text, txtAbizena.Text, txtGalderaEzkutua.Text, txtErantzuna.Text, txtNAN.Text, egiaztatzeZenbakia, 0, txtLanKodea.Text, txtAzpiKodea.Text, txtErabMota.Text, txtPasahitza.Text)

            hylEgiaztatu.Enabled = True
        End If
    End Sub
End Class