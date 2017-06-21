Public NotInheritable Class ListaIngredientes

    Public Shared Lista As New List(Of Ingrediente)

    Shared Sub New()

    End Sub

    Public Function GetPosIngrediente(ByVal Nombre As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetNombre(ByVal Id As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).Id = Id) Then
                Return Lista(i).Nombre
            End If
        Next
        Return -1
    End Function

    Public Function GetName(ByVal Nombre As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).Nombre
            End If
        Next
        Return Nothing
    End Function

    Public Function GetNewId() As Integer
        Dim Nuevo As Integer = -1
        For i = 0 To Lista.Count - 1
            If (Lista(i).Id > Nuevo) Then
                Nuevo = Lista(i).Id
            End If
        Next
        Return Nuevo + 1
    End Function

    Public Function Nuevo(ByVal Nombre As String, ByVal Tipo As Integer, ByVal Descripcion As String)
        If GetPosIngrediente(Nombre) <> -1 Then Return 0
        Dim NuevoIngrediente As New Ingrediente
        NuevoIngrediente.Id = GetNewId()
        NuevoIngrediente.Nombre = Nombre
        NuevoIngrediente.Tipo = Tipo
        NuevoIngrediente.Descripcion = Descripcion

        Lista.Add(NuevoIngrediente)
        Main.DBManager.AddNewIngrediente(NuevoIngrediente)
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
