Public Class FrmBajaUsuarios
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        TxtTipo.Text = Main.ListaUsuarios.GetTipoByPos(Main.ListaUsuarios.GetPosUsuario(TxtUsuario.Text))
        TxtUltimaConexion.Text = Main.ListaLogs.GetUltimaConexion(Main.ListaUsuarios.GetId(TxtUsuario.Text))
        TxtTipo.Enabled = True
        TxtUltimaConexion.Enabled = True
        BtnDarDeBaja.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnDarDeBaja_Click(sender As Object, e As EventArgs) Handles BtnDarDeBaja.Click
        Main.ListaUsuarios.Borrar(TxtUsuario.Text)
    End Sub
End Class