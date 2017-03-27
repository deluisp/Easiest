Public Class ListaLogs

    Public Shared Lista As New List(Of Log)
    Shared Sub New()

    End Sub

    Public Function AddNewLog(ByVal IdUsuario As Integer)
        'Controlar si existe el usuario
        Dim Log As New Log
        Log.Id = GetMaxId() + 1
        Log.IdUsuario = IdUsuario
        Log.FechaInicio = DateTime.Now
        Log.FechaFin = Nothing
        Lista.Add(Log)
        Return Lista.Count - 1
    End Function

    Public Function GetMaxId() As Integer
        If Lista.Count = 0 Then
            Return -1
        Else
            Dim Mayor As Integer = Lista(0).Id
            For i = 0 To Lista.Count - 1
                If Lista(i).Id > Mayor Then Mayor = Lista(i).Id
            Next
            Return Mayor
        End If
        Return 0
    End Function

    Public Function GetLog(ByVal pos As Integer) As Log
        If pos >= 0 And pos < Lista.Count Then
            Return Lista(pos)
        End If
        Return Nothing
    End Function

    Public Function GetUltimaConexion(ByVal IdUsuario As Integer) As DateTime
        'Controlar que el usuario existe
        Dim ListaUsuario As New List(Of Log)
        For i = 0 To Lista.Count - 1
            If Lista(i).IdUsuario = IdUsuario Then
                'MessageBox.Show(Lista(i).IdUsuario & " " & Lista(i).FechaFin)
                ListaUsuario.Add(Lista(i))
            End If
        Next
        Dim Mayor As DateTime = ListaUsuario(0).FechaFin
        For i = 0 To ListaUsuario.Count - 1
            If ListaUsuario(i).FechaFin > Mayor Then
                Mayor = ListaUsuario(i).FechaFin
            End If
        Next

        Return Mayor
    End Function

    Public Function ExportarLogs(ByVal Ruta As String) As Integer
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(Ruta, True)
            file.WriteLine("IdLog" & vbTab & "IdUsuario" & vbTab & "FechaInicio" & vbTab & "FechaFin")
            For i = 0 To Lista.Count - 1
                file.WriteLine(Lista(i).Id & vbTab & Lista(i).IdUsuario & vbTab & Lista(i).FechaInicio & vbTab & Lista(i).FechaFin)
            Next
            file.Close()
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
