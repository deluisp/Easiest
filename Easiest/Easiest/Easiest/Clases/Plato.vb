Public Class Plato

    Public Id As Integer
    Public Nombre As String
    Public Descripcion As String
    Public EsBebida As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal EsBebida As Integer)
        Me.Id = Id
        Me.Nombre = Nombre
        Me.Descripcion = Descripcion
        Me.EsBebida = EsBebida
    End Sub

End Class
