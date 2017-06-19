Public Class ListaEmpleados
    Public Lista As New List(Of Empleado)
    Public Sub New()

    End Sub

    'Public Function Nuevo(ByVal DNI As String, Nombre As String, ByVal Apellido As String, ByVal FechNac As Date, ByVal Email As String, ByVal Direccion As String, ByVal Ciudad As String, ByVal Pais As String, ByVal Telefono As Integer, ByVal Trabajo As String, ByVal Salario As Double, ByVal Restaurante As Integer)
    '    If GetPosEmpleado(Nombre) <> -1 Then Return 0
    '    Dim NuevoEmpleado As New Empleado
    '    NuevoEmpleado.Id = GetNewId()
    '    NuevoEmpleado.DNI = DNI
    '    NuevoEmpleado.Nombre = Nombre
    '    NuevoEmpleado.Apellido = Apellido
    '    NuevoEmpleado.FechNac = FechNac
    '    NuevoEmpleado.Email = Email
    '    NuevoEmpleado.Direccion = Direccion
    '    NuevoEmpleado.Ciudad = Ciudad
    '    NuevoEmpleado.Pais = Pais
    '    NuevoEmpleado.Telefono = Telefono
    '    NuevoEmpleado.Trabajo = Trabajo
    '    NuevoEmpleado.Salario = Salario
    '    NuevoEmpleado.Restaurante = Restaurante


    '    Lista.Add(NuevoEmpleado)
    '    Main.DBManager.AddNewEmployer(NuevoEmpleado)
    'End Function

    Public Function Buscar(ByVal Nombre As String, ByVal DNI As String) As Boolean
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre And Lista(i).DNI = DNI) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function Buscar(ByVal Nombre As String) As Boolean
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function BuscarDNI(ByVal DNI As String) As Boolean
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function BuscarDNIPos(ByVal DNI As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return i
            End If
        Next
        Return -1
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

    Public Function GetPosEmpleado(ByVal Nombre As String, ByVal DNI As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre And Lista(i).DNI = DNI) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetPosEmpleado(ByVal Nombre As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Nombre = Nombre) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetPosEmpleado(ByVal Id As Integer) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Id = Id) Then
                Return i
            End If
        Next
        Return -1
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
