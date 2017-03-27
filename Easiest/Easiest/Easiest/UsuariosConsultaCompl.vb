'Imports ProyectoPruebaUsuarios.DBManager
Imports MySql.Data.MySqlClient
Public Class UsuariosConsultaCompl

    Dim cadenaSelect As String
    Dim cadenaTabla As String


    Dim oDataAdapter As MySqlDataAdapter
    Dim oDataSet As New DataSet

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click



        cadenaSelect = txtConsulta.Text
        cadenaTabla = txtTabla.Text



        ODataAdapter = New MySqlDataAdapter(cadenaSelect, Main.DBManager.OConexion)
        ODataAdapter.Fill(ODataSet, cadenaTabla)
        ODataAdapter = Nothing

        GtdConsulta.DataSource = ODataSet.Tables(cadenaTabla)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        GtdConsulta.DataSource = ""
        txtConsulta.Text = ""
        txtTabla.Text = ""
    End Sub
End Class