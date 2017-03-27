<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosConsultaCompl
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
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.GtdConsulta = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTabla = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.GtdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.Location = New System.Drawing.Point(12, 23)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(95, 13)
        Me.lblConsulta.TabIndex = 0
        Me.lblConsulta.Text = "Consulta a buscar:"
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(160, 20)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(521, 20)
        Me.txtConsulta.TabIndex = 1
        '
        'GtdConsulta
        '
        Me.GtdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GtdConsulta.Location = New System.Drawing.Point(12, 149)
        Me.GtdConsulta.Name = "GtdConsulta"
        Me.GtdConsulta.Size = New System.Drawing.Size(692, 195)
        Me.GtdConsulta.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(15, 111)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(319, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tabla de la Base de Datos: "
        '
        'txtTabla
        '
        Me.txtTabla.Location = New System.Drawing.Point(160, 54)
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.Size = New System.Drawing.Size(174, 20)
        Me.txtTabla.TabIndex = 5
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(385, 111)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(319, 23)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'UsuariosConsultaCompl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 356)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtTabla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GtdConsulta)
        Me.Controls.Add(Me.txtConsulta)
        Me.Controls.Add(Me.lblConsulta)
        Me.Name = "UsuariosConsultaCompl"
        Me.Text = "UsuariosConsultaCompl"
        CType(Me.GtdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConsulta As Label
    Friend WithEvents txtConsulta As TextBox
    Friend WithEvents GtdConsulta As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTabla As TextBox
    Friend WithEvents btnLimpiar As Button
End Class
