Public Class EasiestCamareros
    Private Sub EasiestCamareros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BarraMenu.Enabled = False


        BarraMenu.Focus()


    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub CerrarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesasToolStripMenuItem.Click
        VentanaMesas = New FrmMesas
        VentanaMesas.MdiParent = Me
        VentanaMesas.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click

    End Sub

    Private Sub ListadoPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoPedidosToolStripMenuItem.Click
        VentanaPedidos = FrmPedidos
        VentanaPedidos.MdiParent = Me
        VentanaPedidos.Show()
    End Sub

    Private Sub EasiestCamareros_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        BarraMenu.Enabled = True
    End Sub
End Class
