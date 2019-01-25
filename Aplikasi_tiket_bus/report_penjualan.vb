Public Class report_penjualan

    Private Sub report_penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tiketbusDataSet1.penjualan12' table. You can move, or remove it, as needed.
        Me.penjualan12TableAdapter.Fill(Me.tiketbusDataSet1.penjualan12)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class