Imports System.ComponentModel

Public Class FrmModificarEmpleado
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

            TxtNombre.ReadOnly = False
            TxtApellido.ReadOnly = False
            TxtDni.ReadOnly = False
            TxtNacimiento.ReadOnly = False
            TxtEmail.ReadOnly = False
            TxtTelefono.ReadOnly = False
            TxtCiudad.ReadOnly = False
            TxtDireccion.ReadOnly = False
            TxtPais.ReadOnly = False
            TxtTrabajo.ReadOnly = False
            TxtSalario.ReadOnly = False
            TxtRestaurante.ReadOnly = False

        Else
            MessageBox.Show("El empleado no existe")

        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtNombre.Text <> "" And TxtApellido.Text <> "" And TxtNacimiento.Text <> "" And TxtEmail.Text <> "" And TxtDireccion.Text <> "" And TxtCiudad.Text <> "" And TxtPais.Text <> "" And TxtTelefono.Text <> "" And TxtTrabajo.Text <> "" And TxtSalario.Text <> "" And TxtRestaurante.Text <> "" And TxtDni.Text <> "" Then

            Main.ListaEmpleados.ModificarEmpleado(TxtNombre.Text, TxtApellido.Text, TxtNacimiento.Text, TxtEmail.Text, TxtDireccion.Text, TxtCiudad.Text, TxtPais.Text, TxtTelefono.Text, TxtTrabajo.Text, TxtSalario.Text, TxtRestaurante.Text, TxtDni.Text)
            Main.DBManager.UpdateEmployer()

            MessageBox.Show("Empleado modificado con exito, se cerrará el formulario.")
            Me.Close()
        Else
            MessageBox.Show("No se pueden dejar campos en blanco")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resul
        resul = MessageBox.Show("Va a cancelar la acción, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmModificarEmpleado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmModificarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class