Imports MySql.Data.MySqlClient
Public Class frmReqFormView

    Private Sub frmReqFormView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loaddgv("SELECT * FROM vw_reqsuppliess ORDER BY reqSupNo DESC", dgvReqSup)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim table As New DataTable()
            Dim command As New MySqlCommand("SELECT * FROM vw_reqsuppliess WHERE dateRequest BETWEEN @r1 AND @r2", modcon.con)

            command.Parameters.Add("@r1", MySqlDbType.Date).Value = dtpReqFrom.Value
            command.Parameters.Add("@r2", MySqlDbType.Date).Value = dtpReqTo.Value
            Dim adap As New MySqlDataAdapter(command)
            adap.Fill(table)
            dgvReqSup.DataSource = table

            command.Dispose()
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
      
        frmReqSuppliesReport.Show()
    End Sub
End Class