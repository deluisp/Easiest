<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosConsulta
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
        Me.dtgDatos = New System.Windows.Forms.DataGrid()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.lblDatoBuscar = New System.Windows.Forms.Label()
        Me.optMenor = New System.Windows.Forms.RadioButton()
        Me.optMayor = New System.Windows.Forms.RadioButton()
        Me.optIgual = New System.Windows.Forms.RadioButton()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cmbCampos = New System.Windows.Forms.ComboBox()
        Me.cmbTablas = New System.Windows.Forms.ComboBox()
        Me.lblNoDatos = New System.Windows.Forms.Label()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgDatos
        '
        Me.dtgDatos.DataMember = ""
        Me.dtgDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgDatos.Location = New System.Drawing.Point(12, 290)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.Size = New System.Drawing.Size(1233, 357)
        Me.dtgDatos.TabIndex = 0
        '
        'btnDatos
        '
        Me.btnDatos.Location = New System.Drawing.Point(12, 234)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(1233, 38)
        Me.btnDatos.TabIndex = 23
        Me.btnDatos.Text = "DATOS"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(937, 157)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(156, 23)
        Me.btnAceptar.TabIndex = 22
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtDatoBuscar
        '
        Me.txtDatoBuscar.Enabled = False
        Me.txtDatoBuscar.Location = New System.Drawing.Point(799, 60)
        Me.txtDatoBuscar.Name = "txtDatoBuscar"
        Me.txtDatoBuscar.Size = New System.Drawing.Size(410, 20)
        Me.txtDatoBuscar.TabIndex = 21
        '
        'lblDatoBuscar
        '
        Me.lblDatoBuscar.AutoSize = True
        Me.lblDatoBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatoBuscar.Location = New System.Drawing.Point(874, 9)
        Me.lblDatoBuscar.Name = "lblDatoBuscar"
        Me.lblDatoBuscar.Size = New System.Drawing.Size(158, 25)
        Me.lblDatoBuscar.TabIndex = 20
        Me.lblDatoBuscar.Text = "Dato a buscar: "
        '
        'optMenor
        '
        Me.optMenor.AutoSize = True
        Me.optMenor.Location = New System.Drawing.Point(699, 109)
        Me.optMenor.Name = "optMenor"
        Me.optMenor.Size = New System.Drawing.Size(31, 17)
        Me.optMenor.TabIndex = 19
        Me.optMenor.TabStop = True
        Me.optMenor.Text = "<"
        Me.optMenor.UseVisualStyleBackColor = True
        '
        'optMayor
        '
        Me.optMayor.AutoSize = True
        Me.optMayor.Location = New System.Drawing.Point(699, 86)
        Me.optMayor.Name = "optMayor"
        Me.optMayor.Size = New System.Drawing.Size(31, 17)
        Me.optMayor.TabIndex = 18
        Me.optMayor.TabStop = True
        Me.optMayor.Text = ">"
        Me.optMayor.UseVisualStyleBackColor = True
        '
        'optIgual
        '
        Me.optIgual.AutoSize = True
        Me.optIgual.Location = New System.Drawing.Point(699, 63)
        Me.optIgual.Name = "optIgual"
        Me.optIgual.Size = New System.Drawing.Size(31, 17)
        Me.optIgual.TabIndex = 17
        Me.optIgual.TabStop = True
        Me.optIgual.Text = "="
        Me.optIgual.UseVisualStyleBackColor = True
        '
        'txtSelect
        '
        Me.txtSelect.Location = New System.Drawing.Point(12, 160)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(558, 20)
        Me.txtSelect.TabIndex = 16
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 97)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(83, 24)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Consulta"
        '
        'cmbCampos
        '
        Me.cmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampos.FormattingEnabled = True
        Me.cmbCampos.Location = New System.Drawing.Point(329, 28)
        Me.cmbCampos.Name = "cmbCampos"
        Me.cmbCampos.Size = New System.Drawing.Size(241, 21)
        Me.cmbCampos.TabIndex = 14
        '
        'cmbTablas
        '
        Me.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTablas.FormattingEnabled = True
        Me.cmbTablas.Location = New System.Drawing.Point(16, 28)
        Me.cmbTablas.Name = "cmbTablas"
        Me.cmbTablas.Size = New System.Drawing.Size(250, 21)
        Me.cmbTablas.TabIndex = 13
        '
        'lblNoDatos
        '
        Me.lblNoDatos.AutoSize = True
        Me.lblNoDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDatos.Location = New System.Drawing.Point(381, 429)
        Me.lblNoDatos.Name = "lblNoDatos"
        Me.lblNoDatos.Size = New System.Drawing.Size(466, 73)
        Me.lblNoDatos.TabIndex = 24
        Me.lblNoDatos.Text = "No existen filas"
        Me.lblNoDatos.Visible = False
        '
        'UsuariosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 667)
        Me.Controls.Add(Me.lblNoDatos)
        Me.Controls.Add(Me.btnDatos)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDatoBuscar)
        Me.Controls.Add(Me.lblDatoBuscar)
        Me.Controls.Add(Me.optMenor)
        Me.Controls.Add(Me.optMayor)
        Me.Controls.Add(Me.optIgual)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmbCampos)
        Me.Controls.Add(Me.cmbTablas)
        Me.Controls.Add(Me.dtgDatos)
        Me.Name = "UsuariosConsulta"
        Me.Text = "UsuariosConsulta"
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgDatos As DataGrid
    Friend WithEvents btnDatos As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtDatoBuscar As TextBox
    Friend WithEvents lblDatoBuscar As Label
    Friend WithEvents optMenor As RadioButton
    Friend WithEvents optMayor As RadioButton
    Friend WithEvents optIgual As RadioButton
    Friend WithEvents txtSelect As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents cmbCampos As ComboBox
    Friend WithEvents cmbTablas As ComboBox
    Friend WithEvents lblNoDatos As Label
End Class
