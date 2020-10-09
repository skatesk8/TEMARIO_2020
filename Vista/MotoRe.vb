Public Class MotoRe
    Private Sub MotoRe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'muniDataSet.multa' Puede moverla o quitarla según sea necesario.
        Me.multaTableAdapter.Fill(Me.muniDataSet.multa)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class