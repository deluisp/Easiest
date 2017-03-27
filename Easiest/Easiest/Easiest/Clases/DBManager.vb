Imports System.Text
Imports MySql.Data.MySqlClient

Public NotInheritable Class DBManager

    Public Shared CadenaConexion As String = "server='localhost';database='proyecto';user id='root';password=''"
    Public Shared OConexion As New MySqlConnection
    Public Shared ODataAdapter As New MySqlDataAdapter()
    Public Shared OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
    Public Shared ODataSet As New DataSet

    Shared Sub New()
        OConexion.ConnectionString = CadenaConexion
        OConexion.Open()
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM usuarios", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "usuarios")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM logs", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "logs")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM permisos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "permisos")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM empleados", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "empleados")
        OConexion.Close()
    End Sub

    Public Function CargarUsuarios() As ListaUsuarios
        Dim ListaUsuarios As New ListaUsuarios
        For contador = 0 To ODataSet.Tables("usuarios").Rows.Count - 1
            Dim NuevoUsuario As New Usuario
            NuevoUsuario.Id = ODataSet.Tables("usuarios").Rows(contador).Item("id")
            NuevoUsuario.Usuario = ODataSet.Tables("usuarios").Rows(contador).Item("usuario")
            NuevoUsuario.Clave = ODataSet.Tables("usuarios").Rows(contador).Item("clave")
            NuevoUsuario.Tipo = ODataSet.Tables("usuarios").Rows(contador).Item("tipo")
            NuevoUsuario.Email = ODataSet.Tables("usuarios").Rows(contador).Item("email")
            ListaUsuarios.Lista.Add(NuevoUsuario)
        Next
        Return ListaUsuarios
    End Function

    Public Function CargarLogs() As ListaLogs
        Dim ListaLogs As New ListaLogs
        For contador = 0 To ODataSet.Tables("logs").Rows.Count - 1
            Dim NuevoLog As New Log
            NuevoLog.Id = ODataSet.Tables("logs").Rows(contador).Item("id")
            NuevoLog.IdUsuario = ODataSet.Tables("logs").Rows(contador).Item("idUsuario")
            NuevoLog.FechaInicio = ODataSet.Tables("logs").Rows(contador).Item("fechaInicio")
            NuevoLog.FechaFin = ODataSet.Tables("logs").Rows(contador).Item("fechaFin")
            ListaLogs.Lista.Add(NuevoLog)
        Next
        Return ListaLogs
    End Function

    Public Function CargarPermisos() As ListaPermisos
        Dim ListaPermisos As New ListaPermisos
        For contador = 0 To ODataSet.Tables("permisos").Rows.Count - 1
            Dim NuevoPermiso As New Permiso
            NuevoPermiso.Id = ODataSet.Tables("permisos").Rows(contador).Item("id")
            NuevoPermiso.IdUsuario = ODataSet.Tables("permisos").Rows(contador).Item("idUsuario")
            NuevoPermiso.Tipo = ODataSet.Tables("permisos").Rows(contador).Item("tipo")
            ListaPermisos.Lista.Add(NuevoPermiso)
        Next
        Return ListaPermisos
    End Function

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
            NuevoEmpleado.Trabajo = ODataSet.Tables("empleados").Rows(contador).Item("trabajo")
            NuevoEmpleado.Salario = ODataSet.Tables("empleados").Rows(contador).Item("salario")
            NuevoEmpleado.Restaurante = ODataSet.Tables("empleados").Rows(contador).Item("restaurante")
            ListaEmpleados.Lista.Add(NuevoEmpleado)
        Next
        Return ListaEmpleados
    End Function

    Public Sub AddNewLog(ByVal Log As Log)
        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("logs").NewRow
        ODataRow("id") = Log.Id
        ODataRow("idUsuario") = Log.IdUsuario
        ODataRow("fechaInicio") = Log.FechaInicio
        ODataRow("fechaFin") = DateTime.Now
        ODataSet.Tables("logs").Rows.Add(ODataRow)
    End Sub

    Public Sub UpdateLogs()
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM logs", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Update(ODataSet, "logs")
    End Sub

    Public Sub AddNewUser(ByVal User As Usuario)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM usuarios", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("usuarios").NewRow
        ODataRow("id") = User.Id
        ODataRow("usuario") = User.Usuario
        ODataRow("clave") = User.Clave
        ODataRow("tipo") = User.Tipo
        ODataRow("email") = User.Email
        ODataSet.Tables("usuarios").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "usuarios")
        ODataSet.Tables("usuarios").AcceptChanges()
    End Sub

    Public Sub AddNewPermiso(ByVal Permiso As Permiso)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM permisos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("permisos").NewRow
        ODataRow("id") = Permiso.Id
        ODataRow("idUsuario") = Permiso.IdUsuario
        ODataRow("tipo") = Permiso.Tipo
        ODataSet.Tables("permisos").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "permisos")
        ODataSet.Tables("permisos").AcceptChanges()
    End Sub

    Public Sub AddNewEmployer(ByVal Employer As Empleado)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM empleados", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("empleados").NewRow
        ODataRow("id") = Employer.Id
        ODataRow("dni") = Employer.DNI
        ODataRow("nombre") = Employer.Nombre
        ODataRow("apellido") = Employer.Apellido
        ODataRow("fechnac") = Employer.FechNac
        ODataRow("email") = Employer.Email
        ODataRow("direccion") = Employer.Direccion
        ODataRow("ciudad") = Employer.Ciudad
        ODataRow("pais") = Employer.Pais
        ODataRow("telefono") = Employer.Telefono
        ODataRow("trabajo") = Employer.Trabajo
        ODataRow("salario") = Employer.Salario
        ODataRow("restaurante") = Employer.Restaurante
        ODataSet.Tables("empleados").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "empleados")
        ODataSet.Tables("empleados").AcceptChanges()
    End Sub

    Public Sub UpdateEmployer()
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM empleados", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Update(ODataSet, "empleados")
    End Sub

    Public Sub UpdateUsuarios()
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM usuarios", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Update(ODataSet, "usuarios")
    End Sub

    Public Sub DeleteUsuario(ByVal Pos As Integer)
        ' Controlar si eso
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM usuarios", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("usuarios").Rows(Pos).Delete()
        ODataAdapter.Update(ODataSet, "usuarios")
        ODataSet.Tables("usuarios").AcceptChanges()
    End Sub

    Public Sub ModificarUsuario(ByVal Pos As Integer, ByVal User As Usuario)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM usuarios", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("usuarios").Rows(Pos).Item("clave") = User.Clave
        ODataSet.Tables("usuarios").Rows(Pos).Item("email") = User.Email
        ODataSet.Tables("usuarios").Rows(Pos).Item("tipo") = User.Tipo
        ODataAdapter.Update(ODataSet, "usuarios")
        ODataSet.Tables("usuarios").AcceptChanges()
    End Sub

    Public Sub DeletePermiso(ByVal Pos As Integer)
        ' Controlar si eso
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM permisos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("permisos").Rows(Pos).Delete()
        ODataAdapter.Update(ODataSet, "permisos")
        ODataSet.Tables("permisos").AcceptChanges()
    End Sub

    'Para la excepcion, deletepermisobyid


    Public Sub ModificarEmpleado(ByVal Pos As Integer, ByVal Employer As Empleado)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM empleados", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("empleados").Rows(Pos).Item("nombre") = Employer.Nombre
        ODataSet.Tables("empleados").Rows(Pos).Item("apellido") = Employer.Apellido
        ODataSet.Tables("empleados").Rows(Pos).Item("fechnac") = Employer.FechNac
        ODataSet.Tables("empleados").Rows(Pos).Item("email") = Employer.Email
        ODataSet.Tables("empleados").Rows(Pos).Item("direccion") = Employer.Direccion
        ODataSet.Tables("empleados").Rows(Pos).Item("ciudad") = Employer.Ciudad
        ODataSet.Tables("empleados").Rows(Pos).Item("pais") = Employer.Pais
        ODataSet.Tables("empleados").Rows(Pos).Item("telefono") = Employer.Telefono
        ODataSet.Tables("empleados").Rows(Pos).Item("trabajo") = Employer.Trabajo
        ODataSet.Tables("empleados").Rows(Pos).Item("salario") = Employer.Salario
        ODataSet.Tables("empleados").Rows(Pos).Item("restaurante") = Employer.Restaurante
        ODataAdapter.Update(ODataSet, "empleados")
        ODataSet.Tables("empleados").AcceptChanges()
    End Sub

    Public Sub DeleteEmpleado(ByVal Pos As Integer)
        ' Controlar si eso
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM empleados", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("empleados").Rows(Pos).Delete()
        ODataAdapter.Update(ODataSet, "empleados")
        ODataSet.Tables("empleados").AcceptChanges()
    End Sub
End Class
