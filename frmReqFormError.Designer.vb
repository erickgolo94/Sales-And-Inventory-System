<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReqFormError
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvReqSup = New System.Windows.Forms.DataGridView()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblrawmaterialID = New System.Windows.Forms.Label()
        Me.chkIs_active = New System.Windows.Forms.CheckBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSelectEmployee = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblReqName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddList = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDateRequest = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchRawMaterial = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ppppp = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUSER = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlReqForm = New System.Windows.Forms.Panel()
        Me.btnFrmReqSendReq = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblReqNo = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvReqSup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlData.SuspendLayout()
        Me.ppppp.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlReqForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1367, 40)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 40)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD REQUEST"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.pnlData)
        Me.Panel4.Controls.Add(Me.ppppp)
        Me.Panel4.Controls.Add(Me.pnlReqForm)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1367, 668)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvReqSup)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(383, 38)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(984, 610)
        Me.Panel5.TabIndex = 163
        '
        'dgvReqSup
        '
        Me.dgvReqSup.AllowUserToAddRows = False
        Me.dgvReqSup.AllowUserToDeleteRows = False
        Me.dgvReqSup.AllowUserToResizeRows = False
        Me.dgvReqSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReqSup.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqSup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReqSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReqSup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqSup.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReqSup.RowHeadersVisible = False
        Me.dgvReqSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReqSup.Size = New System.Drawing.Size(984, 610)
        Me.dgvReqSup.TabIndex = 161
        '
        'pnlData
        '
        Me.pnlData.Controls.Add(Me.Label2)
        Me.pnlData.Controls.Add(Me.lblrawmaterialID)
        Me.pnlData.Controls.Add(Me.chkIs_active)
        Me.pnlData.Controls.Add(Me.lblDesc)
        Me.pnlData.Controls.Add(Me.chkIsActive)
        Me.pnlData.Controls.Add(Me.Label9)
        Me.pnlData.Controls.Add(Me.btnSelectEmployee)
        Me.pnlData.Controls.Add(Me.Label19)
        Me.pnlData.Controls.Add(Me.lblDept)
        Me.pnlData.Controls.Add(Me.Label3)
        Me.pnlData.Controls.Add(Me.lblReqName)
        Me.pnlData.Controls.Add(Me.Label4)
        Me.pnlData.Controls.Add(Me.btnAddList)
        Me.pnlData.Controls.Add(Me.txtRemarks)
        Me.pnlData.Controls.Add(Me.txtqty)
        Me.pnlData.Controls.Add(Me.Label34)
        Me.pnlData.Controls.Add(Me.Label10)
        Me.pnlData.Controls.Add(Me.dtpDateRequest)
        Me.pnlData.Controls.Add(Me.btnSearchRawMaterial)
        Me.pnlData.Controls.Add(Me.Label7)
        Me.pnlData.Controls.Add(Me.lblName)
        Me.pnlData.Controls.Add(Me.Label14)
        Me.pnlData.Controls.Add(Me.lblCat)
        Me.pnlData.Controls.Add(Me.lblUnit)
        Me.pnlData.Controls.Add(Me.Label8)
        Me.pnlData.Controls.Add(Me.Label13)
        Me.pnlData.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlData.Location = New System.Drawing.Point(0, 38)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(383, 610)
        Me.pnlData.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(383, 26)
        Me.Label2.TabIndex = 246
        Me.Label2.Text = "Request Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblrawmaterialID
        '
        Me.lblrawmaterialID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrawmaterialID.Location = New System.Drawing.Point(14, 275)
        Me.lblrawmaterialID.Name = "lblrawmaterialID"
        Me.lblrawmaterialID.Size = New System.Drawing.Size(63, 26)
        Me.lblrawmaterialID.TabIndex = 303
        Me.lblrawmaterialID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkIs_active
        '
        Me.chkIs_active.AutoSize = True
        Me.chkIs_active.Checked = True
        Me.chkIs_active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIs_active.Location = New System.Drawing.Point(11, 45)
        Me.chkIs_active.Name = "chkIs_active"
        Me.chkIs_active.Size = New System.Drawing.Size(68, 18)
        Me.chkIs_active.TabIndex = 300
        Me.chkIs_active.Text = "is_active"
        Me.chkIs_active.UseVisualStyleBackColor = True
        Me.chkIs_active.Visible = False
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(177, 353)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(187, 26)
        Me.lblDesc.TabIndex = 302
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Checked = True
        Me.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsActive.Location = New System.Drawing.Point(9, 515)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(69, 18)
        Me.chkIsActive.TabIndex = 263
        Me.chkIsActive.Text = "Is_Active"
        Me.chkIsActive.UseVisualStyleBackColor = True
        Me.chkIsActive.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 18)
        Me.Label9.TabIndex = 301
        Me.Label9.Text = "Description:"
        '
        'btnSelectEmployee
        '
        Me.btnSelectEmployee.BackColor = System.Drawing.Color.White
        Me.btnSelectEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelectEmployee.FlatAppearance.BorderSize = 2
        Me.btnSelectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectEmployee.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnSelectEmployee.Location = New System.Drawing.Point(177, 45)
        Me.btnSelectEmployee.Name = "btnSelectEmployee"
        Me.btnSelectEmployee.Size = New System.Drawing.Size(187, 30)
        Me.btnSelectEmployee.TabIndex = 274
        Me.btnSelectEmployee.Text = "Add Requester"
        Me.btnSelectEmployee.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 18)
        Me.Label19.TabIndex = 277
        Me.Label19.Text = "Requester's Name:"
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(177, 125)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(187, 26)
        Me.lblDept.TabIndex = 298
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 278
        Me.Label3.Text = "Department:"
        '
        'lblReqName
        '
        Me.lblReqName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqName.Location = New System.Drawing.Point(177, 91)
        Me.lblReqName.Name = "lblReqName"
        Me.lblReqName.Size = New System.Drawing.Size(187, 26)
        Me.lblReqName.TabIndex = 297
        Me.lblReqName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 18)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "Remarks/Purpose:"
        '
        'btnAddList
        '
        Me.btnAddList.BackColor = System.Drawing.Color.White
        Me.btnAddList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddList.FlatAppearance.BorderSize = 2
        Me.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddList.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList.ForeColor = System.Drawing.Color.Black
        Me.btnAddList.Location = New System.Drawing.Point(177, 506)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(187, 30)
        Me.btnAddList.TabIndex = 296
        Me.btnAddList.Text = "Add to List"
        Me.btnAddList.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(177, 160)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(187, 26)
        Me.txtRemarks.TabIndex = 283
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(177, 463)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(187, 26)
        Me.txtqty.TabIndex = 295
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 196)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(102, 18)
        Me.Label34.TabIndex = 284
        Me.Label34.Text = "Request Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 466)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 294
        Me.Label10.Text = "Quantity:"
        '
        'dtpDateRequest
        '
        Me.dtpDateRequest.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateRequest.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateRequest.Location = New System.Drawing.Point(177, 194)
        Me.dtpDateRequest.Name = "dtpDateRequest"
        Me.dtpDateRequest.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateRequest.TabIndex = 285
        Me.dtpDateRequest.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'btnSearchRawMaterial
        '
        Me.btnSearchRawMaterial.BackColor = System.Drawing.Color.White
        Me.btnSearchRawMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearchRawMaterial.FlatAppearance.BorderSize = 2
        Me.btnSearchRawMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRawMaterial.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRawMaterial.ForeColor = System.Drawing.Color.Black
        Me.btnSearchRawMaterial.Location = New System.Drawing.Point(177, 275)
        Me.btnSearchRawMaterial.Name = "btnSearchRawMaterial"
        Me.btnSearchRawMaterial.Size = New System.Drawing.Size(187, 30)
        Me.btnSearchRawMaterial.TabIndex = 293
        Me.btnSearchRawMaterial.Text = "Search Raw Materials"
        Me.btnSearchRawMaterial.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(2, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(383, 26)
        Me.Label7.TabIndex = 286
        Me.Label7.Text = "Raw Materials to be Requested"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(177, 316)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(187, 26)
        Me.lblName.TabIndex = 292
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 431)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 18)
        Me.Label14.TabIndex = 289
        Me.Label14.Text = "Unit:"
        '
        'lblCat
        '
        Me.lblCat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.Location = New System.Drawing.Point(177, 390)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(187, 26)
        Me.lblCat.TabIndex = 290
        Me.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnit
        '
        Me.lblUnit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(177, 427)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(187, 26)
        Me.lblUnit.TabIndex = 291
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 287
        Me.Label8.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 394)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 288
        Me.Label13.Text = "Category:"
        '
        'ppppp
        '
        Me.ppppp.Controls.Add(Me.StatusStrip1)
        Me.ppppp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ppppp.ForeColor = System.Drawing.Color.Black
        Me.ppppp.Location = New System.Drawing.Point(0, 648)
        Me.ppppp.Name = "ppppp"
        Me.ppppp.Size = New System.Drawing.Size(1367, 20)
        Me.ppppp.TabIndex = 160
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsUSER, Me.ToolStripStatusLabel2, Me.txtDate, Me.ToolStripStatusLabel4, Me.txtTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, -2)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1367, 22)
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
        'pnlReqForm
        '
        Me.pnlReqForm.Controls.Add(Me.btnFrmReqSendReq)
        Me.pnlReqForm.Controls.Add(Me.btnDelete)
        Me.pnlReqForm.Controls.Add(Me.lblReqNo)
        Me.pnlReqForm.Controls.Add(Me.btnUpdate)
        Me.pnlReqForm.Controls.Add(Me.Label5)
        Me.pnlReqForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReqForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlReqForm.Name = "pnlReqForm"
        Me.pnlReqForm.Size = New System.Drawing.Size(1367, 38)
        Me.pnlReqForm.TabIndex = 0
        '
        'btnFrmReqSendReq
        '
        Me.btnFrmReqSendReq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrmReqSendReq.BackColor = System.Drawing.Color.White
        Me.btnFrmReqSendReq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFrmReqSendReq.FlatAppearance.BorderSize = 2
        Me.btnFrmReqSendReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFrmReqSendReq.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmReqSendReq.ForeColor = System.Drawing.Color.Black
        Me.btnFrmReqSendReq.Location = New System.Drawing.Point(1252, 4)
        Me.btnFrmReqSendReq.Name = "btnFrmReqSendReq"
        Me.btnFrmReqSendReq.Size = New System.Drawing.Size(103, 30)
        Me.btnFrmReqSendReq.TabIndex = 304
        Me.btnFrmReqSendReq.Text = "&Save"
        Me.btnFrmReqSendReq.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(1143, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 30)
        Me.btnDelete.TabIndex = 303
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblReqNo
        '
        Me.lblReqNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqNo.Location = New System.Drawing.Point(175, 6)
        Me.lblReqNo.Name = "lblReqNo"
        Me.lblReqNo.Size = New System.Drawing.Size(187, 26)
        Me.lblReqNo.TabIndex = 302
        Me.lblReqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 2
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(1034, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 30)
        Me.btnUpdate.TabIndex = 301
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 245
        Me.Label5.Text = "Request No:"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "reqSupID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "qty"
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "rawmaterialName"
        Me.Column3.HeaderText = "Rawmaterial Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "desc"
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "catDesc"
        Me.Column5.HeaderText = "Category"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "unitDesc"
        Me.Column6.HeaderText = "Unit"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'frmReqForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1367, 708)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReqForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvReqSup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.ppppp.ResumeLayout(False)
        Me.ppppp.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlReqForm.ResumeLayout(False)
        Me.pnlReqForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ppppp As System.Windows.Forms.Panel
    Friend WithEvents lblrawmaterialID As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkIs_active As System.Windows.Forms.CheckBox
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents lblReqName As System.Windows.Forms.Label
    Friend WithEvents btnAddList As System.Windows.Forms.Button
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearchRawMaterial As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDateRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnSelectEmployee As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkIsActive As System.Windows.Forms.CheckBox
    Friend WithEvents pnlReqForm As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblReqNo As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFrmReqSendReq As System.Windows.Forms.Button
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUSER As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgvReqSup As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
