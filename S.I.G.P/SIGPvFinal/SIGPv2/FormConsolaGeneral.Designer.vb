<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsolaGeneral
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
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAdminGral = New System.Windows.Forms.ComboBox()
        Me.dgvAdminGral = New System.Windows.Forms.DataGridView()
        Me.btnAdminGralEliminar = New System.Windows.Forms.Button()
        Me.btnAdminGralLimpiar = New System.Windows.Forms.Button()
        Me.btnAdminGralSalir = New System.Windows.Forms.Button()
        Me.btnAdminGralBuscar = New System.Windows.Forms.Button()
        Me.btnAdminGralGuardar = New System.Windows.Forms.Button()
        CType(Me.dgvAdminGral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(113, 85)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(592, 47)
        Me.lblEmpresa.TabIndex = 46
        Me.lblEmpresa.Text = "ADMINISTRACION GENERAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(745, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "SELECCIONAR TABLA:"
        '
        'cboAdminGral
        '
        Me.cboAdminGral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdminGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdminGral.FormattingEnabled = True
        Me.cboAdminGral.Items.AddRange(New Object() {"A", "CALCULO", "CONTIENE", "CONTRATA", "CUESTIONARIO", "EMPRESA", "GENERA", "HACE", "ICONO", "INSPECCION", "INVENTARIO", "MAPA", "OBSERVACION", "PLAN", "PREGUNTA", "PREVENCIONISTA", "RELEVAMIENTO", "REPORTE", "RESPONDE", "REALIZA", "ROLES", "SOBRE", "TIENE", "TRABAJADOR", "USUARIO_ROL"})
        Me.cboAdminGral.Location = New System.Drawing.Point(1052, 217)
        Me.cboAdminGral.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAdminGral.Name = "cboAdminGral"
        Me.cboAdminGral.Size = New System.Drawing.Size(384, 28)
        Me.cboAdminGral.TabIndex = 48
        '
        'dgvAdminGral
        '
        Me.dgvAdminGral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAdminGral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAdminGral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdminGral.Location = New System.Drawing.Point(36, 252)
        Me.dgvAdminGral.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAdminGral.Name = "dgvAdminGral"
        Me.dgvAdminGral.Size = New System.Drawing.Size(1541, 516)
        Me.dgvAdminGral.TabIndex = 51
        '
        'btnAdminGralEliminar
        '
        Me.btnAdminGralEliminar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGralEliminar.Location = New System.Drawing.Point(1587, 643)
        Me.btnAdminGralEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminGralEliminar.Name = "btnAdminGralEliminar"
        Me.btnAdminGralEliminar.Size = New System.Drawing.Size(252, 36)
        Me.btnAdminGralEliminar.TabIndex = 53
        Me.btnAdminGralEliminar.Text = "ELIMINAR"
        Me.btnAdminGralEliminar.UseVisualStyleBackColor = True
        '
        'btnAdminGralLimpiar
        '
        Me.btnAdminGralLimpiar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGralLimpiar.Location = New System.Drawing.Point(1587, 686)
        Me.btnAdminGralLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminGralLimpiar.Name = "btnAdminGralLimpiar"
        Me.btnAdminGralLimpiar.Size = New System.Drawing.Size(252, 36)
        Me.btnAdminGralLimpiar.TabIndex = 54
        Me.btnAdminGralLimpiar.Text = "LIMPIAR"
        Me.btnAdminGralLimpiar.UseVisualStyleBackColor = True
        '
        'btnAdminGralSalir
        '
        Me.btnAdminGralSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGralSalir.Location = New System.Drawing.Point(1587, 730)
        Me.btnAdminGralSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminGralSalir.Name = "btnAdminGralSalir"
        Me.btnAdminGralSalir.Size = New System.Drawing.Size(252, 36)
        Me.btnAdminGralSalir.TabIndex = 55
        Me.btnAdminGralSalir.Text = "SALIR"
        Me.btnAdminGralSalir.UseVisualStyleBackColor = True
        '
        'btnAdminGralBuscar
        '
        Me.btnAdminGralBuscar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGralBuscar.Image = Global.SIGP.My.Resources.Resources.iconfinder_magnifying_glass_226571
        Me.btnAdminGralBuscar.Location = New System.Drawing.Point(1449, 214)
        Me.btnAdminGralBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminGralBuscar.Name = "btnAdminGralBuscar"
        Me.btnAdminGralBuscar.Size = New System.Drawing.Size(129, 34)
        Me.btnAdminGralBuscar.TabIndex = 56
        Me.btnAdminGralBuscar.UseVisualStyleBackColor = True
        '
        'btnAdminGralGuardar
        '
        Me.btnAdminGralGuardar.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGralGuardar.Location = New System.Drawing.Point(1585, 600)
        Me.btnAdminGralGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminGralGuardar.Name = "btnAdminGralGuardar"
        Me.btnAdminGralGuardar.Size = New System.Drawing.Size(252, 36)
        Me.btnAdminGralGuardar.TabIndex = 57
        Me.btnAdminGralGuardar.Text = "GUARDAR"
        Me.btnAdminGralGuardar.UseVisualStyleBackColor = True
        '
        'FormConsolaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1853, 809)
        Me.Controls.Add(Me.btnAdminGralBuscar)
        Me.Controls.Add(Me.btnAdminGralSalir)
        Me.Controls.Add(Me.btnAdminGralLimpiar)
        Me.Controls.Add(Me.btnAdminGralEliminar)
        Me.Controls.Add(Me.dgvAdminGral)
        Me.Controls.Add(Me.cboAdminGral)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.btnAdminGralGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormConsolaGeneral"
        Me.Text = "FormConsolaGeneral"
        CType(Me.dgvAdminGral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAdminGral As System.Windows.Forms.ComboBox
    Friend WithEvents dgvAdminGral As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdminGralEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAdminGralLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnAdminGralSalir As System.Windows.Forms.Button
    Friend WithEvents btnAdminGralBuscar As System.Windows.Forms.Button
    Friend WithEvents btnAdminGralGuardar As System.Windows.Forms.Button
End Class
