<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblCamarero = New System.Windows.Forms.Label()
        Me.TxtCamarero = New System.Windows.Forms.TextBox()
        Me.TxtMesaAsignada = New System.Windows.Forms.TextBox()
        Me.LblMesa = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblRecibo = New System.Windows.Forms.Label()
        Me.lblEntrantes = New System.Windows.Forms.Label()
        Me.lblPrimero = New System.Windows.Forms.Label()
        Me.lblSegundo = New System.Windows.Forms.Label()
        Me.lblPostres = New System.Windows.Forms.Label()
        Me.lblBebidas = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEntrantes = New System.Windows.Forms.Button()
        Me.btnPrimerPlato = New System.Windows.Forms.Button()
        Me.btnSegundoPlato = New System.Windows.Forms.Button()
        Me.btnPostres = New System.Windows.Forms.Button()
        Me.btnBebidas = New System.Windows.Forms.Button()
        Me.lbTicket = New System.Windows.Forms.ListBox()
        Me.lbEntrantes = New System.Windows.Forms.ListBox()
        Me.lbPrimerPlato = New System.Windows.Forms.ListBox()
        Me.LbSegundoPlato = New System.Windows.Forms.ListBox()
        Me.lbPostre = New System.Windows.Forms.ListBox()
        Me.lbBebida = New System.Windows.Forms.ListBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnLiberar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 68)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(79, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(135, 31)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Pedido Nº"
        '
        'LblCamarero
        '
        Me.LblCamarero.AutoSize = True
        Me.LblCamarero.Location = New System.Drawing.Point(275, 92)
        Me.LblCamarero.Name = "LblCamarero"
        Me.LblCamarero.Size = New System.Drawing.Size(101, 13)
        Me.LblCamarero.TabIndex = 2
        Me.LblCamarero.Text = "Camarero asignado:"
        '
        'TxtCamarero
        '
        Me.TxtCamarero.Location = New System.Drawing.Point(402, 89)
        Me.TxtCamarero.Name = "TxtCamarero"
        Me.TxtCamarero.ReadOnly = True
        Me.TxtCamarero.Size = New System.Drawing.Size(123, 20)
        Me.TxtCamarero.TabIndex = 3
        '
        'TxtMesaAsignada
        '
        Me.TxtMesaAsignada.Location = New System.Drawing.Point(113, 89)
        Me.TxtMesaAsignada.Name = "TxtMesaAsignada"
        Me.TxtMesaAsignada.ReadOnly = True
        Me.TxtMesaAsignada.Size = New System.Drawing.Size(123, 20)
        Me.TxtMesaAsignada.TabIndex = 5
        '
        'LblMesa
        '
        Me.LblMesa.AutoSize = True
        Me.LblMesa.Location = New System.Drawing.Point(9, 92)
        Me.LblMesa.Name = "LblMesa"
        Me.LblMesa.Size = New System.Drawing.Size(82, 13)
        Me.LblMesa.TabIndex = 4
        Me.LblMesa.Text = "Mesa asignada:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(375, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(69, 20)
        Me.TextBox1.TabIndex = 7
        '
        'LblRecibo
        '
        Me.LblRecibo.AutoSize = True
        Me.LblRecibo.Location = New System.Drawing.Point(294, 12)
        Me.LblRecibo.Name = "LblRecibo"
        Me.LblRecibo.Size = New System.Drawing.Size(66, 13)
        Me.LblRecibo.TabIndex = 6
        Me.LblRecibo.Text = "Nº de recibo"
        '
        'lblEntrantes
        '
        Me.lblEntrantes.AutoSize = True
        Me.lblEntrantes.Location = New System.Drawing.Point(12, 174)
        Me.lblEntrantes.Name = "lblEntrantes"
        Me.lblEntrantes.Size = New System.Drawing.Size(55, 13)
        Me.lblEntrantes.TabIndex = 8
        Me.lblEntrantes.Text = "Entrantes:"
        '
        'lblPrimero
        '
        Me.lblPrimero.AutoSize = True
        Me.lblPrimero.Location = New System.Drawing.Point(275, 244)
        Me.lblPrimero.Name = "lblPrimero"
        Me.lblPrimero.Size = New System.Drawing.Size(65, 13)
        Me.lblPrimero.TabIndex = 10
        Me.lblPrimero.Text = "Primer plato:"
        '
        'lblSegundo
        '
        Me.lblSegundo.AutoSize = True
        Me.lblSegundo.Location = New System.Drawing.Point(12, 338)
        Me.lblSegundo.Name = "lblSegundo"
        Me.lblSegundo.Size = New System.Drawing.Size(79, 13)
        Me.lblSegundo.TabIndex = 12
        Me.lblSegundo.Text = "Segundo plato:"
        '
        'lblPostres
        '
        Me.lblPostres.AutoSize = True
        Me.lblPostres.Location = New System.Drawing.Point(275, 405)
        Me.lblPostres.Name = "lblPostres"
        Me.lblPostres.Size = New System.Drawing.Size(45, 13)
        Me.lblPostres.TabIndex = 14
        Me.lblPostres.Text = "Postres:"
        '
        'lblBebidas
        '
        Me.lblBebidas.AutoSize = True
        Me.lblBebidas.Location = New System.Drawing.Point(14, 495)
        Me.lblBebidas.Name = "lblBebidas"
        Me.lblBebidas.Size = New System.Drawing.Size(48, 13)
        Me.lblBebidas.TabIndex = 16
        Me.lblBebidas.Text = "Bebidas:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(653, 545)
        Me.txtSubtotal.Multiline = True
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(143, 24)
        Me.txtSubtotal.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(529, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Subtotal:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(653, 589)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(143, 24)
        Me.txtTotal.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 597)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Total:"
        '
        'btnEntrantes
        '
        Me.btnEntrantes.Location = New System.Drawing.Point(73, 169)
        Me.btnEntrantes.Name = "btnEntrantes"
        Me.btnEntrantes.Size = New System.Drawing.Size(141, 23)
        Me.btnEntrantes.TabIndex = 23
        Me.btnEntrantes.Text = "Añadir entrante"
        Me.btnEntrantes.UseVisualStyleBackColor = True
        '
        'btnPrimerPlato
        '
        Me.btnPrimerPlato.Location = New System.Drawing.Point(346, 239)
        Me.btnPrimerPlato.Name = "btnPrimerPlato"
        Me.btnPrimerPlato.Size = New System.Drawing.Size(131, 23)
        Me.btnPrimerPlato.TabIndex = 24
        Me.btnPrimerPlato.Text = "Añadir primer plato"
        Me.btnPrimerPlato.UseVisualStyleBackColor = True
        '
        'btnSegundoPlato
        '
        Me.btnSegundoPlato.Location = New System.Drawing.Point(97, 333)
        Me.btnSegundoPlato.Name = "btnSegundoPlato"
        Me.btnSegundoPlato.Size = New System.Drawing.Size(117, 23)
        Me.btnSegundoPlato.TabIndex = 25
        Me.btnSegundoPlato.Text = "Añadir segundo plato"
        Me.btnSegundoPlato.UseVisualStyleBackColor = True
        '
        'btnPostres
        '
        Me.btnPostres.Location = New System.Drawing.Point(326, 400)
        Me.btnPostres.Name = "btnPostres"
        Me.btnPostres.Size = New System.Drawing.Size(151, 23)
        Me.btnPostres.TabIndex = 26
        Me.btnPostres.Text = "Añadir postre"
        Me.btnPostres.UseVisualStyleBackColor = True
        '
        'btnBebidas
        '
        Me.btnBebidas.Location = New System.Drawing.Point(68, 490)
        Me.btnBebidas.Name = "btnBebidas"
        Me.btnBebidas.Size = New System.Drawing.Size(145, 23)
        Me.btnBebidas.TabIndex = 27
        Me.btnBebidas.Text = "Añadir bebidas"
        Me.btnBebidas.UseVisualStyleBackColor = True
        '
        'lbTicket
        '
        Me.lbTicket.FormattingEnabled = True
        Me.lbTicket.Location = New System.Drawing.Point(544, 117)
        Me.lbTicket.Name = "lbTicket"
        Me.lbTicket.Size = New System.Drawing.Size(252, 407)
        Me.lbTicket.TabIndex = 28
        '
        'lbEntrantes
        '
        Me.lbEntrantes.FormattingEnabled = True
        Me.lbEntrantes.Location = New System.Drawing.Point(15, 209)
        Me.lbEntrantes.Name = "lbEntrantes"
        Me.lbEntrantes.Size = New System.Drawing.Size(199, 108)
        Me.lbEntrantes.TabIndex = 29
        '
        'lbPrimerPlato
        '
        Me.lbPrimerPlato.FormattingEnabled = True
        Me.lbPrimerPlato.Location = New System.Drawing.Point(278, 274)
        Me.lbPrimerPlato.Name = "lbPrimerPlato"
        Me.lbPrimerPlato.Size = New System.Drawing.Size(199, 108)
        Me.lbPrimerPlato.TabIndex = 30
        '
        'LbSegundoPlato
        '
        Me.LbSegundoPlato.FormattingEnabled = True
        Me.LbSegundoPlato.Location = New System.Drawing.Point(15, 369)
        Me.LbSegundoPlato.Name = "LbSegundoPlato"
        Me.LbSegundoPlato.Size = New System.Drawing.Size(199, 108)
        Me.LbSegundoPlato.TabIndex = 31
        '
        'lbPostre
        '
        Me.lbPostre.FormattingEnabled = True
        Me.lbPostre.Location = New System.Drawing.Point(278, 436)
        Me.lbPostre.Name = "lbPostre"
        Me.lbPostre.Size = New System.Drawing.Size(199, 108)
        Me.lbPostre.TabIndex = 32
        '
        'lbBebida
        '
        Me.lbBebida.FormattingEnabled = True
        Me.lbBebida.Location = New System.Drawing.Point(13, 530)
        Me.lbBebida.Name = "lbBebida"
        Me.lbBebida.Size = New System.Drawing.Size(199, 108)
        Me.lbBebida.TabIndex = 33
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(601, 19)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(127, 23)
        Me.btnAsignar.TabIndex = 34
        Me.btnAsignar.Text = "Asignar a una mesa"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnLiberar
        '
        Me.btnLiberar.Location = New System.Drawing.Point(601, 63)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(127, 23)
        Me.btnLiberar.TabIndex = 35
        Me.btnLiberar.Text = "Liberar de una mesa"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'FrmPedidos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 650)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.lbBebida)
        Me.Controls.Add(Me.lbPostre)
        Me.Controls.Add(Me.LbSegundoPlato)
        Me.Controls.Add(Me.lbPrimerPlato)
        Me.Controls.Add(Me.lbEntrantes)
        Me.Controls.Add(Me.lbTicket)
        Me.Controls.Add(Me.btnBebidas)
        Me.Controls.Add(Me.btnPostres)
        Me.Controls.Add(Me.btnSegundoPlato)
        Me.Controls.Add(Me.btnPrimerPlato)
        Me.Controls.Add(Me.btnEntrantes)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBebidas)
        Me.Controls.Add(Me.lblPostres)
        Me.Controls.Add(Me.lblSegundo)
        Me.Controls.Add(Me.lblPrimero)
        Me.Controls.Add(Me.lblEntrantes)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblRecibo)
        Me.Controls.Add(Me.TxtMesaAsignada)
        Me.Controls.Add(Me.LblMesa)
        Me.Controls.Add(Me.TxtCamarero)
        Me.Controls.Add(Me.LblCamarero)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblCamarero As Label
    Friend WithEvents TxtCamarero As TextBox
    Friend WithEvents TxtMesaAsignada As TextBox
    Friend WithEvents LblMesa As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblRecibo As Label
    Friend WithEvents lblEntrantes As Label
    Friend WithEvents lblPrimero As Label
    Friend WithEvents lblSegundo As Label
    Friend WithEvents lblPostres As Label
    Friend WithEvents lblBebidas As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEntrantes As Button
    Friend WithEvents btnPrimerPlato As Button
    Friend WithEvents btnSegundoPlato As Button
    Friend WithEvents btnPostres As Button
    Friend WithEvents btnBebidas As Button
    Friend WithEvents lbTicket As ListBox
    Friend WithEvents lbEntrantes As ListBox
    Friend WithEvents lbPrimerPlato As ListBox
    Friend WithEvents LbSegundoPlato As ListBox
    Friend WithEvents lbPostre As ListBox
    Friend WithEvents lbBebida As ListBox
    Friend WithEvents btnAsignar As Button
    Friend WithEvents btnLiberar As Button
End Class
