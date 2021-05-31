Imports MySql.Data.MySqlClient
Public Class frmRecievedRawmaterialView

    Private Sub frmRecievedRawmaterialView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loaddgv("SELECT * FROM vw_rawmaterialonhand ORDER BY rawmaterialonhandID DESC", dgvRawMaterialOnhand)
        dgvRawMaterialOnhand.ClearSelection()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim tbl As New DataTable()
            Dim cmd1 As New MySqlCommand("SELECT * FROM vw_rawmaterialonhand WHERE deliveryRepDate BETWEEN @f1 AND @f2", modcon.con)
            cmd1.Parameters.Add("@f1", MySqlDbType.Date).Value = dtpReceiveFrom.Value
            cmd1.Parameters.Add("@f2", MySqlDbType.Date).Value = dtpReceiveTo.Value

            Dim ad As New MySqlDataAdapter(cmd1)
            ad.Fill(tbl)
            dgvRawMaterialOnhand.DataSource = tbl

        Catch ex As Exception

        End Try
    End Sub
End Class