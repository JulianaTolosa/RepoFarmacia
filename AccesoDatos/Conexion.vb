Imports System.Data.SqlClient

Public MustInherit Class Conexion
    Private connectionString As String
    Protected Sub New()
        connectionString = "Data Source=ALUMN127\SQLEXPRESS;Initial Catalog=Tesis;Integrated Security=True"
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
