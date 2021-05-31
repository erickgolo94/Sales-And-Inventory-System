<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivingPO
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.lblModifyQtyid = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUSER = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnldata = New System.Windows.Forms.Panel()
        Me.dtpDateReceived = New System.Windows.Forms.DateTimePicker()
        Me.lblReceivedBy = New System.Windows.Forms.Label()
        Me.lblsupplierCom = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblsupplierName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDeliveryReportNo = New System.Windows.Forms.TextBox()
        Me.dtpDeliveryReportDate = New System.Windows.Forms.DateTimePicker()
        Me.lblwarning = New System.Windows.Forms.Label()
        Me.dtpDateRequested = New System.Windows.Forms.DateTimePicker()
        Me.btnfrmreleasecancel = New System.Windows.Forms.Button()
        Me.btnSelectEmployee = New System.Windows.Forms.Button()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblreq = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblReqNo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRelease = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblReqBy = New System.Windows.Forms.Label()
        Me.lblremarks = New System.Windows.Forms.Label()
        Me.lbldept = New System.Windows.Forms.Label()
        Me.dgvReqPO = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnldata.SuspendLayout()
        CType(Me.dgvReqPO, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECEIVING PURCHASE REQUEST"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.lblModifyQtyid)
        Me.pnl.Controls.Add(Me.btnSave)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl.Location = New System.Drawing.Point(0, 40)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1380, 41)
        Me.pnl.TabIndex = 16
        '
        'lblModifyQtyid
        '
        Me.lblModifyQtyid.AutoSize = True
        Me.lblModifyQtyid.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModifyQtyid.ForeColor = System.Drawing.Color.White
        Me.lblModifyQtyid.Location = New System.Drawing.Point(382, 6)
        Me.lblModifyQtyid.Name = "lblModifyQtyid"
        Me.lblModifyQtyid.Size = New System.Drawing.Size(16, 18)
        Me.lblModifyQtyid.TabIndex = 334
        Me.lblModifyQtyid.Text = "*"
        '
        'btnSave
        '
        Me.btnSave.AccessibleDescription = "s"
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1211, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 30)
        Me.btnSave.TabIndex = 311
        Me.btnSave.Text = "&Update Quantity"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.StatusStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 738)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1380, 21)
        Me.Panel3.TabIndex = 17
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
        'pnldata
        '
        Me.pnldata.Controls.Add(Me.dtpDateReceived)
        Me.pnldata.Controls.Add(Me.lblReceivedBy)
        Me.pnldata.Controls.Add(Me.lblsupplierCom)
        Me.pnldata.Controls.Add(Me.Label19)
        Me.pnldata.Controls.Add(Me.Label16)
        Me.pnldata.Controls.Add(Me.Label2)
        Me.pnldata.Controls.Add(Me.lblsupplierName)
        Me.pnldata.Controls.Add(Me.Label6)
        Me.pnldata.Controls.Add(Me.Label4)
        Me.pnldata.Controls.Add(Me.Label9)
        Me.pnldata.Controls.Add(Me.txtDeliveryReportNo)
        Me.pnldata.Controls.Add(Me.dtpDeliveryReportDate)
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
        Me.pnldata.Controls.Add(Me.Label7)
        Me.pnldata.Controls.Add(Me.Label8)
        Me.pnldata.Controls.Add(Me.lblReqBy)
        Me.pnldata.Controls.Add(Me.lblremarks)
        Me.pnldata.Controls.Add(Me.lbldept)
        Me.pnldata.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnldata.Location = New System.Drawing.Point(0, 81)
        Me.pnldata.Name = "pnldata"
        Me.pnldata.Size = New System.Drawing.Size(370, 657)
        Me.pnldata.TabIndex = 162
        '
        'dtpDateReceived
        '
        Me.dtpDateReceived.CustomFormat = "yyyy-MM-dd"
        Me.dtpDateReceived.Enabled = False
        Me.dtpDateReceived.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateReceived.Location = New System.Drawing.Point(166, 486)
        Me.dtpDateReceived.Name = "dtpDateReceived"
        Me.dtpDateReceived.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateReceived.TabIndex = 340
        Me.dtpDateReceived.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'lblReceivedBy
        '
        Me.lblReceivedBy.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivedBy.Location = New System.Drawing.Point(166, 453)
        Me.lblReceivedBy.Name = "lblReceivedBy"
        Me.lblReceivedBy.Size = New System.Drawing.Size(188, 26)
        Me.lblReceivedBy.TabIndex = 339
        Me.lblReceivedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblsupplierCom
        '
        Me.lblsupplierCom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplierCom.Location = New System.Drawing.Point(166, 258)
        Me.lblsupplierCom.Name = "lblsupplierCom"
        Me.lblsupplierCom.Size = New System.Drawing.Size(187, 26)
        Me.lblsupplierCom.TabIndex = 338
        Me.lblsupplierCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 299)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 18)
        Me.Label19.TabIndex = 329
        Me.Label19.Text = "Supplier Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 262)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 18)
        Me.Label16.TabIndex = 337
        Me.Label16.Text = "Supplier Company:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 18)
        Me.Label2.TabIndex = 330
        Me.Label2.Text = "Delivery Report No. :"
        '
        'lblsupplierName
        '
        Me.lblsupplierName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupplierName.Location = New System.Drawing.Point(167, 295)
        Me.lblsupplierName.Name = "lblsupplierName"
        Me.lblsupplierName.Size = New System.Drawing.Size(186, 26)
        Me.lblsupplierName.TabIndex = 331
        Me.lblsupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 18)
        Me.Label6.TabIndex = 332
        Me.Label6.Text = "Delivery Report Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 336
        Me.Label4.Text = "Date Received:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 455)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.TabIndex = 333
        Me.Label9.Text = "Received By:"
        '
        'txtDeliveryReportNo
        '
        Me.txtDeliveryReportNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeliveryReportNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeliveryReportNo.Location = New System.Drawing.Point(166, 380)
        Me.txtDeliveryReportNo.Name = "txtDeliveryReportNo"
        Me.txtDeliveryReportNo.Size = New System.Drawing.Size(188, 26)
        Me.txtDeliveryReportNo.TabIndex = 334
        '
        'dtpDeliveryReportDate
        '
        Me.dtpDeliveryReportDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDeliveryReportDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeliveryReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeliveryReportDate.Location = New System.Drawing.Point(166, 416)
        Me.dtpDeliveryReportDate.Name = "dtpDeliveryReportDate"
        Me.dtpDeliveryReportDate.Size = New System.Drawing.Size(187, 26)
        Me.dtpDeliveryReportDate.TabIndex = 335
        Me.dtpDeliveryReportDate.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'lblwarning
        '
        Me.lblwarning.AutoSize = True
        Me.lblwarning.ForeColor = System.Drawing.Color.White
        Me.lblwarning.Location = New System.Drawing.Point(16, 44)
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
        Me.dtpDateRequested.Location = New System.Drawing.Point(166, 221)
        Me.dtpDateRequested.Name = "dtpDateRequested"
        Me.dtpDateRequested.Size = New System.Drawing.Size(187, 26)
        Me.dtpDateRequested.TabIndex = 300
        Me.dtpDateRequested.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'btnfrmreleasecancel
        '
        Me.btnfrmreleasecancel.BackColor = System.Drawing.Color.White
        Me.btnfrmreleasecancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfrmreleasecancel.FlatAppearance.BorderSize = 2
        Me.btnfrmreleasecancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfrmreleasecancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfrmreleasecancel.ForeColor = System.Drawing.Color.Black
        Me.btnfrmreleasecancel.Location = New System.Drawing.Point(165, 577)
        Me.btnfrmreleasecancel.Name = "btnfrmreleasecancel"
        Me.btnfrmreleasecancel.Size = New System.Drawing.Size(189, 30)
        Me.btnfrmreleasecancel.TabIndex = 299
        Me.btnfrmreleasecancel.Text = "Cancel"
        Me.btnfrmreleasecancel.UseVisualStyleBackColor = False
        '
        'btnSelectEmployee
        '
        Me.btnSelectEmployee.BackColor = System.Drawing.Color.White
        Me.btnSelectEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSelectEmployee.FlatAppearance.BorderSize = 2
        Me.btnSelectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectEmployee.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnSelectEmployee.Location = New System.Drawing.Point(166, 34)
        Me.btnSelectEmployee.Name = "btnSelectEmployee"
        Me.btnSelectEmployee.Size = New System.Drawing.Size(187, 30)
        Me.btnSelectEmployee.TabIndex = 275
        Me.btnSelectEmployee.Text = "Search Purchase Order"
        Me.btnSelectEmployee.UseVisualStyleBackColor = False
        '
        'lblqty
        '
        Me.lblqty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(12, 36)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(56, 26)
        Me.lblqty.TabIndex = 298
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'lblreq
        '
        Me.lblreq.AutoSize = True
        Me.lblreq.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreq.Location = New System.Drawing.Point(12, 80)
        Me.lblreq.Name = "lblreq"
        Me.lblreq.Size = New System.Drawing.Size(99, 18)
        Me.lblreq.TabIndex = 276
        Me.lblreq.Text = "Request No:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 18)
        Me.Label11.TabIndex = 277
        Me.Label11.Text = "Requested By:"
        '
        'lblReqNo
        '
        Me.lblReqNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqNo.Location = New System.Drawing.Point(166, 76)
        Me.lblReqNo.Name = "lblReqNo"
        Me.lblReqNo.Size = New System.Drawing.Size(187, 26)
        Me.lblReqNo.TabIndex = 286
        Me.lblReqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 227)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 18)
        Me.Label15.TabIndex = 278
        Me.Label15.Text = "Date Requested:"
        '
        'btnRelease
        '
        Me.btnRelease.BackColor = System.Drawing.Color.White
        Me.btnRelease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRelease.FlatAppearance.BorderSize = 2
        Me.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelease.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelease.ForeColor = System.Drawing.Color.Black
        Me.btnRelease.Location = New System.Drawing.Point(165, 537)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(189, 30)
        Me.btnRelease.TabIndex = 297
        Me.btnRelease.Text = "Receive"
        Me.btnRelease.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Remarks/Purpose:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 280
        Me.Label7.Text = "Department:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-3, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(382, 26)
        Me.Label8.TabIndex = 281
        Me.Label8.Text = "Receiving Details"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReqBy
        '
        Me.lblReqBy.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqBy.Location = New System.Drawing.Point(166, 113)
        Me.lblReqBy.Name = "lblReqBy"
        Me.lblReqBy.Size = New System.Drawing.Size(187, 26)
        Me.lblReqBy.TabIndex = 287
        Me.lblReqBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblremarks
        '
        Me.lblremarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremarks.Location = New System.Drawing.Point(166, 187)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(187, 26)
        Me.lblremarks.TabIndex = 289
        Me.lblremarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldept
        '
        Me.lbldept.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldept.Location = New System.Drawing.Point(166, 150)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(187, 26)
        Me.lbldept.TabIndex = 288
        Me.lbldept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvReqPO
        '
        Me.dgvReqPO.AllowUserToAddRows = False
        Me.dgvReqPO.AllowUserToDeleteRows = False
        Me.dgvReqPO.AllowUserToResizeRows = False
        Me.dgvReqPO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReqPO.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqPO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReqPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReqPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReqPO.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReqPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReqPO.Location = New System.Drawing.Point(370, 81)
        Me.dgvReqPO.MultiSelect = False
        Me.dgvReqPO.Name = "dgvReqPO"
        Me.dgvReqPO.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReqPO.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReqPO.RowHeadersVisible = False
        Me.dgvReqPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReqPO.Size = New System.Drawing.Size(1010, 657)
        Me.dgvReqPO.TabIndex = 163
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "purchaseID"
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
        Me.Column4.DataPropertyName = "catDesc"
        Me.Column4.HeaderText = "Category"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "unitDesc"
        Me.Column5.HeaderText = "Unit"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'frmReceivingPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1380, 759)
        Me.Controls.Add(Me.dgvReqPO)
        Me.Controls.Add(Me.pnldata)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReceivingPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receiving"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnldata.ResumeLayout(False)
        Me.pnldata.PerformLayout()
        CType(Me.dgvReqPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUSER As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnldata As System.Windows.Forms.Panel
    Friend WithEvents lblwarning As System.Windows.Forms.Label
    Friend WithEvents dtpDateRequested As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSelectEmployee As System.Windows.Forms.Button
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblreq As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblReqNo As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblReqBy As System.Windows.Forms.Label
    Friend WithEvents lblremarks As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents dgvReqPO As System.Windows.Forms.DataGridView
    Friend WithEvents btnfrmreleasecancel As System.Windows.Forms.Button
    Friend WithEvents btnRelease As System.Windows.Forms.Button
    Friend WithEvents dtpDateReceived As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReceivedBy As System.Windows.Forms.Label
    Friend WithEvents lblsupplierCom As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblsupplierName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryReportNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDeliveryReportDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblModifyQtyid As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
