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
End Class