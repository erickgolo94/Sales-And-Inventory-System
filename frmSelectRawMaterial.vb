Imports MySql.Data.MySqlClient
Public Class frmselectRawmaterial
    Private Sub frmselectRawmaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        'Call loaddgv("SELECT * FROM vw_rawmaterial WHERE", dgvRawmaterial)
        loaddgv("SELECT rawmaterialID,rawmaterialName,`desc`,catDesc,unitDesc,sum(qty) AS qty FROM vw_rawmaterialonhand GROUP BY rawmaterialName,`desc`,catDesc,unitDesc ORDER BY rawmaterialName DESC LIMIT 14", dgvRawmaterial)
        warning()
        dgvRawmaterial.ClearSelection()
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
            .lblName.Text = table.Rows(0)(1).ToString
            .lbldesc.Text = table.Rows(0)(2).ToString
            .lblCat.Text = table.Rows(0)(3).ToString
            .lblUnit.Text = table.Rows(0)(4).ToString
        End With
        adapt.Dispose()
    End Sub
    Private Sub fetchdataAddReqform(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM vw_rawmaterial WHERE rawmaterialID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmRequestForm
            .lblRawMaterialID.Text = table.Rows(0)(0)
            .lblRawmaterialName.Text = table.Rows(0)(10).ToString
            .lblDesc.Text = table.Rows(0)(11).ToString
            .lblCat.Text = table.Rows(0)(12).ToString
            .lblUnit.Text = table.Rows(0)(13).ToString
        End With
        adapt.Dispose()
    End Sub
    Private Sub fetchdatapurchased(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM vw_rawmaterial WHERE rawmaterialID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmPurchasedReq
            .lblrawmaterialID.Text = table.Rows(0)(0)
            .lblName.Text = table.Rows(0)(1).ToString
            .lblDesc.Text = table.Rows(0)(2).ToString
            .lblCat.Text = table.Rows(0)(3).ToString
            .lblUnit.Text = table.Rows(0)(4).ToString
        End With
        adapt.Dispose()
    End Sub

    Private Sub dgvSupplier_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRawmaterial.CellClick
        If e.RowIndex >= 0 Then
            dgvRawmaterial.Tag = dgvRawmaterial.Item(0, e.RowIndex).Value
            OnhandsQty = dgvRawmaterial.Item(5, e.RowIndex).Value


            OnhandsQty = dgvRawmaterial.CurrentRow.Cells(5).Value
            'MessageBox.Show(OnhandsQty)
            'AddReqFor()
            '  Call fetchdataAddReqform(Val(dgvRawmaterial.Tag))

            With frmReqFormError
                .btnAddList.Enabled = True
                .btnDelete.Enabled = False
                .btnUpdate.Enabled = False
            End With
        End If



        'Purchase()



        'rawMaterialPurchased()

        'Call fetchdatapurchased(Val(dgvRawmaterial.Tag))
        'Me.Close()

        'frmReceive
        'Call fetchdataReceive(Val(dgvRawmaterial.Tag))
        ' Me.Close()


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loaddgv("SELECT * FROM vw_rawmaterial WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%' ", dgvRawmaterial)
    End Sub


    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If Len(dgvRawmaterial.Tag) = 0 Then
            MsgBox("Select Record!", vbCritical)
        Else

            frmRequestForm.lblRawMaterialID.Text = dgvRawmaterial.CurrentRow.Cells(0).Value
            frmRequestForm.lblRawmaterialName.Text = dgvRawmaterial.CurrentRow.Cells(1).Value
            frmRequestForm.lblDesc.Text = dgvRawmaterial.CurrentRow.Cells(2).Value
            frmRequestForm.lblCat.Text = dgvRawmaterial.CurrentRow.Cells(3).Value
            frmRequestForm.lblUnit.Text = dgvRawmaterial.CurrentRow.Cells(4).Value

            Me.Close()

            Call fetchdatapurchased(Val(dgvRawmaterial.Tag))
            With frmPurchasedReq
                .btnAddList.Enabled = True
            End With

            Me.Close()
        End If
        frmRequestForm.txtQty.Focus()
    End Sub
    Private Sub warning()
        Try
            'Set the Variables to Initialize into 0

            For i As Integer = 0 To dgvRawmaterial.Rows.Count() - 1 Step +1
                'Set or create another variable to the will hold variable as count
                Dim pr As Integer

                pr = dgvRawmaterial.Rows(i).Cells(5).Value
                If pr <= 1 Then
                    dgvRawmaterial.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    dgvRawmaterial.Rows(i).DefaultCellStyle.ForeColor = Color.White

                ElseIf pr >= 2 And pr <= 50 Then
                    dgvRawmaterial.Rows(i).DefaultCellStyle.BackColor = Color.Yellow

                Else
                    dgvRawmaterial.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
End Class