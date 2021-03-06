﻿Imports System.ComponentModel

Public Class FrmAltaIngrediente
    Private Sub FrmAltaIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Main.ListaIngredientesCategorias.Lista.Count - 1
            CmbCategoria.Items.Add(Main.ListaIngredientesCategorias.Lista(i).Nombre)
        Next
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        Main.ListaIngredientes.Nuevo(TxtNombre.Text, Main.ListaIngredientesTipos.GetId(CmbTipo.SelectedItem), TxtDescripcion.Text)
        MessageBox.Show("Ingrediente añadido con exito")
        Me.Close()
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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAltaIngrediente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class