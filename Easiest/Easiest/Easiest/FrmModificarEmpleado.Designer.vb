<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarEmpleado
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TxtRestaurante = New System.Windows.Forms.TextBox()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.TxtTrabajo = New System.Windows.Forms.TextBox()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtNacimiento = New System.Windows.Forms.TextBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(292, 459)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(226, 23)
        Me.BtnCancelar.TabIndex = 77
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(4, 459)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(218, 23)
        Me.BtnModificar.TabIndex = 76
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'TxtRestaurante
        '
        Me.TxtRestaurante.Location = New System.Drawing.Point(432, 356)
        Me.TxtRestaurante.Name = "TxtRestaurante"
        Me.TxtRestaurante.Size = New System.Drawing.Size(86, 20)
        Me.TxtRestaurante.TabIndex = 75
        '
        'TxtSalario
        '
        Me.TxtSalario.Location = New System.Drawing.Point(256, 356)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(89, 20)
        Me.TxtSalario.TabIndex = 74
        '
        'TxtTrabajo
        '
        Me.TxtTrabajo.Location = New System.Drawing.Point(62, 356)
        Me.TxtTrabajo.Name = "TxtTrabajo"
        Me.TxtTrabajo.Size = New System.Drawing.Size(133, 20)
        Me.TxtTrabajo.TabIndex = 73
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(446, 256)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(72, 20)
        Me.TxtPais.TabIndex = 72
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(292, 256)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(113, 20)
        Me.TxtCiudad.TabIndex = 71
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(69, 256)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(167, 20)
        Me.TxtDireccion.TabIndex = 70
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(292, 169)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(226, 20)
        Me.TxtTelefono.TabIndex = 69
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(55, 169)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(167, 20)
        Me.TxtEmail.TabIndex = 68
        '
        'TxtNacimiento
        '
        Me.TxtNacimiento.Location = New System.Drawing.Point(211, 113)
        Me.TxtNacimiento.Name = "TxtNacimiento"
        Me.TxtNacimiento.Size = New System.Drawing.Size(167, 20)
        Me.TxtNacimiento.TabIndex = 67
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(49, 15)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(167, 20)
        Me.TxtDni.TabIndex = 66
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(300, 71)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(218, 20)
        Me.TxtApellido.TabIndex = 65
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(67, 71)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(149, 20)
        Me.TxtNombre.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(358, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Restaurante:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(208, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Salario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Trabajo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Telefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(408, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "País:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Direccion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Fecha de Nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Nombre:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(292, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(143, 23)
        Me.btnBuscar.TabIndex = 78
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 493)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TxtRestaurante)
        Me.Controls.Add(Me.TxtSalario)
        Me.Controls.Add(Me.TxtTrabajo)
        Me.Controls.Add(Me.TxtPais)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtNacimiento)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmModificarEmpleado"
        Me.Text = "FrmModificarEmpleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents TxtRestaurante As TextBox
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents TxtTrabajo As TextBox
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtNacimiento As TextBox
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
End Class
