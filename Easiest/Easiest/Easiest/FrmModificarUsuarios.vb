Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class FrmModificarUsuarios
    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles TxtClave.TextChanged
        LblError.Visible = False
        If Opt01.Checked = True Then
            If TxtClave.TextLength < 6 Then
                LblError.Visible = True
            End If
        End If
        If Opt02.Checked = True Then
            If Not Regex.IsMatch(TxtClave.Text, "[\p{L}\s]") Then
                LblError.Visible = True
            End If
        End If
        If Opt03.Checked = True Then
            If Not Regex.IsMatch(TxtClave.Text, "\d") Then
                LblError.Visible = True
            End If
        End If
        If Opt04.Checked = True Then
            If Not Regex.IsMatch(TxtClave.Text, "[A-Z]") Then
                LblError.Visible = True
            End If
        End If
        If Opt05.Checked = True Then
            If Not Regex.IsMatch(TxtClave.Text, "[a-z]") Then
                LblError.Visible = True
            End If
        End If
    End Sub

    Private Sub BtnAleatoria_Click(sender As Object, e As EventArgs) Handles BtnAleatoria.Click
        TxtClave.Text = Main.ListaUsuarios.CrearPassword(10)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Main.ListaUsuarios.Buscar(TxtUsuario.Text) Then
            TxtClave.Text = Main.ListaUsuarios.MostrarPass(TxtUsuario.Text)
            TxtEmail.Text = Main.ListaUsuarios.MostrarEmail(TxtUsuario.Text)

            If Main.ListaUsuarios.GetTipo(TxtUsuario.Text) = 0 Then OptBasico.Checked = True
            If Main.ListaUsuarios.GetTipo(TxtUsuario.Text) = 1 Then OptMedio.Checked = True
            If Main.ListaUsuarios.GetTipo(TxtUsuario.Text) = 2 Then OptAvanzado.Checked = True

            TxtUsuario.Enabled = False
            TxtClave.Enabled = True
            TxtEmail.Enabled = True
            Opt01.Enabled = True
            Opt02.Enabled = True
            Opt03.Enabled = True
            Opt04.Enabled = True
            Opt05.Enabled = True
            OptBasico.Enabled = True
            OptMedio.Enabled = True
            OptAvanzado.Enabled = True
            BtnModificar.Enabled = True
            BtnAltas01.Enabled = True
            BtnModificacion01.Enabled = True
            BtnBajas01.Enabled = True
            BtnConsultaB01.Enabled = True
            BtnConsultaA01.Enabled = True

            If (Main.ListaPermisos.BuscarPermiso(Main.ListaUsuarios.GetId(TxtUsuario.Text), 1)) Then BtnAltas01.Checked = True
            If (Main.ListaPermisos.BuscarPermiso(Main.ListaUsuarios.GetId(TxtUsuario.Text), 2)) Then BtnModificacion01.Checked = True
            If (Main.ListaPermisos.BuscarPermiso(Main.ListaUsuarios.GetId(TxtUsuario.Text), 3)) Then BtnBajas01.Checked = True
            If (Main.ListaPermisos.BuscarPermiso(Main.ListaUsuarios.GetId(TxtUsuario.Text), 4)) Then BtnConsultaB01.Checked = True
            If (Main.ListaPermisos.BuscarPermiso(Main.ListaUsuarios.GetId(TxtUsuario.Text), 5)) Then BtnConsultaA01.Checked = True

        Else
            MessageBox.Show("No existe el usuario")
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtUsuario.Text <> "" And TxtClave.Text <> "" And TxtEmail.Text <> "" Then
            If Not LblError.Visible Then
                Dim Tipo As Integer = 0
                If OptAvanzado.Checked Then Tipo = 2
                If OptMedio.Checked Then Tipo = 1

                Main.ListaUsuarios.ModificarUsuario(TxtUsuario.Text, TxtClave.Text, TxtEmail.Text, Tipo)
                Main.DBManager.UpdateUsuarios()

                Main.ListaPermisos.BorrarPermisos(Main.ListaUsuarios.GetId(TxtUsuario.Text))

                If (BtnAltas01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 1)
                If (BtnModificacion01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 2)
                If (BtnBajas01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 3)
                If (BtnConsultaB01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 4)
                If (BtnConsultaA01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 5)

                MessageBox.Show("Usuario modificado con exito")
                Me.Close()
            End If
        Else
            MessageBox.Show("Hay campos vacios")
        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmModificarUsuarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class