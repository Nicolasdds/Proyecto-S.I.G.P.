Imports System.Data.Odbc
Public Class FormPrincipal

    Private Sub FormPrincipal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        opcionCerrarSesion.Text = "Cerrar Sesion (" + usuario + ")"
    End Sub

    Private Sub FormPrincipal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        conexion = Nothing
        FormLogin.Close()
    End Sub

    Private Sub FormPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLogin.Show()
        Me.Hide()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormularioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemEmpresa.Click
        FormEmpresa.Show()
        FormEmpresa.MdiParent = Me
    End Sub

    Private Sub DatosEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemNuevoRelevamiento.Click
        FormNuevoRelevamiento.Show()
        FormNuevoRelevamiento.MdiParent = Me
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionSalir.Click
        MsgBox("Se va a cerrar el programa. Esta seguro?")
        Me.Close()
    End Sub

    Private Sub CarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionCuestionario.Click
        If RelevamientoActualId = "" Then
            MsgBox("Debe abrir un relevamiento primero.")
        Else
            FormCuestionarios.Show()
            FormCuestionarios.MdiParent = Me
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionInventario.Click
        If RelevamientoActualId = "" Then
            MsgBox("Debe abrir un relevamiento primero.")
        Else
            FormInventario.Show()
            FormInventario.MdiParent = Me
        End If

    End Sub

    Private Sub CalculoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionCalculo.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        If RelevamientoActualId = "" Then
            MsgBox("Debe abrir un relevamiento primero.")
        Else
            sql = "SELECT id_cuestionario, nom_cuestionario as cuestionario, pers_totales as personas_totales, pers_afec as personas_afectadas, fecha_creado as fecha FROM cuestionario where id_relev=" & RelevamientoActualId
            Dim da As New OdbcDataAdapter(sql, conexion)
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                MsgBox("El relevamiento tiene cuestionarios.")
                da.Fill(datasetCuestionario)
                FormCalculos.Show()
                FormCalculos.MdiParent = Me
                dr.Close()
            Else
                MsgBox("El relevamiento no tiene cuestionarios ingresados.")
                dr.Close()
            End If
        End If
    End Sub

    Private Sub opcionMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionMapa.Click
            If RelevamientoActualId = "" Then
                MsgBox("Debe abrir un relevamiento primero.")
            Else
            FormBuscarMapa.Show()
            FormBuscarMapa.MdiParent = Me
            End If
    End Sub

    Private Sub PlanDeRiesgoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RelevamientoActualId = "" Then
            MsgBox("Debe abrir un relevamiento primero.")
        Else
            FormPlanDeContingencia.Show()
            FormPlanDeContingencia.MdiParent = Me
        End If

    End Sub

    Private Sub CuestionariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormInspecciones.Show()
        FormInspecciones.MdiParent = Me
    End Sub

    Private Sub VisitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormNuevoTrabajador.Show()
        FormNuevoTrabajador.MdiParent = Me
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionUsuariosDeSistema.Click
        FormUsuarios.Show()
        FormUsuarios.MdiParent = Me
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionAcercaDe.Click
        FormNavegador.Show()
        FormNavegador.MdiParent = Me
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionCerrarSesion.Click
        cerrar_ventanas()
        Me.Text = "S.I.G.P."
        Desconectar()
        opcionCerrarSesion.Text = "Cerrar Sesion"
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub itemAbrirRelevamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemAbrirRelevamiento.Click
        FormAbrirRelevamiento.Show()
        FormAbrirRelevamiento.MdiParent = Me
    End Sub

    Private Sub ItemCerrarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub opcionPrevencionistas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionPrevencionistas.Click
        FormGestionPrevencionistas.Show()
        FormGestionPrevencionistas.MdiParent = Me
    End Sub

    Private Sub opcionInspecciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionInspecciones.Click
        FormInspecciones.Show()
        FormInspecciones.MdiParent = Me
    End Sub
    Private Sub itemPlanDeContingencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemPlanDeContingencia.Click
        If RelevamientoActualId = "" Then
            MsgBox("Debe abrir un relevamiento primero!")
        Else
            FormPlanDeContingencia.Show()
            FormPlanDeContingencia.MdiParent = Me
        End If
    End Sub

    Private Sub IdrelevToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Relevamiento: " + RelevamientoActualId + vbCr + "Rut: " + EmpresaActualRUT + vbCr + "Razon Social: " + EmpresaActualRS)
    End Sub

    Private Sub ConsolaGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolaGeneralToolStripMenuItem.Click
        FormConsolaGeneral.Show()
        FormConsolaGeneral.MdiParent = Me
    End Sub

    Private Sub ReporteGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemAbrirReporteGeneral.Click
        If RelevamientoActualId = "" Then
            MsgBox("Debe abrir un relevamiento primero!")
        Else
            FormReporteGral.Show()
            FormReporteGral.MdiParent = Me
        End If
    End Sub

    Private Sub opcionProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionCerrarProyecto.Click
        If rol_actual = 2 Then
            Dim sql As String
            Dim visitas As String
            Dim result As Integer = MessageBox.Show("Desea registar visitas en la empresa?", "Mensaje", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                visitas = InputBox("Cantidad(total): ", "Visitas a empresa.")
                If visitas = "" Then
                    MsgBox("Debe ingresar una cantidad de visitas.")
                Else
                    Try
                        sql = "UPDATE sobre SET visitas='" & visitas & "' where id_relev='" & RelevamientoActualId & "' and rut='" & EmpresaActualRUT & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                        MsgBox("La cantidad de visitas se modificaron a: " + visitas)
                    Catch ex As Exception
                        MsgBox("Hubo un error al actualizar datos.")
                    End Try
                End If
            End If
            EmpresaActualRUT = ""
            RelevamientoActualId = ""
            Me.Text = "S.I.G.P."
        End If
        cerrar_ventanas()
    End Sub

    Private Sub FinalizarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionFinalizarProyecto.Click
        Dim sql As String
        Dim fecha_actual As DateTime = DateTime.Now
        Dim fecha_fin As String
        fecha_fin = Format(fecha_actual, "MM/dd/yyyy")
        Dim result As Integer = MessageBox.Show("Está seguro de finalizar el proyecto", "Mensaje", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                sql = "UPDATE relevamiento SET fecha_fin='" & fecha_fin & "' where id_relev='" & RelevamientoActualId & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error al actualizar datos.")
            End Try
        End If
    End Sub

    Private Sub opcionSoporteTécnico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionSoporteTécnico.Click
        MsgBox("Web: www.hipercode.com" + vbCr + "Tel: 2900 2323")
    End Sub

    Private Sub opcionTelefonosDeInteres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcionTelefonosDeInteres.Click
        MsgBox("MTSS: 2915 2020" + vbCr + "Bomberos: 2400 9071" + vbCr + "Emergencias: 109")
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        FormManual.Show()
        FormManual.MdiParent = Me
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.