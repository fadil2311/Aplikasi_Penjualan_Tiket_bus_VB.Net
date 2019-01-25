Public Class flmtiket
    Sub tampilgrid()
        sqL = "select id, trayek, tujuan, kelas,nopol from mstiket1"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv3.DataSource = Tabel

    End Sub
   
    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        sqL = "select  id, trayek, tujuan, kelas,nopol from mstiket1 where tujuan like" & Aphostrophe("%" & tcari.Text & "%")
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count > 0 Then
            MsgBox("Data yang dicari ada...." & Tabel.Rows.Count, vbInformation, "data ditemukan")
            dgv3.DataSource = Tabel
        Else
            MsgBox("data yang dicari tidak ada...", vbInformation, "cari data lain")

        End If
    End Sub

    Private Sub flmtiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilgrid()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        frmpenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub dgv3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv3.CellContentClick
        If dgv3.RowCount > 0 Then
            With frmpenjualan
                .tkelas.Text = dgv3.Item(3, dgv3.CurrentRow.Index).Value
                .ttujuan.Text = dgv3.Item(2, dgv3.CurrentRow.Index).Value

                .tnopol.Text = dgv3.Item(4, dgv3.CurrentRow.Index).Value
                .Show()
                Me.Hide()

            End With

        End If
    End Sub
End Class