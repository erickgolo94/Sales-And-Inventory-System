<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReqSuppliesReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.vw_reqsuppliesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.purchasereq = New WindowsApplication2.purchasereq()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rvReqSupplies = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.vw_reqsuppliesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purchasereq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'vw_reqsuppliesBindingSource
        '
        Me.vw_reqsuppliesBindingSource.DataMember = "vw_reqsupplies"
        Me.vw_reqsuppliesBindingSource.DataSource = Me.purchasereq
        '
        'purchasereq
        '
        Me.purchasereq.DataSetName = "purchasereq"
        Me.purchasereq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 44)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rvReqSupplies)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1019, 660)
        Me.Panel3.TabIndex = 2
        '
        'rvReqSupplies
        '
        Me.rvReqSupplies.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.vw_reqsuppliesBindingSource
        Me.rvReqSupplies.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvReqSupplies.LocalReport.ReportEmbeddedResource = "WindowsApplication2.Report1.rdlc"
        Me.rvReqSupplies.Location = New System.Drawing.Point(0, 0)
        Me.rvReqSupplies.Name = "rvReqSupplies"
        Me.rvReqSupplies.Size = New System.Drawing.Size(1019, 660)
        Me.rvReqSupplies.TabIndex = 1
        '
        'frmReqSuppliesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 704)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReqSuppliesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportSales"
        CType(Me.vw_reqsuppliesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purchasereq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rvReqSupplies As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vw_reqsuppliesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents purchasereq As WindowsApplication2.purchasereq
End Class
