<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EasiestCamareros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasiestCamareros))
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolSesion, Me.MesasToolStripMenuItem, Me.PedidosToolStripMenuItem})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.BarraMenu.Size = New System.Drawing.Size(1192, 29)
        Me.BarraMenu.TabIndex = 1
        Me.BarraMenu.Text = "MenuStrip1"
        '
        'ToolSesion
        '
        Me.ToolSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.CerrarAplicaciónToolStripMenuItem})
        Me.ToolSesion.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolSesion.Image = CType(resources.GetObject("ToolSesion.Image"), System.Drawing.Image)
        Me.ToolSesion.Name = "ToolSesion"
        Me.ToolSesion.Size = New System.Drawing.Size(77, 23)
        Me.ToolSesion.Text = "Sesión"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar aplicación"
        '
        'MesasToolStripMenuItem
        '
        Me.MesasToolStripMenuItem.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesasToolStripMenuItem.Image = CType(resources.GetObject("MesasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem"
        Me.MesasToolStripMenuItem.Size = New System.Drawing.Size(74, 23)
        Me.MesasToolStripMenuItem.Text = "Mesas"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoPedidosToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PedidosToolStripMenuItem.Image = CType(resources.GetObject("PedidosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(86, 23)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'ListadoPedidosToolStripMenuItem
        '
        Me.ListadoPedidosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListadoPedidosToolStripMenuItem.Name = "ListadoPedidosToolStripMenuItem"
        Me.ListadoPedidosToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.ListadoPedidosToolStripMenuItem.Text = "Listado pedidos"
        '
        'EasiestCamareros
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1192, 585)
        Me.Controls.Add(Me.BarraMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.BarraMenu
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "EasiestCamareros"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraMenu As MenuStrip
    Friend WithEvents ToolSesion As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoPedidosToolStripMenuItem As ToolStripMenuItem
End Class
