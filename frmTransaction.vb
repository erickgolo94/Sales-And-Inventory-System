Imports MySql.Data.MySqlClient
Public Class frmTransaction
    'tbl_transaction
    Public varGetSum As Double
    Public varGetidRemove As Long
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmTransAdd.Click
        frmTransactionAdd.ShowDialog()
        cleaner()
    End Sub
    Private Sub cleaner()
        frmTransactionAdd.lblproductname.Text = ""
        frmTransactionAdd.lbldesc.Text = ""
        frmTransactionAdd.lblcategory.Text = ""
        frmTransactionAdd.txtprice.Text = ""
        frmTransactionAdd.txtqty.Text = ""
        frmTransactionAdd.txtunitprice.Text = ""
    End Sub

  
    Private Sub getsumOfItems()
        Dim rdr As MySqlDataReader

        Try
            cmd = New MySqlCommand("SELECT SUM(price) AS _price FROM tbl_temptransaction", modcon.con)
            rdr = cmd.ExecuteReader

            If rdr.HasRows Then
                rdr.Read()

                varGetSum = rdr.Item("_price")
                salestotal = rdr.Item("_price")
                'MessageBox.Show(varGetSum)

                frmTransactionRelease.txtTotal.Text = Format(varGetSum, "###,##0.00")
                rdr.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()

        End Try

    End Sub


    Private Sub frmTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        modcon.main()
        loaddgv("SELECT salesID,itemID,endProduct,description,category,unit,qty,untPrice,price,finprodID FROM tbl_temptransaction ORDER BY salesID DESC", dgvTemptransaction)
        dgvTemptransaction.Columns(7).DefaultCellStyle.Format = "#####00.00"
        dgvTemptransaction.Columns(8).DefaultCellStyle.Format = "#####00.00"
        txtTime.Text = TimeOfDay
        txtDate.Text = DateString
        'getsumOfItems()
        autoid()
    End Sub

    Private Sub btnFrmTransRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmTransRelease.Click

        getsumOfItems()
        updaterecid = frmTransactionAdd.lblItemd.Text
        frmTransactionRelease.ShowDialog()
    End Sub

    Private Sub dgvTemptransaction_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTemptransaction.CellClick
        If e.RowIndex >= 0 Then
            dgvTemptransaction.Tag = dgvTemptransaction.Item(0, e.RowIndex).Value
            idRemove = Val(dgvTemptransaction.Tag)
            '  idRemove = dgvTemptransaction.CurrentRow.Cells(0).Value
            qtyUppdate = dgvTemptransaction.Item(6, e.RowIndex).Value
            finId = dgvTemptransaction.Item(9, e.RowIndex).Value


        End If
        'MessageBox.Show(qtyUppdate)
        'varGetidRemove = dgvTemptransaction.CurrentRow.Cells(0).Value
        'qtyUppdate = dgvTemptransaction.CurrentRow.Cells(7).Value
        'finId = dgvTemptransaction.CurrentRow.Cells(9).Value

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If Val(dgvTemptransaction.Tag) < 0 Then
            MsgBox("Please you must select a record first", MsgBoxStyle.Critical)
        Else
            '  MessageBox.Show(varGetidRemove)
            Try
                modcon.main()
                If MessageBox.Show("Remove this currently item?", "PETROMINE SALES AND INVENTORY", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim sql As String = "DELETE FROM tbl_temptransaction WHERE salesID = " & idRemove & ""
                    Dim cmd1 As New MySqlCommand(sql, modcon.con)
                    cmd1.ExecuteNonQuery()
                    cmd1.Dispose()

                    MessageBox.Show("DELETED")
                    sqlQuery("UPDATE tbl_finishedproducts SET qty = qty + " & qtyUppdate & " WHERE finprodID = " & finId & "")
                    loaddgv("SELECT salesID,itemID,endProduct,description,category,unit,qty,untPrice,price,finprodID FROM tbl_temptransaction ORDER BY salesID DESC", dgvTemptransaction)
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
    End Sub
  
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MsgBox("You are about to exit, Proceed anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cleaner()
            Me.Close()

        End If
    End Sub
    Private Function autoid() As Boolean


        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Try
            modcon.main()
            cmd = New MySqlCommand("SELECT * FROM tbl_maintransaction ORDER BY salesID DESC", modcon.con)
            rd = cmd.ExecuteReader
            If (rd.Read = True) Then
                salesId = rd(CInt(1)) + 1

                'Me.lblupdate.Text = rd(CInt(0))
                'updateid = Val(lbltransactionID.Text)
                '  lbltransactionID.Text = frmTransactionAdd.lblItemd.Text
                frmTransactionAdd.lblItemd.Text = salesId
            Else
                salesId = 100

                rd.Dispose()
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
        Return True
    End Function

    Private Sub txtTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTime.Click

    End Sub

    Private Sub dgvTemptransaction_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTemptransaction.CellContentClick

    End Sub
End Class