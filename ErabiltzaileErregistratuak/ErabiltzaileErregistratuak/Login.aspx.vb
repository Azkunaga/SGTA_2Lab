Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn2Login_Click(sender As Object, e As EventArgs) Handles btn2Login.Click

    End Sub

    Protected Sub btn2Erregistratu_Click(sender As Object, e As EventArgs) Handles btn2Erregistratu.Click
        Response.Redirect("Erregistratu.aspx")
    End Sub

    Protected Sub btnPasaBerr_Click(sender As Object, e As EventArgs) Handles btnPasaBerr.Click
        Response.Redirect("PasahitzaBerreskuratu.aspx")
    End Sub
End Class