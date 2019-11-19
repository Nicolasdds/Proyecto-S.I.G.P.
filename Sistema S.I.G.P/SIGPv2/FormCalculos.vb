Imports System.Data.Odbc
Public Class FormCalculos
    Private Sub FormCalculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        'TextBox
        txtCalculosND.Enabled = False
        txtCalculosNP.Enabled = False
        txtCalculosNC.Enabled = False
        txtCalculosNR.Enabled = False
        txtCalculosFP.Enabled = False
        txtCalculosGR.Enabled = False
        'Button
        btnCalculosNR.Enabled = False
        btnCalculosNP.Enabled = False
        btnCalculoVerTablasGP.Enabled = False
        'ComboBox
        cboCalculosNE.Enabled = False
        'DataGridView
        dgvCalculosCuestionario.Visible = True
        dgvCalculosCuestionario.ReadOnly = True
        dgvCalculosCuestionario.DataSource = datasetCuestionario.Tables(0)
        'PictureBox
        pbCalculosVC.Visible = False
        pbCalculosVE.Visible = False
    End Sub

    Private Sub dgvCalculosCuestionario_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCalculosCuestionario.CellClick
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        If e.RowIndex > -1 Then
            id_cuestionario = (dgvCalculosCuestionario("id_cuestionario", dgvCalculosCuestionario.CurrentRow.Index).Value.ToString())
            pers_afec = (dgvCalculosCuestionario("personas_afectadas", dgvCalculosCuestionario.CurrentRow.Index).Value.ToString())
            pers_totales = (dgvCalculosCuestionario("personas_totales", dgvCalculosCuestionario.CurrentRow.Index).Value.ToString())
            Try
                sql = "SELECT nivel_d FROM calculo WHERE id_cuestionario=" & id_cuestionario
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    nivel_d = dr("nivel_d")
                    txtCalculosND.Text = nivel_d
                    dr.Close()
                Else
                    MsgBox("El cuestionario no tiene nivel de deficiencia.")
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("Error al obtener nivel de deficiencia.")
            End Try
            'Calculando porcentaje de expuestos.
            Try
                sql = "SELECT (pers_afec*100)/pers_totales as porcentaje_expuestos FROM cuestionario WHERE id_cuestionario=" & id_cuestionario
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    porcentaje_expuestos = dr("porcentaje_expuestos")
                    porcentaje_exp_redondeado = CStr(Math.Round(porcentaje_expuestos))
                    dr.Close()
                    'Factor de ponderacion.
                    If porcentaje_exp_redondeado <= 20 Then
                        f_ponderacion = 1
                    ElseIf porcentaje_exp_redondeado >= 21 And porcentaje_exp_redondeado <= 40 Then
                        f_ponderacion = 2
                    ElseIf porcentaje_exp_redondeado >= 41 And porcentaje_exp_redondeado <= 60 Then
                        f_ponderacion = 3
                    ElseIf porcentaje_exp_redondeado >= 61 And porcentaje_exp_redondeado <= 80 Then
                        f_ponderacion = 4
                    ElseIf porcentaje_exp_redondeado >= 81 Then
                        f_ponderacion = 5
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error al realizar el calculo de porcentaje de personas afectadas.")
            End Try
        End If
    End Sub

    Private Sub btnCalculoVerTablas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCalculoVerTablasGP.MouseDown
        pbCalculosVC.Visible = True
        pbCalculosVE.Visible = True
    End Sub

    Private Sub btnCalculoVerTablas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCalculoVerTablasGP.MouseUp
        pbCalculosVC.Visible = False
        pbCalculosVE.Visible = False
    End Sub

    Private Sub btnCalculoSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculoSalir.Click
        dgvCalculosCuestionario.DataSource = Nothing
        datasetCuestionario.Clear()

        Me.Close()
    End Sub

    Private Sub btnCalculosNP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculosNP.Click
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        If cboCalculosNE.Text = "" Then
            MsgBox("Debe elegir un nivel de exposicion para realizar el calculo.")
        Else
            nivel_e = cboCalculosNE.Text
            Try
                sql = "UPDATE calculo SET nivel_e=" & nivel_e & " where id_cuestionario=" & id_cuestionario
                comando.Connection = conexion
                comando.CommandText = sql
                comando.ExecuteNonQuery()
                Try
                    sql = "SELECT (nivel_e*nivel_d) as nivel_p FROM calculo WHERE id_cuestionario=" & id_cuestionario
                    comando.Connection = conexion
                    comando.CommandText = sql
                    dr = comando.ExecuteReader()
                    If dr.HasRows Then
                        nivel_p = dr("nivel_p")
                        dr.Close()
                        Try
                            sql = "UPDATE calculo SET nivel_p=" & nivel_p & " where id_cuestionario=" & id_cuestionario
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                            txtCalculosNP.Text = nivel_p
                            dr.Close()
                        Catch ex As Exception
                            MsgBox("Error al actualizar nivel de probabilidad")
                        End Try
                    Else
                        MsgBox("No se podido realizar el calculo de probabilidad.")
                    End If
                Catch ex As Exception
                    MsgBox("Error al realizar el calculo del nivel de probabilidad.")
                End Try
            Catch ex As Exception
                MsgBox("Error al actualizar nivel de exposicion.")
            End Try
        End If
    End Sub

    Private Sub txtCalculosND_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCalculosND.TextChanged
        cboCalculosNE.Enabled = True
        btnCalculosNP.Enabled = True
        btnCalculoVerTablasGP.Enabled = True
    End Sub

    Private Sub txtCalculosNP_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCalculosNP.TextChanged
        txtCalculosNC.Enabled = True
        btnCalculosNR.Enabled = True
        
    End Sub

    Private Sub btnCalculosNR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculosNR.Click
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        If txtCalculosNC.Text = "" Then
            MsgBox("Debe ingresar el nivel de consecuencia")
        Else
            If IsNumeric(txtCalculosNC.Text) Then
                nivel_c = txtCalculosNC.Text
                Try
                    sql = "UPDATE calculo SET nivel_c=" & nivel_c & " where id_cuestionario=" & id_cuestionario
                    comando.Connection = conexion
                    comando.CommandText = sql
                    comando.ExecuteNonQuery()
                    Try
                        sql = "SELECT (nivel_p*nivel_c) as nivel_r FROM calculo WHERE id_cuestionario=" & id_cuestionario
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            nivel_r = dr("nivel_r")
                            dr.Close()
                            Try
                                sql = "UPDATE calculo SET nivel_r=" & nivel_r & " where id_cuestionario=" & id_cuestionario
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                txtCalculosNR.Text = nivel_r
                                If nivel_r > 1000 Then
                                    nivel_r = 1000
                                    tbCalculoGPEL.Value = nivel_r
                                Else
                                    tbCalculoGPEL.Value = nivel_r
                                End If
                            Catch ex As Exception
                                MsgBox("Error al ingresar nivel de riesgo.")
                            End Try
                        Else
                            MsgBox("No se podido realizar el calculo de riesgo")
                            dr.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Error al obtener el nivel de riesgo.")
                    End Try
                Catch ex As Exception
                    MsgBox("Error al ingresar el nivel de consecuencia.")
                End Try
            Else
                MsgBox("Debe ingresar solamente numeros.")
            End If
        End If
        Try
            sql = "UPDATE calculo SET f_ponderacion=" & f_ponderacion & " where id_cuestionario=" & id_cuestionario
            comando.Connection = conexion
            comando.CommandText = sql
            comando.ExecuteNonQuery()
            txtCalculosFP.Text = f_ponderacion
            Try
                sql = "SELECT (nivel_r*f_ponderacion) as nivel_rep FROM calculo WHERE id_cuestionario=" & id_cuestionario
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    nivel_rep = dr("nivel_rep")
                    txtCalculosGR.Text = nivel_rep
                    dr.Close()
                    Try
                        sql = "UPDATE calculo SET nivel_rep=" & nivel_rep & " where id_cuestionario=" & id_cuestionario
                        comando.Connection = conexion
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al ingresar nivel de repercusión.")
                    End Try
                    dr.Close()
                Else
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("Error al obtener el grado de repercusión.")
                dr.Close()
            End Try
        Catch ex As Exception
            MsgBox("Error al ingresar el factor de ponderacion.")
        End Try
        If nivel_rep > 5000 Then
            nivel_rep = 5000
            tbCalculoGREP.Value = nivel_rep
        Else
            tbCalculoGREP.Value = nivel_rep
        End If
        dr.Close()
    End Sub

    Private Sub btnCalculoLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculoLimpiar.Click, btnCalculoGuardar.Click
        Dim sql As String
        If nivel_r < 300 Then
            intervencion = "BAJO"
        ElseIf nivel_r >= 300 And nivel_r < 600 Then
            intervencion = "MEDIO"
        ElseIf nivel_r >= 600 Then
            intervencion = "ALTO"
        End If
        Try
            sql = "UPDATE calculo SET nivel_i='" & intervencion & "' where id_cuestionario=" & id_cuestionario
            comando.Connection = conexion
            comando.CommandText = sql
            comando.ExecuteNonQuery()
            MsgBox("Datos guardados.")
        Catch ex As Exception
            MsgBox("Error al ingresar nivel de intervencion.")
        End Try
    End Sub

    Private Sub tbCalculoGREP_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCalculoGREP.MouseUp
        tbCalculoGREP.Value = nivel_rep
    End Sub

    Private Sub tbCalculoGPEL_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCalculoGPEL.MouseUp
        tbCalculoGPEL.Value = nivel_r
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.