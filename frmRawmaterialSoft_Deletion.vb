Imports MySql.Data.MySqlClient
Public Class frmRawmaterialSoft_Deletion
    Private Sub frmRawmaterialSoft_Deletion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM vw_rawmaterial WHERE is_active=0 ORDER BY rawmaterialName", dgvRawMaterial)
    End Sub

    Private Sub dgvRawMaterial_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRawMaterial.CellClick
        If e.RowIndex >= 0 Then
            dgvRawMaterial.Tag = dgvRawMaterial.Item(0, e.RowIndex).Value
        End If
    End Sub

    Private Sub btnRetreive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetreive.Click
        If Val(dgvRawMaterial.Tag) = 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Retreive this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("UPDATE tbl_rawmaterial SET is_active=1 WHERE rawmaterialID='" & Val(dgvRawMaterial.Tag) & "' ", modcon.con)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM vw_rawmaterial WHERE is_active=0 ORDER BY rawmaterialName", dgvRawMaterial)
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call loaddgv("SELECT * FROM vw_rawmaterial WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%' ", dgvRawMaterial)
    End Sub
End Class