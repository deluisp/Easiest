Imports System.ComponentModel
Imports System.Windows.Forms

Public Class VentanaPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        '' Cree una nueva instancia del formulario secundario.
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Ventana " & m_ChildFormNumber

        'ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub VentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip.Enabled = False
        ToolStrip.Enabled = False
    End Sub

    Private Sub VentanaPrincipal_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        BtnAlta.Visible = False
        BtnModificar.Visible = False
        BtnBaja.Visible = False
        BtnSimple.Visible = False
        BtnCompleja.Visible = False

        MenuStrip.Enabled = True
        ToolStrip.Enabled = True
        If Main.ListaPermisos.BuscarPermiso(Main.UsuarioActual, 1) Then BtnAlta.Visible = True
        If Main.ListaPermisos.BuscarPermiso(Main.UsuarioActual, 2) Then BtnModificar.Visible = True
        If Main.ListaPermisos.BuscarPermiso(Main.UsuarioActual, 3) Then BtnBaja.Visible = True
        If Main.ListaPermisos.BuscarPermiso(Main.UsuarioActual, 4) Then BtnSimple.Visible = True
        If Main.ListaPermisos.BuscarPermiso(Main.UsuarioActual, 5) Then BtnCompleja.Visible = True

        'If Main.ListaUsuarios.GetTipoById(Main.UsuarioActual) = 2 Then
        '    MenuStrip.Enabled = True
        '    ToolStrip.Enabled = True
        'ElseIf Main.ListaUsuarios.GetTipoById(Main.UsuarioActual) = 1 Then
        '    MenuStrip.Enabled = True
        '    ToolStrip.Enabled = True
        '    BtnAlta.Visible = False
        '    BtnModificar.Visible = False
        '    BtnBaja.Visible = False
        'ElseIf Main.ListaUsuarios.GetTipoById(Main.UsuarioActual) = 0 Then
        '    MenuStrip.Enabled = True
        '    ToolStrip.Enabled = True
        '    BtnAlta.Visible = False
        '    BtnModificar.Visible = False
        '    BtnBaja.Visible = False
        '    ExportarLogs.Enabled = False
        'Else
        '    Me.Close()
        'End If
    End Sub

    Private Sub VentanaPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main.DBManager.AddNewLog(Main.ListaLogs.GetLog(Main.LogActual))
        Main.DBManager.UpdateLogs()
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        Dim FrmBaja As New FrmBajaUsuarios
        FrmBaja.MdiParent = Me
        FrmBaja.Show()
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        Dim FrmAlta As New FrmAltaUsuarios
        FrmAlta.MdiParent = Me
        FrmAlta.Show()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModificacion As New FrmModificarUsuarios
        FrmModificacion.MdiParent = Me
        FrmModificacion.Show()
    End Sub

    Private Sub ExportarLogs_Click(sender As Object, e As EventArgs) Handles ExportarLogs.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de log (*.log)|*.log|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            If Main.ListaLogs.ExportarLogs(FileName) Then
                MessageBox.Show("Logs exportados con éxito")
            Else
                MessageBox.Show("Error al exportar logs")
            End If
        End If
    End Sub

    Private Sub BtnClave_Click(sender As Object, e As EventArgs) Handles BtnClave.Click
        Dim FrmModificarClave As New FrmModificarClave
        FrmModificarClave.MdiParent = Me
        FrmModificarClave.Show()
    End Sub

    Private Sub BtnSimple_Click(sender As Object, e As EventArgs) Handles BtnSimple.Click
        Dim FrmSimple As New UsuariosConsulta
        FrmSimple.MdiParent = Me
        FrmSimple.Show()
    End Sub

    Private Sub BtnCompleja_Click(sender As Object, e As EventArgs) Handles BtnCompleja.Click
        Dim FrmCompleja As New UsuariosConsultaCompl
        FrmCompleja.MdiParent = Me
        FrmCompleja.Show()
    End Sub

    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem.Click
        FrmAltaEmpleado.Show()
    End Sub

    Private Sub ModificaciónDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaciónDeEmpleadoToolStripMenuItem.Click
        FrmModificarEmpleado.Show()
    End Sub

    Private Sub BajaDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeEmpleadoToolStripMenuItem.Click
        FrmBajaEmpleados.Show()
    End Sub
End Class
