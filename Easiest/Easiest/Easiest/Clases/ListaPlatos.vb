Public NotInheritable Class ListaPlatos

    Public Shared Lista As New List(Of Plato)

    Shared Sub New()
    End Sub

    Public Function GetNewId() As Integer
        Dim Nuevo As Integer = -1
        For i = 0 To Lista.Count - 1
            If (Lista(i).Id > Nuevo) Then
                Nuevo = Lista(i).Id
            End If
        Next
        Return Nuevo + 1
    End Function

    Public Function GetPosPlato(ByVal Nombre As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function Nuevo(ByVal Nombre As String, ByVal Descripcion As String, ByVal EsBebida As Integer) As Integer
        If GetPosPlato(Nombre) <> -1 Then Return 0
        Dim NuevoPlato As New Plato
        NuevoPlato.Id = GetNewId()
        NuevoPlato.Nombre = Nombre
        NuevoPlato.Descripcion = Descripcion
        NuevoPlato.EsBebida = EsBebida

        Lista.Add(NuevoPlato)
        Main.DBManager.AddNewPlato(NuevoPlato)

        Return NuevoPlato.Id
    End Function

    Public Function Buscar(ByVal Nombre As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).Id
            End If
        Next
        Return False
    End Function
End Class
