Imports MySql.Data.MySqlClient
Public Class frmModifyQuantityReceving
    Private qtyplus As Integer
    Private Sub frmModifyQuantityReceving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getId()
    End Sub

    Private Function getId() As Boolean
        Try

            Dim str As String = "SELECT * FROM tbl_temprawmaterialonhand WHERE rawmaterialonhandID = '" & Me.lblId.Text & "'"
            Dim scmd As New MySqlCommand(str, modcon.con)
            Dim rdr As MySqlDataReader = scmd.ExecuteReader

            If rdr.Read = True Then
                'lbltotalqty.Text = rdr.Item("gtotalqty")
            End If
            scmd.Dispose()
            rdr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return True
    End Function

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'txtChangeQuantity.Text = qtyforchange + 1
        '   Dim o As Integer = 1
        '   Dim hold As Integer
        '  hold = qtyforchange + o
        '  txtChangeQuantity.Text = hold
        Dim btn As Button = sender
        Dim txt As TextBox = CType(Me.Controls("TextBox" & btn.Tag), TextBox)
        Dim count As Integer = Integer.Parse(txtChangeQuantity.Text)
        txtChangeQuantity.Text = +1
    End Sub
 
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        Dim modify, total As Double
        modify = Val(txtChangeQuantity.Text)
        Try
            ' total = modify - Val(lbltotalqty.Text)
            ' MessageBox.Show(total)
            'To update the temporary table quantity rawmateralonhand
            sqlQuery("UPDATE tbl_temprawmaterialonhand SET qty =" & modify & " WHERE rawmaterialonhandID = " & lblId.Text & "")
            'To upadate the maintable of rawmaterialonhand
            sqlQuery("UPDATE tbl_rawmaterialonhand SET qty =" & total & " WHERE rawmaterialonhandID = " & lblId.Text & "")
            loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", frmReceiving.dgvRawMaterialOnhand)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub txtChangeQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChangeQuantity.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case Chr(9)
            Case "."
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            sqlQuery("UPDATE tbl_purchasereqmain SET qty = " & Val(txtChangeQuantity.Text) & " WHERE purchaseID = " & Val(frmReceivingPO.lblModifyQtyid.Text) & "")


            MsgBox("Quantity Updated", vbInformation)
            Call loaddgv("SELECT purchaseID, qty, rawmaterialName, `desc`, catDesc, unitDesc FROM vw_purchasereqmain WHERE purchaseNo like '%" & IDPO & "%' ORDER BY purchaseNo DESC", frmReceivingPO.dgvReqPO)
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class