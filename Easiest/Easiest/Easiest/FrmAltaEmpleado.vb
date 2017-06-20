Imports System.ComponentModel

Public Class FrmAltaEmpleado
    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        If TxtNombre.Text <> "" And TxtApellido.Text <> "" And TxtDni.Text <> "" And TxtNacimiento.Text <> "" And TxtEmail.Text <> "" And TxtTelefono.Text <> "" And TxtCiudad.Text <> "" And TxtCiudad.Text <> "" And TxtPais.Text <> "" And TxtTrabajo.Text <> "" And TxtSalario.Text <> "" And TxtRestaurante.Text <> "" Then
            If Not Main.ListaEmpleados.BuscarDNI(TxtDni.Text) Then



                Main.ListaEmpleados.Nuevo(TxtDni.Text, TxtNombre.Text, TxtApellido.Text, TxtNacimiento.Text, TxtEmail.Text, TxtDireccion.Text, TxtCiudad.Text, TxtPais.Text, TxtTelefono.Text, TxtTrabajo.Text, TxtSalario.Text, TxtRestaurante.Text)
                Main.DBManager.UpdateUsuarios()



                MessageBox.Show("Usuario añadido con exito")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAltaEmpleado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class