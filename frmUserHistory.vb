Imports MySql.Data.MySqlClient
Public Class frmUserHistory
    'Private getLast As Long
    Private Sub frmUserHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddgv("SELECT UserName,logIn,logout,designation,department FROM tlb_loghis ORDER BY loghisID DESC ", dgvUserLoginhistory)
        'dgvUserLoginhistory.SelectedCells.Item(0).Value.Enabled = False
        'dgvUserLoginhistory.ClearSelection()
    End Sub
End Class