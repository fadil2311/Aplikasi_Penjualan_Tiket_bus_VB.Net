<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mstiket
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnopol = New System.Windows.Forms.TextBox()
        Me.ckelas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ctrayek = New System.Windows.Forms.ComboBox()
        Me.ttujuan = New System.Windows.Forms.TextBox()
        Me.tidbus = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.cberdasarkan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Trayek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tujuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nopol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kelas"
        '
        'tnopol
        '
        Me.tnopol.Location = New System.Drawing.Point(103, 104)
        Me.tnopol.Name = "tnopol"
        Me.tnopol.Size = New System.Drawing.Size(121, 20)
        Me.tnopol.TabIndex = 10
        '
        'ckelas
        '
        Me.ckelas.FormattingEnabled = True
        Me.ckelas.Location = New System.Drawing.Point(103, 130)
        Me.ckelas.Name = "ckelas"
        Me.ckelas.Size = New System.Drawing.Size(121, 21)
        Me.ckelas.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ctrayek)
        Me.GroupBox1.Controls.Add(Me.ttujuan)
        Me.GroupBox1.Controls.Add(Me.tidbus)
        Me.GroupBox1.Controls.Add(Me.ckelas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tnopol)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 201)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Tiket"
        '
        'ctrayek
        '
        Me.ctrayek.FormattingEnabled = True
        Me.ctrayek.Location = New System.Drawing.Point(103, 56)
        Me.ctrayek.Name = "ctrayek"
        Me.ctrayek.Size = New System.Drawing.Size(121, 21)
        Me.ctrayek.TabIndex = 17
        '
        'ttujuan
        '
        Me.ttujuan.Location = New System.Drawing.Point(103, 82)
        Me.ttujuan.Name = "ttujuan"
        Me.ttujuan.Size = New System.Drawing.Size(233, 20)
        Me.ttujuan.TabIndex = 16
        '
        'tidbus
        '
        Me.tidbus.Location = New System.Drawing.Point(103, 30)
        Me.tidbus.Name = "tidbus"
        Me.tidbus.Size = New System.Drawing.Size(100, 20)
        Me.tidbus.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btncari)
        Me.GroupBox2.Controls.Add(Me.tcari)
        Me.GroupBox2.Controls.Add(Me.cberdasarkan)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 100)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(125, 51)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 3
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'tcari
        '
        Me.tcari.Location = New System.Drawing.Point(9, 53)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(100, 20)
        Me.tcari.TabIndex = 2
        '
        'cberdasarkan
        '
        Me.cberdasarkan.FormattingEnabled = True
        Me.cberdasarkan.Location = New System.Drawing.Point(79, 22)
        Me.cberdasarkan.Name = "cberdasarkan"
        Me.cberdasarkan.Size = New System.Drawing.Size(121, 21)
        Me.cberdasarkan.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Berdasarkan"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(372, 119)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 15
        Me.btn1.Text = "Button2"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(470, 119)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 16
        Me.btn2.Text = "Button3"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(422, 148)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 23)
        Me.btn4.TabIndex = 17
        Me.btn4.Text = "Print"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(515, 148)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 23)
        Me.btn5.TabIndex = 18
        Me.btn5.Text = "Keluar"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(564, 119)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 19
        Me.btn3.Text = "Button6"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 229)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(627, 150)
        Me.dgv1.TabIndex = 20
        '
        'mstiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 446)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mstiket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mstiket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tnopol As System.Windows.Forms.TextBox
    Friend WithEvents ckelas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tidbus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents cberdasarkan As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents ttujuan As System.Windows.Forms.TextBox
    Friend WithEvents ctrayek As System.Windows.Forms.ComboBox
End Class
