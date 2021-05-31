Imports mysql.mysqlclient
Public Class frmEmployee
    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM vw_newEmployee ORDER BY lname", dgvEmployee)
        Call loadcmb("SELECT * FROM tbl_designation order by designationDesc", cmbdesignation, "designationDesc", "designationID")
        Call loadcmb("SELECT * FROM tbl_department order by deptDesc", cmbdept, "deptDesc", "deptID")
        loadcmb("SELECT * FROM tbl_city ORDER BY cityDesc", cmCity, "cityDesc", "cityID")
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loaddgv("SELECT * FROM vw_newEmployee WHERE concat(lname,', ',fname,' ',mi,'.') LIKE '%" & Trim(txtSearch.Text) & "%' ", dgvEmployee)
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As New DataTable
        Dim str As String
        str = "SELECT * FROM vw_newEmployee WHERE empID=" & id
        adapt = New MySqlDataAdapter(str, con)
        adapt.Fill(table)
        ' id = table.Rows(0)(0)
        txtfname.Text = table.Rows(0)(1).ToString
        txtmi.Text = table.Rows(0)(2).ToString
        txtlname.Text = table.Rows(0)(3).ToString
        dtpbday.Value = table.Rows(0)(4).ToString
        txlot.Text = table.Rows(0)(5).ToString
        txtblk.Text = table.Rows(0)(6).ToString
        txtstreet.Text = table.Rows(0)(7).ToString
        txtbrgy.Text = table.Rows(0)(8).ToString
        cmCity.Text = table.Rows(0)(9).ToString
        txtcnum.Text = table.Rows(0)(10).ToString
        cmbdesignation.Text = table.Rows(0)(11).ToString
        cmbdept.Text = table.Rows(0)(12).ToString
        adapt.Dispose()
    End Sub
    Private Function checker() As Boolean
        For Each obj As Object In pnldata.controls
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
    
    Private Sub dgvEmployee_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployee.CellClick
        If e.RowIndex >= 0 Then
            dgvEmployee.Tag = dgvEmployee.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvEmployee.Tag))
        End If
    End Sub
    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnldata.Enabled = Not bool
        dgvEmployee.Enabled = bool

    End Sub
    Private Sub cleaner()
        For Each obj As Object In pnldata.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtfname.Focus()
        Call toggle(False)
        Call cleaner()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            Call toggle(True)
            Call cleaner()
            btnUpdate.Hide()
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Len(dgvEmployee.Tag) = 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                Dim str As String = "DELETE FROM tbl_employee WHERE empID=" & Val(dgvEmployee.Tag)
                cmd = New MySqlCommand(str, con)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM vw_newEmployee ORDER BY lname", dgvEmployee)
                Call cleaner()
            End If
        End If
    End Sub
    Private Function save() As Boolean
        Try
            Dim cmd As mysqlcommand
            If MsgBox("Save this Record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand("INSERT INTO tbl_employee(fname,mi,lname,bday,blk,lot,street,brgy,city,cnum,designationID,deptID) VALUES (?,?,?,?,?,?,?,?,?,?,?,?)", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtfname.Text.Trim)
                    .AddWithValue("", txtmi.Text.Trim)
                    .AddWithValue("", txtlname.Text.Trim)
                    .AddWithValue("", Format(dtpbday.Value, "yyyy-MM-dd"))
                    .AddWithValue("", txlot.Text.Trim)
                    .AddWithValue("", txtblk.Text.Trim)
                    .AddWithValue("", txtstreet.Text.Trim)
                    .AddWithValue("", txtbrgy.Text.Trim)
                    .AddWithValue("", cmCity.SelectedValue)
                    .AddWithValue("", txtcnum.Text.Trim)
                    .AddWithValue("", cmbdesignation.SelectedValue)
                    .AddWithValue("", cmbdept.SelectedValue)
                    '  .AddWithValue("", Trim(txtUsername.Text))
                    '  .AddWithValue("", Trim(txtRePass.Text))
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Call loaddgv("SELECT * FROM vw_newEmployee ORDER BY lname", dgvEmployee)
                Call cleaner()
                Call toggle(True)
                MessageBox.Show("Account Successfully Created!", "PETROMINE SALES AND INVENTORY")
                '     Else
                'MessageBox.Show("Password does not match try again!", "PETROMINE SALES AND INVENTORY")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try


        Return True
    End Function
    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()
    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If Val(dgvEmployee.Tag) = 0 Then
                MsgBox("Select a Record!", vbInformation)
            Else
                If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                    Dim cmd As MySqlCommand
                    Dim str As String = "EDIT FROM tbl_employee WHERE empID=" & Val(dgvEmployee.Tag)
                    cmd = New MySqlCommand(str, con)
                    btnUpdate.Show()
                    txtfname.Focus()
                    Call toggle(False)
                    btnSave.Enabled = False
                End If
            End If
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MsgBox("Update Record?", vbYesNo + vbQuestion) = vbYes Then
            cmd = New MySqlCommand("UPDATE tbl_employee SET fname=?,mi=?,lname=?,bday=?,blk=?,lot=?,street=?,brgy=?,city=?,cnum=?,designationID=?,deptID=?  WHERE empID='" & Val(dgvEmployee.Tag) & "'", Modcon.con)
            With cmd.Parameters
                .AddWithValue("", txtfname.Text.Trim)
                .AddWithValue("", txtmi.Text.Trim)
                .AddWithValue("", txtlname.Text.Trim)
                .AddWithValue("", Format(dtpbday.Value, "yyyy-MM-dd"))
                .AddWithValue("", txlot.Text.Trim)
                .AddWithValue("", txtblk.Text.Trim)
                .AddWithValue("", txtstreet.Text.Trim)
                .AddWithValue("", txtbrgy.Text.Trim)
                .AddWithValue("", cmCity.SelectedValue)
                .AddWithValue("", txtcnum.Text)
                .AddWithValue("", cmbdesignation.SelectedValue)
                .AddWithValue("", cmbdept.SelectedValue)
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose
            Call loaddgv("SELECT * FROM vw_newEmployee ORDER BY lname", dgvEmployee)
            Call cleaner()
            Call toggle(True)
            Me.btnUpdate.Hide()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        loaddgv("SELECT * FROM vw_newEmployee WHERE lname='%" & txtSearch.Text & "%'", Me.dgvEmployee)
    End Sub

    Private Sub dgvEmployee_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployee.CellContentClick

    End Sub

End Class