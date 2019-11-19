<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManual))
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnManualSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(23, 28)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(379, 38)
        Me.lblEmpresa.TabIndex = 46
        Me.lblEmpresa.Text = "MANUAL DE USUARIO"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(42, 93)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1315, 451)
        Me.TextBox1.TabIndex = 47
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'btnManualSalir
        '
        Me.btnManualSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnManualSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManualSalir.Location = New System.Drawing.Point(1174, 552)
        Me.btnManualSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnManualSalir.Name = "btnManualSalir"
        Me.btnManualSalir.Size = New System.Drawing.Size(181, 73)
        Me.btnManualSalir.TabIndex = 48
        Me.btnManualSalir.Text = "SALIR"
        Me.btnManualSalir.UseVisualStyleBackColor = False
        '
        'FormManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 653)
        Me.Controls.Add(Me.btnManualSalir)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblEmpresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManual"
        Me.Text = "Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnManualSalir As System.Windows.Forms.Button
End Class
