Imports System.ComponentModel
Imports Easiest.DBManager
Imports MySql.Data.MySqlClient

Public Class UsuariosConsulta

    Dim miTabla As DataTable
    Dim datosCol As DataColumn
    Dim i As Integer
    Dim cadenaSelect As String
    Dim cadenaSelect1 As String
    Dim cadenaSelect2 As String
    Dim sw As Byte

    Private Sub UsuariosConsulta_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i = 0 To ODataSet.Tables.Count - 1
            cmbTablas.Items.Add(ODataSet.Tables.Item(i).TableName)
            'Añade al combobox cada tabla del dataset'
        Next
    End Sub

    Private Sub cmbTablas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTablas.SelectedIndexChanged
        cmbCampos.Items.Clear()
        Dim oDataRow As DataRow
        oDataRow = ODataSet.Tables(cmbTablas.Text).Rows(0)
        miTabla = oDataRow.Table
        For Each datosCol In miTabla.Columns
            cmbCampos.Items.Add(datosCol.ColumnName)
        Next
        cadenaSelect = "Select * from " + cmbTablas.Text
        txtSelect.Text = cadenaSelect
    End Sub

    Private Sub cmbCampos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCampos.SelectedIndexChanged
        txtSelect.Text = cadenaSelect + " where " + cmbCampos.Text
        cadenaSelect1 = txtSelect.Text
        Dim tipoDatoString As String = "System.String"
        Dim tipoDatoInt As String = "System.Int32"

        For Each datosCol In miTabla.Columns
            If datosCol.ColumnName = cmbCampos.Text Then
                Select Case datosCol.DataType.FullName
                    Case tipoDatoString
                        optIgual.Enabled = True
                        optMayor.Enabled = False
                        optMenor.Enabled = False
                        sw = 0
                        Exit For
                    Case tipoDatoInt
                        optIgual.Enabled = True
                        optMayor.Enabled = True
                        optMenor.Enabled = True
                        sw = 1
                        Exit For
                End Select
            End If
        Next
    End Sub

    Private Sub optIgual_Click(sender As Object, e As EventArgs) Handles optIgual.Click
        If optIgual.Checked = True Then
            activarDato(optIgual.Text)
        End If
    End Sub

    Private Sub activarDato(ByVal operador As String)
        cambiarEstado(True)
        cadenaSelect2 = cadenaSelect1 + " " + operador
        txtSelect.Text = cadenaSelect2
        'Mandamos el literal del optionbutton'
    End Sub

    Private Sub cambiarEstado(ByVal valor As Boolean)
        lblDatoBuscar.Enabled = valor
        txtDatoBuscar.Enabled = valor
        btnAceptar.Enabled = valor

    End Sub

    Private Sub optMayor_CheckedChanged(sender As Object, e As EventArgs) Handles optMayor.CheckedChanged
        If optMayor.Checked = True Then
            activarDato(optMayor.Text)
        End If
    End Sub

    Private Sub optMenor_CheckedChanged(sender As Object, e As EventArgs) Handles optMenor.CheckedChanged
        If optMenor.Checked = True Then
            activarDato(optMenor.Text)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        btnAceptar.Enabled = False
        Select Case sw
            Case 0 'Cuando es un string realiza lo siguiente'
                txtSelect.Text = txtSelect.Text + " '"
                txtSelect.Text = txtSelect.Text + txtDatoBuscar.Text
                txtSelect.Text = txtSelect.Text + "'"
                'Al ser un string lo almacena en donde estan los apostrofos'
            Case 1 'Tipo de dato int'
                txtSelect.Text = txtSelect.Text + " " + txtDatoBuscar.Text
                'No lo metemos entre apostrofos ya que es un tipo de dato entero'
        End Select

        OConexion.Open()
        ODataAdapter = Nothing
        ODataAdapter = New MySqlDataAdapter(txtSelect.Text, OConexion)
        ODataSet.Tables(cmbTablas.Text).Clear()
        ODataAdapter.Fill(ODataSet, cmbTablas.Text)
        OConexion.Close()

        If ODataSet.Tables(cmbTablas.Text).Rows.Count > 0 Then
            lblNoDatos.Visible = False
            dtgDatos.DataSource = ODataSet
            dtgDatos.DataMember = cmbTablas.Text
        Else
            lblNoDatos.Visible = True
        End If

        cambiarEstado(False)
    End Sub

    Private Sub UsuariosConsulta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class