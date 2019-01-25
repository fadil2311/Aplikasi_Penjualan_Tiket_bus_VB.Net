Public Class Report_mstiket

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tiketbusDataSet.mstiket1' table. You can move, or remove it, as needed.
        Me.mstiket1TableAdapter.Fill(Me.tiketbusDataSet.mstiket1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class