Imports MySql.Data.MySqlClient
Public Class frmSelectRequest
    Private Sub frmSelectRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT DISTINCT reqSupNo,reqBy,dept,remarks,dateRequest FROM tbl_reqsupplies WHERE is_active=1 ORDER BY reqSupNo DESC", dgvReqNo)
        dgvReqNo.ClearSelection()
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String
            str = "SELECT * FROM vw_reqsuppliess where reqSupNo=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            With frmReleasing
                .lblReqNo.Text = table.Rows(0)(1)
                .lblReqBy.Text = table.Rows(0)(2)
                .lbldept.Text = table.Rows(0)(3)
                .lblremarks.Text = table.Rows(0)(4)
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

    Private Sub dgvReqNo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReqNo.CellClick
        If e.RowIndex >= 0 Then
            dgvReqNo.Tag = dgvReqNo.Item(0, e.RowIndex).Value
            idRelease = dgvReqNo.Item(0, e.RowIndex).Value

            'AddReqForm
           
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call loaddgv("SELECT DISTINCT reqSupNo,reqBy,dept,remarks,dateRequest FROM tbl_mainreqsupplies WHERE reqBy like '%" & Trim(txtSearch.Text) & "%'", dgvReqNo)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Len(dgvReqNo.Tag) = 0 Then
            MsgBox("Select Record", vbCritical)
        Else
            Call fetchdata(Val(dgvReqNo.Tag))
            Call loaddgv("SELECT * FROM vw_reqsuppliess WHERE reqSupNo like '%" & Val(dgvReqNo.Tag) & "%' ORDER BY reqSupNo", frmReleasing.dgvReqSup)
            Me.Close()
        End If
    End Sub
End Class