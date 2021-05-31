Imports MySql.Data.MySqlClient
Public Class frmSupplier
    Dim reader As MySqlDataReader
    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_supplier ORDER BY supplierCode", dgvSupplier)
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loaddgv("SELECT * FROM tbl_supplier WHERE supplierCode LIKE '%" & Trim(txtSearch.Text) & "%' ", dgvSupplier)
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM tbl_supplier WHERE supplierID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        txtSupplierCode.Text = table.Rows(0)(1).ToString
        txtCompany.Text = table.Rows(0)(2).ToString
        txtSupplierName.Text = table.Rows(0)(3).ToString
        txtAddress.Text = table.Rows(0)(4).ToString
        txtContactPerson.Text = table.Rows(0)(5).ToString
        txtCnum.Text = table.Rows(0)(6).ToString
        txtemail.Text = table.Rows(0)(7).ToString
        adapt.Dispose()
    End Sub
    Private Sub dgvSupplier_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        If e.RowIndex >= 0 Then
            dgvSupplier.Tag = dgvSupplier.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvSupplier.Tag))
        End If
    End Sub
    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnlData.Enabled = Not bool
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
    Private Sub cleaner()
        For Each obj As Object In pnlData.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtSupplierCode.Focus()
        Call toggle(False)
        Call cleaner()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checker() = True Then
            Try
                cmd = New MySqlCommand("SELECT * FROM tbl_supplier WHERE supplierCode=?", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtSupplierCode.Text.Trim)
                End With
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Duplicate entry Found!", vbCritical)
                    Call cleaner()
                    txtSupplierCode.Focus()
                    reader.Close()
                Else
                    reader.Close()
                    Dim cmd As MySqlCommand
                    If MsgBox("Save this Record?", vbYesNo + vbQuestion) = vbYes Then
                        cmd = New MySqlCommand("INSERT INTO tbl_supplier (supplierCode,Company,supplierName,address,contactPerson,cnum,email) VALUES (?,?,?,?,?,?)", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", txtSupplierCode.Text.Trim)
                            .AddWithValue("", txtCompany.Text.Trim)
                            .AddWithValue("", txtSupplierName.Text.Trim)
                            .AddWithValue("", txtSupplierName.Text.Trim)
                            .AddWithValue("", txtAddress.Text.Trim)
                            .AddWithValue("", txtContactPerson.Text.Trim)
                            .AddWithValue("", txtCnum.Text.Trim)
                        End With
                        cmd.ExecuteNonQuery()
                        Call loaddgv("SELECT * FROM tbl_supplier ORDER BY supplierCode", dgvSupplier)
                        Call cleaner()
                        Call toggle(True)
                        cmd.Dispose()
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.Collect()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            txtSupplierCode.Focus()
            Call toggle(True)
            Call cleaner()
            btnUpdate.Hide()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If Val(dgvSupplier.Tag) = 0 Then
                MsgBox("Select a Record!", vbInformation)
            Else
                If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                    Dim cmd As MySqlCommand
                    Dim str As String = "EDIT FROM tbl_supplier WHERE supplierID=" & Val(dgvSupplier.Tag)
                    cmd = New MySqlCommand(str, con)
                    txtSupplierCode.Focus()
                    Call toggle(False)
                    btnSave.Enabled = False
                    btnUpdate.Show()
                End If
            End If
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Len(dgvSupplier.Tag) = 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "DELETE FROM tbl_supplier WHERE supplierID=" & Val(dgvSupplier.Tag)
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Call loaddgv("SELECT * FROM tbl_supplier ORDER BY supplierCode", dgvSupplier)
                Call cleaner()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cmd = New MySqlCommand("SELECT * FROM tbl_supplier WHERE supplierCode=? ", modcon.con)
            With cmd.Parameters
                .AddWithValue("", txtSupplierCode.Text.Trim)
            End With
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                MsgBox("Duplicate entry Found!", vbCritical)
                txtSupplierCode.Clear()
                txtSupplierCode.Focus()
                reader.Close()
            Else
                reader.Close()
                cmd = New MySqlCommand("UPDATE tbl_supplier  SET supplierCode=?, Company=?,supplierName=?, Address=?,contactPerson=?,cnum=?, email=?  WHERE supplierID='" & Val(dgvSupplier.Tag) & "'", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtSupplierCode.Text.Trim)
                    .AddWithValue("", txtCompany.Text.Trim)
                    .AddWithValue("", txtSupplierName.Text.Trim)
                    .AddWithValue("", txtSupplierName.Text.Trim)
                    .AddWithValue("", txtAddress.Text.Trim)
                    .AddWithValue("", txtContactPerson.Text.Trim)
                    .AddWithValue("", txtCnum.Text.Trim)
                End With
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM tbl_supplier ORDER BY supplierCode", dgvSupplier)
                Call cleaner()
                Call toggle(True)
                Me.btnUpdate.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loaddgv("SELECT * FROM tbl_supplier WHERE supplierName LIKE '%" & txtSearch.Text & "%'", dgvSupplier)
    End Sub
End Class