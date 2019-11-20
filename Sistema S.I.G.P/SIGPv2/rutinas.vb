Imports System.Data.Odbc
Module rutinas
    Public Sub permisos(ByVal usuario As String)
        Dim sql As String
        'Dim comando As New OdbcCommand
        'Menus
        FormPrincipal.menuGeneral.Enabled = False
        FormPrincipal.menuArchivo.Enabled = False
        FormPrincipal.menuEtapas.Enabled = False
        FormPrincipal.menuAdministración.Enabled = False
        'Opciones del menu
        FormPrincipal.opcionNuevo.Enabled = False
        FormPrincipal.opcionAbrir.Enabled = False
        FormPrincipal.opcionCerrarProyecto.Enabled = False
        FormPrincipal.opcionCuestionario.Enabled = False
        FormPrincipal.opcionInventario.Enabled = False
        FormPrincipal.opcionCalculo.Enabled = False
        FormPrincipal.opcionMapa.Enabled = False
        FormPrincipal.opcionInspecciones.Enabled = False
        FormPrincipal.opcionUsuariosDeSistema.Enabled = False
        FormPrincipal.opcionFinalizarProyecto.Enabled = False
        'Items de la opcion
        FormPrincipal.itemPlanDeContingencia.Enabled = False
        FormPrincipal.itemEmpresa.Enabled = False
        FormPrincipal.itemNuevoRelevamiento.Enabled = False
        FormPrincipal.itemAbrirRelevamiento.Enabled = False

        Dim dr As System.Data.Odbc.OdbcDataReader
        sql = "select rol from usuario_rol where usuario='" & usuario & "'"
        comando.Connection = conexion
        comando.CommandText = sql

        Try
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                If (dr("rol")) = 1 Then
                    'Administrador
                    rol_actual = 1
                    'Menus
                    FormPrincipal.menuGeneral.Enabled = True
                    FormPrincipal.menuArchivo.Enabled = True
                    FormPrincipal.menuEtapas.Enabled = True
                    FormPrincipal.menuAdministración.Enabled = True
                    'Opciones del menu
                    FormPrincipal.opcionNuevo.Enabled = True
                    FormPrincipal.opcionAbrir.Enabled = True
                    FormPrincipal.opcionCerrarProyecto.Enabled = True
                    FormPrincipal.opcionCuestionario.Enabled = True
                    FormPrincipal.opcionInventario.Enabled = True
                    FormPrincipal.opcionCalculo.Enabled = True
                    FormPrincipal.opcionMapa.Enabled = True
                    FormPrincipal.opcionInspecciones.Enabled = True
                    FormPrincipal.opcionUsuariosDeSistema.Enabled = True
                    FormPrincipal.opcionFinalizarProyecto.Enabled = True
                    'Items de la opcion
                    FormPrincipal.itemEmpresa.Enabled = True
                    FormPrincipal.itemNuevoRelevamiento.Enabled = True
                    FormPrincipal.itemAbrirRelevamiento.Enabled = True
                    FormPrincipal.itemPlanDeContingencia.Enabled = True
                    FormPrincipal.Show()
                    FormLogin.Hide()
                    dr.Close()
                ElseIf (dr("rol")) = 2 Then
                    'Tecnico
                    rol_actual = 2
                    'Menus
                    FormPrincipal.menuGeneral.Enabled = True
                    FormPrincipal.menuArchivo.Enabled = True
                    FormPrincipal.menuEtapas.Enabled = True
                    'Opciones del menu
                    FormPrincipal.opcionNuevo.Enabled = True
                    FormPrincipal.opcionAbrir.Enabled = True
                    FormPrincipal.opcionCerrarProyecto.Enabled = True
                    FormPrincipal.opcionCuestionario.Enabled = True
                    FormPrincipal.opcionInventario.Enabled = True
                    FormPrincipal.opcionCalculo.Enabled = True
                    FormPrincipal.opcionMapa.Enabled = True
                    FormPrincipal.opcionInspecciones.Enabled = True
                    FormPrincipal.opcionUsuariosDeSistema.Enabled = True
                    FormPrincipal.opcionFinalizarProyecto.Enabled = True
                    'Items de la opcion
                    FormPrincipal.itemEmpresa.Enabled = True
                    FormPrincipal.itemNuevoRelevamiento.Enabled = True
                    FormPrincipal.itemAbrirRelevamiento.Enabled = True
                    FormPrincipal.itemPlanDeContingencia.Enabled = True
                    FormPrincipal.Show()
                    FormLogin.Hide()
                    dr.Close()
                ElseIf (dr("rol")) = 3 Then
                    'Asistente
                    rol_actual = 3
                    'Menus
                    FormPrincipal.menuGeneral.Enabled = True
                    FormPrincipal.menuArchivo.Enabled = True
                    FormPrincipal.menuEtapas.Enabled = True
                    'Opciones del menu
                    FormPrincipal.opcionNuevo.Enabled = True
                    FormPrincipal.opcionAbrir.Enabled = True
                    FormPrincipal.opcionCerrarProyecto.Enabled = True
                    FormPrincipal.opcionInventario.Enabled = True
                    'Items de la opcion
                    FormPrincipal.itemEmpresa.Enabled = True
                    FormPrincipal.itemAbrirRelevamiento.Enabled = True
                    FormPrincipal.Show()
                    FormLogin.Hide()
                    dr.Close()
                ElseIf (dr("rol")) = 4 Then
                    'Guest
                    rol_actual = 4
                    'Menus
                    FormPrincipal.menuGeneral.Enabled = True
                    FormPrincipal.menuArchivo.Enabled = True
                    'Opciones del menu
                    FormPrincipal.opcionInspecciones.Enabled = True
                    FormPrincipal.opcionAbrir.Enabled = True
                    FormPrincipal.opcionCerrarProyecto.Enabled = True
                    'Items de la opcion
                    FormPrincipal.itemAbrirRelevamiento.Enabled = True
                    FormPrincipal.ItemAbrirReporteGeneral.Enabled = True
                    FormPrincipal.Show()
                    FormLogin.Hide()
                    dr.Close()
                Else
                    MsgBox("El Rol del usuario aun no se ha configurado en el sistema")
                    dr.Close()
                End If
                dr.Close()
            Else
                MsgBox("Error, rol no encontrado")
                dr.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error al obtener datos de la tabla usuario_rol")
            Exit Sub
        End Try
    End Sub
End Module








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.