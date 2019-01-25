<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flmtiket
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
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv3
        '
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Location = New System.Drawing.Point(12, 55)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.Size = New System.Drawing.Size(738, 413)
        Me.dgv3.TabIndex = 0
        '
        'tcari
        '
        Me.tcari.Location = New System.Drawing.Point(12, 12)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(302, 20)
        Me.tcari.TabIndex = 1
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(340, 12)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 2
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(439, 12)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 3
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'flmtiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 480)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.tcari)
        Me.Controls.Add(Me.dgv3)
        Me.Name = "flmtiket"
        Me.Text = "flmtiket"
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
End Class
