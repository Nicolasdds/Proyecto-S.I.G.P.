Imports System.Data.Odbc
Public Class FormCuestionarioLugaresDeTrabajo

    Private Sub FormCuestionarioPrueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Label
        lblPag2.Visible = False
        lblPag3.Visible = False
        'Groupbox
        gbx11a20.Visible = False
        gbx21a24.Visible = False
        'ComboBox
        cboCuestionarioP1.Enabled = False
        cboCuestionarioP2.Enabled = False
        cboCuestionarioP3.Enabled = False
        cboCuestionarioP4.Enabled = False
        cboCuestionarioP5.Enabled = False
        cboCuestionarioP6.Enabled = False
        cboCuestionarioP7.Enabled = False
        cboCuestionarioP8.Enabled = False
        cboCuestionarioP9.Enabled = False
        cboCuestionarioP10.Enabled = False
        cboCuestionarioP11.Enabled = False
        cboCuestionarioP12.Enabled = False
        cboCuestionarioP13.Enabled = False
        cboCuestionarioP14.Enabled = False
        cboCuestionarioP15.Enabled = False
        cboCuestionarioP16.Enabled = False
        cboCuestionarioP17.Enabled = False
        cboCuestionarioP18.Enabled = False
        cboCuestionarioP19.Enabled = False
        cboCuestionarioP20.Enabled = False
        cboCuestionarioP21.Enabled = False
        cboCuestionarioP22.Enabled = False
        cboCuestionarioP23.Enabled = False
        cboCuestionarioP24.Enabled = False
    End Sub

    Private Sub btnCuestionarioSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioSiguiente.Click
        If gbx1a10.Visible = True Then
            gbx1a10.Visible = False
            lblPag1.Visible = False
            gbx11a20.Visible = True
            lblPag2.Visible = True
        ElseIf gbx11a20.Visible = True Then
            gbx11a20.Visible = False
            lblPag2.Visible = False
            gbx21a24.Visible = True
            lblPag3.Visible = True
        ElseIf gbx21a24.Visible = True Then
            MsgBox("La pagina 4 ya esta abierta, no hay mas paginas.")
        End If
    End Sub

    Private Sub btnCuestionarioAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioAnterior.Click
        If gbx21a24.Visible = True Then
            gbx21a24.Visible = False
            lblPag3.Visible = False
            gbx11a20.Visible = True
            lblPag2.Visible = True
        ElseIf gbx11a20.Visible = True Then
            gbx11a20.Visible = False
            lblPag2.Visible = False
            gbx1a10.Visible = True
            lblPag1.Visible = True
        ElseIf gbx1a10.Visible = True Then
            MsgBox("La pagina 1 ya esta abierta, no hay paginas antes")
        End If
    End Sub

    Private Sub btnCuestionarioUltPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioUltPag.Click
        If gbx21a24.Visible = True Then
            MsgBox("Ya se encuentra en la ultima pagina.")
        ElseIf gbx11a20.Visible = True Then
            gbx11a20.Visible = False
            lblPag2.Visible = False
            gbx21a24.Visible = True
            lblPag3.Visible = True
        ElseIf gbx1a10.Visible = True Then
            gbx1a10.Visible = False
            lblPag1.Visible = False
            gbx21a24.Visible = True
            lblPag3.Visible = True
        End If
    End Sub

    Private Sub btnCuestionario1erPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionario1erPag.Click
        If gbx1a10.Visible = True Then
            MsgBox("Ya se encuentra en la primera pagina.")
        ElseIf gbx11a20.Visible = True Then
            gbx11a20.Visible = False
            lblPag2.Visible = False
            gbx1a10.Visible = True
            lblPag1.Visible = True
        ElseIf gbx21a24.Visible = True Then
            gbx21a24.Visible = False
            lblPag3.Visible = False
            gbx1a10.Visible = True
            lblPag1.Visible = True
        End If
    End Sub

    Private Sub btnCuestionarioSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCuestionarioCalcularResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioCalcularResultado.Click
        Dim suma As Integer
        Dim resultado As Double
        Dim p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24 As Integer
        txtCuestionarioC.Clear()
        txtCuestionarioD.Clear()
        txtCuestionarioM.Clear()
        txtCuestionarioMD.Clear()
        lblCuestionarioObjC.Visible = False
        lblCuestionarioObjM.Visible = False
        lblCuestionarioObjD.Visible = False
        lblCuestionarioObjMD.Visible = False
        If cboCuestionarioP1.Text = "" Or cboCuestionarioP2.Text = "" Or cboCuestionarioP3.Text = "" Or cboCuestionarioP4.Text = "" Or cboCuestionarioP5.Text = "" Or cboCuestionarioP6.Text = "" Or cboCuestionarioP7.Text = "" Or cboCuestionarioP8.Text = "" Or cboCuestionarioP9.Text = "" Or cboCuestionarioP10.Text = "" Or cboCuestionarioP11.Text = "" Or cboCuestionarioP12.Text = "" Or cboCuestionarioP13.Text = "" Or cboCuestionarioP14.Text = "" Or cboCuestionarioP15.Text = "" Or cboCuestionarioP16.Text = "" Or cboCuestionarioP17.Text = "" Or cboCuestionarioP18.Text = "" Or cboCuestionarioP19.Text = "" Or cboCuestionarioP20.Text = "" Or cboCuestionarioP21.Text = "" Or cboCuestionarioP22.Text = "" Or cboCuestionarioP23.Text = "" Or cboCuestionarioP24.Text = "" Then
            MsgBox("Debe responder a todo el cuestionario, revise.")
        Else
            p1 = Convert.ToInt32(cboCuestionarioP1.Text)
            p2 = Convert.ToInt32(cboCuestionarioP2.Text)
            p3 = Convert.ToInt32(cboCuestionarioP3.Text)
            p4 = Convert.ToInt32(cboCuestionarioP4.Text)
            p5 = Convert.ToInt32(cboCuestionarioP5.Text)
            p6 = Convert.ToInt32(cboCuestionarioP6.Text)
            p7 = Convert.ToInt32(cboCuestionarioP7.Text)
            p8 = Convert.ToInt32(cboCuestionarioP8.Text)
            p9 = Convert.ToInt32(cboCuestionarioP9.Text)
            p10 = Convert.ToInt32(cboCuestionarioP10.Text)
            p11 = Convert.ToInt32(cboCuestionarioP11.Text)
            p12 = Convert.ToInt32(cboCuestionarioP12.Text)
            p13 = Convert.ToInt32(cboCuestionarioP13.Text)
            p14 = Convert.ToInt32(cboCuestionarioP14.Text)
            p15 = Convert.ToInt32(cboCuestionarioP15.Text)
            p16 = Convert.ToInt32(cboCuestionarioP16.Text)
            p17 = Convert.ToInt32(cboCuestionarioP17.Text)
            p18 = Convert.ToInt32(cboCuestionarioP18.Text)
            p19 = Convert.ToInt32(cboCuestionarioP19.Text)
            p20 = Convert.ToInt32(cboCuestionarioP20.Text)
            p21 = Convert.ToInt32(cboCuestionarioP21.Text)
            p22 = Convert.ToInt32(cboCuestionarioP22.Text)
            p23 = Convert.ToInt32(cboCuestionarioP23.Text)
            p24 = Convert.ToInt32(cboCuestionarioP24.Text)
            If p1 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 1
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 1
                End If
            ElseIf p1 > 1 And p1 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 1
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 1
                End If
            ElseIf p1 > 4 And p1 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 1
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 1
                End If
            ElseIf p1 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 1
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 1
                End If
            End If
            '
            '
            If p2 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 2
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 2
                End If
            ElseIf p2 > 1 And p2 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 2
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 2
                End If
            ElseIf p2 > 4 And p2 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 2
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 2
                End If
            ElseIf p2 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 2
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 2
                End If
            End If
            '
            If p3 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 3
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 3
                End If
            ElseIf p3 > 1 And p3 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 3
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 3
                End If
            ElseIf p3 > 4 And p3 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 3
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 3
                End If
            ElseIf p3 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 3
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 3
                End If
            End If
            '
            '
            If p4 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 4
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 4
                End If
            ElseIf p4 > 1 And p4 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 4
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 4
                End If
            ElseIf p4 > 4 And p4 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 4
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 4
                End If
            ElseIf p4 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 4
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 4
                End If
            End If
            '
            '
            If p5 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 5
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 5
                End If
            ElseIf p5 > 1 And p5 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 5
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 5
                End If
            ElseIf p5 > 4 And p5 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 5
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 5
                End If
            ElseIf p5 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 5
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 5
                End If
            End If
            ' '
            If p6 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 6
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 6
                End If
            ElseIf p6 > 1 And p6 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 6
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 6
                End If
            ElseIf p6 > 4 And p6 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 6
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 6
                End If
            ElseIf p6 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 6
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 6
                End If
            End If
            ' 
            If p7 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 7
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 7
                End If
            ElseIf p7 > 1 And p7 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 7
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 7
                End If
            ElseIf p7 > 4 And p7 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 7
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 7
                End If
            ElseIf p7 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 7
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 7
                End If
            End If
            ' '
            If p8 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 8
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 8
                End If
            ElseIf p8 > 1 And p8 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 8
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 8
                End If
            ElseIf p8 > 4 And p8 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 8
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 8
                End If
            ElseIf p8 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 8
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 8
                End If
            End If
            ' '
            If p9 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 9
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 9
                End If
            ElseIf p9 > 1 And p9 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 9
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 9
                End If
            ElseIf p9 > 4 And p9 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 9
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 9
                End If
            ElseIf p9 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 9
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 9
                End If
            End If
            ' 
            If p10 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 10
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 10
                End If
            ElseIf p10 > 1 And p10 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 10
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 10
                End If
            ElseIf p10 > 4 And p10 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 10
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 10
                End If
            ElseIf p10 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 10
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 10
                End If
            End If
            ' ' 
            If p11 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 11
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 11
                End If
            ElseIf p11 > 1 And p11 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 11
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 11
                End If
            ElseIf p11 > 4 And p11 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 11
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 11
                End If
            ElseIf p11 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 11
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 11
                End If
            End If
            ' ' 
            If p12 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 12
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 12
                End If
            ElseIf p12 > 1 And p12 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 12
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 12
                End If
            ElseIf p12 > 4 And p12 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 12
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 12
                End If
            ElseIf p12 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 12
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 12
                End If
            End If
            ' ' 
            If p13 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 13
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 13
                End If
            ElseIf p13 > 1 And p13 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 13
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 13
                End If
            ElseIf p13 > 4 And p13 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 13
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 13
                End If
            ElseIf p13 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 13
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 13
                End If
            End If
            ' ' 
            If p14 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 14
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 14
                End If
            ElseIf p14 > 1 And p14 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 14
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 14
                End If
            ElseIf p14 > 4 And p14 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 14
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 14
                End If
            ElseIf p14 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 14
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 14
                End If
            End If
            ' ' 
            If p15 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 15
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 15
                End If
            ElseIf p15 > 1 And p15 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 15
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 15
                End If
            ElseIf p15 > 4 And p15 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 15
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 15
                End If
            ElseIf p15 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 15
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 15
                End If
            End If
            ' ' 
            If p16 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 16
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 16
                End If
            ElseIf p16 > 1 And p16 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 16
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 16
                End If
            ElseIf p16 > 4 And p16 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 16
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 16
                End If
            ElseIf p16 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 16
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 16
                End If
            End If
            ' ' 
            If p17 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 17
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 17
                End If
            ElseIf p17 > 1 And p17 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 17
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 17
                End If
            ElseIf p17 > 4 And p17 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 17
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 17
                End If
            ElseIf p17 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 17
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 17
                End If
            End If
            ' ' 
            If p18 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 18
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 18
                End If
            ElseIf p18 > 1 And p18 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 18
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 18
                End If
            ElseIf p18 > 4 And p18 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 18
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 18
                End If
            ElseIf p18 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 18
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 18
                End If
            End If
            ' ' 
            If p19 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 19
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 19
                End If
            ElseIf p19 > 1 And p19 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 19
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 19
                End If
            ElseIf p19 > 4 And p19 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 19
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 19
                End If
            ElseIf p19 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 19
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 19
                End If
            End If
            ' ' 
            If p20 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 20
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 20
                End If
            ElseIf p20 > 1 And p20 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 20
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 20
                End If
            ElseIf p20 > 4 And p20 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 20
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 20
                End If
            ElseIf p20 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 20
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 20
                End If
            End If
            '
            ' ' 
            If p21 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 21
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 21
                End If
            ElseIf p21 > 1 And p21 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 21
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 21
                End If
            ElseIf p21 > 4 And p21 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 21
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 21
                End If
            ElseIf p21 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 21
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 21
                End If
            End If
            '' ' 
            If p22 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 22
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 22
                End If
            ElseIf p22 > 1 And p22 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 22
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 22
                End If
            ElseIf p22 > 4 And p22 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 22
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 22
                End If
            ElseIf p22 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 22
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 22
                End If
            End If
            '' ' 
            If p23 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 23
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 23
                End If
            ElseIf p23 > 1 And p23 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 23
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 23
                End If
            ElseIf p23 > 4 And p23 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 23
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 23
                End If
            ElseIf p23 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 23
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 23
                End If
            End If
            '' ' 
            If p24 = 1 Then
                If txtCuestionarioC.Text = "" Then
                    txtCuestionarioC.Text = 24
                Else
                    txtCuestionarioC.Text = txtCuestionarioC.Text & ", " & 24
                End If
            ElseIf p24 > 1 And p24 < 5 Then
                If txtCuestionarioM.Text = "" Then
                    txtCuestionarioM.Text = 24
                Else
                    txtCuestionarioM.Text = txtCuestionarioM.Text & ", " & 24
                End If
            ElseIf p24 > 4 And p24 < 8 Then
                If txtCuestionarioD.Text = "" Then
                    txtCuestionarioD.Text = 24
                Else
                    txtCuestionarioD.Text = txtCuestionarioD.Text & ", " & 24
                End If
            ElseIf p24 > 7 Then
                If txtCuestionarioMD.Text = "" Then
                    txtCuestionarioMD.Text = 24
                Else
                    txtCuestionarioMD.Text = txtCuestionarioMD.Text & ", " & 24
                End If
            End If
            '
            '
            suma = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21 + p22 + p23 + p24
            resultado = suma / 24
            ponderacion_cuestionario = CStr(Math.Round(resultado))
            txtCuestionarioResultado.Text = ponderacion_cuestionario
            If ponderacion_cuestionario = 1 Then
                lblCuestionarioObjC.Visible = True
            ElseIf ponderacion_cuestionario > 1 And ponderacion_cuestionario < 5 Then
                lblCuestionarioObjM.Visible = True
            ElseIf ponderacion_cuestionario > 4 And ponderacion_cuestionario < 8 Then
                lblCuestionarioObjD.Visible = True
            ElseIf ponderacion_cuestionario > 7 Then
                lblCuestionarioObjMD.Visible = True
            End If
        End If
    End Sub

    Private Sub rbtnCuestionarioSiP1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP1.CheckedChanged
        cboCuestionarioP1.Text = 1
        cboCuestionarioP1.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP2.CheckedChanged
        cboCuestionarioP2.Text = 1
        cboCuestionarioP2.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP3.CheckedChanged
        cboCuestionarioP3.Text = 1
        cboCuestionarioP3.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP4.CheckedChanged
        cboCuestionarioP4.Text = 1
        cboCuestionarioP4.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP5.CheckedChanged
        cboCuestionarioP5.Text = 1
        cboCuestionarioP5.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP6.CheckedChanged
        cboCuestionarioP6.Text = 1
        cboCuestionarioP6.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP7.CheckedChanged
        cboCuestionarioP7.Text = 1
        cboCuestionarioP7.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP8_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP8.CheckedChanged
        cboCuestionarioP8.Text = 1
        cboCuestionarioP8.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP9_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP9.CheckedChanged
        cboCuestionarioP9.Text = 1
        cboCuestionarioP9.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP10_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP10.CheckedChanged
        cboCuestionarioP10.Text = 1
        cboCuestionarioP10.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP11_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP11.CheckedChanged
        cboCuestionarioP11.Text = 1
        cboCuestionarioP11.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP12_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP12.CheckedChanged
        cboCuestionarioP12.Text = 1
        cboCuestionarioP12.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP13_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP13.CheckedChanged
        cboCuestionarioP13.Text = 1
        cboCuestionarioP13.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP14_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP14.CheckedChanged
        cboCuestionarioP14.Text = 1
        cboCuestionarioP14.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP15_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP15.CheckedChanged
        cboCuestionarioP15.Text = 1
        cboCuestionarioP15.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP16_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP16.CheckedChanged
        cboCuestionarioP16.Text = 1
        cboCuestionarioP16.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP17_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP17.CheckedChanged
        cboCuestionarioP17.Text = 1
        cboCuestionarioP17.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP18_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP18.CheckedChanged
        cboCuestionarioP18.Text = 1
        cboCuestionarioP18.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP19_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP19.CheckedChanged
        cboCuestionarioP19.Text = 1
        cboCuestionarioP19.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP20_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP20.CheckedChanged
        cboCuestionarioP20.Text = 1
        cboCuestionarioP20.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP21_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP21.CheckedChanged
        cboCuestionarioP21.Text = 1
        cboCuestionarioP21.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP22_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP22.CheckedChanged
        cboCuestionarioP22.Text = 1
        cboCuestionarioP22.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP23_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP23.CheckedChanged
        cboCuestionarioP23.Text = 1
        cboCuestionarioP23.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioSiP24_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioSiP24.CheckedChanged
        cboCuestionarioP24.Text = 1
        cboCuestionarioP24.Enabled = False
    End Sub

    Private Sub rbtnCuestionarioNoP1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP1.CheckedChanged
        cboCuestionarioP1.Text = 2
        cboCuestionarioP1.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP2.CheckedChanged
        cboCuestionarioP2.Text = 2
        cboCuestionarioP2.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP3.CheckedChanged
        cboCuestionarioP3.Text = 2
        cboCuestionarioP3.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP4.CheckedChanged
        cboCuestionarioP4.Text = 2
        cboCuestionarioP4.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP5.CheckedChanged
        cboCuestionarioP5.Text = 2
        cboCuestionarioP5.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP6.CheckedChanged
        cboCuestionarioP6.Text = 2
        cboCuestionarioP6.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP7.CheckedChanged
        cboCuestionarioP7.Text = 2
        cboCuestionarioP7.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP8_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP8.CheckedChanged
        cboCuestionarioP8.Text = 2
        cboCuestionarioP8.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP9_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP9.CheckedChanged
        cboCuestionarioP9.Text = 2
        cboCuestionarioP9.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP10_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP10.CheckedChanged
        cboCuestionarioP10.Text = 2
        cboCuestionarioP10.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP11_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP11.CheckedChanged
        cboCuestionarioP11.Text = 2
        cboCuestionarioP11.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP12_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP12.CheckedChanged
        cboCuestionarioP12.Text = 2
        cboCuestionarioP12.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP13_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP13.CheckedChanged
        cboCuestionarioP13.Text = 2
        cboCuestionarioP13.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP14_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP14.CheckedChanged
        cboCuestionarioP14.Text = 2
        cboCuestionarioP14.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP15_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP15.CheckedChanged
        cboCuestionarioP15.Text = 2
        cboCuestionarioP15.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP16_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP16.CheckedChanged
        cboCuestionarioP16.Text = 2
        cboCuestionarioP16.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP17_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP17.CheckedChanged
        cboCuestionarioP17.Text = 2
        cboCuestionarioP17.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP18_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP18.CheckedChanged
        cboCuestionarioP18.Text = 2
        cboCuestionarioP18.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP19_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP19.CheckedChanged
        cboCuestionarioP19.Text = 2
        cboCuestionarioP19.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP20_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP20.CheckedChanged
        cboCuestionarioP20.Text = 2
        cboCuestionarioP20.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP21_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP21.CheckedChanged
        cboCuestionarioP21.Text = 2
        cboCuestionarioP21.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP22_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP22.CheckedChanged
        cboCuestionarioP22.Text = 2
        cboCuestionarioP22.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP23_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP23.CheckedChanged
        cboCuestionarioP23.Text = 2
        cboCuestionarioP23.Enabled = True
    End Sub
    Private Sub rbtnCuestionarioNoP24_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnCuestionarioNoP24.CheckedChanged
        cboCuestionarioP24.Text = 2
        cboCuestionarioP24.Enabled = True
    End Sub

    Private Sub btnCuestionarioR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR1.Click
        identificadorReporte = 1
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR2.Click
        identificadorReporte = 2
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR3.Click
        identificadorReporte = 3
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR4.Click
        identificadorReporte = 4
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR5.Click
        identificadorReporte = 5
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR6.Click
        identificadorReporte = 6
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR7.Click
        identificadorReporte = 7
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR8.Click
        identificadorReporte = 8
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR9.Click
        identificadorReporte = 9
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR10.Click
        identificadorReporte = 10
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR11.Click
        identificadorReporte = 11
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR12.Click
        identificadorReporte = 12
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR13.Click
        identificadorReporte = 13
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR14.Click
        identificadorReporte = 14
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR15.Click
        identificadorReporte = 15
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR16.Click
        identificadorReporte = 16
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR17.Click
        identificadorReporte = 17
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR18.Click
        identificadorReporte = 18
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR19.Click
        identificadorReporte = 19
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR20.Click
        identificadorReporte = 20
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub
    Private Sub btnCuestionarioR21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR21.Click
        identificadorReporte = 21
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR22.Click
        identificadorReporte = 22
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR23.Click
        identificadorReporte = 23
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioR24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioR24.Click
        identificadorReporte = 24
        FormReporte.Show()
        FormReporte.MdiParent = FormPrincipal
    End Sub

    Private Sub btnCuestionarioGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuestionarioGuardar.Click
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String
        Dim pafectadas As Integer
        Dim ptotales As Integer
        Dim fecha_prox As String
        Dim fecha_actual As DateTime = DateTime.Now
        Dim solo_fecha As String
        Dim val_subjetivo As String
        solo_fecha = Format(fecha_actual, "MM/dd/yyyy")
        fecha_prox = Format(dtpCuestionarioFechaProxRev.Value, "MM/dd/yyyy")

        If txtCuestionarioResultado.Text = "" Then
            MsgBox("Debe obtener un resultado antes de guardar.")
        Else
            If txtCuestionarioAreaTrab.Text = "" Or txtCuestionarioCumplimentadoPor.Text = "" Or txtCuestionarioTotalPersonas.Text = "" Or txtCuestionarioPersonasAfectadas.Text = "" Then
                MsgBox("Debe ingresar todos los campos")
            Else
                If rbtnCuestionarioSubC.Checked = False And rbtnCuestionarioSubM.Checked = False And rbtnCuestionarioSubD.Checked = False And rbtnCuestionarioSubMD.Checked = False Then
                    MsgBox("Debe ingresar una valoracion subjetiva")
                Else
                    If rbtnCuestionarioSubC.Checked = True Then
                        val_subjetivo = "c"
                    ElseIf rbtnCuestionarioSubM.Checked = True Then
                        val_subjetivo = "m"
                    ElseIf rbtnCuestionarioSubD.Checked = True Then
                        val_subjetivo = "d"
                    ElseIf rbtnCuestionarioSubMD.Checked = True Then
                        val_subjetivo = "md"
                    End If
                    pafectadas = Convert.ToInt32(txtCuestionarioPersonasAfectadas.Text)
                    ptotales = Convert.ToInt32(txtCuestionarioTotalPersonas.Text)
                    If pafectadas > 0 And ptotales > 0 Then
                        If pafectadas > ptotales Then
                            MsgBox("El numero de personas afectadas es mayor que las totales, revise.")
                        Else
                            If solo_fecha > fecha_prox Then
                                MsgBox("No se puede guardar una fecha menor a la de hoy.")
                            Else
                                MsgBox("Bien, cumples con todos los requisitos para guardar el cuestionario!")
                                'Ingresando cuestionario..
                                Try
                                    Dim nombre_relev As String = "Lugares trabajo"
                                    sql = "INSERT INTO cuestionario VALUES(0," & RelevamientoActualId & ",'" & nombre_relev & "','" & txtCuestionarioAreaTrab.Text & "'," & ptotales & "," & pafectadas & ",'" & val_subjetivo & "','" & fecha_prox & "','" & solo_fecha & "')"
                                    comando.Connection = conexion
                                    comando.CommandText = sql
                                    comando.ExecuteNonQuery()

                                    'Recuperando el id del ultimo cuestionario.
                                    Try
                                        sql = "SELECT * FROM cuestionario WHERE id_cuestionario=(select max(id_cuestionario) from cuestionario)"
                                        comando.Connection = conexion
                                        comando.CommandText = sql
                                        dr = comando.ExecuteReader()
                                        If dr.HasRows Then
                                            id_cuestionario = dr("id_cuestionario")
                                            dr.Close()
                                            '*******************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 1********************************************************************************************
                                            'Ingresando pregunta 1
                                            Try
                                                Dim num_pregunta As Integer = 1
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP1.Text & "','" & cboCuestionarioP1.Text & "','" & txtCuestionarioO1.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR1 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR1 & "','" & tituloR1 & "','" & observacionesR1 & "','" & descripcionR1 & "','" & frealizadoR1 & "','" & tecnicoR1 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 1.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 1")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 1******************************************************************************************
                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 2******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 2
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP2.Text & "','" & cboCuestionarioP2.Text & "','" & txtCuestionarioO2.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR2 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR2 & "','" & tituloR2 & "','" & observacionesR2 & "','" & descripcionR2 & "','" & frealizadoR2 & "','" & tecnicoR2 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 2.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 2")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 2******************************************************************************************


                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 3******************************************************************************************

                                            Try
                                                Dim num_pregunta As Integer = 3
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP3.Text & "','" & cboCuestionarioP3.Text & "','" & txtCuestionarioO3.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR3 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR3 & "','" & tituloR3 & "','" & observacionesR3 & "','" & descripcionR3 & "','" & frealizadoR3 & "','" & tecnicoR3 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 3.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 3")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 3******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 4******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 4
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP4.Text & "','" & cboCuestionarioP4.Text & "','" & txtCuestionarioO4.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR4 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR4 & "','" & tituloR4 & "','" & observacionesR4 & "','" & descripcionR4 & "','" & frealizadoR4 & "','" & tecnicoR4 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 4.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta.")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta.")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 4.")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 4******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 5******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 5
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP5.Text & "','" & cboCuestionarioP5.Text & "','" & txtCuestionarioO5.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR5 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR5 & "','" & tituloR5 & "','" & observacionesR5 & "','" & descripcionR5 & "','" & frealizadoR5 & "','" & tecnicoR5 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 5.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 5")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 5******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 6******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 6
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP6.Text & "','" & cboCuestionarioP6.Text & "','" & txtCuestionarioO6.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR6 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR6 & "','" & tituloR6 & "','" & observacionesR6 & "','" & descripcionR6 & "','" & frealizadoR6 & "','" & tecnicoR6 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 6.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 6")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 6******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 7******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 7
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP7.Text & "','" & cboCuestionarioP7.Text & "','" & txtCuestionarioO7.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR7 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR7 & "','" & tituloR7 & "','" & observacionesR7 & "','" & descripcionR7 & "','" & frealizadoR7 & "','" & tecnicoR7 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 7.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 7")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 7******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 8******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 8
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP8.Text & "','" & cboCuestionarioP8.Text & "','" & txtCuestionarioO8.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR8 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR8 & "','" & tituloR8 & "','" & observacionesR8 & "','" & descripcionR8 & "','" & frealizadoR8 & "','" & tecnicoR8 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 8.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 8")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 8******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 9******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 9
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP9.Text & "','" & cboCuestionarioP9.Text & "','" & txtCuestionarioO9.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR9 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR9 & "','" & tituloR9 & "','" & observacionesR9 & "','" & descripcionR9 & "','" & frealizadoR9 & "','" & tecnicoR9 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 9.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 9")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 9******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 10******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 10
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP10.Text & "','" & cboCuestionarioP10.Text & "','" & txtCuestionarioO10.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR10 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR10 & "','" & tituloR10 & "','" & observacionesR10 & "','" & descripcionR10 & "','" & frealizadoR10 & "','" & tecnicoR10 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 10.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 10")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 10******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 11******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 11
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP11.Text & "','" & cboCuestionarioP11.Text & "','" & txtCuestionarioO11.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR11 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR11 & "','" & tituloR11 & "','" & observacionesR11 & "','" & descripcionR11 & "','" & frealizadoR11 & "','" & tecnicoR11 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 11.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 11")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 11******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 12******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 12
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP12.Text & "','" & cboCuestionarioP12.Text & "','" & txtCuestionarioO12.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR12 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR12 & "','" & tituloR12 & "','" & observacionesR12 & "','" & descripcionR12 & "','" & frealizadoR12 & "','" & tecnicoR12 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 12.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 12")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 12******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 13******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 13
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP13.Text & "','" & cboCuestionarioP13.Text & "','" & txtCuestionarioO13.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR13 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR13 & "','" & tituloR13 & "','" & observacionesR13 & "','" & descripcionR13 & "','" & frealizadoR13 & "','" & tecnicoR13 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 13.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 13")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 13******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 14******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 14
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP14.Text & "','" & cboCuestionarioP14.Text & "','" & txtCuestionarioO14.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR14 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR14 & "','" & tituloR14 & "','" & observacionesR14 & "','" & descripcionR14 & "','" & frealizadoR14 & "','" & tecnicoR14 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 14.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 14")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 14******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 15******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 15
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP15.Text & "','" & cboCuestionarioP15.Text & "','" & txtCuestionarioO15.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR15 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR15 & "','" & tituloR15 & "','" & observacionesR15 & "','" & descripcionR15 & "','" & frealizadoR15 & "','" & tecnicoR15 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 15.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 15")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 15******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 16******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 16
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP16.Text & "','" & cboCuestionarioP16.Text & "','" & txtCuestionarioO16.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR16 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR16 & "','" & tituloR16 & "','" & observacionesR16 & "','" & descripcionR16 & "','" & frealizadoR16 & "','" & tecnicoR16 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 16.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 16")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 16******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 17******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 17
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP1.Text & "','" & cboCuestionarioP17.Text & "','" & txtCuestionarioO17.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR17 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR17 & "','" & tituloR17 & "','" & observacionesR17 & "','" & descripcionR17 & "','" & frealizadoR17 & "','" & tecnicoR17 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 17.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 17")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 17******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 18******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 18
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP18.Text & "','" & cboCuestionarioP18.Text & "','" & txtCuestionarioO18.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR18 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR18 & "','" & tituloR18 & "','" & observacionesR18 & "','" & descripcionR18 & "','" & frealizadoR18 & "','" & tecnicoR18 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 18.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 18")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 18******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 19******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 19
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP19.Text & "','" & cboCuestionarioP19.Text & "','" & txtCuestionarioO19.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR19 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR19 & "','" & tituloR19 & "','" & observacionesR19 & "','" & descripcionR19 & "','" & frealizadoR19 & "','" & tecnicoR19 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 19.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 19")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 19******************************************************************************************

                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 20******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 20
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP20.Text & "','" & cboCuestionarioP20.Text & "','" & txtCuestionarioO20.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR20 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR20 & "','" & tituloR20 & "','" & observacionesR20 & "','" & descripcionR20 & "','" & frealizadoR20 & "','" & tecnicoR20 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 20.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 20")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 20******************************************************************************************
                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 21******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 21
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP21.Text & "','" & cboCuestionarioP21.Text & "','" & txtCuestionarioO21.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()

                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR21 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR21 & "','" & tituloR21 & "','" & observacionesR21 & "','" & descripcionR21 & "','" & frealizadoR21 & "','" & tecnicoR21 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()

                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()

                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 21.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 21")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 21******************************************************************************************
                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 22******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 22
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP22.Text & "','" & cboCuestionarioP22.Text & "','" & txtCuestionarioO22.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR22 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR22 & "','" & tituloR22 & "','" & observacionesR22 & "','" & descripcionR22 & "','" & frealizadoR22 & "','" & tecnicoR22 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()
                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()
                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 22.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 22")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 22******************************************************************************************
                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 23******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 23
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP23.Text & "','" & cboCuestionarioP23.Text & "','" & txtCuestionarioO23.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR23 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR23 & "','" & tituloR23 & "','" & observacionesR23 & "','" & descripcionR23 & "','" & frealizadoR23 & "','" & tecnicoR23 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()
                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()
                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 23.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 23")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 23******************************************************************************************
                                            '**************************************************AQUI COMIENZA EL PROCESO DE LA PREGUNTA 24******************************************************************************************
                                            '
                                            Try
                                                Dim num_pregunta As Integer = 24
                                                sql = "INSERT INTO pregunta VALUES(0," & num_pregunta & ",'" & lblCuestionarioP24.Text & "','" & cboCuestionarioP24.Text & "','" & txtCuestionarioO24.Text & "'," & id_cuestionario & "," & RelevamientoActualId & ",NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                                'Recuperando el id de la ultima pregunta...
                                                Try
                                                    sql = "SELECT * FROM pregunta WHERE serie_preg=(select max(serie_preg) from pregunta)"
                                                    comando.Connection = conexion
                                                    comando.CommandText = sql
                                                    dr = comando.ExecuteReader()
                                                    If dr.HasRows Then
                                                        serie_pregunta = dr("serie_preg")
                                                        dr.Close()
                                                        'Verificando si existe algun reporte para ser guardado..
                                                        If tituloR24 <> "" Then
                                                            Try
                                                                sql = "INSERT INTO reporte VALUES(0,'" & fprevistaR24 & "','" & tituloR24 & "','" & observacionesR24 & "','" & descripcionR24 & "','" & frealizadoR24 & "','" & tecnicoR24 & "')"
                                                                comando.Connection = conexion
                                                                comando.CommandText = sql
                                                                comando.ExecuteNonQuery()
                                                                Try
                                                                    'Recuperando el id del ultimo reporte.
                                                                    sql = "SELECT * FROM reporte WHERE id_rep=(select max(id_rep) from reporte)"
                                                                    comando.Connection = conexion
                                                                    comando.CommandText = sql
                                                                    dr = comando.ExecuteReader()
                                                                    If dr.HasRows Then
                                                                        id_reporte = dr("id_rep")
                                                                        dr.Close()
                                                                        Try
                                                                            sql = "UPDATE pregunta SET id_rep='" & id_reporte & "' where serie_preg='" & serie_pregunta & "'"
                                                                            comando.Connection = conexion
                                                                            comando.CommandText = sql
                                                                            comando.ExecuteNonQuery()
                                                                            dr.Close()
                                                                        Catch ex As Exception
                                                                            MsgBox("Error al vincular el reporte con la pregunta.")
                                                                        End Try
                                                                    Else
                                                                        MsgBox("No se encontro el ultimo id de reporte.")
                                                                    End If
                                                                Catch ex As Exception
                                                                    MsgBox("Error al obtener el ultimo id de reporte.")
                                                                End Try
                                                            Catch ex As Exception
                                                                MsgBox("Error al ingresar reporte 24.")
                                                            End Try

                                                        End If
                                                    Else
                                                        MsgBox("No se encontro el ultimo id de pregunta")
                                                    End If
                                                Catch ex As Exception
                                                    MsgBox("Error al obtener el ultimo id de pregunta")
                                                End Try
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar pregunta 24")
                                            End Try
                                            '***************************************************AQUI TERMINA EL PROCESO DE LA PREGUNTA 24******************************************************************************************
                                            'Ingresamos los datos en la tabla de calculos.
                                            Try
                                                sql = "INSERT INTO calculo VALUES(0," & RelevamientoActualId & "," & id_cuestionario & "," & ponderacion_cuestionario & ",NULL,NULL,NULL,NULL,NULL,NULL,NULL)"
                                                comando.Connection = conexion
                                                comando.CommandText = sql
                                                comando.ExecuteNonQuery()
                                            Catch ex As Exception
                                                MsgBox("Error al ingresar datos en calculos")
                                            End Try
                                            MsgBox("Cuestionario Guardado!.")
                                        Else
                                            MsgBox("No se encontró el ultimo id de cuestionario.")
                                        End If
                                    Catch ex As Exception
                                        MsgBox("Error al obtener el id del ultimo cuestionario.")
                                        MsgBox(ex.Message)
                                    End Try
                                Catch ex As Exception
                                    MsgBox("Error al ingresar nuevo cuestionario.")
                                    MsgBox(ex.Message)
                                End Try
                            End If
                        End If
                    Else
                        MsgBox("La cantidad de personas deben ser numeros positivos.")
                    End If
                End If
            End If
        End If

    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.


