Public Class FrmModificarClave
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtActual.Text <> "" And TxtNueva.Text <> "" And TxtConfirmacion.Text <> "" Then
            If Main.ListaUsuarios.GetClave(UsuarioActual) <> "" And TxtNueva.Text = TxtConfirmacion.Text Then
                Main.ListaUsuarios.ModificarUsuario(UsuarioActual, TxtNueva.Text)
                Main.DBManager.UpdateUsuarios()
                MessageBox.Show("Clave modificada con éxito")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class