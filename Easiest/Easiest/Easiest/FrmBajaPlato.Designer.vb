<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaPlato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajaPlato))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmbPlatos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lb2 = New System.Windows.Forms.ListBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Lb1 = New System.Windows.Forms.ListBox()
        Me.RdbBebida = New System.Windows.Forms.RadioButton()
        Me.RdbComida = New System.Windows.Forms.RadioButton()
        Me.TxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.CmbPlatos)
        Me.GroupBox1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 78)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Seleccione un plato:  "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(619, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'CmbPlatos
        '
        Me.CmbPlatos.FormattingEnabled = True
        Me.CmbPlatos.Location = New System.Drawing.Point(277, 30)
        Me.CmbPlatos.Name = "CmbPlatos"
        Me.CmbPlatos.Size = New System.Drawing.Size(186, 23)
        Me.CmbPlatos.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Ingredientes: "
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(500, 299)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(63, 23)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(500, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(500, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 23)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(500, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lb2
        '
        Me.Lb2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.FormattingEnabled = True
        Me.Lb2.ItemHeight = 15
        Me.Lb2.Location = New System.Drawing.Point(569, 176)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lb2.Size = New System.Drawing.Size(161, 139)
        Me.Lb2.TabIndex = 52
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(128, 128)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(186, 22)
        Me.TxtPrecio.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Precio: "
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(128, 332)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(186, 23)
        Me.BtnEliminar.TabIndex = 49
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(333, 332)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(186, 23)
        Me.BtnCancelar.TabIndex = 48
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.FormattingEnabled = True
        Me.Lb1.ItemHeight = 15
        Me.Lb1.Location = New System.Drawing.Point(333, 179)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Lb1.Size = New System.Drawing.Size(161, 139)
        Me.Lb1.TabIndex = 47
        '
        'RdbBebida
        '
        Me.RdbBebida.AutoSize = True
        Me.RdbBebida.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbBebida.Location = New System.Drawing.Point(224, 156)
        Me.RdbBebida.Name = "RdbBebida"
        Me.RdbBebida.Size = New System.Drawing.Size(62, 19)
        Me.RdbBebida.TabIndex = 46
        Me.RdbBebida.TabStop = True
        Me.RdbBebida.Text = "Bebida"
        Me.RdbBebida.UseVisualStyleBackColor = True
        '
        'RdbComida
        '
        Me.RdbComida.AutoSize = True
        Me.RdbComida.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbComida.Location = New System.Drawing.Point(128, 156)
        Me.RdbComida.Name = "RdbComida"
        Me.RdbComida.Size = New System.Drawing.Size(68, 19)
        Me.RdbComida.TabIndex = 45
        Me.RdbComida.TabStop = True
        Me.RdbComida.Text = "Comida"
        Me.RdbComida.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(128, 179)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(186, 147)
        Me.TxtDescripcion.TabIndex = 44
        Me.TxtDescripcion.Text = ""
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(128, 102)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(186, 22)
        Me.TxtNombre.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Descripción: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Tipo: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nombre: "
        '
        'FrmBajaPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.RdbBebida)
        Me.Controls.Add(Me.RdbComida)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBajaPlato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar un plato"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CmbPlatos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Lb2 As ListBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Lb1 As ListBox
    Friend WithEvents RdbBebida As RadioButton
    Friend WithEvents RdbComida As RadioButton
    Friend WithEvents TxtDescripcion As RichTextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
