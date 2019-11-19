<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventario
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
        Me.btnInventarioSalir = New System.Windows.Forms.Button()
        Me.btnInventarioGuardar = New System.Windows.Forms.Button()
        Me.txtInventarioNombre = New System.Windows.Forms.TextBox()
        Me.lblInventarioCantidad = New System.Windows.Forms.Label()
        Me.lblInventarioEstado = New System.Windows.Forms.Label()
        Me.lblInventarioNombre = New System.Windows.Forms.Label()
        Me.lblInventarioTitulo = New System.Windows.Forms.Label()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.txtInventarioTipo = New System.Windows.Forms.TextBox()
        Me.lblInventarioTipo = New System.Windows.Forms.Label()
        Me.cboInventarioEstado = New System.Windows.Forms.ComboBox()
        Me.txtInventarioCantidad = New System.Windows.Forms.TextBox()
        Me.lblInventarioItems = New System.Windows.Forms.Label()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInventarioSalir
        '
        Me.btnInventarioSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventarioSalir.Location = New System.Drawing.Point(1004, 330)
        Me.btnInventarioSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInventarioSalir.Name = "btnInventarioSalir"
        Me.btnInventarioSalir.Size = New System.Drawing.Size(167, 70)
        Me.btnInventarioSalir.TabIndex = 26
        Me.btnInventarioSalir.Text = "SALIR"
        Me.btnInventarioSalir.UseVisualStyleBackColor = True
        '
        'btnInventarioGuardar
        '
        Me.btnInventarioGuardar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventarioGuardar.Location = New System.Drawing.Point(1004, 230)
        Me.btnInventarioGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInventarioGuardar.Name = "btnInventarioGuardar"
        Me.btnInventarioGuardar.Size = New System.Drawing.Size(167, 70)
        Me.btnInventarioGuardar.TabIndex = 24
        Me.btnInventarioGuardar.Text = "GUARDAR"
        Me.btnInventarioGuardar.UseVisualStyleBackColor = True
        '
        'txtInventarioNombre
        '
        Me.txtInventarioNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioNombre.Location = New System.Drawing.Point(299, 228)
        Me.txtInventarioNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInventarioNombre.MaxLength = 10
        Me.txtInventarioNombre.Name = "txtInventarioNombre"
        Me.txtInventarioNombre.Size = New System.Drawing.Size(668, 32)
        Me.txtInventarioNombre.TabIndex = 20
        '
        'lblInventarioCantidad
        '
        Me.lblInventarioCantidad.AutoSize = True
        Me.lblInventarioCantidad.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventarioCantidad.Location = New System.Drawing.Point(159, 331)
        Me.lblInventarioCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventarioCantidad.Name = "lblInventarioCantidad"
        Me.lblInventarioCantidad.Size = New System.Drawing.Size(127, 24)
        Me.lblInventarioCantidad.TabIndex = 19
        Me.lblInventarioCantidad.Text = "CANTIDAD:"
        '
        'lblInventarioEstado
        '
        Me.lblInventarioEstado.AutoSize = True
        Me.lblInventarioEstado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventarioEstado.Location = New System.Drawing.Point(77, 379)
        Me.lblInventarioEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventarioEstado.Name = "lblInventarioEstado"
        Me.lblInventarioEstado.Size = New System.Drawing.Size(199, 24)
        Me.lblInventarioEstado.TabIndex = 18
        Me.lblInventarioEstado.Text = "ESTADO GENERAL:"
        '
        'lblInventarioNombre
        '
        Me.lblInventarioNombre.AutoSize = True
        Me.lblInventarioNombre.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventarioNombre.Location = New System.Drawing.Point(177, 231)
        Me.lblInventarioNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventarioNombre.Name = "lblInventarioNombre"
        Me.lblInventarioNombre.Size = New System.Drawing.Size(104, 24)
        Me.lblInventarioNombre.TabIndex = 17
        Me.lblInventarioNombre.Text = "NOMBRE:"
        '
        'lblInventarioTitulo
        '
        Me.lblInventarioTitulo.AutoSize = True
        Me.lblInventarioTitulo.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventarioTitulo.Location = New System.Drawing.Point(111, 48)
        Me.lblInventarioTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventarioTitulo.Name = "lblInventarioTitulo"
        Me.lblInventarioTitulo.Size = New System.Drawing.Size(279, 47)
        Me.lblInventarioTitulo.TabIndex = 15
        Me.lblInventarioTitulo.Text = "INVENTARIO"
        '
        'dgvInventario
        '
        Me.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(183, 444)
        Me.dgvInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(1008, 334)
        Me.dgvInventario.TabIndex = 51
        '
        'txtInventarioTipo
        '
        Me.txtInventarioTipo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioTipo.Location = New System.Drawing.Point(299, 277)
        Me.txtInventarioTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInventarioTipo.MaxLength = 15
        Me.txtInventarioTipo.Name = "txtInventarioTipo"
        Me.txtInventarioTipo.Size = New System.Drawing.Size(668, 32)
        Me.txtInventarioTipo.TabIndex = 54
        '
        'lblInventarioTipo
        '
        Me.lblInventarioTipo.AutoSize = True
        Me.lblInventarioTipo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventarioTipo.Location = New System.Drawing.Point(221, 283)
        Me.lblInventarioTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventarioTipo.Name = "lblInventarioTipo"
        Me.lblInventarioTipo.Size = New System.Drawing.Size(62, 24)
        Me.lblInventarioTipo.TabIndex = 53
        Me.lblInventarioTipo.Text = "TIPO:"
        '
        'cboInventarioEstado
        '
        Me.cboInventarioEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInventarioEstado.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInventarioEstado.FormattingEnabled = True
        Me.cboInventarioEstado.Items.AddRange(New Object() {"EXCELENTE", "ACEPTABLE", "DEFICIENTE", "EN MANTENIMIENTO"})
        Me.cboInventarioEstado.Location = New System.Drawing.Point(299, 380)
        Me.cboInventarioEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInventarioEstado.Name = "cboInventarioEstado"
        Me.cboInventarioEstado.Size = New System.Drawing.Size(160, 32)
        Me.cboInventarioEstado.TabIndex = 55
        '
        'txtInventarioCantidad
        '
        Me.txtInventarioCantidad.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioCantidad.Location = New System.Drawing.Point(299, 329)
        Me.txtInventarioCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInventarioCantidad.Name = "txtInventarioCantidad"
        Me.txtInventarioCantidad.Size = New System.Drawing.Size(668, 32)
        Me.txtInventarioCantidad.TabIndex = 56
        '
        'lblInventarioItems
        '
        Me.lblInventarioItems.AutoSize = True
        Me.lblInventarioItems.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventarioItems.Location = New System.Drawing.Point(177, 170)
        Me.lblInventarioItems.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInventarioItems.Name = "lblInventarioItems"
        Me.lblInventarioItems.Size = New System.Drawing.Size(91, 28)
        Me.lblInventarioItems.TabIndex = 57
        Me.lblInventarioItems.Text = "ITEMS"
        '
        'FormInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1405, 818)
        Me.Controls.Add(Me.lblInventarioItems)
        Me.Controls.Add(Me.txtInventarioCantidad)
        Me.Controls.Add(Me.cboInventarioEstado)
        Me.Controls.Add(Me.txtInventarioTipo)
        Me.Controls.Add(Me.lblInventarioTipo)
        Me.Controls.Add(Me.dgvInventario)
        Me.Controls.Add(Me.btnInventarioSalir)
        Me.Controls.Add(Me.btnInventarioGuardar)
        Me.Controls.Add(Me.txtInventarioNombre)
        Me.Controls.Add(Me.lblInventarioCantidad)
        Me.Controls.Add(Me.lblInventarioEstado)
        Me.Controls.Add(Me.lblInventarioNombre)
        Me.Controls.Add(Me.lblInventarioTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormInventario"
        Me.Text = "FormInventario"
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInventarioSalir As System.Windows.Forms.Button
    Friend WithEvents btnInventarioGuardar As System.Windows.Forms.Button
    Friend WithEvents txtInventarioNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblInventarioCantidad As System.Windows.Forms.Label
    Friend WithEvents lblInventarioEstado As System.Windows.Forms.Label
    Friend WithEvents lblInventarioNombre As System.Windows.Forms.Label
    Friend WithEvents lblInventarioTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvInventario As System.Windows.Forms.DataGridView
    Friend WithEvents txtInventarioTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblInventarioTipo As System.Windows.Forms.Label
    Friend WithEvents cboInventarioEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtInventarioCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblInventarioItems As System.Windows.Forms.Label
End Class
