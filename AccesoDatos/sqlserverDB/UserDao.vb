Imports System.Data
Imports System.Data.SqlClient
Imports CapaComun

Public Class UserDao
    Inherits Conexion

    Public Sub editProfile(ByVal idusuario, ByVal nombreusuario, ByVal contrasena, ByVal Nombre, ByVal Apellido, ByVal Posicion, ByVal Correo)
        Using Conexion = GetConnection()
            Conexion.Open()
            Using Command = New SqlCommand
                Command.Connection = Conexion
                Command.CommandText = "update Usuario nombreusuario=@user, contrasena=@pass,Nombre=@name,Apellido=@lastname,Correo=@email where idusurio=@id"
                Command.Parameters.AddWithValue("@user", nombreusuario)
                Command.Parameters.AddWithValue("@pass", contrasena)
                Command.Parameters.AddWithValue("@name", Nombre)
                Command.Parameters.AddWithValue("@lastname", Apellido)
                Command.Parameters.AddWithValue("@email", Correo)
                Command.Parameters.AddWithValue("@id", idusuario)
                Command.CommandType = CommandType.Text
                Command.ExecuteNonQuery()
            End Using
        End Using




    End Sub

    Public Function requestUserPassword(ByVal requestingUser As String) As String

        Using connection = GetConnection()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "Select * from Usuario where nombreusuario=@user or Correo=@correo"
                Command.Parameters.AddWithValue("@user", requestingUser)
                Command.Parameters.AddWithValue("@correo", requestingUser)
                Command.CommandType = CommandType.Text

                Dim reader As SqlDataReader = Command.ExecuteReader()

                If reader.Read = True Then
                    Dim username = reader.GetString(3) & " " & reader.GetString(4)
                    Dim userMail = reader.GetString(6)
                    Dim userPassword = reader.GetString(2)

                    Dim mailSupport As New SystemSupportMail
                    'Acordarse de ver bien esto!!! ver el video y creo que hay que cambiar lo del return (el hola) y borrar este comentario dsp.
                    mailSupport.sendMail(subject:="SYSTEM: Solicitud de recuperacion de contraseña",
                                         body:="Hola , " & username & " solicita recuperar su contraseña." & vbNewLine & "Tu contraseña actual es: " & userPassword & vbNewLine &
                                         "Sin embargo, le pedimos que cambia su contraseña inmediatamente una vez que ingrese al sistema.", receiverMail:=New List(Of String) From {userMail})

                    Return "Hola , " & username & " solicita recuperar su contraseña." & vbNewLine & "Por Favor, revise su correo electronico: " & userPassword & vbNewLine &
                                         "Sin embargo, le pedimos que cambia su contraseña inmediatamente una vez que ingrese al sistema."
                Else
                    Return "Lo siento, no tienes una cuenta con ese correo electronico o nombre de usuario"

                End If

            End Using


        End Using

    End Function

    Public Function Login(ByVal user As String, ByVal pass As String) As Boolean
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

    Public Function existsUser(ByVal id As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "select * from Usuario where idusuario=@user"
                Command.Parameters.AddWithValue("@user", id)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Sub anyMethod2()
        If ActiveUser.Posicion = Positions.Encargado Then

        End If
        If ActiveUser.Posicion = Positions.Vendedor Then

        End If
    End Sub

End Class
