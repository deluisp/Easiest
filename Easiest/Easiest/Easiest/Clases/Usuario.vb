Public Class Usuario

    Public Id As Integer
    Public Usuario As String
    Public Clave As String
    Public Tipo As Integer
    Public Email As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Usuario As String, ByVal Clave As String, ByVal Tipo As Integer)
        Me.Id = Id
        Me.Usuario = Usuario
        Me.Clave = Clave
        Me.Tipo = Tipo
    End Sub
End Class
