Public Class FrmModificarPlato
    Private Sub FrmModificarPlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim Bebida As Integer = 0
        If (RdbBebida.Checked) Then
            Bebida = 1
        End If
        Dim Id As Integer = Main.ListaPlatos.GetId(CmbPlatos.SelectedItem.ToString)
        Main.ListaPlatosIngredientes.BorrarIngredientes(Id)
        Main.ListaPlatos.ModificarPlato(Id, TxtNombre.Text, TxtDescripcion.Text, Bebida, TxtPrecio.Text)
        For i = 0 To Lb2.Items.Count - 1
            Main.ListaPlatosIngredientes.Nuevo(Id, Main.ListaIngredientes.Buscar(Lb2.Items(i).ToString))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Lb2.Items.Add(Lb1.SelectedItem)
        Lb1.Items.Remove(Lb1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Lb1.Items.Add(Lb2.SelectedItem)
        Lb2.Items.Remove(Lb2.SelectedItem)
    End Sub
End Class