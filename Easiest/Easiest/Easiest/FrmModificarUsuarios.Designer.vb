<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarUsuarios))
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GBType = New System.Windows.Forms.GroupBox()
        Me.OptAvanzado = New System.Windows.Forms.RadioButton()
        Me.OptMedio = New System.Windows.Forms.RadioButton()
        Me.OptBasico = New System.Windows.Forms.RadioButton()
        Me.BtnConsultaA01 = New System.Windows.Forms.CheckBox()
        Me.BtnConsultaB01 = New System.Windows.Forms.CheckBox()
        Me.BtnBajas01 = New System.Windows.Forms.CheckBox()
        Me.BtnModificacion01 = New System.Windows.Forms.CheckBox()
        Me.BtnAltas01 = New System.Windows.Forms.CheckBox()
        Me.GBSeguridad = New System.Windows.Forms.GroupBox()
        Me.Opt05 = New System.Windows.Forms.CheckBox()
        Me.Opt03 = New System.Windows.Forms.CheckBox()
        Me.Opt04 = New System.Windows.Forms.CheckBox()
        Me.Opt02 = New System.Windows.Forms.CheckBox()
        Me.Opt01 = New System.Windows.Forms.CheckBox()
        Me.BtnAleatoria = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblError = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GBType.SuspendLayout()
        Me.GBSeguridad.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(416, 335)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(279, 23)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(29, 335)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(279, 23)
        Me.BtnModificar.TabIndex = 17
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'GBType
        '
        Me.GBType.Controls.Add(Me.OptAvanzado)
        Me.GBType.Controls.Add(Me.OptMedio)
        Me.GBType.Controls.Add(Me.OptBasico)
        Me.GBType.Controls.Add(Me.BtnConsultaA01)
        Me.GBType.Controls.Add(Me.BtnConsultaB01)
        Me.GBType.Controls.Add(Me.BtnBajas01)
        Me.GBType.Controls.Add(Me.BtnModificacion01)
        Me.GBType.Controls.Add(Me.BtnAltas01)
        Me.GBType.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBType.Location = New System.Drawing.Point(411, 27)
        Me.GBType.Name = "GBType"
        Me.GBType.Size = New System.Drawing.Size(285, 302)
        Me.GBType.TabIndex = 16
        Me.GBType.TabStop = False
        Me.GBType.Text = "Tipo de Usuario: "
        '
        'OptAvanzado
        '
        Me.OptAvanzado.AutoSize = True
        Me.OptAvanzado.Enabled = False
        Me.OptAvanzado.Location = New System.Drawing.Point(194, 43)
        Me.OptAvanzado.Name = "OptAvanzado"
        Me.OptAvanzado.Size = New System.Drawing.Size(79, 19)
        Me.OptAvanzado.TabIndex = 38
        Me.OptAvanzado.TabStop = True
        Me.OptAvanzado.Text = "Avanzado"
        Me.OptAvanzado.UseVisualStyleBackColor = True
        '
        'OptMedio
        '
        Me.OptMedio.AutoSize = True
        Me.OptMedio.Enabled = False
        Me.OptMedio.Location = New System.Drawing.Point(105, 43)
        Me.OptMedio.Name = "OptMedio"
        Me.OptMedio.Size = New System.Drawing.Size(60, 19)
        Me.OptMedio.TabIndex = 37
        Me.OptMedio.TabStop = True
        Me.OptMedio.Text = "Medio"
        Me.OptMedio.UseVisualStyleBackColor = True
        '
        'OptBasico
        '
        Me.OptBasico.AutoSize = True
        Me.OptBasico.Enabled = False
        Me.OptBasico.Location = New System.Drawing.Point(17, 43)
        Me.OptBasico.Name = "OptBasico"
        Me.OptBasico.Size = New System.Drawing.Size(60, 19)
        Me.OptBasico.TabIndex = 36
        Me.OptBasico.TabStop = True
        Me.OptBasico.Text = "Basico"
        Me.OptBasico.UseVisualStyleBackColor = True
        '
        'BtnConsultaA01
        '
        Me.BtnConsultaA01.AutoSize = True
        Me.BtnConsultaA01.Enabled = False
        Me.BtnConsultaA01.Location = New System.Drawing.Point(17, 242)
        Me.BtnConsultaA01.Name = "BtnConsultaA01"
        Me.BtnConsultaA01.Size = New System.Drawing.Size(142, 19)
        Me.BtnConsultaA01.TabIndex = 35
        Me.BtnConsultaA01.Text = "Consultas Avanzadas"
        Me.BtnConsultaA01.UseVisualStyleBackColor = True
        '
        'BtnConsultaB01
        '
        Me.BtnConsultaB01.AutoSize = True
        Me.BtnConsultaB01.Enabled = False
        Me.BtnConsultaB01.Location = New System.Drawing.Point(17, 210)
        Me.BtnConsultaB01.Name = "BtnConsultaB01"
        Me.BtnConsultaB01.Size = New System.Drawing.Size(123, 19)
        Me.BtnConsultaB01.TabIndex = 34
        Me.BtnConsultaB01.Text = "Consultas Basicas"
        Me.BtnConsultaB01.UseVisualStyleBackColor = True
        '
        'BtnBajas01
        '
        Me.BtnBajas01.AutoSize = True
        Me.BtnBajas01.Enabled = False
        Me.BtnBajas01.Location = New System.Drawing.Point(17, 177)
        Me.BtnBajas01.Name = "BtnBajas01"
        Me.BtnBajas01.Size = New System.Drawing.Size(54, 19)
        Me.BtnBajas01.TabIndex = 33
        Me.BtnBajas01.Text = "Bajas"
        Me.BtnBajas01.UseVisualStyleBackColor = True
        '
        'BtnModificacion01
        '
        Me.BtnModificacion01.AutoSize = True
        Me.BtnModificacion01.Enabled = False
        Me.BtnModificacion01.Location = New System.Drawing.Point(17, 144)
        Me.BtnModificacion01.Name = "BtnModificacion01"
        Me.BtnModificacion01.Size = New System.Drawing.Size(99, 19)
        Me.BtnModificacion01.TabIndex = 32
        Me.BtnModificacion01.Text = "Modificacion"
        Me.BtnModificacion01.UseVisualStyleBackColor = True
        '
        'BtnAltas01
        '
        Me.BtnAltas01.AutoSize = True
        Me.BtnAltas01.Enabled = False
        Me.BtnAltas01.Location = New System.Drawing.Point(17, 110)
        Me.BtnAltas01.Name = "BtnAltas01"
        Me.BtnAltas01.Size = New System.Drawing.Size(50, 19)
        Me.BtnAltas01.TabIndex = 31
        Me.BtnAltas01.Text = "Alta"
        Me.BtnAltas01.UseVisualStyleBackColor = True
        '
        'GBSeguridad
        '
        Me.GBSeguridad.Controls.Add(Me.Opt05)
        Me.GBSeguridad.Controls.Add(Me.Opt03)
        Me.GBSeguridad.Controls.Add(Me.Opt04)
        Me.GBSeguridad.Controls.Add(Me.Opt02)
        Me.GBSeguridad.Controls.Add(Me.Opt01)
        Me.GBSeguridad.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSeguridad.Location = New System.Drawing.Point(29, 161)
        Me.GBSeguridad.Name = "GBSeguridad"
        Me.GBSeguridad.Size = New System.Drawing.Size(321, 168)
        Me.GBSeguridad.TabIndex = 15
        Me.GBSeguridad.TabStop = False
        Me.GBSeguridad.Text = "Seguridad de la contraseña: "
        '
        'Opt05
        '
        Me.Opt05.AutoSize = True
        Me.Opt05.Enabled = False
        Me.Opt05.Location = New System.Drawing.Point(6, 132)
        Me.Opt05.Name = "Opt05"
        Me.Opt05.Size = New System.Drawing.Size(142, 19)
        Me.Opt05.TabIndex = 9
        Me.Opt05.Text = "Contiene minúsculas"
        Me.Opt05.UseVisualStyleBackColor = True
        '
        'Opt03
        '
        Me.Opt03.AutoSize = True
        Me.Opt03.Enabled = False
        Me.Opt03.Location = New System.Drawing.Point(6, 86)
        Me.Opt03.Name = "Opt03"
        Me.Opt03.Size = New System.Drawing.Size(128, 19)
        Me.Opt03.TabIndex = 8
        Me.Opt03.Text = "Contiene numeros"
        Me.Opt03.UseVisualStyleBackColor = True
        '
        'Opt04
        '
        Me.Opt04.AutoSize = True
        Me.Opt04.Enabled = False
        Me.Opt04.Location = New System.Drawing.Point(6, 109)
        Me.Opt04.Name = "Opt04"
        Me.Opt04.Size = New System.Drawing.Size(144, 19)
        Me.Opt04.TabIndex = 7
        Me.Opt04.Text = "Contiene mayúsculas"
        Me.Opt04.UseVisualStyleBackColor = True
        '
        'Opt02
        '
        Me.Opt02.AutoSize = True
        Me.Opt02.Enabled = False
        Me.Opt02.Location = New System.Drawing.Point(6, 63)
        Me.Opt02.Name = "Opt02"
        Me.Opt02.Size = New System.Drawing.Size(111, 19)
        Me.Opt02.TabIndex = 6
        Me.Opt02.Text = "Contiene letras"
        Me.Opt02.UseVisualStyleBackColor = True
        '
        'Opt01
        '
        Me.Opt01.AutoSize = True
        Me.Opt01.Enabled = False
        Me.Opt01.Location = New System.Drawing.Point(6, 40)
        Me.Opt01.Name = "Opt01"
        Me.Opt01.Size = New System.Drawing.Size(149, 19)
        Me.Opt01.TabIndex = 5
        Me.Opt01.Text = "Mayor de 6 caracteres"
        Me.Opt01.UseVisualStyleBackColor = True
        '
        'BtnAleatoria
        '
        Me.BtnAleatoria.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAleatoria.Location = New System.Drawing.Point(313, 68)
        Me.BtnAleatoria.Name = "BtnAleatoria"
        Me.BtnAleatoria.Size = New System.Drawing.Size(84, 38)
        Me.BtnAleatoria.TabIndex = 14
        Me.BtnAleatoria.Text = "Contraseña aleatoria"
        Me.BtnAleatoria.UseVisualStyleBackColor = True
        '
        'TxtClave
        '
        Me.TxtClave.Enabled = False
        Me.TxtClave.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.Location = New System.Drawing.Point(120, 61)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(155, 22)
        Me.TxtClave.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Contraseña:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(120, 20)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(155, 22)
        Me.TxtUsuario.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(120, 123)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(155, 22)
        Me.TxtEmail.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Email:"
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.Location = New System.Drawing.Point(133, 96)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(149, 15)
        Me.LblError.TabIndex = 21
        Me.LblError.Text = "Compruebe la contraseña"
        Me.LblError.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(303, 18)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(94, 23)
        Me.BtnBuscar.TabIndex = 22
        Me.BtnBuscar.Text = "Buscar usuario"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmModificarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(708, 370)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.GBType)
        Me.Controls.Add(Me.GBSeguridad)
        Me.Controls.Add(Me.BtnAleatoria)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmModificarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModificarUsuarios"
        Me.GBType.ResumeLayout(False)
        Me.GBType.PerformLayout()
        Me.GBSeguridad.ResumeLayout(False)
        Me.GBSeguridad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents GBType As GroupBox
    Friend WithEvents GBSeguridad As GroupBox
    Friend WithEvents BtnAleatoria As Button
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblError As Label
    Friend WithEvents Opt05 As CheckBox
    Friend WithEvents Opt03 As CheckBox
    Friend WithEvents Opt04 As CheckBox
    Friend WithEvents Opt02 As CheckBox
    Friend WithEvents Opt01 As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents OptAvanzado As RadioButton
    Friend WithEvents OptMedio As RadioButton
    Friend WithEvents OptBasico As RadioButton
    Friend WithEvents BtnConsultaA01 As CheckBox
    Friend WithEvents BtnConsultaB01 As CheckBox
    Friend WithEvents BtnBajas01 As CheckBox
    Friend WithEvents BtnModificacion01 As CheckBox
    Friend WithEvents BtnAltas01 As CheckBox
End Class
