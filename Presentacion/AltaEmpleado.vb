Imports System.Data.SqlClient
Imports System.Data.DataTable


Public Class AltaEmpleado

    Dim DgEmpleados As Object
    Dim dtusuario As Object

    Private Sub btnCerrarForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub




    Private Sub AltaEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnagregar.Click

        Dim nombreusuario As String = TextBox1.Text
        Dim contrasena As String = TextBox2.Text
        Dim nombre As String = TextBox3.Text
        Dim apellido As String = TextBox4.Text
        Dim posicion As String = Cmbposicion.Text
        Dim correo As String = TextBox6.Text

        Dim query As String = "Insert into Usuario values (@nombreusuario,@contrasena,@nombre,@apellido,@posicion,@correo)"

        Using con As SqlConnection = New SqlConnection(Utilidades.ConnectionString)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@nombreusuario", nombreusuario)
                cmd.Parameters.AddWithValue("@contrasena", contrasena)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@apellido", apellido)
                cmd.Parameters.AddWithValue("@posicion", posicion)
                cmd.Parameters.AddWithValue("@correo", correo)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Usuario registrado correctamente")
                'BinData()


            End Using
        End Using
    End Sub

    'Private Sub BinData()
    '    Dim query As String = "Select * from Usuario"
    '    Using con As SqlConnection = New SqlConnection("Data Source=ALUMN127\SQLEXPRESS;Initial Catalog=Tesis;Integrated Security=True")
    '        Using cmd As SqlCommand = New SqlCommand(query, con)
    '            Using da As New SqlDataAdapter()
    '                da.SelectCommand = cmd
    '                Using dt As New DataTable
    '                    da.Fill(dt)
    '                    Empleados.DgEmpleados.DataSource = dt
    '                    Empleados.DgEmpleados.
    '                End Using
    '            End Using
    '        End Using
    '    End Using

    'End Sub

End Class