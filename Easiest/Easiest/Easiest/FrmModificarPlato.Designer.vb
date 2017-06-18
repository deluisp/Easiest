<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarPlato
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
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Lb1 = New System.Windows.Forms.ListBox()
        Me.RdbBebida = New System.Windows.Forms.RadioButton()
        Me.RdbComida = New System.Windows.Forms.RadioButton()
        Me.TxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lb2 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbPlatos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(130, 76)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(186, 20)
        Me.TxtPrecio.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Precio: "
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(335, 280)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(186, 23)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(130, 280)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(186, 23)
        Me.BtnCancelar.TabIndex = 26
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.FormattingEnabled = True
        Me.Lb1.Location = New System.Drawing.Point(335, 127)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(161, 147)
        Me.Lb1.TabIndex = 25
        '
        'RdbBebida
        '
        Me.RdbBebida.AutoSize = True
        Me.RdbBebida.Location = New System.Drawing.Point(226, 104)
        Me.RdbBebida.Name = "RdbBebida"
        Me.RdbBebida.Size = New System.Drawing.Size(58, 17)
        Me.RdbBebida.TabIndex = 24
        Me.RdbBebida.TabStop = True
        Me.RdbBebida.Text = "Bebida"
        Me.RdbBebida.UseVisualStyleBackColor = True
        '
        'RdbComida
        '
        Me.RdbComida.AutoSize = True
        Me.RdbComida.Location = New System.Drawing.Point(130, 104)
        Me.RdbComida.Name = "RdbComida"
        Me.RdbComida.Size = New System.Drawing.Size(60, 17)
        Me.RdbComida.TabIndex = 23
        Me.RdbComida.TabStop = True
        Me.RdbComida.Text = "Comida"
        Me.RdbComida.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(130, 127)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(186, 147)
        Me.TxtDescripcion.TabIndex = 22
        Me.TxtDescripcion.Text = ""
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(130, 50)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(186, 20)
        Me.TxtNombre.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descripción: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tipo: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre: "
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(502, 247)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(63, 23)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(502, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(502, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(502, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lb2
        '
        Me.Lb2.FormattingEnabled = True
        Me.Lb2.Location = New System.Drawing.Point(571, 124)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(161, 147)
        Me.Lb2.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Seleccione un plato:  "
        '
        'CmbPlatos
        '
        Me.CmbPlatos.FormattingEnabled = True
        Me.CmbPlatos.Location = New System.Drawing.Point(130, 6)
        Me.CmbPlatos.Name = "CmbPlatos"
        Me.CmbPlatos.Size = New System.Drawing.Size(186, 21)
        Me.CmbPlatos.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Ingredientes: "
        '
        'FrmModificarPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 315)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbPlatos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.RdbBebida)
        Me.Controls.Add(Me.RdbComida)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmModificarPlato"
        Me.Text = "FrmModificarPlato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Lb1 As ListBox
    Friend WithEvents RdbBebida As RadioButton
    Friend WithEvents RdbComida As RadioButton
    Friend WithEvents TxtDescripcion As RichTextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Lb2 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbPlatos As ComboBox
    Friend WithEvents Label6 As Label
End Class
