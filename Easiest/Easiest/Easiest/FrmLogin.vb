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
        Me.Close()
    End Sub

    Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click
        FrmEmail.Show()
    End Sub
End Class
