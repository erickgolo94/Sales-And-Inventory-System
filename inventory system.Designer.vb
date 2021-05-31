<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menustripmain = New System.Windows.Forms.MenuStrip()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmclient = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RawMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrderViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrderViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleasedRawMaterialsViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivedRawMaterialsViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestSuppliesViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RawMaterialDeletionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnRawMaterial = New System.Windows.Forms.ToolStripButton()
        Me.btnRawmaterialStock = New System.Windows.Forms.ToolStripButton()
        Me.btnPurchaseOrder = New System.Windows.Forms.ToolStripButton()
        Me.btnReqSup = New System.Windows.Forms.ToolStripButton()
        Me.btnRelease = New System.Windows.Forms.ToolStripButton()
        Me.btnEndProd = New System.Windows.Forms.ToolStripButton()
        Me.btnTransaction = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUSER = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.menustripmain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.menustripmain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1372, 22)
        Me.Panel1.TabIndex = 6
        '
        'menustripmain
        '
        Me.menustripmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.menustripmain.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menustripmain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StocksToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.MaintenanceToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menustripmain.Location = New System.Drawing.Point(0, 0)
        Me.menustripmain.Name = "menustripmain"
        Me.menustripmain.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menustripmain.Size = New System.Drawing.Size(1372, 24)
        Me.menustripmain.TabIndex = 4
        Me.menustripmain.Text = "MenuStrip1"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserHistoryToolStripMenuItem})
        Me.StocksToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.StocksToolStripMenuItem.Text = "&Logs"
        '
        'UserHistoryToolStripMenuItem
        '
        Me.UserHistoryToolStripMenuItem.Name = "UserHistoryToolStripMenuItem"
        Me.UserHistoryToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UserHistoryToolStripMenuItem.Text = "User history"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem, Me.tsmclient, Me.EmployeesRecordToolStripMenuItem, Me.RawMaterialToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.PurchaseOrderViewToolStripMenuItem, Me.InventoryHistoryToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem1.Text = "&Records"
        '
        'tsmclient
        '
        Me.tsmclient.Name = "tsmclient"
        Me.tsmclient.Size = New System.Drawing.Size(195, 22)
        Me.tsmclient.Text = "Clients"
        '
        'EmployeesRecordToolStripMenuItem
        '
        Me.EmployeesRecordToolStripMenuItem.Name = "EmployeesRecordToolStripMenuItem"
        Me.EmployeesRecordToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.EmployeesRecordToolStripMenuItem.Text = "Employee's Records"
        '
        'RawMaterialToolStripMenuItem
        '
        Me.RawMaterialToolStripMenuItem.Name = "RawMaterialToolStripMenuItem"
        Me.RawMaterialToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RawMaterialToolStripMenuItem.Text = "Raw Materials"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SupplierToolStripMenuItem.Text = "Suppliers"
        '
        'PurchaseOrderViewToolStripMenuItem
        '
        Me.PurchaseOrderViewToolStripMenuItem.Name = "PurchaseOrderViewToolStripMenuItem"
        Me.PurchaseOrderViewToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PurchaseOrderViewToolStripMenuItem.Text = "Purchase order View"
        '
        'InventoryHistoryToolStripMenuItem
        '
        Me.InventoryHistoryToolStripMenuItem.Name = "InventoryHistoryToolStripMenuItem"
        Me.InventoryHistoryToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.InventoryHistoryToolStripMenuItem.Text = "Inventory History"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseOrderViewToolStripMenuItem1, Me.ReleasedRawMaterialsViewToolStripMenuItem, Me.ReceivedRawMaterialsViewToolStripMenuItem, Me.RequestSuppliesViewToolStripMenuItem, Me.TransactionsViewToolStripMenuItem})
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(64, 20)
        Me.ToolStripMenuItem2.Text = "&Reports"
        '
        'PurchaseOrderViewToolStripMenuItem1
        '
        Me.PurchaseOrderViewToolStripMenuItem1.Name = "PurchaseOrderViewToolStripMenuItem1"
        Me.PurchaseOrderViewToolStripMenuItem1.Size = New System.Drawing.Size(262, 22)
        Me.PurchaseOrderViewToolStripMenuItem1.Text = "Purchase Order View"
        '
        'ReleasedRawMaterialsViewToolStripMenuItem
        '
        Me.ReleasedRawMaterialsViewToolStripMenuItem.Name = "ReleasedRawMaterialsViewToolStripMenuItem"
        Me.ReleasedRawMaterialsViewToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ReleasedRawMaterialsViewToolStripMenuItem.Text = "Released Request Supplies View"
        '
        'ReceivedRawMaterialsViewToolStripMenuItem
        '
        Me.ReceivedRawMaterialsViewToolStripMenuItem.Name = "ReceivedRawMaterialsViewToolStripMenuItem"
        Me.ReceivedRawMaterialsViewToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ReceivedRawMaterialsViewToolStripMenuItem.Text = "Released Order Request View"
        '
        'RequestSuppliesViewToolStripMenuItem
        '
        Me.RequestSuppliesViewToolStripMenuItem.Name = "RequestSuppliesViewToolStripMenuItem"
        Me.RequestSuppliesViewToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.RequestSuppliesViewToolStripMenuItem.Text = "Request Supplies View"
        '
        'TransactionsViewToolStripMenuItem
        '
        Me.TransactionsViewToolStripMenuItem.Name = "TransactionsViewToolStripMenuItem"
        Me.TransactionsViewToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.TransactionsViewToolStripMenuItem.Text = "Sales Report"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AreaToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.CityToolStripMenuItem, Me.PositionToolStripMenuItem, Me.UnitToolStripMenuItem, Me.RawMaterialDeletionToolStripMenuItem, Me.UserTypeToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MaintenanceToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'AreaToolStripMenuItem
        '
        Me.AreaToolStripMenuItem.Name = "AreaToolStripMenuItem"
        Me.AreaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AreaToolStripMenuItem.Text = "&Area"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CategoryToolStripMenuItem.Text = "&Category"
        '
        'CityToolStripMenuItem
        '
        Me.CityToolStripMenuItem.Name = "CityToolStripMenuItem"
        Me.CityToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CityToolStripMenuItem.Text = "City"
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PositionToolStripMenuItem.Text = "&Designation"
        '
        'UnitToolStripMenuItem
        '
        Me.UnitToolStripMenuItem.Name = "UnitToolStripMenuItem"
        Me.UnitToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.UnitToolStripMenuItem.Text = "&Unit"
        '
        'RawMaterialDeletionToolStripMenuItem
        '
        Me.RawMaterialDeletionToolStripMenuItem.Name = "RawMaterialDeletionToolStripMenuItem"
        Me.RawMaterialDeletionToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RawMaterialDeletionToolStripMenuItem.Text = "Raw Material Deletion"
        '
        'UserTypeToolStripMenuItem
        '
        Me.UserTypeToolStripMenuItem.Name = "UserTypeToolStripMenuItem"
        Me.UserTypeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.UserTypeToolStripMenuItem.Text = "User Type"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ReportsToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1372, 94)
        Me.Panel3.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRawMaterial, Me.btnRawmaterialStock, Me.btnPurchaseOrder, Me.btnReqSup, Me.btnRelease, Me.btnEndProd, Me.btnTransaction, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1372, 90)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnRawMaterial
        '
        Me.btnRawMaterial.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawMaterial.ForeColor = System.Drawing.Color.Black
        Me.btnRawMaterial.Image = CType(resources.GetObject("btnRawMaterial.Image"), System.Drawing.Image)
        Me.btnRawMaterial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRawMaterial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRawMaterial.Name = "btnRawMaterial"
        Me.btnRawMaterial.Size = New System.Drawing.Size(80, 87)
        Me.btnRawMaterial.Text = "Receiving"
        Me.btnRawMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnRawmaterialStock
        '
        Me.btnRawmaterialStock.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawmaterialStock.ForeColor = System.Drawing.Color.Black
        Me.btnRawmaterialStock.Image = CType(resources.GetObject("btnRawmaterialStock.Image"), System.Drawing.Image)
        Me.btnRawmaterialStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRawmaterialStock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRawmaterialStock.Name = "btnRawmaterialStock"
        Me.btnRawmaterialStock.Size = New System.Drawing.Size(81, 87)
        Me.btnRawmaterialStock.Text = "Inventory"
        Me.btnRawmaterialStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnPurchaseOrder
        '
        Me.btnPurchaseOrder.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseOrder.ForeColor = System.Drawing.Color.Black
        Me.btnPurchaseOrder.Image = CType(resources.GetObject("btnPurchaseOrder.Image"), System.Drawing.Image)
        Me.btnPurchaseOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPurchaseOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPurchaseOrder.Name = "btnPurchaseOrder"
        Me.btnPurchaseOrder.Size = New System.Drawing.Size(122, 87)
        Me.btnPurchaseOrder.Text = "Purchase Order"
        Me.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnReqSup
        '
        Me.btnReqSup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReqSup.ForeColor = System.Drawing.Color.Black
        Me.btnReqSup.Image = CType(resources.GetObject("btnReqSup.Image"), System.Drawing.Image)
        Me.btnReqSup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReqSup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReqSup.Name = "btnReqSup"
        Me.btnReqSup.Size = New System.Drawing.Size(122, 87)
        Me.btnReqSup.Text = "Request Supply"
        Me.btnReqSup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnRelease
        '
        Me.btnRelease.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelease.ForeColor = System.Drawing.Color.Black
        Me.btnRelease.Image = CType(resources.GetObject("btnRelease.Image"), System.Drawing.Image)
        Me.btnRelease.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRelease.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(80, 87)
        Me.btnRelease.Text = "Releasing"
        Me.btnRelease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEndProd
        '
        Me.btnEndProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndProd.ForeColor = System.Drawing.Color.Black
        Me.btnEndProd.Image = CType(resources.GetObject("btnEndProd.Image"), System.Drawing.Image)
        Me.btnEndProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEndProd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEndProd.Name = "btnEndProd"
        Me.btnEndProd.Size = New System.Drawing.Size(99, 87)
        Me.btnEndProd.Text = "End Product"
        Me.btnEndProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnTransaction
        '
        Me.btnTransaction.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnTransaction.Image = CType(resources.GetObject("btnTransaction.Image"), System.Drawing.Image)
        Me.btnTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(68, 87)
        Me.btnTransaction.Text = "Sales"
        Me.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnExit
        '
        Me.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 87)
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.StatusStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 730)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1372, 22)
        Me.Panel4.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsUSER, Me.ToolStripStatusLabel2, Me.txtDate, Me.ToolStripStatusLabel4, Me.txtTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1372, 22)
        Me.StatusStrip1.TabIndex = 9
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(247, 660)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 38)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PETROMINE (M) SDN. BHD"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(12, 534)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 206)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1372, 752)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sss"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menustripmain.ResumeLayout(False)
        Me.menustripmain.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents menustripmain As System.Windows.Forms.MenuStrip
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmclient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeesRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RawMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRawMaterial As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRawmaterialStock As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReqSup As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRelease As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTransaction As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsUSER As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UserHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEndProd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReceivedRawMaterialsViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReleasedRawMaterialsViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestSuppliesViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseOrderViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseOrderViewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RawMaterialDeletionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPurchaseOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
