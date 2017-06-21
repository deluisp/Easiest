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

        TxtCamarero.Text = Main.ListaEmpleados.GetNombre(Main.EmpleadoActual) & " " & Main.ListaEmpleados.GetApellido(Main.EmpleadoActual)

        For i = 0 To Main.ListaPlatos.Lista.Count - 1
            If Main.ListaPlatos.Lista(i).Tipo = 1 Then lbEntrantes.Items.Add(Main.ListaPlatos.Lista(i).Nombre)
            If Main.ListaPlatos.Lista(i).Tipo = 2 Then lbPrimerPlato.Items.Add(Main.ListaPlatos.Lista(i).Nombre)
            If Main.ListaPlatos.Lista(i).Tipo = 3 Then LbSegundoPlato.Items.Add(Main.ListaPlatos.Lista(i).Nombre)
            If Main.ListaPlatos.Lista(i).Tipo = 4 Then lbPostre.Items.Add(Main.ListaPlatos.Lista(i).Nombre)
            If Main.ListaPlatos.Lista(i).Tipo = 5 Then lbBebida.Items.Add(Main.ListaPlatos.Lista(i).Nombre)
        Next

    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        VentanaMesas = FrmMesas
        VentanaMesas.Show()

        Me.Close()
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click

        Dim IdPedido = Main.ListaPedidos.Nuevo(Now, 1, Main.EmpleadoActual)
        Dim Leidos = New List(Of String)

        For i = 0 To lbTicket.Items.Count - 1
            If Not Leidos.Contains(lbTicket.Items(i).ToString) Then
                Dim Contador As Integer = 0
                For j = 0 To lbTicket.Items.Count - 1
                    If lbTicket.Items(i) = lbTicket.Items(j) Then Contador = Contador + 1
                Next
                Main.ListaLineasPedido.Nuevo(IdPedido, Main.ListaPlatos.GetId(lbTicket.Items(i)), Contador)
                Leidos.Add(lbTicket.Items(i).ToString)
            End If
        Next

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

    Private Sub btnEntrantes_Click(sender As Object, e As EventArgs) Handles btnEntrantes.Click, lbEntrantes.DoubleClick
        Try
            lbTicket.Items.Add(lbEntrantes.SelectedItem)
            ActualizarPrecio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrimerPlato_Click(sender As Object, e As EventArgs) Handles btnPrimerPlato.Click, lbPrimerPlato.DoubleClick
        Try
            lbTicket.Items.Add(lbPrimerPlato.SelectedItem)
            ActualizarPrecio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSegundoPlato_Click(sender As Object, e As EventArgs) Handles btnSegundoPlato.Click, LbSegundoPlato.DoubleClick
        Try
            lbTicket.Items.Add(LbSegundoPlato.SelectedItem)
            ActualizarPrecio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPostres_Click(sender As Object, e As EventArgs) Handles btnPostres.Click, lbPostre.DoubleClick
        Try
            lbTicket.Items.Add(lbPostre.SelectedItem)
            ActualizarPrecio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnBebidas.Click, lbBebida.DoubleClick
        Try
            lbTicket.Items.Add(lbBebida.SelectedItem)
            ActualizarPrecio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbTicket_DoubleClick(sender As Object, e As EventArgs) Handles lbTicket.DoubleClick
        Try
            lbTicket.Items.Remove(lbTicket.SelectedItem)
            ActualizarPrecio()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActualizarPrecio()
        Dim Precio As Double = 0
        For i = 0 To lbTicket.Items.Count - 1
            Precio = Precio + Main.ListaPlatos.GetPrecio(lbTicket.Items(i))
        Next
        txtSubtotal.Text = Precio.ToString
        txtTotal.Text = Precio * 1.21
    End Sub

End Class