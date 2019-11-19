Imports System.Data.Odbc
Public Class FormInventario

    Private Sub FormInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        'DataGrid
        dgvInventario.Visible = False

    End Sub

    Private Sub btnInventarioGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventarioGuardar.Click
        If txtInventarioNombre.Text = "" Or txtInventarioCantidad.Text = "" Or txtInventarioTipo.Text = "" Or cboInventarioEstado.Text = "" Then
            MsgBox("Debe ingresar todos los datos.")
        Else
            Dim sql As String
            Dim estado As String
            estado = Trim(Me.cboInventarioEstado.Text)
            Try
                sql = "INSERT INTO inventario VALUES(0,'" & txtInventarioNombre.Text & "','" & txtInventarioTipo.Text & "'," & txtInventarioCantidad.Text & ",'" & estado & "'," & RelevamientoActualId & ")"
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
                MsgBox("Datos ingresados en inventario.")
                txtInventarioNombre.Clear()
                txtInventarioCantidad.Clear()
                txtInventarioTipo.Clear()
                cboInventarioEstado.Text = ""
                datagrid()
            Catch ex As Exception
                MsgBox("Error al ingresar datos en inventario.")
            End Try
        End If
    End Sub
    Private Sub datagrid()
        Dim dr As Odbc.OdbcDataReader
        Dim ds As New DataSet
        Dim sql As String
        Try
            sql = "SELECT nom_obj as objeto, tipo_obj as tipo, cant_obj as cantidad, estado from inventario where id_relev=" & RelevamientoActualId
            Dim da As New OdbcDataAdapter(sql, conexion)
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                MsgBox("El relevamietno tiene datos en inventario.")
                da.Fill(ds)
                dgvInventario.DataSource = ds.Tables(0)
                dgvInventario.Visible = True
                dgvInventario.ReadOnly = True
                dr.Close()
            Else
                MsgBox("La empresa no tiene inspecciones")
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error.")
        End Try
    End Sub

    Private Sub btnInventarioSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventarioSalir.Click
        Me.Close()
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.