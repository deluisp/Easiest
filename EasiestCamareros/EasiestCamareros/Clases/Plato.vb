Public Class Plato

    Public Id As Integer
    Public Nombre As String
    Public Descripcion As String
    Public EsBebida As Integer
    Public Precio As Double
    Public Tipo As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal EsBebida As Integer, ByVal Precio As Double, ByVal Tipo As Integer)
        Me.Id = Id
        Me.Nombre = Nombre
        Me.Descripcion = Descripcion
        Me.EsBebida = EsBebida
        Me.Precio = Precio
        Me.Tipo = Tipo
    End Sub

End Class
