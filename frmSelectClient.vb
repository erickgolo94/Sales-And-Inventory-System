Imports MySql.Data.MySqlClient
Public Class frmSelectClient
  Private Sub frmSelectClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM tbl_client", dgvclient)
        ' lblNotation.Enabled = True
    End Sub
    Private Sub fetchdataTransRelease(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM tbl_client WHERE clientID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        With frmSales
            .lblCustId.Text = table.Rows(0)(0)
            '.lblCompny.Text = table.Rows(0)(2).ToString
            .txtCustomerName.Text = table.Rows(0)(3).ToString
            ' .lblcnum.Text = table.Rows(0)(6)
        End With
        adapt.Dispose()
    End Sub

    Private Sub dgvClient_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
      
    End Sub

    Private Sub dgvClient_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loaddgv("SELECT * FROM tbl_client WHERE clientCompany LIKE '%" & txtSearch.Text & "%'", dgvclient)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(dgvclient.Tag) = 0 Then
            MsgBox("Select Record!", vbCritical)
        Else
            Call fetchdataTransRelease(Val(dgvclient.Tag))
            Me.Close()
        End If
    End Sub

    Private Sub dgvclient_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclient.CellClick
        If e.RowIndex >= 0 Then
            dgvclient.Tag = dgvclient.Item(0, e.RowIndex).Value
            ' cliendId = dgvclient.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub lblNotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class