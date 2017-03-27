<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarClave
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
        Me.TxtActual = New System.Windows.Forms.TextBox()
        Me.TxtNueva = New System.Windows.Forms.TextBox()
        Me.TxtConfirmacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtActual
        '
        Me.TxtActual.Location = New System.Drawing.Point(160, 32)
        Me.TxtActual.Name = "TxtActual"
        Me.TxtActual.Size = New System.Drawing.Size(100, 20)
        Me.TxtActual.TabIndex = 0
        '
        'TxtNueva
        '
        Me.TxtNueva.Location = New System.Drawing.Point(160, 71)
        Me.TxtNueva.Name = "TxtNueva"
        Me.TxtNueva.Size = New System.Drawing.Size(100, 20)
        Me.TxtNueva.TabIndex = 1
        '
        'TxtConfirmacion
        '
        Me.TxtConfirmacion.Location = New System.Drawing.Point(160, 97)
        Me.TxtConfirmacion.Name = "TxtConfirmacion"
        Me.TxtConfirmacion.Size = New System.Drawing.Size(100, 20)
        Me.TxtConfirmacion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clave actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave Nueva:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirmación nueva:"
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(39, 158)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 6
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(185, 158)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmModificarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 208)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtConfirmacion)
        Me.Controls.Add(Me.TxtNueva)
        Me.Controls.Add(Me.TxtActual)
        Me.Name = "FrmModificarClave"
        Me.Text = "FrmModificarClave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtActual As TextBox
    Friend WithEvents TxtNueva As TextBox
    Friend WithEvents TxtConfirmacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnCancelar As Button
End Class
