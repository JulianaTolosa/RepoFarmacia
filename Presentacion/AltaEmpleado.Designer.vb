<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaEmpleado))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblAltaEmpleado = New System.Windows.Forms.Label()
        Me.PanelIzq = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblnombreusu = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblcontrasena = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblposicion = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.Cmbposicion = New System.Windows.Forms.ComboBox()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIzq.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Controls.Add(Me.lblAltaEmpleado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 45)
        Me.Panel1.TabIndex = 2
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(592, 12)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 15
        Me.btnCerrarForm.TabStop = False
        '
        'lblAltaEmpleado
        '
        Me.lblAltaEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAltaEmpleado.AutoSize = True
        Me.lblAltaEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaEmpleado.Location = New System.Drawing.Point(241, 10)
        Me.lblAltaEmpleado.Name = "lblAltaEmpleado"
        Me.lblAltaEmpleado.Size = New System.Drawing.Size(188, 24)
        Me.lblAltaEmpleado.TabIndex = 3
        Me.lblAltaEmpleado.Text = "NUEVO EMPLEADO"
        Me.lblAltaEmpleado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelIzq
        '
        Me.PanelIzq.Controls.Add(Me.PictureBox1)
        Me.PanelIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzq.Location = New System.Drawing.Point(0, 45)
        Me.PanelIzq.Name = "PanelIzq"
        Me.PanelIzq.Size = New System.Drawing.Size(310, 319)
        Me.PanelIzq.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(340, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 20)
        Me.TextBox1.TabIndex = 8
        '
        'lblnombreusu
        '
        Me.lblnombreusu.AutoSize = True
        Me.lblnombreusu.Location = New System.Drawing.Point(340, 60)
        Me.lblnombreusu.Name = "lblnombreusu"
        Me.lblnombreusu.Size = New System.Drawing.Size(109, 13)
        Me.lblnombreusu.TabIndex = 7
        Me.lblnombreusu.Text = "NOMBRE USUARIO:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(340, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(190, 20)
        Me.TextBox2.TabIndex = 10
        '
        'lblcontrasena
        '
        Me.lblcontrasena.AutoSize = True
        Me.lblcontrasena.Location = New System.Drawing.Point(340, 110)
        Me.lblcontrasena.Name = "lblcontrasena"
        Me.lblcontrasena.Size = New System.Drawing.Size(84, 13)
        Me.lblcontrasena.TabIndex = 9
        Me.lblcontrasena.Text = "CONTRASEÑA:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(340, 180)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(190, 20)
        Me.TextBox3.TabIndex = 12
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(340, 160)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(57, 13)
        Me.lblnombre.TabIndex = 11
        Me.lblnombre.Text = "NOMBRE:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(340, 230)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(190, 20)
        Me.TextBox4.TabIndex = 14
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Location = New System.Drawing.Point(340, 210)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(62, 13)
        Me.lblapellido.TabIndex = 13
        Me.lblapellido.Text = "APELLIDO:"
        '
        'lblposicion
        '
        Me.lblposicion.AutoSize = True
        Me.lblposicion.Location = New System.Drawing.Point(340, 260)
        Me.lblposicion.Name = "lblposicion"
        Me.lblposicion.Size = New System.Drawing.Size(61, 13)
        Me.lblposicion.TabIndex = 15
        Me.lblposicion.Text = "POSICIÓN:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(340, 330)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(190, 20)
        Me.TextBox6.TabIndex = 18
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(340, 310)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(56, 13)
        Me.lblcorreo.TabIndex = 17
        Me.lblcorreo.Text = "CORREO:"
        '
        'Cmbposicion
        '
        Me.Cmbposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbposicion.FormattingEnabled = True
        Me.Cmbposicion.Items.AddRange(New Object() {"Administrador", "Encargado", "Vendedor"})
        Me.Cmbposicion.Location = New System.Drawing.Point(340, 285)
        Me.Cmbposicion.Name = "Cmbposicion"
        Me.Cmbposicion.Size = New System.Drawing.Size(190, 21)
        Me.Cmbposicion.TabIndex = 19
        '
        'Btnagregar
        '
        Me.Btnagregar.Location = New System.Drawing.Point(530, 100)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.Btnagregar.TabIndex = 20
        Me.Btnagregar.Text = "AGREGAR"
        Me.Btnagregar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(530, 150)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 21
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'AltaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 364)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.Cmbposicion)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.lblposicion)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblcontrasena)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblnombreusu)
        Me.Controls.Add(Me.PanelIzq)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaEmpleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIzq.ResumeLayout(False)
        Me.PanelIzq.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents lblAltaEmpleado As System.Windows.Forms.Label
    Friend WithEvents PanelIzq As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblnombreusu As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblcontrasena As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblapellido As System.Windows.Forms.Label
    Friend WithEvents lblposicion As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents lblcorreo As System.Windows.Forms.Label
    Friend WithEvents Cmbposicion As System.Windows.Forms.ComboBox
    Friend WithEvents Btnagregar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
