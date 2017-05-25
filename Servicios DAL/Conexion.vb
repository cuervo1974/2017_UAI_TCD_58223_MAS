Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion
    Shared Function GetObjConnection() As SqlConnection
        Return New SqlConnection(ConfigurationManager.ConnectionStrings("SGISI").ConnectionString)
    End Function

End Class