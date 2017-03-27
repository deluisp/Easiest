<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaUsuarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.TxtUltimaConexion = New System.Windows.Forms.TextBox()
        Me.BtnDarDeBaja = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(125, 33)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ultima Conexion:"
        '
        'TxtTipo
        '
        Me.TxtTipo.Enabled = False
        Me.TxtTipo.Location = New System.Drawing.Point(125, 153)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(100, 20)
        Me.TxtTipo.TabIndex = 4
        '
        'TxtUltimaConexion
        '
        Me.TxtUltimaConexion.Enabled = False
        Me.TxtUltimaConexion.Location = New System.Drawing.Point(126, 178)
        Me.TxtUltimaConexion.Name = "TxtUltimaConexion"
        Me.TxtUltimaConexion.ReadOnly = True
        Me.TxtUltimaConexion.Size = New System.Drawing.Size(100, 20)
        Me.TxtUltimaConexion.TabIndex = 5
        '
        'BtnDarDeBaja
        '
        Me.BtnDarDeBaja.Enabled = False
        Me.BtnDarDeBaja.Location = New System.Drawing.Point(37, 222)
        Me.BtnDarDeBaja.Name = "BtnDarDeBaja"
        Me.BtnDarDeBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnDarDeBaja.TabIndex = 6
        Me.BtnDarDeBaja.Text = "Dar de Baja"
        Me.BtnDarDeBaja.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(151, 222)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(37, 59)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(188, 23)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmBajaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnDarDeBaja)
        Me.Controls.Add(Me.TxtUltimaConexion)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBajaUsuarios"
        Me.Text = "Baja de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents TxtUltimaConexion As TextBox
    Friend WithEvents BtnDarDeBaja As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBuscar As Button
End Class
