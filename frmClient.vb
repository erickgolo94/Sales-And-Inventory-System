Imports MySql.Data.MySqlClient
Public Class frmClient
    Dim reader As MySqlDataReader
    Dim cmd As MySqlCommand
    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_client ORDER BY clientCode", dgvclient)
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loaddgv("SELECT * FROM tbl_client WHERE clientName LIKE '%" & Trim(txtSearch.Text) & "%' ", dgvclient)
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM tbl_client WHERE clientID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        txtClientCode.Text = table.Rows(0)(1).ToString
        txtCompany.Text = table.Rows(0)(2).ToString
        txtClientName.Text = table.Rows(0)(3).ToString
        txtAddress.Text = table.Rows(0)(4).ToString
        txtContactPer.Text = table.Rows(0)(5).ToString
        txtCnum.Text = table.Rows(0)(6).ToString
        txtEmail.Text = table.Rows(0)(7).ToString
        adapt.Dispose()
    End Sub
    Private Sub dgvclient_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclient.CellClick
        If e.ColumnIndex >= 0 Then
            dgvclient.Tag = dgvclient.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvclient.Tag))
        End If
    End Sub
    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnlData.Enabled = Not bool
        'dgvclient.Enabled = bool
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
        txtClientCode.Focus()
        Call toggle(False)
        Call cleaner()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checker() = True Then
            Try
                cmd = New MySqlCommand("SELECT * FROM tbl_client WHERE clientCode=?", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtClientCode.Text.Trim)
                End With
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Duplicate entry Found!", vbCritical)
                    Call cleaner()
                    txtClientCode.Focus()
                    reader.Close()
                Else
                    reader.Close()
                    Dim cmd As MySqlCommand
                    If MsgBox("Save this Record?", vbYesNo + vbQuestion) = vbYes Then
                        cmd = New MySqlCommand("INSERT INTO tbl_client (clientCode,Company,clientName,address,contactPerson,cnum,email) VALUES (?,?,?,?,?,?)", modcon.con)
                        With cmd.Parameters
                            .AddWithValue("", txtClientCode.Text.Trim)
                            .AddWithValue("", txtCompany.Text.Trim)
                            .AddWithValue("", txtAddress.Text.Trim)
                            .AddWithValue("", txtContactPer.Text.Trim)
                            .AddWithValue("", txtCnum.Text.Trim)
                            .AddWithValue("", txtEmail.Text.Trim)
                        End With
                        cmd.ExecuteNonQuery()
                        Call loaddgv("SELECT * FROM tbl_client ORDER BY clientCode", dgvclient)
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cmd = New MySqlCommand("SELECT * FROM tbl_client WHERE clientCode=? ", modcon.con)
            With cmd.Parameters
                .AddWithValue("", txtClientCode.Text.Trim)
            End With
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                MsgBox("Duplicate entry Found!", vbCritical)
                txtClientCode.Clear()
                txtClientCode.Focus()
                reader.Close()
            Else
                reader.Close()
                cmd = New MySqlCommand("UPDATE tbl_client  SET clientCode=?,Company=?, clientName=?,address=?,contactPerson=?,cnum=?,email=?  WHERE clientID='" & Val(dgvclient.Tag) & "'", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtClientCode.Text.Trim)
                    .AddWithValue("", txtCompany.Text.Trim)
                    .AddWithValue("", txtAddress.Text.Trim)
                    .AddWithValue("", txtContactPer.Text.Trim)
                    .AddWithValue("", txtCnum.Text.Trim)
                    .AddWithValue("", txtEmail.Text.Trim)
                End With
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM tbl_client ORDER BY clientCode", dgvclient)
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            txtClientCode.Focus()
            Call toggle(True)
            Call cleaner()
            btnUpdate.Hide()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If Val(dgvclient.Tag) = 0 Then
                MsgBox("Select a Record!", vbInformation)
            Else
                If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                    Dim cmd As MySqlCommand
                    Dim str As String = "EDIT FROM tbl_client WHERE clientID=" & Val(dgvclient.Tag)
                    cmd = New MySqlCommand(str, con)
                    txtClientCode.Focus()
                    Call toggle(False)
                    btnUpdate.Show()
                    btnSave.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Len(dgvclient.Tag) = 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "DELETE FROM tbl_client WHERE clientID=" & Val(dgvclient.Tag)
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM tbl_client ORDER BY clientCode", dgvclient)
                Call cleaner()
            End If
        End If
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        'If (e.KeyChar < "0" OrElse e.KeyChar > "0") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
        'e.Handled = True
        'End If


    End Sub
End Class