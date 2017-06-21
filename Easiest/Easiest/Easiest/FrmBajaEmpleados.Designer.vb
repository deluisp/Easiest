<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajaEmpleados))
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNacimiento = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRestaurante = New System.Windows.Forms.TextBox()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.TxtTrabajo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(355, 104)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(129, 23)
        Me.btnBuscar.TabIndex = 81
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TxtDni
        '
        Me.TxtDni.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDni.Location = New System.Drawing.Point(290, 24)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(157, 22)
        Me.TxtDni.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "DNI:"
        '
        'TxtNacimiento
        '
        Me.TxtNacimiento.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNacimiento.Location = New System.Drawing.Point(227, 224)
        Me.TxtNacimiento.Name = "TxtNacimiento"
        Me.TxtNacimiento.ReadOnly = True
        Me.TxtNacimiento.Size = New System.Drawing.Size(105, 22)
        Me.TxtNacimiento.TabIndex = 87
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(227, 196)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.ReadOnly = True
        Me.TxtApellido.Size = New System.Drawing.Size(218, 22)
        Me.TxtApellido.TabIndex = 86
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(227, 167)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(149, 22)
        Me.TxtNombre.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fecha de Nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Nombre:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(227, 291)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.ReadOnly = True
        Me.TxtTelefono.Size = New System.Drawing.Size(149, 22)
        Me.TxtTelefono.TabIndex = 91
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(227, 265)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(218, 22)
        Me.TxtEmail.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(90, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 15)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Email:"
        '
        'TxtPais
        '
        Me.TxtPais.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPais.Location = New System.Drawing.Point(227, 391)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.ReadOnly = True
        Me.TxtPais.Size = New System.Drawing.Size(105, 22)
        Me.TxtPais.TabIndex = 97
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(227, 363)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.ReadOnly = True
        Me.TxtCiudad.Size = New System.Drawing.Size(149, 22)
        Me.TxtCiudad.TabIndex = 96
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(227, 335)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(218, 22)
        Me.TxtDireccion.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "País:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(90, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Direccion:"
        '
        'TxtRestaurante
        '
        Me.TxtRestaurante.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRestaurante.Location = New System.Drawing.Point(227, 489)
        Me.TxtRestaurante.Name = "TxtRestaurante"
        Me.TxtRestaurante.ReadOnly = True
        Me.TxtRestaurante.Size = New System.Drawing.Size(59, 22)
        Me.TxtRestaurante.TabIndex = 103
        '
        'TxtSalario
        '
        Me.TxtSalario.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSalario.Location = New System.Drawing.Point(227, 461)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.ReadOnly = True
        Me.TxtSalario.Size = New System.Drawing.Size(105, 22)
        Me.TxtSalario.TabIndex = 102
        '
        'TxtTrabajo
        '
        Me.TxtTrabajo.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTrabajo.Location = New System.Drawing.Point(227, 433)
        Me.TxtTrabajo.Name = "TxtTrabajo"
        Me.TxtTrabajo.ReadOnly = True
        Me.TxtTrabajo.Size = New System.Drawing.Size(81, 22)
        Me.TxtTrabajo.TabIndex = 101
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(90, 496)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Restaurante:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(90, 468)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Salario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(90, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Trabajo:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(305, 547)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(200, 23)
        Me.BtnCancelar.TabIndex = 105
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(12, 547)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(206, 23)
        Me.BtnBorrar.TabIndex = 104
        Me.BtnBorrar.Text = "Dar de Baja"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxtDni)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 133)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'FrmBajaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 581)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.TxtRestaurante)
        Me.Controls.Add(Me.TxtSalario)
        Me.Controls.Add(Me.TxtTrabajo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtPais)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNacimiento)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBajaEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNacimiento As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRestaurante As TextBox
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents TxtTrabajo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
