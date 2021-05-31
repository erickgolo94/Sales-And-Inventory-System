Imports MySql.Data.MySqlClient
Public Class frmTransactionView

    Private Sub frmTransactionView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modcon.main()
        '    loaddgv("SELECT itemID,endProduct,description,category,unit,qty,untPrice,price,tDate FROM vw_SaleTransaction ORDER BY itemID DESC", dgvTemptransaction)
        'loaddgv("SELECT * FROM vw_maintransaction ORDER BY salesID DESC LIMIT 25", dgvTemptransaction)
        loaddgv("SELECT * FROM vw_maintransaction ORDER BY salesID DESC LIMIT 25", dgvTemptransaction)
        dgvRawMaterialOnhand.ClearSelection()
    End Sub
    Private Sub btnDateSerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateSerch.Click
        Try

            Dim sQlQuery As String = "SELECT * FROM vw_maintransaction WHERE sDate BETWEEN @d1 AND @d2"
            Dim cmd1 As New MySqlCommand(sQlQuery, modcon.con)

            cmd1.Parameters.Add("@d1", MySqlDbType.Date).Value = dtpFrom.Value
            cmd1.Parameters.Add("@d2", MySqlDbType.Date).Value = dtpTo.Value
            Dim adapter As New MySqlDataAdapter(cmd1)
            adapter.Fill(table)

            dgvTemptransaction.DataSource = table

            cmd1.Dispose()
            adapter.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class