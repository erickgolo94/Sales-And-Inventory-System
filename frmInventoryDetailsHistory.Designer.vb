<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryDetailsHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryDetailsHistory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDateSerch = New System.Windows.Forms.Button()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnInventoryPrint = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvInventoryDetails = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvInventoryDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDateSerch
        '
        Me.btnDateSerch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDateSerch.BackColor = System.Drawing.Color.White
        Me.btnDateSerch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDateSerch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDateSerch.FlatAppearance.BorderSize = 2
        Me.btnDateSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDateSerch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDateSerch.ForeColor = System.Drawing.Color.Black
        Me.btnDateSerch.Location = New System.Drawing.Point(990, 10)
        Me.btnDateSerch.Name = "btnDateSerch"
        Me.btnDateSerch.Size = New System.Drawing.Size(106, 30)
        Me.btnDateSerch.TabIndex = 335
        Me.btnDateSerch.Text = "&Search"
        Me.btnDateSerch.UseVisualStyleBackColor = False
        '
        'dtpTo
        '
        Me.dtpTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTo.CustomFormat = "yyyy-MM-dd"
        Me.dtpTo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(788, 11)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(190, 26)
        Me.dtpTo.TabIndex = 334
        Me.dtpTo.Value = New Date(2018, 3, 8, 0, 0, 0, 0)
        '
        'btnInventoryPrint
        '
        Me.btnInventoryPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventoryPrint.BackColor = System.Drawing.Color.White
        Me.btnInventoryPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInventoryPrint.FlatAppearance.BorderSize = 2
        Me.btnInventoryPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryPrint.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryPrint.ForeColor = System.Drawing.Color.Black
        Me.btnInventoryPrint.Image = CType(resources.GetObject("btnInventoryPrint.Image"), System.Drawing.Image)
        Me.btnInventoryPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInventoryPrint.Location = New System.Drawing.Point(986, 17)
        Me.btnInventoryPrint.Name = "btnInventoryPrint"
        Me.btnInventoryPrint.Size = New System.Drawing.Size(115, 42)
        Me.btnInventoryPrint.TabIndex = 326
        Me.btnInventoryPrint.Text = "&Print"
        Me.btnInventoryPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryPrint.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.pnl)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1115, 577)
        Me.Panel4.TabIndex = 26
        '
        'dgvInventoryDetails
        '
        Me.dgvInventoryDetails.AllowUserToAddRows = False
        Me.dgvInventoryDetails.AllowUserToDeleteRows = False
        Me.dgvInventoryDetails.AllowUserToResizeRows = False
        Me.dgvInventoryDetails.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventoryDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventoryDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column1, Me.Column21, Me.Column22, Me.Column23, Me.Column24, Me.Column25})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventoryDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInventoryDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventoryDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvInventoryDetails.MultiSelect = False
        Me.dgvInventoryDetails.Name = "dgvInventoryDetails"
        Me.dgvInventoryDetails.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventoryDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvInventoryDetails.RowHeadersVisible = False
        Me.dgvInventoryDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventoryDetails.Size = New System.Drawing.Size(1115, 413)
        Me.dgvInventoryDetails.TabIndex = 167
        Me.dgvInventoryDetails.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 40)
        Me.Panel1.TabIndex = 336
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVENTORY DETAILS HISTORY"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.btnDateSerch)
        Me.pnl.Controls.Add(Me.dtpTo)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl.Location = New System.Drawing.Point(0, 40)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1115, 50)
        Me.pnl.TabIndex = 337
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnInventoryPrint)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 503)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1115, 74)
        Me.Panel3.TabIndex = 338
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvInventoryDetails)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1115, 413)
        Me.Panel2.TabIndex = 339
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "rawmaterialOnHandID"
        Me.Column13.HeaderText = "ID"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        Me.Column13.Width = 85
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "transactionNo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column14.HeaderText = "Transaction ID"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "requestDate"
        Me.Column15.HeaderText = "Date Request"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 130
        '
        'Column16
        '
        Me.Column16.DataPropertyName = "comSupplier"
        Me.Column16.HeaderText = "Supplier"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 130
        '
        'Column17
        '
        Me.Column17.DataPropertyName = "supplierName"
        Me.Column17.HeaderText = "Supplier Name"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 140
        '
        'Column18
        '
        Me.Column18.DataPropertyName = "deliveryRepDate"
        Me.Column18.HeaderText = "Delivery Report Date"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 160
        '
        'Column19
        '
        Me.Column19.DataPropertyName = "receiveBy"
        Me.Column19.HeaderText = "Received By"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 130
        '
        'Column20
        '
        Me.Column20.DataPropertyName = "dateReceive"
        Me.Column20.HeaderText = "Date Received"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 130
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "rawmaterialID"
        Me.Column1.HeaderText = "rawmterialID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column21
        '
        Me.Column21.DataPropertyName = "rawmaterialName"
        Me.Column21.HeaderText = "Raw Material Name"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 150
        '
        'Column22
        '
        Me.Column22.DataPropertyName = "desc"
        Me.Column22.HeaderText = "Description"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Width = 150
        '
        'Column23
        '
        Me.Column23.DataPropertyName = "catDesc"
        Me.Column23.HeaderText = "Category"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        '
        'Column24
        '
        Me.Column24.DataPropertyName = "unitDesc"
        Me.Column24.HeaderText = "Unit"
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        '
        'Column25
        '
        Me.Column25.DataPropertyName = "qty"
        Me.Column25.HeaderText = "Quantity"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        '
        'frmInventoryDetailsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 577)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInventoryDetailsHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInventoryDetailsHistory"
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvInventoryDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDateSerch As System.Windows.Forms.Button
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInventoryPrint As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgvInventoryDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column25 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
