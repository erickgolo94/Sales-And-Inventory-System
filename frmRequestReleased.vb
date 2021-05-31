Imports MySql.Data.MySqlClient
Public Class frmRequestReleased
    Private Sub frmRequestReleased_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT DISTINCT reqSupNo,reqBy,dept,remarks,dateRequest,releaseBy,deptEmp,dateReleased FROM vw_releasing ORDER BY reqSupNo DESC", dgvViewRelease)
    End Sub

    Private Sub dgvRequest_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRequest.CellClick
        If e.RowIndex >= 0 Then
            dgvRequest.Tag = dgvRequest.Item(0, e.RowIndex).Value
            Call loaddgv("SELECT * FROM vw_reqsupplies WHERE reqSupNo LIKE '%" & Trim(dgvRequest.Tag) & "%' ", dgvViewSup)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Try

            Dim sQlQuery As String = "SELECT * FROM vw_releasing WHERE dateReleased BETWEEN @d1 AND @d2"
            Dim cmd1 As New MySqlCommand(sQlQuery, modcon.con)

            cmd1.Parameters.Add("@d1", MySqlDbType.Date).Value = dtpReqFrom.Value
            cmd1.Parameters.Add("@d2", MySqlDbType.Date).Value = dtpReqTo.Value
            Dim adapter As New MySqlDataAdapter(cmd1)
            adapter.Fill(table)

            dgvRequest.DataSource = table

            cmd1.Dispose()
            adapter.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class