<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMapas
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
        Me.components = New System.ComponentModel.Container()
        Me.pbMapasPlano = New System.Windows.Forms.PictureBox()
        Me.tcMapasIconos = New System.Windows.Forms.TabControl()
        Me.tbMapasObl = New System.Windows.Forms.TabPage()
        Me.pbOblig4 = New System.Windows.Forms.PictureBox()
        Me.pbOblig3 = New System.Windows.Forms.PictureBox()
        Me.pbOblig2 = New System.Windows.Forms.PictureBox()
        Me.pbOblig1 = New System.Windows.Forms.PictureBox()
        Me.tbMapasProhib = New System.Windows.Forms.TabPage()
        Me.pbProhib4 = New System.Windows.Forms.PictureBox()
        Me.pbProhib3 = New System.Windows.Forms.PictureBox()
        Me.pbProhib2 = New System.Windows.Forms.PictureBox()
        Me.pbProhib1 = New System.Windows.Forms.PictureBox()
        Me.tbMapasRiesgo = New System.Windows.Forms.TabPage()
        Me.pbRiesgo4 = New System.Windows.Forms.PictureBox()
        Me.pbRiesgo3 = New System.Windows.Forms.PictureBox()
        Me.pbRiesgo2 = New System.Windows.Forms.PictureBox()
        Me.pbRiesgo1 = New System.Windows.Forms.PictureBox()
        Me.tbMapasInfo = New System.Windows.Forms.TabPage()
        Me.pbInfo3 = New System.Windows.Forms.PictureBox()
        Me.pbInfo2 = New System.Windows.Forms.PictureBox()
        Me.pbInfo1 = New System.Windows.Forms.PictureBox()
        Me.tbMapasVeloc = New System.Windows.Forms.TabPage()
        Me.pbVelo4 = New System.Windows.Forms.PictureBox()
        Me.pbVelo3 = New System.Windows.Forms.PictureBox()
        Me.pbVelo2 = New System.Windows.Forms.PictureBox()
        Me.pbVelo1 = New System.Windows.Forms.PictureBox()
        Me.btnMapasGuardarMapa = New System.Windows.Forms.Button()
        Me.btnMapasCargarPlano = New System.Windows.Forms.Button()
        Me.OfdSeleccionarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.btnMapasSalir = New System.Windows.Forms.Button()
        Me.lblMapasNombreM = New System.Windows.Forms.Label()
        Me.txtMapasNombreMapa = New System.Windows.Forms.TextBox()
        Me.cmClickDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.opcionTSMEliminar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbMapasPlano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcMapasIconos.SuspendLayout()
        Me.tbMapasObl.SuspendLayout()
        CType(Me.pbOblig4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOblig3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOblig2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOblig1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMapasProhib.SuspendLayout()
        CType(Me.pbProhib4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProhib3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProhib2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProhib1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMapasRiesgo.SuspendLayout()
        CType(Me.pbRiesgo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRiesgo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRiesgo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRiesgo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMapasInfo.SuspendLayout()
        CType(Me.pbInfo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMapasVeloc.SuspendLayout()
        CType(Me.pbVelo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVelo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVelo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVelo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmClickDerecho.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbMapasPlano
        '
        Me.pbMapasPlano.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMapasPlano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbMapasPlano.Location = New System.Drawing.Point(43, 64)
        Me.pbMapasPlano.Margin = New System.Windows.Forms.Padding(4)
        Me.pbMapasPlano.Name = "pbMapasPlano"
        Me.pbMapasPlano.Size = New System.Drawing.Size(1660, 742)
        Me.pbMapasPlano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMapasPlano.TabIndex = 0
        Me.pbMapasPlano.TabStop = False
        '
        'tcMapasIconos
        '
        Me.tcMapasIconos.Controls.Add(Me.tbMapasObl)
        Me.tcMapasIconos.Controls.Add(Me.tbMapasProhib)
        Me.tcMapasIconos.Controls.Add(Me.tbMapasRiesgo)
        Me.tcMapasIconos.Controls.Add(Me.tbMapasInfo)
        Me.tcMapasIconos.Controls.Add(Me.tbMapasVeloc)
        Me.tcMapasIconos.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMapasIconos.Location = New System.Drawing.Point(36, 875)
        Me.tcMapasIconos.Margin = New System.Windows.Forms.Padding(4)
        Me.tcMapasIconos.Name = "tcMapasIconos"
        Me.tcMapasIconos.SelectedIndex = 0
        Me.tcMapasIconos.Size = New System.Drawing.Size(617, 130)
        Me.tcMapasIconos.TabIndex = 23
        '
        'tbMapasObl
        '
        Me.tbMapasObl.Controls.Add(Me.pbOblig4)
        Me.tbMapasObl.Controls.Add(Me.pbOblig3)
        Me.tbMapasObl.Controls.Add(Me.pbOblig2)
        Me.tbMapasObl.Controls.Add(Me.pbOblig1)
        Me.tbMapasObl.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMapasObl.Location = New System.Drawing.Point(4, 29)
        Me.tbMapasObl.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMapasObl.Name = "tbMapasObl"
        Me.tbMapasObl.Padding = New System.Windows.Forms.Padding(4)
        Me.tbMapasObl.Size = New System.Drawing.Size(609, 97)
        Me.tbMapasObl.TabIndex = 0
        Me.tbMapasObl.Text = "OBLIGATORIOS"
        Me.tbMapasObl.UseVisualStyleBackColor = True
        '
        'pbOblig4
        '
        Me.pbOblig4.Location = New System.Drawing.Point(419, 7)
        Me.pbOblig4.Margin = New System.Windows.Forms.Padding(4)
        Me.pbOblig4.Name = "pbOblig4"
        Me.pbOblig4.Size = New System.Drawing.Size(73, 76)
        Me.pbOblig4.TabIndex = 8
        Me.pbOblig4.TabStop = False
        '
        'pbOblig3
        '
        Me.pbOblig3.Location = New System.Drawing.Point(309, 7)
        Me.pbOblig3.Margin = New System.Windows.Forms.Padding(4)
        Me.pbOblig3.Name = "pbOblig3"
        Me.pbOblig3.Size = New System.Drawing.Size(73, 76)
        Me.pbOblig3.TabIndex = 7
        Me.pbOblig3.TabStop = False
        '
        'pbOblig2
        '
        Me.pbOblig2.Location = New System.Drawing.Point(199, 7)
        Me.pbOblig2.Margin = New System.Windows.Forms.Padding(4)
        Me.pbOblig2.Name = "pbOblig2"
        Me.pbOblig2.Size = New System.Drawing.Size(73, 76)
        Me.pbOblig2.TabIndex = 6
        Me.pbOblig2.TabStop = False
        '
        'pbOblig1
        '
        Me.pbOblig1.Location = New System.Drawing.Point(95, 7)
        Me.pbOblig1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbOblig1.Name = "pbOblig1"
        Me.pbOblig1.Size = New System.Drawing.Size(73, 76)
        Me.pbOblig1.TabIndex = 5
        Me.pbOblig1.TabStop = False
        '
        'tbMapasProhib
        '
        Me.tbMapasProhib.Controls.Add(Me.pbProhib4)
        Me.tbMapasProhib.Controls.Add(Me.pbProhib3)
        Me.tbMapasProhib.Controls.Add(Me.pbProhib2)
        Me.tbMapasProhib.Controls.Add(Me.pbProhib1)
        Me.tbMapasProhib.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMapasProhib.Location = New System.Drawing.Point(4, 29)
        Me.tbMapasProhib.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMapasProhib.Name = "tbMapasProhib"
        Me.tbMapasProhib.Padding = New System.Windows.Forms.Padding(4)
        Me.tbMapasProhib.Size = New System.Drawing.Size(609, 97)
        Me.tbMapasProhib.TabIndex = 1
        Me.tbMapasProhib.Text = "PROHIBIDO"
        Me.tbMapasProhib.UseVisualStyleBackColor = True
        '
        'pbProhib4
        '
        Me.pbProhib4.Location = New System.Drawing.Point(427, 10)
        Me.pbProhib4.Margin = New System.Windows.Forms.Padding(4)
        Me.pbProhib4.Name = "pbProhib4"
        Me.pbProhib4.Size = New System.Drawing.Size(73, 76)
        Me.pbProhib4.TabIndex = 8
        Me.pbProhib4.TabStop = False
        '
        'pbProhib3
        '
        Me.pbProhib3.Location = New System.Drawing.Point(320, 10)
        Me.pbProhib3.Margin = New System.Windows.Forms.Padding(4)
        Me.pbProhib3.Name = "pbProhib3"
        Me.pbProhib3.Size = New System.Drawing.Size(73, 76)
        Me.pbProhib3.TabIndex = 7
        Me.pbProhib3.TabStop = False
        '
        'pbProhib2
        '
        Me.pbProhib2.Location = New System.Drawing.Point(209, 10)
        Me.pbProhib2.Margin = New System.Windows.Forms.Padding(4)
        Me.pbProhib2.Name = "pbProhib2"
        Me.pbProhib2.Size = New System.Drawing.Size(73, 76)
        Me.pbProhib2.TabIndex = 6
        Me.pbProhib2.TabStop = False
        '
        'pbProhib1
        '
        Me.pbProhib1.Location = New System.Drawing.Point(105, 10)
        Me.pbProhib1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbProhib1.Name = "pbProhib1"
        Me.pbProhib1.Size = New System.Drawing.Size(73, 76)
        Me.pbProhib1.TabIndex = 5
        Me.pbProhib1.TabStop = False
        '
        'tbMapasRiesgo
        '
        Me.tbMapasRiesgo.Controls.Add(Me.pbRiesgo4)
        Me.tbMapasRiesgo.Controls.Add(Me.pbRiesgo3)
        Me.tbMapasRiesgo.Controls.Add(Me.pbRiesgo2)
        Me.tbMapasRiesgo.Controls.Add(Me.pbRiesgo1)
        Me.tbMapasRiesgo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMapasRiesgo.Location = New System.Drawing.Point(4, 29)
        Me.tbMapasRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMapasRiesgo.Name = "tbMapasRiesgo"
        Me.tbMapasRiesgo.Padding = New System.Windows.Forms.Padding(4)
        Me.tbMapasRiesgo.Size = New System.Drawing.Size(609, 97)
        Me.tbMapasRiesgo.TabIndex = 2
        Me.tbMapasRiesgo.Text = "RIESGO"
        Me.tbMapasRiesgo.UseVisualStyleBackColor = True
        '
        'pbRiesgo4
        '
        Me.pbRiesgo4.Location = New System.Drawing.Point(427, 10)
        Me.pbRiesgo4.Margin = New System.Windows.Forms.Padding(4)
        Me.pbRiesgo4.Name = "pbRiesgo4"
        Me.pbRiesgo4.Size = New System.Drawing.Size(73, 76)
        Me.pbRiesgo4.TabIndex = 8
        Me.pbRiesgo4.TabStop = False
        '
        'pbRiesgo3
        '
        Me.pbRiesgo3.Location = New System.Drawing.Point(320, 10)
        Me.pbRiesgo3.Margin = New System.Windows.Forms.Padding(4)
        Me.pbRiesgo3.Name = "pbRiesgo3"
        Me.pbRiesgo3.Size = New System.Drawing.Size(73, 76)
        Me.pbRiesgo3.TabIndex = 7
        Me.pbRiesgo3.TabStop = False
        '
        'pbRiesgo2
        '
        Me.pbRiesgo2.Location = New System.Drawing.Point(209, 10)
        Me.pbRiesgo2.Margin = New System.Windows.Forms.Padding(4)
        Me.pbRiesgo2.Name = "pbRiesgo2"
        Me.pbRiesgo2.Size = New System.Drawing.Size(73, 76)
        Me.pbRiesgo2.TabIndex = 6
        Me.pbRiesgo2.TabStop = False
        '
        'pbRiesgo1
        '
        Me.pbRiesgo1.Location = New System.Drawing.Point(105, 10)
        Me.pbRiesgo1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbRiesgo1.Name = "pbRiesgo1"
        Me.pbRiesgo1.Size = New System.Drawing.Size(73, 76)
        Me.pbRiesgo1.TabIndex = 5
        Me.pbRiesgo1.TabStop = False
        '
        'tbMapasInfo
        '
        Me.tbMapasInfo.Controls.Add(Me.pbInfo3)
        Me.tbMapasInfo.Controls.Add(Me.pbInfo2)
        Me.tbMapasInfo.Controls.Add(Me.pbInfo1)
        Me.tbMapasInfo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMapasInfo.Location = New System.Drawing.Point(4, 29)
        Me.tbMapasInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMapasInfo.Name = "tbMapasInfo"
        Me.tbMapasInfo.Size = New System.Drawing.Size(609, 97)
        Me.tbMapasInfo.TabIndex = 3
        Me.tbMapasInfo.Text = "INFORMACION"
        Me.tbMapasInfo.UseVisualStyleBackColor = True
        '
        'pbInfo3
        '
        Me.pbInfo3.Location = New System.Drawing.Point(380, 9)
        Me.pbInfo3.Margin = New System.Windows.Forms.Padding(4)
        Me.pbInfo3.Name = "pbInfo3"
        Me.pbInfo3.Size = New System.Drawing.Size(73, 76)
        Me.pbInfo3.TabIndex = 7
        Me.pbInfo3.TabStop = False
        '
        'pbInfo2
        '
        Me.pbInfo2.Location = New System.Drawing.Point(269, 9)
        Me.pbInfo2.Margin = New System.Windows.Forms.Padding(4)
        Me.pbInfo2.Name = "pbInfo2"
        Me.pbInfo2.Size = New System.Drawing.Size(73, 76)
        Me.pbInfo2.TabIndex = 6
        Me.pbInfo2.TabStop = False
        '
        'pbInfo1
        '
        Me.pbInfo1.Location = New System.Drawing.Point(165, 9)
        Me.pbInfo1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbInfo1.Name = "pbInfo1"
        Me.pbInfo1.Size = New System.Drawing.Size(73, 76)
        Me.pbInfo1.TabIndex = 5
        Me.pbInfo1.TabStop = False
        '
        'tbMapasVeloc
        '
        Me.tbMapasVeloc.Controls.Add(Me.pbVelo4)
        Me.tbMapasVeloc.Controls.Add(Me.pbVelo3)
        Me.tbMapasVeloc.Controls.Add(Me.pbVelo2)
        Me.tbMapasVeloc.Controls.Add(Me.pbVelo1)
        Me.tbMapasVeloc.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMapasVeloc.Location = New System.Drawing.Point(4, 29)
        Me.tbMapasVeloc.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMapasVeloc.Name = "tbMapasVeloc"
        Me.tbMapasVeloc.Size = New System.Drawing.Size(609, 97)
        Me.tbMapasVeloc.TabIndex = 4
        Me.tbMapasVeloc.Text = "VELOCIDAD"
        Me.tbMapasVeloc.UseVisualStyleBackColor = True
        '
        'pbVelo4
        '
        Me.pbVelo4.Location = New System.Drawing.Point(423, 9)
        Me.pbVelo4.Margin = New System.Windows.Forms.Padding(4)
        Me.pbVelo4.Name = "pbVelo4"
        Me.pbVelo4.Size = New System.Drawing.Size(73, 76)
        Me.pbVelo4.TabIndex = 4
        Me.pbVelo4.TabStop = False
        '
        'pbVelo3
        '
        Me.pbVelo3.Location = New System.Drawing.Point(316, 9)
        Me.pbVelo3.Margin = New System.Windows.Forms.Padding(4)
        Me.pbVelo3.Name = "pbVelo3"
        Me.pbVelo3.Size = New System.Drawing.Size(73, 76)
        Me.pbVelo3.TabIndex = 3
        Me.pbVelo3.TabStop = False
        '
        'pbVelo2
        '
        Me.pbVelo2.Location = New System.Drawing.Point(205, 9)
        Me.pbVelo2.Margin = New System.Windows.Forms.Padding(4)
        Me.pbVelo2.Name = "pbVelo2"
        Me.pbVelo2.Size = New System.Drawing.Size(73, 76)
        Me.pbVelo2.TabIndex = 2
        Me.pbVelo2.TabStop = False
        '
        'pbVelo1
        '
        Me.pbVelo1.Location = New System.Drawing.Point(101, 9)
        Me.pbVelo1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbVelo1.Name = "pbVelo1"
        Me.pbVelo1.Size = New System.Drawing.Size(73, 76)
        Me.pbVelo1.TabIndex = 1
        Me.pbVelo1.TabStop = False
        '
        'btnMapasGuardarMapa
        '
        Me.btnMapasGuardarMapa.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapasGuardarMapa.Location = New System.Drawing.Point(1465, 930)
        Me.btnMapasGuardarMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMapasGuardarMapa.Name = "btnMapasGuardarMapa"
        Me.btnMapasGuardarMapa.Size = New System.Drawing.Size(167, 70)
        Me.btnMapasGuardarMapa.TabIndex = 26
        Me.btnMapasGuardarMapa.Text = "GUARDAR MAPA"
        Me.btnMapasGuardarMapa.UseVisualStyleBackColor = True
        '
        'btnMapasCargarPlano
        '
        Me.btnMapasCargarPlano.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapasCargarPlano.Location = New System.Drawing.Point(1291, 930)
        Me.btnMapasCargarPlano.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMapasCargarPlano.Name = "btnMapasCargarPlano"
        Me.btnMapasCargarPlano.Size = New System.Drawing.Size(167, 70)
        Me.btnMapasCargarPlano.TabIndex = 24
        Me.btnMapasCargarPlano.Text = "CARGAR PLANO"
        Me.btnMapasCargarPlano.UseVisualStyleBackColor = True
        '
        'OfdSeleccionarImagen
        '
        Me.OfdSeleccionarImagen.Filter = "Archivos de mapas de bits|*.BMP|JPEG|*.JPG|PNG|"
        Me.OfdSeleccionarImagen.Title = "Seleccionar Imagen"
        '
        'btnMapasSalir
        '
        Me.btnMapasSalir.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapasSalir.Location = New System.Drawing.Point(1640, 930)
        Me.btnMapasSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMapasSalir.Name = "btnMapasSalir"
        Me.btnMapasSalir.Size = New System.Drawing.Size(167, 70)
        Me.btnMapasSalir.TabIndex = 27
        Me.btnMapasSalir.Text = "SALIR"
        Me.btnMapasSalir.UseVisualStyleBackColor = True
        '
        'lblMapasNombreM
        '
        Me.lblMapasNombreM.AutoSize = True
        Me.lblMapasNombreM.Location = New System.Drawing.Point(663, 910)
        Me.lblMapasNombreM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMapasNombreM.Name = "lblMapasNombreM"
        Me.lblMapasNombreM.Size = New System.Drawing.Size(124, 17)
        Me.lblMapasNombreM.TabIndex = 28
        Me.lblMapasNombreM.Text = "Nombre del mapa:"
        '
        'txtMapasNombreMapa
        '
        Me.txtMapasNombreMapa.Location = New System.Drawing.Point(695, 942)
        Me.txtMapasNombreMapa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMapasNombreMapa.Name = "txtMapasNombreMapa"
        Me.txtMapasNombreMapa.Size = New System.Drawing.Size(377, 22)
        Me.txtMapasNombreMapa.TabIndex = 29
        '
        'cmClickDerecho
        '
        Me.cmClickDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcionTSMEliminar})
        Me.cmClickDerecho.Name = "cmClickDerecho"
        Me.cmClickDerecho.Size = New System.Drawing.Size(174, 28)
        '
        'opcionTSMEliminar
        '
        Me.opcionTSMEliminar.Name = "opcionTSMEliminar"
        Me.opcionTSMEliminar.Size = New System.Drawing.Size(173, 24)
        Me.opcionTSMEliminar.Text = "Eliminar Icono"
        '
        'FormMapas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1844, 1019)
        Me.Controls.Add(Me.txtMapasNombreMapa)
        Me.Controls.Add(Me.lblMapasNombreM)
        Me.Controls.Add(Me.btnMapasSalir)
        Me.Controls.Add(Me.btnMapasGuardarMapa)
        Me.Controls.Add(Me.btnMapasCargarPlano)
        Me.Controls.Add(Me.tcMapasIconos)
        Me.Controls.Add(Me.pbMapasPlano)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMapas"
        Me.Text = "FormMapas"
        CType(Me.pbMapasPlano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcMapasIconos.ResumeLayout(False)
        Me.tbMapasObl.ResumeLayout(False)
        CType(Me.pbOblig4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOblig3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOblig2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOblig1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMapasProhib.ResumeLayout(False)
        CType(Me.pbProhib4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProhib3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProhib2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProhib1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMapasRiesgo.ResumeLayout(False)
        CType(Me.pbRiesgo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRiesgo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRiesgo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRiesgo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMapasInfo.ResumeLayout(False)
        CType(Me.pbInfo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMapasVeloc.ResumeLayout(False)
        CType(Me.pbVelo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVelo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVelo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVelo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmClickDerecho.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbMapasPlano As System.Windows.Forms.PictureBox
    Friend WithEvents tcMapasIconos As System.Windows.Forms.TabControl
    Friend WithEvents tbMapasObl As System.Windows.Forms.TabPage
    Friend WithEvents tbMapasProhib As System.Windows.Forms.TabPage
    Friend WithEvents tbMapasRiesgo As System.Windows.Forms.TabPage
    Friend WithEvents tbMapasInfo As System.Windows.Forms.TabPage
    Friend WithEvents tbMapasVeloc As System.Windows.Forms.TabPage
    Friend WithEvents btnMapasGuardarMapa As System.Windows.Forms.Button
    Friend WithEvents btnMapasCargarPlano As System.Windows.Forms.Button
    Friend WithEvents OfdSeleccionarImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pbOblig3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbOblig2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbOblig1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbProhib4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbProhib3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbProhib2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbProhib1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbRiesgo4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbRiesgo3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbRiesgo2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbRiesgo1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbInfo4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbInfo3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbInfo2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbInfo1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbVelo4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbVelo3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbVelo2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbVelo1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMapasSalir As System.Windows.Forms.Button
    Friend WithEvents lblMapasNombreM As System.Windows.Forms.Label
    Friend WithEvents txtMapasNombreMapa As System.Windows.Forms.TextBox
    Friend WithEvents pbOblig4 As System.Windows.Forms.PictureBox
    Friend WithEvents cmClickDerecho As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents opcionTSMEliminar As System.Windows.Forms.ToolStripMenuItem
End Class
