Imports MySql.Data.MySqlClient
Public Class frmSelectEndProd
    Public num As Long
    Public prodname As String
    Public description As String
    Public category As String
    Public unit As String
    Public price As Double
    Public qty As Long
    Private idForUpdate As Long
    Private totalUpdate As Long
    Private Sub frmSelectEndProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modcon.main()
        ' Call loaddgv("SELECT prodName, descrip, catDesc, unitDesc, price, sum(qty) as qty FROM vw_finishedproducts GROUP BY prodName DESC", dgvSelectProd)
        loaddgv("SELECT * FROM vw_finishedproducts ORDER BY prodName DESC", dgvSelectProd)
        'dgvSelectProd.DefaultCellStyle.Format = "######00000.00"
        'warning()

    End Sub
    Private Function warning() As Boolean

        For i As Integer = 0 To dgvSelectProd.Rows.Count() - 1 Step +1
            Dim item As Integer


            item = dgvSelectProd.Rows(i).Cells(6).Value
            If item <= 1 Then
                dgvSelectProd.DefaultCellStyle.ForeColor = Color.Black
                dgvSelectProd.DefaultCellStyle.BackColor = Color.Red
                MessageBox.Show(i)
            ElseIf item >= 2 And item <= 51 Then

                dgvSelectProd.DefaultCellStyle.BackColor = Color.Yellow
            Else
                dgvSelectProd.DefaultCellStyle.BackColor = Color.White

            End If

        Next
        Return True
    End Function
    Private Sub fetchEndProd(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String = "SELECT * FROM vw_finishedproducts WHERE finprodID=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            id = table.Rows(0)(0)
            prodname = table.Rows(0)(1).ToString
            description = table.Rows(0)(2).ToString
            category = table.Rows(0)(3).ToString
            unit = table.Rows(0)(4)
            price = table.Rows(0)(5)
            qty = table.Rows(0)(6)

            adapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Function SelectProd() As Boolean

        If Len(dgvSelectProd.Tag) = 0 Then

        Else
            If MsgBox("Select this Current item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                frmTransactionAdd.txtqty.Focus()
                ' Dim idp As Long
            Else
                frmTransactionAdd.txtqty.Focus()
            End If
        End If

        Return True
    End Function
    Private Sub dgvSelectProd_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If Len(dgvSelectProd.Tag) >= 0 Then
            lblendProdID.Text = dgvSelectProd.CurrentRow.Cells(0).Value
            lblProductName.Text = dgvSelectProd.CurrentRow.Cells(1).Value
            lblDesc.Text = dgvSelectProd.CurrentRow.Cells(2).Value
            lblCategory.Text = dgvSelectProd.CurrentRow.Cells(3).Value
            lblUnit.Text = dgvSelectProd.CurrentRow.Cells(4).Value
            lblPrice.Text = dgvSelectProd.CurrentRow.Cells(5).Value
            lblfetchprice.Text = dgvSelectProd.CurrentRow.Cells(5).Value
            lblqtyfetch.Text = dgvSelectProd.CurrentRow.Cells(6).Value
            txtQty.Enabled = True
            txtQty.Focus()
        End If
        'FrmAddEnd 
        ' If Len(dgvSelectProd.Tag) >= 0 Then
        'Get the id
        ' dgvSelectProd.Tag = dgvSelectProd.Item(0, e.RowIndex).Value
        'salesId = dgvSelectProd.CurrentRow.Cells(0).Value
        'holdEndID = dgvSelectProd.CurrentRow.Cells(0).Value ' For Update Purposes
        'onhandsqtyforendprod = dgvSelectProd.CurrentRow.Cells(6).Value


        ' MessageBox.Show(onhandsqtyforendprod)
        'frmTransactionAdd.txtqty.Focus()
        ' End If

    End Sub


    Private Sub btnSelectItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' MessageBox.Show(vbNewLine num vbNewLine prodname vbNewLine description vbNewLine category vbNewLine unit)

    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call loaddgv("SELECT * FROM vw_finishedproducts WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%'", dgvSelectProd)
    End Sub
    Public Function sumTotal() As Boolean
        Dim total, price, supertotal, qtty As Double
        'Dim qty As Long

        Try
            price = Val(lblfetchprice.Text)
            qtty = Val(txtQty.Text)

            total = price * qtty

            frmSales.lblTotal.Text = Format(total, "###,####.00")

            supertotal = total + Val(frmSales.lblSalesTotal.Text)

            frmSales.lblTotal.Text = Format(supertotal, "###,###.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return True
    End Function

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click


        'GetGrandtotal()
        '    If Val(dgvSelectProd.Tag) <= 1 Then
        'MsgBox("Select Record!", vbCritical)
        If Len(txtQty.Text) = 0 Or Val(txtQty.Text) = 0 Or txtQty.Text = "" Then
            MsgBox("Quantity cannot be empty!", vbCritical)
            txtQty.Text = ""
            txtQty.Focus()

        ElseIf Val(CDbl(txtQty.Text)) > Val(CDbl(lblqtyfetch.Text)) Then
            MsgBox("Insufficient Stock!", vbCritical, "WARNING")
            txtQty.Text = ""
            txtQty.Focus()



        Else

            gettotal()
            vatFunc()
            frmSales.granTotal()

            'frmSales.auto()
            Try
                modcon.main()
                Dim cmd As New MySqlCommand("INSERT INTO tbl_temptransaction(itemID,endProduct, description,category,unit,qty,untPrice,totalPrice,vat,ID)VALUES(?,?,?,?,?,?,?,?,?,?)", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", Val(frmSales.lblSalesInvoice.Text))
                    .AddWithValue("", lblProductName.Text.Trim)
                    .AddWithValue("", lblDesc.Text.Trim)
                    .AddWithValue("", lblCategory.Text.Trim)
                    .AddWithValue("", lblUnit.Text.Trim)
                    .AddWithValue("", txtQty.Text)
                    .AddWithValue("", Val(lblPrice.Text.Trim))
                    .AddWithValue("", holdtotalqty)
                    .AddWithValue("", Holdvat)
                    .AddWithValue("", Val(lblendProdID.Text))
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Added Item.", vbInformation)




                'With frmTransactionAdd
                '.lblproductname.Text = dgvSelectProd.CurrentRow.Cells(1).Value
                '.lbldesc.Text = dgvSelectProd.CurrentRow.Cells(2).Value
                ' .lblcategory.Text = dgvSelectProd.CurrentRow.Cells(3).Value
                ' .lblunnit.Text = dgvSelectProd.CurrentRow.Cells(4).Value
                ' .txtunitprice.Text = dgvSelectProd.CurrentRow.Cells(5).Value


                ' .txtqty.Focus()
                ' End With

                totalUpdate = Val(lblqtyfetch.Text) - Val(txtQty.Text)
                idForUpdate = Val(lblendProdID.Text)
                frmSales.dgvSalesList.ClearSelection()
                sqlQuery("UPDATE tbl_finishedproducts SET qty = " & totalUpdate & " WHERE finprodID = " & idForUpdate & " ")
                loaddgv("SELECT qty,endProduct,untPrice, totalPrice, vat FROM tbl_temptransaction ORDER BY salesID DESC", frmSales.dgvSalesList)
                'After execution query this computation will exist
                '        frmSales.lblTotal.Text = Format("###,#00.00")

                getsum()
                sumQty()
                GetGrandtotal()
                ' frmSales.payment()
                frmSales.txtchange.Text = 0
                frmSales.txtCash.Text = ""
                frmSales.txtCash.Focus()
                ' granst = Val(frmSales.txtGtotal.Text)
                '  frmSales.lblgtotal.Text = Format(granst, "#######.00")
                cleaner()
                Me.Close()

                'frmSales.ShowDialog()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If

    End Sub
    Private Function gettotal() As Boolean
        Dim curQty, selectQty, formatQty As Double

        curQty = Val(lblfetchprice.Text)
        selectQty = Val(txtQty.Text)

        'holdtotalqty = curQty * selectQty
        formatQty = curQty * selectQty
        holdtotalqty = Format(formatQty, "###,##0.00")
        Return True
    End Function
    Private Function cleaner() As Boolean

        lblProductName.Text = ""
        lblDesc.Text = ""
        lblCategory.Text = ""
        lblUnit.Text = ""
        lblPrice.Text = ""
        txtQty.Text = ""


        Return True
    End Function
    Private Function getsum() As Boolean
        Dim grttotal As Double
        Try
            modcon.main()
            Dim mysqlcom As New MySqlCommand("SELECT SUM(totalPrice) as FetchTotal FROM tbl_temptransaction ORDER BY itemID DESC", modcon.con)
            Dim rdr As MySqlDataReader = mysqlcom.ExecuteReader

            If (rdr.Read = True) Then

                '    frmSales.lblTotal.Text = rdr.Item("FetchTotal")
                grttotal = rdr.Item("FetchTotal")
                frmSales.lbltotall.Text = rdr.Item("FetchTotal")
                frmSales.lblTotal.Text = Format(grttotal, "###,##0.00")

            End If
            mysqlcom.Dispose()
            rdr.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return True
    End Function
    Function sumQty() As Boolean
        Try
            modcon.main()
            Dim mysqlcom As New MySqlCommand("SELECT SUM(qty) as items FROM tbl_temptransaction ORDER BY itemID DESC", modcon.con)
            Dim rdr As MySqlDataReader = mysqlcom.ExecuteReader

            If (rdr.Read = True) Then

                frmSales.lblNoOfItems.Text = rdr.Item("items")

            End If
            mysqlcom.Dispose()
            rdr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return True
    End Function
    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If Asc(e.KeyChar) <> 14 AndAlso Asc(e.KeyChar) <> 9 And Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Function GetGrandtotal() As Boolean

        Dim Stotal, Svat As Double

        Stotal = Val(frmSales.lbltotall.Text)
        Svat = Val(frmSales.txtVat.Text)

        holdGrandtotal = Stotal + Svat

        'holdGrandtotal = frmSales.lblTotaHistory.Text
        frmSales.txtGtotal.Text = Format(holdGrandtotal, "###,##0.00")
        frmSales.lblgrandtotal.Text = Format(holdGrandtotal, "########00.00")
        frmSales.lblgtotal.Text = Format(holdGrandtotal, "######0.00")
        frmSales.lblTotaHistory.Text = Format(holdGrandtotal, "######.00")
        Return True
    End Function

    Public Function vatFunc() As Boolean

        Dim vatTot, vatVal, supervat, vatholder As Double

        vatVal = Val(lblfetchprice.Text)

        vatTot = (15 / 100) * vatVal * Val(txtQty.Text)
        Holdvat = vatTot


        supervat = Holdvat + supervat

        vatholder = Val(frmSales.txtVat.Text) + supervat
        frmSales.txtVat.Text = Format(vatholder, "###,##0.00")

        Return True
    End Function

    Private Sub dgvSelectProd_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSelectProd.CellClick
        If Len(dgvSelectProd.Tag) >= 0 Then
            lblendProdID.Text = dgvSelectProd.CurrentRow.Cells(0).Value
            lblProductName.Text = dgvSelectProd.CurrentRow.Cells(1).Value
            lblDesc.Text = dgvSelectProd.CurrentRow.Cells(2).Value
            lblCategory.Text = dgvSelectProd.CurrentRow.Cells(3).Value
            lblUnit.Text = dgvSelectProd.CurrentRow.Cells(4).Value
            lblPrice.Text = dgvSelectProd.CurrentRow.Cells(5).Value
            lblfetchprice.Text = dgvSelectProd.CurrentRow.Cells(5).Value
            lblqtyfetch.Text = dgvSelectProd.CurrentRow.Cells(6).Value
            txtQty.Enabled = True
            txtQty.Focus()
        End If

    End Sub

    Private Sub lblProductName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProductName.Click

    End Sub
End Class