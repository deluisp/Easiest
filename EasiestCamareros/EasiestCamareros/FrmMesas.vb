Imports System.ComponentModel

Public Class FrmMesas

    Private Sub btnAsignar01_Click(sender As Object, e As EventArgs) Handles btnAsignar01.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 01"

        btnAsignar01.Enabled = False
        btnLiberar01.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar01_Click(sender As Object, e As EventArgs) Handles btnLiberar01.Click
        btnAsignar01.Enabled = True
        btnLiberar01.Enabled = False
    End Sub

    Private Sub btnAsignar02_Click(sender As Object, e As EventArgs) Handles btnAsignar02.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 02"

        btnAsignar02.Enabled = False
        btnLiberar02.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar02_Click(sender As Object, e As EventArgs) Handles btnLiberar02.Click
        btnAsignar02.Enabled = True
        btnLiberar02.Enabled = False
    End Sub

    Private Sub btnAsignar03_Click(sender As Object, e As EventArgs) Handles btnAsignar03.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 03"

        btnAsignar03.Enabled = False
        btnLiberar03.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar03_Click(sender As Object, e As EventArgs) Handles btnLiberar03.Click
        btnAsignar03.Enabled = True
        btnLiberar03.Enabled = False
    End Sub

    Private Sub btnAsignar04_Click(sender As Object, e As EventArgs) Handles btnAsignar04.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 04"

        btnAsignar04.Enabled = False
        btnLiberar04.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar04_Click(sender As Object, e As EventArgs) Handles btnLiberar04.Click
        btnAsignar04.Enabled = True
        btnLiberar04.Enabled = False
    End Sub

    Private Sub btnAsignar05_Click(sender As Object, e As EventArgs) Handles btnAsignar05.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 05"

        btnAsignar05.Enabled = False
        btnLiberar05.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar05_Click(sender As Object, e As EventArgs) Handles btnLiberar05.Click
        btnAsignar05.Enabled = True
        btnLiberar05.Enabled = False
    End Sub

    Private Sub btnAsignar06_Click(sender As Object, e As EventArgs) Handles btnAsignar06.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 06"

        btnAsignar06.Enabled = False
        btnLiberar06.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar06_Click(sender As Object, e As EventArgs) Handles btnLiberar06.Click
        btnAsignar06.Enabled = True
        btnLiberar06.Enabled = False
    End Sub

    Private Sub btnAsignar07_Click(sender As Object, e As EventArgs) Handles btnAsignar07.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 07"

        btnAsignar07.Enabled = False
        btnLiberar07.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar07_Click(sender As Object, e As EventArgs) Handles btnLiberar07.Click
        btnAsignar07.Enabled = True
        btnLiberar07.Enabled = False
    End Sub

    Private Sub btnAsignar08_Click(sender As Object, e As EventArgs) Handles btnAsignar08.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 08"

        btnAsignar08.Enabled = False
        btnLiberar08.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar08_Click(sender As Object, e As EventArgs) Handles btnLiberar08.Click
        btnAsignar08.Enabled = True
        btnLiberar08.Enabled = False
    End Sub

    Private Sub btnAsignar09_Click(sender As Object, e As EventArgs) Handles btnAsignar09.Click
        FrmPedidos.TxtMesaAsignada.Text = "Mesa 09"

        btnAsignar09.Enabled = False
        btnLiberar09.Enabled = True

        VentanaPedidos = FrmPedidos
        VentanaPedidos.Show()
    End Sub

    Private Sub btnLiberar09_Click(sender As Object, e As EventArgs) Handles btnLiberar09.Click
        btnAsignar09.Enabled = True
        btnLiberar09.Enabled = False
    End Sub

    Private Sub FrmMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLiberar01.Enabled = False
        btnLiberar02.Enabled = False
        btnLiberar03.Enabled = False
        btnLiberar04.Enabled = False
        btnLiberar05.Enabled = False
        btnLiberar06.Enabled = False
        btnLiberar07.Enabled = False
        btnLiberar08.Enabled = False
        btnLiberar09.Enabled = False
    End Sub

    Private Sub FrmMesas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim resul As Byte
        resul = MessageBox.Show("El formulario se va a cerrar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resul = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class