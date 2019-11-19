<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlanDeContingencia
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
        Me.txtPlanContingenciaNombre = New System.Windows.Forms.TextBox()
        Me.txtPlanContingenciaSolucion = New System.Windows.Forms.TextBox()
        Me.chkPlanContingenciaCompletado = New System.Windows.Forms.CheckBox()
        Me.lblPlanContingenciaSolucion = New System.Windows.Forms.Label()
        Me.lblPlanContingenciaNombre = New System.Windows.Forms.Label()
        Me.lblPlanContingenciaCompletado = New System.Windows.Forms.Label()
        Me.lblPlanContingenciaTitulo = New System.Windows.Forms.Label()
        Me.btnPlanContingenciaSalir = New System.Windows.Forms.Button()
        Me.btnPlanContingenciaGuardar = New System.Windows.Forms.Button()
        Me.btnPlanContingenciaLimpiar = New System.Windows.Forms.Button()
        Me.lblPlanContingenciaInspeccion = New System.Windows.Forms.Label()
        Me.txtPlanContingenciaInspeccion = New System.Windows.Forms.TextBox()
        Me.dgvPlanContingenciaInspecciones = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPlanContingenciaInspecciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPlanContingenciaNombre
        '
        Me.txtPlanContingenciaNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanContingenciaNombre.Location = New System.Drawing.Point(248, 214)
        Me.txtPlanContingenciaNombre.Name = "txtPlanContingenciaNombre"
        Me.txtPlanContingenciaNombre.Size = New System.Drawing.Size(439, 27)
        Me.txtPlanContingenciaNombre.TabIndex = 13
        '
        'txtPlanContingenciaSolucion
        '
        Me.txtPlanContingenciaSolucion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanContingenciaSolucion.Location = New System.Drawing.Point(248, 256)
        Me.txtPlanContingenciaSolucion.Multiline = True
        Me.txtPlanContingenciaSolucion.Name = "txtPlanContingenciaSolucion"
        Me.txtPlanContingenciaSolucion.Size = New System.Drawing.Size(439, 112)
        Me.txtPlanContingenciaSolucion.TabIndex = 12
        '
        'chkPlanContingenciaCompletado
        '
        Me.chkPlanContingenciaCompletado.AutoSize = True
        Me.chkPlanContingenciaCompletado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlanContingenciaCompletado.Location = New System.Drawing.Point(676, 177)
        Me.chkPlanContingenciaCompletado.Name = "chkPlanContingenciaCompletado"
        Me.chkPlanContingenciaCompletado.Size = New System.Drawing.Size(15, 14)
        Me.chkPlanContingenciaCompletado.TabIndex = 11
        Me.chkPlanContingenciaCompletado.UseVisualStyleBackColor = True
        '
        'lblPlanContingenciaSolucion
        '
        Me.lblPlanContingenciaSolucion.AutoSize = True
        Me.lblPlanContingenciaSolucion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanContingenciaSolucion.Location = New System.Drawing.Point(144, 256)
        Me.lblPlanContingenciaSolucion.Name = "lblPlanContingenciaSolucion"
        Me.lblPlanContingenciaSolucion.Size = New System.Drawing.Size(98, 20)
        Me.lblPlanContingenciaSolucion.TabIndex = 10
        Me.lblPlanContingenciaSolucion.Text = "SOLUCION:"
        '
        'lblPlanContingenciaNombre
        '
        Me.lblPlanContingenciaNombre.AutoSize = True
        Me.lblPlanContingenciaNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanContingenciaNombre.Location = New System.Drawing.Point(154, 217)
        Me.lblPlanContingenciaNombre.Name = "lblPlanContingenciaNombre"
        Me.lblPlanContingenciaNombre.Size = New System.Drawing.Size(85, 20)
        Me.lblPlanContingenciaNombre.TabIndex = 9
        Me.lblPlanContingenciaNombre.Text = "NOMBRE:"
        '
        'lblPlanContingenciaCompletado
        '
        Me.lblPlanContingenciaCompletado.AutoSize = True
        Me.lblPlanContingenciaCompletado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanContingenciaCompletado.Location = New System.Drawing.Point(545, 173)
        Me.lblPlanContingenciaCompletado.Name = "lblPlanContingenciaCompletado"
        Me.lblPlanContingenciaCompletado.Size = New System.Drawing.Size(125, 20)
        Me.lblPlanContingenciaCompletado.TabIndex = 8
        Me.lblPlanContingenciaCompletado.Text = "COMPLETADO"
        '
        'lblPlanContingenciaTitulo
        '
        Me.lblPlanContingenciaTitulo.AutoSize = True
        Me.lblPlanContingenciaTitulo.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanContingenciaTitulo.Location = New System.Drawing.Point(168, 128)
        Me.lblPlanContingenciaTitulo.Name = "lblPlanContingenciaTitulo"
        Me.lblPlanContingenciaTitulo.Size = New System.Drawing.Size(362, 32)
        Me.lblPlanContingenciaTitulo.TabIndex = 14
        Me.lblPlanContingenciaTitulo.Text = "PLAN DE CONTINGENCIA"
        '
        'btnPlanContingenciaSalir
        '
        Me.btnPlanContingenciaSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanContingenciaSalir.Location = New System.Drawing.Point(745, 311)
        Me.btnPlanContingenciaSalir.Name = "btnPlanContingenciaSalir"
        Me.btnPlanContingenciaSalir.Size = New System.Drawing.Size(125, 57)
        Me.btnPlanContingenciaSalir.TabIndex = 15
        Me.btnPlanContingenciaSalir.Text = "SALIR"
        Me.btnPlanContingenciaSalir.UseVisualStyleBackColor = True
        '
        'btnPlanContingenciaGuardar
        '
        Me.btnPlanContingenciaGuardar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanContingenciaGuardar.Location = New System.Drawing.Point(745, 184)
        Me.btnPlanContingenciaGuardar.Name = "btnPlanContingenciaGuardar"
        Me.btnPlanContingenciaGuardar.Size = New System.Drawing.Size(125, 57)
        Me.btnPlanContingenciaGuardar.TabIndex = 16
        Me.btnPlanContingenciaGuardar.Text = "GUARDAR"
        Me.btnPlanContingenciaGuardar.UseVisualStyleBackColor = True
        '
        'btnPlanContingenciaLimpiar
        '
        Me.btnPlanContingenciaLimpiar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanContingenciaLimpiar.Location = New System.Drawing.Point(745, 247)
        Me.btnPlanContingenciaLimpiar.Name = "btnPlanContingenciaLimpiar"
        Me.btnPlanContingenciaLimpiar.Size = New System.Drawing.Size(125, 57)
        Me.btnPlanContingenciaLimpiar.TabIndex = 17
        Me.btnPlanContingenciaLimpiar.Text = "LIMPIAR"
        Me.btnPlanContingenciaLimpiar.UseVisualStyleBackColor = True
        '
        'lblPlanContingenciaInspeccion
        '
        Me.lblPlanContingenciaInspeccion.AutoSize = True
        Me.lblPlanContingenciaInspeccion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanContingenciaInspeccion.Location = New System.Drawing.Point(130, 390)
        Me.lblPlanContingenciaInspeccion.Name = "lblPlanContingenciaInspeccion"
        Me.lblPlanContingenciaInspeccion.Size = New System.Drawing.Size(112, 20)
        Me.lblPlanContingenciaInspeccion.TabIndex = 18
        Me.lblPlanContingenciaInspeccion.Text = "INSPECCION:"
        '
        'txtPlanContingenciaInspeccion
        '
        Me.txtPlanContingenciaInspeccion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanContingenciaInspeccion.Location = New System.Drawing.Point(246, 387)
        Me.txtPlanContingenciaInspeccion.Name = "txtPlanContingenciaInspeccion"
        Me.txtPlanContingenciaInspeccion.Size = New System.Drawing.Size(439, 27)
        Me.txtPlanContingenciaInspeccion.TabIndex = 19
        '
        'dgvPlanContingenciaInspecciones
        '
        Me.dgvPlanContingenciaInspecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlanContingenciaInspecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanContingenciaInspecciones.Location = New System.Drawing.Point(134, 440)
        Me.dgvPlanContingenciaInspecciones.Name = "dgvPlanContingenciaInspecciones"
        Me.dgvPlanContingenciaInspecciones.ReadOnly = True
        Me.dgvPlanContingenciaInspecciones.Size = New System.Drawing.Size(736, 150)
        Me.dgvPlanContingenciaInspecciones.TabIndex = 20
        '
        'FormPlanDeContingencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 602)
        Me.Controls.Add(Me.dgvPlanContingenciaInspecciones)
        Me.Controls.Add(Me.txtPlanContingenciaInspeccion)
        Me.Controls.Add(Me.lblPlanContingenciaInspeccion)
        Me.Controls.Add(Me.btnPlanContingenciaLimpiar)
        Me.Controls.Add(Me.btnPlanContingenciaGuardar)
        Me.Controls.Add(Me.btnPlanContingenciaSalir)
        Me.Controls.Add(Me.lblPlanContingenciaTitulo)
        Me.Controls.Add(Me.txtPlanContingenciaNombre)
        Me.Controls.Add(Me.txtPlanContingenciaSolucion)
        Me.Controls.Add(Me.chkPlanContingenciaCompletado)
        Me.Controls.Add(Me.lblPlanContingenciaSolucion)
        Me.Controls.Add(Me.lblPlanContingenciaNombre)
        Me.Controls.Add(Me.lblPlanContingenciaCompletado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPlanDeContingencia"
        Me.Text = "FormPlanDeContingencia"
        CType(Me.dgvPlanContingenciaInspecciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlanContingenciaNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPlanContingenciaSolucion As System.Windows.Forms.TextBox
    Friend WithEvents chkPlanContingenciaCompletado As System.Windows.Forms.CheckBox
    Friend WithEvents lblPlanContingenciaSolucion As System.Windows.Forms.Label
    Friend WithEvents lblPlanContingenciaNombre As System.Windows.Forms.Label
    Friend WithEvents lblPlanContingenciaCompletado As System.Windows.Forms.Label
    Friend WithEvents lblPlanContingenciaTitulo As System.Windows.Forms.Label
    Friend WithEvents btnPlanContingenciaSalir As System.Windows.Forms.Button
    Friend WithEvents btnPlanContingenciaGuardar As System.Windows.Forms.Button
    Friend WithEvents btnPlanContingenciaLimpiar As System.Windows.Forms.Button
    Friend WithEvents lblPlanContingenciaInspeccion As System.Windows.Forms.Label
    Friend WithEvents txtPlanContingenciaInspeccion As System.Windows.Forms.TextBox
    Friend WithEvents dgvPlanContingenciaInspecciones As System.Windows.Forms.DataGridView
End Class
