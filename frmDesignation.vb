Imports MySql.Data.MySqlClient
Public Class frmDesignation
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub frmPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_designation ORDER BY designationDesc", dgvPosition)
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As New DataTable
        Dim str As String
        str = "SELECT * FROM tbl_designation WHERE designationID=" & id
        adapt = New MySqlDataAdapter(str, con)
        adapt.Fill(table)
        txtdesignation.Text = table.Rows(0)(1).ToString
        txtDept.Text = table.Rows(0)(2).ToString
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

    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnldata.Enabled = Not bool
        dgvPosition.Enabled = bool

    End Sub
    Private Sub cleaner()
        For Each obj As Object In pnldata.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub

    Private Sub dgvPosition_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPosition.CellClick
        If e.RowIndex >= 0 Then
            dgvPosition.Tag = dgvPosition.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvPosition.Tag))
        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call toggle(False)
        Call cleaner()
        btnUpdate.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            Call toggle(True)
            Call cleaner()
            btnUpdate.Hide()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checker() = True Then
            Try
                cmd = New MySqlCommand("SELECT * FROM tbl_designation WHERE designationDesc=?", modcon.con)
                cmd.Parameters.AddWithValue("", txtdesignation.Text.Trim)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Duplicate entry Found!", vbCritical)
                    txtdesignation.Clear()
                    txtdesignation.Focus()
                    reader.Close()
                Else
                    reader.Close()
                    cmd = New MySqlCommand("INSERT INTO tbl_designation (designtionDesc,deptDesc) VALUES (?,?)", modcon.con)
                    cmd.Parameters.AddWithValue("", txtdesignation.Text.Trim)
                    cmd.Parameters.AddWithValue("", txtDept.Text.Trim)
                    cmd.ExecuteNonQuery()
                    Call loaddgv("SELECT * FROM tbl_designation ORDER BY designationDesc", dgvPosition)
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Val(dgvPosition.Tag) = 0 Then
            MsgBox("Select a Record!", vbInformation)
        Else
            If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "EDIT FROM tbl_designation WHERE designationID=" & Val(dgvPosition.Tag)
                cmd = New MySqlCommand(str, con)
                txtdesignation.Focus()
                Call toggle(False)
                btnUpdate.Show()

            End If
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Len(dgvPosition.Tag) = 0 Then
                MsgBox("Select Record!", vbInformation)
            Else
                If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                    Dim cmd As MySqlCommand
                    Dim str As String = "DELETE FROM tbl_designation WHERE designationID=" & Val(dgvPosition.Tag)
                    cmd = New MySqlCommand(str, con)
                    cmd.ExecuteNonQuery()
                    Call loaddgv("SELECT * FROM tbl_designation ORDER BY designationDesc", dgvPosition)
                    Call cleaner()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cmd = New MySqlCommand("SELECT * FROM tbl_designation WHERE designationDesc=?", modcon.con)
            cmd.Parameters.AddWithValue("", txtdesignation.Text.Trim)
            cmd.Parameters.AddWithValue("", txtDept.Text.Trim)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                MsgBox("Duplicate entry Found!", vbCritical)
                txtdesignation.Clear()
                reader.Close()
            Else
                reader.Close()
                cmd = New MySqlCommand("UPDATE tbl_unit SET unitDesc=? WHERE unitID='" & Val(dgvPosition.Tag) & "'", modcon.con)
                cmd.Parameters.AddWithValue("", txtdesignation.Text.Trim)
                cmd.Parameters.AddWithValue("", txtDept.Text.Trim)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM tbl_designation ORDER BY designationDesc", dgvPosition)
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
End Class