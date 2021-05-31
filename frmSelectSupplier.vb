Imports MySql.Data.MySqlClient
Public Class frmSelectSupplier
    Private Sub frmSelectSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_supplier", dgvSupplier)
        dgvSupplier.ClearSelection()
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM tbl_supplier WHERE supplierID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmReceiving
            .lblsupplierCom.Text = table.Rows(0)(2).ToString
            .lblsupplierName.Text = table.Rows(0)(3).ToString
        End With
        adapt.Dispose()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            'loaddgv("SELECT * FROM tbl_finishedproducts WHERE prodName LIKE '%" & txtSearch.Text & "%'", dgvProduct)
            Call loaddgv("SELECT * FROM tbl_supplier WHERE supplierName LIKE '%" & txtSearch.Text & "%'", dgvSupplier)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub dgvSupplier_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
      

        If e.RowIndex >= 0 Then
            dgvSupplier.Tag = dgvSupplier.Item(0, e.RowIndex).Value
            '  select Supplier from frmReceive

        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Len(dgvSupplier.Tag) = 0 Then
            MsgBox("Select Record!", vbCritical)
        Else
            frmPurchasedReq.lblSupId.Text = dgvSupplier.CurrentRow.Cells(0).Value
            frmPurchasedReq.lblsupplierCom.Text = dgvSupplier.CurrentRow.Cells(2).Value
            frmPurchasedReq.lblsupplierName.Text = dgvSupplier.CurrentRow.Cells(3).Value
            ' Call fetchdata(Val(dgvSupplier.Tag))
            Me.Close()
        End If
    End Sub

    Private Sub dgvSupplier_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellContentClick

    End Sub
End Class