Imports System.Net
Imports System.Net.Mail
Public Class FrmEmail

    Dim clave As String

    Dim Mensaje As New MailMessage()
    Dim Servidor As New SmtpClient

    Dim Emisor As String = "proyecto.net.easiest@gmail.com"
    Dim ClaveEmisor As String = "Proyectoeasiest"
    Dim Asunto As String = "Recuperacion de clave"


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        TxtEmail.Text = Main.ListaUsuarios.GetUsuario(TxtUsuario.Text)
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        clave = Main.ListaUsuarios.MostrarPass(TxtUsuario.Text)

        'Configuracion SMTP'
        Servidor.Credentials = New NetworkCredential(Emisor, ClaveEmisor)
        Servidor.Host = "smtp.gmail.com"
        Servidor.Port = 587
        Servidor.EnableSsl = True

        'Mensaje'
        Mensaje.To.Add(TxtEmail.Text) 'contraseña del usuario'
        Mensaje.From = New MailAddress(Emisor, "Admin", System.Text.Encoding.UTF8)
        Mensaje.Subject = Asunto
        Mensaje.SubjectEncoding = System.Text.Encoding.UTF8
        Mensaje.Body = "Su clave es la siguiente: " + clave
        Mensaje.BodyEncoding = System.Text.Encoding.UTF8

        Mensaje.Priority = MailPriority.High
        Mensaje.IsBodyHtml = False

        'Envio'
        Try
            Servidor.Send(Mensaje)
            MessageBox.Show("Su clave ha sido enviada", "Enviado", MessageBoxButtons.OK)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error. No se ha podido enviar la clave a la direccion de correo", "Error", MessageBoxButtons.OK)
        End Try





    End Sub
End Class