Public NotInheritable Class ListaIngredientesCategorias

    Public Shared Lista As New List(Of IngredienteCategoria)

    Shared Sub New()

    End Sub

    Public Function Buscar(ByVal Nombre As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).Id
            End If
        Next
        Return False
    End Function

    Public Function GetId(ByVal Nombre As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).Id
            End If
        Next
        Return -1
    End Function

End Class
