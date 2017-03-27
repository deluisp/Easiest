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
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(319, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(95, 23)
        Me.btnBuscar.TabIndex = 81
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(95, 14)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(119, 20)
        Me.TxtDni.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "DNI:"
        '
        'TxtNacimiento
        '
        Me.TxtNacimiento.Location = New System.Drawing.Point(129, 158)
        Me.TxtNacimiento.Name = "TxtNacimiento"
        Me.TxtNacimiento.Size = New System.Drawing.Size(167, 20)
        Me.TxtNacimiento.TabIndex = 87
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(78, 120)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(218, 20)
        Me.TxtApellido.TabIndex = 86
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(78, 82)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 20)
        Me.TxtNombre.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fecha de Nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Nombre:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(78, 231)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(218, 20)
        Me.TxtTelefono.TabIndex = 91
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(78, 196)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(218, 20)
        Me.TxtEmail.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Email:"
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(78, 392)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(218, 20)
        Me.TxtPais.TabIndex = 97
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(78, 351)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(218, 20)
        Me.TxtCiudad.TabIndex = 96
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(78, 305)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(218, 20)
        Me.TxtDireccion.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "País:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Direccion:"
        '
        'TxtRestaurante
        '
        Me.TxtRestaurante.Location = New System.Drawing.Point(95, 536)
        Me.TxtRestaurante.Name = "TxtRestaurante"
        Me.TxtRestaurante.Size = New System.Drawing.Size(201, 20)
        Me.TxtRestaurante.TabIndex = 103
        '
        'TxtSalario
        '
        Me.TxtSalario.Location = New System.Drawing.Point(78, 498)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(218, 20)
        Me.TxtSalario.TabIndex = 102
        '
        'TxtTrabajo
        '
        Me.TxtTrabajo.Location = New System.Drawing.Point(78, 461)
        Me.TxtTrabajo.Name = "TxtTrabajo"
        Me.TxtTrabajo.Size = New System.Drawing.Size(218, 20)
        Me.TxtTrabajo.TabIndex = 101
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 543)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Restaurante:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 505)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Salario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Trabajo:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(286, 587)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(128, 23)
        Me.BtnCancelar.TabIndex = 105
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(15, 587)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(142, 23)
        Me.BtnBorrar.TabIndex = 104
        Me.BtnBorrar.Text = "Dar de Baja"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'FrmBajaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 622)
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
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmBajaEmpleados"
        Me.Text = "FrmBajaEmpleados"
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
End Class
