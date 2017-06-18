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
End Class
