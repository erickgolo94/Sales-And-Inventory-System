Imports MySql.Data.MySqlClient
Public Class frmOnhand

    Private Sub frmOnhand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,sum(qty) AS qty FROM vw_rawmaterialonhand GROUP BY rawmaterialName,`desc`,catDesc,unitDesc ORDER BY rawmaterialName LIMIT 14", dgvRawMaterialOnhand)
        'sloaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,SUM(qty) AS qty FROM vw_rawmaterialonhand GROUP BY `desc`, rawmaterialName ORDER BY transactionNo DESC LIMIT 14", dgvRawMaterialOnhand)
        dgvRawMaterialOnhand.ClearSelection()
        warning()
        txtTime.Text = TimeOfDay
        txtDate.Text = DateString
        tsUSER.Text = labelUser
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call loaddgv("SELECT * FROM vw_rawmaterialonhand WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%'", dgvRawMaterialOnhand)
    End Sub

    'Private Sub dgvRawMaterialOnhand_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRawMaterialOnhand.CellClick
    ' If e.RowIndex >= 0 Then
    '   dgvRawMaterialOnhand.Tag = dgvRawMaterialOnhand.Item(0, e.RowIndex).Value
    'End If
    ' End Sub
    Private Sub warning()

        Try
            'Set the Variables to Initialize into 0

            For i As Integer = 0 To dgvRawMaterialOnhand.Rows.Count() - 1 Step +1
                'Set or create another variable to the will hold variable as count
                Dim pr As Integer

                pr = dgvRawMaterialOnhand.Rows(i).Cells(14).Value
                If pr <= 1 Then
                    dgvRawMaterialOnhand.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    dgvRawMaterialOnhand.Rows(i).DefaultCellStyle.ForeColor = Color.White

                ElseIf pr >= 2 And pr <= 50 Then
                    dgvRawMaterialOnhand.Rows(i).DefaultCellStyle.BackColor = Color.Yellow

                Else
                    dgvRawMaterialOnhand.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub dgvRawMaterialOnhand_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRawMaterialOnhand.CellClick

        'Cell event for evety single row selected from dgv tag
        ' Me.lblrawmaterialonhandrn.Text = dgvRawMaterialOnhand.CurrentRow.Cells(0).Value
        ' Me.lblrawmaterialonhandrno.Text = Me.dgvRawMaterialOnhand.CurrentRow.Cells(9).Value
        Me.lblrawmaterialonhandrmn.Text = Me.dgvRawMaterialOnhand.CurrentRow.Cells(10).Value
        Me.lblrawmaterialonhandcat.Text = Me.dgvRawMaterialOnhand.CurrentRow.Cells(12).Value
        Me.lblrawmaterialonhandunit.Text = Me.dgvRawMaterialOnhand.CurrentRow.Cells(13).Value
        Me.lblrawmaterialonhandqty.Text = Me.dgvRawMaterialOnhand.CurrentRow.Cells(14).Value
        'dgvViewSup.Tag = dgvViewSup.Item(0, e.RowIndex).Value
    End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    '   loaddgv("SELECT * FROM vw_rawmaterialonhand WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%'", dgvRawMaterialOnhand)
    'End Sub

End Class