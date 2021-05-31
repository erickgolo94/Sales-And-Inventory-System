Imports MySql.Data.MySqlClient

Public Class frmmain
Public getId As Long
    Private Sub AreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaToolStripMenuItem.Click
        frmArea.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        frmCategory.ShowDialog()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDepartment.ShowDialog()
    End Sub

    Private Sub PositionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PositionToolStripMenuItem.Click
        frmDesignation.ShowDialog()
    End Sub

    Private Sub UnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitToolStripMenuItem.Click
        frmUnit.ShowDialog()
    End Sub

    Private Sub tsmclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmclient.Click
        frmClient.Show()
    End Sub

    Private Sub EmployeesRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesRecordToolStripMenuItem.Click
        frmEmployee.Show()
    End Sub

    Private Sub RawMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RawMaterialToolStripMenuItem.Click
        frmRawMaterials.Show()
    End Sub
    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        frmSupplier.Show()
    End Sub

    Private Sub btnRawMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawMaterial.Click
        frmReceivingPO.Show()
    End Sub

    Private Sub btnRawmaterialStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawmaterialStock.Click
        With frmOnhand
            .txtSearch.Focus()
            .Show()

        End With


    End Sub

    Private Sub btnPurchasedOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPurchasedReq.Show()
    End Sub

    Private Sub btnReqSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReqSup.Click
        With frmRequestForm
            .btnAddList.Enabled = True
            .btnDelete.Enabled = False
            .btnUpdate.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub btnRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelease.Click
        frmReleasing.Show()
    End Sub

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDate.Text = DateString

    End Sub

    Private Sub RawMaterialOnhandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPendingReq.Show()
    End Sub

    Private Sub RequestSuppliesViewingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmRequestReleased.Show()
    End Sub

    Private Sub EndProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEndProd.Show()
    End Sub

    Private Sub PurchaseRequisitionpendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MsgBox("Quit or Change user proceed anyway?(Yes/No)", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Petromine Inventory System") = MsgBoxResult.Yes Then

            trackId()
            sqlQuery("UPDATE tlb_loghis SET logout = NOW() WHERE loghisID =" & getId & "")
            Me.Close()
            frmLogin.Show()
            frmLogin.txtUsername.Text = ""
            frmLogin.txtPassword.Text = ""
            frmLogin.txtUsername.Focus()
            Me.Close()

        End If
    End Sub
    Private Function trackId() As Boolean

        Try
            modcon.main()
            Dim rd As MySqlDataReader

            Dim sql As String = "SELECT loghisID FROM tlb_loghis ORDER BY loghisID DESC"
            Dim cmd = New MySqlCommand(sql, modcon.con)
            rd = cmd.ExecuteReader

            If rd.HasRows Then
                rd.Read()
                getId = rd.Item("loghisID")
            End If
            'con.Close()
            cmd.Dispose()
            rd.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try

            'sqlQuery("SELECT loghisID FROM tlb_loghis ORDER BY loghisID DESC")


            Return True
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTime.Text = TimeOfDay
    End Sub

    Private Sub UserHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserHistoryToolStripMenuItem.Click
        frmUserHistory.Show()
    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSales.Show()
    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        '   Dim msg As String

        If MsgBox("Add New customer for a new transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "PETROMINE SALES AND INVENTORY SYSTEM") = MsgBoxResult.Yes Then
            frmClient.Show()


        Else
            frmSales.Show()
        End If
    End Sub

    Private Sub btnEndProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndProd.Click
        frmEndProd.Show()
    End Sub

    Private Sub ReleasedRawMaterialsViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleasedRawMaterialsViewToolStripMenuItem.Click
        frmReleasedRawmaterialView.Show()
    End Sub

    Private Sub ReceivedRawMaterialsViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceivedRawMaterialsViewToolStripMenuItem.Click
        frmPOReleasingView.Show()
    End Sub

    Private Sub TransactionsViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsViewToolStripMenuItem.Click
        frmTransactionView.Show()
    End Sub

    Private Sub RequestSuppliesViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequestSuppliesViewToolStripMenuItem.Click
        frmReqFormView.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub PurchaseOrderViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderViewToolStripMenuItem.Click
        frmPurchaseOrderView.Show()

    End Sub

    Private Sub UserTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserTypeToolStripMenuItem.Click
        frmUserType.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmPurchasedReq
            .btnAddList.Enabled = True
            .btnUpdate.Enabled = False
            .btnDelete.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub PurchaseOrderViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderViewToolStripMenuItem1.Click
        frmPurchaseOrderViewReport.Show()
    End Sub

    Private Sub CityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityToolStripMenuItem.Click
        frmCity.Show()
    End Sub

    Private Sub RawMaterialDeletionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RawMaterialDeletionToolStripMenuItem.Click
        frmRawmaterialSoft_Deletion.Show()
    End Sub

    Private Sub InventoryHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryHistoryToolStripMenuItem.Click
        frmInventoryDetailsHistory.Show()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReceivingPO.Show()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchaseOrder.Click
        frmPurchasedReq.Show()
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsToolStripMenuItem.Click
        frmAccount.Show()
    End Sub
End Class
