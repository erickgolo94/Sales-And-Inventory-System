Imports MySql.Data.MySqlClient
Public Class frmAccount

    Private Sub frmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM vw_account ORDER BY fullname", dgvAccount)
        '    Call loadcmb("SELECT * FROM tbl_designation ORDER BY designationDesc", cmbDesignation, "designationDesc ", "designationID")
        '  loadcmb("SELECT * FROM tbl_designation ORDER BY designationID", cmbDesignation, "designationDesc", "designationID")
        Call loadcmb("SELECT * FROM tbl_usertype ORDER BY userDesc", cmbUserType, "userDesc", "userTypeID")
        fetchComboDesgination()
      
    End Sub
    Private Function fetch(ByRef id As Long) As Boolean
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM tbl_account WHERE accountID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        ' With 
        txtFname.Text = table.Rows(0)(1).ToString
        txtMname.Text = table.Rows(0)(2).ToString
        txtLname.Text = table.Rows(0)(3).ToString
        ' cmbDesignation.SelectedText = table.Rows(0)(4).ToString
        ' lblDept.Text = table.Rows(0)(5).ToString
        txtUsername.Text = table.Rows(0)(5)
        txtpassword.Text = table.Rows(0)(6).ToString
        txtRetypePass.Text = table.Rows(0)(6).ToString
        cmbUserType.SelectedText = table.Rows(0)(7).ToString
        ' End With
        adapt.Dispose()
        Return True
    End Function
    Private Sub fetchComboDesgination()
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            adapt = New MySqlDataAdapter("SELECT * FROM tbl_designation ORDER BY designationDesc ", modcon.con)
            table = New DataTable
            adapt.Fill(table)
            cmbDesignation.DataSource = table
            cmbDesignation.DisplayMember = "deptDesc"
            cmbDesignation.ValueMember = "designationID"
            lblID.Text = table.Rows(0)(0).ToString
            lblDept.Text = table.Rows(0)(1).ToString
            adapt.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MsgBox("Update Record?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE account SET fname=?,mname=?,designationID=?,UserName=?,passKey=?,UserTypeID=?,is_active=? WHERE accountID =" & Val(dgvAccount.Tag) & "", modcon.con)
            cmd.Parameters.AddWithValue("", txtFname.Text.Trim)
            cmd.Parameters.AddWithValue("", txtMname.Text.Trim)
            cmd.Parameters.AddWithValue("", txtLname.Text.Trim)
            cmd.Parameters.AddWithValue("", cmbDesignation.SelectedValue)
            cmd.Parameters.AddWithValue("", Trim(txtUsername.Text))
            cmd.Parameters.AddWithValue("", Trim(txtRetypePass.Text))
            cmd.Parameters.AddWithValue("", cmbUserType.SelectedValue)
            cmd.Parameters.AddWithValue("", chk_active.CheckState)
            cmd.ExecuteNonQuery()
            Call loaddgv("SELECT * FROM vw_account ORDER BY designationDesc", dgvAccount)
            Call cleaner()
            Call toggle(True)
            Me.btnUpdate.Hide()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If checker() = True Then
            Try
                'Track if password not matched!
                If txtpassword.Text <> txtRetypePass.Text Then
                    MsgBox("Password not match!, Please Re-type.", MsgBoxStyle.Critical)
                    txtRetypePass.Clear()
                    txtRetypePass.Focus()
                Else
                    '  reader.Close()
                    cmd = New MySqlCommand("INSERT INTO tbl_account(fname,mname,lname,designationID,UserName,passKey,UserTypeID,is_active) VALUES (?,?,?,?,?,?,?,?)", modcon.con)
                    cmd.Parameters.AddWithValue("", txtFname.Text.Trim)
                    cmd.Parameters.AddWithValue("", txtMname.Text.Trim)
                    cmd.Parameters.AddWithValue("", txtLname.Text.Trim)
                    cmd.Parameters.AddWithValue("", cmbDesignation.SelectedValue)
                    cmd.Parameters.AddWithValue("", Trim(txtUsername.Text))
                    cmd.Parameters.AddWithValue("", Trim(txtRetypePass.Text))
                    cmd.Parameters.AddWithValue("", cmbUserType.SelectedValue)
                    cmd.Parameters.AddWithValue("", chk_active.CheckState)
                    cmd.ExecuteNonQuery()
                    MsgBox("Successful", vbInformation)
                    Call loaddgv("SELECT * FROM vw_account ORDER BY designationDesc", dgvAccount)
                    Call cleaner()
                    Call toggle(True)

                End If
                ' End If
                cmd.Dispose()

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally

                GC.Collect()
            End Try
        End If

    End Sub
    Private Function checker() As Boolean
        For Each obj As Object In pnlde.Controls
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
        pnlde.Enabled = Not bool
        dgvAccount.Enabled = bool
    End Sub
    Private Sub cleaner()
        For Each obj As Object In pnlde.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call toggle(False)
        Call cleaner()
        txtFname.Focus()
        btnUpdate.Hide()
    End Sub

    Private Sub cmbDesignation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDesignation.Click
        fetchComboDesgination()
    End Sub

    Private Sub cmbDesignation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDesignation.SelectedIndexChanged

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            Call toggle(True)
            Call cleaner()
            btnUpdate.Hide()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Val(dgvAccount.Tag) = 0 Then
            MsgBox("Select a Record!", vbInformation)
        Else
            If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "EDIT FROM tbl_designation WHERE designationID=" & Val(dgvAccount.Tag)
                cmd = New MySqlCommand(str, con)
                txtFname.Focus()
                Call toggle(False)
                btnUpdate.Show()

            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Val(dgvAccount.Tag) < 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "DELETE FROM tbl_account WHERE accountID=" & Val(dgvAccount.Tag) & ""
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM vw_account ORDER BY designationDesc", dgvAccount)
                Call cleaner()
            End If
        End If
    End Sub

    Private Sub dgvAccount_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccount.CellClick
        If e.RowIndex >= 0 Then
            dgvAccount.Tag = dgvAccount.Item(0, e.RowIndex).Value
            fetch(Val(dgvAccount.Tag))
        End If
    End Sub

    Private Sub dgvAccount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccount.CellContentClick

    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        '  loaddgv("SELECT * FROM vw_account WHERE fullname LIKE '%" & Trim(txtSearch.Text) & "'%", dgvAccount)
        loaddgv("SELECT * FROM vw_account WHERE fullname like '%" & Trim(txtSearch.Text) & "%'", dgvAccount)
    End Sub
End Class