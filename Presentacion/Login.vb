
Imports System.Runtime.InteropServices
Imports Dominio

Public Class Login
#Region "Form Comportamientos"
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub


#End Region

    Private Sub TituloBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TituloBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#Region "Control Personalizado"
    Private Sub Componentepersonalizado()
        'txtUsuario
        txtUsuario.AutoSize = False
        txtUsuario.Size = New Size(350, 27)
        'txtContraseña
        txtcontraseña.AutoSize = False
        txtcontraseña.Size = New Size(350, 27)
        txtcontraseña.UseSystemPasswordChar = True
    End Sub

    Private Sub btnIngresar_Paint(sender As Object, e As PaintEventArgs) Handles btnIngresar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myrectangle As Rectangle = btnIngresar.ClientRectangle
        myrectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myrectangle)
        btnIngresar.Region = New Region(buttonPath)
    End Sub

#End Region
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Componentepersonalizado()
    End Sub

    
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim user As New user()
        Dim validlogin = user.Login(txtUsuario.Text, txtcontraseña.Text)
        If validlogin = True Then
            Me.Hide()
            Dim formWelcome As New FormWelcome
            formWelcome.ShowDialog()
            Dim frm As New FormPrincipal()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout

        Else
            MessageBox.Show("Usuario o Contraseña Incorrecta." + vbNewLine + "Por Favor intente nuevamente")
            txtcontraseña.Clear()
            txtcontraseña.Focus()
        End If
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUsuario.Clear()
        txtcontraseña.Clear()
        Me.Show()
        txtUsuario.Focus()
    End Sub

    Private Sub Lblolvidocontraseña_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Lblolvidocontraseña.LinkClicked
        Dim formrecoverpass As New RecuperarContraseña
        formrecoverpass.ShowDialog()

    End Sub

    'VER BIEN ESTO QUE NO ME ACUERDO QUE ES!!!
    'Private Sub Checkremember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Checkremember.CheckedChanged
    '    If Checkremember.Checked = True Then
    '        My.Settings.username = txtUsuario.Text
    '        My.Settings.password = txtcontraseña.Text
    '        My.Settings.Save()
    '        My.Settings.Reload()
    '    End If
    'End Sub

    'Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    txtUsuario.Text = My.Settings.username
    '    txtcontraseña.Text = My.Settings.password
    'End Sub
End Class