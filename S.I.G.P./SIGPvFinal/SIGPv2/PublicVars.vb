Module PublicVars
    Public Sub cerrar_ventanas()
        For Each frm As Form In FormPrincipal.MdiChildren
            frm.Close()
        Next
    End Sub
    'Login
    Public idioma_actual As String
    Public rol_actual As Integer
    'Reporte General
    Public nom_cuestionario As String
    Public id_cuestionario As String
    Public area_trabajo As String
    Public pers_totales As String
    Public pers_afec As String
    Public res_subjetivo As String
    Public res_objetivo As String
    Public fecha_prox_cuest As String
    Public fecha_creado As String
    'Empresa
    Public RutEmpresa As String
    Public RSEmpresa As String
    Public EmpresaActualRS As String
    Public EmpresaActualRUT As String
    'Trabajador
    Public ci_tr As String
    Public turno_tr As String
    Public sector_tr As String
    'Relevamiento
    Public RelevamientoActualId As String
    Public VisitasActuales As String
    'Gestion de Prevencionistas
    Public CiPrevencionista As String
    Public NombrePrevencionista As String
    Public UsuarioPrevencionista As String
    'Inspecciones
    Public Id_obs As String
    Public unidad_inspectora As String
    'Cuestionario
    Public ponderacion_cuestionario As Integer
    Public fecha_visita As String
    Public nombre_sistema As String = "S.I.G.P."
    Public id_reporte As String
    Public serie_pregunta As String
    Public datasetCuestionario As New DataSet
    'Calculo
    Public nivel_d As Integer
    Public nivel_e As Integer
    Public nivel_p As Integer
    Public nivel_c As Integer
    Public nivel_r As Integer
    Public nivel_rep As Integer
    Public f_ponderacion As Integer
    Public porcentaje_expuestos As Double
    Public porcentaje_exp_redondeado As Integer
    Public intervencion As String
    'Consola General
    Public rowID As String
    Public rowID1 As String
    Public rowID2 As String
    Public rowTitle As String
    Public rowDate As DateTime
    Public row1 As String
    Public row2 As String
    Public row3 As String
    Public row4 As String
    Public row5 As String
    Public row6 As String
    Public row7 As String
    Public row8 As String
    Public row9 As String
    Public row10 As String
    'Mapas
    Public temporal As Integer
    Public fecha_fin_relevamiento As String
    Public estado_relevamiento As String
    Public cantidad_iconos As Integer
    Public id_for_iconos As Integer
    Public id_icono As String
    Public nombre_icono As String
    Public tipo_icono As String
    Public ruta_nuevo_icono As String
    Public pos_x As String
    Public pos_y As String
    Public id_mapa As String
    Public titulo_mapa As String
    Public ruta_mapa As String
    Public error_caption As Boolean = False
    Public rutaInfo1 As String = "\Iconos\Informacion\info1.jpeg"
    Public rutaInfo2 As String = "\Iconos\Informacion\info2.jpeg"
    Public rutaInfo3 As String = "\Iconos\Informacion\info3.jpeg"
    Public rutaOblig1 As String = "\Iconos\Obligatorios\oblig1.jpeg"
    Public rutaOblig2 As String = "\Iconos\Obligatorios\oblig2.jpeg"
    Public rutaOblig3 As String = "\Iconos\Obligatorios\oblig3.jpeg"
    Public rutaOblig4 As String = "\Iconos\Obligatorios\oblig4.jpeg"
    Public rutaProhib1 As String = "\Iconos\Prohibido\prohib1.jpeg"
    Public rutaProhib2 As String = "\Iconos\Prohibido\prohib2.jpeg"
    Public rutaProhib3 As String = "\Iconos\Prohibido\prohib3.jpeg"
    Public rutaProhib4 As String = "\Iconos\Prohibido\prohib4.jpeg"
    Public rutaRiesgo1 As String = "\Iconos\Riesgo\riesgo1.jpeg"
    Public rutaRiesgo2 As String = "\Iconos\Riesgo\riesgo2.jpeg"
    Public rutaRiesgo3 As String = "\Iconos\Riesgo\riesgo3.jpeg"
    Public rutaRiesgo4 As String = "\Iconos\Riesgo\riesgo4.jpeg"
    Public rutaVeloc1 As String = "\Iconos\Velocidad\veloc1.jpeg"
    Public rutaVeloc2 As String = "\Iconos\Velocidad\veloc2.jpeg"
    Public rutaVeloc3 As String = "\Iconos\Velocidad\veloc3.jpeg"
    Public rutaVeloc4 As String = "\Iconos\Velocidad\veloc4.jpeg"
    'Reportes
    Public identificadorReporte As String
    'Reporte 1
    Public tituloR1 As String
    Public descripcionR1 As String
    Public fprevistaR1 As String
    Public tecnicoR1 As String
    Public frealizadoR1 As String
    Public observacionesR1 As String
    'Reporte 2
    Public tituloR2 As String
    Public descripcionR2 As String
    Public fprevistaR2 As String
    Public tecnicoR2 As String
    Public frealizadoR2 As String
    Public observacionesR2 As String
    'Reporte 3
    Public tituloR3 As String
    Public descripcionR3 As String
    Public fprevistaR3 As String
    Public tecnicoR3 As String
    Public frealizadoR3 As String
    Public observacionesR3 As String
    'Reporte 4
    Public tituloR4 As String
    Public descripcionR4 As String
    Public fprevistaR4 As String
    Public tecnicoR4 As String
    Public frealizadoR4 As String
    Public observacionesR4 As String
    'Reporte 5 
    Public tituloR5 As String
    Public descripcionR5 As String
    Public fprevistaR5 As String
    Public tecnicoR5 As String
    Public frealizadoR5 As String
    Public observacionesR5 As String
    'Reporte 6
    Public tituloR6 As String
    Public descripcionR6 As String
    Public fprevistaR6 As String
    Public tecnicoR6 As String
    Public frealizadoR6 As String
    Public observacionesR6 As String
    'Reporte 7
    Public tituloR7 As String
    Public descripcionR7 As String
    Public fprevistaR7 As String
    Public tecnicoR7 As String
    Public frealizadoR7 As String
    Public observacionesR7 As String
    'Reporte 8
    Public tituloR8 As String
    Public descripcionR8 As String
    Public fprevistaR8 As String
    Public tecnicoR8 As String
    Public frealizadoR8 As String
    Public observacionesR8 As String
    'Reporte 9
    Public tituloR9 As String
    Public descripcionR9 As String
    Public fprevistaR9 As String
    Public tecnicoR9 As String
    Public frealizadoR9 As String
    Public observacionesR9 As String
    'Reporte 10
    Public tituloR10 As String
    Public descripcionR10 As String
    Public fprevistaR10 As String
    Public tecnicoR10 As String
    Public frealizadoR10 As String
    Public observacionesR10 As String
    'Reporte 11
    Public tituloR11 As String
    Public descripcionR11 As String
    Public fprevistaR11 As String
    Public tecnicoR11 As String
    Public frealizadoR11 As String
    Public observacionesR11 As String
    'Reporte 12
    Public tituloR12 As String
    Public descripcionR12 As String
    Public fprevistaR12 As String
    Public tecnicoR12 As String
    Public frealizadoR12 As String
    Public observacionesR12 As String
    'Reporte 13
    Public tituloR13 As String
    Public descripcionR13 As String
    Public fprevistaR13 As String
    Public tecnicoR13 As String
    Public frealizadoR13 As String
    Public observacionesR13 As String
    'Reporte 14
    Public tituloR14 As String
    Public descripcionR14 As String
    Public fprevistaR14 As String
    Public tecnicoR14 As String
    Public frealizadoR14 As String
    Public observacionesR14 As String
    'Reporte 15
    Public tituloR15 As String
    Public descripcionR15 As String
    Public fprevistaR15 As String
    Public tecnicoR15 As String
    Public frealizadoR15 As String
    Public observacionesR15 As String
    'Reporte 16
    Public tituloR16 As String
    Public descripcionR16 As String
    Public fprevistaR16 As String
    Public tecnicoR16 As String
    Public frealizadoR16 As String
    Public observacionesR16 As String
    'Reporte 17
    Public tituloR17 As String
    Public descripcionR17 As String
    Public fprevistaR17 As String
    Public tecnicoR17 As String
    Public frealizadoR17 As String
    Public observacionesR17 As String
    'Reporte 18
    Public tituloR18 As String
    Public descripcionR18 As String
    Public fprevistaR18 As String
    Public tecnicoR18 As String
    Public frealizadoR18 As String
    Public observacionesR18 As String
    'Reporte 19
    Public tituloR19 As String
    Public descripcionR19 As String
    Public fprevistaR19 As String
    Public tecnicoR19 As String
    Public frealizadoR19 As String
    Public observacionesR19 As String
    'Reporte 20
    Public tituloR20 As String
    Public descripcionR20 As String
    Public fprevistaR20 As String
    Public tecnicoR20 As String
    Public frealizadoR20 As String
    Public observacionesR20 As String
    'Reporte 21
    Public tituloR21 As String
    Public descripcionR21 As String
    Public fprevistaR21 As String
    Public tecnicoR21 As String
    Public frealizadoR21 As String
    Public observacionesR21 As String
    'Reporte 22
    Public tituloR22 As String
    Public descripcionR22 As String
    Public fprevistaR22 As String
    Public tecnicoR22 As String
    Public frealizadoR22 As String
    Public observacionesR22 As String
    'Reporte 23
    Public tituloR23 As String
    Public descripcionR23 As String
    Public fprevistaR23 As String
    Public tecnicoR23 As String
    Public frealizadoR23 As String
    Public observacionesR23 As String
    'Reporte 24
    Public tituloR24 As String
    Public descripcionR24 As String
    Public fprevistaR24 As String
    Public tecnicoR24 As String
    Public frealizadoR24 As String
    Public observacionesR24 As String
End Module








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.