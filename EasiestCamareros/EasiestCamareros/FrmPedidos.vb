Imports System.ComponentModel

Public Class FrmPedidos

    'Cambios en el modo diseñador'
    'Los textbox tienen la propiedad ReadOnly en True, ya que solo queremos que se muestre el pedido'

    Private Sub FrmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TxtMesaAsignada.Text = "" Then
            btnLiberar.Enabled = False
        End If

        If Not TxtMesaAsignada.Text = "" Then
            btnAsignar.Enabled = False
        End If

    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        VentanaMesas = FrmMesas
        VentanaMesas.Show()

        Me.Close()
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click



        If TxtMesaAsignada.Text = "Mesa 01" Then
            Me.Close()
            VentanaMesas.btnAsignar01.Focus()
            VentanaMesas.btnAsignar01.Enabled = True
            VentanaMesas.btnLiberar01.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 02" Then
            Me.Close()
            VentanaMesas.btnAsignar02.Focus()
            VentanaMesas.btnAsignar02.Enabled = True
            VentanaMesas.btnLiberar02.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 03" Then
            Me.Close()
            VentanaMesas.btnAsignar03.Focus()
            VentanaMesas.btnAsignar03.Enabled = True
            VentanaMesas.btnLiberar03.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 04" Then
            Me.Close()
            VentanaMesas.btnAsignar04.Focus()
            VentanaMesas.btnAsignar04.Enabled = True
            VentanaMesas.btnLiberar04.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 05" Then
            Me.Close()
            VentanaMesas.btnAsignar05.Focus()
            VentanaMesas.btnAsignar05.Enabled = True
            VentanaMesas.btnLiberar05.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 06" Then
            Me.Close()
            VentanaMesas.btnAsignar06.Focus()
            VentanaMesas.btnAsignar06.Enabled = True
            VentanaMesas.btnLiberar06.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 07" Then
            Me.Close()
            VentanaMesas.btnAsignar07.Focus()
            VentanaMesas.btnAsignar07.Enabled = True
            VentanaMesas.btnLiberar07.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 08" Then
            Me.Close()
            VentanaMesas.btnAsignar08.Focus()
            VentanaMesas.btnAsignar08.Enabled = True
            VentanaMesas.btnLiberar08.Enabled = False
        End If

        If TxtMesaAsignada.Text = "Mesa 09" Then
            Me.Close()
            VentanaMesas.btnAsignar09.Focus()
            VentanaMesas.btnAsignar09.Enabled = True
            VentanaMesas.btnLiberar09.Enabled = False
        End If
    End Sub

End Class