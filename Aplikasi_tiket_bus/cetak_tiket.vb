Public Class cetak_tiket

    Private Sub cetak_tiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tiketbusDataSet2.stroke' table. You can move, or remove it, as needed.
        Me.strokeTableAdapter.Fill(Me.tiketbusDataSet2.stroke)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class