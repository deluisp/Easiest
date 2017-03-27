Imports System.Text

Public NotInheritable Class ListaUsuarios

    Public Shared Lista As New List(Of Usuario)
    Shared Sub New()
    End Sub

    Public Function Buscar(ByVal Usuario As String, ByVal Clave As String) As Boolean
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario And Lista(i).Clave = Clave) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function Buscar(ByVal Usuario As String) As Boolean
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function BuscarEmail(ByVal Email As String) As Boolean
        For i = 0 To Lista.Count - 1
            If (Lista(i).Email = Email) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function GetTipo(ByVal Usuario As String, ByVal Clave As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario And Lista(i).Clave = Clave) Then
                Return Lista(i).Tipo
            End If
        Next
        Return -1
    End Function

    Public Function GetTipo(ByVal Usuario As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Return Lista(i).Tipo
            End If
        Next
        Return -1
    End Function

    Public Function GetTipoByPos(ByVal Pos As Integer) As Integer
        If Pos >= 0 And Pos < Lista.Count Then
            Return Lista(Pos).Tipo
        End If
        Return -1
    End Function

    Public Function GetTipoById(ByVal Id As Integer) As Integer
        For i = 0 To Lista.Count - 1
            If Lista(i).Id = Id Then
                Return Lista(i).Tipo
            End If
        Next
        Return -1
    End Function

    Public Function GetPosUsuario(ByVal Usuario As String, ByVal Clave As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario And Lista(i).Clave = Clave) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetPosUsuario(ByVal Usuario As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetPosUsuario(ByVal Id As Integer) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Id = Id) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetId(ByVal Pos As Integer) As Integer
        If Pos >= 0 And Pos < Lista.Count Then
            Return Lista(Pos).Id
        End If
        Return -1
    End Function

    Public Function GetId(ByVal Usuario As String) As Integer
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Return Lista(i).Id
            End If
        Next
        Return -1
    End Function

    Public Function Borrar(ByVal Usuario As String) As Integer
        ' Compruebo que el usuario existe
        If GetPosUsuario(Usuario) = -1 Then
            Return 0
        End If

        ' Compruebo que no soy yo
        If Main.UsuarioActual = GetId(Usuario) Then
            Return 0
        End If

        ' Compruebo que han pasado dos dias desde su ultima conexion
        If DateDiff("d", Main.ListaLogs.GetUltimaConexion(GetId(Usuario)), DateTime.Now) < 2 Then
            Return 0
        End If

        ' Busco al usuario y lo borro
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Lista.RemoveAt(i)
                Main.DBManager.DeleteUsuario(i)
                Return 1
            End If
        Next
        Return 0
    End Function

    Public Function Nuevo(ByVal Usuario As String, ByVal Clave As String, ByVal Email As String, ByVal Tipo As Integer)
        If GetPosUsuario(Usuario) <> -1 Then Return 0
        Dim NuevoUsuario As New Usuario
        NuevoUsuario.Id = GetNewId()
        NuevoUsuario.Usuario = Usuario
        NuevoUsuario.Clave = Clave
        NuevoUsuario.Tipo = Tipo
        NuevoUsuario.Email = Email

        Lista.Add(NuevoUsuario)
        Main.DBManager.AddNewUser(NuevoUsuario)
    End Function

    Public Function CrearPassword(longitud As Integer) As String
        Dim caracteres As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim res As New StringBuilder()
        Dim rnd As New Random()
        While 0 < System.Math.Max(System.Threading.Interlocked.Decrement(longitud), longitud + 1)
            res.Append(caracteres(rnd.[Next](caracteres.Length)))
        End While
        Return res.ToString()
    End Function

    Public Function MostrarPass(ByVal Usuario As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Return Lista(i).Clave
            End If
        Next
        Return False
    End Function

    Public Function MostrarEmail(ByVal Usuario As String) As String
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Return Lista(i).Email
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

    Public Function ModificarUsuario(ByVal Usuario As String, ByVal NewClave As String, ByVal NewEmail As String, ByVal NewTipo As Integer) As Integer
        Dim Pos As Integer = GetPosUsuario(Usuario)
        If Pos = -1 Then Return 0

        Lista(Pos).Clave = NewClave
        Lista(Pos).Email = NewEmail
        Lista(Pos).Tipo = NewTipo

        Main.DBManager.ModificarUsuario(Pos, Lista(Pos))
        Return 1
    End Function

    Public Function ModificarUsuario(ByVal Id As Integer, ByVal NewClave As String) As Integer
        Dim Pos As Integer = GetPosUsuario(Id)
        If Pos = -1 Then Return 0

        Lista(Pos).Clave = NewClave

        Main.DBManager.ModificarUsuario(Pos, Lista(Pos))
        Return 1
    End Function

    Public Function GetClave(ByVal Id As Integer) As String
        If GetPosUsuario(Id) = -1 Then
            Return ""
        Else
            Return Lista(GetPosUsuario(Id)).Clave
        End If
    End Function

    Public Function GetUsuario(ByVal Usuario As String)
        For i = 0 To Lista.Count - 1
            If (Lista(i).Usuario = Usuario) Then
                Return Lista(i).Email.ToString()
            End If
        Next
        Return -1
    End Function

End Class
