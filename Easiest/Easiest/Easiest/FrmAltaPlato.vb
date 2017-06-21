Imports System.ComponentModel

Public Class FrmAltaPlato

    Private Sub FrmAltaPlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Main.ListaIngredientes.Lista.Count - 1
            Lb1.Items.Add(Main.ListaIngredientes.Lista(i).Nombre)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Lb2.Items.Add(Lb1.SelectedItem)
            Lb1.Items.Remove(Lb1.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("No hay elementos seleccionados en la lista")
        End Try
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        Dim IdPlato = Main.ListaPlatos.Nuevo(TxtNombre.Text, TxtDescripcion.Text, RdbBebida.Checked, TxtPrecio.Text)
        For i = 0 To Lb2.Items.Count - 1
            Main.ListaPlatosIngredientes.Nuevo(IdPlato, Main.ListaIngredientes.Buscar(Lb2.Items(i).ToString))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Lb1.Items.Add(Lb2.SelectedItem)
            Lb2.Items.Remove(Lb2.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("No hay elementos seleccionados en la lista")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For x = 0 To Lb1.SelectedItems.Count - 1
            Lb2.Items.Add(Lb1.SelectedItems(x))
        Next
        For x = Lb1.SelectedItems.Count - 1 To 0 Step -1
            Lb1.Items.Remove(Lb1.SelectedItems(x))
        Next
        Lb2.Refresh()
        Lb1.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For x = 0 To Lb2.SelectedItems.Count - 1
            Lb1.Items.Add(Lb2.SelectedItems(x))

        Next
        For x = Lb2.SelectedItems.Count - 1 To 0 Step -1

            Lb2.Items.Remove(Lb2.SelectedItems(x))
        Next
        Lb1.Refresh()
        Lb2.Refresh()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAltaPlato_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class