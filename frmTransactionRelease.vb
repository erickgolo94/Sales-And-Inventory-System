Imports MySql.Data.MySqlClient
Public Class frmTransactionRelease
    'yung dtp gawin mong date now
    Private Sub frmTransactionRelease_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loadcmb("SELECT * FROM tbl_client", cmbCustomer, "clientName", "clientID")
        'Dropdown()
        ' txtTotal.Text = totalSum
        txtChange.Text = "0.00"
        Change()
    End Sub
    Private Sub Change()
        Dim at, change, total, gtotal As Double

        total = Val(txtTotal.Text)
        at = Val(txtAmountTendered.Text)
        change = Val(txtChange.Text)

        gtotal = at - salestotal

        txtChange.Text = Format(gtotal, "###,##0.00")
    End Sub
    'Private Sub Dropdown()
    'Try
    'Dim adapt As MySqlDataAdapter
    ' Dim table As DataTable
    ' adapt = New MySqlDataAdapter("SELECT * FROM tbl_client", con)
    'table = New DataTable
    'adapt.Fill(table)
    'cmbCustomer.DataSource = table
    'cmbCustomer.DisplayMember = "ClientName"
    ' cmbCustomer.ValueMember = "clientID"
    'lblCompny.Text = cmbCustomer.DisplayMember = "clientCompany"
    'lblPhoneNo.Text = cmbCustomer.DisplayMember = "cnum"
    'lblTelNo.Text = cmbCustomer.DisplayMember = "landline"
    'adapt.Dispose()
    ' Catch ex As MySqlException
    'MessageBox.Show(ex.Message.ToString)
    'Finally
    ' GC.Collect()

    'End Try
    'End Sub

    Private Sub txtChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Change()
    End Sub
    Private Sub cleaner()
        lblAssist.Text = ""
        lblchange.Text = ""
        lblClientName.Text = "'"
        lblCompny.Text = ""
        lblcnum.Text = ""
        txtAmountTendered.Text = ""
        txtChange.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub txtaMountTendered_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Change()
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Close tab?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Me.Close()
        End If
    End Sub

    Private Sub btnFrmTransSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            If MsgBox("Save the transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sqlQuery("UPDATE tbl_maintransaction SET clientID =" & Val(lblClientID.Text) & ", AssistBy ='" & lblAssist.Text & "',Total= " & txtTotal.Text & ", AmuontTendered=" & txtaMountTendered.Text & ",IChange=" & txtChange.Text & ",tDate=NOW(),ttime=NOW() WHERE itemID = " & updateid & "")
                MsgBox("Transaction has been complete", MsgBoxStyle.Information)
                sqlQuery("TRUNCATE tbl_temptransaction")
                cleaner()
                Me.Close()
            Else

            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' Dim adapt As MySqlDataAdapter
            '  Dim table As DataTable
            '  Dim str As String = "SELECT * FROM tbl_client WHERE clientID=" & cmbCustomer.SelectedValue & ""

            '  adapt = New MySqlDataAdapter(str, con)
            '  table = New DataTable
            '  adapt.Fill(table)
            ' lblCompny.TabIndex = table.Rows(0)(1)
            ' lblTelNo.Text = table.Rows(0)(2)
            ' lblPhoneNo.Text = table.Rows(0)(3)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnFrmTransSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchClient.Click
        frmSelectClient.ShowDialog()
    End Sub

    Private Sub btnFrmTransSave_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmTransSave.Click
        Try
            If MsgBox("Save the transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sqlQuery("UPDATE tbl_maintransaction SET clientID =" & cliendId & ", AssistBy ='" & lblAssist.Text & "',Total= " & txtTotal.Text & ", AmuontTendered=" & txtAmountTendered.Text & ",IChange=" & txtChange.Text & ",tDate=NOW(),ttime=NOW() WHERE itemID = " & Val(frmTransactionAdd.lblItemd.Text) & "")
                'sqlQuery("UPDATE tbl_maintransaction SET clientID =" & cliendId & ", AssistBy ='" & lblAssist.Text & "',Total= " & txtTotal.Text & ", AmuontTendered=" & txtAmountTendered.Text & ",IChange=" & txtChange.Text & ",tDate=NOW(),ttime=NOW() WHERE itemID = " & holdsIdForRelease & "")

                MsgBox("Transaction has been complete", MsgBoxStyle.Information)
                sqlQuery("TRUNCATE tbl_temptransaction")
                loaddgv("SELECT * FROM tbl_temptransaction ORDER BY salesID DESC", frmTransaction.dgvTemptransaction)

                Me.Close()
            Else

            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        Change()
    End Sub

  
    Private Sub txtAmountTendered_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountTendered.TextChanged
        Change()
    End Sub

    Private Sub txtChange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChange.TextChanged
        Change()
    End Sub
End Class