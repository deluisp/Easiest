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
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM ingredientes_categorias", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "ingredientes_categorias")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM ingredientes_tipos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "ingredientes_tipos")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM ingredientes", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "ingredientes")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM platos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "platos")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM platos_ingredientes", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "platos_ingredientes")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM pedidos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "pedidos")
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM lineas_pedido", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataAdapter.Fill(ODataSet, "lineas_pedido")
        OConexion.Close()
    End Sub

    Public Function CargarLineasPedido() As ListaLineasPedido
        Dim ListaLineasPedido As New ListaLineasPedido
        Try
            For contador = 0 To ODataSet.Tables("lineas_pedido").Rows.Count - 1
                Dim NuevaLineaPedido As New LineaPedido
                NuevaLineaPedido.Id = ODataSet.Tables("lineas_pedido").Rows(contador).Item("id")
                NuevaLineaPedido.IdPedido = ODataSet.Tables("lineas_pedido").Rows(contador).Item("id_pedido")
                NuevaLineaPedido.IdPlato = ODataSet.Tables("lineas_pedido").Rows(contador).Item("id_plato")
                NuevaLineaPedido.Cantidad = ODataSet.Tables("lineas_pedido").Rows(contador).Item("cantidad")
                NuevaLineaPedido.Total = ODataSet.Tables("lineas_pedido").Rows(contador).Item("total")
                ListaLineasPedido.Lista.Add(NuevaLineaPedido)
            Next
        Catch ex As Exception

        End Try
        Return ListaLineasPedido
    End Function

    Public Function CargarPedidos() As ListaPedidos
        Dim ListaPedidos As New ListaPedidos
        Try
            For contador = 0 To ODataSet.Tables("pedidos").Rows.Count - 1
                Dim NuevoPedido As New Pedido
                NuevoPedido.Id = ODataSet.Tables("pedidos").Rows(contador).Item("id")
                NuevoPedido.Fecha = ODataSet.Tables("pedidos").Rows(contador).Item("fecha")
                NuevoPedido.Mesa = ODataSet.Tables("pedidos").Rows(contador).Item("mesa")
                NuevoPedido.Empleado = ODataSet.Tables("pedidos").Rows(contador).Item("id_empleado")
                ListaPedidos.Lista.Add(NuevoPedido)
            Next
        Catch ex As Exception

        End Try
        Return ListaPedidos
    End Function

    Public Function CargarPlatos() As ListaPlatos
        Dim ListaPlatos As New ListaPlatos
        For contador = 0 To ODataSet.Tables("platos").Rows.Count - 1
            Dim NuevoPlato As New Plato
            NuevoPlato.Id = ODataSet.Tables("platos").Rows(contador).Item("id")
            NuevoPlato.Nombre = ODataSet.Tables("platos").Rows(contador).Item("nombre")
            NuevoPlato.Descripcion = ODataSet.Tables("platos").Rows(contador).Item("descripcion")
            NuevoPlato.EsBebida = ODataSet.Tables("platos").Rows(contador).Item("esbebida")
            NuevoPlato.Precio = ODataSet.Tables("platos").Rows(contador).Item("precio")
            NuevoPlato.Tipo = ODataSet.Tables("platos").Rows(contador).Item("tipo")
            ListaPlatos.Lista.Add(NuevoPlato)
        Next
        Return ListaPlatos
    End Function

    Public Function CargarPlatosIngredientes() As ListaPlatosIngredientes
        Dim ListaPlatosIngredientes As New ListaPlatosIngredientes
        For contador = 0 To ODataSet.Tables("platos_ingredientes").Rows.Count - 1
            Dim NuevoPlatoIngrediente As New PlatoIngrediente
            NuevoPlatoIngrediente.IdPlato = ODataSet.Tables("platos_ingredientes").Rows(contador).Item("id_plato")
            NuevoPlatoIngrediente.IdIngrediente = ODataSet.Tables("platos_ingredientes").Rows(contador).Item("id_ingrediente")
            ListaPlatosIngredientes.Lista.Add(NuevoPlatoIngrediente)
        Next
        Return ListaPlatosIngredientes
    End Function


    Public Function CargarIngredientesCategorias() As ListaIngredientesCategorias
        Dim ListaIngredientesCategorias As New ListaIngredientesCategorias
        For contador = 0 To ODataSet.Tables("ingredientes_categorias").Rows.Count - 1
            Dim NuevoIngredienteCategoria As New IngredienteCategoria
            NuevoIngredienteCategoria.Id = ODataSet.Tables("ingredientes_categorias").Rows(contador).Item("id")
            NuevoIngredienteCategoria.Nombre = ODataSet.Tables("ingredientes_categorias").Rows(contador).Item("nombre")
            ListaIngredientesCategorias.Lista.Add(NuevoIngredienteCategoria)
        Next
        Return ListaIngredientesCategorias
    End Function

    Public Function CargarIngredientesTipos() As ListaIngredientesTipos
        Dim ListaIngredientesTipos As New ListaIngredientesTipos
        For contador = 0 To ODataSet.Tables("ingredientes_tipos").Rows.Count - 1
            Dim NuevoIngredienteTipo As New IngredienteTipo
            NuevoIngredienteTipo.Id = ODataSet.Tables("ingredientes_tipos").Rows(contador).Item("id")
            NuevoIngredienteTipo.Nombre = ODataSet.Tables("ingredientes_tipos").Rows(contador).Item("nombre")
            NuevoIngredienteTipo.Categoria = ODataSet.Tables("ingredientes_tipos").Rows(contador).Item("categoria")
            ListaIngredientesTipos.Lista.Add(NuevoIngredienteTipo)
        Next
        Return ListaIngredientesTipos
    End Function

    Public Function CargarIngredientes() As ListaIngredientes
        Dim ListaIngredientes As New ListaIngredientes
        For contador = 0 To ODataSet.Tables("ingredientes").Rows.Count - 1
            Dim NuevoIngrediente As New Ingrediente
            NuevoIngrediente.Id = ODataSet.Tables("ingredientes").Rows(contador).Item("id")
            NuevoIngrediente.Nombre = ODataSet.Tables("ingredientes").Rows(contador).Item("nombre")
            NuevoIngrediente.Tipo = ODataSet.Tables("ingredientes").Rows(contador).Item("tipo")
            NuevoIngrediente.Descripcion = ODataSet.Tables("ingredientes").Rows(contador).Item("descripcion")
            ListaIngredientes.Lista.Add(NuevoIngrediente)
        Next
        Return ListaIngredientes
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



    Public Sub AddNewIngrediente(ByVal Ingrediente As Ingrediente)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM ingredientes", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("ingredientes").NewRow
        ODataRow("id") = Ingrediente.Id
        ODataRow("nombre") = Ingrediente.Nombre
        ODataRow("tipo") = Ingrediente.Tipo
        ODataRow("descripcion") = Ingrediente.Descripcion
        ODataSet.Tables("ingredientes").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "ingredientes")
        ODataSet.Tables("ingredientes").AcceptChanges()
    End Sub

    Public Sub AddNewPlato(ByVal Plato As Plato)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM platos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("platos").NewRow
        ODataRow("id") = Plato.Id
        ODataRow("nombre") = Plato.Nombre
        ODataRow("descripcion") = Plato.Descripcion
        ODataRow("esbebida") = Plato.EsBebida
        ODataRow("precio") = Plato.Precio
        ODataSet.Tables("platos").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "platos")
        ODataSet.Tables("platos").AcceptChanges()
    End Sub

    Public Sub AddNewPedido(ByVal Pedido As Pedido)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM pedidos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("pedidos").NewRow
        ODataRow("id") = Pedido.Id
        ODataRow("fecha") = Pedido.Fecha
        ODataRow("mesa") = Pedido.Mesa
        ODataRow("id_empleado") = Pedido.Empleado
        ODataSet.Tables("pedidos").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "pedidos")
        ODataSet.Tables("pedidos").AcceptChanges()
    End Sub

    Public Sub AddNewLineaPedido(ByVal LineaPedido As LineaPedido)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM lineas_pedido", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("lineas_pedido").NewRow
        ODataRow("id") = LineaPedido.Id
        ODataRow("id_pedido") = LineaPedido.IdPedido
        ODataRow("id_plato") = LineaPedido.IdPlato
        ODataRow("cantidad") = LineaPedido.Cantidad
        ODataRow("total") = LineaPedido.Total
        ODataSet.Tables("lineas_pedido").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "lineas_pedido")
        ODataSet.Tables("lineas_pedido").AcceptChanges()
    End Sub


    Public Sub AddNewPlatoIngrediente(ByVal PlatoIngrediente As PlatoIngrediente)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM platos_ingredientes", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)

        Dim ODataRow As DataRow
        ODataRow = ODataSet.Tables("platos_ingredientes").NewRow
        ODataRow("id_plato") = PlatoIngrediente.IdPlato
        ODataRow("id_ingrediente") = PlatoIngrediente.IdIngrediente
        ODataSet.Tables("platos_ingredientes").Rows.Add(ODataRow)

        ODataAdapter.Update(ODataSet, "platos_ingredientes")
        ODataSet.Tables("platos_ingredientes").AcceptChanges()
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

    Public Sub ModificarPlato(ByVal Pos As Integer, ByVal Plato As Plato)
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM platos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("platos").Rows(Pos).Item("nombre") = Plato.Nombre
        ODataSet.Tables("platos").Rows(Pos).Item("descripcion") = Plato.Descripcion
        ODataSet.Tables("platos").Rows(Pos).Item("esbebida") = Plato.EsBebida
        ODataSet.Tables("platos").Rows(Pos).Item("precio") = Plato.Precio
        ODataAdapter.Update(ODataSet, "platos")
        ODataSet.Tables("platos").AcceptChanges()
    End Sub

    Public Sub DeletePermiso(ByVal Pos As Integer)
        ' Controlar si eso
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM permisos", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("permisos").Rows(Pos).Delete()
        ODataAdapter.Update(ODataSet, "permisos")
        ODataSet.Tables("permisos").AcceptChanges()
    End Sub

    Public Sub DeletePlatoIngrediente(ByVal Pos As Integer)
        ' Controlar si eso
        ODataAdapter = New MySqlDataAdapter("SELECT * FROM platos_ingredientes", OConexion)
        OCommandBuilder = New MySqlCommandBuilder(ODataAdapter)
        ODataSet.Tables("platos_ingredientes").Rows(Pos).Delete()
        ODataAdapter.Update(ODataSet, "platos_ingredientes")
        ODataSet.Tables("platos_ingredientes").AcceptChanges()
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
