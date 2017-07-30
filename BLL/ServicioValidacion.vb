Imports System.Text.RegularExpressions

Public Class ServicioValidacion

    Public Shared Function IsEmail(email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Public Shared Function IsLegajo(cuit As String) As Boolean
        Static LegajoExpression As New Regex("^\d{2}\-\d{8}\-\d{1}$")
        Return LegajoExpression.IsMatch(cuit)
    End Function

End Class