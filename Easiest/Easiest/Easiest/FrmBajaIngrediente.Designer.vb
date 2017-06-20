<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaIngrediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajaIngrediente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnAnadirCategoria = New System.Windows.Forms.Button()
        Me.BtnAnadirTipo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 145)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(265, 98)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(178, 23)
        Me.BtnBuscar.TabIndex = 21
        Me.BtnBuscar.Text = "Buscar ingrediente"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre: "
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(353, 35)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(214, 22)
        Me.TxtNombre.TabIndex = 12
        '
        'BtnAnadirCategoria
        '
        Me.BtnAnadirCategoria.Location = New System.Drawing.Point(486, 188)
        Me.BtnAnadirCategoria.Name = "BtnAnadirCategoria"
        Me.BtnAnadirCategoria.Size = New System.Drawing.Size(44, 21)
        Me.BtnAnadirCategoria.TabIndex = 34
        Me.BtnAnadirCategoria.Text = "+"
        Me.BtnAnadirCategoria.UseVisualStyleBackColor = True
        '
        'BtnAnadirTipo
        '
        Me.BtnAnadirTipo.Location = New System.Drawing.Point(486, 215)
        Me.BtnAnadirTipo.Name = "BtnAnadirTipo"
        Me.BtnAnadirTipo.Size = New System.Drawing.Size(44, 21)
        Me.BtnAnadirTipo.TabIndex = 33
        Me.BtnAnadirTipo.Text = "+"
        Me.BtnAnadirTipo.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(354, 421)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(189, 23)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(105, 421)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(178, 23)
        Me.BtnEliminar.TabIndex = 31
        Me.BtnEliminar.Text = "Eliminar Ingrediente"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(182, 242)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(312, 131)
        Me.TxtDescripcion.TabIndex = 30
        Me.TxtDescripcion.Text = ""
        '
        'CmbCategoria
        '
        Me.CmbCategoria.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(280, 188)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(164, 23)
        Me.CmbCategoria.TabIndex = 29
        '
        'CmbTipo
        '
        Me.CmbTipo.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(280, 215)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(164, 23)
        Me.CmbTipo.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Descripción: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Categoría: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tipo: "
        '
        'FrmBajaIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnAnadirCategoria)
        Me.Controls.Add(Me.BtnAnadirTipo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBajaIngrediente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Ingrediente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnAnadirCategoria As Button
    Friend WithEvents BtnAnadirTipo As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtDescripcion As RichTextBox
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
