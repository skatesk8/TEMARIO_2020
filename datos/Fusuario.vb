Imports System.Data.SqlClient
Imports entidad

Public Class Fusuario

    Inherits conexion
    Public Function validarusuario(ByVal dts As Eusuario) As DataTable

        conectado()
        cmd = New SqlCommand("_iniciorsesion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@usuario", dts._usuario)
        cmd.Parameters.AddWithValue("@pass", dts._pass)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function
End Class
