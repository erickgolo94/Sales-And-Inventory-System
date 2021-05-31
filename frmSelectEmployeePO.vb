Imports MySql.Data.MySqlClient
Public Class frmSelectEmployeePO

    Private Sub frmSelectEmployeePO_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmPurchasedReq.txtRemarksPO.Focus()
    End Sub

    Private Sub frmSelectEmployeePO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        loaddgv("SELECT empID,CONCAT(fname,' ',mi,' ',lname) AS fullname,deptDesc FROM vw_newEmployee ORDER BY fullname", dgvEmployeePo)
        dgvEmployeePo.ClearSelection()
    End Sub

    Private Sub btnSearchPo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPo.Click
        loaddgv("SELECT CONCAT(fname,' ',mi,' ',lname) AS fullname,deptDesc FROM vw_employee WHERE lname like '%" & Trim(txtSearchPo.Text) & "%' ", dgvEmployeePo)
    End Sub

    Private Sub btnSelectPo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPo.Click
        '  frmPurchasedReq.txtRemarks.Focus()
        If Val(dgvEmployeePo.Tag) < 0 Then
            MsgBox("You must select record!", vbCritical)
        Else
            fetchEMPLOYEE()
            frmPurchasedReq.txtRemarksPO.Focus()
        End If

        Me.Close()
    End Sub

    Private Sub fetchEMPLOYEE()
        frmPurchasedReq.lblReqName.Text = dgvEmployeePo.CurrentRow.Cells(1).Value
        frmPurchasedReq.lblDept.Text = dgvEmployeePo.CurrentRow.Cells(2).Value
    End Sub
End Class