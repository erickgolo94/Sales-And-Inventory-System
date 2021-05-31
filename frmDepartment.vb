Imports MySql.Data.MySqlClient
Public Class frmDepartment
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_department ORDER BY deptDesc", dgvDept)
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As New DataTable
        Dim str As String
        str = "SELECT * FROM tbl_department WHERE deptID=" & id
        adapt = New MySqlDataAdapter(str, con)
        adapt.Fill(table)
        txtDept.Text = table.Rows(0)(1).ToString
        adapt.Dispose()
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

    Private Sub dgvDept_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDept.CellClick
        If e.RowIndex >= 0 Then
            dgvDept.Tag = dgvDept.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvDept.Tag))
        End If
    End Sub
    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnldata.Enabled = Not bool
        dgvDept.Enabled = bool

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
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checker() = True Then
            Try
                cmd = New MySqlCommand("SELECT * FROM tbl_department WHERE deptDesc=?", Modcon.con)
                cmd.Parameters.AddWithValue("", txtDept.Text.Trim)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Duplicate entry Found!", vbCritical)
                    txtDept.Clear()
                    reader.Close()
                Else
                    reader.Close()
                    cmd = New MySqlCommand("INSERT INTO tbl_department (deptDesc) VALUES (?)", Modcon.con)
                    cmd.Parameters.AddWithValue("", txtDept.Text.Trim)
                    cmd.ExecuteNonQuery()
                    Call loaddgv("SELECT * FROM tbl_department ORDER BY deptDesc", dgvDept)
                    Call cleaner()
                    Call toggle(True)
                End If
                cmd.Dispose()
                reader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.Collect()
            End Try
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
        If Val(dgvDept.Tag) = 0 Then
            MsgBox("Select a Record!", vbInformation)
        Else
            If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "EDIT FROM tbl_department WHERE deptID=" & Val(dgvDept.Tag)
                cmd = New MySqlCommand(str, con)
                txtDept.Focus()
                Call toggle(False)
                btnUpdate.Show()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Len(dgvDept.Tag) = 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "DELETE FROM tbl_department WHERE deptID=" & Val(dgvDept.Tag)
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM tbl_department ORDER BY deptDesc", dgvDept)
                Call cleaner()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If MsgBox("Update this Record?", vbInformation) Then
                cmd = New MySqlCommand("UPDATE tbl_department SET deptDesc=? WHERE deptID='" & Val(dgvDept.Tag) & "'", Modcon.con)
                cmd.Parameters.AddWithValue("", txtDept.Text.Trim)
                cmd.ExecuteNonQuery()
                loaddgv("SELECT * FROM tbl_department ORDER BY deptDesc", dgvDept)
                toggle(True)
                Me.btnUpdate.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub
End Class