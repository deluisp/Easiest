Public NotInheritable Class ListaPlatosIngredientes
    Public Shared Lista As New List(Of PlatoIngrediente)
    Shared Sub New()
    End Sub

    Public Function Nuevo(ByVal IdPlato As Integer, ByVal IdIngrediente As Integer)
        Dim NuevoPlatoIngrediente As New PlatoIngrediente
        NuevoPlatoIngrediente.IdPlato = IdPlato
        NuevoPlatoIngrediente.IdIngrediente = IdIngrediente

        Lista.Add(NuevoPlatoIngrediente)
        Main.DBManager.AddNewPlatoIngrediente(NuevoPlatoIngrediente)
    End Function

    Public Function GetIngredientes(ByVal IdPlato As Integer) As String()
        Dim C As Integer = 0
        For i = 0 To Lista.Count - 1
            If (Lista(i).IdPlato = IdPlato) Then
                C = C + 1
            End If
        Next
        Dim Ingredientes As String()
        ReDim Ingredientes(C - 1)
        C = 0
        For i = 0 To Lista.Count - 1
            If (Lista(i).IdPlato = IdPlato) Then
                Ingredientes(C) = Main.ListaIngredientes.GetNombre(Lista(i).IdIngrediente)
                C = C + 1
            End If
        Next
        Return Ingredientes
    End Function

    Public Function BorrarIngredientes(ByVal IdPlato As Integer)
        For i = 0 To Lista.Count - 1
            If (Lista(i).IdPlato = IdPlato) Then
                Lista.RemoveAt(i)
                Main.DBManager.DeletePlatoIngrediente(i)
                Return True
            End If
        Next
        Return False
    End Function
End Class
