Imports System.Data.Odbc
Public Class FormBuscarMapa

    Private Sub FormBuscarMapa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        id_mapa = ""
        listar_mapas()
    End Sub

    Private Sub listar_mapas()
        Dim sql As String
        Dim ds As New DataSet
        dgvAbrirMapa.ReadOnly = True
        Try
            sql = "SELECT * FROM mapa where id_relev=" & RelevamientoActualId
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvAbrirMapa.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error.")
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapaSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvAbrirMapa_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAbrirMapa.CellDoubleClick
        If e.RowIndex > -1 Then
            id_mapa = (dgvAbrirMapa("id_mapa", dgvAbrirMapa.CurrentRow.Index).Value.ToString())
            Me.Close()
            FormMapas.Show()
            FormMapas.MdiParent = FormPrincipal
        End If
    End Sub

    Private Sub btnMapaNuevoMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapaNuevoMapa.Click
        Me.Close()
        FormMapas.Show()
        FormMapas.MdiParent = FormPrincipal
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.