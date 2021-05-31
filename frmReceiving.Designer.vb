<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiving
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTransNo = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpDateRequest = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvRawMaterialOnhand = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtpDateReceived = New System.Windows.Forms.DateTimePicker()
        Me.lblReceivedBy = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddtolist = New System.Windows.Forms.Button()
        Me.btnSelectEmployee = New System.Windows.Forms.Button()
        Me.lblsupplierCom = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblsupplierName = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDeliveryReportNo = New System.Windows.Forms.TextBox()
        Me.dtpDeliveryReportDate = New System.Windows.Forms.DateTimePicker()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSearchRawMaterial = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUSER = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblRawMaterialOnHandID = New System.Windows.Forms.Label()
        Me.lblrawmaterialID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvRawMaterialOnhand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlData.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECEIVING"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1377, 40)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTransNo)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.dtpDateRequest)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1377, 41)
        Me.Panel2.TabIndex = 16
        '
        'lblTransNo
        '
        Me.lblTransNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNo.Location = New System.Drawing.Point(148, 8)
        Me.lblTransNo.Name = "lblTransNo"
        Me.lblTransNo.Size = New System.Drawing.Size(184, 26)
        Me.lblTransNo.TabIndex = 330
        Me.lblTransNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(1265, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 30)
        Me.btnCancel.TabIndex = 329
        Me.btnCancel.Text = "&Exit"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1153, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 30)
        Me.btnSave.TabIndex = 327
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtpDateRequest
        '
        Me.dtpDateRequest.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateRequest.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateRequest.Location = New System.Drawing.Point(497, 8)
        Me.dtpDateRequest.Name = "dtpDateRequest"
        Me.dtpDateRequest.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateRequest.TabIndex = 324
        Me.dtpDateRequest.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(389, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 18)
        Me.Label7.TabIndex = 323
        Me.Label7.Text = "Request Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 322
        Me.Label5.Text = "Transaction No :"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.pnlData)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1377, 707)
        Me.Panel3.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvRawMaterialOnhand)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(375, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1002, 684)
        Me.Panel5.TabIndex = 16
        '
        'dgvRawMaterialOnhand
        '
        Me.dgvRawMaterialOnhand.AllowUserToAddRows = False
        Me.dgvRawMaterialOnhand.AllowUserToDeleteRows = False
        Me.dgvRawMaterialOnhand.AllowUserToResizeRows = False
        Me.dgvRawMaterialOnhand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRawMaterialOnhand.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRawMaterialOnhand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRawMaterialOnhand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRawMaterialOnhand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column15, Me.Column4, Me.Column5, Me.Column6, Me.Column12, Me.Column13, Me.Column11, Me.Column10, Me.Column7, Me.Column14, Me.Column8, Me.Column9})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRawMaterialOnhand.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRawMaterialOnhand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRawMaterialOnhand.Location = New System.Drawing.Point(0, 0)
        Me.dgvRawMaterialOnhand.MultiSelect = False
        Me.dgvRawMaterialOnhand.Name = "dgvRawMaterialOnhand"
        Me.dgvRawMaterialOnhand.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRawMaterialOnhand.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRawMaterialOnhand.RowHeadersVisible = False
        Me.dgvRawMaterialOnhand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRawMaterialOnhand.Size = New System.Drawing.Size(1002, 684)
        Me.dgvRawMaterialOnhand.TabIndex = 162
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "rawmaterialOnHandID"
        Me.Column1.HeaderText = "rawmaterialOnHandID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "transactionNo"
        Me.Column2.HeaderText = "Transaction No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "requestDate"
        Me.Column3.HeaderText = "Request Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "comSupplier"
        Me.Column15.HeaderText = "Comapany Supplier"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "supplierName"
        Me.Column4.HeaderText = "Supplier's Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "deliveryRepNo"
        Me.Column5.HeaderText = "Delivery Report No"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "deliveryRepDate"
        Me.Column6.HeaderText = "Delivery Report Date"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "receiveBy"
        Me.Column12.HeaderText = "Received By"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "dateReceive"
        Me.Column13.HeaderText = "Date Received"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "rawmaterialID"
        Me.Column11.HeaderText = "rawmaterialID"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "qty"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column10.HeaderText = "Quantity"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.DataPropertyName = "rawmaterialName"
        Me.Column7.HeaderText = "Raw Material Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "desc"
        Me.Column14.HeaderText = "Description"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "catDesc"
        Me.Column8.HeaderText = "Category"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "unitDesc"
        Me.Column9.HeaderText = "Unit"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dtpDateReceived)
        Me.Panel4.Controls.Add(Me.lblReceivedBy)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btnAddtolist)
        Me.Panel4.Controls.Add(Me.btnSelectEmployee)
        Me.Panel4.Controls.Add(Me.lblsupplierCom)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.lbldesc)
        Me.Panel4.Controls.Add(Me.lblsupplierName)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtDeliveryReportNo)
        Me.Panel4.Controls.Add(Me.dtpDeliveryReportDate)
        Me.Panel4.Controls.Add(Me.txtqty)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.btnSearchRawMaterial)
        Me.Panel4.Controls.Add(Me.lblName)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.lblCat)
        Me.Panel4.Controls.Add(Me.lblUnit)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(375, 684)
        Me.Panel4.TabIndex = 15
        '
        'dtpDateReceived
        '
        Me.dtpDateReceived.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateReceived.Enabled = False
        Me.dtpDateReceived.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateReceived.Location = New System.Drawing.Point(165, 271)
        Me.dtpDateReceived.Name = "dtpDateReceived"
        Me.dtpDateReceived.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateReceived.TabIndex = 327
        Me.dtpDateReceived.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'lblReceivedBy
        '
        Me.lblReceivedBy.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivedBy.Location = New System.Drawing.Point(165, 238)
        Me.lblReceivedBy.Name = "lblReceivedBy"
        Me.lblReceivedBy.Size = New System.Drawing.Size(188, 26)
        Me.lblReceivedBy.TabIndex = 326
        Me.lblReceivedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 26)
        Me.Label2.TabIndex = 325
        Me.Label2.Text = "Transaction Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(393, 26)
        Me.Label4.TabIndex = 299
        Me.Label4.Text = "Raw Materials"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddtolist
        '
        Me.btnAddtolist.BackColor = System.Drawing.Color.White
        Me.btnAddtolist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddtolist.FlatAppearance.BorderSize = 2
        Me.btnAddtolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddtolist.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtolist.ForeColor = System.Drawing.Color.Black
        Me.btnAddtolist.Location = New System.Drawing.Point(171, 606)
        Me.btnAddtolist.Name = "btnAddtolist"
        Me.btnAddtolist.Size = New System.Drawing.Size(187, 30)
        Me.btnAddtolist.TabIndex = 323
        Me.btnAddtolist.Text = "Add to List"
        Me.btnAddtolist.UseVisualStyleBackColor = False
        '
        'btnSelectEmployee
        '
        Me.btnSelectEmployee.BackColor = System.Drawing.Color.White
        Me.btnSelectEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelectEmployee.FlatAppearance.BorderSize = 2
        Me.btnSelectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectEmployee.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnSelectEmployee.Location = New System.Drawing.Point(164, 40)
        Me.btnSelectEmployee.Name = "btnSelectEmployee"
        Me.btnSelectEmployee.Size = New System.Drawing.Size(188, 30)
        Me.btnSelectEmployee.TabIndex = 275
        Me.btnSelectEmployee.Text = "Search Suppliers"
        Me.btnSelectEmployee.UseVisualStyleBackColor = False
        '
        'lblsupplierCom
        '
        Me.lblsupplierCom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplierCom.Location = New System.Drawing.Point(164, 90)
        Me.lblsupplierCom.Name = "lblsupplierCom"
        Me.lblsupplierCom.Size = New System.Drawing.Size(188, 26)
        Me.lblsupplierCom.TabIndex = 322
        Me.lblsupplierCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 18)
        Me.Label19.TabIndex = 278
        Me.Label19.Text = "Supplier Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 18)
        Me.Label16.TabIndex = 321
        Me.Label16.Text = "Supplier Company:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 18)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Delivery Report No. :"
        '
        'lbldesc
        '
        Me.lbldesc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(171, 450)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(187, 26)
        Me.lbldesc.TabIndex = 320
        '
        'lblsupplierName
        '
        Me.lblsupplierName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplierName.Location = New System.Drawing.Point(165, 127)
        Me.lblsupplierName.Name = "lblsupplierName"
        Me.lblsupplierName.Size = New System.Drawing.Size(187, 26)
        Me.lblsupplierName.TabIndex = 298
        Me.lblsupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 459)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 18)
        Me.Label15.TabIndex = 319
        Me.Label15.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 18)
        Me.Label6.TabIndex = 300
        Me.Label6.Text = "Delivery Report Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 18)
        Me.Label11.TabIndex = 317
        Me.Label11.Text = "Date Received:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 301
        Me.Label8.Text = "Received By:"
        '
        'txtDeliveryReportNo
        '
        Me.txtDeliveryReportNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliveryReportNo.Location = New System.Drawing.Point(165, 165)
        Me.txtDeliveryReportNo.Name = "txtDeliveryReportNo"
        Me.txtDeliveryReportNo.Size = New System.Drawing.Size(188, 26)
        Me.txtDeliveryReportNo.TabIndex = 303
        '
        'dtpDeliveryReportDate
        '
        Me.dtpDeliveryReportDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDeliveryReportDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeliveryReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeliveryReportDate.Location = New System.Drawing.Point(165, 201)
        Me.dtpDeliveryReportDate.Name = "dtpDeliveryReportDate"
        Me.dtpDeliveryReportDate.Size = New System.Drawing.Size(187, 26)
        Me.dtpDeliveryReportDate.TabIndex = 303
        Me.dtpDeliveryReportDate.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(171, 563)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(187, 26)
        Me.txtqty.TabIndex = 313
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 574)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 312
        Me.Label10.Text = "Quantity:"
        '
        'btnSearchRawMaterial
        '
        Me.btnSearchRawMaterial.BackColor = System.Drawing.Color.White
        Me.btnSearchRawMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearchRawMaterial.FlatAppearance.BorderSize = 2
        Me.btnSearchRawMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRawMaterial.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRawMaterial.ForeColor = System.Drawing.Color.Black
        Me.btnSearchRawMaterial.Location = New System.Drawing.Point(171, 371)
        Me.btnSearchRawMaterial.Name = "btnSearchRawMaterial"
        Me.btnSearchRawMaterial.Size = New System.Drawing.Size(187, 30)
        Me.btnSearchRawMaterial.TabIndex = 305
        Me.btnSearchRawMaterial.Text = "Search Raw Materials"
        Me.btnSearchRawMaterial.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(171, 413)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(187, 26)
        Me.lblName.TabIndex = 311
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 535)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 18)
        Me.Label14.TabIndex = 308
        Me.Label14.Text = "Unit:"
        '
        'lblCat
        '
        Me.lblCat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.Location = New System.Drawing.Point(171, 489)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(187, 26)
        Me.lblCat.TabIndex = 309
        '
        'lblUnit
        '
        Me.lblUnit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(171, 526)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(187, 26)
        Me.lblUnit.TabIndex = 310
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 421)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 18)
        Me.Label9.TabIndex = 306
        Me.Label9.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 498)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 307
        Me.Label13.Text = "Category:"
        '
        'pnlData
        '
        Me.pnlData.Controls.Add(Me.StatusStrip1)
        Me.pnlData.Controls.Add(Me.lblRawMaterialOnHandID)
        Me.pnlData.Controls.Add(Me.lblrawmaterialID)
        Me.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlData.Location = New System.Drawing.Point(0, 684)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(1377, 23)
        Me.pnlData.TabIndex = 14
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsUSER, Me.ToolStripStatusLabel2, Me.txtDate, Me.ToolStripStatusLabel4, Me.txtTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1377, 22)
        Me.StatusStrip1.TabIndex = 317
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
        'lblRawMaterialOnHandID
        '
        Me.lblRawMaterialOnHandID.AutoSize = True
        Me.lblRawMaterialOnHandID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawMaterialOnHandID.Location = New System.Drawing.Point(12, 44)
        Me.lblRawMaterialOnHandID.Name = "lblRawMaterialOnHandID"
        Me.lblRawMaterialOnHandID.Size = New System.Drawing.Size(0, 18)
        Me.lblRawMaterialOnHandID.TabIndex = 316
        '
        'lblrawmaterialID
        '
        Me.lblrawmaterialID.AutoSize = True
        Me.lblrawmaterialID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrawmaterialID.Location = New System.Drawing.Point(12, 350)
        Me.lblrawmaterialID.Name = "lblrawmaterialID"
        Me.lblrawmaterialID.Size = New System.Drawing.Size(0, 18)
        Me.lblrawmaterialID.TabIndex = 315
        Me.lblrawmaterialID.Visible = False
        '
        'frmReceiving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1377, 788)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receiving"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvRawMaterialOnhand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtpDateRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvRawMaterialOnhand As System.Windows.Forms.DataGridView
    Friend WithEvents pnlData As System.Windows.Forms.Panel
    Friend WithEvents lblRawMaterialOnHandID As System.Windows.Forms.Label
    Friend WithEvents lblrawmaterialID As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUSER As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblReceivedBy As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAddtolist As System.Windows.Forms.Button
    Friend WithEvents btnSelectEmployee As System.Windows.Forms.Button
    Friend WithEvents lblsupplierCom As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents lblsupplierName As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryReportNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDeliveryReportDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearchRawMaterial As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDateReceived As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTransNo As System.Windows.Forms.Label
End Class
