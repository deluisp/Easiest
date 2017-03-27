Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Public Class FrmAltaUsuarios
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

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        If TxtUsuario.Text <> "" And TxtClave.Text <> "" And TxtEmail.Text <> "" Then
            If Not Main.ListaUsuarios.Buscar(TxtUsuario.Text) And Not Main.ListaUsuarios.BuscarEmail(TxtEmail.Text) And Not LblError.Visible Then
                Dim Tipo As Integer = 0
                If OptAvanzado.Checked Then Tipo = 2
                If OptMedio.Checked Then Tipo = 1

                Main.ListaUsuarios.Nuevo(TxtUsuario.Text, TxtClave.Text, TxtEmail.Text, Tipo)
                Main.DBManager.UpdateUsuarios()

                If (BtnAltas01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 1)
                If (BtnModificacion01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 2)
                If (BtnBajas01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 3)
                If (BtnConsultaB01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 4)
                If (BtnConsultaA01.Checked = True) Then Main.ListaPermisos.Nuevo(Main.ListaUsuarios.GetId(TxtUsuario.Text), 5)

                MessageBox.Show("Usuario añadido con exito")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub OptBasico_CheckedChanged(sender As Object, e As EventArgs) Handles OptBasico.CheckedChanged

    End Sub

    Private Sub OptMedio_CheckedChanged(sender As Object, e As EventArgs) Handles OptMedio.CheckedChanged
        BtnConsultaB01.Checked = True
        BtnConsultaA01.Checked = True
    End Sub

    Private Sub OptAvanzado_CheckedChanged(sender As Object, e As EventArgs) Handles OptAvanzado.CheckedChanged
        BtnAltas01.Checked = True
        BtnModificacion01.Checked = True
        BtnBajas01.Checked = True
        BtnConsultaB01.Checked = True
        BtnConsultaA01.Checked = True
    End Sub
End Class