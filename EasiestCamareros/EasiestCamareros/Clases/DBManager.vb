Imports System.Text
Imports MySql.Data.MySqlClient

Public NotInheritable Class DBManager

    Public Shared CadenaConexion As String = "server='localhost';database='easiest';user id='root';password=''"
    Public Shared OConexion As New MySqlConnection
    Public Shared ODataAdapter As New MySqlDataAdapter()
    Public Shared OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
    Public Shared ODataSet As New DataSet

    Shared Sub New()

        OConexion.ConnectionString = CadenaConexion
        OConexion.Open()
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM empleados", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "empleados")
        OConexion.Close()

    End Sub

    Public Function CargarEmpleados() As ListaEmpleados
        Dim ListaEmpleados As New ListaEmpleados
        For contador = 0 To ODataSet.Tables("empleados").Rows.Count - 1
            Dim NuevoEmpleado As New Empleado
            NuevoEmpleado.Id = ODataSet.Tables("empleados").Rows(contador).Item("id")
            NuevoEmpleado.DNI = ODataSet.Tables("empleados").Rows(contador).Item("dni")
            NuevoEmpleado.Nombre = ODataSet.Tables("empleados").Rows(contador).Item("nombre")
            NuevoEmpleado.Apellido = ODataSet.Tables("empleados").Rows(contador).Item("apellido")
            NuevoEmpleado.FechNac = ODataSet.Tables("empleados").Rows(contador).Item("fechnac")
            NuevoEmpleado.Email = ODataSet.Tables("empleados").Rows(contador).Item("email")
            NuevoEmpleado.Direccion = ODataSet.Tables("empleados").Rows(contador).Item("direccion")
            NuevoEmpleado.Ciudad = ODataSet.Tables("empleados").Rows(contador).Item("ciudad")
            NuevoEmpleado.Pais = ODataSet.Tables("empleados").Rows(contador).Item("pais")
            NuevoEmpleado.Telefono = ODataSet.Tables("empleados").Rows(contador).Item("telefono")
            NuevoEmpleado.Trabajo = ODataSet.Tables("empleados").Rows(contador).Item("restaurante")
            NuevoEmpleado.Salario = ODataSet.Tables("empleados").Rows(contador).Item("salario")
            NuevoEmpleado.Restaurante = ODataSet.Tables("empleados").Rows(contador).Item("restaurante")
            ListaEmpleados.Lista.Add(NuevoEmpleado)
        Next
        Return ListaEmpleados
    End Function
End Class
