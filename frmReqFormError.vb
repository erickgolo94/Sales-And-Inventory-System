Imports MySql.Data.MySqlClient
Public Class frmReqFormError
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub frmAddReqForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call autoID()
        dtpDateRequest.Value = Now
        txtTime.Text = TimeOfDay
        txtDate.Text = DateString
        loaddgv("SELECT * FROM tbl_reqsupplies ORDER BY reqSupNo DESC", Me.dgvReqSup)
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String = "SELECT * FROM vw_reqsupplies WHERE reqSupID=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            lblReqNo.Text = table.Rows(0)(1)
            lblReqName.Text = table.Rows(0)(2)
            lblDept.Text = table.Rows(0)(3)
            txtRemarks.Text = table.Rows(0)(4)
            dtpDateRequest.Value = table.Rows(0)(5)
            lblrawmaterialID.Text = table.Rows(0)(6)
            lblName.Text = table.Rows(0)(7)
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
        For Each obj As Object In ppppp.Controls
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
    Private Sub dgvReqSup_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReqSup.CellClick
        If e.RowIndex >= 0 Then
            dgvReqSup.Tag = dgvReqSup.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvReqSup.Tag))

            btnAddList.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnSelectEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectEmployee.Click
        frmSelectEmployee.ShowDialog()
    End Sub
    Private Sub btnSearchRawMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRawMaterial.Click
        frmselectRawmaterial.ShowDialog()
    End Sub

    Private Sub btnAddList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddList.Click
        Try
            If checker() = True Then

                If Val(txtqty.Text) >= Val(CDbl(OnhandsQty)) Then
                    MsgBox("Insufficient Stock!", MsgBoxStyle.Critical, "PETROMINE SALES AND INVENTORY")
                    'MessageBox.Show("The current item is :", OnhandsQty)
                    txtqty.Clear()
                    txtqty.Focus()
                ElseIf txtqty.Text = 0 Or 0.0 Then
                    MsgBox("Invalid Quantity", MsgBoxStyle.Exclamation)
                    txtqty.Clear()
                    txtqty.Focus()
                Else

                    cmd = New MySqlCommand("SELECT * FROM tbl_reqsupplies WHERE reqSupNo=? and reqBy=? and dept=? and remarks=? and dateRequest=? and rawmaterialID=?", modcon.con)
                    With cmd.Parameters
                        .AddWithValue("", lblReqNo.Text.Trim)
                        .AddWithValue("", lblReqName.Text.Trim)
                        .AddWithValue("", lblDept.Text.Trim)
                        .AddWithValue("", txtRemarks.Text.Trim)
                        .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                        .AddWithValue("", Val(lblrawmaterialID.Text))

                    End With
                    reader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Close()
                        'cmd = New MySqlCommand("UPDATE tbl_temprawmaterialonhand SET qty=" & Val(txtqty.Text) & " + " & Val(txtqty.Text) & " WHERE transactionNo=? and requestDate=? and comSupplier=? and supplierName=? and deliveryRepNo=? and deliveryRepDate=? and receiveBy=? and dateReceive=? and rawmaterialID=?", modcon.con)
                        'cmd = New MySqlCommand("INSERT INTO tbl_reqsupplies(reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty)VALUES(?,?,?,?,?,?,?) ON DUPLICATE KEY UPDATE SET qty = qty -- =" & Val(txtqty.Text) & "", modcon.con)
                        cmd = New MySqlCommand("UPDATE tbl_reqsupplies SET qty=" & Val(txtqty.Text) & " + " & Val(txtqty.Text) & " WHERE reqSupNo=? AND reqBy=? AND dept=? AND remarks=? AND dateRequest=? AND rawmaterialID=?", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", lblReqNo.Text.Trim)
                            .AddWithValue("", lblReqName.Text.Trim)
                            .AddWithValue("", lblDept.Text.Trim)
                            .AddWithValue("", txtRemarks.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                            .AddWithValue("", Val(lblrawmaterialID.Text))
                            .AddWithValue("", txtqty.Text)

                        End With
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        'loaddgv("SELECT reqSupNo,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsupplies WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSup)
                        loaddgv("SELECT * FROM vw_reqsupplies WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSup)
                        txtqty.Clear()
                    Else
                        reader.Close()
                        cmd = New MySqlCommand("INSERT INTO tbl_reqsupplies(reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active)VALUES(?,?,?,?,?,?,?,?)", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", lblReqNo.Text.Trim)
                            .AddWithValue("", lblReqName.Text.Trim)
                            .AddWithValue("", lblDept.Text.Trim)
                            .AddWithValue("", txtRemarks.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                            .AddWithValue("", Val(lblrawmaterialID.Text))
                            .AddWithValue("", txtqty.Text.Trim)
                            .AddWithValue("", chkIsActive.CheckState)
                        End With
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        '   loaddgv("SELECT * FROM tbl_reqsupplies WHERE reqSupNo LIKE ORDER BY reqSupNo DESC", dgvReqSup)
                        loaddgv("SELECT reqSupNo,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsupplies WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSup)
                        showAllRawMatRequest()
                        txtqty.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

            GC.Collect()
        End Try

    End Sub
    Public Sub showAllRawMatRequest()
        'cmd.CommandT
        Try
            Dim sqlAdat = New MySqlDataAdapter
            sqlAdat = New MySqlDataAdapter()
            Dim dt As New DataTable()

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM tbl_reqsupplies"
            cmd.Connection = modcon.con
            sqlAdat.SelectCommand = cmd
            adapt.Fill(dt)
            dgvReqSup.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            cmd.Dispose()
            adapt.Dispose()
            GC.Collect()
        End Try

    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Val(txtqty.Text) = 0 Then
                MsgBox("Insufficient Data", vbInformation)
            Else
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("UPDATE tbl_reqsupplies SET reqSupNo=?,reqBy=?,dept=?,remarks=?,dateRequest=?,rawmaterialI,qty=?,is_active=? WHERE reqSupNo='" & (dgvReqSup.Tag) & "'", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", lblReqNo.Text.Trim)
                    .AddWithValue("", lblReqName.Text.Trim)
                    .AddWithValue("", lblDept.Text.Trim)
                    .AddWithValue("", txtRemarks.Text.Trim)
                    .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                    .AddWithValue("", Val(lblrawmaterialID.Text))
                    .AddWithValue("", txtqty.Text.Trim)
                    .AddWithValue("", chkIsActive.CheckState)
                End With
                cmd.ExecuteNonQuery()
                loaddgv("SELECT reqSupNo,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsupplies WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSup)
                txtqty.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub
    Function autoID() As Boolean
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand
        Try
            cmd = New MySqlCommand("SELECT reqSupNo from vw_reqsupplies ORDER BY reqSupNo DESC", Modcon.con)
            rd = cmd.ExecuteReader
            If (rd.Read = True) Then
                Me.lblReqNo.Text = rd(CInt(0)) + 1
            Else
                Me.lblReqNo.Text = 100
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
        Return True
    End Function

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim cmd As MySqlCommand
            If MsgBox("Update Record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand("UPDATE tbl_reqsupplies SET reqSupNo=?,reqBy=?,dept=?,remarks=?,dateRequest=?,rawmaterialID=?,qty=?,is_active=? WHERE reqSupID='" & (dgvReqSup.Tag) & "'", Modcon.con)
                With cmd.Parameters
                    .AddWithValue("", lblReqNo.Text.Trim)
                    .AddWithValue("", lblReqName.Text.Trim)
                    .AddWithValue("", lblDept.Text.Trim)
                    .AddWithValue("", txtRemarks.Text.Trim)
                    .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                    .AddWithValue("", Val(lblrawmaterialID.Text))
                    .AddWithValue("", txtqty.Text.Trim)
                    .AddWithValue("", chkIsActive.CheckState)
                End With
                cmd.ExecuteNonQuery()
                loaddgv("SELECT reqSupNo,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsupplies WHERE reqSupNo  LIKE '%" & Val(lblReqNo.Text) & "%' ", dgvReqSup)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub
    Private Sub txtqty_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
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
            Dim str As String = "DELETE FROM tbl_reqsupplies WHERE reqSupID=" & Val(dgvReqSup.Tag)
            cmd = New MySqlCommand(str, con)
            cmd.ExecuteNonQuery()
            loaddgv("SELECT reqSupNo,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsupplies WHERE reqSupNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY reqSupNo DESC", dgvReqSup)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub
    Private Function sendRequest() As Boolean
        '  Dim cmd1 As New MySqlCommand
        Dim getRequestNo As Long = lblReqNo.Text
        Try
            'cmd = New MySqlCommand("INSERT INTO tbl_rawmaterialonhand(transactionNo,requestDate,comSupplier,supplierName,deliveryRepNo,deliveryRepDate,receiveBy,dateReceive,rawmaterialID,qty) SELECT transactionNo, requestDate, comSupplier, supplierName, deliveryRepNo, deliveryRepDate, receiveBy, dateReceive, rawmaterialID, qty  FROM tbl_temprawmaterialonhand WHERE transactionNo=" & Val(lblTransNo.Text) & "", modcon.con)
            'sqlQuery("INSERT INTO tbl_Mainreqsupplies (reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active)VALUES(?,?,?,?,?,?,?,?)")
            Dim cmd As New MySqlCommand("INSERT INTO tbl_Mainreqsupplies (reqSupNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active) SELECT reqSupNo, reqBy, dept, remarks, dateRequest, rawmaterialId, qty, is_active FROM tbl_reqsupplies WHERE reqSupNo = " & getRequestNo & "", modcon.con)

            With cmd.Parameters
                .AddWithValue("@purchaseNo", lblReqNo.Text.Trim)
                .AddWithValue("@reqBy", lblReqName.Text.Trim)
                .AddWithValue("@dept", lblDept.Text.Trim)
                .AddWithValue("@remarks", txtRemarks.Text.Trim)
                .AddWithValue("@dateRequest", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                .AddWithValue("@rawmaterialID", Val(lblrawmaterialID.Text))
                .AddWithValue("@qty", txtqty.Text.Trim)
                .AddWithValue("@is_active", chkIsActive.CheckState)
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
        lblName.Text = ""
        lblDept.Text = ""
        lblDesc.Text = ""
        lblUnit.Text = ""
        txtqty.Text = ""

    End Sub

    Private Sub btnFrmReqSendReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmReqSendReq.Click
        If MsgBox("Save Request?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sendRequest()
            sqlQuery("TRUNCATE tbl_temprawmaterialonhand")
            cleaner1()
            loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvReqSup)
            ' sqlQuery("")
        End If
    End Sub

    Private Sub txtTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTime.Click
    End Sub


    Private Sub dgvReqSup_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReqSup.CellContentClick

    End Sub
End Class
