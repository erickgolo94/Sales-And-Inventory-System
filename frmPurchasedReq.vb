Imports MySql.Data.MySqlClient
Public Class frmPurchasedReq
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub frmPurchasedReq_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtRemarksPO.Focus()
    End Sub
    Private Sub frmPurchasedReqvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call autoID()
        dtpDateRequest.Value = Now
        txtTime.Text = TimeOfDay
        txtDate.Text = DateString
        tsUSER.Text = labelUser
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String = "SELECT * FROM vw_purchasereqmain WHERE purchaseID=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            lblReqNo.Text = table.Rows(0)(1)
            lblReqName.Text = table.Rows(0)(2)
            lblDept.Text = table.Rows(0)(3)
            txtRemarksPO.Text = table.Rows(0)(4)
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
    Function autoID() As Boolean
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand
        Try
            cmd = New MySqlCommand("SELECT purchaseNo from vw_purchasereqmain ORDER BY purchaseNo DESC", modcon.con)
            rd = cmd.ExecuteReader
            If (rd.Read = True) Then
                lblReqNo.Text = rd(CInt(0)) + 1
            Else
                Me.lblReqNo.Text = 1
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

    Private Sub dgvPurchase_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex >= 0 Then
            btnAddList.Enabled = False
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            dgvPurchase.Tag = dgvPurchase.Item(0, e.RowIndex).Value
            fetchdata(Val(dgvPurchase.Tag))

        End If
    End Sub

    Private Sub btnSelectEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectEmployee.Click
        frmSelectEmployeePO.ShowDialog()
    End Sub

    Private Sub btnSearchRawMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRawMaterial.Click
        frmselectRawmaterial.ShowDialog()
    End Sub
    Private Sub save()
        cmd = New MySqlCommand("INSERT INTO tbl_purchsereq (purchaseNo,reqBy,dept,remarks,dateRequest,name,desc,category,unit,qty,is_active) values (?,?,?,?,?,?,?,?,?,?,?)", modcon.con)
        With cmd.Parameters
            .AddWithValue("", lblReqNo.Text.Trim)
            .AddWithValue("", lblReqName.Text.Trim)
            .AddWithValue("", lblDept.Text.Trim)
            .AddWithValue("", txtRemarksPO.Text.Trim)
            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
            .AddWithValue("", lblName.Text.Trim)
            .AddWithValue("", lblDesc.Text.Trim)
            .AddWithValue("", lblCat.Text.Trim)
            .AddWithValue("", lblUnit.Text.Trim)
            .AddWithValue("", txtqty.Text.Trim)
            .AddWithValue("", chk_active.CheckState)
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()


    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim str As String = "DELETE FROM tbl_purchasereq WHERE purchaseID=" & Val(dgvPurchase.Tag)
            cmd = New MySqlCommand(str, con)
            cmd.ExecuteNonQuery()
            Call loaddgv("SELECT purchaseNo,qty,rawmaterialName,`desc`,catDesc,unitDesc FROM vw_purchasereqmain WHERE purchaseNo LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY purchaseNo DESC", dgvPurchase)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
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

    Private Sub btnAddto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddList.Click
        Dim qty As Double
        qty = Val(txtqty.Text)

        If checker() = True Then
            If txtqty.Text = 0 Or 0.0 Then
                MsgBox("Invalid Quantity", MsgBoxStyle.Critical)
            Else
                Try
                    cmd = New MySqlCommand("SELECT * FROM tbl_purchasereqmain WHERE purchaseNo=? and reqBy=? and dept=? and remarks=? and dateRequest=? AND supplierID=? AND rawmaterialID=? ", modcon.con)
                    With cmd.Parameters

                        .AddWithValue("", lblReqNo.Text.Trim)
                        .AddWithValue("", lblReqName.Text.Trim)
                        .AddWithValue("", lblDept.Text.Trim)
                        .AddWithValue("", txtRemarksPO.Text.Trim)
                        .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                        .AddWithValue("", lblSupId.Text)
                        .AddWithValue("", Val(lblrawmaterialID.Text))
                    End With
                    reader = cmd.ExecuteReader
                    If reader.HasRows Then
                        reader.Close()

                        cmd = New MySqlCommand("UPDATE tbl_purchasereqmain SET qty = qty + " & Val(txtqty.Text) & " WHERE purchaseNo=? and reqBy=? and dept=? and remarks=? and dateRequest=? AND supplierID=? and rawmaterialID=?", modcon.con)
                        'cmd = New MySqlCommand("UPDATE tbl_purchasereqmain SET qty = qty + " & Val(txtqty.Text) & " WHERE purchaseNo = " & Val(CLng(lblReqNo.Text)) & "", modcon.con)
                        'purchaseNo=? AND reqBy=? AND dept=? AND remarks=? AND dateRequest=? AND rawmaterialID=?", modcon.con)
                        'cmd = New MySqlCommand("UPDATE tbl_purchasereqmain SET qty=" & Val(txtqty.Text) & " + " & Val(txtqty.Text) & " WHERE purchaseNo=? and reqBy? and dept=? and remarks=? and dateRequest=? and rawmaterialID=? ", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", Val(lblReqNo.Text))
                            .AddWithValue("", lblReqName.Text.Trim)
                            .AddWithValue("", lblDept.Text.Trim)
                            .AddWithValue("", txtRemarksPO.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                            .AddWithValue("", lblSupId.Text)
                            .AddWithValue("", Val(lblrawmaterialID.Text))
                        End With
                        cmd.ExecuteNonQuery()
                        loaddgv("SELECT * FROM vw_purchasereqmain WHERE purchaseNo LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY purchaseNo DESC", dgvPurchase)
                        txtqty.Clear()
                    Else
                        reader.Close()
                        cmd = New MySqlCommand("INSERT INTO tbl_purchasereqmain(purchaseNo,reqBy,dept,remarks,dateRequest, supplierID,rawmaterialID,qty,is_active)values(?,?,?,?,?,?,?,?,?)", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", lblReqNo.Text.Trim)
                            .AddWithValue("", lblReqName.Text.Trim)
                            .AddWithValue("", lblDept.Text.Trim)
                            .AddWithValue("", txtRemarksPO.Text.Trim)
                            .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                            .AddWithValue("", lblSupId.Text)
                            .AddWithValue("", Val(lblrawmaterialID.Text))
                            .AddWithValue("", txtqty.Text.Trim)
                            .AddWithValue("", chk_active.CheckState)
                        End With
                        cmd.ExecuteNonQuery()
                        loaddgv("SELECT * FROM vw_purchasereqmain WHERE purchaseNo  LIKE '%" & Trim(lblReqNo.Text) & "%' ORDER BY purchaseNo DESC", dgvPurchase)
                        txtqty.Clear()
                    End If
                    cmd.Dispose()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    GC.Collect()
                End Try
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If MsgBox("Update Record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand("UPDATE tbl_purchasereq SET purchaseNo=?,reqBy=?,dept=?,remarks=?,dateRequest=?,rawmaterialID=?,qty=?,is_active=? WHERE purchaseNo='" & (dgvPurchase.Tag) & "'", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", lblReqNo.Text.Trim)
                    .AddWithValue("", lblReqName.Text.Trim)
                    .AddWithValue("", lblDept.Text.Trim)
                    .AddWithValue("", txtRemarksPO.Text.Trim)
                    .AddWithValue("", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                    .AddWithValue("", lblrawmaterialID.Text)
                    .AddWithValue("", txtqty.Text.Trim)
                    .AddWithValue("", chk_active.CheckState)
                End With
                cmd.ExecuteNonQuery()
                loaddgv("SELECT qty,purchaseNo,rawmaterialName,`desc`,catDesc,unitDesc FROM vw_purchasereqmain WHERE purchaseNo  LIKE '%" & Val(lblReqNo.Text) & "%' ", dgvPurchase)
                MsgBox("success")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub
    Private Function sendRequest() As Boolean
        'Dim getRequestNo As Long = lblReqNo.Text
        Try
            If MsgBox("Save Transaction?", vbYesNo) = vbYes Then
                'Dim cmd As New MySqlCommand("INSERT INTO tbl_purchasereqmain purchaseNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active SELECT purchaseNo, reqBy, dept, remarks, dateRequest, rawmaterialID, qty, is_active FROM tbl_purchasereq WHERE purchaseNo ='" & getRequestNo & "'", modcon.con)
                cmd = New MySqlCommand("INSERT INTO tbl_purchasereqmain(purchaseNo,reqBy,dept,remarks,dateRequest,supplierID, rawmaterialID,qty,is_active) SELECT purchaseNo,reqBy,dept,remarks,dateRequest,supplierID,rawmaterialID,qty,is_active FROM tbl_purchasereq WHERE purchaseNo=" & Val(lblReqNo.Text) & "", modcon.con)
                With cmd.Parameters
                    .AddWithValue("@reqSupNo", lblReqNo.Text.Trim)
                    .AddWithValue("@reqBy", lblReqName.Text.Trim)
                    .AddWithValue("@dept", lblDept.Text.Trim)
                    .AddWithValue("@remarks", txtRemarksPO.Text.Trim)
                    .AddWithValue("@dateRequest", Format(dtpDateRequest.Value, "yyyy-MM-dd"))
                    .AddWithValue("@supplierID", Val(lblSupId.Text))
                    .AddWithValue("@rawmaterialID", Val(lblrawmaterialID.Text))
                    .AddWithValue("@qty", txtqty.Text.Trim)
                    .AddWithValue("@is_active", chk_active.CheckState)
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'MessageBox.Show("Send Request Successfully", "PETROMINE SALES AND INVENTORY")
                loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_purchasereqmain", dgvPurchase)
                'loaddgv("SELECT * FROM vw_purchasereqmain", dgvPurchase)
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        Finally
            GC.Collect()
        End Try
        Return False
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Save Request?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sendRequest()
                '  IDPO = Val(lblReqNo.Text)
                loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_purchasereqmain WHERE purchaseNo LIKE '%" & Val(dgvPurchase.Tag) & "%' ", dgvPurchase)
                Me.Dispose()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
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

    Private Sub btnSearchSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSupplier.Click
        frmSelectSupplier.Show()
    End Sub
End Class