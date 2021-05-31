Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReqSuppliesReport
    Dim con As MySqlConnection
    Private Sub frmReportSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Dim table As New DataTable
        'Using con As New MySqlConnection("SERVER=localhost; USER=root; PASSWORD=; DATABASE=inventorypetromine;")
        'con.Open()
        'Dim sqlcommand As New MySqlCommand("SELECT reqSupNo,reqBy,dept,dateRequest,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess ORDER BY reqSupNo", modcon.con)
        Dim adapt As MySqlDataAdapter
        adapt = New MySqlDataAdapter("SELECT * FROM vw_reqsuppliess", modcon.con)
        'table = New DataTable
        adapt.Fill(table)
        'End Using

        With Me.rvReqSupplies.LocalReport
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource)
        End With
        Me.rvReqSupplies.RefreshReport()
    End Sub

    Private Sub rvReqSupplies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rvReqSupplies.Load
       
        Me.rvReqSupplies.RefreshReport()
    End Sub
End Class