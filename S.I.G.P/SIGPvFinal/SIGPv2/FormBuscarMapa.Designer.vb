<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarMapa
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
        Me.btnMapaSalir = New System.Windows.Forms.Button()
        Me.gbBuscarMapa = New System.Windows.Forms.GroupBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.dgvAbrirMapa = New System.Windows.Forms.DataGridView()
        Me.btnMapaNuevoMapa = New System.Windows.Forms.Button()
        Me.gbBuscarMapa.SuspendLayout()
        CType(Me.dgvAbrirMapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMapaSalir
        '
        Me.btnMapaSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapaSalir.Location = New System.Drawing.Point(1141, 387)
        Me.btnMapaSalir.Name = "btnMapaSalir"
        Me.btnMapaSalir.Size = New System.Drawing.Size(125, 57)
        Me.btnMapaSalir.TabIndex = 8
        Me.btnMapaSalir.Text = "SALIR"
        Me.btnMapaSalir.UseVisualStyleBackColor = True
        '
        'gbBuscarMapa
        '
        Me.gbBuscarMapa.Controls.Add(Me.lblEmpresa)
        Me.gbBuscarMapa.Controls.Add(Me.dgvAbrirMapa)
        Me.gbBuscarMapa.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscarMapa.Location = New System.Drawing.Point(97, 44)
        Me.gbBuscarMapa.Name = "gbBuscarMapa"
        Me.gbBuscarMapa.Size = New System.Drawing.Size(1214, 326)
        Me.gbBuscarMapa.TabIndex = 7
        Me.gbBuscarMapa.TabStop = False
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(48, 30)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(364, 38)
        Me.lblEmpresa.TabIndex = 52
        Me.lblEmpresa.Text = "SELECCIONAR MAPA:"
        '
        'dgvAbrirMapa
        '
        Me.dgvAbrirMapa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAbrirMapa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAbrirMapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAbrirMapa.Location = New System.Drawing.Point(55, 83)
        Me.dgvAbrirMapa.Name = "dgvAbrirMapa"
        Me.dgvAbrirMapa.Size = New System.Drawing.Size(1106, 170)
        Me.dgvAbrirMapa.TabIndex = 51
        '
        'btnMapaNuevoMapa
        '
        Me.btnMapaNuevoMapa.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapaNuevoMapa.Location = New System.Drawing.Point(1010, 387)
        Me.btnMapaNuevoMapa.Name = "btnMapaNuevoMapa"
        Me.btnMapaNuevoMapa.Size = New System.Drawing.Size(125, 57)
        Me.btnMapaNuevoMapa.TabIndex = 9
        Me.btnMapaNuevoMapa.Text = "NUEVO MAPA"
        Me.btnMapaNuevoMapa.UseVisualStyleBackColor = True
        '
        'FormBuscarMapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 530)
        Me.Controls.Add(Me.btnMapaNuevoMapa)
        Me.Controls.Add(Me.btnMapaSalir)
        Me.Controls.Add(Me.gbBuscarMapa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBuscarMapa"
        Me.Text = "FormBuscarMapa"
        Me.gbBuscarMapa.ResumeLayout(False)
        Me.gbBuscarMapa.PerformLayout()
        CType(Me.dgvAbrirMapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMapaSalir As System.Windows.Forms.Button
    Friend WithEvents gbBuscarMapa As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAbrirMapa As System.Windows.Forms.DataGridView
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents btnMapaNuevoMapa As System.Windows.Forms.Button
End Class
