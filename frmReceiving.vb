Imports MySql.Data.MySqlClient
Public Class frmReceiving
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public totalp As Double
    Private Sub frmReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call autoID()
        dtpDateReceived.Value = Now.ToString("yyyy-MM-dd")
        dtpDateRequest.Value = Now.ToString("yyyy-MM-dd")
        dtpDeliveryReportDate.Value = Now.ToString("yyyy-MM-dd")
        txtTime.Text = TimeOfDay
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String = "SELECT * FROM vw_temprawmaterialonhand WHERE rawmaterialOnHandID=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            lblTransNo.Text = table.Rows(0)(1).ToString
            removeUpdate = table.Rows(0)(1).ToString
            dtpDateRequest.Value = table.Rows(0)(2).ToString
            lblsupplierCom.Text = table.Rows(0)(3).ToString
            lblsupplierName.Text = table.Rows(0)(4).ToString
            txtDeliveryReportNo.Text = table.Rows(0)(5).ToString
            dtpDeliveryReportDate.Value = table.Rows(0)(6).ToString
            ' dtpDateReceive.Value = table.Rows(0)(7).ToString
            lblrawmaterialID.Text = table.Rows(0)(8).ToString
            lblName.Text = table.Rows(0)(9).ToString
            lbldesc.Text = table.Rows(0)(10).ToString
            lblCat.Text = table.Rows(0)(11).ToString
            lblUnit.Text = table.Rows(0)(12).ToString
            txtqty.Text = table.Rows(0)(13).ToString
            adapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
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

    Private Sub btnSelectEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectEmployee.Click
        frmSelectSupplier.ShowDialog()
    End Sub
    Private Sub btnSearchRawMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRawMaterial.Click
        '  frmselectRawmaterial.ShowDialog()
        frmSelectRawmaterialReceiving.ShowDialog()
    End Sub

    Private Sub dgvRawMaterialOnhand_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRawMaterialOnhand.CellClick
        If e.RowIndex >= 0 Then
            dgvRawMaterialOnhand.Tag = dgvRawMaterialOnhand.Item(0, e.RowIndex).Value
            frmModifyQuantityReceving.lblId.Text = dgvRawMaterialOnhand.Item(1, e.RowIndex).Value
            ' frmModifyQuantityReceving.txtChangeQuantity.Text = dgvRawMaterialOnhand.CurrentRow.Cells(10).Value
            frmModifyQuantityReceving.txtChangeQuantity.Text = dgvRawMaterialOnhand.Item(10, e.RowIndex).Value
            'frmModifyQuantityReceving.lblTempID.Text = dgvRawMaterialOnhand.CurrentRow.Cells(1).Value

        End If

    End Sub
    Private Sub fetchgetid(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM temprawmaterialonhan WHERE rawmaterialOnHandID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmModifyQuantityReceving
            '.Text = table.Rows(0)(0)
            .lblId.Text = table.Rows(0)(0)
            ' .lblName.Text = table.Rows(0)(1).ToString
            ' .lbldesc.Text = table.Rows(0)(2).ToString
            ' .lblCat.Text = table.Rows(0)(3).ToString
            '.lblUnit.Text = table.Rows(0)(4).ToString
            ' 'lblgetqty.Text = table.Rows(0)(5).ToString
        End With
        adapt.Dispose()
    End Sub

    Function autoID() As Boolean
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Try
            cmd = New MySqlCommand("SELECT transactionNo FROM tbl_rawmaterialmonitoring ORDER BY transactionNo DESC", modcon.con)
            rd = cmd.ExecuteReader

            If (rd.Read = True) Then
                lblTransNo.Text = rd(CInt(0)) + 1

            Else
                Me.lblTransNo.Text = 100
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

    Private Function totalAndUpdate() As Boolean
        Try
            Dim total, qty As Double

            'id = Val(frmSelectRawmaterialReceiving.lblID.Text)
            total = Val(frmSelectRawmaterialReceiving.lblgetqty.Text)
            qty = Val(Me.txtqty.Text)
            totalp = total + qty
            totalRemove = totalp
            '  MessageBox.Show(totalp)
            ' MessageBox.Show(frmSelectRawmaterialReceiving.lblID.Text)
            'MessageBox.Show(idUpdateForreceiving)
            idUpdateForreceiving = frmSelectRawmaterialReceiving.lblID.Text

            '  sqlQuery("UPDATE `tbl_rawmaterialonhand` SET qty =" & totalp & "  WHERE `rawmaterialOnHandID` = " & idUpdateForreceiving & "")
            sqlQuery("UPDATE `tbl_rawmaterialonhand` SET qty =" & totalp & "  WHERE `rawmaterialOnHandID` = " & idUpdateForreceiving & "")
            ' MessageBox.Show("Success!")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try

        Return True
    End Function
    Private Sub btnAddtolist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddtolist.Click





        If Val(txtqty.Text) = 0 Or 0.0 Then
            MsgBox("Invalid Input Quantity", vbCritical)
            '  ElseIf Len(txtqty.Text) = 0 Then
            ' MessageBox.Show("Invalid quantiry")
            Me.txtqty.Text = ""
            Me.txtqty.Focus()


        Else
            If checker() = True Then
                totalAndUpdate()
                Try
                    cmd = New MySqlCommand("SELECT * FROM tbl_temprawmaterialonhand WHERE transactionNo=? and requestDate=? and comSupplier=? and supplierName=? and deliveryRepNo=? and deliveryRepDate=? and receiveBy=? and dateReceive=? and rawmaterialID=?", modcon.con)
                    With cmd.Parameters
                        .AddWithValue("", lblTransNo.Text.Trim)
                        .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-yy"))
                        .AddWithValue("", lblsupplierCom.Text.Trim)
                        .AddWithValue("", lblsupplierName.Text.Trim)
                        .AddWithValue("", txtDeliveryReportNo.Text.Trim)
                        .AddWithValue("", Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd"))
                        .AddWithValue("", lblReceivedBy.Text.Trim)
                        .AddWithValue("", Format(dtpDateReceived.Value, "yyyy-MM-dd"))
                        .AddWithValue("", lblrawmaterialID.Text.Trim)
                        '.AddWithValue("", lblqty.Text.Trim)
                    End With
                    reader = cmd.ExecuteReader
                    If reader.HasRows Then
                        reader.Close()
                        cmd = New MySqlCommand("UPDATE tbl_temprawmaterialonhand SET qty=" & Val(txtqty.Text) & " + " & Val(txtqty.Text) & " WHERE transactionNo=? and requestDate=? and comSupplier=? and supplierName=? and deliveryRepNo=? and deliveryRepDate=? and receiveBy=? and dateReceive=? and rawmaterialID=?", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", lblTransNo.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                            .AddWithValue("", lblsupplierCom.Text.Trim)
                            .AddWithValue("", lblsupplierName.Text.Trim)
                            .AddWithValue("", txtDeliveryReportNo.Text.Trim)
                            .AddWithValue("", Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd"))
                            .AddWithValue("", lblReceivedBy.Text.Trim)
                            .AddWithValue("", Format(dtpDateReceived.Value, "yyyy-MM-dd"))
                            .AddWithValue("", lblrawmaterialID.Text.Trim)
                        End With
                        cmd.ExecuteNonQuery()
                        'loaddgv("SELECT * FROM vw_temprawmaterialonhand WHERE transactionNo  LIKE '%" & Trim(lblTransNo.Text) & "%' ORDER BY transactionNo DESC", dgvRawMaterialOnhand)
                        loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvRawMaterialOnhand)

                        txtqty.Clear()
                    Else
                        reader.Close()

                        cmd = New MySqlCommand("INSERT INTO tbl_temprawmaterialonhand(transactionNo,requestDate,comSupplier,supplierName,deliveryRepNo,deliveryRepDate,receiveBy,dateReceive,rawmaterialID,qty,temptotal) VALUES (?,?,?,?,?,?,?,?,?,?,?)", modcon.con)
                        'loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvRawMaterialOnhand)
                        With cmd.Parameters
                            '.AddWithValue("", lblRawMaterialOnHandID.Text)
                            .AddWithValue("", lblTransNo.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-yy"))
                            .AddWithValue("", lblsupplierCom.Text.Trim)
                            .AddWithValue("", lblsupplierName.Text.Trim)
                            .AddWithValue("", txtDeliveryReportNo.Text.Trim)
                            .AddWithValue("", Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd"))
                            .AddWithValue("", lblReceivedBy.Text.Trim)
                            .AddWithValue("", Format(dtpDateReceived.Value, "yyyy-MM-dd"))
                            .AddWithValue("", lblrawmaterialID.Text.Trim)
                            .AddWithValue("", txtqty.Text.Trim)
                            .AddWithValue("", totalp)
                        End With
                        dgvRawMaterialOnhand.ClearSelection()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        cleanerRawMaterial()
                        ' totalAndUpdate()
                        'loaddgv("SELECT * FROM vw_temprawmaterialonhand WHERE transactionNo  LIKE '%" & Trim(lblTransNo.Text) & "%' ORDER BY transactionNo DESC", dgvRawMaterialOnhand)
                        loaddgv("SELECT  rawmaterialonhandID,qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvRawMaterialOnhand)
                        txtqty.Clear()
                    End If


                Catch ex As MySqlException
                    MsgBox(ex.Message.ToString)
                Finally
                    GC.Collect()

                End Try
            End If
        End If
    End Sub
    Private Sub cleanerRawMaterial()

        lblName.Text = ""
        lbldesc.Text = ""
        lblCat.Text = ""
        lblUnit.Text = ""
        txtqty.Text = ""
        btnSearchRawMaterial.Focus()


    End Sub
    Public Sub getFetch(ByVal id As Long)

        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String = "SELECT * FROM tbl_temprawmaterialonhand WHERE rawmaterialOnHandID=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            '  lblTransNo.Text = table.Rows(0)(1).ToString
            '  removeUpdate = table.Rows(0)(1).ToString
            '  dtpDateRequest.Value = table.Rows(0)(2).ToString
            '  lblcompany.Text = table.Rows(0)(3).ToString
            ' lblSupplierName.Text = table.Rows(0)(4).ToString
            ' txtDeliveryReportNo.Text = table.Rows(0)(5).ToString
            ' dtpDeliveryReportDate.Value = table.Rows(0)(6).ToString
            ' dtpDateReceive.Value = table.Rows(0)(7).ToString
            'lblrawmaterialID.Text = table.Rows(0)(8).ToString
            frmModifyQuantityReceving.lblId.Text = table.Rows(0)(9).ToString

            adapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Val(dgvRawMaterialOnhand.Tag) = 0 Then

            frmModifyQuantityReceving.ShowDialog()
            'frmModifyQuantityReceving.lbltotalqty.Text = dgvRawMaterialOnhand.CurrentRow.Cells(1).Value
        Else
            MessageBox.Show("Please select quantity you want to change")

        End If


        '   If MsgBox("Are you want to change quantity?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

        'End If

        'frmModifyQuantityReceving.ShowDialog()

        '  Try
        'If MsgBox("Update this Record?", vbYesNo + vbQuestion) = vbYes Then
        'Dim cmd As MySqlCommand
        ' cmd = New MySqlCommand("UPDATE tbl_temprawmaterialonhand SET transactionNo=?,requestData=?,comsupplier=?,supplierName=?,deliveryRepNo=?,deliveryRepDate=?,receiveBy=?,dateReceive=?,rawmaterialID=?,qty=? WHERE rawmaterialOnHand='" & Val(dgvRawMaterialOnhand.Tag) & "' ", modcon.con)
        '' With cmd.Parameters
        '.AddWithValue("", lblTransNo.Text.Trim)
        ' .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-yy"))
        ' .AddWithValue("", lblcompany.Text.Trim)
        '  .AddWithValue("", lblSupplierName.Text.Trim)
        '  .AddWithValue("", txtDeliveryReportNo.Text.Trim)
        ' .AddWithValue("", Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd"))
        ' .AddWithValue("", txtReceivedBy.Text.Trim)
        ' .AddWithValue("", Format(dtpDateReceive.Value, "yyyy-MM-dd"))
        ' .AddWithValue("", lblrawmaterialID.Text.Trim)
        ' .AddWithValue("", txtqty.Text.Trim)
        ' .AddWithValue("", lblRawMaterialOnHandID.Text)
        '  End With
        '  cmd.ExecuteNonQuery()
        '  loaddgv("SELECT transactionNo,rawmaterialName,catDesc,UnitDesc,qty FROM vw_temprawmaterialonhand WHERE transactionNo  LIKE '%" & Trim(lblTransNo.Text) & "%' ORDER BY transactionNo DESC", dgvRawMaterialOnhand)
        '  End If

        '  Catch ex As Exception
        'MsgBox(ex.ToString)
        '  Finally
        'GC.Collect()
        '  End Try
    End Sub
    Private Sub SaveTransaction()
        'Dim getTransId As Long = Val(lblTransNo.Text)
        Try

            'cmd = New MySqlCommand("INSERT INTO tbl_rawmaterialonhand SELECT (rawmaterialOnHandID,transactionNo,comSupplier,supplierName,DeliveryRepNo,deliveryRepDate,receiveBy,dateReceive,rawmaterialID,qty)VALUES("NULL,?,?,?,?,?,?,?,?,?") FROM tbl_temprawmaterialonhand WHERE transactionNo=" & Val(lblTransNo.Text) & "", modcon.con)
            cmd = New MySqlCommand("INSERT INTO tbl_rawmaterialonhand SELECT (?,?,?,?,?,?,?,?,?) FROM tbl_temprawmaterialonhand WHERE transactionNo=" & Val(lblTransNo.Text) & "", modcon.con)

            'cmd = New MySqlCommand("INSERT INTO tbl_rawmaterialonhand(transactionNo,requestDate,comSupplier,supplierName,deliveryRepNo,deliveryRepDate,receiveBy,dateReceive,rawmaterialID,qty) VALUES (?,?,?,?,?,?,?,?,?,?) ", modcon.con)
            'SELECT ('" & Val(lblTransNo.Text) & "','" & Format(dtpDateRequest.Value, "yyyy-MM-dd") & "','" & (lblcompany.Text) & "','" & (lblSupplierName.Text) & "','" & Trim(txtDeliveryReportNo.Text) & "','" & Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd") & "','" & Trim(txtReceivedBy.Text) & "','" & Format(dtpDateReceive.Value, "yyyy-MM-dd") & "','" & (lblrawmaterialID.Text) & "','" & Val(txtqty.Text) & "')  FROM tbl_rawmaterialonhand WHERE transactionNo='" & Val(dgvRawMaterialOnhand.Tag) & "'", Modcon.con)
            With cmd.Parameters
                '  .Add("NULL")

                .AddWithValue("", lblTransNo.Text.Trim)
                .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-yy"))
                .AddWithValue("", lblsupplierCom.Text.Trim)
                .AddWithValue("", lblsupplierName.Text.Trim)
                .AddWithValue("", txtDeliveryReportNo.Text.Trim)
                .AddWithValue("", Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd"))
                .AddWithValue("", lblReceivedBy.Text.Trim)
                .AddWithValue("", lblReceivedBy.Text)
                .AddWithValue("", lblrawmaterialID.Text.Trim)
                .AddWithValue("", txtqty.Text.Trim)
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            '  loaddgv("SELECT * FROM vw_rawmaterialonhand WHERE transactionNo  LIKE '%" & Trim(lblTransNo.Text) & "%' ORDER BY transactionNo DESC", dgvRawMaterialOnhand)
            loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvRawMaterialOnhand)

            MsgBox("Successfully Saved!", vbInformation)
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Save Transaction?", vbYesNo + vbQuestion) = vbYes Then
                Call save()
                cleaner()
                sqlQuery("TRUNCATE tbl_temprawmaterialonhand")
                loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvRawMaterialOnhand)
                'cmd = New MySqlCommand("DELETE FROM tbl_temprawmaterialonhand WHERE transactionNo=" & Val(lblTransNo.Text) & "", modcon.con)
                'cmd.ExecuteNonQuery()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
            cmd.Dispose()
        End Try
        '  loaddgv("SELECT * FROM tbl_temprawmaterialonhand WHERE rawmaterialOnHandID ORDER BY transactionno DESC", dgvRawMaterialOnhand)
    End Sub
    Private Sub save()
        'Dim cmd As New MySqlCommand("INSERT INTO tbl_temprawmaterialonhand(transactionNo,requestDate,supplierName,deliveryRepNo,deliveryRepDate,receiveBy,dateReceive,rawmaterialqtyID,qty) values (?,?,?,?,?,?,?,?,?) ON DUPLICATE KEY UPDATE qty = '" & Trim(txtqty.Text).ToString & "' ")
        Try
            cmd = New MySqlCommand("INSERT INTO tbl_rawmaterialmonitoring(transactionNo,requestDate,comSupplier,supplierName,deliveryRepNo,deliveryRepDate,receiveBy,dateReceive,rawmaterialID,qty) SELECT transactionNo, requestDate, comSupplier, supplierName, deliveryRepNo, deliveryRepDate, receiveBy, dateReceive, rawmaterialID, qty  FROM tbl_temprawmaterialonhand WHERE transactionNo=" & Val(lblTransNo.Text) & "", modcon.con)
            'sqlQuery("INSERT INTO tbl_rawmaterialonhand(transactionNo,requestDatem,comSupplier,supplierName,deliveryRepNo,deliveryRepDate,rawmaterialID,qty)VALUES(?a,?b,?c,?d,?e,?f,?g,?h,?i,?j)")
            With cmd.Parameters
                .AddWithValue("", lblTransNo.Text.Trim)
                .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-yy"))
                .AddWithValue("", lblsupplierCom.Text.Trim)
                .AddWithValue("", lblsupplierName.Text.Trim)
                .AddWithValue("", txtDeliveryReportNo.Text.Trim)
                .AddWithValue("", Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd"))
                .AddWithValue("", lblReceivedBy.Text.Trim)
                .AddWithValue("", Format(dtpDateReceived.Value, "yyyy-MM-dd"))
                .AddWithValue("", lblrawmaterialID.Text.Trim)
                .AddWithValue("", txtqty.Text.Trim)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Saved", "RECEIVING SECTION")
            End With

        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            cmd.Dispose()
        End Try
    End Sub





    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress

        Select Case e.KeyChar
            Case "0" To "9"
            Case Chr(9)
            Case "."
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Close receiving? Y/N", vbQuestion + vbYesNo) = Windows.Forms.DialogResult.Yes Then
            sqlQuery("TRUNCATE tbl_temprawmaterialonhand")
            Me.Close()

        End If
    End Sub
    Private Sub cleaner()

        lblsupplierCom.Text = ""
        lblsupplierName.Text = ""
        txtDeliveryReportNo.Text = ""
        'lblReceivedBy.Text = ""
        lblName.Text = ""
        lbldesc.Text = ""
        lblCat.Text = ""
        lblUnit.Text = ""
        txtqty.Text = ""
        btnSelectEmployee.Focus()


    End Sub

    Private Sub txtTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTime.Click
    End Sub

    Private Sub txtDateReceived_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtReceivedBy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub


End Class