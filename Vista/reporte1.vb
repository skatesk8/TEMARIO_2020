Public Class reporte1
    Private Sub reporte1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'muniDataSet.multas' Puede moverla o quitarla según sea necesario.
        Me.multasTableAdapter.Fill(Me.muniDataSet.multas)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Vehiculo.Show()
    End Sub
End Class