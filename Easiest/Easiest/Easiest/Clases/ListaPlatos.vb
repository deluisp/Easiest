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

    Public Function GetPosPlato(ByVal Id As Integer) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Id = Id) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function Nuevo(ByVal Nombre As String, ByVal Descripcion As String, ByVal EsBebida As Integer, ByVal Precio As Double) As Integer
        If GetPosPlato(Nombre) <> -1 Then Return 0
        Dim NuevoPlato As New Plato
        NuevoPlato.Id = GetNewId()
        NuevoPlato.Nombre = Nombre
        NuevoPlato.Descripcion = Descripcion
        NuevoPlato.EsBebida = EsBebida
        NuevoPlato.Precio = Precio

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

    Public Function GetDescripcion(ByVal Nombre As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).Descripcion
            End If
        Next
        Return -1
    End Function

    Public Function GetPrecio(ByVal Nombre As String) As Double
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).Precio
            End If
        Next
        Return -1
    End Function

    Public Function GetEsBebida(ByVal Nombre As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).EsBebida
            End If
        Next
        Return -1
    End Function

    Public Function GetId(ByVal Nombre As String) As Double
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return Lista(i).Id
            End If
        Next
        Return -1
    End Function

    Public Function ModificarPlato(ByVal Id As Integer, ByVal NewNombre As String, ByVal NewDescripcion As String, ByVal NewEsBebida As String, ByVal NewPrecio As Double) As Integer
        Dim Pos As Integer = GetPosPlato(Id)
        If Pos = -1 Then Return 0

        Lista(Pos).Nombre = NewNombre
        Lista(Pos).Descripcion = NewDescripcion
        Lista(Pos).EsBebida = NewEsBebida
        Lista(Pos).Precio = NewPrecio

        Main.DBManager.ModificarPlato(Pos, Lista(Pos))
        Return 1
    End Function
End Class
