Public Class utama
    Sub sembunyi()
        mstiket.Close()
        frmpenjualan.Close()

    End Sub
    Dim x As Integer
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        x = MsgBox("Apakah anda ingin keluar ??", vbOK + vbInformation, "Terimakasih")
        If x = vbOK Then
            Login.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sembunyi()
        mstiket.MdiParent = Me
        mstiket.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sembunyi()
        frmpenjualan.MdiParent = Me
        frmpenjualan.Show()
    End Sub

    Private Sub utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        x = MsgBox("Apakah anda ingin keluar ??", vbOK + vbInformation, "Terimakasih")
        If x = vbOK Then
            Login.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmpilihan_report.MdiParent = Me
        frmpilihan_report.Show()
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        frmpenjualan.MdiParent = Me
        frmpenjualan.Show()

    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        mstiket.MdiParent = Me
        mstiket.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frminformasi.MdiParent = Me
        frminformasi.Show()

    End Sub
End Class