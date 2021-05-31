Imports MySql.Data.MySqlClient
Public Class frmPendingReq

    Private Sub frmPendingReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT DISTINCT reqSupNo,reqBy,dept,remarks,dateRequest FROM tbl_reqsupplies WHERE is_active=1 ORDER BY reqSupNo DESC", dgvRequest)
    End Sub

    Private Sub dgvViewRelease_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRequest.CellClick
        If e.RowIndex >= 0 Then
            dgvRequest.Tag = dgvRequest.Item(0, e.RowIndex).Value
            Call loaddgv("SELECT * FROM vw_reqsupplies WHERE reqSupNo LIKE '%" & Trim(dgvRequest.Tag) & "%' ", dgvViewSup)

        End If
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        Dim str As String = "SELECT * FROM vw_reqsupplies WHERE reqSupID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        lblReqSup.Text = table.Rows(0)(1)
        lblName.Text = table.Rows(0)(7)
        lblDesc.Text = table.Rows(0)(8)
        lblCat.Text = table.Rows(0)(9)
        lblUnit.Text = table.Rows(0)(10)
        lblqty.Text = table.Rows(0)(11)
        adapt.Dispose()
    End Sub

    Private Sub dgvViewSup_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvViewSup.CellClick
        If e.RowIndex >= 0 Then
            dgvViewSup.Tag = dgvViewSup.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvViewSup.Tag))
        End If
    End Sub
End Class