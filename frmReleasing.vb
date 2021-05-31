Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmReleasing

    Protected itemrelease(100) As String
    Protected qty(100) As Double
    Protected materialid(100) As Integer
    Private rawmaterial As Long
    Private totalrawmaterial As Long
    Private getsubtotal As Long
    Private onhandid As Integer

    Private Function checker() As Boolean
        For Each obj As Object In pnldata.Controls
            If TypeOf obj Is Label Then
                If Len(obj.text) = 0 Then
                    MsgBox("Please select request to release", vbInformation)
                    obj.focus()
                    checker = False
                    Exit Function
                End If
            End If
        Next
        checker = True
    End Function

    Private Sub frmReleasing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call main()
        autoID()
        dtpDateRelease.Value = Now
        txtTime.Text = TimeOfDay
        txtDate.Text = DateString = Format("YYYY-MM-DD")
        tsUSER.Text = labelUser
        'btnRelease.Enabled = True
    End Sub
    Private Sub btnSelectEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectEmployee.Click
        If Val(lblwarning.Text) <= 0 Then
            MsgBox("Request list is Empty!", vbCritical)
            frmSelectRequest.ShowDialog()
        Else
            btnRelease.Enabled = True
            frmSelectRequest.ShowDialog()
        End If

    End Sub

    Private Sub btnSearchEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectEmployee.ShowDialog()
    End Sub


    Private Function RetrieveReleased(ByVal condition As String) As Boolean
        'SET array
        Dim adapt As MySqlDataAdapter
        Dim table As DataTable
        adapt = New MySqlDataAdapter("SELECT * FROM tbl_reqsupplies WHERE reqSupNo = " & condition, modcon.con)
        table = New DataTable
        adapt.Fill(table)

        For i As Integer = 0 To table.Rows.Count - 1

            itemrelease(i) = table.Rows(i)(0).ToString
            qty(i) = CDbl(table.Rows(i)(7))
            'materialid(0) = CInt(table.Rows(0)(6))
            materialid(i) = CInt(table.Rows(i)(6))
            getsubtotal = CInt(table.Rows(0)(6))

            Dim sql As String = "SELECT SUM(qty) AS qty FROM tbl_rawmaterialonhand WHERE rawmaterialID = " & materialid(i) & ""
            Dim cmd As New MySqlCommand(sql, modcon.con)
            Dim rd As MySqlDataReader = cmd.ExecuteReader


            If rd.Read = True Then

                totalrawmaterial = rd.Item("qty")
                ' MessageBox.Show(qty(i))
                'MessageBox.Show(totalrawmaterial)
                Dim Gtotal As Long = totalrawmaterial - qty(i)
                ' MessageBox.Show(materialid(i))
                rd.Dispose()
              

                ' sqlQuery("UPDATE tbl_rawmaterialonhand SET qty = " & Gtotal & " WHERE rawmaterialOnHandID = " & materialid(0) & "")
                sqlQuery("UPDATE tbl_rawmaterialonhand SET qty = " & Gtotal & " WHERE rawmaterialOnHandID = " & materialid(i) & "")
                'MessageBox.Show(Gtotal)
            End If

            'MessageBox.Show(itemrelease(i) & vbNewLine & qty(i).ToString & vbNewLine & materialid(i).ToString)


            rd.Dispose()

            '    Dim cmd1 = New MySqlCommand("SELECT SUM(rawmaterialID) AS getraw FROM tbl_rawmaterialonhand WHERE rawmaterialID=" & getsubtotal & "", modcon.con)
            '  Dim rd1 As MySqlDataReader = cmd1.ExecuteReader


        Next



        'table.Rows()()

        Return True
    End Function

    Private Sub releasing()
        Dim qt As Long = Me.lblReqNo.Text

        Try
            ' cmd = New MySqlCommand("UPDATE tbl_rawmaterialonhand INNER JOIN tbl_reqsupplies ON (tbl_rawmaterialonhand.reqSupNo=tbl_reqsupplies.reqSupNo)SET tbl_rawmaterialonhand.qty = tbl_rawmaterialonhand.qty + tbl_rawmaterialonhand.qty -  tbl_reqsupplies.qty WHERE tbl_reqsupplies.reqSupNo = " & qt, modcon.con)
            'cmd = New MySqlCommand("UPDATE tbl_rawmaterialonhand SET SELECT qty='" & Val(lblqty.Text) & "' - '" & Val(lblqty.Text) & "' FROM tbl_reqsupplies WHERE reqSupNo='" & Val(lblReqNo.Tag) & "'", modcon.con)
            cmd.ExecuteNonQuery()
            Call loaddgv("SELECT deliveryRepNo,rawmaterialName,`desc`,catDesc,unitDesc,sum(qty) as qty FROM vw_rawmaterialonhand group by rawmaterialName,`desc`,catDesc,unitDesc ORDER BY transactionNo DESC", frmOnhand.dgvRawMaterialOnhand)
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub
 
    Private Sub btnRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelease.Click

        Dim cmd1 As New MySqlCommand
        '  If checker() = True Then
        Try

            RetrieveReleased(lblReqNo.Text)

            If dtpDateRequested.Value >= dtpDateRelease.Value Then
                MsgBox("Date Release is invalid", vbCritical, "PETROMINE SALES AND INVEMTORY")
            Else
                '  If dtpDateRelease.Value = Now Then
                modcon.main()
                cmd1 = New MySqlCommand("INSERT INTO tbl_releasing (reqSupNo,releaseBy,deptEmp,dateReleased)VALUES(?,?,?,?)", modcon.con)

                With cmd1.Parameters
                    .AddWithValue("", lblReqNo.Text.Trim)
                    .AddWithValue("", lblrelease.Text.Trim)
                    .AddWithValue("", lblDeptEmp.Text.Trim)
                    .AddWithValue("", Format(dtpDateRelease.Value, "MM-DD-yyyy"))

                End With
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()
                cleaner()
                sqlQuery("DELETE FROM tbl_reqsupplies WHERE reqSupNo = " & idRelease & "")
                sqlQuery("TRUNCATE tbl_temprawmaterialonhand")
                loaddgv("SELECT qty, rawmaterialName,`desc`,catDesc,unitDesc FROM vw_temprawmaterialonhand", Me.dgvReqSup)
                'con.Close()
                ' sqlQuery("DELETE FROM tbl_reqsupplies WHERE  reqSupNo=" & Val(lblReqNo.Text) & "")
                'loaddgv("SELECT DISTINCT reqSupNo,reqBy,dept,remarks,dateRequest,releaseBy,dept,dateReleased FROM vw_releasing ORDER BY reqSupNo", frmViewRealeasedForm.dgvViewRelease)
                ' Me.dgvReqSup.Dispose()

                MsgBox("SUCCESSED")
            End If
            ' End If
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub btnfrmreleasecancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrmreleasecancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", "NOTICE", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cleaner()
            Me.Close()
        End If
    End Sub
    Private Sub cleaner()
        lblReqNo.Text = ""
        lblReqBy.Text = ""
        lbldept.Text = ""
        lblremarks.Text = ""
        'lbldateReq.Text = ""


    End Sub

    Function autoID() As Boolean
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Try
            cmd = New MySqlCommand("SELECT * FROM tbl_reqsupplies ORDER BY reqSupID ASC", modcon.con)
            rd = cmd.ExecuteReader
            If (rd.Read = True) Then
                lblwarning.Text = rd(CInt(0))
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
        Return True
    End Function
End Class
