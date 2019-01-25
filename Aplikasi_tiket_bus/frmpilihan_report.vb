Public Class frmpilihan_report

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Report_mstiket.MdiParent = utama
        Report_mstiket.Show()
        Me.Close()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        report_penjualan.MdiParent = utama
        report_penjualan.Show()
        Me.Close()
    End Sub
End Class