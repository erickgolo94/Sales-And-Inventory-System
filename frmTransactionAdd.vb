Imports MySql.Data.MySqlClient
Public Class frmTransactionAdd
    Public getsum As Long
    Public holdTransaction As Long
    Dim holtotal As Double

    Private Sub btnSelectEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectEndProd.ShowDialog()
    End Sub

    Private Sub btnSelectEmployee_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectEmployee.Click
        frmSelectEndProd.ShowDialog()
    End Sub

    Private Sub frmTransactionAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sumofqty()
        '  autoitemid()
        'txtqty.Focus()
    End Sub
    Private Sub sumofqty()

        Dim qty, unitprice, price, gtotal As Double

        qty = Val(Me.txtqty.Text)
        unitprice = Val(Me.txtunitprice.Text)
        price = Val(Me.txtprice.Text)

        gtotal = (qty * unitprice)
        'gtotal = holtotal

        txtprice.Text = Format(gtotal, "###,##0.00")


    End Sub
    Private Function autoitemid() As Boolean

        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Try
            modcon.main()
            cmd = New MySqlCommand("SELECT * FROM tbl_maintransaction ORDER BY salesID DESC", modcon.con)
            rd = cmd.ExecuteReader
            If (rd.Read = True) Then
                Me.lblItemd.Text = rd(CInt(1)) + 1
                'Me.lblupdate.Text = rd(CInt(0))
                updateid = Val(lblItemd.Text)
            Else
                Me.lblItemd.Text = 100

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

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        sumofqty()
    End Sub

    Private Sub txtunitprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunitprice.TextChanged
        sumofqty()
    End Sub
    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        sumofqty()
    End Sub

    Private Sub btnAddtolist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEndProduct.Click
        Dim cmd1 As New MySqlCommand
        ' MessageBox.Show(salesId)
        Try
            If checker() = True Then

                If Val(txtqty.Text) >= onhandsqtyforendprod Then
                    MsgBox("Insuffiecient stock!", MsgBoxStyle.Critical + MsgBoxStyle.Information)
                    txtqty.Clear()
                    txtqty.Focus()
                Else
                    modcon.main()
                    Dim cmd As New MySqlCommand("INSERT INTO tbl_temptransaction(itemID,endProduct, description,category,unit,qty,untPrice,price,finprodID)VALUES(?,?,?,?,?,?,?,?,?)", modcon.con)

                    'cmd = New MySqlCommand("INSERT INTO tbl_maintransaction(itemID,endProduct, description,category,unit,qty,untPrice,price,dateIn,clientID)VALUES(?,?,?,?,?,?,?,?,?)")
                    cmd.Parameters.AddWithValue("", Val(lblItemd.Text))
                    cmd.Parameters.AddWithValue("", lblproductname.Text.Trim)
                    cmd.Parameters.AddWithValue("", lbldesc.Text.Trim)

                    cmd.Parameters.AddWithValue("", lblcategory.Text.Trim)

                    cmd.Parameters.AddWithValue("", lblunnit.Text.Trim)

                    cmd.Parameters.AddWithValue("", txtqty.Text)

                    cmd.Parameters.AddWithValue("", txtunitprice.Text.Trim)

                    cmd.Parameters.AddWithValue("", txtprice.Text.Trim)

                    cmd.Parameters.AddWithValue("", holdEndID)


                    ' cmd.Parameters.AddWithValue("", Now())

                    'cmd.Parameters.AddWithValue("", "NULL")

                    'Dim cmd1 As New MySqlCommand("INSERT INTO tbl_maintransaction(itemID,endProduct, description,category,unit,qty,untPrice,price,dateIn,clientID)VALUES(?,?,?,?,?,?,?,?,?)", modcon.con)
                    'cmd.Parameters.AddWithValue("", "NULL")
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    UpadateQty()
                    sqlQuery("INSERT INTO tbl_maintransaction(itemID,endProduct, description,category,unit,qty,untPrice,price)SELECT itemID,endProduct, description,category,unit,qty,untPrice,price FROM tbl_temptransaction WHERE itemID = " & Val(lblItemd.Text) & "")
                    loaddgv("SELECT itemID,endProduct,description,category,unit,qty,untPrice, price FROM tbl_temptransaction ORDER BY salesID DESC", frmTransaction.dgvTemptransaction)
                    'MessageBox.Show("Item Added", "PETROMINE SALES AND INVENTORY")
                    'MessageBox.Show(holtotal)
                    If MsgBox("Add another item from finished product?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        holdsIdForRelease = Val(lblItemd.Text)
                        ' lblItemd.Text = holdsIdForRelease

                        frmSelectEndProd.Show()
                    Else
                        cleaner()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub UpadateQty()
      
        Dim rdr As MySqlDataReader
        ' Dim ggtotal As Long
        Dim holdqty As Long

        Try
            'Dim sql As String = "SELECT qty FROM tbl_finishedproducts WHERE finprodID = " & salesId & ""
            cmd = New MySqlCommand("SELECT qty FROM tbl_finishedproducts WHERE finprodID = " & salesId & "", modcon.con)
           
            rdr = cmd.ExecuteReader

            If rdr.HasRows Then
                rdr.Read()
                getsum = rdr.Item("qty")
            End If
            'Me.txtqty.Text = holdqty
            holdqty = CStr(Me.txtqty.Text)

            'ggtotal = getsum - holdqty
            sqlQuery("UPDATE tbl_finishedproducts SET qty = qty - " & holdqty & " WHERE finprodID = " & salesId & "")
           
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub
    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
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
    Private Sub cleaner()
        txtqty.Text = ""
        lblproductname.Text = ""
        lblcategory.Text = ""
        lbldesc.Text = ""
        lblunnit.Text = ""
        txtunitprice.Text = ""
        txtprice.Text = ""
        txtqty.Focus()
    End Sub
    Private Function checker() As Boolean
        For Each obj As Object In pnldeEnd.Controls
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

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Close tab?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cleaner()
            Me.Close()
        End If
    End Sub
End Class