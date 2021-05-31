Imports MySql.Data.MySqlClient
Public Class frmSelectPurchaseReq

    Public id As Long
    Private Sub frmSelectPurchaseReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT purchaseID, purchaseNo, reqBy, dept, remarks,company, supplierName, dateRequest FROM vw_purchasereqmain ORDER BY purchaseID DESC", dgvPurchase)
    End Sub
    Private Sub fetchdatareq(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String
            str = "SELECT * FROM vw_purchasereqmain WHERE purchaseNo=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            With frmReceivingPO
                id = table.Rows(0)(1).ToString
                .lblReqNo.Text = table.Rows(0)(1).ToString
                .lblReqBy.Text = table.Rows(0)(2).ToString
                .lbldept.Text = table.Rows(0)(3).ToString
                .lblremarks.Text = table.Rows(0)(4).ToString
                .dtpDateRequested.Value = table.Rows(0)(5)
                '.AddWithValue("", Format(dtpDateRelease.Value, "MM-DD-yyyy"))
            End With
            adapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call loaddgv("SELECT purchaseID, purchaseNo, reqBy, dept, remarks, dateRequest FROM vw_purchasereqmain WHERE reqBy LIKE '%" & Trim(txtSearch.Text) & "%' ORDER BY reqBy", dgvPurchase)
        'Call loaddgv("SELECT * FROM vw_purchasereqmain WHERE reqBy LIKE '%" & Trim(txtSearch.Text) & "%' ", dgvPurchase)
    End Sub

    Private Sub dgvPurchase_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPurchase.CellClick
        If e.RowIndex >= 0 Then
            dgvPurchase.Tag = dgvPurchase.Item(0, e.RowIndex).Value
        End If
    End Sub

    Private Sub dgvPurchase_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPurchase.CellContentClick

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Len(dgvPurchase.Tag) = 0 Then
            MsgBox("Select Record", vbCritical)
        Else
            'Call fetchdatareq(CLng(id))
            selectingFetch()
            Call loaddgv("SELECT purchaseID, qty, rawmaterialName, `desc`, catDesc, unitDesc FROM vw_purchasereqmain WHERE purchaseNo like '%" & IDPO & "%' ORDER BY purchaseNo DESC", frmReceivingPO.dgvReqPO)
            frmReceivingPO.txtDeliveryReportNo.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub selectingFetch()
        removePurchaseReq = dgvPurchase.CurrentRow.Cells(0).Value 'This variable from module sent data to hold remove
        PURCHASEID = dgvPurchase.CurrentRow.Cells(0).Value
        '  frmReceivingPO.lblModifyQtyid.Text = dgvPurchase.CurrentRow.Cells(0).Value
        IDPO = dgvPurchase.CurrentRow.Cells(1).Value
        frmReceivingPO.lblReqNo.Text = dgvPurchase.CurrentRow.Cells(1).Value
        frmReceivingPO.lblReqBy.Text = dgvPurchase.CurrentRow.Cells(2).Value
        frmReceivingPO.lbldept.Text = dgvPurchase.CurrentRow.Cells(3).Value
        frmReceivingPO.lblremarks.Text = dgvPurchase.CurrentRow.Cells(4).Value
        frmReceivingPO.lblsupplierCom.Text = dgvPurchase.CurrentRow.Cells(5).Value
        frmReceivingPO.lblsupplierName.Text = dgvPurchase.CurrentRow.Cells(6).Value
        frmReceivingPO.dtpDateRequested.Value = dgvPurchase.CurrentRow.Cells(7).Value
        Me.Close()
        '  frmReceivingPO.lblReqNo.Text = dgvPurchase.CurrentRow.Cells().value


    End Sub
End Class