Public Class Login
    Sub pertama()
        btnlogin.Enabled = False
        btnkeluar.Enabled = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pertama()
        ServerName = ".\SQLEXPRESS"
        userServer = "sa"
        PasServer = "123"
    End Sub

    Dim x As Integer
    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        x = MsgBox("Apakah anda ingin keluar ??", vbOK + vbInformation, "Terimakasih")
        If x = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        sqL = "select* from msuser where username=" & Aphostrophe(tuser.Text) &
          "and password=" & Aphostrophe(tpassword.Text)
        Tabel = Proses.ExecuteQuery(Sql)
        If Tabel.Rows.Count > 0 Then
            utama.Show()
            utama.MASTERMENU.Visible = False
            Me.Hide()
        ElseIf tuser.Text = "admin" And tpassword.Text = "123" Then
            MsgBox("User dan pasword anda benar", vbOKOnly + vbInformation, "Selamat Datang")
            utama.Show()
            utama.MASTERMENU.Visible = True
            Me.Hide()

        Else
            MsgBox("User dan Password Salah", vbCritical, "coba kembali")
            tuser.Clear()
            tpassword.Clear()
            Me.Close()
        End If

       

    End Sub

    Private Sub tuser_Enter(sender As Object, e As EventArgs) Handles tuser.Enter

    End Sub

    Private Sub tuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tuser.KeyPress
        btnlogin.Enabled = True
        tpassword.Enabled = True
        btnkeluar.Enabled = True
       
    End Sub

    Private Sub tuser_TextChanged(sender As Object, e As EventArgs) Handles tuser.TextChanged

    End Sub

    Private Sub tpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpassword.KeyPress

    End Sub

    Private Sub tpassword_TextChanged(sender As Object, e As EventArgs) Handles tpassword.TextChanged

    End Sub
End Class
