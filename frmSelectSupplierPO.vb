Imports MySql.Data.MySqlClient
Public Class frmSelectSupplierPO

    Private Sub frmSelectSupplierPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_supplier", dgvSupplierPO)
        'dgvSupplierPO.ClearSelection()
    End Sub

    Private Sub btnSearchPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPO.Click
        Call loaddgv("SELECT * FROM tbl_supplier WHERE supplierName LIKE '%" & txtSearchPO.Text & "%'", dgvSupplierPO)
    End Sub

    Private Sub btnSelectPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPO.Click

        If Val(dgvSupplierPO.Tag) < 0 Then
            MsgBox("Select Record", vbCritical)
        Else
            fetchSupplier()
            '  frmReceivingPO.txtDeliveryReportNo.Focus()
            Me.Close()
        End If

    End Sub
    Private Sub fetchSupplier()
        SUPPLIERID = dgvSupplierPO.CurrentRow.Cells(0).Value
        frmReceivingPO.lblsupplierCom.Text = dgvSupplierPO.CurrentRow.Cells(2).Value
        frmReceivingPO.lblsupplierName.Text = dgvSupplierPO.CurrentRow.Cells(3).Value
    End Sub
End Class