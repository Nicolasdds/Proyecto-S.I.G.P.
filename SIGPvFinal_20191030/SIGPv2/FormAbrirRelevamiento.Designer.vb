<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbrirRelevamiento
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
        Me.btnAbrirRelevamientoSalir = New System.Windows.Forms.Button()
        Me.lblAbrirRelevamientoRS = New System.Windows.Forms.Label()
        Me.txtAbrirRelevamientoRS = New System.Windows.Forms.TextBox()
        Me.dtpAbrirRelevamientoF1 = New System.Windows.Forms.DateTimePicker()
        Me.lblAbrirRelevamientoFechas = New System.Windows.Forms.Label()
        Me.lblAbrirRelevamientoTitulo = New System.Windows.Forms.Label()
        Me.lblAbrirRelevamientoCriterio = New System.Windows.Forms.Label()
        Me.cboAbrirRelevamientoCriterio = New System.Windows.Forms.ComboBox()
        Me.txtAbrirRelevamientoRUT = New System.Windows.Forms.TextBox()
        Me.lblAbrirRelevamientoRUT = New System.Windows.Forms.Label()
        Me.dtpAbrirRelevamientoF2 = New System.Windows.Forms.DateTimePicker()
        Me.lblAbrirRelevamientoDesde = New System.Windows.Forms.Label()
        Me.lblAbrirRelevamientoHasta = New System.Windows.Forms.Label()
        Me.dgvAbrirRelevamientoResultado = New System.Windows.Forms.DataGridView()
        Me.btnAbrirRelevamientoLimpiar = New System.Windows.Forms.Button()
        Me.lblAbrirRelevamientoID = New System.Windows.Forms.Label()
        Me.txtAbrirRelevamientoID = New System.Windows.Forms.TextBox()
        Me.btnAbrirRelevamientoBuscar = New System.Windows.Forms.Button()
        CType(Me.dgvAbrirRelevamientoResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAbrirRelevamientoSalir
        '
        Me.btnAbrirRelevamientoSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirRelevamientoSalir.Location = New System.Drawing.Point(1663, 668)
        Me.btnAbrirRelevamientoSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbrirRelevamientoSalir.Name = "btnAbrirRelevamientoSalir"
        Me.btnAbrirRelevamientoSalir.Size = New System.Drawing.Size(167, 70)
        Me.btnAbrirRelevamientoSalir.TabIndex = 12
        Me.btnAbrirRelevamientoSalir.Text = "SALIR"
        Me.btnAbrirRelevamientoSalir.UseVisualStyleBackColor = True
        '
        'lblAbrirRelevamientoRS
        '
        Me.lblAbrirRelevamientoRS.AutoSize = True
        Me.lblAbrirRelevamientoRS.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoRS.Location = New System.Drawing.Point(656, 234)
        Me.lblAbrirRelevamientoRS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbrirRelevamientoRS.Name = "lblAbrirRelevamientoRS"
        Me.lblAbrirRelevamientoRS.Size = New System.Drawing.Size(171, 24)
        Me.lblAbrirRelevamientoRS.TabIndex = 1
        Me.lblAbrirRelevamientoRS.Text = "RAZON SOCIAL:"
        '
        'txtAbrirRelevamientoRS
        '
        Me.txtAbrirRelevamientoRS.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbrirRelevamientoRS.Location = New System.Drawing.Point(849, 230)
        Me.txtAbrirRelevamientoRS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbrirRelevamientoRS.Name = "txtAbrirRelevamientoRS"
        Me.txtAbrirRelevamientoRS.Size = New System.Drawing.Size(365, 32)
        Me.txtAbrirRelevamientoRS.TabIndex = 2
        '
        'dtpAbrirRelevamientoF1
        '
        Me.dtpAbrirRelevamientoF1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAbrirRelevamientoF1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAbrirRelevamientoF1.Location = New System.Drawing.Point(849, 230)
        Me.dtpAbrirRelevamientoF1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dtpAbrirRelevamientoF1.Name = "dtpAbrirRelevamientoF1"
        Me.dtpAbrirRelevamientoF1.Size = New System.Drawing.Size(289, 32)
        Me.dtpAbrirRelevamientoF1.TabIndex = 41
        '
        'lblAbrirRelevamientoFechas
        '
        Me.lblAbrirRelevamientoFechas.AutoSize = True
        Me.lblAbrirRelevamientoFechas.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoFechas.Location = New System.Drawing.Point(735, 234)
        Me.lblAbrirRelevamientoFechas.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblAbrirRelevamientoFechas.Name = "lblAbrirRelevamientoFechas"
        Me.lblAbrirRelevamientoFechas.Size = New System.Drawing.Size(96, 24)
        Me.lblAbrirRelevamientoFechas.TabIndex = 39
        Me.lblAbrirRelevamientoFechas.Text = "FECHAS:"
        '
        'lblAbrirRelevamientoTitulo
        '
        Me.lblAbrirRelevamientoTitulo.AutoSize = True
        Me.lblAbrirRelevamientoTitulo.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoTitulo.Location = New System.Drawing.Point(231, 107)
        Me.lblAbrirRelevamientoTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbrirRelevamientoTitulo.Name = "lblAbrirRelevamientoTitulo"
        Me.lblAbrirRelevamientoTitulo.Size = New System.Drawing.Size(374, 35)
        Me.lblAbrirRelevamientoTitulo.TabIndex = 42
        Me.lblAbrirRelevamientoTitulo.Text = "ABRIR RELEVAMIENTO"
        '
        'lblAbrirRelevamientoCriterio
        '
        Me.lblAbrirRelevamientoCriterio.AutoSize = True
        Me.lblAbrirRelevamientoCriterio.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoCriterio.Location = New System.Drawing.Point(243, 231)
        Me.lblAbrirRelevamientoCriterio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbrirRelevamientoCriterio.Name = "lblAbrirRelevamientoCriterio"
        Me.lblAbrirRelevamientoCriterio.Size = New System.Drawing.Size(109, 24)
        Me.lblAbrirRelevamientoCriterio.TabIndex = 45
        Me.lblAbrirRelevamientoCriterio.Text = "CRITERIO:"
        '
        'cboAbrirRelevamientoCriterio
        '
        Me.cboAbrirRelevamientoCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAbrirRelevamientoCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAbrirRelevamientoCriterio.FormattingEnabled = True
        Me.cboAbrirRelevamientoCriterio.Items.AddRange(New Object() {"ID", "RUT", "Razon Social", "Fecha Creacion", "Fecha Finalizacion"})
        Me.cboAbrirRelevamientoCriterio.Location = New System.Drawing.Point(369, 234)
        Me.cboAbrirRelevamientoCriterio.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAbrirRelevamientoCriterio.Name = "cboAbrirRelevamientoCriterio"
        Me.cboAbrirRelevamientoCriterio.Size = New System.Drawing.Size(263, 25)
        Me.cboAbrirRelevamientoCriterio.TabIndex = 44
        '
        'txtAbrirRelevamientoRUT
        '
        Me.txtAbrirRelevamientoRUT.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbrirRelevamientoRUT.Location = New System.Drawing.Point(849, 230)
        Me.txtAbrirRelevamientoRUT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbrirRelevamientoRUT.Name = "txtAbrirRelevamientoRUT"
        Me.txtAbrirRelevamientoRUT.Size = New System.Drawing.Size(365, 32)
        Me.txtAbrirRelevamientoRUT.TabIndex = 43
        '
        'lblAbrirRelevamientoRUT
        '
        Me.lblAbrirRelevamientoRUT.AutoSize = True
        Me.lblAbrirRelevamientoRUT.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoRUT.Location = New System.Drawing.Point(776, 234)
        Me.lblAbrirRelevamientoRUT.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblAbrirRelevamientoRUT.Name = "lblAbrirRelevamientoRUT"
        Me.lblAbrirRelevamientoRUT.Size = New System.Drawing.Size(56, 24)
        Me.lblAbrirRelevamientoRUT.TabIndex = 46
        Me.lblAbrirRelevamientoRUT.Text = "RUT:"
        '
        'dtpAbrirRelevamientoF2
        '
        Me.dtpAbrirRelevamientoF2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAbrirRelevamientoF2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAbrirRelevamientoF2.Location = New System.Drawing.Point(1153, 230)
        Me.dtpAbrirRelevamientoF2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dtpAbrirRelevamientoF2.Name = "dtpAbrirRelevamientoF2"
        Me.dtpAbrirRelevamientoF2.Size = New System.Drawing.Size(289, 32)
        Me.dtpAbrirRelevamientoF2.TabIndex = 47
        '
        'lblAbrirRelevamientoDesde
        '
        Me.lblAbrirRelevamientoDesde.AutoSize = True
        Me.lblAbrirRelevamientoDesde.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoDesde.Location = New System.Drawing.Point(928, 199)
        Me.lblAbrirRelevamientoDesde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbrirRelevamientoDesde.Name = "lblAbrirRelevamientoDesde"
        Me.lblAbrirRelevamientoDesde.Size = New System.Drawing.Size(80, 24)
        Me.lblAbrirRelevamientoDesde.TabIndex = 48
        Me.lblAbrirRelevamientoDesde.Text = "DESDE:"
        '
        'lblAbrirRelevamientoHasta
        '
        Me.lblAbrirRelevamientoHasta.AutoSize = True
        Me.lblAbrirRelevamientoHasta.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoHasta.Location = New System.Drawing.Point(1216, 199)
        Me.lblAbrirRelevamientoHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbrirRelevamientoHasta.Name = "lblAbrirRelevamientoHasta"
        Me.lblAbrirRelevamientoHasta.Size = New System.Drawing.Size(87, 24)
        Me.lblAbrirRelevamientoHasta.TabIndex = 49
        Me.lblAbrirRelevamientoHasta.Text = "HASTA:"
        '
        'dgvAbrirRelevamientoResultado
        '
        Me.dgvAbrirRelevamientoResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAbrirRelevamientoResultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAbrirRelevamientoResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAbrirRelevamientoResultado.Location = New System.Drawing.Point(91, 273)
        Me.dgvAbrirRelevamientoResultado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAbrirRelevamientoResultado.Name = "dgvAbrirRelevamientoResultado"
        Me.dgvAbrirRelevamientoResultado.Size = New System.Drawing.Size(1564, 465)
        Me.dgvAbrirRelevamientoResultado.TabIndex = 50
        '
        'btnAbrirRelevamientoLimpiar
        '
        Me.btnAbrirRelevamientoLimpiar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirRelevamientoLimpiar.Location = New System.Drawing.Point(1663, 594)
        Me.btnAbrirRelevamientoLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbrirRelevamientoLimpiar.Name = "btnAbrirRelevamientoLimpiar"
        Me.btnAbrirRelevamientoLimpiar.Size = New System.Drawing.Size(167, 70)
        Me.btnAbrirRelevamientoLimpiar.TabIndex = 51
        Me.btnAbrirRelevamientoLimpiar.Text = "LIMPIAR"
        Me.btnAbrirRelevamientoLimpiar.UseVisualStyleBackColor = True
        '
        'lblAbrirRelevamientoID
        '
        Me.lblAbrirRelevamientoID.AutoSize = True
        Me.lblAbrirRelevamientoID.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirRelevamientoID.Location = New System.Drawing.Point(795, 233)
        Me.lblAbrirRelevamientoID.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblAbrirRelevamientoID.Name = "lblAbrirRelevamientoID"
        Me.lblAbrirRelevamientoID.Size = New System.Drawing.Size(37, 24)
        Me.lblAbrirRelevamientoID.TabIndex = 52
        Me.lblAbrirRelevamientoID.Text = "ID:"
        '
        'txtAbrirRelevamientoID
        '
        Me.txtAbrirRelevamientoID.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbrirRelevamientoID.Location = New System.Drawing.Point(849, 230)
        Me.txtAbrirRelevamientoID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbrirRelevamientoID.Name = "txtAbrirRelevamientoID"
        Me.txtAbrirRelevamientoID.Size = New System.Drawing.Size(164, 32)
        Me.txtAbrirRelevamientoID.TabIndex = 53
        '
        'btnAbrirRelevamientoBuscar
        '
        Me.btnAbrirRelevamientoBuscar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirRelevamientoBuscar.Image = Global.SIGP.My.Resources.Resources.iconfinder_magnifying_glass_226571
        Me.btnAbrirRelevamientoBuscar.Location = New System.Drawing.Point(1488, 225)
        Me.btnAbrirRelevamientoBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbrirRelevamientoBuscar.Name = "btnAbrirRelevamientoBuscar"
        Me.btnAbrirRelevamientoBuscar.Size = New System.Drawing.Size(167, 36)
        Me.btnAbrirRelevamientoBuscar.TabIndex = 10
        Me.btnAbrirRelevamientoBuscar.UseVisualStyleBackColor = True
        '
        'FormAbrirRelevamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1845, 815)
        Me.Controls.Add(Me.txtAbrirRelevamientoID)
        Me.Controls.Add(Me.lblAbrirRelevamientoID)
        Me.Controls.Add(Me.dtpAbrirRelevamientoF2)
        Me.Controls.Add(Me.btnAbrirRelevamientoLimpiar)
        Me.Controls.Add(Me.dgvAbrirRelevamientoResultado)
        Me.Controls.Add(Me.lblAbrirRelevamientoHasta)
        Me.Controls.Add(Me.lblAbrirRelevamientoDesde)
        Me.Controls.Add(Me.lblAbrirRelevamientoRUT)
        Me.Controls.Add(Me.lblAbrirRelevamientoCriterio)
        Me.Controls.Add(Me.cboAbrirRelevamientoCriterio)
        Me.Controls.Add(Me.lblAbrirRelevamientoTitulo)
        Me.Controls.Add(Me.lblAbrirRelevamientoFechas)
        Me.Controls.Add(Me.lblAbrirRelevamientoRS)
        Me.Controls.Add(Me.txtAbrirRelevamientoRS)
        Me.Controls.Add(Me.btnAbrirRelevamientoSalir)
        Me.Controls.Add(Me.btnAbrirRelevamientoBuscar)
        Me.Controls.Add(Me.txtAbrirRelevamientoRUT)
        Me.Controls.Add(Me.dtpAbrirRelevamientoF1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAbrirRelevamiento"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Abrir Relevamiento"
        CType(Me.dgvAbrirRelevamientoResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbrirRelevamientoSalir As System.Windows.Forms.Button
    Friend WithEvents btnAbrirRelevamientoBuscar As System.Windows.Forms.Button
    Friend WithEvents lblAbrirRelevamientoRS As System.Windows.Forms.Label
    Friend WithEvents txtAbrirRelevamientoRS As System.Windows.Forms.TextBox
    Friend WithEvents dtpAbrirRelevamientoF1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAbrirRelevamientoFechas As System.Windows.Forms.Label
    Friend WithEvents lblAbrirRelevamientoTitulo As System.Windows.Forms.Label
    Friend WithEvents lblAbrirRelevamientoCriterio As System.Windows.Forms.Label
    Friend WithEvents cboAbrirRelevamientoCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents txtAbrirRelevamientoRUT As System.Windows.Forms.TextBox
    Friend WithEvents lblAbrirRelevamientoRUT As System.Windows.Forms.Label
    Friend WithEvents dtpAbrirRelevamientoF2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAbrirRelevamientoDesde As System.Windows.Forms.Label
    Friend WithEvents lblAbrirRelevamientoHasta As System.Windows.Forms.Label
    Friend WithEvents dgvAbrirRelevamientoResultado As System.Windows.Forms.DataGridView
    Friend WithEvents btnAbrirRelevamientoLimpiar As System.Windows.Forms.Button
    Friend WithEvents lblAbrirRelevamientoID As System.Windows.Forms.Label
    Friend WithEvents txtAbrirRelevamientoID As System.Windows.Forms.TextBox
End Class
