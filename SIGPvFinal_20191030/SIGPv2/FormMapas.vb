Imports System.Data.Odbc
Public Class FormMapas
    Dim icono() As ClassIcono
    Dim c, x, y As Integer
    Dim arrastrar As Boolean = False
    Dim selection As Rectangle
    Dim imageBitmap As Bitmap

    Private Sub FormMapas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        error_caption = False
        c = 0
        ReDim icono(1000)
        pbInfo1.Image = Image.FromFile(Application.StartupPath + rutainfo1)
        pbInfo2.Image = Image.FromFile(Application.StartupPath + rutaInfo2)
        pbInfo3.Image = Image.FromFile(Application.StartupPath + rutaInfo3)
        pbOblig1.Image = Image.FromFile(Application.StartupPath + rutaOblig1)
        pbOblig2.Image = Image.FromFile(Application.StartupPath + rutaOblig2)
        pbOblig3.Image = Image.FromFile(Application.StartupPath + rutaOblig3)
        pbOblig4.Image = Image.FromFile(Application.StartupPath + rutaOblig4)
        pbProhib1.Image = Image.FromFile(Application.StartupPath + rutaProhib1)
        pbProhib2.Image = Image.FromFile(Application.StartupPath + rutaProhib2)
        pbProhib3.Image = Image.FromFile(Application.StartupPath + rutaProhib3)
        pbProhib4.Image = Image.FromFile(Application.StartupPath + rutaProhib4)
        pbRiesgo1.Image = Image.FromFile(Application.StartupPath + rutaRiesgo1)
        pbRiesgo2.Image = Image.FromFile(Application.StartupPath + rutaRiesgo2)
        pbRiesgo3.Image = Image.FromFile(Application.StartupPath + rutaRiesgo3)
        pbRiesgo4.Image = Image.FromFile(Application.StartupPath + rutaRiesgo4)
        pbVelo1.Image = Image.FromFile(Application.StartupPath + rutaVeloc1)
        pbVelo2.Image = Image.FromFile(Application.StartupPath + rutaVeloc2)
        pbVelo3.Image = Image.FromFile(Application.StartupPath + rutaVeloc3)
        pbVelo4.Image = Image.FromFile(Application.StartupPath + rutaVeloc4)
        mostrar_mapa()
    End Sub

    Private Sub mostrar_mapa()
        Dim sql As String
        Dim dr As Odbc.OdbcDataReader
        If id_mapa <> "" Then
            Try
                sql = "SELECT * FROM mapa WHERE id_mapa=" & id_mapa
                comando.Connection = conexion
                comando.CommandText = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    ruta_mapa = dr("ruta")
                    titulo_mapa = dr("titulo")
                    txtMapasNombreMapa.Text = titulo_mapa
                    pbMapasPlano.Image = Image.FromFile(ruta_mapa)
                    dr.Close()
                    Try
                        sql = "SELECT * FROM contiene WHERE id_icono in (select id_icono from contiene where id_mapa='" & id_mapa & "')"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            id_for_iconos = dr("id_icono")
                            dr.Close()
                            Try
                                sql = "SELECT count(*) as cantidad FROM contiene WHERE id_mapa='" & id_mapa & "'"
                                comando.Connection = conexion
                                comando.CommandText = sql
                                dr = comando.ExecuteReader()
                                If dr.HasRows Then
                                    cantidad_iconos = dr("cantidad")
                                    dr.Close()
                                    Dim i As Integer
                                    For i = 1 To cantidad_iconos
                                        Try
                                            sql = "SELECT * FROM contiene WHERE id_icono='" & id_for_iconos & "'"
                                            comando.Connection = conexion
                                            comando.CommandText = sql
                                            dr = comando.ExecuteReader()
                                            If dr.HasRows Then
                                                id_icono = dr("id_icono")
                                                pos_x = dr("pos_x")
                                                pos_y = dr("pos_y")
                                                dr.Close()
                                                Try
                                                    sql = "SELECT * FROM icono WHERE id_icono='" & id_for_iconos & "'"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        id_icono = dr("id_icono")
                                                        tipo_icono = dr("tipo_icono")
                                                        nombre_icono = dr("nom_icono")
                                                        ruta_nuevo_icono = dr("ruta")
                                                        dr.Close()
                                                        traerIcono()
                                                    Else
                                                        dr.Close()
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener datos de icono.")
                                                End Try
                                            Else
                                                dr.Close()
                                            End If
                                        Catch ex As Exception
                                            MsgBox("Error al obtener datos de contiene.")
                                        End Try
                                        id_for_iconos = id_for_iconos + 1
                                    Next
                                Else
                                    dr.Close()
                                End If
                            Catch ex As Exception
                                MsgBox("Error al obtener catidad de iconos.")
                            End Try
                        Else
                            dr.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Error al obtener id minimo de iconos.")
                    End Try
                Else
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("Error al obtener mapa")
            End Try
        End If
        
    End Sub

    Private Sub btnCargarplano_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapasCargarPlano.Click
        If OfdSeleccionarImagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbMapasPlano.Image = Bitmap.FromFile(OfdSeleccionarImagen.FileName)
            ruta_mapa = OfdSeleccionarImagen.FileName
        End If
    End Sub

    Private Sub btnMapasSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapasSalir.Click
        id_mapa = ""
        Me.Close()
    End Sub

    Private Sub btnMapasGuardarMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapasGuardarMapa.Click
        Dim fecha_actual As DateTime = DateTime.Now
        Dim dr As Odbc.OdbcDataReader
        Dim solo_fecha As String
        Dim sql As String
        Dim id_icono As String
        solo_fecha = Format(fecha_actual, "MM/dd/yyyy")
        If txtMapasNombreMapa.Text = "" Or pbMapasPlano.Image Is Nothing Then
            MsgBox("Verifique los datos.")
        Else
            If id_mapa <> "" Then
                Try
                    sql = "SELECT * FROM mapa WHERE id_mapa=" & id_mapa
                    comando.Connection = conexion
                    comando.CommandText = sql
                    dr = comando.ExecuteReader()
                    If dr.HasRows Then
                        dr.Close()
                        Try
                            sql = "UPDATE mapa SET titulo='" & txtMapasNombreMapa.Text & "',ruta='" & ruta_mapa & "',fecha_creado='" & solo_fecha & "' where id_relev=" & RelevamientoActualId
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Error al actualizar datos")
                            error_caption = True
                        End Try
                    Else
                        dr.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Error al verificar datos de mapa.")
                    error_caption = True
                End Try
                dr.Close()
            Else

                Try
                    sql = "INSERT INTO mapa VALUES(0,'" & txtMapasNombreMapa.Text & "','" & ruta_mapa & "','" & solo_fecha & "'," & RelevamientoActualId & ")"
                    comando.Connection = conexion
                    comando.CommandText = sql
                    comando.ExecuteNonQuery()
                    Try
                        sql = "SELECT * FROM mapa WHERE id_mapa=(select max(id_mapa) from mapa)"
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            id_mapa = dr("id_mapa")
                            dr.Close()
                        End If
                        dr.Close()
                    Catch ex As Exception
                        MsgBox("Error al obtener el ultimo id de mapa.")
                        error_caption = True
                    End Try
                Catch ex As Exception
                    MsgBox("Error al ingresar mapa.")
                    error_caption = True
                End Try
            End If
            '
            For i = 0 To c - 1
                If icono(i).eliminar = True Then
                    If icono(i).id <> "" Then
                        Try
                            sql = "DELETE contiene where id_icono=" & icono(i).id
                            comando.Connection = conexion
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()
                            Try
                                sql = "DELETE icono where id_icono=" & icono(i).id
                                comando.Connection = conexion
                                comando.CommandText = sql
                                comando.ExecuteNonQuery()
                                icono(i).id = ""
                            Catch ex As Exception
                                MsgBox("Error al eliminar icono " + icono(i).Name + " de la tabla icono.")
                                error_caption = True
                            End Try
                        Catch ex As Exception
                            MsgBox("Error al eliminar icono " + icono(i).Name + " de la tabla contiene.")
                            error_caption = True
                        End Try
                    End If
                Else
                    dr.Close()
                    pos_x = icono(i).Location.X
                    pos_y = icono(i).Location.Y
                    Try
                        sql = "SELECT * FROM contiene WHERE pos_x=" & pos_x & " and pos_y=" & pos_y
                        comando.Connection = conexion
                        comando.CommandText = sql
                        dr = comando.ExecuteReader()
                        If dr.HasRows Then
                            'Ya existe un icono en esas coordenadas y no se guarda.
                            dr.Close()
                        Else
                            dr.Close()
                            If icono(i).id <> "" Then
                                For j = 0 To c - 1
                                    id_icono = icono(j).id
                                    Try
                                        sql = "SELECT * FROM contiene WHERE id_icono=" & id_icono
                                        comando.Connection = conexion
                                        comando.CommandText = sql
                                        dr = comando.ExecuteReader()
                                        If dr.HasRows Then
                                            pos_x = dr("pos_x")
                                            pos_y = dr("pos_y")
                                            dr.Close()
                                            If icono(j).Location.X = pos_x And icono(j).Location.Y = pos_y Then
                                                'El icono mantiene sus coordenadas, por lo tanto no pasa nada con ese icono en la BD.
                                            Else
                                                'Pero si el icono ha cambiado sus coordenadas, entonces se actualizan estos datos.
                                                sql = "UPDATE contiene SET pos_x=" & icono(j).Location.X & ",pos_y=" & icono(j).Location.Y & " where id_icono=" & id_icono
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                                dr.Close()
                                            End If
                                            dr.Close()
                                        Else
                                            dr.Close()
                                        End If
                                    Catch ex As Exception
                                        MsgBox("Error al verificar id de icono para obtener sus coordenadas.")
                                        error_caption = True
                                    End Try
                                Next ' for (j)
                            Else
                                dr.Close()
                                Try
                                    sql = "INSERT INTO icono VALUES(0,'" & icono(i).tipo & "','" & icono(i).Name & "','" & icono(i).ruta & "')"
                                    comando.Connection = conexion
                                    comando.CommandText = sql
                                    comando.ExecuteNonQuery()
                                    Try
                                        sql = "SELECT * FROM icono WHERE id_icono=(select max(id_icono) from icono)"
                                        comando.Connection = conexion
                                        comando.CommandText = sql
                                        dr = comando.ExecuteReader()
                                        If dr.HasRows Then
                                            id_icono = dr("id_icono")
                                            dr.Close()
                                            Try                                      
                                                sql = "INSERT INTO contiene VALUES(" & id_icono & "," & id_mapa & "," & RelevamientoActualId & "," & pos_x & "," & pos_y & ")"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                            Catch ex As Exception
                                                MsgBox("Error al asociar icono al mapa.")
                                                error_caption = True
                                            End Try
                                        End If
                                        dr.Close()
                                    Catch ex As Exception
                                        MsgBox("Error al obtener el ultimo id de icono")
                                        error_caption = True
                                    End Try
                                Catch ex As Exception
                                    MsgBox("Error al ingresar iconos")
                                    error_caption = True
                                End Try
                            End If
                            dr.Close()
                        End If
                        dr.Close()
                    Catch ex As Exception
                        MsgBox("Error al verificar si el icono esta repetido.")
                        error_caption = True
                    End Try
                End If
                dr.Close()
            Next ' for (i)
            If error_caption = False Then
                screenshot()
                MsgBox("Datos guardados.")
            Else
                MsgBox("Datos guardados parcialmente, verifique errores.")
                error_caption = False
            End If
        End If
    End Sub

    Private Sub nuevoIcono()
        x = Me.PointToClient(Cursor.Position).X
        y = Me.PointToClient(Cursor.Position).Y
        icono(c) = New ClassIcono
        icono(c).Text = c
        icono(c).Name = nombre_icono
        icono(c).ruta = ruta_nuevo_icono
        icono(c).tipo = tipo_icono
        icono(c).AutoSize = True
        icono(c).Image = Image.FromFile(Application.StartupPath + ruta_nuevo_icono)
        icono(c).Size = New System.Drawing.Size(10, 23)
        icono(c).Visible = True
        Controls.Add(icono(c))
        icono(c).BringToFront()
        icono(c).Location = New System.Drawing.Point(x - 25, y - 25)
        AddHandler icono(c).MouseMove, AddressOf boton_MouseMove
        AddHandler icono(c).MouseDown, AddressOf boton_Mousedown
        AddHandler icono(c).MouseUp, AddressOf boton_MouseUp
        AddHandler icono(c).DoubleClick, AddressOf boton_DOUBLEClick
        c = c + 1
    End Sub

    Private Sub traerIcono()
        icono(c) = New ClassIcono
        icono(c).Text = c
        icono(c).Name = nombre_icono
        icono(c).ruta = ruta_nuevo_icono
        icono(c).id = id_icono
        icono(c).tipo = tipo_icono
        icono(c).AutoSize = True
        icono(c).Image = Image.FromFile(Application.StartupPath + ruta_nuevo_icono)
        icono(c).Size = New System.Drawing.Size(10, 23)
        icono(c).Visible = True
        Controls.Add(icono(c))
        icono(c).BringToFront()
        icono(c).Location = New System.Drawing.Point(pos_x, pos_y)
        AddHandler icono(c).MouseMove, AddressOf boton_MouseMove
        AddHandler icono(c).MouseDown, AddressOf boton_Mousedown
        AddHandler icono(c).MouseUp, AddressOf boton_MouseUp
        AddHandler icono(c).DoubleClick, AddressOf boton_DOUBLEClick
        c = c + 1
    End Sub

    Private Sub boton_DOUBLEClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        temporal = sender.text
        Controls.Remove(icono(temporal)) 'Este lo desaparece pero no lo destruye
        sender.eliminar = True
    End Sub

    Private Sub boton_Mousedown(ByVal sender As Object, ByVal e As EventArgs)
        arrastrar = Not arrastrar
    End Sub

    Private Sub boton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If arrastrar Then
            x = Me.PointToClient(Cursor.Position).X
            y = Me.PointToClient(Cursor.Position).Y
            sender.Location = New System.Drawing.Point(x - 10, y - 10)
        End If
    End Sub

    Private Sub boton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        arrastrar = False
    End Sub

    Private Sub pbInfo1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbInfo1.MouseDown
        nombre_icono = "info1"
        tipo_icono = "Informacion"
        ruta_nuevo_icono = rutaInfo1
        nuevoIcono()
    End Sub

    Private Sub pbInfo2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbInfo2.MouseDown
        nombre_icono = "info2"
        tipo_icono = "Informacion"
        ruta_nuevo_icono = rutaInfo2
        nuevoIcono()
    End Sub

    Private Sub pbInfo3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbInfo3.MouseDown
        nombre_icono = "info3"
        tipo_icono = "Informacion"
        ruta_nuevo_icono = rutaInfo3
        nuevoIcono()
    End Sub

    Private Sub pbOblig1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbOblig1.MouseDown
        nombre_icono = "oblig1"
        tipo_icono = "Obligatorio"
        ruta_nuevo_icono = rutaOblig1
        nuevoIcono()
    End Sub

    Private Sub pbOblig2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbOblig2.MouseDown
        nombre_icono = "oblig2"
        tipo_icono = "Obligatorio"
        ruta_nuevo_icono = rutaOblig2
        nuevoIcono()
    End Sub

    Private Sub pbOblig3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbOblig3.MouseDown
        nombre_icono = "oblig3"
        tipo_icono = "Obligatorio"
        ruta_nuevo_icono = rutaOblig3
        nuevoIcono()
    End Sub

    Private Sub pbOblig4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbOblig4.MouseDown
        nombre_icono = "oblig4"
        tipo_icono = "Obligatorio"
        ruta_nuevo_icono = rutaOblig4
        nuevoIcono()
    End Sub

    Private Sub pbProhib1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbProhib1.MouseDown
        nombre_icono = "prohib1"
        tipo_icono = "Prohibido"
        ruta_nuevo_icono = rutaProhib1
        nuevoIcono()
    End Sub

    Private Sub pbProhib2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbProhib2.MouseDown
        nombre_icono = "prohib2"
        tipo_icono = "Prohibido"
        ruta_nuevo_icono = rutaProhib2
        nuevoIcono()
    End Sub

    Private Sub pbProhib3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbProhib3.MouseDown
        nombre_icono = "prohib3"
        tipo_icono = "Prohibido"
        ruta_nuevo_icono = rutaProhib3
        nuevoIcono()
    End Sub

    Private Sub pbProhib4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbProhib4.MouseDown
        nombre_icono = "prohib4"
        tipo_icono = "Prohibido"
        ruta_nuevo_icono = rutaProhib4
        nuevoIcono()
    End Sub

    Private Sub pbRiesgo1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbRiesgo1.MouseDown
        nombre_icono = "riesgo1"
        tipo_icono = "Riesgo"
        ruta_nuevo_icono = rutaRiesgo1
        nuevoIcono()
    End Sub

    Private Sub pbRiesgo2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbRiesgo2.MouseDown
        nombre_icono = "riesgo2"
        tipo_icono = "Riesgo"
        ruta_nuevo_icono = rutaRiesgo2
        nuevoIcono()
    End Sub

    Private Sub pbRiesgo3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbRiesgo3.MouseDown
        nombre_icono = "riesgo3"
        tipo_icono = "Riesgo"
        ruta_nuevo_icono = rutaRiesgo3
        nuevoIcono()
    End Sub

    Private Sub pbRiesgo4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbRiesgo4.MouseDown
        nombre_icono = "riesgo4"
        tipo_icono = "Riesgo"
        ruta_nuevo_icono = rutaRiesgo4
        nuevoIcono()
    End Sub

    Private Sub pbVelo1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbVelo1.MouseDown
        nombre_icono = "veloc1"
        tipo_icono = "Velocidad"
        ruta_nuevo_icono = rutaVeloc1
        nuevoIcono()
    End Sub

    Private Sub pbVelo2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbVelo2.MouseDown
        nombre_icono = "veloc2"
        tipo_icono = "Velocidad"
        ruta_nuevo_icono = rutaVeloc2
        nuevoIcono()
    End Sub

    Private Sub pbVelo3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbVelo3.MouseDown
        nombre_icono = "veloc3"
        tipo_icono = "Velocidad"
        ruta_nuevo_icono = rutaVeloc3
        nuevoIcono()
    End Sub

    Private Sub pbVelo4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbVelo4.MouseDown
        nombre_icono = "veloc4"
        tipo_icono = "Velocidad"
        ruta_nuevo_icono = rutaVeloc4
        nuevoIcono()
    End Sub

    Private Sub screenshot()
        imageBitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(imageBitmap)
        g.CopyFromScreen(0, 0, 0, 0, imageBitmap.Size)
        g.Dispose()
        Me.BackgroundImage = imageBitmap
        Me.BackgroundImageLayout = ImageLayout.None
        Me.Invalidate()
        Try
            CropImage(imageBitmap).Save(Application.StartupPath + "\Mapas\Mapa_ID_" + id_mapa + ".png", Drawing.Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox("Error, intente correr el programa con derechos de adminsitrador.")
        End Try
        Me.BackgroundImage = Nothing
    End Sub

    Function CropImage(ByVal image As Bitmap) As Bitmap
        selection.X = pbMapasPlano.Location.X - 6
        selection.Y = pbMapasPlano.Location.Y + 37
        selection.Width = pbMapasPlano.Width
        selection.Height = pbMapasPlano.Height
        Dim cropped As Bitmap = image.Clone(selection, image.PixelFormat)
        Return cropped
    End Function

End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.
