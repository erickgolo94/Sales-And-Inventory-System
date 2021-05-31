Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmLogin
    'create public variables instanciated
    Private MysqlConn As MySqlConnection
    Private MySQLCOMMAND As New MySqlCommand
    Public getUser As String
    Public designation As String
    Public department As String
    Public getid As Long


    Private Sub _logFunc()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "SERVER=localhost; USERNAME=root; PASSWORD=; DATABASE=inventorypetromine"

        'Inside of try catch lets open database and command Using AND function

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successfully")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
   

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' If e.KeyCode = Keys.Enter Then btnLogin.PerformClick()
        'if e.keycode = Keys.Escape Then _frmbtnCancel.performClick()

    End Sub

    Private Sub frmLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'If Asc 35 <> andalso = Keys.Enter Then btnLogin.PerformClick()
    End Sub

    Private Sub _frmLogbtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        logInuser()
        '  login()
        trackId()

    End Sub
    Private Function logInuser() As Boolean

        Dim dfault As String = "N/A"
        modcon.main()
        Try


            Dim reader As MySqlDataReader

            'MySQLCOMMAND.CommandText = "SELECT * FROM vw_employee WHERE userName ='" & Replace(txtUsername.Text, "'", "''") & "' AND _passWord='" & Replace(txtPassword.Text, "'", "''") & "'"
            'MySQLCOMMAND.Connection = modcon.con
            '  Dim cmd = New MySqlCommand("SELECT * FROM vw_employee WHERE userName =@username AND _passWord=@password", modcon.con)
            Dim cmd = New MySqlCommand("SELECT * FROM vw_account WHERE UserName =@username AND passKey=@password", modcon.con)

            'con.Open()
            cmd.Parameters.AddWithValue("@username", Trim(txtUsername.Text))
            cmd.Parameters.AddWithValue("@password", Trim(txtPassword.Text))
            reader = cmd.ExecuteReader


            If reader.HasRows Then
                reader.Read()
                'MessageBox.Show("Login Successfully", "Petromine Sales And Inventory")
                'sqlQuery("INSERT INTO tlb_loghis(UserName,logIn,logout,designation,department)VALUES('" & getUser & "',NOW(),NULL,'" & designation & "','" & department & "')")
                'If Asc(e.keychar) = 13 Then
                Me.Hide()
                frmmain.Show()
                'Another Syntax for get username parse into mainform

                labelUser = reader.Item("userDesc")
                frmmain.tsUSER.Text = reader.Item("userDesc")
                frmReceiving.tsUSER.Text = reader.Item("fullname")
                frmReleasing.tsUSER.Text = reader.Item("fullname")
                frmPurchasedReq.tsUSER.Text = reader.Item("fullname")
                frmOnhand.tsUSER.Text = reader.Item("fullname")
                frmReqFormError.tsUSER.Text = reader.Item("fullname")
                frmTransaction.tsUSER.Text = reader.Item("fullname")
                frmReleasing.lblrelease.Text = reader.Item("fullname")
                frmTransactionRelease.lblAssist.Text = reader.Item("fullname")
                frmReleasing.lblDeptEmp.Text = reader.Item("deptDesc")
                frmReceiving.lblReceivedBy.Text = reader.Item("fullname")
                frmSales.lblAssistBy.Text = reader.Item("fullname")
                frmSales.lblEmployeeID.Text = reader.Item("accountID")
                getUser = reader.Item("fullname")
                holdnameForReceiviingPo = reader.Item("fullname")
                designation = reader.Item("designationDesc")
                department = reader.Item("deptDesc")

                'reader.Dispose()
            ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
                MsgBox("Please Enter your USERNAME and PASSWORD", vbCritical, "ERROR")
                txtUsername.Focus()

            ElseIf Len(txtUsername.Text) = 0 Then
                MsgBox("Please Enter your USERNAME.", vbCritical, "ERROR")
                txtUsername.Focus()
            ElseIf Len(txtPassword.Text) = 0 Then
                MsgBox("Please Enter your PASSWORD.", MsgBoxStyle.Critical, "ERROR")
                txtPassword.Focus()
            Else
                MsgBox("Incorrect USERNAME or PASSWORD!", vbCritical, "ERROR")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()

            End If
            'End If
            con.Close()
            If (reader.HasRows = True) Then
                sqlQuery("INSERT INTO tlb_loghis(UserName,logIn,logout,designation,department)VALUES('" & getUser & "',NOW(),NULL,'" & designation & "','" & department & "')")

            ElseIf (reader.HasRows = True) Then
                sqlQuery("UPDATE tlb_loghis SET logout = '" & CStr(dfault.ToString) & "' WHERE loghisID =" & getid & "")

                MessageBox.Show("Not updates")
                '     sqlQuery("UPDATE tlb_loghis SET logout = NOW() WHERE loghisID =" & getid & "")

                reader.Dispose()
            End If


            'Insert function for log-in users purposes
            'sqlQuery("INSERT INTO tlb_loghis(UserName,logIn,logout,designation,department)VALUES('" & getUser & "',NOW(),NULL,'" & designation & "','" & department & "')")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try

            Return True
    End Function

    Private Function trackId() As Boolean
        Dim rdr As MySqlDataReader
        Try
            modcon.main()
            Dim cmd = New MySqlCommand("SELECT loghisID FROM tlb_loghis ORDER BY loghisID DESC", modcon.con)
            'con.Open()
            rdr = cmd.ExecuteReader

            If (rdr.Read = True) Then
                getid = rdr(0)

                rdr.Dispose()
            End If
            'con.Close()
            cmd.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message.ToString)
        End Try

        ' sqlQuery("SELECT loghisID FROM tlb_loghis ORDER BY loghisID DESC")


        Return True
    End Function

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        ' If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
        'e.Handled = True
        ' End If

    End Sub

    
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class