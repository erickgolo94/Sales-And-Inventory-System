<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblReqNo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUSER = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.btnAddList = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblRawmaterialName = New System.Windows.Forms.Label()
        Me.lblRawMaterialID = New System.Windows.Forms.Label()
        Me.btnSearchRawMaterial = New System.Windows.Forms.Button()
        Me.chk_active = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDateRequest = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblReqName = New System.Windows.Forms.Label()
        Me.btnSelectEmployee = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvReqSupp = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlData.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvReqSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1380, 40)
        Me.Panel2.TabIndex = 11
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.lblReqNo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1380, 38)
        Me.Panel1.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1265, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 30)
        Me.btnSave.TabIndex = 354
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(1156, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 30)
        Me.btnDelete.TabIndex = 353
        Me.btnDelete.Text = "&Remove"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 2
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(1047, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 30)
        Me.btnUpdate.TabIndex = 352
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'lblReqNo
        '
        Me.lblReqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqNo.Location = New System.Drawing.Point(179, 6)
        Me.lblReqNo.Name = "lblReqNo"
        Me.lblReqNo.Size = New System.Drawing.Size(187, 26)
        Me.lblReqNo.TabIndex = 346
        Me.lblReqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 302
        Me.Label5.Text = "Request No:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.StatusStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 736)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1380, 23)
        Me.Panel3.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsUSER, Me.ToolStripStatusLabel2, Me.txtDate, Me.ToolStripStatusLabel4, Me.txtTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1380, 22)
        Me.StatusStrip1.TabIndex = 11
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
        'pnlData
        '
        Me.pnlData.Controls.Add(Me.btnAddList)
        Me.pnlData.Controls.Add(Me.txtQty)
        Me.pnlData.Controls.Add(Me.lblUnit)
        Me.pnlData.Controls.Add(Me.Label17)
        Me.pnlData.Controls.Add(Me.lblCat)
        Me.pnlData.Controls.Add(Me.lblDesc)
        Me.pnlData.Controls.Add(Me.lblRawmaterialName)
        Me.pnlData.Controls.Add(Me.lblRawMaterialID)
        Me.pnlData.Controls.Add(Me.btnSearchRawMaterial)
        Me.pnlData.Controls.Add(Me.chk_active)
        Me.pnlData.Controls.Add(Me.Label11)
        Me.pnlData.Controls.Add(Me.dtpDateRequest)
        Me.pnlData.Controls.Add(Me.txtRemarks)
        Me.pnlData.Controls.Add(Me.lblDept)
        Me.pnlData.Controls.Add(Me.lblReqName)
        Me.pnlData.Controls.Add(Me.btnSelectEmployee)
        Me.pnlData.Controls.Add(Me.Label2)
        Me.pnlData.Controls.Add(Me.Label9)
        Me.pnlData.Controls.Add(Me.Label19)
        Me.pnlData.Controls.Add(Me.Label3)
        Me.pnlData.Controls.Add(Me.Label4)
        Me.pnlData.Controls.Add(Me.Label34)
        Me.pnlData.Controls.Add(Me.Label10)
        Me.pnlData.Controls.Add(Me.Label14)
        Me.pnlData.Controls.Add(Me.Label8)
        Me.pnlData.Controls.Add(Me.Label13)
        Me.pnlData.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlData.Location = New System.Drawing.Point(0, 78)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(383, 658)
        Me.pnlData.TabIndex = 14
        '
        'btnAddList
        '
        Me.btnAddList.BackColor = System.Drawing.Color.White
        Me.btnAddList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddList.FlatAppearance.BorderSize = 2
        Me.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddList.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList.ForeColor = System.Drawing.Color.Black
        Me.btnAddList.Location = New System.Drawing.Point(179, 528)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(187, 30)
        Me.btnAddList.TabIndex = 351
        Me.btnAddList.Text = "Add to list"
        Me.btnAddList.UseVisualStyleBackColor = False
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(179, 483)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(187, 26)
        Me.txtQty.TabIndex = 350
        '
        'lblUnit
        '
        Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(179, 447)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(187, 26)
        Me.lblUnit.TabIndex = 349
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(179, 443)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(187, 26)
        Me.Label17.TabIndex = 348
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCat
        '
        Me.lblCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.Location = New System.Drawing.Point(179, 410)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(187, 26)
        Me.lblCat.TabIndex = 347
        Me.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(179, 373)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(187, 26)
        Me.lblDesc.TabIndex = 346
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRawmaterialName
        '
        Me.lblRawmaterialName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawmaterialName.Location = New System.Drawing.Point(179, 336)
        Me.lblRawmaterialName.Name = "lblRawmaterialName"
        Me.lblRawmaterialName.Size = New System.Drawing.Size(187, 26)
        Me.lblRawmaterialName.TabIndex = 345
        Me.lblRawmaterialName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRawMaterialID
        '
        Me.lblRawMaterialID.AutoSize = True
        Me.lblRawMaterialID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawMaterialID.ForeColor = System.Drawing.Color.White
        Me.lblRawMaterialID.Location = New System.Drawing.Point(12, 289)
        Me.lblRawMaterialID.Name = "lblRawMaterialID"
        Me.lblRawMaterialID.Size = New System.Drawing.Size(63, 18)
        Me.lblRawMaterialID.TabIndex = 344
        Me.lblRawMaterialID.Text = "lblRawID"
        '
        'btnSearchRawMaterial
        '
        Me.btnSearchRawMaterial.BackColor = System.Drawing.Color.White
        Me.btnSearchRawMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearchRawMaterial.FlatAppearance.BorderSize = 2
        Me.btnSearchRawMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRawMaterial.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRawMaterial.ForeColor = System.Drawing.Color.Black
        Me.btnSearchRawMaterial.Location = New System.Drawing.Point(179, 277)
        Me.btnSearchRawMaterial.Name = "btnSearchRawMaterial"
        Me.btnSearchRawMaterial.Size = New System.Drawing.Size(187, 30)
        Me.btnSearchRawMaterial.TabIndex = 343
        Me.btnSearchRawMaterial.Text = "Search Raw Materials"
        Me.btnSearchRawMaterial.UseVisualStyleBackColor = False
        '
        'chk_active
        '
        Me.chk_active.AutoSize = True
        Me.chk_active.Checked = True
        Me.chk_active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_active.Location = New System.Drawing.Point(13, 38)
        Me.chk_active.Name = "chk_active"
        Me.chk_active.Size = New System.Drawing.Size(68, 17)
        Me.chk_active.TabIndex = 336
        Me.chk_active.Text = "is_active"
        Me.chk_active.UseVisualStyleBackColor = True
        Me.chk_active.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(383, 26)
        Me.Label11.TabIndex = 337
        Me.Label11.Text = "Raw Materials to be Requested"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateRequest
        '
        Me.dtpDateRequest.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateRequest.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateRequest.Location = New System.Drawing.Point(179, 192)
        Me.dtpDateRequest.Name = "dtpDateRequest"
        Me.dtpDateRequest.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateRequest.TabIndex = 333
        Me.dtpDateRequest.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'txtRemarks
        '
        Me.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(179, 158)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(187, 26)
        Me.txtRemarks.TabIndex = 331
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(179, 120)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(187, 26)
        Me.lblDept.TabIndex = 329
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReqName
        '
        Me.lblReqName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqName.Location = New System.Drawing.Point(179, 86)
        Me.lblReqName.Name = "lblReqName"
        Me.lblReqName.Size = New System.Drawing.Size(187, 26)
        Me.lblReqName.TabIndex = 328
        Me.lblReqName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSelectEmployee
        '
        Me.btnSelectEmployee.BackColor = System.Drawing.Color.White
        Me.btnSelectEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelectEmployee.FlatAppearance.BorderSize = 2
        Me.btnSelectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectEmployee.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnSelectEmployee.Location = New System.Drawing.Point(179, 38)
        Me.btnSelectEmployee.Name = "btnSelectEmployee"
        Me.btnSelectEmployee.Size = New System.Drawing.Size(187, 30)
        Me.btnSelectEmployee.TabIndex = 327
        Me.btnSelectEmployee.Text = "Add Requestor"
        Me.btnSelectEmployee.UseVisualStyleBackColor = False
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
        Me.Label2.TabIndex = 312
        Me.Label2.Text = "Request Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 18)
        Me.Label9.TabIndex = 311
        Me.Label9.Text = "Description:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 18)
        Me.Label19.TabIndex = 303
        Me.Label19.Text = "Requester's Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 304
        Me.Label3.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 18)
        Me.Label4.TabIndex = 305
        Me.Label4.Text = "Remarks/Purpose:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(12, 192)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(102, 18)
        Me.Label34.TabIndex = 306
        Me.Label34.Text = "Request Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 486)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 310
        Me.Label10.Text = "Quantity:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 451)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 18)
        Me.Label14.TabIndex = 309
        Me.Label14.Text = "Unit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 307
        Me.Label8.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 414)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 308
        Me.Label13.Text = "Category:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvReqSupp)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(383, 78)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(997, 658)
        Me.Panel5.TabIndex = 15
        '
        'dgvReqSupp
        '
        Me.dgvReqSupp.AllowUserToAddRows = False
        Me.dgvReqSupp.AllowUserToDeleteRows = False
        Me.dgvReqSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReqSupp.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqSupp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReqSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReqSupp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReqSupp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReqSupp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReqSupp.Location = New System.Drawing.Point(0, 0)
        Me.dgvReqSupp.Name = "dgvReqSupp"
        Me.dgvReqSupp.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqSupp.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReqSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReqSupp.Size = New System.Drawing.Size(997, 658)
        Me.dgvReqSupp.TabIndex = 0
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
        'frmRequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1380, 759)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRequestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRequestFormNEWNEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvReqSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUSER As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelectEmployee As System.Windows.Forms.Button
    Friend WithEvents lblReqName As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_active As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSearchRawMaterial As System.Windows.Forms.Button
    Friend WithEvents lblRawMaterialID As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblRawmaterialName As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents btnAddList As System.Windows.Forms.Button
    Friend WithEvents lblReqNo As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvReqSupp As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
