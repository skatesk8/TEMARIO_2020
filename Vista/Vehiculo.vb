Public Class Vehiculo
    Private Sub MultasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MultasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuniDataSet)

    End Sub

    Private Sub Vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuniDataSet.multas' Puede moverla o quitarla según sea necesario.
        Me.MultasTableAdapter.Fill(Me.MuniDataSet.multas)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reporte1.Show()
    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In MultasDataGridView.Rows
            total += Convert.ToDouble(fila.Cells("monto").Value)
        Next

        txttotal.Text = Convert.ToString(total)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class