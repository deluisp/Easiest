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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosConsulta))
        Me.dtgDatos = New System.Windows.Forms.DataGrid()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.optMenor = New System.Windows.Forms.RadioButton()
        Me.optMayor = New System.Windows.Forms.RadioButton()
        Me.optIgual = New System.Windows.Forms.RadioButton()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cmbCampos = New System.Windows.Forms.ComboBox()
        Me.cmbTablas = New System.Windows.Forms.ComboBox()
        Me.lblNoDatos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDatoBuscar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgDatos
        '
        Me.dtgDatos.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.dtgDatos.BackColor = System.Drawing.Color.OldLace
        Me.dtgDatos.BackgroundColor = System.Drawing.Color.Tan
        Me.dtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgDatos.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.dtgDatos.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtgDatos.CaptionForeColor = System.Drawing.Color.OldLace
        Me.dtgDatos.DataMember = ""
        Me.dtgDatos.FlatMode = True
        Me.dtgDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtgDatos.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dtgDatos.GridLineColor = System.Drawing.Color.Tan
        Me.dtgDatos.HeaderBackColor = System.Drawing.Color.Wheat
        Me.dtgDatos.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtgDatos.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.dtgDatos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dtgDatos.Location = New System.Drawing.Point(12, 259)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.dtgDatos.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.dtgDatos.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.dtgDatos.SelectionForeColor = System.Drawing.Color.White
        Me.dtgDatos.Size = New System.Drawing.Size(780, 330)
        Me.dtgDatos.TabIndex = 0
        '
        'btnDatos
        '
        Me.btnDatos.Enabled = False
        Me.btnDatos.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatos.Location = New System.Drawing.Point(68, 191)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(637, 38)
        Me.btnDatos.TabIndex = 23
        Me.btnDatos.Text = "DATOS"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(180, 105)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(156, 23)
        Me.btnAceptar.TabIndex = 22
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtDatoBuscar
        '
        Me.txtDatoBuscar.Enabled = False
        Me.txtDatoBuscar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatoBuscar.Location = New System.Drawing.Point(352, 57)
        Me.txtDatoBuscar.Name = "txtDatoBuscar"
        Me.txtDatoBuscar.Size = New System.Drawing.Size(144, 22)
        Me.txtDatoBuscar.TabIndex = 21
        '
        'optMenor
        '
        Me.optMenor.AutoSize = True
        Me.optMenor.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMenor.Location = New System.Drawing.Point(293, 64)
        Me.optMenor.Name = "optMenor"
        Me.optMenor.Size = New System.Drawing.Size(29, 19)
        Me.optMenor.TabIndex = 19
        Me.optMenor.TabStop = True
        Me.optMenor.Text = "<"
        Me.optMenor.UseVisualStyleBackColor = True
        '
        'optMayor
        '
        Me.optMayor.AutoSize = True
        Me.optMayor.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMayor.Location = New System.Drawing.Point(293, 41)
        Me.optMayor.Name = "optMayor"
        Me.optMayor.Size = New System.Drawing.Size(29, 19)
        Me.optMayor.TabIndex = 18
        Me.optMayor.TabStop = True
        Me.optMayor.Text = ">"
        Me.optMayor.UseVisualStyleBackColor = True
        '
        'optIgual
        '
        Me.optIgual.AutoSize = True
        Me.optIgual.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIgual.Location = New System.Drawing.Point(293, 18)
        Me.optIgual.Name = "optIgual"
        Me.optIgual.Size = New System.Drawing.Size(32, 19)
        Me.optIgual.TabIndex = 17
        Me.optIgual.TabStop = True
        Me.optIgual.Text = "="
        Me.optIgual.UseVisualStyleBackColor = True
        '
        'txtSelect
        '
        Me.txtSelect.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelect.Location = New System.Drawing.Point(537, 62)
        Me.txtSelect.Multiline = True
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.ReadOnly = True
        Me.txtSelect.Size = New System.Drawing.Size(241, 83)
        Me.txtSelect.TabIndex = 16
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(537, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(89, 24)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Consulta"
        '
        'cmbCampos
        '
        Me.cmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampos.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCampos.FormattingEnabled = True
        Me.cmbCampos.Location = New System.Drawing.Point(136, 60)
        Me.cmbCampos.Name = "cmbCampos"
        Me.cmbCampos.Size = New System.Drawing.Size(115, 23)
        Me.cmbCampos.TabIndex = 14
        '
        'cmbTablas
        '
        Me.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTablas.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTablas.FormattingEnabled = True
        Me.cmbTablas.Location = New System.Drawing.Point(136, 19)
        Me.cmbTablas.Name = "cmbTablas"
        Me.cmbTablas.Size = New System.Drawing.Size(115, 23)
        Me.cmbTablas.TabIndex = 13
        '
        'lblNoDatos
        '
        Me.lblNoDatos.AutoSize = True
        Me.lblNoDatos.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDatos.Location = New System.Drawing.Point(591, 157)
        Me.lblNoDatos.Name = "lblNoDatos"
        Me.lblNoDatos.Size = New System.Drawing.Size(161, 27)
        Me.lblNoDatos.TabIndex = 24
        Me.lblNoDatos.Text = "No existen filas"
        Me.lblNoDatos.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Seleccionar tabla:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Seleccionar campo:"
        '
        'lblDatoBuscar
        '
        Me.lblDatoBuscar.AutoSize = True
        Me.lblDatoBuscar.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatoBuscar.Location = New System.Drawing.Point(376, 19)
        Me.lblDatoBuscar.Name = "lblDatoBuscar"
        Me.lblDatoBuscar.Size = New System.Drawing.Size(87, 15)
        Me.lblDatoBuscar.TabIndex = 27
        Me.lblDatoBuscar.Text = "Dato a buscar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDatoBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblDatoBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.cmbTablas)
        Me.GroupBox1.Controls.Add(Me.cmbCampos)
        Me.GroupBox1.Controls.Add(Me.optMenor)
        Me.GroupBox1.Controls.Add(Me.optIgual)
        Me.GroupBox1.Controls.Add(Me.optMayor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 140)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'UsuariosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 605)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNoDatos)
        Me.Controls.Add(Me.btnDatos)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dtgDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UsuariosConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta simple"
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgDatos As DataGrid
    Friend WithEvents btnDatos As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtDatoBuscar As TextBox
    Friend WithEvents optMenor As RadioButton
    Friend WithEvents optMayor As RadioButton
    Friend WithEvents optIgual As RadioButton
    Friend WithEvents txtSelect As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents cmbCampos As ComboBox
    Friend WithEvents cmbTablas As ComboBox
    Friend WithEvents lblNoDatos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDatoBuscar As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
