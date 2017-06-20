Imports System.ComponentModel

Public Class FrmLogin

    Dim Pos As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Pos = -1
        Main.UsuarioActual = -1
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Pos As Integer = Main.ListaUsuarios.GetTipo(TxtUsuario.Text, TxtClave.Text)
        If Pos = -1 Then
            MessageBox.Show("No existe el usuario")
        Else
            Main.UsuarioActual = Main.ListaUsuarios.GetId(TxtUsuario.Text)
            Main.LogActual = Main.ListaLogs.AddNewLog(Main.ListaUsuarios.GetId(TxtUsuario.Text))
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim resul
        resul = MessageBox.Show("Si continua, la aplicación se cerrará, ¿está de acuerdo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbYes Then
            Application.ExitThread()
        End If


    End Sub

    Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click
        Me.Close()
        'VentanaPrincipal.Focus()
        VentanaMail = New FrmEmail
        VentanaMail.MdiParent = FrmPrincipal
        VentanaMail.Show()


    End Sub

    'Private Sub FrmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    Dim resul As Byte
    '    resul = MessageBox.Show("¿Desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '    If resul = vbNo Then
    '        e.Cancel = True
    '    End If

    '    If resul = vbYes Then
    '        Application.ExitThread()
    '    End If

    'End Sub
End Class
