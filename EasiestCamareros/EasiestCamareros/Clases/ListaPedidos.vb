Public NotInheritable Class ListaPedidos
    Public Shared Lista As New List(Of Pedido)

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

    Public Function Nuevo(ByVal Fecha As Date, ByVal Mesa As Integer, ByVal IdEmpleado As Integer) As Integer
        Dim NuevoPedido As New Pedido
        NuevoPedido.Id = GetNewId()
        NuevoPedido.Fecha = Fecha
        NuevoPedido.Mesa = Mesa
        NuevoPedido.Empleado = IdEmpleado

        Lista.Add(NuevoPedido)
        Main.DBManager.AddNewPedido(NuevoPedido)

        Return NuevoPedido.Id
    End Function
End Class
