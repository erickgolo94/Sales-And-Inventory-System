Public Class frmPurchaseOrderView

    Private Sub frmPurchaseOrderView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT DISTINCT purchaseNo,reqBy,dept,remarks,dateRequest FROM vw_purchasereqmain ORDER BY purchaseNo DESC", dgvrequisition)
        dgvrequisition.ClearSelection()
    End Sub

    Private Sub dgvrequisition_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvrequisition.CellClick
        If e.RowIndex >= 0 Then
            dgvrequisition.Tag = dgvrequisition.Item(0, e.RowIndex).Value ',
            Call loaddgv("SELECT * FROM vw_purchasereqmain WHERE purchaseNo LIKE '%" & dgvrequisition.Tag & "%' ORDER BY purchaseNo DESC", dgvPurchase)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call loaddgv("SELECT DISTINCT purchaseNo,reqBy,dept,remarks,dateRequest FROM vw_purchasereqmain WHERE reqBy LIKE '%" & Trim(txtSearch.Text) & "%' ORDER BY purchaseNo DESC", dgvrequisition)
    End Sub
End Class