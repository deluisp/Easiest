Imports System.ComponentModel

Public Class FrmBajaEmpleados
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click



        Main.ListaEmpleados.BorrarEmpleado(TxtDni.Text)

        MessageBox.Show("El empleado ha sido eliminado con exito")

        TxtDni.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtNacimiento.Text = ""
        TxtEmail.Text = ""
        TxtTelefono.Text = ""
        TxtDireccion.Text = ""
        TxtCiudad.Text = ""
        TxtPais.Text = ""
        TxtTrabajo.Text = ""
        TxtSalario.Text = ""
        TxtRestaurante.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Main.ListaEmpleados.BuscarDNI(TxtDni.Text) Then

            TxtNombre.Text = Main.ListaEmpleados.GetNombre(TxtDni.Text)
            TxtApellido.Text = Main.ListaEmpleados.GetApellido(TxtDni.Text)
            TxtNacimiento.Text = Main.ListaEmpleados.GetNacimiento(TxtDni.Text)
            TxtEmail.Text = Main.ListaEmpleados.GetEmail(TxtDni.Text)
            TxtDireccion.Text = Main.ListaEmpleados.GetDireccion(TxtDni.Text)
            TxtCiudad.Text = Main.ListaEmpleados.GetCiudad(TxtDni.Text)
            TxtPais.Text = Main.ListaEmpleados.GetPais(TxtDni.Text)
            TxtTelefono.Text = Main.ListaEmpleados.GetTelefono(TxtDni.Text)
            TxtTrabajo.Text = Main.ListaEmpleados.GetTrabajo(TxtDni.Text)
            TxtSalario.Text = Main.ListaEmpleados.GetSalario(TxtDni.Text)
            TxtRestaurante.Text = Main.ListaEmpleados.GetRestaurante(TxtDni.Text)

        Else
            MessageBox.Show("No existe el empleado")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmBajaEmpleados_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub

End Class