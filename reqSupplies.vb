
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Partial Class purchasereq
    Partial Class vw_reqsuppliesDataTable
        Private Sub vw_reqsuppliesDataTable_vw_reqsuppliesRowChanging(ByVal sender As System.Object, ByVal e As vw_reqsuppliesRowChangeEvent) Handles Me.vw_reqsuppliesRowChanging
            Call main()
            Dim table As DataTable
            Using con As New MySqlConnection("SERVER=localhost; USER=root; PASSWORD=; DATABASE=inventorypetromine;")
                con.Open()
                Dim sqlcommand As New MySqlCommand("SELECT reqSupNo,reqBy,dept,dateRequest,rawmaterialName,`desc`,catDesc,unitDesc,qty FROM vw_reqsuppliess ORDER BY reqSupNo", con)
                Dim adapt As New MySqlDataAdapter(sqlcommand)
                table = New DataTable
                adapt.Fill(table)
            End Using

            With frmReqSuppliesReport.rvReqSupplies.LocalReport
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource)
            End With
        End Sub

    End Class

End Class
