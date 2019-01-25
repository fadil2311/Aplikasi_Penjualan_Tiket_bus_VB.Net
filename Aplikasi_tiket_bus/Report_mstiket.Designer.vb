<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_mstiket
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
        Me.mstiket1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tiketbusDataSet = New Aplikasi_tiket_bus.tiketbusDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mstiket1TableAdapter = New Aplikasi_tiket_bus.tiketbusDataSetTableAdapters.mstiket1TableAdapter()
        CType(Me.mstiket1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tiketbusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mstiket1BindingSource
        '
        Me.mstiket1BindingSource.DataMember = "mstiket1"
        Me.mstiket1BindingSource.DataSource = Me.tiketbusDataSet
        '
        'tiketbusDataSet
        '
        Me.tiketbusDataSet.DataSetName = "tiketbusDataSet"
        Me.tiketbusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mstiket1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi_tiket_bus.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1244, 733)
        Me.ReportViewer1.TabIndex = 0
        '
        'mstiket1TableAdapter
        '
        Me.mstiket1TableAdapter.ClearBeforeFill = True
        '
        'Report_mstiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 733)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Report_mstiket"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Ms Tiket"
        CType(Me.mstiket1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tiketbusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mstiket1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tiketbusDataSet As Aplikasi_tiket_bus.tiketbusDataSet
    Friend WithEvents mstiket1TableAdapter As Aplikasi_tiket_bus.tiketbusDataSetTableAdapters.mstiket1TableAdapter
End Class
