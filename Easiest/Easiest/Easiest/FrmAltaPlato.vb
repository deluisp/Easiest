Public Class FrmAltaPlato

    Private Sub FrmAltaPlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Main.ListaIngredientes.Lista.Count - 1
            Lb1.Items.Add(Main.ListaIngredientes.Lista(i).Nombre)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Lb2.Items.Add(Lb1.SelectedItem)
        Lb1.Items.Remove(Lb1.SelectedItem)
    End Sub

    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        Dim IdPlato = Main.ListaPlatos.Nuevo(TxtNombre.Text, TxtDescripcion.Text, RdbBebida.Checked, TxtPrecio.Text)
        For i = 0 To Lb2.Items.Count - 1
            Main.ListaPlatosIngredientes.Nuevo(IdPlato, Main.ListaIngredientes.Buscar(Lb2.Items(i).ToString))
        Next
    End Sub

End Class