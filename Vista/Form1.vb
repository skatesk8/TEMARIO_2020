Imports entidad
Imports datos

Public Class Form1

    Dim fu As New Fusuario
    Dim eu As New Eusuario

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Try

            If txtcontraseña.Text <> "" And txtusuario.Text <> "" Then
                Dim dt As New DataTable

                eu._usuario = txtusuario.Text
                eu._pass = txtcontraseña.Text
                dt = fu.validarusuario(eu)
                If dt.Rows.Count > 0 Then
                    Timer1.Start()

                    Dim tipo As String
                    tipo = dt.Rows(0)("tipo")
                    If tipo = "moto" Then
                        My.Forms.motocicleta.Show()
                    ElseIf tipo = "Part" Then
                        My.Forms.Particular.Show()

                    ElseIf tipo = "Vehi" Then
                        My.Forms.Vehiculo.Show()

                    ElseIf tipo = "Administrador" Then
                        My.Forms.Administrador.Show()
                    End If
                Else
                    Static intento As Integer

                    intento = intento + 1
                    MsgBox("estimado usuario te quedan " & (3 - intento) & " intentos")
                    If intento = 3 Then
                        MsgBox("el sistema se cerrara , gracias", MsgBoxStyle.Critical, "SISTEMA")

                        Me.Close()
                        'inicio de proceso de apagado
                        'Process.Start("shutdow.exe", "-s -t 00")

                    End If


                End If


            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            MsgBox("Ingresaste al sistema al apartado de: " & txtusuario.Text)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub
End Class
