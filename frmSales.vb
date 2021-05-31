Imports MySql.Data.MySqlClient
Public Class frmSales
    Private holdidremove As Long
    Private holdqty As Long
    Private holdFinProdId As Long
    Private Sub pnlSalesItems_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlSalesItems.Paint

    End Sub

    Private Sub btnSalesAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectEndProd.Show()
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'loaddgv("SELECT salesID,qty, endProduct,untPrice,totalPrice,vat,ID FROM tbl_temptransaction", dgvSalesList)
        dtpSales.Value = Now
        lblTotaHistory.Text = Val(lblTotal.Text)
        autoid()
        granTotal()
        'payment()
        dgvSalesList.RowsDefaultCellStyle.BackColor = Color.White
        dgvSalesList.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray
        '  dgvSalesList.ClearSelection()
        'loaddgv("SELECT qty, endProduct,untPrice,totalPrice,vat FROM tbl_temptransaction", dgvSalesList)

    End Sub
    Private Sub btnSalesSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesSave.Click
        If MsgBox("Add New Transaction?", vbQuestion + vbYesNo) = vbYes Then
          
            frmSelectEndProd.Show()
        End If
    End Sub

    Private Sub btnGetCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub autoid()

        Try
            modcon.main()
            Dim mysqlcom As New MySqlCommand("SELECT * FROM tbl_maintransaction ORDER BY itemID DESC", modcon.con)
            Dim rdr As MySqlDataReader = mysqlcom.ExecuteReader

            If (rdr.Read = True) Then

                lblSalesInvoice.Text = rdr(CInt(1)) + 1

            Else
                lblSalesInvoice.Text = 100
                mysqlcom.Dispose()
                rdr.Dispose()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
    Public Function countRows() As Boolean
        Try
            ' Dim dbCount1 As Integer
            modcon.main()
            Dim cmdr As New MySqlCommand("SELECT SUM(qty)  FROM tbl_temptransaction", modcon.con)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            If (rdr.Read = True) Then
                'rdr.Read()
                lblNoOfItems.Text = rdr(CInt(0))

            Else
                lblNoOfItems.Text = "0"
            End If

            ' Else
            '    lblNoOfItems.Text = "0"

            cmdr.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try

        Return True
    End Function
    Public Function getTotalVat() As Double
        Try
            modcon.main()
            Dim cmdr As New MySqlCommand("SELECT SUM(vat) as Tv FROM tbl_temptransaction", modcon.con)
            Dim rd As MySqlDataReader = cmdr.ExecuteReader

            If (rd.Read = True) Then
                txtVat.Text = rd.Item("Tv")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try

        Return True
    End Function
    Public Function granTotal() As Boolean

        Dim gtotal, total, vatTotal, holdTemp As Double
        total = Val(lbltotall.Text)
        vatTotal = Val(txtVat.Text)
        holdTemp = Val(lbltotall.Text)

        gtotal = total + vatTotal



        txtGtotal.Text = Format(gtotal, "#####0.00")
        Return True

    End Function
    Public Function payment() As Boolean
        Dim total, gtotal, change, stotal As Double

        total = Val(lblTotaHistory.Text)
        gtotal = Val(txtCash.Text)
        change = Val(txtchange.Text)

        stotal = gtotal - total

        txtchange.Text = Format(stotal, "###,##0.00")


        Return True
    End Function

    Private Sub txtGtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGtotal.TextChanged
        payment()

    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress

        ' If Asc(e.KeyChar) <> 15 AndAlso Asc(e.KeyChar) <> 9 And Not IsNumeric(e.KeyChar) Then
        'e.Handled = True

        '   End If
        Select Case e.KeyChar
            Case "0" To "9"
            Case Chr(9)
            Case "."
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        Dim total, change, input, st As Double

        change = Val(txtchange.Text)
        input = Val(txtCash.Text)
        st = Val(lblgtotal.Text)
        If txtCash.Text = "" Then
            txtchange.Text = "0.00"
        Else
            total = input - st

            txtchange.Text = Format(total, "###,##0.00")
            '  lblgrandtotal.Text = Format(total, "#######00.00")
        End If
    End Sub

    Private Sub txtchange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchange.TextChanged
        ' payment()

    End Sub

    Public Sub saveTrans()
        ' Dim newFrmSelectClient As New frmSelectClient
        Dim payment, totalPayment As Double

        payment = Val(txtCash.Text)
        totalPayment = Format(payment, "###,##0.00")

        If lblCustId.Text = "" Then
            MsgBox("Please Select the customer", vbInformation, "ERROR")
            dgvSalesList.ClearSelection()
            frmSelectClient.ShowDialog()
        ElseIf txtCash.Text = "" Then
            MsgBox("Please Enter Amount", vbInformation, "ERROR")
        ElseIf Val(txtCash.Text) < Val(lblgrandtotal.Text) Then
            MsgBox("Price must be exact amount to pay", vbCritical)
            txtCash.Text = ""
            txtCash.Focus()
        Else
            Try
                sqlQuery("INSERT INTO tbl_maintransaction(itemID,endProduct,description,category,unit,qty,untPrice,totalPrice,vat) SELECT itemID,endProduct,description,category,unit,qty,untPrice,totalPrice,vat FROM tbl_temptransaction WHERE itemID = " & Val(lblSalesInvoice.Text) & "")
                Dim cmdup As New MySqlCommand("UPDATE tbl_maintransaction SET NoOfItems=?,sDate=?, empID=?,clientID=?,total=?,totalVat=?,grandTotal=?,amountTendered=?,`change`=?,sTime=? WHERE itemID= " & Val(lblSalesInvoice.Text) & "", modcon.con)

                cmdup.Parameters.AddWithValue("", lblNoOfItems.Text.Trim)
                cmdup.Parameters.AddWithValue("", Format(dtpSales.Value, "yyyy-MM-dd"))
                cmdup.Parameters.AddWithValue("", Val(lblEmployeeID.Text))
                cmdup.Parameters.AddWithValue("", Val(lblCustId.Text))
                cmdup.Parameters.AddWithValue("", Trim(lblTotal.Text))
                cmdup.Parameters.AddWithValue("", Trim(txtVat.Text))
                cmdup.Parameters.AddWithValue("", Trim(txtGtotal.Text))
                cmdup.Parameters.AddWithValue("", Val(txtCash.Text))
                cmdup.Parameters.AddWithValue("", Trim(txtchange.Text))
                cmdup.Parameters.AddWithValue("", Now())
                cmdup.ExecuteNonQuery()
                cmdup.CommandTimeout = 0
                cmdup.Dispose()

                MsgBox("Transaction was made", vbInformation, "COMPLETE")
                sqlQuery("TRUNCATE tbl_temptransaction")
                loaddgv("SELECT qty, endProduct,untPrice,totalPrice,vat FROM tbl_temptransaction", dgvSalesList)
                cleaner()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message.ToString)
            End Try

        End If

    End Sub

    Private Sub btnSaveTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTransaction.Click
        If MsgBox("Save and close tally?", vbYesNo + MsgBoxStyle.Question) = vbYes Then

            
                Call saveTrans()

                Me.lblSalesInvoice.Text = ""
                autoid()
            End If

    End Sub
    Public Function AddId() As Boolean
        Dim holdid, total As Long
        'Create variable into integer values
        Dim intval1 As Integer

        'Parse our textboxes into integer values
        intval1 = Integer.Parse(lblSalesInvoice.Text)

        'set lebel to add numbers
        holdid = lblSalesInvoice.Text
        total = holdid + Val(lblSalesInvoice.Text)

        lblSalesInvoice.Text = holdid
        Return True
    End Function

    Private Sub cleaner()
        lblSalesInvoice.Refresh()
        lblNoOfItems.Text = ""
        lblCustId.Text = ""
        txtCustomerName.Text = ""
        txtVat.Text = "0.00"
        txtGtotal.Text = "0.00"
        txtCash.Text = "0.00"
        txtchange.Text = "0.00"
        lblTotal.Text = "0.00"
    End Sub

    Private Sub btnSalesClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesClose.Click

        If MsgBox("Are you sure you want to close sales? all transaction is cancel", vbQuestion + vbYesNo) = vbYes Then
            cleaner()
            Me.Close()
        End If
    End Sub
    Private Sub dgvSalesList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSalesList.CellClick
        holdidremove = dgvSalesList.CurrentRow.Cells(0).Value
        holdqty = dgvSalesList.CurrentRow.Cells(1).Value
        holdFinProdId = dgvSalesList.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btnSalesCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesCancel.Click

        If Val(dgvSalesList.Tag) < 0 Then
            MsgBox("Please you must select a record first", MsgBoxStyle.Critical)
        Else
            '  MessageBox.Show(varGetidRemove)
            Try
                modcon.main()
                If MessageBox.Show("Remove this currently item?", "PETROMINE SALES AND INVENTORY", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim sql As String = "DELETE FROM tbl_temptransaction WHERE salesID = " & holdidremove & ""
                    Dim cmd1 As New MySqlCommand(sql, modcon.con)
                    cmd1.ExecuteNonQuery()
                    cmd1.Dispose()

                    MessageBox.Show("DELETED")
                    sqlQuery("UPDATE tbl_finishedproducts SET qty = qty + " & holdqty & " WHERE finprodID = " & holdFinProdId & "")
                    'loaddgv("SELECT salesID,itemID,endProduct,description,category,unit,qty,untPrice,price,finprodID FROM tbl_temptransaction ORDER BY salesID DESC", dgvTemptransaction)
                    loaddgv("SELECT qty, endProduct,untPrice,totalPrice,vat FROM tbl_temptransaction", dgvSalesList)
                    dgvSalesList.Tag = " "

                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If




    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSelectClient.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmReqSuppliesReport.Show()
    End Sub
End Class
