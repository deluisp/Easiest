Imports System.ComponentModel
Public Class FrmModificarIngrediente
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Main.ListaIngredientes.Buscar(txtBuscar.Text) Then
            'MessageBox.Show(Main.ListaIngredientes.Buscar(txtBuscar.Text))
            TxtNombre.Text = Main.ListaIngredientes.GetName(txtBuscar.Text)
            TxtDescripcion.Text = Main.ListaIngredientes.GetDescripcion(txtBuscar.Text)
        Else
            MessageBox.Show("El ingrediente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FrmModificarIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Main.ListaIngredientesCategorias.Lista.Count - 1
            CmbCategoria.Items.Add(Main.ListaIngredientesCategorias.Lista(i).Nombre)
        Next
    End Sub

    Private Sub CmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategoria.SelectedIndexChanged
        CmbTipo.Items.Clear()
        Dim Id = Main.ListaIngredientesCategorias.GetId(CmbCategoria.SelectedItem)
        For i = 0 To Main.ListaIngredientesTipos.Lista.Count - 1
            If (Main.ListaIngredientesTipos.Lista(i).Categoria = Id) Then
                CmbTipo.Items.Add(Main.ListaIngredientesTipos.Lista(i).Nombre)
            End If
        Next
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Main.ListaIngredientes.ModificarIngrediente(TxtNombre.Text, Main.ListaIngredientesTipos.GetId(CmbTipo.SelectedItem), TxtDescripcion.Text)
        MessageBox.Show("Ingrediente modificado con exito")
        Me.Close()
    End Sub
End Class