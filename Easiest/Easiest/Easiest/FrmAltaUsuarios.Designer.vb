<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaUsuarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.BtnAleatoria = New System.Windows.Forms.Button()
        Me.GBSeguridad = New System.Windows.Forms.GroupBox()
        Me.Opt05 = New System.Windows.Forms.CheckBox()
        Me.Opt03 = New System.Windows.Forms.CheckBox()
        Me.Opt04 = New System.Windows.Forms.CheckBox()
        Me.Opt02 = New System.Windows.Forms.CheckBox()
        Me.Opt01 = New System.Windows.Forms.CheckBox()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblError = New System.Windows.Forms.Label()
        Me.GBType = New System.Windows.Forms.GroupBox()
        Me.OptAvanzado = New System.Windows.Forms.RadioButton()
        Me.OptMedio = New System.Windows.Forms.RadioButton()
        Me.OptBasico = New System.Windows.Forms.RadioButton()
        Me.BtnConsultaA01 = New System.Windows.Forms.CheckBox()
        Me.BtnConsultaB01 = New System.Windows.Forms.CheckBox()
        Me.BtnBajas01 = New System.Windows.Forms.CheckBox()
        Me.BtnModificacion01 = New System.Windows.Forms.CheckBox()
        Me.BtnAltas01 = New System.Windows.Forms.CheckBox()
        Me.GBSeguridad.SuspendLayout()
        Me.GBType.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(106, 21)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(155, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(106, 58)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(155, 20)
        Me.TxtClave.TabIndex = 4
        '
        'BtnAleatoria
        '
        Me.BtnAleatoria.Location = New System.Drawing.Point(297, 40)
        Me.BtnAleatoria.Name = "BtnAleatoria"
        Me.BtnAleatoria.Size = New System.Drawing.Size(75, 38)
        Me.BtnAleatoria.TabIndex = 5
        Me.BtnAleatoria.Text = "Contraseña aleatoria"
        Me.BtnAleatoria.UseVisualStyleBackColor = True
        '
        'GBSeguridad
        '
        Me.GBSeguridad.Controls.Add(Me.Opt05)
        Me.GBSeguridad.Controls.Add(Me.Opt03)
        Me.GBSeguridad.Controls.Add(Me.Opt04)
        Me.GBSeguridad.Controls.Add(Me.Opt02)
        Me.GBSeguridad.Controls.Add(Me.Opt01)
        Me.GBSeguridad.Location = New System.Drawing.Point(15, 146)
        Me.GBSeguridad.Name = "GBSeguridad"
        Me.GBSeguridad.Size = New System.Drawing.Size(325, 168)
        Me.GBSeguridad.TabIndex = 6
        Me.GBSeguridad.TabStop = False
        Me.GBSeguridad.Text = "Seguridad de la contraseña: "
        '
        'Opt05
        '
        Me.Opt05.AutoSize = True
        Me.Opt05.Location = New System.Drawing.Point(6, 131)
        Me.Opt05.Name = "Opt05"
        Me.Opt05.Size = New System.Drawing.Size(123, 17)
        Me.Opt05.TabIndex = 4
        Me.Opt05.Text = "Contiene minúsculas"
        Me.Opt05.UseVisualStyleBackColor = True
        '
        'Opt03
        '
        Me.Opt03.AutoSize = True
        Me.Opt03.Location = New System.Drawing.Point(6, 85)
        Me.Opt03.Name = "Opt03"
        Me.Opt03.Size = New System.Drawing.Size(111, 17)
        Me.Opt03.TabIndex = 3
        Me.Opt03.Text = "Contiene numeros"
        Me.Opt03.UseVisualStyleBackColor = True
        '
        'Opt04
        '
        Me.Opt04.AutoSize = True
        Me.Opt04.Location = New System.Drawing.Point(6, 108)
        Me.Opt04.Name = "Opt04"
        Me.Opt04.Size = New System.Drawing.Size(126, 17)
        Me.Opt04.TabIndex = 2
        Me.Opt04.Text = "Contiene mayúsculas"
        Me.Opt04.UseVisualStyleBackColor = True
        '
        'Opt02
        '
        Me.Opt02.AutoSize = True
        Me.Opt02.Location = New System.Drawing.Point(6, 62)
        Me.Opt02.Name = "Opt02"
        Me.Opt02.Size = New System.Drawing.Size(96, 17)
        Me.Opt02.TabIndex = 1
        Me.Opt02.Text = "Contiene letras"
        Me.Opt02.UseVisualStyleBackColor = True
        '
        'Opt01
        '
        Me.Opt01.AutoSize = True
        Me.Opt01.Location = New System.Drawing.Point(6, 39)
        Me.Opt01.Name = "Opt01"
        Me.Opt01.Size = New System.Drawing.Size(132, 17)
        Me.Opt01.TabIndex = 0
        Me.Opt01.Text = "Mayor de 6 caracteres"
        Me.Opt01.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(12, 320)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(279, 23)
        Me.BtnAlta.TabIndex = 8
        Me.BtnAlta.Text = "Dar de Alta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(382, 320)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(279, 23)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Email:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(106, 108)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(155, 20)
        Me.TxtEmail.TabIndex = 11
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Location = New System.Drawing.Point(116, 86)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(128, 13)
        Me.LblError.TabIndex = 12
        Me.LblError.Text = "Compruebe la contraseña"
        Me.LblError.Visible = False
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
        Me.GBType.Location = New System.Drawing.Point(376, 12)
        Me.GBType.Name = "GBType"
        Me.GBType.Size = New System.Drawing.Size(285, 302)
        Me.GBType.TabIndex = 17
        Me.GBType.TabStop = False
        Me.GBType.Text = "Tipo de Usuario: "
        '
        'OptAvanzado
        '
        Me.OptAvanzado.AutoSize = True
        Me.OptAvanzado.Location = New System.Drawing.Point(184, 20)
        Me.OptAvanzado.Name = "OptAvanzado"
        Me.OptAvanzado.Size = New System.Drawing.Size(73, 17)
        Me.OptAvanzado.TabIndex = 30
        Me.OptAvanzado.TabStop = True
        Me.OptAvanzado.Text = "Avanzado"
        Me.OptAvanzado.UseVisualStyleBackColor = True
        '
        'OptMedio
        '
        Me.OptMedio.AutoSize = True
        Me.OptMedio.Location = New System.Drawing.Point(95, 20)
        Me.OptMedio.Name = "OptMedio"
        Me.OptMedio.Size = New System.Drawing.Size(54, 17)
        Me.OptMedio.TabIndex = 29
        Me.OptMedio.TabStop = True
        Me.OptMedio.Text = "Medio"
        Me.OptMedio.UseVisualStyleBackColor = True
        '
        'OptBasico
        '
        Me.OptBasico.AutoSize = True
        Me.OptBasico.Location = New System.Drawing.Point(7, 20)
        Me.OptBasico.Name = "OptBasico"
        Me.OptBasico.Size = New System.Drawing.Size(57, 17)
        Me.OptBasico.TabIndex = 28
        Me.OptBasico.TabStop = True
        Me.OptBasico.Text = "Basico"
        Me.OptBasico.UseVisualStyleBackColor = True
        '
        'BtnConsultaA01
        '
        Me.BtnConsultaA01.AutoSize = True
        Me.BtnConsultaA01.Location = New System.Drawing.Point(7, 219)
        Me.BtnConsultaA01.Name = "BtnConsultaA01"
        Me.BtnConsultaA01.Size = New System.Drawing.Size(128, 17)
        Me.BtnConsultaA01.TabIndex = 27
        Me.BtnConsultaA01.Text = "Consultas Avanzadas"
        Me.BtnConsultaA01.UseVisualStyleBackColor = True
        '
        'BtnConsultaB01
        '
        Me.BtnConsultaB01.AutoSize = True
        Me.BtnConsultaB01.Location = New System.Drawing.Point(7, 187)
        Me.BtnConsultaB01.Name = "BtnConsultaB01"
        Me.BtnConsultaB01.Size = New System.Drawing.Size(112, 17)
        Me.BtnConsultaB01.TabIndex = 26
        Me.BtnConsultaB01.Text = "Consultas Basicas"
        Me.BtnConsultaB01.UseVisualStyleBackColor = True
        '
        'BtnBajas01
        '
        Me.BtnBajas01.AutoSize = True
        Me.BtnBajas01.Location = New System.Drawing.Point(7, 154)
        Me.BtnBajas01.Name = "BtnBajas01"
        Me.BtnBajas01.Size = New System.Drawing.Size(52, 17)
        Me.BtnBajas01.TabIndex = 25
        Me.BtnBajas01.Text = "Bajas"
        Me.BtnBajas01.UseVisualStyleBackColor = True
        '
        'BtnModificacion01
        '
        Me.BtnModificacion01.AutoSize = True
        Me.BtnModificacion01.Location = New System.Drawing.Point(7, 121)
        Me.BtnModificacion01.Name = "BtnModificacion01"
        Me.BtnModificacion01.Size = New System.Drawing.Size(86, 17)
        Me.BtnModificacion01.TabIndex = 24
        Me.BtnModificacion01.Text = "Modificacion"
        Me.BtnModificacion01.UseVisualStyleBackColor = True
        '
        'BtnAltas01
        '
        Me.BtnAltas01.AutoSize = True
        Me.BtnAltas01.Location = New System.Drawing.Point(7, 87)
        Me.BtnAltas01.Name = "BtnAltas01"
        Me.BtnAltas01.Size = New System.Drawing.Size(44, 17)
        Me.BtnAltas01.TabIndex = 23
        Me.BtnAltas01.Text = "Alta"
        Me.BtnAltas01.UseVisualStyleBackColor = True
        '
        'FrmAltaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 347)
        Me.Controls.Add(Me.GBType)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAlta)
        Me.Controls.Add(Me.GBSeguridad)
        Me.Controls.Add(Me.BtnAleatoria)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAltaUsuarios"
        Me.Text = "Alta de Usuarios"
        Me.GBSeguridad.ResumeLayout(False)
        Me.GBSeguridad.PerformLayout()
        Me.GBType.ResumeLayout(False)
        Me.GBType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents BtnAleatoria As Button
    Friend WithEvents GBSeguridad As GroupBox
    Friend WithEvents Opt04 As CheckBox
    Friend WithEvents Opt02 As CheckBox
    Friend WithEvents Opt01 As CheckBox
    Friend WithEvents BtnAlta As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblError As Label
    Friend WithEvents Opt05 As CheckBox
    Friend WithEvents Opt03 As CheckBox
    Friend WithEvents GBType As GroupBox
    Friend WithEvents BtnConsultaA01 As CheckBox
    Friend WithEvents BtnConsultaB01 As CheckBox
    Friend WithEvents BtnBajas01 As CheckBox
    Friend WithEvents BtnModificacion01 As CheckBox
    Friend WithEvents BtnAltas01 As CheckBox
    Friend WithEvents OptAvanzado As RadioButton
    Friend WithEvents OptMedio As RadioButton
    Friend WithEvents OptBasico As RadioButton
End Class
