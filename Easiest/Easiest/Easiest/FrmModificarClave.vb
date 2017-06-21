Imports System.ComponentModel

Public Class FrmModificarClave
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtActual.Text <> "" And TxtNueva.Text <> "" And TxtConfirmacion.Text <> "" Then
            If Main.ListaUsuarios.GetClave(UsuarioActual) <> "" And TxtNueva.Text = TxtConfirmacion.Text Then
                Main.ListaUsuarios.ModificarUsuario(UsuarioActual, TxtNueva.Text)
                Main.DBManager.UpdateUsuarios()
                MessageBox.Show("Clave modificada con éxito, el formulario se cerrará")
                Me.Close()
            Else
                MessageBox.Show("El usuario no existe")
                TxtActual.Text = ""
                TxtNueva.Text = ""
                TxtConfirmacion.Text = ""
            End If
        Else
            MessageBox.Show("No deben quedar campos vacios")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmModificarClave_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub

End Class