<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaIngrediente
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.BtnAnadir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAnadirTipo = New System.Windows.Forms.Button()
        Me.BtnAnadirCategoria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(225, 29)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(214, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Categoría: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción: "
        '
        'CmbTipo
        '
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(225, 55)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(164, 21)
        Me.CmbTipo.TabIndex = 5
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(225, 82)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(164, 21)
        Me.CmbCategoria.TabIndex = 6
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(127, 109)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(312, 131)
        Me.TxtDescripcion.TabIndex = 7
        Me.TxtDescripcion.Text = ""
        '
        'BtnAnadir
        '
        Me.BtnAnadir.Location = New System.Drawing.Point(261, 255)
        Me.BtnAnadir.Name = "BtnAnadir"
        Me.BtnAnadir.Size = New System.Drawing.Size(178, 23)
        Me.BtnAnadir.TabIndex = 8
        Me.BtnAnadir.Text = "Añadir Ingrediente"
        Me.BtnAnadir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(35, 255)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(189, 23)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAnadirTipo
        '
        Me.BtnAnadirTipo.Location = New System.Drawing.Point(395, 55)
        Me.BtnAnadirTipo.Name = "BtnAnadirTipo"
        Me.BtnAnadirTipo.Size = New System.Drawing.Size(44, 21)
        Me.BtnAnadirTipo.TabIndex = 10
        Me.BtnAnadirTipo.Text = "+"
        Me.BtnAnadirTipo.UseVisualStyleBackColor = True
        '
        'BtnAnadirCategoria
        '
        Me.BtnAnadirCategoria.Location = New System.Drawing.Point(395, 82)
        Me.BtnAnadirCategoria.Name = "BtnAnadirCategoria"
        Me.BtnAnadirCategoria.Size = New System.Drawing.Size(44, 21)
        Me.BtnAnadirCategoria.TabIndex = 11
        Me.BtnAnadirCategoria.Text = "+"
        Me.BtnAnadirCategoria.UseVisualStyleBackColor = True
        '
        'FrmAltaIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 297)
        Me.Controls.Add(Me.BtnAnadirCategoria)
        Me.Controls.Add(Me.BtnAnadirTipo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAnadir)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Name = "FrmAltaIngrediente"
        Me.Text = "Alta de Ingrediente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents TxtDescripcion As RichTextBox
    Friend WithEvents BtnAnadir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAnadirTipo As Button
    Friend WithEvents BtnAnadirCategoria As Button
End Class
