Public Class Administrador
    Private Sub GeneralBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GeneralBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuniDataSet)

    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuniDataSet.General' Puede moverla o quitarla según sea necesario.
        Me.GeneralTableAdapter.Fill(Me.MuniDataSet.General)

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Me.GeneralTableAdapter.Agregar(Id_multaTextBox.Text, PlacaTextBox.Text, RemisionTextBox.Text, FechaTextBox.Text, MontoTextBox.Text)
        Me.GeneralTableAdapter.Fill(Me.MuniDataSet.General)
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Me.GeneralTableAdapter.Modificar(Id_multaTextBox.Text, PlacaTextBox.Text, RemisionTextBox.Text, FechaTextBox.Text, MontoTextBox.Text, Id_multaTextBox.Text)
        Me.GeneralTableAdapter.Fill(Me.MuniDataSet.General)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.GeneralTableAdapter.Eliminar(Id_multaTextBox.Text)
        Me.GeneralTableAdapter.Fill(Me.MuniDataSet.General)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Me.GeneralTableAdapter.Buscar(MuniDataSet.General, Id_multaTextBox.Text)
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        Me.GeneralTableAdapter.Fill(Me.MuniDataSet.General)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class