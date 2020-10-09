Public Class motocicleta
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub MultaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MultaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuniDataSet)

    End Sub

    Private Sub motocicleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuniDataSet.multa' Puede moverla o quitarla según sea necesario.
        Me.MultaTableAdapter.Fill(Me.MuniDataSet.multa)

    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In MultaDataGridView.Rows
            total += Convert.ToDouble(fila.Cells("monto1").Value)
        Next

        txttotal.Text = Convert.ToString(total)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MotoRe.Show()
    End Sub
End Class