<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.components = New System.ComponentModel.Container()
        Dim lblPosicion As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.TesisDataSet = New Presentacion.TesisDataSet()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.cmbposicion = New System.Windows.Forms.ComboBox()
        Me.Txtapellido = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtcontrasena = New System.Windows.Forms.TextBox()
        Me.Txtnombreusuario = New System.Windows.Forms.TextBox()
        Me.Panelcentro = New System.Windows.Forms.Panel()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblcontrasena = New System.Windows.Forms.Label()
        Me.Lblnombreusuario = New System.Windows.Forms.Label()
        Me.DgEmpleados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContrasenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New Presentacion.TesisDataSetTableAdapters.UsuarioTableAdapter()
        lblPosicion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TesisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelcentro.SuspendLayout()
        CType(Me.DgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPosicion
        '
        lblPosicion.AutoSize = True
        lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPosicion.Location = New System.Drawing.Point(20, 170)
        lblPosicion.Name = "lblPosicion"
        lblPosicion.Size = New System.Drawing.Size(72, 20)
        lblPosicion.TabIndex = 15
        lblPosicion.Text = "Posicion:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrarForm)
        Me.Panel1.Controls.Add(Me.lblEmpleados)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 45)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarForm.Image = CType(resources.GetObject("btnCerrarForm.Image"), System.Drawing.Image)
        Me.btnCerrarForm.Location = New System.Drawing.Point(992, 12)
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
        Me.lblEmpleados.Location = New System.Drawing.Point(450, 10)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(127, 24)
        Me.lblEmpleados.TabIndex = 3
        Me.lblEmpleados.Text = "EMPLEADOS"
        Me.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TesisDataSet
        '
        Me.TesisDataSet.DataSetName = "TesisDataSet"
        Me.TesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btnnuevo
        '
        Me.Btnnuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnnuevo.Location = New System.Drawing.Point(540, 22)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(90, 40)
        Me.Btnnuevo.TabIndex = 6
        Me.Btnnuevo.Text = "NUEVO"
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(540, 72)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(90, 40)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Btnborrar
        '
        Me.Btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnborrar.Location = New System.Drawing.Point(540, 122)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(90, 40)
        Me.Btnborrar.TabIndex = 8
        Me.Btnborrar.Text = "BORRAR"
        Me.Btnborrar.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Location = New System.Drawing.Point(540, 172)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(90, 40)
        Me.BtnImprimir.TabIndex = 9
        Me.BtnImprimir.Text = "IMPRIMIR"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Txtcorreo
        '
        Me.Txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcorreo.Location = New System.Drawing.Point(140, 140)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(250, 19)
        Me.Txtcorreo.TabIndex = 4
        '
        'cmbposicion
        '
        Me.cmbposicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbposicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbposicion.FormattingEnabled = True
        Me.cmbposicion.Items.AddRange(New Object() {"Administrador", "Encargado", "Vendedor"})
        Me.cmbposicion.Location = New System.Drawing.Point(140, 170)
        Me.cmbposicion.Name = "cmbposicion"
        Me.cmbposicion.Size = New System.Drawing.Size(150, 28)
        Me.cmbposicion.TabIndex = 5
        '
        'Txtapellido
        '
        Me.Txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtapellido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtapellido.Location = New System.Drawing.Point(140, 110)
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(250, 19)
        Me.Txtapellido.TabIndex = 3
        '
        'Txtnombre
        '
        Me.Txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombre.Location = New System.Drawing.Point(140, 80)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(250, 19)
        Me.Txtnombre.TabIndex = 2
        '
        'Txtcontrasena
        '
        Me.Txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcontrasena.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcontrasena.Location = New System.Drawing.Point(140, 50)
        Me.Txtcontrasena.Name = "Txtcontrasena"
        Me.Txtcontrasena.Size = New System.Drawing.Size(150, 19)
        Me.Txtcontrasena.TabIndex = 1
        '
        'Txtnombreusuario
        '
        Me.Txtnombreusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtnombreusuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txtnombreusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombreusuario.Location = New System.Drawing.Point(140, 20)
        Me.Txtnombreusuario.Name = "Txtnombreusuario"
        Me.Txtnombreusuario.Size = New System.Drawing.Size(150, 19)
        Me.Txtnombreusuario.TabIndex = 0
        '
        'Panelcentro
        '
        Me.Panelcentro.Controls.Add(Me.LblCorreo)
        Me.Panelcentro.Controls.Add(Me.LblApellido)
        Me.Panelcentro.Controls.Add(Me.Lblnombre)
        Me.Panelcentro.Controls.Add(Me.Lblcontrasena)
        Me.Panelcentro.Controls.Add(Me.Lblnombreusuario)
        Me.Panelcentro.Controls.Add(Me.Txtnombreusuario)
        Me.Panelcentro.Controls.Add(Me.Txtcontrasena)
        Me.Panelcentro.Controls.Add(Me.Txtnombre)
        Me.Panelcentro.Controls.Add(Me.Txtapellido)
        Me.Panelcentro.Controls.Add(lblPosicion)
        Me.Panelcentro.Controls.Add(Me.cmbposicion)
        Me.Panelcentro.Controls.Add(Me.Txtcorreo)
        Me.Panelcentro.Controls.Add(Me.BtnImprimir)
        Me.Panelcentro.Controls.Add(Me.Btnborrar)
        Me.Panelcentro.Controls.Add(Me.BtnEditar)
        Me.Panelcentro.Controls.Add(Me.Btnnuevo)
        Me.Panelcentro.Location = New System.Drawing.Point(0, 45)
        Me.Panelcentro.Name = "Panelcentro"
        Me.Panelcentro.Size = New System.Drawing.Size(1000, 228)
        Me.Panelcentro.TabIndex = 1
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.Location = New System.Drawing.Point(20, 140)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(61, 20)
        Me.LblCorreo.TabIndex = 23
        Me.LblCorreo.Text = "Correo:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(20, 110)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(69, 20)
        Me.LblApellido.TabIndex = 22
        Me.LblApellido.Text = "Apellido:"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombre.Location = New System.Drawing.Point(20, 80)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(69, 20)
        Me.Lblnombre.TabIndex = 21
        Me.Lblnombre.Text = "Nombre:"
        '
        'Lblcontrasena
        '
        Me.Lblcontrasena.AutoSize = True
        Me.Lblcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcontrasena.Location = New System.Drawing.Point(20, 50)
        Me.Lblcontrasena.Name = "Lblcontrasena"
        Me.Lblcontrasena.Size = New System.Drawing.Size(96, 20)
        Me.Lblcontrasena.TabIndex = 20
        Me.Lblcontrasena.Text = "Contraseña:"
        '
        'Lblnombreusuario
        '
        Me.Lblnombreusuario.AutoSize = True
        Me.Lblnombreusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombreusuario.Location = New System.Drawing.Point(20, 20)
        Me.Lblnombreusuario.Name = "Lblnombreusuario"
        Me.Lblnombreusuario.Size = New System.Drawing.Size(68, 20)
        Me.Lblnombreusuario.TabIndex = 19
        Me.Lblnombreusuario.Text = "Usuario:"
        '
        'DgEmpleados
        '
        Me.DgEmpleados.AutoGenerateColumns = False
        Me.DgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ContrasenaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.PosicionDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn})
        Me.DgEmpleados.DataSource = Me.UsuarioBindingSource
        Me.DgEmpleados.Location = New System.Drawing.Point(20, 290)
        Me.DgEmpleados.Name = "DgEmpleados"
        Me.DgEmpleados.Size = New System.Drawing.Size(729, 230)
        Me.DgEmpleados.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nombreusuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 110
        '
        'ContrasenaDataGridViewTextBoxColumn
        '
        Me.ContrasenaDataGridViewTextBoxColumn.DataPropertyName = "contrasena"
        Me.ContrasenaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContrasenaDataGridViewTextBoxColumn.Name = "ContrasenaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'PosicionDataGridViewTextBoxColumn
        '
        Me.PosicionDataGridViewTextBoxColumn.DataPropertyName = "Posicion"
        Me.PosicionDataGridViewTextBoxColumn.HeaderText = "Posicion"
        Me.PosicionDataGridViewTextBoxColumn.Name = "PosicionDataGridViewTextBoxColumn"
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 175
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.TesisDataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1020, 540)
        Me.Controls.Add(Me.DgEmpleados)
        Me.Controls.Add(Me.Panelcentro)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TesisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelcentro.ResumeLayout(False)
        Me.Panelcentro.PerformLayout()
        CType(Me.DgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents btnCerrarForm As System.Windows.Forms.PictureBox
    Friend WithEvents NombreusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TesisDataSet As Presentacion.TesisDataSet
    Friend WithEvents Btnnuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Btnborrar As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents Txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents cmbposicion As System.Windows.Forms.ComboBox
    Friend WithEvents Txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Txtcontrasena As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombreusuario As System.Windows.Forms.TextBox
    Friend WithEvents Panelcentro As System.Windows.Forms.Panel
    Friend WithEvents LblCorreo As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents Lblcontrasena As System.Windows.Forms.Label
    Friend WithEvents Lblnombreusuario As System.Windows.Forms.Label
    Friend WithEvents DgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As Presentacion.TesisDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContrasenaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PosicionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
