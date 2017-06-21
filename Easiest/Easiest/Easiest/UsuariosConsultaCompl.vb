'Imports ProyectoPruebaUsuarios.DBManager
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class UsuariosConsultaCompl

    Dim cadenaSelect As String
    Dim cadenaTabla As String


    Dim oDataAdapter As MySqlDataAdapter
    Dim oDataSet As New DataSet

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            cadenaSelect = txtConsulta.Text
            cadenaTabla = txtTabla.Text



            oDataAdapter = New MySqlDataAdapter(cadenaSelect, Main.DBManager.OConexion)
            oDataAdapter.Fill(oDataSet, cadenaTabla)
            oDataAdapter = Nothing

            GtdConsulta.DataSource = oDataSet.Tables(cadenaTabla)
        Catch ex As Exception
            MessageBox.Show("No puede estar los campos vacios")
        End Try



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        GtdConsulta.DataSource = ""
        txtConsulta.Text = ""
        txtTabla.Text = ""
    End Sub

    Private Sub UsuariosConsultaCompl_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class