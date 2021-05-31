Imports MySql.Data.MySqlClient
Public Class frmEndProd
    Private Sub frmEndProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        autoid()
        'table name:     tbl_endproductOnHand
        Call loaddgv("SELECT * FROM vw_finishedproducts ORDER BY finprodID DESC", dgvProduct)
        Call loadcmb("SELECT * FROM tbl_category ORDER BY catDesc", cmbCat, "catDesc", "catID")
        Call loadcmb("SELECT * FROM tbl_unit ORDER BY unitDesc", cmbUnit, "unitDesc", "unitID")
        dgvProduct.ClearSelection()
        dgvProduct.Columns(4).DefaultCellStyle.Format = "###,##0.00"

    End Sub
    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnlData.Enabled = Not bool
        dgvProduct.Enabled = bool

    End Sub
    Private Sub autoid()
        Dim cmd As New MySqlCommand

        Try
            modcon.main()
            cmd = New MySqlCommand("SELECT finprodID from tbl_finishedproducts ORDER BY finprodID DESC", modcon.con)
            Dim rd As MySqlDataReader = cmd.ExecuteReader
            If (rd.Read = True) Then
                Me.lblproductId.Text = rd(CInt(0)) + 1
            Else
                Me.lblproductId.Text = 100
            End If

            cmd.Dispose()
            con.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try

    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As New DataTable
            Dim str As String = "SELECT * FROM vw_finishedproducts WHERE finprodID=" & id
            adapt = New MySqlDataAdapter(str, con)
            adapt.Fill(table)
            txtProdName.Text = table.Rows(0)(1).ToString
            txtdesc.Text = table.Rows(0)(2).ToString
            cmbCat.Text = table.Rows(0)(3).ToString
            cmbUnit.Text = table.Rows(0)(4).ToString
            txtPrice.Text = table.Rows(0)(5).ToString
            txtQty.Text = table.Rows(0)(6).ToString
            adapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub dgvProduct_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellClick
        If e.RowIndex >= 0 Then
            dgvProduct.Tag = dgvProduct.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvProduct.Tag))
        End If
    End Sub

    Private Sub cleaner()
        For Each obj As Object In pnlData.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub
    Private Function checker() As Boolean
        For Each obj As Object In pnlData.Controls
            If TypeOf obj Is TextBox Then
                If Len(obj.text) = 0 Then
                    MsgBox("insufficient data", vbInformation)
                    obj.focus()
                    checker = False
                    Exit Function

                End If
            End If
        Next
        checker = True
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' txtProdName.Focus()
        autoid()
        txtProdName.Focus()
        Call toggle(False)
        Call cleaner()
       

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            Call toggle(True)
            Call cleaner()
            '  btnUpdate.Hide()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checker() = True Then
            If Len(dgvProduct.Tag) = 0 Then
                save()
                ' Try
                'modcon.main()
                ' cmd = New MySqlCommand("INSERT INTO tbl_finishedproducts(prodName, descrip, catID, unitID, price, qty) VALUES (?,?,?,?,?,?)", modcon.con)
                '  With cmd.Parameters
                '.AddWithValue("", txtProdName.Text.Trim)
                '   .AddWithValue("", txtdesc.Text.Trim)
                '   .AddWithValue("", cmbCat.SelectedValue)
                '   .AddWithValue("", cmbUnit.SelectedValue)
                '   .AddWithValue("", txtPrice.Text)
                '   .AddWithValue("", txtQty.Text)
                '   End With
                '   cmd.ExecuteNonQuery()
                '   cmd.Dispose()
                '   MessageBox.Show("Record Sucessfully Saved", "PETROMINE SALES AND INVENTORY")
                '   Call loaddgv("SELECT * FROM vw_finishedproducts ORDER BY finprodID DESC", dgvProduct)
                '   Catch ex As MySqlException
                'MessageBox.Show(ex.Message.ToString)
                '   Finally
                'GC.Collect()
                '   End Try
            End If
        End If

    End Sub
    Private Function save() As Boolean
        Try
            modcon.main()
            cmd = New MySqlCommand("INSERT INTO tbl_finishedproducts(prodName, descrip, catID, unitID, price, qty)VALUES(?,?,?,?,?,?)", modcon.con)
            cmd.Parameters.AddWithValue("", txtProdName.Text.Trim)
            cmd.Parameters.AddWithValue("", txtdesc.Text.Trim)
            cmd.Parameters.AddWithValue("", cmbCat.SelectedValue)
            cmd.Parameters.AddWithValue("", cmbUnit.SelectedValue)
            cmd.Parameters.AddWithValue("", txtPrice.Text)
            cmd.Parameters.AddWithValue("", txtQty.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MessageBox.Show("Record Sucessfully Saved", "PETROMINE SALES AND INVENTORY")
            loaddgv("SELECT prodName, descrip, catDesc, unitDesc, price, qty FROM vw_finishedproducts ORDER BY finprodID DESC", dgvProduct)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return True
    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Len(dgvProduct.Tag) = 0 Then
            MsgBox("Select a Record!", vbInformation)
        Else
            If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "EDIT FROM tbl_finishedproducts WHERE finprodID=" & Val(dgvProduct.Tag)
                cmd = New MySqlCommand(str, con)
                txtProdName.Focus()
                btnUpdate.Show()
                Call toggle(False)
                btnSave.Enabled = False
            End If
        End If
        
    End Sub

  

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                e.KeyChar = e.KeyChar
            Case Else
                e.KeyChar = ""
        End Select
 

        If Asc(e.KeyChar) <> 14 AndAlso Asc(e.KeyChar) <> 9 And Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case Chr(9)
            Case "."
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtProdName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProdName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Val(dgvProduct.Tag) < 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            modcon.main()
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "DELETE FROM tbl_finishedproducts WHERE finprodID=" & Val(dgvProduct.Tag)
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Call loaddgv("SELECT * FROM vw_finishedproducts ORDER BY prodName", dgvProduct)
                Call cleaner()
            End If
        End If
    End Sub

   

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Try
            modcon.main()
            If MsgBox("Update this Record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand("UPDATE tbl_finishedproducts SET prodName=?,descrip=?,catID=?,unitID=?,price=?,qty=? WHERE finprodID ='" & Val(dgvProduct.Tag) & "' ", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtProdName.Text.Trim)
                    .AddWithValue("", txtdesc.Text.Trim)
                    .AddWithValue("", cmbCat.SelectedValue)
                    .AddWithValue("?", cmbUnit.SelectedValue)
                    .AddWithValue("", Format(txtPrice.Text, "###,##0.00"))
                    .AddWithValue("", txtQty.Text)
                    '.AddWithValue("", lblproductId.Text - 1)
                    '  con.Open()
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MessageBox.Show("Update record successfully")
                loaddgv("SELECT * FROM vw_finishedproducts ORDER BY finprodID DESC", dgvProduct)
                btnUpdate.Show()
                Call toggle(True)
                Me.btnUpdate.Hide()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            loaddgv("SELECT * FROM vw_finishedproducts WHERE prodName LIKE '%" & txtSearch.Text & "%'", dgvProduct)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class