Imports System.Data.Odbc
Public Class FormGestionPrevencionistas

    Private Sub FormGestionPrevencionistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        'Labels   
        lblGestionPrevencionistasAviso.Text = ""
        lblGestionPrevencionistaContratos.Visible = False
        'TextBox
        txtGestionPrevencionistasNombre.Enabled = False
        txtGestionPrevencionistasApellido.Enabled = False
        txtGestionPrevencionistasTelefono.Enabled = False
        txtGestionPrevencionistasDomicilio.Enabled = False
        'Buttons
        btnGestionPrevencionistasGuardar.Enabled = False
        btnGestionPrevencionistasNuevoContrato.Enabled = False
        btnGestionPrevencionistasActualizarU.Enabled = False
        'ComboBox
        cboGestionPrevencionistas.Enabled = False
        'DataGridView
        dgvGestionPrevencionistasContratos.Visible = False
        dgvGestionPrevencionistasContratos.ReadOnly = True
        'Funciones
    End Sub

    Private Sub btnGestionPrevencionistasSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPrevencionistasSalir.Click
        Me.Close()
    End Sub

    Private Sub mostrar_roles()
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        cboGestionPrevencionistas.Items.Clear()
        'cboGestionPrevencionistas.Text = ""
        Try
            sql = "select u.usuario from usuario_rol as u left join prevencionista as p on u.usuario=p.usr_pr where p.usr_pr is null and u.rol=2"
            comando.Connection = conexion
            comando.CommandText = sql
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                lblGestionPrevencionistasAviso.Text = ""
                btnGestionPrevencionistasBuscar.Enabled = True
                btnGestionPrevencionistasLimpiar.Enabled = True
                btnGestionPrevencionistasNuevoContrato.Enabled = True
                btnGestionPrevencionistasActualizarU.Enabled = True
                txtGestionPrevencionistasCi.Enabled = True
                While dr.Read
                    cboGestionPrevencionistas.Items.Add(dr.Item("usuario"))
                End While
            Else
                lblGestionPrevencionistasAviso.Text = "No quedan mas nombres de usuarios disponibles, debe gestionarlos en la seccion de usuarios.!"
                btnGestionPrevencionistasBuscar.Enabled = False
                btnGestionPrevencionistasLimpiar.Enabled = False
                btnGestionPrevencionistasNuevoContrato.Enabled = False
                btnGestionPrevencionistasActualizarU.Enabled = False
                txtGestionPrevencionistasCi.Enabled = False
                cboGestionPrevencionistas.Text = ""
                cboGestionPrevencionistas.Items.Clear()
                cboGestionPrevencionistas.Enabled = False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al obtener usuarios")
        End Try
        dr.Close()
    End Sub

    Private Sub btnGestionPrevencionistasBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPrevencionistasBuscar.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Dim ds As New DataSet
        If txtGestionPrevencionistasCi.Text = "" Then
            MsgBox("Debe ingresar los datos.")
        Else
            Try
                sql = "SELECT * FROM prevencionista WHERE ci_pr='" & txtGestionPrevencionistasCi.Text & "'"
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    MsgBox("El prevencionista existe.")
                    'TextBox
                    txtGestionPrevencionistasNombre.Enabled = False
                    txtGestionPrevencionistasApellido.Enabled = False
                    txtGestionPrevencionistasTelefono.Enabled = False
                    txtGestionPrevencionistasDomicilio.Enabled = False
                    cboGestionPrevencionistas.Enabled = True
                    'Buttons
                    btnGestionPrevencionistasNuevoContrato.Enabled = True
                    btnGestionPrevencionistasActualizarU.Enabled = True
                    'DB
                    txtGestionPrevencionistasNombre.Text = dr("nom_pr")
                    txtGestionPrevencionistasApellido.Text = dr("ape_pr")
                    txtGestionPrevencionistasTelefono.Text = dr("tel_pr")
                    txtGestionPrevencionistasDomicilio.Text = dr("dom_pr")
                    dr.Close()
                    Try
                        sql = "SELECT usr_pr FROM prevencionista WHERE ci_pr='" & txtGestionPrevencionistasCi.Text & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            If dr("usr_pr") Is DBNull.Value Then
                                lblGestionPrevencionistasAviso.Text = "El prevencionista aun no tiene un nombre de usuario vinculado!"
                                dr.Close()
                            Else
                                cboGestionPrevencionistas.Text = dr("usr_pr")
                                dr.Close()
                            End If
                            dr.Close()
                        End If
                        dr.Close()
                    Catch ex As Exception
                        MsgBox("Error el obtener el nombre de usuario del prevencionista.")
                    End Try
                    dr.Close()
                    sql = "SELECT E.razon_social AS empresas, C.fecha_contrato AS fecha_contrato, C.fecha_de_baja AS fecha_baja FROM empresa AS E, contrata AS C, prevencionista AS P WHERE E.rut=C.rut AND P.ci_pr=C.ci_pr AND P.ci_pr='" & txtGestionPrevencionistasCi.Text & "'"
                    Dim da As New OdbcDataAdapter(sql, conexion)
                    comando.Connection = conexion
                    comando.CommandText = sql
                    dr = comando.ExecuteReader()
                    If dr.HasRows Then
                        lblGestionPrevencionistaContratos.Visible = True
                        dgvGestionPrevencionistasContratos.Visible = True
                        da.Fill(ds)
                        dgvGestionPrevencionistasContratos.DataSource = ds.Tables(0)
                        dr.Close()
                    Else
                        MsgBox("El prevencionista no tiene contratos actualmente.")
                        dr.Close()
                    End If
                    dr.Close()
                Else
                    dr.Close()
                    Dim result As Integer = MessageBox.Show("El prevencionista no existe, desea ingresarlo?", "Mensaje", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        'TextBox
                        txtGestionPrevencionistasNombre.Enabled = True
                        txtGestionPrevencionistasNombre.Clear()
                        txtGestionPrevencionistasApellido.Enabled = True
                        txtGestionPrevencionistasApellido.Clear()
                        txtGestionPrevencionistasTelefono.Enabled = True
                        txtGestionPrevencionistasTelefono.Clear()
                        txtGestionPrevencionistasDomicilio.Enabled = True
                        txtGestionPrevencionistasDomicilio.Clear()
                        'Buttons
                        btnGestionPrevencionistasGuardar.Enabled = True
                        'ComboBox
                        cboGestionPrevencionistas.Enabled = True
                        dr.Close()
                    Else
                        dr.Close()
                    End If
                    dr.Close()
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox("Error.")
            End Try
        End If
        dr.Close()
    End Sub

    Private Sub btnGestionPrevencionistasGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPrevencionistasGuardar.Click
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        Dim alias_user
        If txtGestionPrevencionistasCi.Text = "" Or cboGestionPrevencionistas.Text = "" Then
            MsgBox("Verifique todos los datos.")
        Else
            alias_user = cboGestionPrevencionistas.Text
            Try
                sql = "INSERT INTO prevencionista VALUES('" & txtGestionPrevencionistasCi.Text & "','" & txtGestionPrevencionistasNombre.Text & "','" & txtGestionPrevencionistasApellido.Text & "','" & txtGestionPrevencionistasTelefono.Text & "','" & txtGestionPrevencionistasDomicilio.Text & "','" & alias_user & "')"
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
                MsgBox("Prevencionista Ingresado.")
                'TextBox
                txtGestionPrevencionistasNombre.Enabled = False
                txtGestionPrevencionistasApellido.Enabled = False
                txtGestionPrevencionistasTelefono.Enabled = False
                txtGestionPrevencionistasDomicilio.Enabled = False
                'Buttons
                btnGestionPrevencionistasNuevoContrato.Enabled = True
                btnGestionPrevencionistasGuardar.Enabled = False
                btnGestionPrevencionistasActualizarU.Enabled = True
            Catch ex As Exception
                MsgBox("Error al ingresar el nuevo prevencionista.")
                dr.Close()
            End Try
        End If
    End Sub

    Private Sub btnGestionPrevencionistasLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPrevencionistasLimpiar.Click
        'Label
        lblGestionPrevencionistaContratos.Visible = False
        'TextBox
        txtGestionPrevencionistasCi.Clear()
        txtGestionPrevencionistasNombre.Clear()
        txtGestionPrevencionistasApellido.Clear()
        txtGestionPrevencionistasTelefono.Clear()
        txtGestionPrevencionistasDomicilio.Clear()
        'Button
        btnGestionPrevencionistasNuevoContrato.Enabled = False
        btnGestionPrevencionistasGuardar.Enabled = False
        'DataGridView
        dgvGestionPrevencionistasContratos.Visible = False
    End Sub

    Private Sub btnGestionPrevencionistasNuevoContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPrevencionistasNuevoContrato.Click
        If txtGestionPrevencionistasCi.Text = "" Then
            MsgBox("Debe ingresar la CI.")
        Else
            CiPrevencionista = txtGestionPrevencionistasCi.Text
            FormNuevoContrato.Show()
            FormNuevoContrato.MdiParent = FormPrincipal
            btnGestionPrevencionistasNuevoContrato.Enabled = False

        End If
    End Sub

    Private Sub btnGestionPrevencionistasAsignarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Dim forever As Boolean
        Do
            UsuarioPrevencionista = InputBox("Nuevo nombre: ", "Usuarios de Sistema")
            If UsuarioPrevencionista = "" Then
                MsgBox("Debe ingresar un nombre de usuario.")
            Else
                If txtGestionPrevencionistasCi.Text = "" Then
                    MsgBox("Debe tener un Prevencionista seleccionado.")
                Else
                    Try
                        sql = "SELECT * FROM prevencionista WHERE usr_pr='" & UsuarioPrevencionista & "'"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            MsgBox("El nombre de usuario: " + UsuarioPrevencionista + " ya existe.")
                            dr.Close()
                        Else
                            Try
                                dr.Close()
                                sql = "UPDATE prevencionista SET usr_pr='" & UsuarioPrevencionista & "' where ci_pr='" & txtGestionPrevencionistasCi.Text & "'"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                MsgBox("El usuario del Prevencionista ha sido actualizado a: " + UsuarioPrevencionista)
                                lblGestionPrevencionistasAviso.Text = ""
                                dr.Close()
                                Exit Do
                            Catch ex As Exception
                                MsgBox("Hubo un error al intentar asignarle un usuario al Prevencionista.")
                                dr.Close()
                            End Try
                            dr.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Error al verificar si el nombre de usuario ya existe.")
                        dr.Close()
                    End Try
                End If
            End If
        Loop Until forever
    End Sub

    Private Sub btnGestionPrevencionistasGU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPrevencionistasGU.Click
        FormUsuarios.Show()
        FormUsuarios.MdiParent = FormPrincipal
    End Sub

    Private Sub btnGestionPrevencionistasActualizarU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionPrevencionistasActualizarU.Click
        Dim sql As String
        Dim alias_user As String
        alias_user = cboGestionPrevencionistas.Text
        If txtGestionPrevencionistasNombre.Enabled = False Then
            Try
                sql = "UPDATE prevencionista SET usr_pr='" & alias_user & "' where ci_pr=" & txtGestionPrevencionistasCi.Text
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
                MsgBox("Datos actualizados!")
            Catch ex As Exception
                MsgBox("Error al actualizar datos.")
            End Try
        Else
            MsgBox("Debe ingresar el prevencionista primero.")
        End If
        
    End Sub

    Private Sub FormGestionPrevencionistas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        mostrar_roles()
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.