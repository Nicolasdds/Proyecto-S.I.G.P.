Imports System.Data.Odbc
Public Class FormAbrirRelevamiento


    Private Sub FormAbrirRelevamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        lblAbrirRelevamientoRUT.Visible = False
        lblAbrirRelevamientoRS.Visible = False
        lblAbrirRelevamientoFechas.Visible = False
        lblAbrirRelevamientoDesde.Visible = False
        lblAbrirRelevamientoID.Visible = False
        lblAbrirRelevamientoHasta.Visible = False
        txtAbrirRelevamientoRUT.Visible = False
        txtAbrirRelevamientoRS.Visible = False
        txtAbrirRelevamientoID.Visible = False
        dtpAbrirRelevamientoF1.Visible = False
        dtpAbrirRelevamientoF2.Visible = False
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirRelevamientoBuscar.Click
        Dim sql As String
        Dim ds As New DataSet
        Dim fecha_desde As String
        Dim fecha_hasta As String
        Dim eleccion As String
        eleccion = Trim(Me.cboAbrirRelevamientoCriterio.Text)
        dgvAbrirRelevamientoResultado.ReadOnly = True
        fecha_desde = Format(dtpAbrirRelevamientoF1.Value, "MM/dd/yyyy")
        fecha_hasta = Format(dtpAbrirRelevamientoF2.Value, "MM/dd/yyyy")
        If eleccion = "RUT" Then
            If txtAbrirRelevamientoRUT.Text = "" Then
                MsgBox("Debe ingresar los datos.")
            Else
                Try
                    sql = "SELECT R.id_relev as Id, E.rut AS Rut, E.razon_social AS Empresa, P.nom_pr AS nombre_tecnico, P.ape_pr AS apellido_tecnico, S.visitas, R.fecha_inicio AS Fecha_inicio, R.fecha_fin AS Fecha_fin FROM empresa AS E, prevencionista as P, relevamiento AS R, hace AS H, sobre AS S WHERE P.ci_pr=h.ci_pr and h.id_relev=r.id_relev and E.rut=S.rut AND R.id_relev=S.id_relev AND S.rut='" & txtAbrirRelevamientoRUT.Text & "'"
                dgvAbrirRelevamientoResultado.Visible = True
                Dim da As New OdbcDataAdapter(sql, conexion)
                da.Fill(ds)
                    dgvAbrirRelevamientoResultado.DataSource = ds.Tables(0)
                    Catch ex As Exception
                    MsgBox("Error.")
                    End Try
            End If
        ElseIf eleccion = "Razon Social" Then
            If txtAbrirRelevamientoRS.Text = "" Then
                MsgBox("Debe ingresar los datos.")
            Else
                Try
                    sql = "SELECT R.id_relev as Id, E.rut AS Rut, E.razon_social AS Empresa, P.nom_pr AS nombre_tecnico, P.ape_pr AS apellido_tecnico, S.visitas, R.fecha_inicio AS Fecha_inicio, R.fecha_fin AS Fecha_fin FROM empresa AS E, prevencionista as P, relevamiento AS R, hace AS H, sobre AS S WHERE P.ci_pr=h.ci_pr and h.id_relev=r.id_relev and E.rut=S.rut AND R.id_relev=S.id_relev AND E.razon_social like '%" & txtAbrirRelevamientoRS.Text & "%'"
                dgvAbrirRelevamientoResultado.Visible = True
                Dim da As New OdbcDataAdapter(sql, conexion)
                da.Fill(ds)
                dgvAbrirRelevamientoResultado.DataSource = ds.Tables(0)
                Catch ex As Exception
                    MsgBox("Error.")
                End Try
            End If
        ElseIf eleccion = "Fecha Creacion" Then
            If dtpAbrirRelevamientoF1.Text = "" Or dtpAbrirRelevamientoF2.Text = "" Then
                MsgBox("Debe ingresar los datos.")
            Else
                Try
                    sql = "SELECT R.id_relev as Id, E.rut AS Rut, E.razon_social AS Empresa, P.nom_pr AS nombre_tecnico, P.ape_pr AS apellido_tecnico, S.visitas, R.fecha_inicio AS Fecha_inicio, R.fecha_fin AS Fecha_fin FROM empresa AS E, prevencionista as P, relevamiento AS R, hace AS H, sobre AS S WHERE P.ci_pr=h.ci_pr and h.id_relev=r.id_relev and E.rut=S.rut AND R.id_relev=S.id_relev AND R.fecha_inicio between '" & fecha_desde & "' and '" & fecha_hasta & "'"
                    dgvAbrirRelevamientoResultado.Visible = True
                    Dim da As New OdbcDataAdapter(sql, conexion)
                    da.Fill(ds)
                    dgvAbrirRelevamientoResultado.DataSource = ds.Tables(0)
                Catch ex As Exception
                    MsgBox("Error.")
                End Try
            End If
        ElseIf eleccion = "Fecha Finalizacion" Then
            If dtpAbrirRelevamientoF1.Text = "" Or dtpAbrirRelevamientoF2.Text = "" Then
                MsgBox("Debe ingresar los datos.")
            Else
                Try
                    sql = "SELECT R.id_relev as Id, E.rut AS Rut, E.razon_social AS Empresa, P.nom_pr AS nombre_tecnico, P.ape_pr AS apellido_tecnico, S.visitas, R.fecha_inicio AS Fecha_inicio, R.fecha_fin AS Fecha_fin FROM empresa AS E, prevencionista as P, relevamiento AS R, hace AS H, sobre AS S WHERE P.ci_pr=h.ci_pr and h.id_relev=r.id_relev and E.rut=S.rut AND R.id_relev=S.id_relev AND R.fecha_fin between '" & fecha_desde & "' and '" & fecha_hasta & "'"
                    dgvAbrirRelevamientoResultado.Visible = True
                    Dim da As New OdbcDataAdapter(sql, conexion)
                    da.Fill(ds)
                    dgvAbrirRelevamientoResultado.DataSource = ds.Tables(0)
                Catch ex As Exception
                    MsgBox("Error.")
                End Try
            End If
        ElseIf eleccion = "ID" Then
            If txtAbrirRelevamientoID.Text = "" Then
                MsgBox("Debe ingresar los datos.")
            Else
                Try
                    sql = "SELECT R.id_relev as Id, E.rut AS Rut, E.razon_social AS Empresa, P.nom_pr AS nombre_tecnico, P.ape_pr AS apellido_tecnico, S.visitas, R.fecha_inicio AS Fecha_inicio, R.fecha_fin AS Fecha_fin FROM empresa AS E, prevencionista as P, relevamiento AS R, hace AS H, sobre AS S WHERE P.ci_pr=h.ci_pr and h.id_relev=r.id_relev and E.rut=S.rut AND R.id_relev=S.id_relev AND S.id_relev='" & txtAbrirRelevamientoID.Text & "'"
                    dgvAbrirRelevamientoResultado.Visible = True
                    Dim da As New OdbcDataAdapter(sql, conexion)
                    da.Fill(ds)
                    dgvAbrirRelevamientoResultado.DataSource = ds.Tables(0)
                Catch ex As Exception
                    MsgBox("Error.")
                End Try
            End If
        Else
            MsgBox("No tiene ninguna opcion seleccionada")
        End If
    End Sub

    Private Sub cboAbrirRelevamientoCriterio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAbrirRelevamientoCriterio.TextChanged
        Dim eleccion As String
        eleccion = Trim(Me.cboAbrirRelevamientoCriterio.Text)
        If eleccion = "RUT" Then
            lblAbrirRelevamientoRUT.Visible = True
            lblAbrirRelevamientoRS.Visible = False
            lblAbrirRelevamientoFechas.Visible = False
            lblAbrirRelevamientoDesde.Visible = False
            lblAbrirRelevamientoHasta.Visible = False
            lblAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoRUT.Visible = True
            txtAbrirRelevamientoRS.Visible = False
            dtpAbrirRelevamientoF1.Visible = False
            dtpAbrirRelevamientoF2.Visible = False
        ElseIf eleccion = "Razon Social" Then
            lblAbrirRelevamientoRUT.Visible = False
            lblAbrirRelevamientoRS.Visible = True
            lblAbrirRelevamientoFechas.Visible = False
            lblAbrirRelevamientoDesde.Visible = False
            lblAbrirRelevamientoHasta.Visible = False
            lblAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoRUT.Visible = False
            txtAbrirRelevamientoRS.Visible = True
            dtpAbrirRelevamientoF1.Visible = False
            dtpAbrirRelevamientoF2.Visible = False
        ElseIf eleccion = "Fecha Creacion" Then
            lblAbrirRelevamientoRUT.Visible = False
            lblAbrirRelevamientoRS.Visible = False
            lblAbrirRelevamientoFechas.Visible = True
            lblAbrirRelevamientoDesde.Visible = True
            lblAbrirRelevamientoHasta.Visible = True
            lblAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoRUT.Visible = False
            txtAbrirRelevamientoRS.Visible = False
            dtpAbrirRelevamientoF1.Visible = True
            dtpAbrirRelevamientoF2.Visible = True
        ElseIf eleccion = "Fecha Finalizacion" Then
            lblAbrirRelevamientoRUT.Visible = False
            lblAbrirRelevamientoRS.Visible = False
            lblAbrirRelevamientoFechas.Visible = True
            lblAbrirRelevamientoDesde.Visible = True
            lblAbrirRelevamientoHasta.Visible = True
            lblAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoID.Visible = False
            txtAbrirRelevamientoRUT.Visible = False
            txtAbrirRelevamientoRS.Visible = False
            dtpAbrirRelevamientoF1.Visible = True
            dtpAbrirRelevamientoF2.Visible = True
        ElseIf eleccion = "ID" Then
            lblAbrirRelevamientoRUT.Visible = False
            lblAbrirRelevamientoRS.Visible = False
            lblAbrirRelevamientoFechas.Visible = False
            lblAbrirRelevamientoDesde.Visible = False
            lblAbrirRelevamientoHasta.Visible = False
            lblAbrirRelevamientoID.Visible = True
            txtAbrirRelevamientoID.Visible = True
            txtAbrirRelevamientoRUT.Visible = False
            txtAbrirRelevamientoRS.Visible = False
            dtpAbrirRelevamientoF1.Visible = False
            dtpAbrirRelevamientoF2.Visible = False
        End If
    End Sub

    Private Sub btnAbrirRelevamientoLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirRelevamientoLimpiar.Click
        'Label
        lblAbrirRelevamientoRUT.Visible = False
        lblAbrirRelevamientoRS.Visible = False
        lblAbrirRelevamientoFechas.Visible = False
        lblAbrirRelevamientoDesde.Visible = False
        lblAbrirRelevamientoHasta.Visible = False
        'TextBox
        txtAbrirRelevamientoRUT.Visible = False
        txtAbrirRelevamientoRS.Visible = False
        txtAbrirRelevamientoRS.Clear()
        txtAbrirRelevamientoRUT.Clear()
        'DateTimePicker
        dtpAbrirRelevamientoF1.Visible = False
        dtpAbrirRelevamientoF2.Visible = False
        'ComboBox
        cboAbrirRelevamientoCriterio.Text = ""
        'DataGridView
        dgvAbrirRelevamientoResultado.DataSource = Nothing
        dgvAbrirRelevamientoResultado.Visible = False
    End Sub

    Private Sub dgvAbrirRelevamientoResultado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAbrirRelevamientoResultado.CellDoubleClick
        Dim empresa As String
        If e.RowIndex > -1 Then
            empresa = (dgvAbrirRelevamientoResultado("empresa", dgvAbrirRelevamientoResultado.CurrentRow.Index).Value.ToString())
            EmpresaActualRUT = (dgvAbrirRelevamientoResultado("rut", dgvAbrirRelevamientoResultado.CurrentRow.Index).Value.ToString())
            RelevamientoActualId = (dgvAbrirRelevamientoResultado("id", dgvAbrirRelevamientoResultado.CurrentRow.Index).Value.ToString())
            NombrePrevencionista = (dgvAbrirRelevamientoResultado("nombre_tecnico", dgvAbrirRelevamientoResultado.CurrentRow.Index).Value.ToString())
            VisitasActuales = (dgvAbrirRelevamientoResultado("visitas", dgvAbrirRelevamientoResultado.CurrentRow.Index).Value.ToString())
            EmpresaActualRS = empresa
            FormPrincipal.Text = nombre_sistema + " - " + EmpresaActualRS
            Me.Close()
        End If
    End Sub

    Private Sub btnAbrirRelevamientoCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirRelevamientoSalir.Click
        Me.Close()
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.