Public Class FormReporte

    Private Sub FormReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MaximizeBox = False
        MinimizeBox = False
        If identificadorReporte = 1 Then
            txtReporteTitulo.Text = tituloR1
            txtReporteDescripcion.Text = descripcionR1
            txtReporteTecnico.Text = tecnicoR1
            txtReporteObservaciones.Text = observacionesR1
        ElseIf identificadorReporte = 2 Then
            txtReporteTitulo.Text = tituloR2
            txtReporteDescripcion.Text = descripcionR2
            txtReporteTecnico.Text = tecnicoR2
            txtReporteObservaciones.Text = observacionesR2
        ElseIf identificadorReporte = 3 Then
            txtReporteTitulo.Text = tituloR3
            txtReporteDescripcion.Text = descripcionR3
            txtReporteTecnico.Text = tecnicoR3
            txtReporteObservaciones.Text = observacionesR3
        ElseIf identificadorReporte = 4 Then
            txtReporteTitulo.Text = tituloR4
            txtReporteDescripcion.Text = descripcionR4
            txtReporteTecnico.Text = tecnicoR4
            txtReporteObservaciones.Text = observacionesR4
        ElseIf identificadorReporte = 5 Then
            txtReporteTitulo.Text = tituloR5
            txtReporteDescripcion.Text = descripcionR5
            txtReporteTecnico.Text = tecnicoR5
            txtReporteObservaciones.Text = observacionesR5
        ElseIf identificadorReporte = 6 Then
            txtReporteTitulo.Text = tituloR6
            txtReporteDescripcion.Text = descripcionR6
            txtReporteTecnico.Text = tecnicoR6
            txtReporteObservaciones.Text = observacionesR6
        ElseIf identificadorReporte = 7 Then
            txtReporteTitulo.Text = tituloR7
            txtReporteDescripcion.Text = descripcionR7
            txtReporteTecnico.Text = tecnicoR7
            txtReporteObservaciones.Text = observacionesR7
        ElseIf identificadorReporte = 8 Then
            txtReporteTitulo.Text = tituloR8
            txtReporteDescripcion.Text = descripcionR8
            txtReporteTecnico.Text = tecnicoR8
            txtReporteObservaciones.Text = observacionesR8
        ElseIf identificadorReporte = 9 Then
            txtReporteTitulo.Text = tituloR9
            txtReporteDescripcion.Text = descripcionR9
            txtReporteTecnico.Text = tecnicoR9
            txtReporteObservaciones.Text = observacionesR9
        ElseIf identificadorReporte = 10 Then
            txtReporteTitulo.Text = tituloR10
            txtReporteDescripcion.Text = descripcionR10
            txtReporteTecnico.Text = tecnicoR10
            txtReporteObservaciones.Text = observacionesR10
        ElseIf identificadorReporte = 11 Then
            txtReporteTitulo.Text = tituloR11
            txtReporteDescripcion.Text = descripcionR11
            txtReporteTecnico.Text = tecnicoR11
            txtReporteObservaciones.Text = observacionesR11
        ElseIf identificadorReporte = 12 Then
            txtReporteTitulo.Text = tituloR12
            txtReporteDescripcion.Text = descripcionR12
            txtReporteTecnico.Text = tecnicoR12
            txtReporteObservaciones.Text = observacionesR12
        ElseIf identificadorReporte = 13 Then
            txtReporteTitulo.Text = tituloR13
            txtReporteDescripcion.Text = descripcionR13
            txtReporteTecnico.Text = tecnicoR13
            txtReporteObservaciones.Text = observacionesR13
        ElseIf identificadorReporte = 14 Then
            txtReporteTitulo.Text = tituloR14
            txtReporteDescripcion.Text = descripcionR14
            txtReporteTecnico.Text = tecnicoR14
            txtReporteObservaciones.Text = observacionesR14
        ElseIf identificadorReporte = 15 Then
            txtReporteTitulo.Text = tituloR15
            txtReporteDescripcion.Text = descripcionR15
            txtReporteTecnico.Text = tecnicoR15
            txtReporteObservaciones.Text = observacionesR15
        ElseIf identificadorReporte = 16 Then
            txtReporteTitulo.Text = tituloR16
            txtReporteDescripcion.Text = descripcionR16
            txtReporteTecnico.Text = tecnicoR16
            txtReporteObservaciones.Text = observacionesR16
        ElseIf identificadorReporte = 17 Then
            txtReporteTitulo.Text = tituloR17
            txtReporteDescripcion.Text = descripcionR17
            txtReporteTecnico.Text = tecnicoR17
            txtReporteObservaciones.Text = observacionesR17
        ElseIf identificadorReporte = 18 Then
            txtReporteTitulo.Text = tituloR18
            txtReporteDescripcion.Text = descripcionR18
            txtReporteTecnico.Text = tecnicoR18
            txtReporteObservaciones.Text = observacionesR18
        ElseIf identificadorReporte = 19 Then
            txtReporteTitulo.Text = tituloR19
            txtReporteDescripcion.Text = descripcionR19
            txtReporteTecnico.Text = tecnicoR19
            txtReporteObservaciones.Text = observacionesR19
        ElseIf identificadorReporte = 20 Then
            txtReporteTitulo.Text = tituloR20
            txtReporteDescripcion.Text = descripcionR20
            txtReporteTecnico.Text = tecnicoR20
            txtReporteObservaciones.Text = observacionesR20
        ElseIf identificadorReporte = 21 Then
            txtReporteTitulo.Text = tituloR21
            txtReporteDescripcion.Text = descripcionR21
            txtReporteTecnico.Text = tecnicoR21
            txtReporteObservaciones.Text = observacionesR21
        ElseIf identificadorReporte = 22 Then
            txtReporteTitulo.Text = tituloR22
            txtReporteDescripcion.Text = descripcionR22
            txtReporteTecnico.Text = tecnicoR22
            txtReporteObservaciones.Text = observacionesR22
        ElseIf identificadorReporte = 23 Then
            txtReporteTitulo.Text = tituloR23
            txtReporteDescripcion.Text = descripcionR23
            txtReporteTecnico.Text = tecnicoR23
            txtReporteObservaciones.Text = observacionesR23
        ElseIf identificadorReporte = 24 Then
            txtReporteTitulo.Text = tituloR24
            txtReporteDescripcion.Text = descripcionR24
            txtReporteTecnico.Text = tecnicoR24
            txtReporteObservaciones.Text = observacionesR24
        End If
    End Sub

    Private Sub btnReporteListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteListo.Click
        MsgBox("Recuerde que debe darle a guardar el custionario para conservar este reporte.")
        
        If txtReporteTitulo.Text = "" Then
            MsgBox("Debe ingresar el titulo.")
        Else
        If identificadorReporte = 1 Then
            tituloR1 = txtReporteTitulo.Text
            descripcionR1 = txtReporteDescripcion.Text
            tecnicoR1 = txtReporteTecnico.Text
                observacionesR1 = txtReporteObservaciones.Text
            fprevistaR1 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR1 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 2 Then
            tituloR2 = txtReporteTitulo.Text
            descripcionR2 = txtReporteDescripcion.Text
            tecnicoR2 = txtReporteTecnico.Text
                observacionesR2 = txtReporteObservaciones.Text
            fprevistaR2 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR2 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 3 Then
            tituloR3 = txtReporteTitulo.Text
            descripcionR3 = txtReporteDescripcion.Text
            tecnicoR3 = txtReporteTecnico.Text
                observacionesR3 = txtReporteObservaciones.Text
            fprevistaR3 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR3 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 4 Then
            tituloR4 = txtReporteTitulo.Text
            descripcionR4 = txtReporteDescripcion.Text
            tecnicoR4 = txtReporteTecnico.Text
                observacionesR4 = txtReporteObservaciones.Text
            fprevistaR4 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR4 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 5 Then
            tituloR5 = txtReporteTitulo.Text
            descripcionR5 = txtReporteDescripcion.Text
            tecnicoR5 = txtReporteTecnico.Text
                observacionesR5 = txtReporteObservaciones.Text
            fprevistaR5 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR5 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 6 Then
            tituloR6 = txtReporteTitulo.Text
            descripcionR6 = txtReporteDescripcion.Text
            tecnicoR6 = txtReporteTecnico.Text
                observacionesR6 = txtReporteObservaciones.Text
            fprevistaR6 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR6 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 7 Then
            tituloR7 = txtReporteTitulo.Text
            descripcionR7 = txtReporteDescripcion.Text
            tecnicoR7 = txtReporteTecnico.Text
                observacionesR7 = txtReporteObservaciones.Text
            fprevistaR7 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR7 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 8 Then
            tituloR8 = txtReporteTitulo.Text
            descripcionR8 = txtReporteDescripcion.Text
            tecnicoR8 = txtReporteTecnico.Text
                observacionesR8 = txtReporteObservaciones.Text
            fprevistaR8 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR8 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 9 Then
            tituloR9 = txtReporteTitulo.Text
            descripcionR9 = txtReporteDescripcion.Text
            tecnicoR9 = txtReporteTecnico.Text
                observacionesR9 = txtReporteObservaciones.Text
            fprevistaR9 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR9 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 10 Then
            tituloR10 = txtReporteTitulo.Text
            descripcionR10 = txtReporteDescripcion.Text
            tecnicoR10 = txtReporteTecnico.Text
                observacionesR10 = txtReporteObservaciones.Text
            fprevistaR10 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR10 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 11 Then
            tituloR11 = txtReporteTitulo.Text
            descripcionR11 = txtReporteDescripcion.Text
            tecnicoR11 = txtReporteTecnico.Text
                observacionesR11 = txtReporteObservaciones.Text
            fprevistaR11 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR11 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 12 Then
            tituloR12 = txtReporteTitulo.Text
            descripcionR12 = txtReporteDescripcion.Text
            tecnicoR12 = txtReporteTecnico.Text
                observacionesR12 = txtReporteObservaciones.Text
            fprevistaR12 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR12 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 13 Then
            tituloR13 = txtReporteTitulo.Text
            descripcionR13 = txtReporteDescripcion.Text
            tecnicoR13 = txtReporteTecnico.Text
                observacionesR13 = txtReporteObservaciones.Text
            fprevistaR13 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR13 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 14 Then
            tituloR14 = txtReporteTitulo.Text
            descripcionR14 = txtReporteDescripcion.Text
            tecnicoR14 = txtReporteTecnico.Text
                observacionesR14 = txtReporteObservaciones.Text
            fprevistaR14 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR14 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 15 Then
            tituloR15 = txtReporteTitulo.Text
            descripcionR15 = txtReporteDescripcion.Text
            tecnicoR15 = txtReporteTecnico.Text
                observacionesR15 = txtReporteObservaciones.Text
            fprevistaR15 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR15 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 16 Then
            tituloR16 = txtReporteTitulo.Text
            descripcionR16 = txtReporteDescripcion.Text
            tecnicoR16 = txtReporteTecnico.Text
                observacionesR16 = txtReporteObservaciones.Text
            fprevistaR16 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR16 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 17 Then
            tituloR17 = txtReporteTitulo.Text
            descripcionR17 = txtReporteDescripcion.Text
            tecnicoR17 = txtReporteTecnico.Text
                observacionesR17 = txtReporteObservaciones.Text
            fprevistaR17 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR17 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 18 Then
            tituloR18 = txtReporteTitulo.Text
            descripcionR18 = txtReporteDescripcion.Text
            tecnicoR18 = txtReporteTecnico.Text
                observacionesR18 = txtReporteObservaciones.Text
            fprevistaR18 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR18 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 19 Then
            tituloR19 = txtReporteTitulo.Text
            descripcionR19 = txtReporteDescripcion.Text
            tecnicoR19 = txtReporteTecnico.Text
                observacionesR19 = txtReporteObservaciones.Text
            fprevistaR19 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR19 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 20 Then
            tituloR20 = txtReporteTitulo.Text
            descripcionR20 = txtReporteDescripcion.Text
            tecnicoR20 = txtReporteTecnico.Text
                observacionesR20 = txtReporteObservaciones.Text
            fprevistaR20 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR20 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 21 Then
            tituloR21 = txtReporteTitulo.Text
            descripcionR21 = txtReporteDescripcion.Text
            tecnicoR21 = txtReporteTecnico.Text
                observacionesR21 = txtReporteObservaciones.Text
            fprevistaR21 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR21 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 22 Then
            tituloR22 = txtReporteTitulo.Text
            descripcionR22 = txtReporteDescripcion.Text
            tecnicoR22 = txtReporteTecnico.Text
                observacionesR22 = txtReporteObservaciones.Text
            fprevistaR22 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR22 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 23 Then
            tituloR23 = txtReporteTitulo.Text
            descripcionR23 = txtReporteDescripcion.Text
            tecnicoR23 = txtReporteTecnico.Text
                observacionesR23 = txtReporteObservaciones.Text
            fprevistaR23 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR23 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
        ElseIf identificadorReporte = 24 Then
            tituloR24 = txtReporteTitulo.Text
            descripcionR24 = txtReporteDescripcion.Text
            tecnicoR24 = txtReporteTecnico.Text
                observacionesR24 = txtReporteObservaciones.Text
            fprevistaR24 = Format(dtpReporteFPrevista.Value, "MM/dd/yyyy")
            frealizadoR24 = Format(dtpReporteFRealizado.Value, "MM/dd/yyyy")
            End If
        End If
    End Sub

    Private Sub btnReporteVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteVolver.Click
        Me.Close()
        identificadorReporte = ""
    End Sub
End Class








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.