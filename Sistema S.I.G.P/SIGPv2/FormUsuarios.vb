Imports System.Data.Odbc
Public Class FormUsuarios

    Private Sub FormUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        'Label
        lblUsuarioAlias.Visible = False
        lblUsuarioRolNU.Visible = False
        lblUsuarioRolNR.Visible = False
        lblUsuarioIDNR.Visible = False
        'TextoBox
        txtUsuariosAlias.Visible = False
        txtUsuariosRolNR.Visible = False
        txtUsuariosIDNR.Visible = False
        'ComboBox
        cboUsuariosRol.Visible = False
        'Button
        btnUsuariosGuardar.Enabled = False
        btnUsuariosEliminar.Enabled = False
        btnUsuariosAceptarNU.Visible = False
        btnUsuariosAceptarNR.Visible = False
        rowID = ""
    End Sub

    Private Sub users()
        Dim sql As String
        Dim ds As New DataSet
        sql = "SELECT * from usuario_rol"
        Dim da As New OdbcDataAdapter(sql, conexion)
        da.Fill(ds)
        dgvUsuarios.DataSource = ds.Tables(0)
        btnUsuariosGuardar.Enabled = True
        btnUsuariosEliminar.Enabled = True
    End Sub

    Private Sub roles()
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT * from roles"
            Dim da As New OdbcDataAdapter(sql, conexion)
            da.Fill(ds)
            dgvUsuarios.DataSource = ds.Tables(0)
            btnUsuariosGuardar.Enabled = True
            btnUsuariosEliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error.")
        End Try
    End Sub

    Private Sub btnUsuariosSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosSalir.Click
        Me.Close()
    End Sub

    Private Sub btnUsuariosBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosBuscar.Click
        If rbUsuariosNombres.Checked = False And rbUsuariosRoles.Checked = False Then
                MsgBox("Debe seleccionar una opcion")
        ElseIf rbUsuariosNombres.Checked = True Then
            users()
        ElseIf rbUsuariosRoles.Checked = True Then
            roles()
        End If
    End Sub

    Private Sub btnUsuariosNuevoUSR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosNuevoUSR.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        'Label
        lblUsuarioAlias.Visible = True
        lblUsuarioRolNU.Visible = True
        lblUsuarioRolNR.Visible = False
        lblUsuarioIDNR.Visible = False
        'TextoBox
        txtUsuariosAlias.Visible = True
        txtUsuariosRolNR.Visible = False
        txtUsuariosIDNR.Visible = False
        'ComboBox
        cboUsuariosRol.Visible = True
        'Button
        btnUsuariosAceptarNU.Visible = True
        btnUsuariosAceptarNR.Visible = False
        Try
            sql = "SELECT id FROM roles"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            While dr.Read
                cboUsuariosRol.Items.Add(dr.Item("id"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al obtener roles")
        End Try
    End Sub

    Private Sub btnUsuariosAceptarNU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosAceptarNU.Click
        Dim sql As String
        Dim alias_user As String
        Dim rol As Integer
        If txtUsuariosAlias.Text = "" Or cboUsuariosRol.Text = "" Then
            MsgBox("Verifique los datos.")
        Else
            Try
                alias_user = txtUsuariosAlias.Text
                rol = cboUsuariosRol.Text
                sql = "INSERT INTO usuario_rol VALUES('" & alias_user & "'," & rol & ")"
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
                MsgBox("Ingresado")
                users()
                'Label
                lblUsuarioAlias.Visible = False
                lblUsuarioRolNU.Visible = False
                'TextoBox
                txtUsuariosAlias.Visible = False
                'ComboBox
                cboUsuariosRol.Visible = False
                'Button
                btnUsuariosAceptarNU.Visible = False
            Catch ex As Exception
                MsgBox("Error al ingresar datos.")
            End Try
        End If
    End Sub

    Private Sub btnUsuariosNuevoROL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosNuevoROL.Click
        'Label
        lblUsuarioRolNR.Visible = True
        lblUsuarioIDNR.Visible = True
        lblUsuarioAlias.Visible = False
        lblUsuarioRolNU.Visible = False
        'TextoBox
        txtUsuariosRolNR.Visible = True
        txtUsuariosIDNR.Visible = True
        txtUsuariosAlias.Visible = False
        'Button
        btnUsuariosAceptarNR.Visible = True
        btnUsuariosAceptarNU.Visible = False
        'ComboBox
        cboUsuariosRol.Visible = False
    End Sub

    Private Sub btnUsuariosAceptarNR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosAceptarNR.Click
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        Dim nombre_rol As String
        Dim id_rol As Integer
        If txtUsuariosRolNR.Text = "" Or txtUsuariosIDNR.Text = "" Then
            MsgBox("Verifique los datos.")
        Else
            nombre_rol = txtUsuariosRolNR.Text
            id_rol = txtUsuariosIDNR.Text
            Try
                sql = "SELECT * FROM roles WHERE rol='" & nombre_rol & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    MsgBox("El nombre del rol ya existe.")
                    dr.Close()
                Else
                    dr.Close()
                    Try
                        sql = "SELECT * FROM roles WHERE id='" & id_rol & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            MsgBox("El id del rol ya existe.")
                            dr.Close()
                        Else
                            dr.Close()
                            Try
                                sql = "INSERT INTO roles VALUES(" & id_rol & ",'" & nombre_rol & "')"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("Ingresado")
                                roles()
                                'Label
                                lblUsuarioRolNR.Visible = False
                                lblUsuarioIDNR.Visible = False
                                'TextoBox
                                txtUsuariosRolNR.Visible = False
                                txtUsuariosIDNR.Visible = False
                                'Button
                                btnUsuariosAceptarNR.Visible = False
                            Catch ex As Exception
                                MsgBox("Error al ingresar datos.")
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error al obtener id del rol")
                    End Try
                End If
            Catch es As Exception
                MsgBox("Error al obtener nombre de rol.")
            End Try
        End If
    End Sub

    Private Sub btnUsuariosEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosEliminar.Click
        Dim tabla As String
        If rbUsuariosRoles.Checked = True Then
            tabla = "roles"
            MsgBox(tabla + vbCr + rowTitle + vbCr + rowID)
            deleteInt(tabla, rowTitle, rowID)
            roles()
        Else
            tabla = "usuario_rol"
            MsgBox(tabla + vbCr + rowTitle + vbCr + rowID)
            deleteStr(tabla, rowTitle, rowID)
            users()
        End If
    End Sub

    'FUNCIONES PARA DELETE
    Private Sub deleteStr(ByVal tabla As String, ByVal id As String, ByVal valor As String)
        Dim sql As String
        Try
            sql = "DELETE FROM " & tabla & " where " & id & "='" & valor & "'"
            comando.Connection = conexion
            comando.CommandText = sql
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al actualizar datos.")
        End Try
    End Sub

    Private Sub deleteInt(ByVal tabla As String, ByVal id As String, ByVal valor As Integer)
        Dim sql As String
        Try
            sql = "DELETE FROM " & tabla & " where " & id & "=" & valor
            comando.Connection = conexion
            comando.CommandText = sql
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al actualizar datos.")
        End Try
    End Sub

    Private Sub dgvUsuarios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        rowID = (dgvUsuarios(0, dgvUsuarios.CurrentRow.Index).Value.ToString())
        rowTitle = dgvUsuarios.Columns(0).HeaderText
    End Sub

    Private Sub rbUsuariosNombres_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbUsuariosNombres.CheckedChanged
        dgvUsuarios.DataSource = Nothing
        btnUsuariosGuardar.Enabled = False
        btnUsuariosEliminar.Enabled = False
    End Sub

    Private Sub btnUsuariosGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuariosGuardar.Click
        Dim sql As String
        Dim tabla As String
        If rbUsuariosRoles.Checked = True Then
            tabla = "roles"
            row1 = (dgvUsuarios("id", dgvUsuarios.CurrentRow.Index).Value.ToString())
            row2 = (dgvUsuarios("rol", dgvUsuarios.CurrentRow.Index).Value.ToString())
            Try
                sql = "UPDATE roles SET id=" & row1 & ",rol='" & row2 & "' where id=" & rowID
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error al actualizar datos.")
            End Try
            roles()
        Else
            tabla = "usuario_rol"
            row1 = (dgvUsuarios("usuario", dgvUsuarios.CurrentRow.Index).Value.ToString())
            row2 = (dgvUsuarios("rol", dgvUsuarios.CurrentRow.Index).Value.ToString())
            Try
                sql = "UPDATE usuario_rol SET usuario='" & row1 & "',rol=" & row2 & " where usuario='" & rowID & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error al actualizar datos.")
            End Try
            users()
        End If
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.