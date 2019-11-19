<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporte
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
        Me.txtReporteObservaciones = New System.Windows.Forms.TextBox()
        Me.txtReporteDescripcion = New System.Windows.Forms.TextBox()
        Me.dtpReporteFRealizado = New System.Windows.Forms.DateTimePicker()
        Me.dtpReporteFPrevista = New System.Windows.Forms.DateTimePicker()
        Me.btnReporteVolver = New System.Windows.Forms.Button()
        Me.btnReporteListo = New System.Windows.Forms.Button()
        Me.txtReporteTecnico = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblFecRealizado = New System.Windows.Forms.Label()
        Me.lblTecnico = New System.Windows.Forms.Label()
        Me.lblFechaPrev = New System.Windows.Forms.Label()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.lblDescripción = New System.Windows.Forms.Label()
        Me.txtReporteTitulo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtReporteObservaciones
        '
        Me.txtReporteObservaciones.Location = New System.Drawing.Point(196, 480)
        Me.txtReporteObservaciones.Multiline = True
        Me.txtReporteObservaciones.Name = "txtReporteObservaciones"
        Me.txtReporteObservaciones.Size = New System.Drawing.Size(395, 92)
        Me.txtReporteObservaciones.TabIndex = 41
        '
        'txtReporteDescripcion
        '
        Me.txtReporteDescripcion.Location = New System.Drawing.Point(195, 137)
        Me.txtReporteDescripcion.Multiline = True
        Me.txtReporteDescripcion.Name = "txtReporteDescripcion"
        Me.txtReporteDescripcion.Size = New System.Drawing.Size(397, 164)
        Me.txtReporteDescripcion.TabIndex = 40
        '
        'dtpReporteFRealizado
        '
        Me.dtpReporteFRealizado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReporteFRealizado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReporteFRealizado.Location = New System.Drawing.Point(195, 430)
        Me.dtpReporteFRealizado.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpReporteFRealizado.Name = "dtpReporteFRealizado"
        Me.dtpReporteFRealizado.Size = New System.Drawing.Size(218, 27)
        Me.dtpReporteFRealizado.TabIndex = 38
        '
        'dtpReporteFPrevista
        '
        Me.dtpReporteFPrevista.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReporteFPrevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReporteFPrevista.Location = New System.Drawing.Point(195, 337)
        Me.dtpReporteFPrevista.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpReporteFPrevista.Name = "dtpReporteFPrevista"
        Me.dtpReporteFPrevista.Size = New System.Drawing.Size(218, 27)
        Me.dtpReporteFPrevista.TabIndex = 37
        '
        'btnReporteVolver
        '
        Me.btnReporteVolver.BackColor = System.Drawing.SystemColors.Control
        Me.btnReporteVolver.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteVolver.Location = New System.Drawing.Point(640, 214)
        Me.btnReporteVolver.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReporteVolver.Name = "btnReporteVolver"
        Me.btnReporteVolver.Size = New System.Drawing.Size(151, 59)
        Me.btnReporteVolver.TabIndex = 36
        Me.btnReporteVolver.Text = "VOLVER"
        Me.btnReporteVolver.UseVisualStyleBackColor = False
        '
        'btnReporteListo
        '
        Me.btnReporteListo.BackColor = System.Drawing.SystemColors.Control
        Me.btnReporteListo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteListo.Location = New System.Drawing.Point(640, 148)
        Me.btnReporteListo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReporteListo.Name = "btnReporteListo"
        Me.btnReporteListo.Size = New System.Drawing.Size(151, 56)
        Me.btnReporteListo.TabIndex = 35
        Me.btnReporteListo.Text = "LISTO"
        Me.btnReporteListo.UseVisualStyleBackColor = False
        '
        'txtReporteTecnico
        '
        Me.txtReporteTecnico.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReporteTecnico.Location = New System.Drawing.Point(194, 378)
        Me.txtReporteTecnico.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReporteTecnico.Name = "txtReporteTecnico"
        Me.txtReporteTecnico.Size = New System.Drawing.Size(397, 27)
        Me.txtReporteTecnico.TabIndex = 31
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(26, 483)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(149, 20)
        Me.lblObservaciones.TabIndex = 30
        Me.lblObservaciones.Text = "OBSERVACIONES:"
        '
        'lblFecRealizado
        '
        Me.lblFecRealizado.AutoSize = True
        Me.lblFecRealizado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecRealizado.Location = New System.Drawing.Point(10, 430)
        Me.lblFecRealizado.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFecRealizado.Name = "lblFecRealizado"
        Me.lblFecRealizado.Size = New System.Drawing.Size(168, 20)
        Me.lblFecRealizado.TabIndex = 28
        Me.lblFecRealizado.Text = "FECHA REALIZADO:"
        '
        'lblTecnico
        '
        Me.lblTecnico.AutoSize = True
        Me.lblTecnico.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTecnico.Location = New System.Drawing.Point(93, 381)
        Me.lblTecnico.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(86, 20)
        Me.lblTecnico.TabIndex = 27
        Me.lblTecnico.Text = "TECNICO:"
        '
        'lblFechaPrev
        '
        Me.lblFechaPrev.AutoSize = True
        Me.lblFechaPrev.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPrev.Location = New System.Drawing.Point(31, 342)
        Me.lblFechaPrev.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFechaPrev.Name = "lblFechaPrev"
        Me.lblFechaPrev.Size = New System.Drawing.Size(150, 20)
        Me.lblFechaPrev.TabIndex = 26
        Me.lblFechaPrev.Text = "FECHA PREVISTA:"
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResumen.Location = New System.Drawing.Point(192, 311)
        Me.lblResumen.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(97, 21)
        Me.lblResumen.TabIndex = 25
        Me.lblResumen.Text = "RESUMEN:"
        '
        'lblDescripción
        '
        Me.lblDescripción.AutoSize = True
        Me.lblDescripción.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripción.Location = New System.Drawing.Point(60, 138)
        Me.lblDescripción.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescripción.Name = "lblDescripción"
        Me.lblDescripción.Size = New System.Drawing.Size(122, 20)
        Me.lblDescripción.TabIndex = 24
        Me.lblDescripción.Text = "DESCRIPCION:"
        '
        'txtReporteTitulo
        '
        Me.txtReporteTitulo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReporteTitulo.Location = New System.Drawing.Point(195, 97)
        Me.txtReporteTitulo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReporteTitulo.Name = "txtReporteTitulo"
        Me.txtReporteTitulo.Size = New System.Drawing.Size(397, 27)
        Me.txtReporteTitulo.TabIndex = 23
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(112, 100)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 20)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "TITULO:"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(28, 31)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(163, 38)
        Me.lblEmpresa.TabIndex = 46
        Me.lblEmpresa.Text = "REPORTE"
        '
        'FormReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 597)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.txtReporteObservaciones)
        Me.Controls.Add(Me.txtReporteDescripcion)
        Me.Controls.Add(Me.dtpReporteFRealizado)
        Me.Controls.Add(Me.dtpReporteFPrevista)
        Me.Controls.Add(Me.btnReporteVolver)
        Me.Controls.Add(Me.btnReporteListo)
        Me.Controls.Add(Me.txtReporteTecnico)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblFecRealizado)
        Me.Controls.Add(Me.lblTecnico)
        Me.Controls.Add(Me.lblFechaPrev)
        Me.Controls.Add(Me.lblResumen)
        Me.Controls.Add(Me.lblDescripción)
        Me.Controls.Add(Me.txtReporteTitulo)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FormReporte"
        Me.Text = "FormReporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReporteObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtReporteDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtpReporteFRealizado As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReporteFPrevista As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnReporteVolver As System.Windows.Forms.Button
    Friend WithEvents btnReporteListo As System.Windows.Forms.Button
    Friend WithEvents txtReporteTecnico As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblFecRealizado As System.Windows.Forms.Label
    Friend WithEvents lblTecnico As System.Windows.Forms.Label
    Friend WithEvents lblFechaPrev As System.Windows.Forms.Label
    Friend WithEvents lblResumen As System.Windows.Forms.Label
    Friend WithEvents lblDescripción As System.Windows.Forms.Label
    Friend WithEvents txtReporteTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
End Class
