Imports MySql.Data.MySqlClient
Public Class frmInventoryDetailsHistory
    Private getDate As String
    Private Sub frmInventoryDetailsHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Myconfucntion()
        '
        'loaddgv("SELECT rawmaterialOnHandID, transactionNo, requestDate, comSupplier,supplierName,deliveryRepDate,receiveBy,dateReceive,rawmaterialName,desc,catDesc,unitDesc qty FROM  vw_rawmaterialmonitoring ORDER BY rawmaterialonhandID DESC ", dgvInventoryDetails)
        loaddgv("SELECT * FROM vw_rawmaterialmonitoring ORDER BY rawmaterialonhandID DESC", Me.dgvInventoryDetails)

        'loaddgv("SELECT * FROM tbl_rawmaterialmonitoring ORDER BY rawmaterialOnHandID DESC", dgvInventoryDetails)
    End Sub
    Private Sub Myconfucntion()
        Dim Mysqlconn As New MySqlConnection

        MysqlConn = New MySqlConnection
        Mysqlconn.ConnectionString = "SERVER=localhost; USERNAME=root; PASSWORD=; DATABASE=inventorypetromine; Convert Zero Datetime=true;"

        'Inside of try catch lets open database and command Using AND function

        Try
            MysqlConn.Open()
            ' MessageBox.Show("Connection Successfully")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    

    Private Sub btnDateSerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateSerch.Click
        getDate = Format(dtpTo.Value, "MM-dd-yyyy")

        sqlQuery("SELECT * FROM vw_rawmaterialmonitoring WHERE dateReceive LIKE" & getDate & "")
    End Sub
End Class