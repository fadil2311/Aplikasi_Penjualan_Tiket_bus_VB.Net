<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cetak_tiket
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tiketbusDataSet2 = New Aplikasi_tiket_bus.tiketbusDataSet2()
        Me.strokeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.strokeTableAdapter = New Aplikasi_tiket_bus.tiketbusDataSet2TableAdapters.strokeTableAdapter()
        CType(Me.tiketbusDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.strokeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.strokeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi_tiket_bus.Reportcetaktiket.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 617)
        Me.ReportViewer1.TabIndex = 0
        '
        'tiketbusDataSet2
        '
        Me.tiketbusDataSet2.DataSetName = "tiketbusDataSet2"
        Me.tiketbusDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'strokeBindingSource
        '
        Me.strokeBindingSource.DataMember = "stroke"
        Me.strokeBindingSource.DataSource = Me.tiketbusDataSet2
        '
        'strokeTableAdapter
        '
        Me.strokeTableAdapter.ClearBeforeFill = True
        '
        'cetak_tiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 617)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "cetak_tiket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cetak_tiket"
        CType(Me.tiketbusDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.strokeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents strokeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tiketbusDataSet2 As Aplikasi_tiket_bus.tiketbusDataSet2
    Friend WithEvents strokeTableAdapter As Aplikasi_tiket_bus.tiketbusDataSet2TableAdapters.strokeTableAdapter
End Class
