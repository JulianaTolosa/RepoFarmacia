Public Class Clientes

    Private dtCliente As New TesisDataSet.ClientesDataTable
    Private taCliente As New TesisDataSetTableAdapters.ClientesTableAdapter
    Private registro As TesisDataSet.ClientesRow

    Private Sub btnCerrarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TesisDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.TesisDataSet.Clientes)
        Me.dtCliente = Me.taCliente.GetData()
        DgClientes.DataSource = Me.dtCliente


    End Sub

   
    
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        AltaCliente.Show()
    End Sub
End Class