Imports MySql.Data.MySqlClient
Public Class frmRawMaterials
    Dim reader As MySqlDataReader
    Private Sub frmAddRawMaterials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        Call loaddgv("SELECT * FROM vw_rawmaterial WHERE is_active=1 ORDER BY rawmaterialName", dgvRawMaterial)
        Call loadcmb("SELECT * FROM tbl_category order by catDesc LIMIT 5", cmbCat, "catDesc", "catID")
        Call loadcmb("SELECT * FROM tbl_unit ORDER BY unitDesc LIMIT 10", cmbUnit, "unitDesc", "unitID")
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loaddgv("SELECT * FROM vw_rawmaterial WHERE rawmaterialName LIKE '%" & Trim(txtSearch.Text) & "%' ", dgvRawMaterial)
    End Sub
    Private Sub fetchdata(ByVal id As Long)
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        str = "SELECT * FROM vw_rawmaterial WHERE rawmaterialID=" & id
        adapt = New MySqlDataAdapter(str, con)
        table = New DataTable
        adapt.Fill(table)
        txtRawMaterial.Text = table.Rows(0)(1).ToString
        txtDesc.Text = table.Rows(0)(2).ToString
        cmbCat.Text = table.Rows(0)(3).ToString
        cmbUnit.Text = table.Rows(0)(4).ToString
        adapt.Dispose()
    End Sub
    Private Sub dgvRawMaterial_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRawMaterial.CellClick
        If e.ColumnIndex >= 0 Then
            dgvRawMaterial.Tag = dgvRawMaterial.Item(0, e.RowIndex).Value
            Call fetchdata(Val(dgvRawMaterial.Tag))
        End If
    End Sub
    Private Sub toggle(ByVal bool As Boolean)
        btnAdd.Enabled = bool
        btnSave.Enabled = Not bool
        btnCancel.Enabled = Not bool
        btnEdit.Enabled = bool
        btnDelete.Enabled = bool
        pnlData.Enabled = Not bool
    End Sub
    Private Function checker() As Boolean
        For Each obj As Object In pnlData.Controls
            If TypeOf obj Is TextBox Then
                If Len(obj.text) = 0 Then
                    MsgBox("insufficient data", vbInformation)
                    obj.focus()
                    checker = False
                    Exit Function
                End If
            End If
        Next
        checker = True
    End Function
    Private Sub cleaner()
        For Each obj As Object In pnlData.Controls
            If TypeOf obj Is TextBox Then
                obj.clear()
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtRawMaterial.Focus()
        Call toggle(False)
        Call cleaner()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("cancel this record?", vbYesNo + vbQuestion) = vbYes Then
            txtRawMaterial.Focus()
            Call toggle(True)
            Call cleaner()
            btnUpdate.Hide()
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checker() = True Then
            Try
                cmd = New MySqlCommand("SELECT * FROM tbl_rawmaterial WHERE rawmaterialName=?", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtRawMaterial.Text.Trim)
                End With
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Duplicate entry Found!", vbCritical)
                    Call cleaner()
                    txtRawMaterial.Focus()
                    reader.Close()
                Else
                    reader.Close()
                    Dim cmd As MySqlCommand
                    If MsgBox("Save this Record?", vbYesNo + vbQuestion) = vbYes Then
                        cmd = New MySqlCommand("INSERT INTO tbl_rawmaterial (rawmaterialName,`desc`,catID,unitID,is_active) VALUES (?,?,?,?,?)", modcon.con)
                     With cmd.Parameters
                            .AddWithValue("", txtRawMaterial.Text.Trim)
                            .AddWithValue("", txtDesc.Text.Trim)
                            .AddWithValue("", cmbCat.SelectedValue)
                            .AddWithValue("", cmbUnit.SelectedValue)
                            .AddWithValue("", chk_isActive.CheckState)
                        End With
                        cmd.ExecuteNonQuery()
                        Call loaddgv("SELECT * FROM vw_rawmaterial WHERE is_active=1 ORDER BY rawmaterialName", dgvRawMaterial)
                        Call cleaner()
                        Call toggle(True)
                        cmd.Dispose()
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.Collect()
            End Try
        End If

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cmd = New MySqlCommand("SELECT * FROM vw_rawmaterial WHERE rawmaterialName=? ", modcon.con)
            With cmd.Parameters
                .AddWithValue("", txtRawMaterial.Text.Trim)
            End With
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                MsgBox("Duplicate entry Found!", vbCritical)
                txtRawMaterial.Clear()
                txtRawMaterial.Focus()
                reader.Close()
            Else
                reader.Close()
                cmd = New MySqlCommand("UPDATE tbl_rawmaterial  SET rawmaterialName=?,`desc`=?,catID=?,unitID=?  WHERE rawmaterialID='" & Val(dgvRawMaterial.Tag) & "'", modcon.con)
                With cmd.Parameters
                    .AddWithValue("", txtRawMaterial.Text.Trim)
                    .AddWithValue("", txtDesc.Text.Trim)
                    .AddWithValue("", cmbCat.SelectedValue)
                    .AddWithValue("", cmbUnit.SelectedValue)
                End With
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM vw_rawmaterial WHERE is_active=1 ORDER BY rawmaterialName", dgvRawMaterial)
                Call cleaner()
                Call toggle(True)
                Me.btnUpdate.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If Val(dgvRawMaterial.Tag) = 0 Then
                MsgBox("Select a Record!", vbInformation)
            Else
                If MsgBox("Edit this record?", vbYesNo) = vbYes Then
                    Dim cmd As MySqlCommand
                    Dim str As String = "EDIT FROM tbl_rawmaterial WHERE rawmaterialID=" & Val(dgvRawMaterial.Tag)
                    cmd = New MySqlCommand(str, con)
                    txtRawMaterial.Focus()
                    Call toggle(False)
                    btnUpdate.Show()
                    btnSave.Enabled = False
                End If
            End If
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Len(dgvRawMaterial.Tag) = 0 Then
            MsgBox("Select Record!", vbInformation)
        Else
            If MsgBox("Delete this Record?", vbYesNo) = vbYes Then
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("UPDATE tbl_rawmaterial SET is_active=0 WHERE rawmaterialID='" & Val(dgvRawMaterial.Tag) & "' ", modcon.con)
                cmd.Parameters.AddWithValue("", chk_isActive.CheckState)
                cmd.ExecuteNonQuery()
                Call loaddgv("SELECT * FROM vw_rawmaterial WHERE is_active=1 ORDER BY rawmaterialName", dgvRawMaterial)
                Call cleaner()
            End If
        End If
    End Sub

    Private Sub btnAddSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSupplier.tsCrud.Enabled = False
        frmSupplier.ShowDialog()
    End Sub

    
End Class

