Public Class ListaEmpleados

    Public Lista As New List(Of Empleado)
    Public Sub New()

    End Sub

    Public Function Nuevo(ByVal DNI As String, Nombre As String, ByVal Apellido As String, ByVal FechNac As Date, ByVal Email As String, ByVal Direccion As String, ByVal Ciudad As String, ByVal Pais As String, ByVal Telefono As Integer, ByVal Trabajo As String, ByVal Salario As Double, ByVal Restaurante As Integer)
        If GetPosEmpleado(Nombre) <> -1 Then Return 0
        Dim NuevoEmpleado As New Empleado
        NuevoEmpleado.Id = GetNewId()
        NuevoEmpleado.DNI = DNI
        NuevoEmpleado.Nombre = Nombre
        NuevoEmpleado.Apellido = Apellido
        NuevoEmpleado.FechNac = FechNac
        NuevoEmpleado.Email = Email
        NuevoEmpleado.Direccion = Direccion
        NuevoEmpleado.Ciudad = Ciudad
        NuevoEmpleado.Pais = Pais
        NuevoEmpleado.Telefono = Telefono
        NuevoEmpleado.Trabajo = Trabajo
        NuevoEmpleado.Salario = Salario
        NuevoEmpleado.Restaurante = Restaurante


        Lista.Add(NuevoEmpleado)
        Main.DBManager.AddNewEmployer(NuevoEmpleado)
    End Function

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

    Public Function GetPosEmpleadoDNI(ByVal DNI As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetNombre(ByVal DNI As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Nombre
            End If
        Next
        Return Nothing
    End Function

    Public Function GetApellido(ByVal DNI As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Apellido
            End If
        Next
        Return Nothing
    End Function

    Public Function GetNacimiento(ByVal DNI As String) As Date
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).FechNac
            End If
        Next
        Return Nothing
    End Function

    Public Function GetEmail(ByVal DNI As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Email
            End If
        Next
        Return Nothing
    End Function

    Public Function GetDireccion(ByVal DNI As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Direccion
            End If
        Next
        Return Nothing
    End Function

    Public Function GetCiudad(ByVal DNI As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Ciudad
            End If
        Next
        Return Nothing
    End Function

    Public Function GetPais(ByVal DNI As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Pais
            End If
        Next
        Return Nothing
    End Function

    Public Function GetTelefono(ByVal DNI As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Telefono
            End If
        Next
        Return -1
    End Function

    Public Function GetTrabajo(ByVal DNI As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Trabajo
            End If
        Next
        Return Nothing
    End Function

    Public Function GetSalario(ByVal DNI As String) As Double
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Salario
            End If
        Next
        Return -1
    End Function

    Public Function GetRestaurante(ByVal DNI As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Return Lista(i).Restaurante
            End If
        Next
        Return -1
    End Function

    Public Function ModificarEmpleado(ByVal NewNombre As String, ByVal NewApellido As String, ByVal NewNacimiento As Date, ByVal NewEmail As String, ByVal NewDireccion As String, ByVal NewCiudad As String, ByVal NewPais As String, ByVal NewTelefono As Integer, ByVal NewTrabajo As String, ByVal NewSalario As Double, ByVal NewRestaurante As Integer, ByVal DNI As String) As Integer
        Dim Pos As Integer = GetPosEmpleadoDNI(DNI)
        If Pos = -1 Then Return 0

        Lista(Pos).Nombre = NewNombre
        Lista(Pos).Apellido = NewApellido
        Lista(Pos).FechNac = NewNacimiento
        Lista(Pos).Email = NewEmail
        Lista(Pos).Direccion = NewDireccion
        Lista(Pos).Ciudad = NewCiudad
        Lista(Pos).Pais = NewPais
        Lista(Pos).Telefono = NewTelefono
        Lista(Pos).Trabajo = NewTrabajo
        Lista(Pos).Salario = NewSalario
        Lista(Pos).Restaurante = NewRestaurante


        Main.DBManager.ModificarEmpleado(Pos, Lista(Pos))
        Return 1
    End Function

    Public Function BorrarEmpleado(ByVal DNI As String) As Integer

        ' Compruebo que el usuario existe
        If GetPosEmpleadoDNI(DNI) = -1 Then
            Return 0
        End If

        For i = 0 To Lista.Count - 1
            If (Lista(i).DNI = DNI) Then
                Lista.RemoveAt(i)
                Main.DBManager.DeleteUsuario(i)
                Return 1
            End If
        Next

        Return 0

    End Function
End Class
