Imports MySql.Data.MySqlClient
Public Class frmSelectEmployee
    Private Sub frmSelectEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        loaddgv("SELECT empID,CONCAT(fname,' ',mi,' ',lname) AS fullname,deptDesc FROM vw_newEmployee ORDER BY fullname", dgvEmployee)
        dgvEmployee.ClearSelection()
    End Sub
    Private Sub fetchdataAddReqForm(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT empID,CONCAT(fname,' ',mi,' ',lname) AS fullname,deptDesc FROM vw_newEmployee WHERE empID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmRequestForm
            .lblReqName.Text = table.Rows(0)(1)
            .lblDept.Text = table.Rows(0)(2)
        End With

    End Sub
    Private Sub fetchdataPurchase(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT empID,CONCAT(fname,' ',mi,' ',lname) AS fullname,deptDesc FROM vw_employee WHERE empID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmPurchasedReq
            .lblReqName.Text = table.Rows(0)(1)
            .lblDept.Text = table.Rows(0)(2)
        End With

    End Sub
    Private Sub fetchdataReleasEmp(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT empID,CONCAT(fname,' ',mi,' ',lname) AS fullname,deptDesc FROM vw_employee WHERE empID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmReleasing
            .lblrelease.Text = table.Rows(0)(1)
            .lblDeptEmp.Text = table.Rows(0)(2)
        End With
        adapt.Dispose()
    End Sub

    Private Sub dgvEmployee_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmployee.CellClick
        If e.RowIndex >= 0 Then
            dgvEmployee.Tag = dgvEmployee.Item(0, e.RowIndex).Value



        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loaddgv("SELECT CONCAT(fname,' ',mi,' ',lname) AS fullname,deptDesc FROM vw_employee WHERE lname like '%" & Trim(txtSearch.Text) & "%' ", dgvEmployee)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        frmRequestForm.lblReqName.Text = dgvEmployee.CurrentRow.Cells(1).Value
        frmRequestForm.lblDept.Text = dgvEmployee.CurrentRow.Cells(2).Value
        frmRequestForm.txtRemarks.Focus()
        Me.Close()

        'AddReqForm
        '   If Len(dgvEmployee.Tag) >= 0 Then
        '   Call fetchdataAddReqForm(Val(dgvEmployee.Tag))
        '   Me.Close()
        '  End If
        '
        'Purchase
        ' If Len(dgvEmployee.Tag) >= 0 Then
        'Call fetchdataPurchase(Val(dgvEmployee.Tag))
        ' Me.Close()
        ' End If

        'frmRelease
        '  If Len(dgvEmployee.Tag) >= 0 Then
        'Call fetchdataReleasEmp(Val(dgvEmployee.Tag))

        frmRequestForm.txtRemarks.Focus()
        '  Me.Close()
        '  End If
    End Sub
End Class