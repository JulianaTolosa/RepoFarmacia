Imports CapaComun
Imports Dominio

Public Class Editarempleado


    Private Sub btnCerrarForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub loadUserData()
        'vista
        Lblusuario.Text = ActiveUser.nombreusuario
        LblNombre3.Text = ActiveUser.Nombre
        Lblapellido3.Text = ActiveUser.Apellido
        Lblcorreo3.Text = ActiveUser.Correo
        Lblposicion3.Text = ActiveUser.Posicion

        'Editar
        Txtnomusuario.Text = ActiveUser.nombreusuario
        Txtnombre.Text = ActiveUser.Nombre
        Txtapellido.Text = ActiveUser.Apellido
        Txtcontrasena.Text = ActiveUser.Contrasena
        Txtconfirmar.Text = ActiveUser.Contrasena
        Txtcorreo.Text = ActiveUser.Correo
    End Sub

    Public Sub initializeControlsEditPass()
        Lkllbleditar.Text = "EDITAR"
        Txtcontrasena.UseSystemPasswordChar = True
        Txtcontrasena.Enabled = False
        Txtconfirmar.UseSystemPasswordChar = True
        Txtconfirmar.Enabled = False
        Txtactualcontrasena.Text = ""
    End Sub

    Private Sub reset()
        loadUserData()
        initializeControlsEditPass()
    End Sub


    Private Sub Editarempleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadUserData()
        initializeControlsEditPass()
    End Sub

    Private Sub Lkllbleditar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Lkllbleditar.LinkClicked
        If Lkllbleditar.Text = "EDITAR" Then
            Lkllbleditar.Text = "CANCELAR"
            Txtcontrasena.Enabled = True
            Txtcontrasena.Text = ""
            Txtconfirmar.Enabled = True
            Txtconfirmar.Text = ""
        ElseIf Lkllbleditar.Text = "CANCELAR" Then
            reset()
        End If
    End Sub

    Private Sub LkllblEditarperfil_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LkllblEditarperfil.LinkClicked
        Panelder.Visible = True
        loadUserData()
    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If Txtcontrasena.Text = Txtconfirmar.Text Then
            If Txtactualcontrasena.Text = ActiveUser.Contrasena Then

                Dim user As New user(idusuario:=ActiveUser.idusuario,
                                       nombreusuario:=Txtnomusuario.Text,
                                       Contrasena:=Txtcontrasena.Text,
                                       Nombre:=Txtnombre.Text,
                                       Apellido:=Txtapellido.Text,
                                       Posicion:=Nothing,
                                       Correo:=Txtcorreo.Text)
                Dim result = user.editUserProfile()
                MessageBox.Show(result)
                reset()
                Panelder.Visible = False
            Else
                MessageBox.Show("Contraseña actual incorrecta")
            End If
        Else
            MessageBox.Show("Las contraseñas no coinciden,por favor intente nuevamente")
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Panelder.Visible = False
        reset()
    End Sub

    
End Class