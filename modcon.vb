Imports MySql.Data.MySqlClient
Module modcon
    Public cmd As MySqlCommand
    Public adapt As MySqlDataAdapter
    Public table As New DataTable
    Public str As String
    Public con As MySqlConnection
    Public salesId As Long
    Public salestotal As Double
    Public updateid As Long ' holds the transaction no of sales for updating
    Public holdsIdForRelease As Long
    Public cliendId As Long
    Public updaterecid As Long
    Public totalSum As Decimal
    Public holdEndID As Long 'This will be hold id from tbl_finished to return the current value
    Public qtyUppdate As Integer 'This also holds the quanty to turning back the real value
    Public finId As Long 'This also hold the id where we are updating
    Public idRemove As Long ' Holds the id for remove item
    Public autoidSales As Long ' hollds the id to update 
    Public OnhandsQty As Long 'Holds quantity for request section
    Public onhandsqtyforendprod As Long 'hold the qty of end product
    Public idUpdateForreceiving As Long ' holds the qty of for selectreceiving raw material
    Public totalRemove As Long 'This only valid on remove the releasing raw material
    'Public removeValDgvReceiving As Long ' This will hold for subtract the remove selected items
    Public removeUpdate As Long 'This will be hold the id for temporarymaterialonhans
    Public idRelease As Long ' This hold the id for deleting requests
    Public autoidwarning As Long 'This hold and warning for empty releasing
    Public holdtotalqty As Double 'This hold the total qty for amount in select sales
    Public Holdvat As Double 'This will hold the VAT for frmSales
    Public holdGrandtotal As Double ' Frmsales
    Public granst As Double
    Public holdnameForReceiviingPo As String
    Public IDPO As Long 'This is for PO
    Public PURCHASEID As Integer
    Public SUPPLIERID As Integer
    Public removePurchaseReq As Integer 'This id  hold to remove the processed record
    Public selectReqNo As Integer
    Public qtyforchange As Integer ' hold void the inventory
    Public idForVoid As Long ' Holds the id
    Public labelUser As String ' This holds the current user label




    Public Sub main()
        Try
            con = New MySqlConnection("SERVER=localhost; USER=root; PASSWORD=; DATABASE=inventorypetromine;")
            con.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try

    End Sub
    Public Sub loaddgv(ByVal str As String, ByVal dgv As DataGridView)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As New DataTable
            adapt = New MySqlDataAdapter(str, con)
            adapt.Fill(table)
            dgv.DataSource = table
            adapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub
    Public Sub loadcmb(ByVal str As String, ByVal cmb As ComboBox, ByVal dmem As String, ByVal vmem As String)
        Try
            Dim adapt As MySqlDataAdapter
            Dim table As DataTable
            adapt = New MySqlDataAdapter(str, con)
            table = New DataTable
            adapt.Fill(table)
            cmb.DataSource = table
            cmb.DisplayMember = dmem
            cmb.ValueMember = vmem
            adapt.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        Finally
            GC.Collect()

        End Try
    End Sub
    Public Sub sqlQuery(ByRef sql As String)

        Try
            modcon.main()
            cmd = New MySqlCommand(sql, modcon.con)
            cmd.ExecuteNonQuery()
            'con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        Finally
            cmd.Dispose()
            GC.Collect()

        End Try

    End Sub
End Module
