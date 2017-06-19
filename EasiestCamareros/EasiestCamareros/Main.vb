Imports MySql.Data.MySqlClient
Module Main
    Public DBManager As DBManager
    Public ListaEmpleados As New ListaEmpleados

    Public EmpleadoActual As Integer

    Public FrmPrincipal As EasiestCamareros
    Public FrmLogin As LoginCamarero
    Public VentanaMesas As FrmMesas
    Public VentanaPedidos As FrmPedidos


    Public Sub Main()
        DBManager = New DBManager()
        ListaEmpleados = DBManager.CargarEmpleados

        FrmLogin = New LoginCamarero()
        FrmPrincipal = New EasiestCamareros()
        FrmLogin.MdiParent = FrmPrincipal
        FrmLogin.Show()
        Application.Run(FrmPrincipal)
    End Sub
End Module
