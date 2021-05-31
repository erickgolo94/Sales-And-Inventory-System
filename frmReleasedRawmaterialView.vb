Imports MySql.Data.MySqlClient
Public Class frmReleasedRawmaterialView

    Private Sub frmReleasedRawmaterialView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        loaddgv("SELECT * FROM vw_releasing", dgvViewRelease)
        '   Call loaddgv("SELECT * FROM vw_releasing GROUP BY reqSupNo,reqBy,dept,remarks,dateRequest,releaseBy,deptEmp,dateReleased ORDER BY reqSupNo", dgvViewRelease)
        dgvViewRelease.ClearSelection()
    End Sub
End Class