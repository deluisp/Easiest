Imports System.ComponentModel

Public Class FrmBajaPlato
    Private Sub FrmBajaPlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Main.ListaIngredientes.Lista.Count - 1
            Lb1.Items.Add(Main.ListaIngredientes.Lista(i).Nombre)
        Next
        For i = 0 To Main.ListaPlatos.Lista.Count - 1
            CmbPlatos.Items.Add(Main.ListaPlatos.Lista(i).Nombre)
        Next
    End Sub

    Private Sub CmbPlatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPlatos.SelectedIndexChanged
        Lb1.Items.Clear()
        For i = 0 To Main.ListaIngredientes.Lista.Count - 1
            Lb1.Items.Add(Main.ListaIngredientes.Lista(i).Nombre)
        Next
        TxtNombre.Text = CmbPlatos.SelectedItem.ToString
        TxtDescripcion.Text = Main.ListaPlatos.GetDescripcion(CmbPlatos.SelectedItem.ToString)
        TxtPrecio.Text = Main.ListaPlatos.GetPrecio(CmbPlatos.SelectedItem.ToString)
        If (Main.ListaPlatos.GetEsBebida(CmbPlatos.SelectedItem.ToString) = 1) Then
            RdbBebida.Checked = True
            RdbComida.Checked = False
        Else
            RdbBebida.Checked = False
            RdbComida.Checked = True
        End If
        Dim ListaIngredientes = Main.ListaPlatosIngredientes.GetIngredientes(Main.ListaPlatos.GetId(CmbPlatos.SelectedItem.ToString))
        Lb2.Items.Clear()
        For i = 0 To ListaIngredientes.Count - 1
            Lb2.Items.Add(ListaIngredientes(i))
        Next
        For i = 0 To Lb1.Items.Count - 1
            For j = 0 To ListaIngredientes.Count - 1
                Try
                    If (Lb1.Items(i) = ListaIngredientes(j)) Then
                        Lb1.Items.RemoveAt(i)
                    End If
                Catch ex As Exception

                End Try
            Next
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

    Private Sub FrmBajaPlato_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim Bebida As Integer = 0
            If (RdbBebida.Checked) Then
                Bebida = 1
            End If
            Dim Id As Integer = Main.ListaPlatos.GetId(CmbPlatos.SelectedItem.ToString)
            'Main.ListaPlatosIngredientes.BorrarIngredientes(Id)
            Main.ListaPlatos.EliminarPlato(Id, TxtNombre.Text, TxtDescripcion.Text, Bebida, TxtPrecio.Text)
            'For i = 0 To Lb2.Items.Count - 1
            '    Main.ListaPlatosIngredientes.Nuevo(Id, Main.ListaIngredientes.Buscar(Lb2.Items(i).ToString))
            'Next
            MessageBox.Show("Plato eliminado con exito")
        Catch ex As Exception
            MessageBox.Show("Todos los campos deben estar rellenos")
        End Try
    End Sub
End Class