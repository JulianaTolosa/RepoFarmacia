<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editarempleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editarempleado))
        Me.PanelTOP = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.Panelizq = New System.Windows.Forms.Panel()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.Lblposicion3 = New System.Windows.Forms.Label()
        Me.LblPosicioneditar = New System.Windows.Forms.Label()
        Me.Lblcorreo3 = New System.Windows.Forms.Label()
        Me.Lblapellido3 = New System.Windows.Forms.Label()
        Me.LblNombre3 = New System.Windows.Forms.Label()
        Me.LkllblEditarperfil = New System.Windows.Forms.LinkLabel()
        Me.LblCorreoeditar = New System.Windows.Forms.Label()
        Me.Lblapellidoeditar = New System.Windows.Forms.Label()
        Me.Lblnombreeditar = New System.Windows.Forms.Label()
        Me.LblUsuarioeditar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelder = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Lkllbleditar = New System.Windows.Forms.LinkLabel()
        Me.Txtactualcontrasena = New System.Windows.Forms.TextBox()
        Me.Txtconfirmar = New System.Windows.Forms.TextBox()
        Me.Txtcontrasena = New System.Windows.Forms.TextBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Txtapellido = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtnomusuario = New System.Windows.Forms.TextBox()
        Me.Lblactual = New System.Windows.Forms.Label()
        Me.Lblconfirmacontrasena = New System.Windows.Forms.Label()
        Me.LblContrasena = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Lblnombreusuario = New System.Windows.Forms.Label()
        Me.PanelTOP.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelizq.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelder.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTOP
        '
        Me.PanelTOP.Controls.Add(Me.btnCerrarForm)
        Me.PanelTOP.Controls.Add(Me.lblEmpleados)
        Me.PanelTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTOP.Location = New System.Drawing.Point(0, 0)
        Me.PanelTOP.Name = "PanelTOP"
        Me.PanelTOP.Size = New System.Drawing.Size(623, 45)
        Me.PanelTOP.TabIndex = 1
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(595, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 15
        Me.btnCerrarForm.TabStop = False
        '
        'lblEmpleados
        '
        Me.lblEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.Location = New System.Drawing.Point(212, 10)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(188, 24)
        Me.lblEmpleados.TabIndex = 3
        Me.lblEmpleados.Text = "EDITAR EMPLEADO"
        Me.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panelizq
        '
        Me.Panelizq.Controls.Add(Me.Lblusuario)
        Me.Panelizq.Controls.Add(Me.Lblposicion3)
        Me.Panelizq.Controls.Add(Me.LblPosicioneditar)
        Me.Panelizq.Controls.Add(Me.Lblcorreo3)
        Me.Panelizq.Controls.Add(Me.Lblapellido3)
        Me.Panelizq.Controls.Add(Me.LblNombre3)
        Me.Panelizq.Controls.Add(Me.LkllblEditarperfil)
        Me.Panelizq.Controls.Add(Me.LblCorreoeditar)
        Me.Panelizq.Controls.Add(Me.Lblapellidoeditar)
        Me.Panelizq.Controls.Add(Me.Lblnombreeditar)
        Me.Panelizq.Controls.Add(Me.LblUsuarioeditar)
        Me.Panelizq.Controls.Add(Me.PictureBox1)
        Me.Panelizq.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelizq.Location = New System.Drawing.Point(0, 45)
        Me.Panelizq.Name = "Panelizq"
        Me.Panelizq.Size = New System.Drawing.Size(280, 436)
        Me.Panelizq.TabIndex = 2
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = True
        Me.Lblusuario.Location = New System.Drawing.Point(80, 60)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(41, 13)
        Me.Lblusuario.TabIndex = 22
        Me.Lblusuario.Text = "usuario"
        '
        'Lblposicion3
        '
        Me.Lblposicion3.AutoSize = True
        Me.Lblposicion3.Location = New System.Drawing.Point(80, 220)
        Me.Lblposicion3.Name = "Lblposicion3"
        Me.Lblposicion3.Size = New System.Drawing.Size(46, 13)
        Me.Lblposicion3.TabIndex = 21
        Me.Lblposicion3.Text = "posicion"
        '
        'LblPosicioneditar
        '
        Me.LblPosicioneditar.AutoSize = True
        Me.LblPosicioneditar.Location = New System.Drawing.Point(80, 200)
        Me.LblPosicioneditar.Name = "LblPosicioneditar"
        Me.LblPosicioneditar.Size = New System.Drawing.Size(61, 13)
        Me.LblPosicioneditar.TabIndex = 20
        Me.LblPosicioneditar.Text = "POSICIÓN:"
        '
        'Lblcorreo3
        '
        Me.Lblcorreo3.AutoSize = True
        Me.Lblcorreo3.Location = New System.Drawing.Point(80, 180)
        Me.Lblcorreo3.Name = "Lblcorreo3"
        Me.Lblcorreo3.Size = New System.Drawing.Size(37, 13)
        Me.Lblcorreo3.TabIndex = 19
        Me.Lblcorreo3.Text = "correo"
        '
        'Lblapellido3
        '
        Me.Lblapellido3.AutoSize = True
        Me.Lblapellido3.Location = New System.Drawing.Point(80, 140)
        Me.Lblapellido3.Name = "Lblapellido3"
        Me.Lblapellido3.Size = New System.Drawing.Size(43, 13)
        Me.Lblapellido3.TabIndex = 18
        Me.Lblapellido3.Text = "apellido"
        '
        'LblNombre3
        '
        Me.LblNombre3.AutoSize = True
        Me.LblNombre3.Location = New System.Drawing.Point(80, 100)
        Me.LblNombre3.Name = "LblNombre3"
        Me.LblNombre3.Size = New System.Drawing.Size(42, 13)
        Me.LblNombre3.TabIndex = 17
        Me.LblNombre3.Text = "nombre"
        '
        'LkllblEditarperfil
        '
        Me.LkllblEditarperfil.AutoSize = True
        Me.LkllblEditarperfil.Location = New System.Drawing.Point(70, 260)
        Me.LkllblEditarperfil.Name = "LkllblEditarperfil"
        Me.LkllblEditarperfil.Size = New System.Drawing.Size(87, 13)
        Me.LkllblEditarperfil.TabIndex = 15
        Me.LkllblEditarperfil.TabStop = True
        Me.LkllblEditarperfil.Text = "EDITAR PERFIL"
        '
        'LblCorreoeditar
        '
        Me.LblCorreoeditar.AutoSize = True
        Me.LblCorreoeditar.Location = New System.Drawing.Point(80, 160)
        Me.LblCorreoeditar.Name = "LblCorreoeditar"
        Me.LblCorreoeditar.Size = New System.Drawing.Size(56, 13)
        Me.LblCorreoeditar.TabIndex = 11
        Me.LblCorreoeditar.Text = "CORREO:"
        '
        'Lblapellidoeditar
        '
        Me.Lblapellidoeditar.AutoSize = True
        Me.Lblapellidoeditar.Location = New System.Drawing.Point(80, 120)
        Me.Lblapellidoeditar.Name = "Lblapellidoeditar"
        Me.Lblapellidoeditar.Size = New System.Drawing.Size(62, 13)
        Me.Lblapellidoeditar.TabIndex = 10
        Me.Lblapellidoeditar.Text = "APELLIDO:"
        '
        'Lblnombreeditar
        '
        Me.Lblnombreeditar.AutoSize = True
        Me.Lblnombreeditar.Location = New System.Drawing.Point(80, 80)
        Me.Lblnombreeditar.Name = "Lblnombreeditar"
        Me.Lblnombreeditar.Size = New System.Drawing.Size(57, 13)
        Me.Lblnombreeditar.TabIndex = 9
        Me.Lblnombreeditar.Text = "NOMBRE:"
        '
        'LblUsuarioeditar
        '
        Me.LblUsuarioeditar.AutoSize = True
        Me.LblUsuarioeditar.Location = New System.Drawing.Point(80, 40)
        Me.LblUsuarioeditar.Name = "LblUsuarioeditar"
        Me.LblUsuarioeditar.Size = New System.Drawing.Size(59, 13)
        Me.LblUsuarioeditar.TabIndex = 8
        Me.LblUsuarioeditar.Text = "USUARIO:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panelder
        '
        Me.Panelder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panelder.Controls.Add(Me.BtnGuardar)
        Me.Panelder.Controls.Add(Me.BtnCancelar)
        Me.Panelder.Controls.Add(Me.Lkllbleditar)
        Me.Panelder.Controls.Add(Me.Txtactualcontrasena)
        Me.Panelder.Controls.Add(Me.Txtconfirmar)
        Me.Panelder.Controls.Add(Me.Txtcontrasena)
        Me.Panelder.Controls.Add(Me.Txtcorreo)
        Me.Panelder.Controls.Add(Me.Txtapellido)
        Me.Panelder.Controls.Add(Me.Txtnombre)
        Me.Panelder.Controls.Add(Me.Txtnomusuario)
        Me.Panelder.Controls.Add(Me.Lblactual)
        Me.Panelder.Controls.Add(Me.Lblconfirmacontrasena)
        Me.Panelder.Controls.Add(Me.LblContrasena)
        Me.Panelder.Controls.Add(Me.LblCorreo)
        Me.Panelder.Controls.Add(Me.LblApellido)
        Me.Panelder.Controls.Add(Me.LblNombre)
        Me.Panelder.Controls.Add(Me.Lblnombreusuario)
        Me.Panelder.Location = New System.Drawing.Point(300, 45)
        Me.Panelder.Name = "Panelder"
        Me.Panelder.Size = New System.Drawing.Size(323, 435)
        Me.Panelder.TabIndex = 3
        Me.Panelder.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Lime
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(170, 380)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(130, 40)
        Me.BtnGuardar.TabIndex = 16
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(30, 380)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(130, 40)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Lkllbleditar
        '
        Me.Lkllbleditar.AutoSize = True
        Me.Lkllbleditar.Location = New System.Drawing.Point(110, 220)
        Me.Lkllbleditar.Name = "Lkllbleditar"
        Me.Lkllbleditar.Size = New System.Drawing.Size(47, 13)
        Me.Lkllbleditar.TabIndex = 14
        Me.Lkllbleditar.TabStop = True
        Me.Lkllbleditar.Text = "EDITAR"
        '
        'Txtactualcontrasena
        '
        Me.Txtactualcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtactualcontrasena.Location = New System.Drawing.Point(30, 350)
        Me.Txtactualcontrasena.Name = "Txtactualcontrasena"
        Me.Txtactualcontrasena.Size = New System.Drawing.Size(270, 13)
        Me.Txtactualcontrasena.TabIndex = 13
        '
        'Txtconfirmar
        '
        Me.Txtconfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtconfirmar.Location = New System.Drawing.Point(30, 290)
        Me.Txtconfirmar.Name = "Txtconfirmar"
        Me.Txtconfirmar.Size = New System.Drawing.Size(270, 13)
        Me.Txtconfirmar.TabIndex = 12
        '
        'Txtcontrasena
        '
        Me.Txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcontrasena.Location = New System.Drawing.Point(30, 240)
        Me.Txtcontrasena.Name = "Txtcontrasena"
        Me.Txtcontrasena.Size = New System.Drawing.Size(270, 13)
        Me.Txtcontrasena.TabIndex = 11
        '
        'Txtcorreo
        '
        Me.Txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcorreo.Location = New System.Drawing.Point(30, 190)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(270, 13)
        Me.Txtcorreo.TabIndex = 10
        '
        'Txtapellido
        '
        Me.Txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtapellido.Location = New System.Drawing.Point(30, 140)
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(270, 13)
        Me.Txtapellido.TabIndex = 9
        '
        'Txtnombre
        '
        Me.Txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombre.Location = New System.Drawing.Point(30, 90)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(270, 13)
        Me.Txtnombre.TabIndex = 8
        '
        'Txtnomusuario
        '
        Me.Txtnomusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnomusuario.Location = New System.Drawing.Point(30, 40)
        Me.Txtnomusuario.Name = "Txtnomusuario"
        Me.Txtnomusuario.Size = New System.Drawing.Size(270, 13)
        Me.Txtnomusuario.TabIndex = 7
        '
        'Lblactual
        '
        Me.Lblactual.AutoSize = True
        Me.Lblactual.Location = New System.Drawing.Point(30, 330)
        Me.Lblactual.Name = "Lblactual"
        Me.Lblactual.Size = New System.Drawing.Size(129, 13)
        Me.Lblactual.TabIndex = 6
        Me.Lblactual.Text = "ACTUAL CONTRASEÑA:"
        '
        'Lblconfirmacontrasena
        '
        Me.Lblconfirmacontrasena.AutoSize = True
        Me.Lblconfirmacontrasena.Location = New System.Drawing.Point(30, 270)
        Me.Lblconfirmacontrasena.Name = "Lblconfirmacontrasena"
        Me.Lblconfirmacontrasena.Size = New System.Drawing.Size(161, 13)
        Me.Lblconfirmacontrasena.TabIndex = 5
        Me.Lblconfirmacontrasena.Text = "CONFIRMA TU CONTRASEÑA:"
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.Location = New System.Drawing.Point(30, 220)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(84, 13)
        Me.LblContrasena.TabIndex = 4
        Me.LblContrasena.Text = "CONTRASEÑA:"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(30, 170)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(56, 13)
        Me.LblCorreo.TabIndex = 3
        Me.LblCorreo.Text = "CORREO:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(30, 120)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(62, 13)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "APELLIDO:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(30, 70)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "NOMBRE:"
        '
        'Lblnombreusuario
        '
        Me.Lblnombreusuario.AutoSize = True
        Me.Lblnombreusuario.Location = New System.Drawing.Point(30, 20)
        Me.Lblnombreusuario.Name = "Lblnombreusuario"
        Me.Lblnombreusuario.Size = New System.Drawing.Size(59, 13)
        Me.Lblnombreusuario.TabIndex = 0
        Me.Lblnombreusuario.Text = "USUARIO:"
        Me.Lblnombreusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Editarempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 481)
        Me.Controls.Add(Me.Panelder)
        Me.Controls.Add(Me.Panelizq)
        Me.Controls.Add(Me.PanelTOP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Editarempleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editarempleado"
        Me.PanelTOP.ResumeLayout(False)
        Me.PanelTOP.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelizq.ResumeLayout(False)
        Me.Panelizq.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelder.ResumeLayout(False)
        Me.Panelder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTOP As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents Panelizq As System.Windows.Forms.Panel
    Friend WithEvents Panelder As System.Windows.Forms.Panel
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Lblnombreusuario As System.Windows.Forms.Label
    Friend WithEvents LblCorreo As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblContrasena As System.Windows.Forms.Label
    Friend WithEvents Lblactual As System.Windows.Forms.Label
    Friend WithEvents Lblconfirmacontrasena As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LkllblEditarperfil As System.Windows.Forms.LinkLabel
    Friend WithEvents LblCorreoeditar As System.Windows.Forms.Label
    Friend WithEvents Lblapellidoeditar As System.Windows.Forms.Label
    Friend WithEvents Lblnombreeditar As System.Windows.Forms.Label
    Friend WithEvents LblUsuarioeditar As System.Windows.Forms.Label
    Friend WithEvents Lkllbleditar As System.Windows.Forms.LinkLabel
    Friend WithEvents Txtactualcontrasena As System.Windows.Forms.TextBox
    Friend WithEvents Txtconfirmar As System.Windows.Forms.TextBox
    Friend WithEvents Txtcontrasena As System.Windows.Forms.TextBox
    Friend WithEvents Txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents Txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtnomusuario As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Lblcorreo3 As System.Windows.Forms.Label
    Friend WithEvents Lblapellido3 As System.Windows.Forms.Label
    Friend WithEvents LblNombre3 As System.Windows.Forms.Label
    Friend WithEvents LblPosicioneditar As System.Windows.Forms.Label
    Friend WithEvents Lblposicion3 As System.Windows.Forms.Label
    Friend WithEvents Lblusuario As System.Windows.Forms.Label
End Class
