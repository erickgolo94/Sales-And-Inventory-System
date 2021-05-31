Imports MySql.Data.MySqlClient
Public Class frmSelectReqPO
    Private Sub frmSelectReqPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_supplier", dgvSupplierPO)
        dgvSupplierPO.ClearSelection()
    End Sub

    Private Sub btnSearchPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPO.Click
        Call loaddgv("SELECT * FROM tbl_supplier WHERE supplierName LIKE '%" & txtSearchPO.Text & "%'", dgvSupplierPO)
    End Sub

    Private Sub dgvSupplierPO_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplierPO.CellClick

    End Sub

    Private Sub btnSelectPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPO.Click

    End Sub

    Private Sub dgvSupplierPO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplierPO.CellContentClick

    End Sub
End Class