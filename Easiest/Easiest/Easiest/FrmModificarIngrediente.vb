Imports System.ComponentModel
Public Class FrmModificarIngrediente
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Main.ListaIngredientes.Buscar(txtBuscar.Text) Then
            'MessageBox.Show(Main.ListaIngredientes.Buscar(txtBuscar.Text))
            TxtNombre.Text = Main.ListaIngredientes.GetName(txtBuscar.Text)
            'Dim Id = Main.ListaIngredientesCategorias.GetId(CmbCategoria.SelectedItem)
            Dim Id = Main.ListaIngredientesCategorias.GetId(txtBuscar.Text)
            For i = 0 To Main.ListaIngredientesTipos.Lista.Count - 1
                If (Main.ListaIngredientesTipos.Lista(i).Categoria = Id) Then

                    CmbTipo.Items.Add(Main.ListaIngredientesTipos.Lista(i).Nombre)
                End If
            Next
        Else
            MessageBox.Show("El ingrediente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FrmModificarIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Main.ListaIngredientesCategorias.Lista.Count - 1
            CmbCategoria.Items.Add(Main.ListaIngredientesCategorias.Lista(i).Nombre)
        Next
    End Sub
End Class