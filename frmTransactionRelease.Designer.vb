<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionRelease
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAmountTendered = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.btnFrmTransSave = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.lblAssist = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblcnum = New System.Windows.Forms.Label()
        Me.lblCompny = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSearchClient = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 18)
        Me.Label7.TabIndex = 338
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtAmountTendered)
        Me.Panel2.Controls.Add(Me.txtChange)
        Me.Panel2.Controls.Add(Me.lblClientID)
        Me.Panel2.Controls.Add(Me.lblClientName)
        Me.Panel2.Controls.Add(Me.btnFrmTransSave)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.lblAssist)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.lblcnum)
        Me.Panel2.Controls.Add(Me.lblCompny)
        Me.Panel2.Controls.Add(Me.lblchange)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnSearchClient)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(414, 525)
        Me.Panel2.TabIndex = 20
        '
        'txtAmountTendered
        '
        Me.txtAmountTendered.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtAmountTendered.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountTendered.ForeColor = System.Drawing.SystemColors.Info
        Me.txtAmountTendered.Location = New System.Drawing.Point(188, 297)
        Me.txtAmountTendered.Multiline = True
        Me.txtAmountTendered.Name = "txtAmountTendered"
        Me.txtAmountTendered.Size = New System.Drawing.Size(195, 40)
        Me.txtAmountTendered.TabIndex = 395
        Me.txtAmountTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtChange.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.SystemColors.Info
        Me.txtChange.Location = New System.Drawing.Point(188, 354)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(195, 39)
        Me.txtChange.TabIndex = 394
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientID.Location = New System.Drawing.Point(21, 21)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(0, 18)
        Me.lblClientID.TabIndex = 393
        Me.lblClientID.Visible = False
        '
        'lblClientName
        '
        Me.lblClientName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.Location = New System.Drawing.Point(191, 53)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(192, 26)
        Me.lblClientName.TabIndex = 392
        Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFrmTransSave
        '
        Me.btnFrmTransSave.BackColor = System.Drawing.Color.White
        Me.btnFrmTransSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFrmTransSave.FlatAppearance.BorderSize = 2
        Me.btnFrmTransSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFrmTransSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmTransSave.ForeColor = System.Drawing.Color.Black
        Me.btnFrmTransSave.Location = New System.Drawing.Point(190, 408)
        Me.btnFrmTransSave.Name = "btnFrmTransSave"
        Me.btnFrmTransSave.Size = New System.Drawing.Size(192, 30)
        Me.btnFrmTransSave.TabIndex = 391
        Me.btnFrmTransSave.Text = "&Save"
        Me.btnFrmTransSave.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 308)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 18)
        Me.Label17.TabIndex = 390
        Me.Label17.Text = "Amount Tendered:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTotal.Location = New System.Drawing.Point(189, 238)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(193, 41)
        Me.txtTotal.TabIndex = 389
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAssist
        '
        Me.lblAssist.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssist.Location = New System.Drawing.Point(190, 198)
        Me.lblAssist.Name = "lblAssist"
        Me.lblAssist.Size = New System.Drawing.Size(192, 26)
        Me.lblAssist.TabIndex = 388
        Me.lblAssist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncancel.FlatAppearance.BorderSize = 2
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(190, 448)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(192, 30)
        Me.btncancel.TabIndex = 386
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lblcnum
        '
        Me.lblcnum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcnum.Location = New System.Drawing.Point(190, 149)
        Me.lblcnum.Name = "lblcnum"
        Me.lblcnum.Size = New System.Drawing.Size(192, 26)
        Me.lblcnum.TabIndex = 384
        Me.lblcnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCompny
        '
        Me.lblCompny.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompny.Location = New System.Drawing.Point(190, 91)
        Me.lblCompny.Name = "lblCompny"
        Me.lblCompny.Size = New System.Drawing.Size(192, 48)
        Me.lblCompny.TabIndex = 382
        Me.lblCompny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.Location = New System.Drawing.Point(21, 365)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(62, 18)
        Me.lblchange.TabIndex = 381
        Me.lblchange.Text = "Change:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 380
        Me.Label8.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 379
        Me.Label2.Text = "Assist By:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 378
        Me.Label5.Text = "Contact No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 377
        Me.Label4.Text = "Company:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 18)
        Me.Label6.TabIndex = 375
        Me.Label6.Text = "Client Name:"
        '
        'btnSearchClient
        '
        Me.btnSearchClient.BackColor = System.Drawing.Color.White
        Me.btnSearchClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearchClient.FlatAppearance.BorderSize = 2
        Me.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchClient.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchClient.ForeColor = System.Drawing.Color.Black
        Me.btnSearchClient.Location = New System.Drawing.Point(188, 9)
        Me.btnSearchClient.Name = "btnSearchClient"
        Me.btnSearchClient.Size = New System.Drawing.Size(193, 30)
        Me.btnSearchClient.TabIndex = 374
        Me.btnSearchClient.Text = "&Search Client"
        Me.btnSearchClient.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYMENT DETAILS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 37)
        Me.Panel1.TabIndex = 19
        '
        'frmTransactionRelease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTransactionRelease"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Details"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSearchClient As System.Windows.Forms.Button
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents btnFrmTransSave As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents lblAssist As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lblcnum As System.Windows.Forms.Label
    Friend WithEvents lblCompny As System.Windows.Forms.Label
    Friend WithEvents lblchange As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAmountTendered As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
End Class
