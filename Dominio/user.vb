Imports AccesoDatos
Imports CapaComun

Public Class user
    Dim userDao As New UserDao()

    Private idusuario
    Private nombreusuario
    Private contrasena
    Private Nombre
    Private Apellido
    Private Posicion
    Private Correo

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property idusuario1 As Object
        Get
            Return idusuario
        End Get
        Set(ByVal value As Object)
            idusuario = value
        End Set
    End Property
    Public Property nombreusuario1 As Object
        Get
            Return nombreusuario
        End Get
        Set(ByVal value As Object)
            nombreusuario = value
        End Set
    End Property
    Public Property contrasena1 As Object
        Get
            Return contrasena
        End Get
        Set(ByVal value As Object)
            contrasena = value
        End Set
    End Property
    Public Property Nombre1 As Object
        Get
            Return Nombre
        End Get
        Set(ByVal value As Object)
            Nombre = value
        End Set
    End Property
    Public Property Apellido1 As Object
        Get
            Return Apellido
        End Get
        Set(ByVal value As Object)
            Apellido = value
        End Set
    End Property
    Public Property Posicion1 As Object
        Get
            Return Posicion
        End Get
        Set(ByVal value As Object)
            Posicion = value
        End Set
    End Property
    Public Property Correo1 As Object
        Get
            Return Correo
        End Get
        Set(ByVal value As Object)
            Correo = value
        End Set
    End Property

    Public Sub New(ByVal idusuario As Object, ByVal nombreusuario As Object, ByVal contrasena As Object, ByVal Nombre As Object, ByVal Apellido As Object, ByVal Posicion As Object, ByVal Correo As Object)
        Me.idusuario = idusuario
        Me.nombreusuario = nombreusuario
        Me.contrasena = contrasena
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.Posicion = Posicion
        Me.Correo = Correo
    End Sub

    Public Function editUserProfile() As String
        Try
            userDao.editProfile(idusuario, nombreusuario, contrasena, Nombre, Apellido, Posicion, Correo)
            Login(nombreusuario, contrasena)
            Return "Tu Perfil se ha actualizado satisfactorimente"
        Catch ex As Exception
            Return "El Nombre de usuario ya esta registrado, intente con otro"
        End Try
    End Function


    Public Function recoryPassword(ByVal requestingUser As String) As String
        Return userDao.requestUserPassword(requestingUser)
    End Function

    Public Function Login(ByVal user As String, ByVal pass As String) As Boolean
        Return userDao.Login(user, pass)

    End Function

    Public Function anyMethod(ByVal id As Integer) As Boolean
        If ActiveUser.idusuario >= 1 Then
            If userDao.existsUser(ActiveUser.idusuario) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Sub anyMethod2()
        If ActiveUser.Posicion = Positions.Encargado Then

        End If
        If ActiveUser.Posicion = Positions.Vendedor Then

        End If
    End Sub

End Class