<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tuser = New System.Windows.Forms.TextBox()
        Me.tpassword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'tuser
        '
        Me.tuser.Location = New System.Drawing.Point(242, 48)
        Me.tuser.Name = "tuser"
        Me.tuser.Size = New System.Drawing.Size(175, 20)
        Me.tuser.TabIndex = 2
        '
        'tpassword
        '
        Me.tpassword.Location = New System.Drawing.Point(242, 104)
        Me.tpassword.Name = "tpassword"
        Me.tpassword.Size = New System.Drawing.Size(175, 20)
        Me.tpassword.TabIndex = 3
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(242, 143)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(343, 143)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 5
        Me.btnkeluar.Text = "keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Aplikasi_tiket_bus.My.Resources.Resources._248297720
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(46, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 136)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(467, 215)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.tpassword)
        Me.Controls.Add(Me.tuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tuser As System.Windows.Forms.TextBox
    Friend WithEvents tpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
