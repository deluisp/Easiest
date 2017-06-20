Imports System.ComponentModel

Public Class FrmBajaUsuarios
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        TxtTipo.Text = Main.ListaUsuarios.GetTipoByPos(Main.ListaUsuarios.GetPosUsuario(TxtUsuario.Text))
        TxtUltimaConexion.Text = Main.ListaLogs.GetUltimaConexion(Main.ListaUsuarios.GetId(TxtUsuario.Text))
        TxtTipo.Enabled = True
        TxtUltimaConexion.Enabled = True
        BtnDarDeBaja.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnDarDeBaja_Click(sender As Object, e As EventArgs) Handles BtnDarDeBaja.Click
        Main.ListaUsuarios.Borrar(TxtUsuario.Text)
    End Sub

    Private Sub FrmBajaUsuarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class