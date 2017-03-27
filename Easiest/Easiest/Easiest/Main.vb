Imports MySql.Data.MySqlClient

Module Main
    Public DBManager As DBManager
    Public ListaUsuarios As New ListaUsuarios
    Public ListaLogs As New ListaLogs
    Public ListaPermisos As New ListaPermisos
    Public ListaEmpleados As New ListaEmpleados

    Public UsuarioActual As Integer 'ID
    Public LogActual As Integer

    Public FrmPrincipal As VentanaPrincipal
    Public FrmLogin As FrmLogin

    Public Sub Main()
        DBManager = New DBManager()
        ListaUsuarios = DBManager.CargarUsuarios
        ListaLogs = DBManager.CargarLogs
        ListaPermisos = DBManager.CargarPermisos
        ListaEmpleados = DBManager.CargarEmpleados

        FrmLogin = New FrmLogin()
        FrmPrincipal = New VentanaPrincipal()
        FrmLogin.MdiParent = FrmPrincipal
        FrmLogin.Show()
        Application.Run(FrmPrincipal)
    End Sub
End Module
