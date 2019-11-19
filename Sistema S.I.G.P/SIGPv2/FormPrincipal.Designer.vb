<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.menuGeneral = New System.Windows.Forms.MenuStrip()
        Me.menuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemNuevoRelevamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemPlanDeContingencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemAbrirRelevamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemAbrirReporteGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionCerrarProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionInspecciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEtapas = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionCuestionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionCalculo = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionMapa = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionInventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionFinalizarProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdministración = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionUsuariosDeSistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionPrevencionistas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolaGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionTelefonosDeInteres = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionSoporteTécnico = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuGeneral
        '
        Me.menuGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivo, Me.menuEtapas, Me.menuAdministración, Me.AyudaToolStripMenuItem})
        Me.menuGeneral.Location = New System.Drawing.Point(0, 0)
        Me.menuGeneral.Name = "menuGeneral"
        Me.menuGeneral.Size = New System.Drawing.Size(1083, 24)
        Me.menuGeneral.TabIndex = 1
        Me.menuGeneral.Text = "menuPricnipal"
        '
        'menuArchivo
        '
        Me.menuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcionNuevo, Me.opcionAbrir, Me.opcionCerrarProyecto, Me.opcionInspecciones, Me.opcionCerrarSesion, Me.opcionSalir})
        Me.menuArchivo.Name = "menuArchivo"
        Me.menuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuArchivo.Text = "Archivo"
        '
        'opcionNuevo
        '
        Me.opcionNuevo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemEmpresa, Me.itemNuevoRelevamiento, Me.itemPlanDeContingencia})
        Me.opcionNuevo.Name = "opcionNuevo"
        Me.opcionNuevo.Size = New System.Drawing.Size(156, 22)
        Me.opcionNuevo.Text = "Nuevo"
        '
        'itemEmpresa
        '
        Me.itemEmpresa.Name = "itemEmpresa"
        Me.itemEmpresa.Size = New System.Drawing.Size(187, 22)
        Me.itemEmpresa.Text = "Empresa"
        '
        'itemNuevoRelevamiento
        '
        Me.itemNuevoRelevamiento.Name = "itemNuevoRelevamiento"
        Me.itemNuevoRelevamiento.Size = New System.Drawing.Size(187, 22)
        Me.itemNuevoRelevamiento.Text = "Relevamiento"
        '
        'itemPlanDeContingencia
        '
        Me.itemPlanDeContingencia.Name = "itemPlanDeContingencia"
        Me.itemPlanDeContingencia.Size = New System.Drawing.Size(187, 22)
        Me.itemPlanDeContingencia.Text = "Plan de Contingencia"
        '
        'opcionAbrir
        '
        Me.opcionAbrir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemAbrirRelevamiento, Me.ItemAbrirReporteGeneral})
        Me.opcionAbrir.Name = "opcionAbrir"
        Me.opcionAbrir.Size = New System.Drawing.Size(156, 22)
        Me.opcionAbrir.Text = "Abrir"
        '
        'itemAbrirRelevamiento
        '
        Me.itemAbrirRelevamiento.Name = "itemAbrirRelevamiento"
        Me.itemAbrirRelevamiento.Size = New System.Drawing.Size(158, 22)
        Me.itemAbrirRelevamiento.Text = "Relevamiento"
        '
        'ItemAbrirReporteGeneral
        '
        Me.ItemAbrirReporteGeneral.Name = "ItemAbrirReporteGeneral"
        Me.ItemAbrirReporteGeneral.Size = New System.Drawing.Size(158, 22)
        Me.ItemAbrirReporteGeneral.Text = "Reporte General"
        '
        'opcionCerrarProyecto
        '
        Me.opcionCerrarProyecto.Name = "opcionCerrarProyecto"
        Me.opcionCerrarProyecto.Size = New System.Drawing.Size(156, 22)
        Me.opcionCerrarProyecto.Text = "Cerrar Proyecto"
        '
        'opcionInspecciones
        '
        Me.opcionInspecciones.Name = "opcionInspecciones"
        Me.opcionInspecciones.Size = New System.Drawing.Size(156, 22)
        Me.opcionInspecciones.Text = "Inspecciones"
        '
        'opcionCerrarSesion
        '
        Me.opcionCerrarSesion.Name = "opcionCerrarSesion"
        Me.opcionCerrarSesion.Size = New System.Drawing.Size(156, 22)
        Me.opcionCerrarSesion.Text = "Cerrar Sesion"
        '
        'opcionSalir
        '
        Me.opcionSalir.Name = "opcionSalir"
        Me.opcionSalir.Size = New System.Drawing.Size(156, 22)
        Me.opcionSalir.Text = "Salir"
        '
        'menuEtapas
        '
        Me.menuEtapas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcionCuestionario, Me.opcionCalculo, Me.opcionMapa, Me.opcionInventario, Me.opcionFinalizarProyecto})
        Me.menuEtapas.Name = "menuEtapas"
        Me.menuEtapas.Size = New System.Drawing.Size(53, 20)
        Me.menuEtapas.Text = "Etapas"
        '
        'opcionCuestionario
        '
        Me.opcionCuestionario.Name = "opcionCuestionario"
        Me.opcionCuestionario.Size = New System.Drawing.Size(167, 22)
        Me.opcionCuestionario.Text = "Cuestionario"
        '
        'opcionCalculo
        '
        Me.opcionCalculo.Name = "opcionCalculo"
        Me.opcionCalculo.Size = New System.Drawing.Size(167, 22)
        Me.opcionCalculo.Text = "Calculo"
        '
        'opcionMapa
        '
        Me.opcionMapa.Name = "opcionMapa"
        Me.opcionMapa.Size = New System.Drawing.Size(167, 22)
        Me.opcionMapa.Text = "Mapa"
        '
        'opcionInventario
        '
        Me.opcionInventario.Name = "opcionInventario"
        Me.opcionInventario.Size = New System.Drawing.Size(167, 22)
        Me.opcionInventario.Text = "Inventario"
        '
        'opcionFinalizarProyecto
        '
        Me.opcionFinalizarProyecto.Name = "opcionFinalizarProyecto"
        Me.opcionFinalizarProyecto.Size = New System.Drawing.Size(167, 22)
        Me.opcionFinalizarProyecto.Text = "Finalizar Proyecto"
        '
        'menuAdministración
        '
        Me.menuAdministración.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcionUsuariosDeSistema, Me.opcionPrevencionistas, Me.ConsolaGeneralToolStripMenuItem})
        Me.menuAdministración.Name = "menuAdministración"
        Me.menuAdministración.Size = New System.Drawing.Size(100, 20)
        Me.menuAdministración.Text = "Administración"
        '
        'opcionUsuariosDeSistema
        '
        Me.opcionUsuariosDeSistema.Name = "opcionUsuariosDeSistema"
        Me.opcionUsuariosDeSistema.Size = New System.Drawing.Size(179, 22)
        Me.opcionUsuariosDeSistema.Text = "Usuarios de Sistema"
        '
        'opcionPrevencionistas
        '
        Me.opcionPrevencionistas.Name = "opcionPrevencionistas"
        Me.opcionPrevencionistas.Size = New System.Drawing.Size(179, 22)
        Me.opcionPrevencionistas.Text = "Prevencionistas"
        '
        'ConsolaGeneralToolStripMenuItem
        '
        Me.ConsolaGeneralToolStripMenuItem.Name = "ConsolaGeneralToolStripMenuItem"
        Me.ConsolaGeneralToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ConsolaGeneralToolStripMenuItem.Text = "Consola General"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem, Me.opcionTelefonosDeInteres, Me.opcionSoporteTécnico, Me.opcionAcercaDe})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'opcionTelefonosDeInteres
        '
        Me.opcionTelefonosDeInteres.Name = "opcionTelefonosDeInteres"
        Me.opcionTelefonosDeInteres.Size = New System.Drawing.Size(179, 22)
        Me.opcionTelefonosDeInteres.Text = "Telefonos de interes"
        '
        'opcionSoporteTécnico
        '
        Me.opcionSoporteTécnico.Name = "opcionSoporteTécnico"
        Me.opcionSoporteTécnico.Size = New System.Drawing.Size(179, 22)
        Me.opcionSoporteTécnico.Text = "Soporte técnico"
        '
        'opcionAcercaDe
        '
        Me.opcionAcercaDe.Name = "opcionAcercaDe"
        Me.opcionAcercaDe.Size = New System.Drawing.Size(179, 22)
        Me.opcionAcercaDe.Text = "Acerca de"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1083, 638)
        Me.Controls.Add(Me.menuGeneral)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.Text = "S.I.G.P."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuGeneral.ResumeLayout(False)
        Me.menuGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuGeneral As System.Windows.Forms.MenuStrip
    Friend WithEvents menuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemEmpresa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemNuevoRelevamiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemAbrirRelevamiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionCerrarProyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEtapas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionCuestionario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionInventario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionCalculo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionMapa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAdministración As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionUsuariosDeSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionTelefonosDeInteres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionSoporteTécnico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionCerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionPrevencionistas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionInspecciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemPlanDeContingencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsolaGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemAbrirReporteGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcionFinalizarProyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
