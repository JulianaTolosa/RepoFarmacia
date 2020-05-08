Imports System.Data
Imports System.Data.SqlClient
Imports CapaComun

Public Class UserDao
    Inherits Conexion

    Public Function Login(user As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "select * from Usuario where nombreusuario=@user and contrasena=@pass"
                Command.Parameters.AddWithValue("@user", user)
                Command.Parameters.AddWithValue("@pass", pass)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.idusuario = reader.GetInt32(0)
                        ActiveUser.Nombre = reader.GetString(3)
                        ActiveUser.Apellido = reader.GetString(4)
                        ActiveUser.Posicion = reader.GetString(5)
                        ActiveUser.Correo = reader.GetString(6)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using

    End Function
End Class
