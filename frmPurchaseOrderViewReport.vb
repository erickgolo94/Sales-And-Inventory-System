Imports MySql.Data.MySqlClient
Public Class frmPurchaseOrderViewReport

    Private Sub frmPurchaseOrderViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT purchaseNo,reqBy,dept,remarks,dateRequest FROM vw_purchasereqmain GROUP BY purchaseNo,reqBy,dept,remarks,dateRequest ORDER BY purchaseNo", dgvrequisition)
    End Sub
End Class