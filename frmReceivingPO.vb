Imports MySql.Data.MySqlClient
Public Class frmReceivingPO
    Protected itemrelease(100) As String
    Protected qty(100) As Double
    Protected materialid(100) As Integer
    Private rawmaterial As Integer
    Private totalrawmaterial As Integer
    Private getsubtotal As Integer
    Private onhandid As Integer

    Private Sub frmReceivingPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  dtpDateReceived.Value = Now.ToString("yyyy-MM-dd")
        dtpDateReceived.Value = Now.ToString("yyyy-MM-dd")
        dtpDateRequested.Value = Now.ToString("yyyy-MM-dd")
        txtTime.Text = TimeOfDay
        txtDate.Text = DateString
        lblReceivedBy.Text = holdnameForReceiviingPo
        tsUSER.Text = labelUser
    End Sub
    Private Sub btnSelectEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectEmployee.Click
        frmSelectPurchaseReq.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSupplierPO.ShowDialog()
    End Sub
    Private Function cleaner() As Boolean
        lbldept.Text = ""
        lblqty.Text = ""
        lblReqNo.Text = ""
        lblremarks.Text = ""
        txtDeliveryReportNo.Text = ""
        lblReqBy.Text = ""
        lblsupplierCom.Text = ""
        lblsupplierName.Text = ""
        Call loaddgv("SELECT qty, rawmaterialName, `desc`, catDesc, unitDesc FROM vw_purchasereqmain WHERE purchaseNo = 0 ORDER BY purchaseNo DESC", dgvReqPO)
        Return True
    End Function
    Private Function ReqRelease(ByVal con As String) As Boolean

        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        adapt = New MySqlDataAdapter("SELECT * FROM tbl_purchasereqmain WHERE purchaseNo = " & con, modcon.con)
        table = New DataTable
        adapt.Fill(table)

        For i As Integer = 0 To table.Rows.Count - 1

            itemrelease(i) = table.Rows(i)(0).ToString
            qty(i) = CInt(table.Rows(i)(8))
            'materialid(0) = CInt(table.Rows(0)(6))
            materialid(i) = CInt(table.Rows(i)(7))
            getsubtotal = CInt(table.Rows(0)(7))

            Dim sql As String = "SELECT SUM(qty) AS qty FROM tbl_rawmaterialonhand WHERE rawmaterialID = " & materialid(i) & ""
            Dim cmd As New MySqlCommand(sql, modcon.con)
            Dim rd As MySqlDataReader = cmd.ExecuteReader


            If rd.Read = True Then

                totalrawmaterial = rd.Item("qty")
                ' MessageBox.Show(qty(i))
                ' MessageBox.Show(totalrawmaterial)
                Dim Gtotal As Long = totalrawmaterial + qty(i)
                ' MessageBox.Show(materialid(i))
                rd.Dispose()


                ' sqlQuery("UPDATE tbl_rawmaterialonhand SET qty = " & Gtotal & " WHERE rawmaterialOnHandID = " & materialid(0) & "")
                sqlQuery("UPDATE tbl_rawmaterialonhand SET qty = " & Gtotal & " WHERE rawmaterialOnHandID = " & materialid(i) & "")
                'MessageBox.Show(Gtotal)
            End If

            'MessageBox.Show(itemrelease(i) & vbNewLine & qty(i).ToString & vbNewLine & materialid(i).ToString)


            rd.Dispose()
        Next
        Return True
    End Function
    Public Function insertionOfReq() As Boolean

        'Dim getRequestNo As Long = lblReqNo.Text
        Try
            modcon.main()
            If MsgBox("Save Transaction?", vbYesNo) = vbYes Then
                ReqRelease(Val(lblReqNo.Text))
                'Dim cmd As New MySqlCommand("INSERT INTO tbl_purchasereqmain purchaseNo,reqBy,dept,remarks,dateRequest,rawmaterialID,qty,is_active SELECT purchaseNo, reqBy, dept, remarks, dateRequest, rawmaterialID, qty, is_active FROM tbl_purchasereq WHERE purchaseNo ='" & getRequestNo & "'", modcon.con)
                cmd = New MySqlCommand("INSERT INTO tbl_purchaseRequestRelease(purchaseID, supplierID, deliverReportNo, deliveryReportDate, receivedBy, dateReceived, rTime) VALUES (?,?,?,?,?,?,?)", modcon.con)

                With cmd.Parameters
                    .AddWithValue("", PURCHASEID)
                    .AddWithValue("", SUPPLIERID)
                    .AddWithValue("", Trim(txtDeliveryReportNo.Text))
                    .AddWithValue("", Format(dtpDeliveryReportDate.Value, "yyyy-MM-dd"))
                    .AddWithValue("", lblReceivedBy.Text.Trim)
                    .AddWithValue("", Format(dtpDateReceived.Value, "yyyy-MM-dd"))
                    .AddWithValue("", Now())
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'MessageBox.Show("Send Request Successfully", "PETROMINE SALES AND INVENTORY")
                'loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_purchasereq", dgvPurchase)
                ' loaddgv("SELECT * FROM vw_purchasereqmain", dgvPurchase)
            End If

            'dgvReqPO.Dispose()
            cleaner()
        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        Finally
            GC.Collect()
        End Try
        Return False
    End Function

    Private Sub btnRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelease.Click
        Try
            If lblReqNo.Text = "" Then
                MsgBox("Receiving cannot be proceed please select atleast one", vbCritical)
            Else
                insertionOfReq()
                sqlQuery("DELETE FROM tbl_purchasereqmain WHERE purchaseNo = " & PURCHASEID & "")
                ' MessageBox.Show(PURCHASEID)
                MessageBox.Show("SUCCESSFULLY RECEIVED", "PETROMINE SALES AND INVENTORY")
                MessageBox.Show("Rawmaterial Updated Quantity", "PETROMINE SALES AND INVENTORY")
            End If
            ' Call loaddgv("SELECT qty, rawmaterialName, `desc`, catDesc, unitDesc FROM vw_purchasereqmain WHERE purchaseNo ORDER BY purchaseNo DESC", dgvReqPO)
            loaddgv("SELECT rawmaterialID,rawmaterialName,`desc`,catDesc,unitDesc,sum(qty) AS qty FROM vw_rawmaterialonhand GROUP BY rawmaterialName,`desc`,catDesc,unitDesc ORDER BY rawmaterialName DESC LIMIT 14", frmselectRawmaterial.dgvRawmaterial)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub



    Private Sub btnfrmreleasecancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrmreleasecancel.Click
        If MsgBox("Are you sure you want to quit?", vbQuestion + vbYesNo) = vbYes Then
            cleaner()
            Me.Close()

        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Val(dgvReqPO.Tag) > 0 Then
            ' MessageBox.Show("Select Record To Moidify The Item,", "PETROMINE SALES AND INVENTORY" +)
            MsgBox("Select Record From list", vbCritical)
        Else
            frmModifyQuantityReceving.txtChangeQuantity.Text = dgvReqPO.CurrentRow.Cells(1).Value
            qtyforchange = dgvReqPO.CurrentRow.Cells(1).Value
            idForVoid = lblModifyQtyid.Text
            frmModifyQuantityReceving.ShowDialog()
        End If
    End Sub

    Private Sub dgvReqPO_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReqPO.CellClick
        lblModifyQtyid.Text = dgvReqPO.CurrentRow.Cells(0).Value

    End Sub

    Private Sub dgvReqPO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReqPO.CellContentClick

    End Sub
End Class