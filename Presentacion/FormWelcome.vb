Imports CapaComun

Public Class FormWelcome

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1

        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If

    End Sub

    Private Sub Bienvenida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsername.Text = ActiveUser.Nombre & " " & ActiveUser.Apellido
        ProgressBar1.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub

    
End Class