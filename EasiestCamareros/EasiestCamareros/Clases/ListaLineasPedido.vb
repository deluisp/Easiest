Public NotInheritable Class ListaLineasPedido
    Public Shared Lista As New List(Of LineaPedido)

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

    Public Function Nuevo(ByVal IdPedido As Integer, ByVal IdPlato As Integer, ByVal Cantidad As Integer)
        Dim NuevaLineaPedido As New LineaPedido
        NuevaLineaPedido.Id = GetNewId()
        NuevaLineaPedido.IdPedido = IdPedido
        NuevaLineaPedido.IdPlato = IdPlato
        NuevaLineaPedido.Cantidad = Cantidad
        NuevaLineaPedido.Total = Main.ListaPlatos.GetPrecio(IdPlato) * Cantidad

        Lista.Add(NuevaLineaPedido)
        Main.DBManager.AddNewLineaPedido(NuevaLineaPedido)
    End Function
End Class
