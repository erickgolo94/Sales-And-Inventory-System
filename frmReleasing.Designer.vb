<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReleasing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.lblreq = New System.Windows.Forms.Label()
        Me.lblReqNo = New System.Windows.Forms.Label()
        Me.btnRelease = New System.Windows.Forms.Button()
        Me.lblDeptEmp = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblrelease = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbldept = New System.Windows.Forms.Label()
        Me.lblremarks = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUSER = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnfrmreleasecancel = New System.Windows.Forms.Button()
        Me.lblReqBy = New System.Windows.Forms.Label()
        Me.dtpDateRelease = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSelectEmployee = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvReqSup = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pnldata = New System.Windows.Forms.Panel()
        Me.lblwarning = New System.Windows.Forms.Label()
        Me.dtpDateRequested = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvReqSup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnldata.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1380, 40)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1380, 40)
        Me.Panel2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RELEASING"
        '
        'pnl
        '
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl.Location = New System.Drawing.Point(0, 40)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1380, 41)
        Me.pnl.TabIndex = 15
        '
        'lblqty
        '
        Me.lblqty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(12, 38)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(56, 26)
        Me.lblqty.TabIndex = 298
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblreq
        '
        Me.lblreq.AutoSize = True
        Me.lblreq.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreq.Location = New System.Drawing.Point(12, 82)
        Me.lblreq.Name = "lblreq"
        Me.lblreq.Size = New System.Drawing.Size(99, 18)
        Me.lblreq.TabIndex = 276
        Me.lblreq.Text = "Request No:"
        '
        'lblReqNo
        '
        Me.lblReqNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqNo.Location = New System.Drawing.Point(154, 78)
        Me.lblReqNo.Name = "lblReqNo"
        Me.lblReqNo.Size = New System.Drawing.Size(187, 26)
        Me.lblReqNo.TabIndex = 286
        Me.lblReqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRelease
        '
        Me.btnRelease.BackColor = System.Drawing.Color.White
        Me.btnRelease.Enabled = False
        Me.btnRelease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRelease.FlatAppearance.BorderSize = 2
        Me.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelease.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelease.ForeColor = System.Drawing.Color.Black
        Me.btnRelease.Location = New System.Drawing.Point(154, 436)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(187, 30)
        Me.btnRelease.TabIndex = 297
        Me.btnRelease.Text = "Release"
        Me.btnRelease.UseVisualStyleBackColor = False
        '
        'lblDeptEmp
        '
        Me.lblDeptEmp.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptEmp.Location = New System.Drawing.Point(157, 347)
        Me.lblDeptEmp.Name = "lblDeptEmp"
        Me.lblDeptEmp.Size = New System.Drawing.Size(184, 26)
        Me.lblDeptEmp.TabIndex = 295
        Me.lblDeptEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 351)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 18)
        Me.Label13.TabIndex = 294
        Me.Label13.Text = " Department:"
        '
        'lblrelease
        '
        Me.lblrelease.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrelease.Location = New System.Drawing.Point(157, 310)
        Me.lblrelease.Name = "lblrelease"
        Me.lblrelease.Size = New System.Drawing.Size(184, 26)
        Me.lblrelease.TabIndex = 293
        Me.lblrelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 18)
        Me.Label10.TabIndex = 292
        Me.Label10.Text = "Released By:"
        '
        'lbldept
        '
        Me.lbldept.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldept.Location = New System.Drawing.Point(154, 152)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(187, 26)
        Me.lbldept.TabIndex = 288
        Me.lbldept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblremarks
        '
        Me.lblremarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremarks.Location = New System.Drawing.Point(154, 189)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(187, 26)
        Me.lblremarks.TabIndex = 289
        Me.lblremarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.StatusStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 626)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1380, 21)
        Me.Panel3.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsUSER, Me.ToolStripStatusLabel2, Me.txtDate, Me.ToolStripStatusLabel4, Me.txtTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, -1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1380, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "USER:"
        '
        'tsUSER
        '
        Me.tsUSER.AutoSize = False
        Me.tsUSER.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUSER.ForeColor = System.Drawing.Color.White
        Me.tsUSER.Name = "tsUSER"
        Me.tsUSER.Size = New System.Drawing.Size(970, 17)
        Me.tsUSER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel2.Text = "Date :"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = False
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(140, 17)
        Me.txtDate.Text = "                                                       "
        Me.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel4.Text = "Time :"
        '
        'txtTime
        '
        Me.txtTime.AutoSize = False
        Me.txtTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.White
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(120, 17)
        Me.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnfrmreleasecancel
        '
        Me.btnfrmreleasecancel.BackColor = System.Drawing.Color.White
        Me.btnfrmreleasecancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfrmreleasecancel.FlatAppearance.BorderSize = 2
        Me.btnfrmreleasecancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfrmreleasecancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfrmreleasecancel.ForeColor = System.Drawing.Color.Black
        Me.btnfrmreleasecancel.Location = New System.Drawing.Point(154, 478)
        Me.btnfrmreleasecancel.Name = "btnfrmreleasecancel"
        Me.btnfrmreleasecancel.Size = New System.Drawing.Size(187, 30)
        Me.btnfrmreleasecancel.TabIndex = 299
        Me.btnfrmreleasecancel.Text = "Cancel"
        Me.btnfrmreleasecancel.UseVisualStyleBackColor = False
        '
        'lblReqBy
        '
        Me.lblReqBy.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqBy.Location = New System.Drawing.Point(154, 115)
        Me.lblReqBy.Name = "lblReqBy"
        Me.lblReqBy.Size = New System.Drawing.Size(187, 26)
        Me.lblReqBy.TabIndex = 287
        Me.lblReqBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateRelease
        '
        Me.dtpDateRelease.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateRelease.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateRelease.Location = New System.Drawing.Point(154, 385)
        Me.dtpDateRelease.Name = "dtpDateRelease"
        Me.dtpDateRelease.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateRelease.TabIndex = 284
        Me.dtpDateRelease.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(16, 388)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(107, 18)
        Me.Label34.TabIndex = 285
        Me.Label34.Text = "Date Released:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(429, 26)
        Me.Label8.TabIndex = 281
        Me.Label8.Text = "Releasing Details"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 280
        Me.Label7.Text = "Department:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Remarks/Purpose:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 229)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 18)
        Me.Label15.TabIndex = 278
        Me.Label15.Text = "Date Requested:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 18)
        Me.Label11.TabIndex = 277
        Me.Label11.Text = "Requested By:"
        '
        'btnSelectEmployee
        '
        Me.btnSelectEmployee.BackColor = System.Drawing.Color.White
        Me.btnSelectEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelectEmployee.FlatAppearance.BorderSize = 2
        Me.btnSelectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectEmployee.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnSelectEmployee.Location = New System.Drawing.Point(154, 36)
        Me.btnSelectEmployee.Name = "btnSelectEmployee"
        Me.btnSelectEmployee.Size = New System.Drawing.Size(187, 30)
        Me.btnSelectEmployee.TabIndex = 275
        Me.btnSelectEmployee.Text = "Search Request"
        Me.btnSelectEmployee.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 26)
        Me.Label3.TabIndex = 247
        Me.Label3.Text = "Request Details"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvReqSup
        '
        Me.dgvReqSup.AllowUserToAddRows = False
        Me.dgvReqSup.AllowUserToDeleteRows = False
        Me.dgvReqSup.AllowUserToResizeRows = False
        Me.dgvReqSup.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqSup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReqSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReqSup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column12, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReqSup.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReqSup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReqSup.Location = New System.Drawing.Point(0, 0)
        Me.dgvReqSup.MultiSelect = False
        Me.dgvReqSup.Name = "dgvReqSup"
        Me.dgvReqSup.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqSup.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReqSup.RowHeadersVisible = False
        Me.dgvReqSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReqSup.Size = New System.Drawing.Size(1010, 626)
        Me.dgvReqSup.TabIndex = 162
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "reqSupID"
        Me.Column6.HeaderText = "reqSupID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "reqSupNo"
        Me.Column2.HeaderText = "Request No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "reqBy"
        Me.Column1.HeaderText = "Request By"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "dept"
        Me.Column3.HeaderText = "Department"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "remarks"
        Me.Column4.HeaderText = "Remarks"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "dateRequest"
        Me.Column5.HeaderText = "Date Requested"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "rawmaterialID"
        Me.Column12.HeaderText = "rawmaterialID"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.DataPropertyName = "rawmaterialName"
        Me.Column7.HeaderText = "Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "catDesc"
        Me.Column8.HeaderText = "Category"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 120
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "unitDesc"
        Me.Column9.HeaderText = "Unit"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "qty"
        Me.Column10.HeaderText = "Quantity"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "is_active"
        Me.Column11.HeaderText = "is_active"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1380, 626)
        Me.Panel4.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.pnldata)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1380, 626)
        Me.Panel6.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.dgvReqSup)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(370, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1010, 626)
        Me.Panel7.TabIndex = 162
        '
        'pnldata
        '
        Me.pnldata.Controls.Add(Me.lblwarning)
        Me.pnldata.Controls.Add(Me.dtpDateRequested)
        Me.pnldata.Controls.Add(Me.btnfrmreleasecancel)
        Me.pnldata.Controls.Add(Me.btnSelectEmployee)
        Me.pnldata.Controls.Add(Me.lblqty)
        Me.pnldata.Controls.Add(Me.Label3)
        Me.pnldata.Controls.Add(Me.lblreq)
        Me.pnldata.Controls.Add(Me.Label11)
        Me.pnldata.Controls.Add(Me.lblReqNo)
        Me.pnldata.Controls.Add(Me.Label15)
        Me.pnldata.Controls.Add(Me.btnRelease)
        Me.pnldata.Controls.Add(Me.Label5)
        Me.pnldata.Controls.Add(Me.lblDeptEmp)
        Me.pnldata.Controls.Add(Me.Label7)
        Me.pnldata.Controls.Add(Me.Label13)
        Me.pnldata.Controls.Add(Me.Label8)
        Me.pnldata.Controls.Add(Me.lblrelease)
        Me.pnldata.Controls.Add(Me.Label34)
        Me.pnldata.Controls.Add(Me.Label10)
        Me.pnldata.Controls.Add(Me.dtpDateRelease)
        Me.pnldata.Controls.Add(Me.lblReqBy)
        Me.pnldata.Controls.Add(Me.lblremarks)
        Me.pnldata.Controls.Add(Me.lbldept)
        Me.pnldata.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnldata.Location = New System.Drawing.Point(0, 0)
        Me.pnldata.Name = "pnldata"
        Me.pnldata.Size = New System.Drawing.Size(370, 626)
        Me.pnldata.TabIndex = 161
        '
        'lblwarning
        '
        Me.lblwarning.AutoSize = True
        Me.lblwarning.ForeColor = System.Drawing.Color.White
        Me.lblwarning.Location = New System.Drawing.Point(16, 46)
        Me.lblwarning.Name = "lblwarning"
        Me.lblwarning.Size = New System.Drawing.Size(39, 13)
        Me.lblwarning.TabIndex = 301
        Me.lblwarning.Text = "Label2"
        '
        'dtpDateRequested
        '
        Me.dtpDateRequested.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateRequested.Enabled = False
        Me.dtpDateRequested.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRequested.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateRequested.Location = New System.Drawing.Point(154, 223)
        Me.dtpDateRequested.Name = "dtpDateRequested"
        Me.dtpDateRequested.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateRequested.TabIndex = 300
        Me.dtpDateRequested.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 81)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1380, 647)
        Me.Panel5.TabIndex = 16
        '
        'frmReleasing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1380, 728)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReleasing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Releasing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvReqSup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.pnldata.ResumeLayout(False)
        Me.pnldata.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblreq As System.Windows.Forms.Label
    Friend WithEvents lblReqNo As System.Windows.Forms.Label
    Friend WithEvents btnRelease As System.Windows.Forms.Button
    Friend WithEvents lblDeptEmp As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblrelease As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents lblremarks As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblReqBy As System.Windows.Forms.Label
    Friend WithEvents dtpDateRelease As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSelectEmployee As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvReqSup As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnldata As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnfrmreleasecancel As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUSER As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents dtpDateRequested As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblwarning As System.Windows.Forms.Label
End Class
