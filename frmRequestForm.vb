Imports MySql.Data.MySqlClient
Public Class frmRequestForm
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim idInsertDuplicate As Long


    Private Sub frmRequestFormNEWNEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        '  loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess WHERE reqSupNo  ORDER BY reqSupNo DESC", dgvReqSupp)
        autoID()
        dtpDateRequest.Value = Now
        txtTime.Text = TimeOfDay
        txtDate.Text = DateString
        tsUSER.Text = labelUser

    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String = "SELECT * FROM vw_reqsuppliess WHERE reqSupID=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            lblReqNo.Text = table.Rows(0)(1)
            lblReqName.Text = table.Rows(0)(2)
            lblDept.Text = table.Rows(0)(3)
            txtRemarks.Text = table.Rows(0)(4)
            dtpDateRequest.Value = table.Rows(0)(5)
            lblrawmaterialID.Text = table.Rows(0)(6)
            lblRawmaterialName.Text = table.Rows(0)(7)
            lblDesc.Text = table.Rows(0)(8)
            lblCat.Text = table.Rows(0)(9)
            lblUnit.Text = table.Rows(0)(10)
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
        frmSelectEmployee.Show()
    End Sub

    Private Sub btnSearchRawMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRawMaterial.Click
        frmselectRawmaterial.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim cmd As MySqlCommand
            If MsgBox("Update Record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand("UPDATE tbl_reqsupplies SET reqSupNo=?,reqBy=?,dept=?,remarks=?,dateRequest=?,rawmaterialID=?,qty=?,is_active=? WHERE reqSupID='" & (dgvReqSupp.Tag) & "'", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", lblReqNo.Text.Trim)
                    .AddWithValue("", lblReqName.Text.Trim)
                    .AddWithValue("", lblDept.Text.Trim)
                    .AddWithValue("", txtRemarks.Text.Trim)
                    .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                    .AddWithValue("", Val(lblRawMaterialID.Text))
                    .AddWithValue("", txtQty.Text.Trim)
                    .AddWithValue("", chk_active.CheckState)
                End With
                cmd.ExecuteNonQuery()
                loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess WHERE reqSupNo  LIKE '%" & Val(lblReqNo.Text) & "%' ", dgvReqSupp)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case Chr(9)
            Case "."
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            Dim str As String = "DELETE FROM tbl_reqsuppliess WHERE reqSupID=" & Val(dgvReqSupp.Tag)
            cmd = New MySqlCommand(str, con)
            cmd.ExecuteNonQuery()
            loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSupp)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub
    Private Function sendRequest() As Boolean
        '  Dim cmd1 As New MySqlCommand
        Dim getRequestNo As Long
        getRequestNo = CLng(Val(lblReqNo.Text))
        Try

            'cmd = New MySqlCommand("INSERT INTO tbl_rawmaterialonhand(transactionNo,requestDate,comSupplier,supplierName,deliveryRepNo,deliveryRepDate,receiveBy,dateReceive,rawmaterialID,qty) SELECT transactionNo, requestDate, comSupplier, supplierName, deliveryRepNo, deliveryRepDate, receiveBy, dateReceive, rawmaterialID, qty  FROM tbl_temprawmaterialonhand WHERE transactionNo=" & Val(lblTransNo.Text) & "", modcon.con)
            'sqlQuery("INSERT INTO tbl_Mainreqsupplies (reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active)VALUES(?,?,?,?,?,?,?,?)")
            Dim cmd As New MySqlCommand("INSERT INTO tbl_mainreqsupplies(reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active) SELECT reqSupNo, reqBy, dept, remarks, dateRequest, rawmaterialId, qty, is_active FROM tbl_reqsupplies WHERE reqSupNo = " & getRequestNo & "", modcon.con)

            With cmd.Parameters
                .AddWithValue("@purchaseNo", lblReqNo.Text.Trim)
                .AddWithValue("@reqBy", lblReqName.Text.Trim)
                .AddWithValue("@dept", lblDept.Text.Trim)
                .AddWithValue("@remarks", txtRemarks.Text.Trim)
                .AddWithValue("@dateRequest", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                .AddWithValue("@rawmaterialID", Val(lblRawMaterialID.Text))
                .AddWithValue("@qty", txtQty.Text.Trim)
                ' .AddWithValue("@unitID", defaultIdForRaw)
                .AddWithValue("@is_active", chk_active.CheckState)
            End With
            cmd.ExecuteNonQuery()
            MessageBox.Show("Send Request Successfully", "PETROMINE SALES AND INVNTORY")
            cmd.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        Finally
            GC.Collect()
        End Try
        Return False
    End Function
    Public Function releaseRaw() As Boolean


        Return False
    End Function
    Private Sub cleaner1()
        lblReqName.Text = ""
        lblDept.Text = ""
        txtRemarks.Text = ""
        lblRawmaterialName.Text = ""
        lblDept.Text = ""
        lblDesc.Text = ""
        lblUnit.Text = ""
        txtqty.Text = ""

    End Sub

    Private Sub btnAddList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddList.Click
        ' insertID()
        '  MessageBox.Show(idInsertDuplicate)
        Try

            If checker() = True Then

                If Val(txtQty.Text) > Val(CDbl(OnhandsQty)) Then
                    MsgBox("Insufficient Stock!", MsgBoxStyle.Critical, "PETROMINE SALES AND INVENTORY")
                    'MessageBox.Show("The current item is :", OnhandsQty)
                    txtQty.Clear()
                    txtQty.Focus()

                    '     ElseIf Val(txtQty.Text) And Val(CDbl(OnhandsQty)) Then
                    '     MsgBox("Insufficientt Stock!", MsgBoxStyle.Critical, "PETROMINE SALES AND INVENTORY")
                    'MessageBox.Show("The current item is :", OnhandsQty)
                    '   txtQty.Clear()
                    '   txtQty.Focus()

                ElseIf txtQty.Text = 0 Or 0.0 Then
                    MsgBox("Invalid Quantity", MsgBoxStyle.Exclamation)
                    txtQty.Clear()
                    txtQty.Focus()
                Else
                    modcon.main()
                    cmd = New MySqlCommand("SELECT * FROM tbl_reqsupplies WHERE reqSupNo=? and reqBy=? and dept=? and remarks=? and dateRequest=? and rawmaterialID=?", modcon.con)
                    With cmd.Parameters
                        .AddWithValue("", lblReqNo.Text.Trim)
                        .AddWithValue("", lblReqName.Text.Trim)
                        .AddWithValue("", lblDept.Text.Trim)
                        .AddWithValue("", txtRemarks.Text.Trim)
                        .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                        .AddWithValue("", Val(lblRawMaterialID.Text))


                    End With
                    reader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Close()

                        'cmd = New MySqlCommand("INSERT INTO tbl_reqsupplies(reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty)VALUES(?,?,?,?,?,?,?) ON DUPLICATE KEY UPDATE SET qty = qty -- =" & Val(txtqty.Text) & "", modcon.con)
                        cmd = New MySqlCommand("UPDATE tbl_reqsupplies SET qty = qty + " & Val(txtQty.Text) & " WHERE reqSupNo=? AND reqBy=? AND dept=? AND remarks=? AND dateRequest=? AND rawmaterialID=?", modcon.con)

                        With cmd.Parameters
                            '.AddWithValue("", idInsertDuplicate)
                            .AddWithValue("", lblReqNo.Text.Trim)
                            .AddWithValue("", lblReqName.Text.Trim)
                            .AddWithValue("", lblDept.Text.Trim)
                            .AddWithValue("", txtRemarks.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                            .AddWithValue("", Val(lblRawMaterialID.Text))
                            '.AddWithValue("", defaultIdForRaw)
                            .AddWithValue("", txtQty.Text)
                            '.AddWithValue("", chk_active.CheckState)
                        End With
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        '  reader.Dispose()
                        'loaddgv("SELECT reqSupNo,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsupplies WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSup)
                        ' loaddgv("SELECT * FROM vw_reqsuppliess WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSupp)
                        loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSupp)
                        txtQty.Clear()
                    Else
                        reader.Close()

                        cmd = New MySqlCommand("INSERT INTO tbl_reqsupplies(reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active)VALUES(?,?,?,?,?,?,?,?)", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", lblReqNo.Text.Trim)
                            .AddWithValue("", lblReqName.Text.Trim)
                            .AddWithValue("", lblDept.Text.Trim)
                            .AddWithValue("", txtRemarks.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                            .AddWithValue("", Val(lblRawMaterialID.Text))
                            .AddWithValue("", txtQty.Text.Trim)
                            '.AddWithValue("", defaultIdForRaw)
                            .AddWithValue("", chk_active.CheckState)
                        End With

                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        'Call loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsupplies WHERE reqSupNo LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSup)
                        loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSupp)
                        'loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty  FROM vw_reqsuppliess WHERE reqSupNo = " & Val(lblReqNo.Text) & " ORDER BY reqSupNo DESC", dgvReqSupp)
                        ' loaddgv("SELECT rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSupp)
                        txtQty.Clear()
                        txtQty.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally

            GC.Collect()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MsgBox("Save Request?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sendRequest()
            ' sqlQuery("TRUNCATE tbl_reqsupplies")
            cleaner1()
        
            loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvReqSupp)
            lblReqNo.Text = ""
            autoID()
            ' sqlQuery("")
        End If
    End Sub
    Function autoID() As Boolean
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Try
            cmd = New MySqlCommand("SELECT * FROM tbl_reqsupplies ORDER BY reqSupID DESC", modcon.con)
            rd = cmd.ExecuteReader
            If (rd.Read = True) Then
                lblReqNo.Text = rd(CInt(1)) + 1
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
    Function insertID() As Boolean
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Try

            cmd = New MySqlCommand("SELECT * FROM tbl_reqsupplies ORDER BY reqSupID DESC", modcon.con)
            rd = cmd.ExecuteReader
            If (rd.Read = True) Then
                idInsertDuplicate = rd(CInt(0)) + 1
            End If

            rd.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            cmd.Dispose()

            GC.Collect()
        End Try
        Return True
    End Function

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub
End Class