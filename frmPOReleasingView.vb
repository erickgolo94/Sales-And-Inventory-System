Public Class frmPOReleasingView

    Private Sub frmPOReleasingView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM vw_purchaserequestrelease ORDER BY purchaseNo DESC", dgvReqSup)
    End Sub
End Class