<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInspecciones
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
        Me.btnInspeccionSalir = New System.Windows.Forms.Button()
        Me.btnInspeccionGuardarInspeccion = New System.Windows.Forms.Button()
        Me.dtpInspeccionFechaVisita = New System.Windows.Forms.DateTimePicker()
        Me.cboInspeccionTipoUnidad = New System.Windows.Forms.ComboBox()
        Me.lblInspeccionlFechaVisita = New System.Windows.Forms.Label()
        Me.lblInspeccionTipoUnidad = New System.Windows.Forms.Label()
        Me.lblInspeccionUnidadInspectora = New System.Windows.Forms.Label()
        Me.lblInspeccion = New System.Windows.Forms.Label()
        Me.dtpInspeccionFechaRespuesta = New System.Windows.Forms.DateTimePicker()
        Me.dtpInspeccionFechaDictado = New System.Windows.Forms.DateTimePicker()
        Me.txtInspeccionNarracion = New System.Windows.Forms.TextBox()
        Me.txtInspeccionTipoObservacion = New System.Windows.Forms.TextBox()
        Me.lblInspeccionNarracion = New System.Windows.Forms.Label()
        Me.lblInspeccionFechaRespuesta = New System.Windows.Forms.Label()
        Me.lblInspeccionFechaDictado = New System.Windows.Forms.Label()
        Me.lblInspeccionTipoObservacion = New System.Windows.Forms.Label()
        Me.txtInspeccionUnidadInspectora = New System.Windows.Forms.TextBox()
        Me.txtInspeccionRUT = New System.Windows.Forms.TextBox()
        Me.lblInspeccionRUT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInspeccionLimpiar = New System.Windows.Forms.Button()
        Me.btnInspeccionBuscar = New System.Windows.Forms.Button()
        Me.dgvInspeccionInspeccionesRealizadas = New System.Windows.Forms.DataGridView()
        Me.lblInspeccionInspeccionesRealizadas = New System.Windows.Forms.Label()
        CType(Me.dgvInspeccionInspeccionesRealizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInspeccionSalir
        '
        Me.btnInspeccionSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnInspeccionSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInspeccionSalir.Location = New System.Drawing.Point(1136, 229)
        Me.btnInspeccionSalir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnInspeccionSalir.Name = "btnInspeccionSalir"
        Me.btnInspeccionSalir.Size = New System.Drawing.Size(241, 90)
        Me.btnInspeccionSalir.TabIndex = 11
        Me.btnInspeccionSalir.Text = "SALIR"
        Me.btnInspeccionSalir.UseVisualStyleBackColor = False
        '
        'btnInspeccionGuardarInspeccion
        '
        Me.btnInspeccionGuardarInspeccion.BackColor = System.Drawing.SystemColors.Control
        Me.btnInspeccionGuardarInspeccion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInspeccionGuardarInspeccion.Location = New System.Drawing.Point(845, 233)
        Me.btnInspeccionGuardarInspeccion.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnInspeccionGuardarInspeccion.Name = "btnInspeccionGuardarInspeccion"
        Me.btnInspeccionGuardarInspeccion.Size = New System.Drawing.Size(241, 90)
        Me.btnInspeccionGuardarInspeccion.TabIndex = 9
        Me.btnInspeccionGuardarInspeccion.Text = "GUARDAR INSPECCION"
        Me.btnInspeccionGuardarInspeccion.UseVisualStyleBackColor = False
        '
        'dtpInspeccionFechaVisita
        '
        Me.dtpInspeccionFechaVisita.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInspeccionFechaVisita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInspeccionFechaVisita.Location = New System.Drawing.Point(431, 271)
        Me.dtpInspeccionFechaVisita.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dtpInspeccionFechaVisita.Name = "dtpInspeccionFechaVisita"
        Me.dtpInspeccionFechaVisita.Size = New System.Drawing.Size(345, 32)
        Me.dtpInspeccionFechaVisita.TabIndex = 4
        '
        'cboInspeccionTipoUnidad
        '
        Me.cboInspeccionTipoUnidad.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInspeccionTipoUnidad.FormattingEnabled = True
        Me.cboInspeccionTipoUnidad.Items.AddRange(New Object() {"MINISTERIAL", "MUNICIPAL", "SINDICAL"})
        Me.cboInspeccionTipoUnidad.Location = New System.Drawing.Point(431, 226)
        Me.cboInspeccionTipoUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboInspeccionTipoUnidad.Name = "cboInspeccionTipoUnidad"
        Me.cboInspeccionTipoUnidad.Size = New System.Drawing.Size(348, 32)
        Me.cboInspeccionTipoUnidad.TabIndex = 3
        '
        'lblInspeccionlFechaVisita
        '
        Me.lblInspeccionlFechaVisita.AutoSize = True
        Me.lblInspeccionlFechaVisita.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionlFechaVisita.Location = New System.Drawing.Point(253, 277)
        Me.lblInspeccionlFechaVisita.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionlFechaVisita.Name = "lblInspeccionlFechaVisita"
        Me.lblInspeccionlFechaVisita.Size = New System.Drawing.Size(157, 24)
        Me.lblInspeccionlFechaVisita.TabIndex = 25
        Me.lblInspeccionlFechaVisita.Text = "FECHA VISITA:"
        '
        'lblInspeccionTipoUnidad
        '
        Me.lblInspeccionTipoUnidad.AutoSize = True
        Me.lblInspeccionTipoUnidad.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionTipoUnidad.Location = New System.Drawing.Point(351, 233)
        Me.lblInspeccionTipoUnidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionTipoUnidad.Name = "lblInspeccionTipoUnidad"
        Me.lblInspeccionTipoUnidad.Size = New System.Drawing.Size(62, 24)
        Me.lblInspeccionTipoUnidad.TabIndex = 24
        Me.lblInspeccionTipoUnidad.Text = "TIPO:"
        '
        'lblInspeccionUnidadInspectora
        '
        Me.lblInspeccionUnidadInspectora.AutoSize = True
        Me.lblInspeccionUnidadInspectora.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionUnidadInspectora.Location = New System.Drawing.Point(180, 181)
        Me.lblInspeccionUnidadInspectora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionUnidadInspectora.Name = "lblInspeccionUnidadInspectora"
        Me.lblInspeccionUnidadInspectora.Size = New System.Drawing.Size(236, 24)
        Me.lblInspeccionUnidadInspectora.TabIndex = 23
        Me.lblInspeccionUnidadInspectora.Text = "UNIDAD INSPECTORA:"
        '
        'lblInspeccion
        '
        Me.lblInspeccion.AutoSize = True
        Me.lblInspeccion.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccion.Location = New System.Drawing.Point(137, 69)
        Me.lblInspeccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccion.Name = "lblInspeccion"
        Me.lblInspeccion.Size = New System.Drawing.Size(268, 47)
        Me.lblInspeccion.TabIndex = 22
        Me.lblInspeccion.Text = "INSPECCION"
        '
        'dtpInspeccionFechaRespuesta
        '
        Me.dtpInspeccionFechaRespuesta.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInspeccionFechaRespuesta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInspeccionFechaRespuesta.Location = New System.Drawing.Point(436, 498)
        Me.dtpInspeccionFechaRespuesta.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dtpInspeccionFechaRespuesta.Name = "dtpInspeccionFechaRespuesta"
        Me.dtpInspeccionFechaRespuesta.Size = New System.Drawing.Size(345, 32)
        Me.dtpInspeccionFechaRespuesta.TabIndex = 7
        '
        'dtpInspeccionFechaDictado
        '
        Me.dtpInspeccionFechaDictado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInspeccionFechaDictado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInspeccionFechaDictado.Location = New System.Drawing.Point(436, 447)
        Me.dtpInspeccionFechaDictado.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dtpInspeccionFechaDictado.Name = "dtpInspeccionFechaDictado"
        Me.dtpInspeccionFechaDictado.Size = New System.Drawing.Size(345, 32)
        Me.dtpInspeccionFechaDictado.TabIndex = 6
        '
        'txtInspeccionNarracion
        '
        Me.txtInspeccionNarracion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspeccionNarracion.Location = New System.Drawing.Point(436, 548)
        Me.txtInspeccionNarracion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInspeccionNarracion.Multiline = True
        Me.txtInspeccionNarracion.Name = "txtInspeccionNarracion"
        Me.txtInspeccionNarracion.Size = New System.Drawing.Size(351, 127)
        Me.txtInspeccionNarracion.TabIndex = 8
        '
        'txtInspeccionTipoObservacion
        '
        Me.txtInspeccionTipoObservacion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspeccionTipoObservacion.Location = New System.Drawing.Point(433, 393)
        Me.txtInspeccionTipoObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInspeccionTipoObservacion.Name = "txtInspeccionTipoObservacion"
        Me.txtInspeccionTipoObservacion.Size = New System.Drawing.Size(348, 32)
        Me.txtInspeccionTipoObservacion.TabIndex = 5
        '
        'lblInspeccionNarracion
        '
        Me.lblInspeccionNarracion.AutoSize = True
        Me.lblInspeccionNarracion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionNarracion.Location = New System.Drawing.Point(260, 548)
        Me.lblInspeccionNarracion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionNarracion.Name = "lblInspeccionNarracion"
        Me.lblInspeccionNarracion.Size = New System.Drawing.Size(144, 24)
        Me.lblInspeccionNarracion.TabIndex = 34
        Me.lblInspeccionNarracion.Text = "NARRACION:"
        '
        'lblInspeccionFechaRespuesta
        '
        Me.lblInspeccionFechaRespuesta.AutoSize = True
        Me.lblInspeccionFechaRespuesta.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionFechaRespuesta.Location = New System.Drawing.Point(200, 502)
        Me.lblInspeccionFechaRespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionFechaRespuesta.Name = "lblInspeccionFechaRespuesta"
        Me.lblInspeccionFechaRespuesta.Size = New System.Drawing.Size(205, 24)
        Me.lblInspeccionFechaRespuesta.TabIndex = 33
        Me.lblInspeccionFechaRespuesta.Text = "FECHA RESPUESTA:"
        '
        'lblInspeccionFechaDictado
        '
        Me.lblInspeccionFechaDictado.AutoSize = True
        Me.lblInspeccionFechaDictado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionFechaDictado.Location = New System.Drawing.Point(223, 452)
        Me.lblInspeccionFechaDictado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionFechaDictado.Name = "lblInspeccionFechaDictado"
        Me.lblInspeccionFechaDictado.Size = New System.Drawing.Size(185, 24)
        Me.lblInspeccionFechaDictado.TabIndex = 32
        Me.lblInspeccionFechaDictado.Text = "FECHA DICTADO:"
        '
        'lblInspeccionTipoObservacion
        '
        Me.lblInspeccionTipoObservacion.AutoSize = True
        Me.lblInspeccionTipoObservacion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionTipoObservacion.Location = New System.Drawing.Point(351, 398)
        Me.lblInspeccionTipoObservacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionTipoObservacion.Name = "lblInspeccionTipoObservacion"
        Me.lblInspeccionTipoObservacion.Size = New System.Drawing.Size(62, 24)
        Me.lblInspeccionTipoObservacion.TabIndex = 31
        Me.lblInspeccionTipoObservacion.Text = "TIPO:"
        '
        'txtInspeccionUnidadInspectora
        '
        Me.txtInspeccionUnidadInspectora.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspeccionUnidadInspectora.Location = New System.Drawing.Point(431, 177)
        Me.txtInspeccionUnidadInspectora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInspeccionUnidadInspectora.Name = "txtInspeccionUnidadInspectora"
        Me.txtInspeccionUnidadInspectora.Size = New System.Drawing.Size(348, 32)
        Me.txtInspeccionUnidadInspectora.TabIndex = 2
        '
        'txtInspeccionRUT
        '
        Me.txtInspeccionRUT.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspeccionRUT.Location = New System.Drawing.Point(431, 137)
        Me.txtInspeccionRUT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInspeccionRUT.Name = "txtInspeccionRUT"
        Me.txtInspeccionRUT.Size = New System.Drawing.Size(348, 32)
        Me.txtInspeccionRUT.TabIndex = 1
        '
        'lblInspeccionRUT
        '
        Me.lblInspeccionRUT.AutoSize = True
        Me.lblInspeccionRUT.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionRUT.Location = New System.Drawing.Point(251, 140)
        Me.lblInspeccionRUT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionRUT.Name = "lblInspeccionRUT"
        Me.lblInspeccionRUT.Size = New System.Drawing.Size(156, 24)
        Me.lblInspeccionRUT.TabIndex = 40
        Me.lblInspeccionRUT.Text = "RUT EMPRESA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 338)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 37)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "OBSERVACIÓN"
        '
        'btnInspeccionLimpiar
        '
        Me.btnInspeccionLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnInspeccionLimpiar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInspeccionLimpiar.Location = New System.Drawing.Point(1136, 127)
        Me.btnInspeccionLimpiar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnInspeccionLimpiar.Name = "btnInspeccionLimpiar"
        Me.btnInspeccionLimpiar.Size = New System.Drawing.Size(241, 90)
        Me.btnInspeccionLimpiar.TabIndex = 10
        Me.btnInspeccionLimpiar.Text = "LIMPIAR"
        Me.btnInspeccionLimpiar.UseVisualStyleBackColor = False
        '
        'btnInspeccionBuscar
        '
        Me.btnInspeccionBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnInspeccionBuscar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInspeccionBuscar.Location = New System.Drawing.Point(845, 127)
        Me.btnInspeccionBuscar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnInspeccionBuscar.Name = "btnInspeccionBuscar"
        Me.btnInspeccionBuscar.Size = New System.Drawing.Size(241, 90)
        Me.btnInspeccionBuscar.TabIndex = 43
        Me.btnInspeccionBuscar.Text = "BUSCAR"
        Me.btnInspeccionBuscar.UseVisualStyleBackColor = False
        '
        'dgvInspeccionInspeccionesRealizadas
        '
        Me.dgvInspeccionInspeccionesRealizadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInspeccionInspeccionesRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInspeccionInspeccionesRealizadas.Location = New System.Drawing.Point(431, 768)
        Me.dgvInspeccionInspeccionesRealizadas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvInspeccionInspeccionesRealizadas.Name = "dgvInspeccionInspeccionesRealizadas"
        Me.dgvInspeccionInspeccionesRealizadas.Size = New System.Drawing.Size(963, 185)
        Me.dgvInspeccionInspeccionesRealizadas.TabIndex = 45
        '
        'lblInspeccionInspeccionesRealizadas
        '
        Me.lblInspeccionInspeccionesRealizadas.AutoSize = True
        Me.lblInspeccionInspeccionesRealizadas.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInspeccionInspeccionesRealizadas.Location = New System.Drawing.Point(561, 716)
        Me.lblInspeccionInspeccionesRealizadas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccionInspeccionesRealizadas.Name = "lblInspeccionInspeccionesRealizadas"
        Me.lblInspeccionInspeccionesRealizadas.Size = New System.Drawing.Size(441, 37)
        Me.lblInspeccionInspeccionesRealizadas.TabIndex = 46
        Me.lblInspeccionInspeccionesRealizadas.Text = "INSPECCIONES REALIZADAS"
        '
        'FormInspecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1623, 1002)
        Me.Controls.Add(Me.lblInspeccionInspeccionesRealizadas)
        Me.Controls.Add(Me.dgvInspeccionInspeccionesRealizadas)
        Me.Controls.Add(Me.btnInspeccionBuscar)
        Me.Controls.Add(Me.btnInspeccionLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInspeccionRUT)
        Me.Controls.Add(Me.lblInspeccionRUT)
        Me.Controls.Add(Me.txtInspeccionUnidadInspectora)
        Me.Controls.Add(Me.dtpInspeccionFechaRespuesta)
        Me.Controls.Add(Me.dtpInspeccionFechaDictado)
        Me.Controls.Add(Me.txtInspeccionNarracion)
        Me.Controls.Add(Me.txtInspeccionTipoObservacion)
        Me.Controls.Add(Me.lblInspeccionNarracion)
        Me.Controls.Add(Me.lblInspeccionFechaRespuesta)
        Me.Controls.Add(Me.lblInspeccionFechaDictado)
        Me.Controls.Add(Me.lblInspeccionTipoObservacion)
        Me.Controls.Add(Me.btnInspeccionSalir)
        Me.Controls.Add(Me.btnInspeccionGuardarInspeccion)
        Me.Controls.Add(Me.dtpInspeccionFechaVisita)
        Me.Controls.Add(Me.cboInspeccionTipoUnidad)
        Me.Controls.Add(Me.lblInspeccionlFechaVisita)
        Me.Controls.Add(Me.lblInspeccionTipoUnidad)
        Me.Controls.Add(Me.lblInspeccionUnidadInspectora)
        Me.Controls.Add(Me.lblInspeccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormInspecciones"
        Me.Text = "FormInspeccion"
        CType(Me.dgvInspeccionInspeccionesRealizadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInspeccionSalir As System.Windows.Forms.Button
    Friend WithEvents btnInspeccionGuardarInspeccion As System.Windows.Forms.Button
    Friend WithEvents dtpInspeccionFechaVisita As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboInspeccionTipoUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblInspeccionlFechaVisita As System.Windows.Forms.Label
    Friend WithEvents lblInspeccionTipoUnidad As System.Windows.Forms.Label
    Friend WithEvents lblInspeccionUnidadInspectora As System.Windows.Forms.Label
    Friend WithEvents lblInspeccion As System.Windows.Forms.Label
    Friend WithEvents dtpInspeccionFechaRespuesta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInspeccionFechaDictado As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInspeccionNarracion As System.Windows.Forms.TextBox
    Friend WithEvents txtInspeccionTipoObservacion As System.Windows.Forms.TextBox
    Friend WithEvents lblInspeccionNarracion As System.Windows.Forms.Label
    Friend WithEvents lblInspeccionFechaRespuesta As System.Windows.Forms.Label
    Friend WithEvents lblInspeccionFechaDictado As System.Windows.Forms.Label
    Friend WithEvents lblInspeccionTipoObservacion As System.Windows.Forms.Label
    Friend WithEvents txtInspeccionUnidadInspectora As System.Windows.Forms.TextBox
    Friend WithEvents txtInspeccionRUT As System.Windows.Forms.TextBox
    Friend WithEvents lblInspeccionRUT As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInspeccionLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnInspeccionBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvInspeccionInspeccionesRealizadas As System.Windows.Forms.DataGridView
    Friend WithEvents lblInspeccionInspeccionesRealizadas As System.Windows.Forms.Label
End Class
