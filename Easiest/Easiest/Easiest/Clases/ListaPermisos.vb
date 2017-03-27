Public Class ListaPermisos

    Public Shared Lista As New List(Of Permiso)
    Shared Sub New()

    End Sub

    Public Function BuscarPermiso(ByVal IdUsuario As Integer, ByVal Tipo As Integer) As Boolean
        For i = 0 To Lista.Count - 1
            If (Lista(i).IdUsuario = IdUsuario And Lista(i).Tipo = Tipo) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function Nuevo(ByVal IdUsuario As Integer, ByVal Tipo As Integer)
        Dim NuevoPermiso As New Permiso
        NuevoPermiso.Id = GetNewId()
        NuevoPermiso.IdUsuario = IdUsuario
        NuevoPermiso.Tipo = Tipo

        Lista.Add(NuevoPermiso)
        Main.DBManager.AddNewPermiso(NuevoPermiso)
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

    Public Function BorrarPermisos(ByVal IdUsuario As Integer)
        For i = 0 To Lista.Count - 1
            If (Lista(i).IdUsuario = IdUsuario) Then
                Lista.RemoveAt(i)
                Main.DBManager.DeletePermiso(i)
                Return True
            End If
        Next
        Return False
    End Function
End Class
