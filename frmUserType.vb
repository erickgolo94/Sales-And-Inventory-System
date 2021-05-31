Imports MySql.Data.MySqlClient
Public Class frmUserType
    Dim cmd As MySqlCommand
    Dim adapt As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Private Sub frmUserType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_usertype ORDER BY userDesc", dgvUser)
    End Sub

    Private Sub fetchdata(ByVal id As Long)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            Dim str As String
            str = "SELECT * FROM tbl_usertype WHERE userTypeID=" & id
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            txtuser.Text = table.Rows(0)(1).ToString
            adapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Function checker() As Boolean
        For Each obj As Object In pnldata.Controls
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

    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnldata.Enabled = Not bool
        dgvUser.Enabled = bool
    End Sub
    Private Sub cleaner()
        For Each obj As Object In pnldata.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call toggle(False)
        Call cleaner()
        btnUpdate.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checker() = True Then
            Try
                cmd = New MySqlCommand("SELECT * FROM tbl_usertype WHERE userDesc=?", modcon.con)
                cmd.Parameters.AddWithValue("", txtuser.Text.Trim)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Duplicate entry Found!", vbCritical)
                    txtuser.Clear()
                    reader.Close()
                Else
                    reader.Close()
                    cmd = New MySqlCommand("INSERT INTO tbl_usertype (userDesc) VALUES (?)", modcon.con)
                    cmd.Parameters.AddWithValue("", txtuser.Text.Trim)
                    cmd.ExecuteNonQuery()
                    Call loaddgv("SELECT * FROM tbl_usertype ORDER BY userDesc", dgvUser)
                    Call cleaner()
                    Call toggle(True)
                    MsgBox("Successful", vbInformation)

                End If
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.Collect()
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Len(dgvUser.Tag) = 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "DELETE FROM tbl_usertype WHERE userTypeID=" & Val(dgvUser.Tag)
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM tbl_usertype ORDER BY userDesc", dgvUser)
                Call cleaner()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            Call toggle(True)
            Call cleaner()
            btnUpdate.Hide()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Val(dgvUser.Tag) = 0 Then
            MsgBox("Select a Record!", vbInformation)
        Else
            If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "EDIT FROM tbl_usertype WHERE userTypeID=" & Val(dgvUser.Tag)
                cmd = New MySqlCommand(str, con)
                txtuser.Focus()
                btnUpdate.Show()
                Call toggle(False)
                btnSave.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cmd = New MySqlCommand("SELECT * FROM tbl_usertype WHERE userDesc=?", modcon.con)
            cmd.Parameters.AddWithValue("", txtuser.Text)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                MsgBox("Duplicate entry Found!", vbCritical)
                txtuser.Clear()
                reader.Close()
            Else
                reader.Close()
                cmd = New MySqlCommand("UPDATE tbl_usertype SET userDesc=? WHERE userTypeID='" & Val(dgvUser.Tag) & "'", modcon.con)
                cmd.Parameters.AddWithValue("", txtuser.Text.Trim)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM tbl_usertype ORDER BY userDesc", dgvUser)
                Call cleaner()
                Call toggle(True)
                MsgBox("Successful", vbInformation)
                Call toggle(True)
                Me.btnUpdate.Hide()
            End If
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub dgvUser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUser.CellClick
        If e.RowIndex >= 0 Then
            dgvUser.Tag = dgvUser.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvUser.Tag))
        End If
    End Sub

    Private Sub dgvUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUser.CellContentClick

    End Sub
End Class