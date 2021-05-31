Imports MySql.Data.MySqlClient
Public Class frmSelectRawmaterialReceiving

    Private Sub frmSelectRawmaterialReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modcon.main()
        loaddgv("SELECT rawmaterialID,rawmaterialName,`desc`,catDesc,unitDesc,sum(qty) AS qty FROM vw_rawmaterialonhand GROUP BY rawmaterialName,`desc`,catDesc,unitDesc ORDER BY rawmaterialName ", dgvSelectRawReceiving)
        dgvSelectRawReceiving.ClearSelection()
    End Sub
    Private Sub fetchdataReceive(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM vw_rawmaterial WHERE rawmaterialID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmReceiving
            .lblrawmaterialID.Text = table.Rows(0)(0)
            lblID.Text = table.Rows(0)(0)
            .lblName.Text = table.Rows(0)(1).ToString
            .lbldesc.Text = table.Rows(0)(2).ToString
            .lblCat.Text = table.Rows(0)(3).ToString
            .lblUnit.Text = table.Rows(0)(4).ToString
            'lblgetqty.Text = table.Rows(0)(5).ToString
        End With
        adapt.Dispose()
    End Sub

    Private Sub dgvSelectRawReceiving_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSelectRawReceiving.CellClick
        If e.RowIndex >= 0 Then
            dgvSelectRawReceiving.Tag = dgvSelectRawReceiving.Item(0, e.RowIndex).Value
            lblID.Text = dgvSelectRawReceiving.Item(0, e.RowIndex).Value
            lblgetqty.Text = dgvSelectRawReceiving.CurrentRow.Cells(5).Value
            idUpdateForreceiving = dgvSelectRawReceiving.CurrentRow.Cells(0).Value
            ' frmModifyQuantityReceving.lblqty.Text = dgvSelectRawReceiving.CurrentRow.Cells(5).Value
            'frmModifyQuantityReceving.lblrawmaterialID.Text = dgvSelectRawReceiving.CurrentRow.Cells(0).Value


            'frmReceive

        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ' loaddgv("SELECT rawmaterialID,rawmaterialName,`desc`,catDesc,unitDesc,sum(qty) AS qty FROM vw_rawmaterialonhand GROUP BY rawmaterialName,`desc`,catDesc,unitDesc ORDER BY rawmaterialName ", dgvSelectRawReceiving)
        Try
            If Len(txtSearch.Text) = 0 Then
                MsgBox("No Data Entry!", vbCritical)



            Else
                Call loaddgv("SELECT * FROM vw_rawmaterial WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%'", dgvSelectRawReceiving)
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)

        End Try


    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Call loaddgv("SELECT * FROM vw_rawmaterial WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%'", dgvSelectRawReceiving)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        ' frmReceiving.txtqty.Focus()
        If Len(dgvSelectRawReceiving.Tag) = 0 Then
            MsgBox("Select Record!", vbCritical)
        Else
            ' MessageBox.Show("PLease enter select to the rawmaterial", "PETROMINE SALES AND INVENTORY")
            Call fetchdataReceive(Val(dgvSelectRawReceiving.Tag))


            Me.Close()
        End If
        frmReceiving.txtqty.Focus()
    End Sub
   
End Class