Public Class LoginCamarero

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Dim Pos As Integer

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Pos As Integer = Main.ListaEmpleados.BuscarDNIPos(TxtClave.Text)
        If Pos = -1 Then
            MessageBox.Show("No existe el empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand
                            )
            Application.ExitThread()
        Else
            Main.EmpleadoActual = Main.ListaEmpleados.GetId(TxtClave.Text)
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.ExitThread()
    End Sub

    Private Sub LoginCamarero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pos = -1
        Main.EmpleadoActual = -1
    End Sub
End Class
