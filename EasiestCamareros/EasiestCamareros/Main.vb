Imports MySql.Data.MySqlClient
Module Main
    Public DBManager As DBManager

    Public ListaEmpleados As New ListaEmpleados
    Public ListaIngredientesCategorias As New ListaIngredientesCategorias
    Public ListaIngredientesTipos As New ListaIngredientesTipos
    Public ListaIngredientes As New ListaIngredientes
    Public ListaPlatos As New ListaPlatos
    Public ListaPlatosIngredientes As New ListaPlatosIngredientes

    Public EmpleadoActual As Integer

    Public FrmPrincipal As EasiestCamareros
    Public FrmLogin As LoginCamarero
    Public VentanaMesas As FrmMesas
    Public VentanaPedidos As FrmPedidos


    Public Sub Main()
        DBManager = New DBManager()
        ListaEmpleados = DBManager.CargarEmpleados
        ListaIngredientesCategorias = DBManager.CargarIngredientesCategorias
        ListaIngredientesTipos = DBManager.CargarIngredientesTipos
        ListaIngredientes = DBManager.CargarIngredientes
        ListaPlatos = DBManager.CargarPlatos
        ListaPlatosIngredientes = DBManager.CargarPlatosIngredientes

        FrmLogin = New LoginCamarero()
        FrmPrincipal = New EasiestCamareros()
        FrmLogin.MdiParent = FrmPrincipal
        FrmLogin.Show()
        Application.Run(FrmPrincipal)
    End Sub
End Module
