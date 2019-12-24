Imports System.IO

Public Class FrmMenuPrincipal

    Friend Shared ID_USUARIO As Integer = 0
    Friend Shared ID_PERFIL As Integer = 0
    Friend Shared SITIO_USR As Integer = 0
    Friend Shared USUARIO As String = ""
    Friend Shared SUPER_USUARIO As String = ""
    Friend Shared NOMBRE_USUARIO As String = ""
    Friend Shared DB_HOST As String = ""

    'MENUES DEL USUARIO
    'MENU ACCESO
    Dim ACC_DEFINICION_MENUES As Boolean = False
    Dim ACC_DEFINICION_USUARIOS As Boolean = False
    Dim ACC_ASIGNACION_PERMISOS_USR As Boolean = False

    'MENU FUNDACIONAL
    Dim FUN_DEFINICION_SUCURSALES As Boolean = False
    Dim FUN_DEFINICION_PERIODOS_GESTION As Boolean = False
    Dim FUN_DEFINICION_PAISES As Boolean = False
    Dim FUN_DEFINICION_TERRITORIOS As Boolean = False
    Dim FUN_DEFINICION_CIUDADES As Boolean = False

    'MENU PRODUCTOS
    Dim PR_ACTIVAR_DESACTIVAR As Boolean = False
    Dim PR_PRODUCTOS_POR_LINEAS As Boolean = False
    Dim PR_RECARGO_PRODCUTOS As Boolean = False
    Dim PR_GENERAR_ARCHIVO_BALANZA As Boolean = False
    Dim PR_CAMBIO_PRECIO_VENTA As Boolean = False
    Dim PR_PRECIO_VENTA_APLICADOS As Boolean = False

    'MENU TESORERIA
    Dim TS_GASTOS_DIARIOS As Boolean = False
    Dim TS_CONTROLES_CAJA As Boolean = False

    'MENU INVENTARIO
    Dim IN_CARGA_INVENTARIO As Boolean = False
    Dim IN_GESTION_INVENTARIO As Boolean = False
    Dim IN_EXISTENCIA_PRODUCTOS As Boolean = False
    Dim IN_TRANSACCIONES_STOCK As Boolean = False

    'MENU VENTAS
    Dim VT_PROMOCIONES As Boolean = False

    'MENU CAJAS
    Dim CJ_CERRAR_CONTROLES As Boolean = False
    Dim CJ_BUSQUEDA_PRODUCTOS_CAJA As Boolean = False

    'MENU STOCK
    Dim ST_CONSUMO_MATERIA_PRIMA As Boolean = False
    Dim ST_REM_AL_CARGA_PRODUCTOS As Boolean = False
    Dim ST_REM_AL_GESTION_REMISIONES As Boolean = False
    Dim ST_REM_AL_RECEPCION_REMISIONES As Boolean = False

    'MENU REPORTES
    Dim RP_PRODUCTOS As Boolean = False
    Dim RP_VENTAS As Boolean = False
    Dim RP_COMPRAS As Boolean = False
    Dim RP_INVENTARIO As Boolean = False
    Dim RP_TESORERIA As Boolean = False


    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parametrosConexion()
        validarSesionUsuario()
        abrirForm(FrmLogin)
    End Sub

    Public Sub parametrosConexion()
        Try
            Dim directorio As String = My.Application.Info.DirectoryPath & "\Back365.txt"
            Dim objReader As New StreamReader(directorio)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()

            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()

            DB_HOST = arrText(0).ToString
        Catch ex As Exception
            ControlMensajes.mensaje("Error al obtener archivo de configuracion: " + ex.Message, "", "ERR")
        End Try
    End Sub

    Public Sub validarSesionUsuario()
        If ID_USUARIO <= 0 Then
            menuPrincipal.Visible = False
            StatusStrip.Visible = False
        Else
            reiniciarMenues()
            getMenuesUsuario()
            menuPrincipal.Visible = True
            StatusStrip.Visible = True
        End If

        statusLabel.Text = "EN LINEA: " & NOMBRE_USUARIO.ToUpper & "     SERVIDOR:" & DB_HOST
    End Sub

    Private Sub reiniciarMenues()
        'MENU ACCESO
        ACC_DEFINICION_MENUES = False
        ACC_DEFINICION_USUARIOS = False
        ACC_ASIGNACION_PERMISOS_USR = False

        'MENU FUNDACIONAL
        FUN_DEFINICION_SUCURSALES = False
        FUN_DEFINICION_PERIODOS_GESTION = False
        FUN_DEFINICION_PAISES = False
        FUN_DEFINICION_TERRITORIOS = False
        FUN_DEFINICION_CIUDADES = False

        'MENU PRODUCTOS
        PR_ACTIVAR_DESACTIVAR = False
        PR_PRODUCTOS_POR_LINEAS = False
        PR_RECARGO_PRODCUTOS = False
        PR_GENERAR_ARCHIVO_BALANZA = False
        PR_CAMBIO_PRECIO_VENTA = False
        PR_PRECIO_VENTA_APLICADOS = False

        'MENU TESORERIA
        TS_GASTOS_DIARIOS = False
        TS_CONTROLES_CAJA = False

        'MENU INVENTARIO
        IN_CARGA_INVENTARIO = False
        IN_GESTION_INVENTARIO = False
        IN_EXISTENCIA_PRODUCTOS = False
        IN_TRANSACCIONES_STOCK = False

        'MENU VENTAS
        VT_PROMOCIONES = False

        'MENU CAJAS
        CJ_CERRAR_CONTROLES = False
        CJ_BUSQUEDA_PRODUCTOS_CAJA = False

        'MENU STOCK
        ST_CONSUMO_MATERIA_PRIMA = False
        ST_REM_AL_CARGA_PRODUCTOS = False
        ST_REM_AL_GESTION_REMISIONES = False
        ST_REM_AL_RECEPCION_REMISIONES = False

        'MENU REPORTES
        RP_PRODUCTOS = False
        RP_VENTAS = False
        RP_COMPRAS = False
        RP_INVENTARIO = False
        RP_TESORERIA = False
    End Sub

    Private Sub getMenuesUsuario()
        If SUPER_USUARIO = "S" Then
            'MENU ACCESO
            ACC_DEFINICION_MENUES = True
            ACC_DEFINICION_USUARIOS = True
            ACC_ASIGNACION_PERMISOS_USR = True

            'MENU FUNDACIONAL
            FUN_DEFINICION_SUCURSALES = True
            FUN_DEFINICION_PERIODOS_GESTION = True
            FUN_DEFINICION_PAISES = True
            FUN_DEFINICION_TERRITORIOS = True
            FUN_DEFINICION_CIUDADES = True

            'MENU PRODUCTOS
            PR_ACTIVAR_DESACTIVAR = True
            PR_PRODUCTOS_POR_LINEAS = True
            PR_RECARGO_PRODCUTOS = True
            PR_GENERAR_ARCHIVO_BALANZA = True
            PR_CAMBIO_PRECIO_VENTA = True
            PR_PRECIO_VENTA_APLICADOS = True

            'MENU TESORERIA
            TS_GASTOS_DIARIOS = True
            TS_CONTROLES_CAJA = True

            'MENU INVENTARIO
            IN_CARGA_INVENTARIO = True
            IN_GESTION_INVENTARIO = True
            IN_EXISTENCIA_PRODUCTOS = True
            IN_TRANSACCIONES_STOCK = True

            'MENU VENTAS
            VT_PROMOCIONES = True

            'MENU CAJAS
            CJ_CERRAR_CONTROLES = True
            CJ_BUSQUEDA_PRODUCTOS_CAJA = True

            'MENU STOCK
            ST_CONSUMO_MATERIA_PRIMA = True
            ST_REM_AL_CARGA_PRODUCTOS = True
            ST_REM_AL_GESTION_REMISIONES = True
            ST_REM_AL_RECEPCION_REMISIONES = True

            'MENU REPORTES
            RP_PRODUCTOS = True
            RP_VENTAS = True
            RP_COMPRAS = True
            RP_INVENTARIO = True
            RP_TESORERIA = True
        Else
            Dim contFndUsuarios As New ContFndUsuarios
            Dim dt As New DataTable
            dt = contFndUsuarios.consultar("SELECT FND_MENUES.NOMBRE
                                        FROM FND_MENUES_USR ME
                                        INNER JOIN FND_MENUES ON FND_MENUES.IDENTIFICADOR = ME.ID_MENU
                                        WHERE ME.USUARIO='" & USUARIO & "'")



            For Each row As DataRow In dt.Rows
                'MENU ACCESO
                If CStr(row("NOMBRE")).ToUpper = "ACCESO - DEFINICION DE MENUES" Then
                    ACC_DEFINICION_MENUES = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "ACCESO - DEFINICION DE USUARIOS" Then
                    ACC_DEFINICION_USUARIOS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "ACCESO - ASIGNACION DE PERMISOS DE USUARIO" Then
                    ACC_ASIGNACION_PERMISOS_USR = True
                End If


                'MENU FUNDACIONAL
                If CStr(row("NOMBRE")).ToUpper = "FUNDACIONAL - DEFINICION DE SUCURSALES" Then
                    FUN_DEFINICION_SUCURSALES = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "FUNDACIONAL - DEFINICION DE PERIODOS DE GESTION" Then
                    FUN_DEFINICION_PERIODOS_GESTION = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "FUNDACIONAL - ASIGNACION DE PERMISOS DE PAISES" Then
                    FUN_DEFINICION_PAISES = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "FUNDACIONAL - DEFINICION DE TERRITORIOS" Then
                    FUN_DEFINICION_TERRITORIOS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "FUNDACIONAL - DEFINICION DE CIUDADES" Then
                    FUN_DEFINICION_CIUDADES = True
                End If

                'MENU PRODUCTOS
                If CStr(row("NOMBRE")).ToUpper = "PRODUCTOS - ACTIVAR/DESACTIVAR" Then
                    PR_ACTIVAR_DESACTIVAR = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "PRODUCTOS - PRODUCTOS POR LINEAS" Then
                    PR_PRODUCTOS_POR_LINEAS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "PRODUCTOS - RECARGO DE PRODUCTOS" Then
                    PR_RECARGO_PRODCUTOS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "PRODUCTOS - GENERAR ARCHIVO BALANZA" Then
                    PR_GENERAR_ARCHIVO_BALANZA = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "PRODUCTOS - ACTUALIZACION DE PRECIO DE VENTA" Then
                    PR_CAMBIO_PRECIO_VENTA = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "PRODUCTOS - PRECIOS DE VENTAS APLICADOS" Then
                    PR_PRECIO_VENTA_APLICADOS = True
                End If

                'MENU TESORERIA
                If CStr(row("NOMBRE")).ToUpper = "TESORERIA - GASTOS DIARIOS" Then
                    TS_GASTOS_DIARIOS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "TESORERIA - CONTROLES DE CAJA" Then
                    TS_CONTROLES_CAJA = True
                End If

                'MENU INVENTARIO
                If CStr(row("NOMBRE")).ToUpper = "INVENTARIO - CARGA DE INVENTARIO" Then
                    IN_CARGA_INVENTARIO = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "INVENTARIO - GESTION DE INVENTARIO" Then
                    IN_GESTION_INVENTARIO = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "INVENTARIO - EXISTENCIA DE PRODUCTOS" Then
                    IN_EXISTENCIA_PRODUCTOS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "INVENTARIO - TRANSACCIONES DE STOCK" Then
                    IN_TRANSACCIONES_STOCK = True
                End If

                'MENU VENTAS
                If CStr(row("NOMBRE")).ToUpper = "VENTAS - PROMOCIONES" Then
                    VT_PROMOCIONES = True
                End If

                'MENU CAJAS
                If CStr(row("NOMBRE")).ToUpper = "CAJAS - CERRAR CONTROLES" Then
                    CJ_CERRAR_CONTROLES = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "CAJAS - BUSQUEDA DE PRODUCTOS EN CAJA" Then
                    CJ_BUSQUEDA_PRODUCTOS_CAJA = True
                End If

                'MENU STOCK
                If CStr(row("NOMBRE")).ToUpper = "STOCK - CONSUMO DE MATERIA PRIMA" Then
                    ST_CONSUMO_MATERIA_PRIMA = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "STOCK - CARGA DE PRODUCTOS PARA REMISION A SUCRUSALES" Then
                    ST_REM_AL_CARGA_PRODUCTOS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "STOCK - GESTION DE REMISIONES A SUCRUSALES" Then
                    ST_REM_AL_GESTION_REMISIONES = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "STOCK - RECEPCION DE REMISION A SUCURSALES" Then
                    ST_REM_AL_RECEPCION_REMISIONES = True
                End If

                'MENU REPORTES
                If CStr(row("NOMBRE")).ToUpper = "REPORTES - REPORTES DE PRODUCTOS" Then
                    RP_PRODUCTOS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "REPORTES - REPORTES DE VENTAS" Then
                    RP_VENTAS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "REPORTES - REPORTES DE COMPRAS" Then
                    RP_COMPRAS = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "REPORTES - REPORTES DE INVENTARIO" Then
                    RP_INVENTARIO = True
                End If
                If CStr(row("NOMBRE")).ToUpper = "REPORTES - REPORTES DE TESORERIA" Then
                    RP_TESORERIA = True
                End If

            Next

        End If

        mostrarMenues()
    End Sub

    Private Sub mostrarMenues()
        'MENU ACCESO
        If ACC_DEFINICION_MENUES = False Then
            DefinicionDeMenuesToolStripMenuItem.Visible = False
        End If
        If ACC_DEFINICION_USUARIOS = False Then
            UsuariosToolStripMenuItem.Visible = False
        End If
        If ACC_ASIGNACION_PERMISOS_USR = False Then
            AsignacionDePermisosToolStripMenuItem.Visible = False
        End If


        'MENU FUNDACIONAL
        If FUN_DEFINICION_SUCURSALES = False Then
            DefinicionDeSucursalesToolStripMenuItem.Visible = False
        End If
        If FUN_DEFINICION_PERIODOS_GESTION = False Then
            PeriodosDeGestionToolStripMenuItem.Visible = False
        End If
        If FUN_DEFINICION_PAISES = False Then
            PaisesToolStripMenuItem.Visible = False
        End If
        If FUN_DEFINICION_TERRITORIOS = False Then
            TerritoriosToolStripMenuItem.Visible = False
        End If
        If FUN_DEFINICION_CIUDADES = False Then
            CiudadesToolStripMenuItem.Visible = False
        End If


        'MENU PRODUCTOS
        If PR_ACTIVAR_DESACTIVAR = False Then
            ActivarDesactivarToolStripMenuItem.Visible = False
        End If
        If PR_PRODUCTOS_POR_LINEAS = False Then
            LineasComercialesToolStripMenuItem.Visible = False
        End If
        If PR_RECARGO_PRODCUTOS = False Then
            RecargoDeProductosToolStripMenuItem.Visible = False
        End If
        If PR_GENERAR_ARCHIVO_BALANZA = False Then
            GenerarArchivoBalanzaToolStripMenuItem.Visible = False
        End If
        If PR_CAMBIO_PRECIO_VENTA = False Then
            CambioPrecioDeVentaToolStripMenuItem.Visible = False
        End If
        If PR_PRECIO_VENTA_APLICADOS = False Then
            PreciosDeVentaAplicadosToolStripMenuItem.Visible = False
        End If

        'MENU TESORERIA
        If TS_GASTOS_DIARIOS = False Then
            GastosDiariosToolStripMenuItem.Visible = False
        End If
        If TS_GASTOS_DIARIOS = False Then
            ControlesDeCajaToolStripMenuItem.Visible = False
        End If

        'MENU INVENTARIO
        If IN_CARGA_INVENTARIO = False Then
            CargaDeInventarioToolStripMenuItem.Visible = False
        End If
        If IN_GESTION_INVENTARIO = False Then
            GestionDeInventarioToolStripMenuItem.Visible = False
        End If
        If IN_EXISTENCIA_PRODUCTOS = False Then
            ExistenciaEnAlmcenesToolStripMenuItem.Visible = False
        End If
        If IN_TRANSACCIONES_STOCK = False Then
            TransaccionesDeInventarioToolStripMenuItem.Visible = False
        End If

        'MENU VENTAS
        If VT_PROMOCIONES = False Then
            PromocionesToolStripMenuItem1.Visible = False
        End If


        'MENU CAJAS
        If CJ_CERRAR_CONTROLES = False Then
            CerrarControlesToolStripMenuItem.Visible = False
        End If
        If CJ_BUSQUEDA_PRODUCTOS_CAJA = False Then
            BuscarProductosToolStripMenuItem.Visible = False
        End If


        'MENU STOCK
        If ST_CONSUMO_MATERIA_PRIMA = False Then
            ConsumoDeMateriaPrimaToolStripMenuItem.Visible = False
        End If
        If ST_REM_AL_CARGA_PRODUCTOS = False Then
            CargaDeProductosRemToolStripMenuItem.Visible = False
        End If
        If ST_REM_AL_GESTION_REMISIONES = False Then
            GestionDeTraspasosToolStripMenuItem.Visible = False
        End If
        If ST_REM_AL_RECEPCION_REMISIONES = False Then
            RecepcionDeProductosToolStripMenuItem1.Visible = False
        End If

        'MENU REPORTES

        If RP_PRODUCTOS = False Then
            ProductosToolStripMenuItem.Visible = False
        End If
        If RP_VENTAS = False Then
            VentasToolStripMenuItem.Visible = False
        End If
        If RP_COMPRAS = False Then
            ComprasToolStripMenuItem.Visible = False
        End If
        If RP_INVENTARIO = False Then
            InventarioToolStripMenuItem.Visible = False
        End If
        If RP_TESORERIA = False Then
            ArqueoDeCajasToolStripMenuItem.Visible = False
        End If

    End Sub

    Sub abrirForm(form As Form)
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarUsuarioToolStripMenuItem.Click
        abrirForm(FrmLogin)

        ID_USUARIO = 0
        ID_PERFIL = 0
        USUARIO = ""
        NOMBRE_USUARIO = ""

        validarSesionUsuario()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ActivarDesactivarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivarDesactivarToolStripMenuItem.Click
        abrirForm(FrmActivarDesactivarProducto)
    End Sub
    Private Sub LineasComercialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineasComercialesToolStripMenuItem.Click
        abrirForm(FrmPrLineasProd)
    End Sub

    Private Sub ProducToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abrirForm(FrmProductosPorFamilia)
    End Sub

    Private Sub RecargoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecargoDeProductosToolStripMenuItem.Click
        abrirForm(FrmRecargoProductos)
    End Sub

    Private Sub RecargoDePreciosPProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecargoDePreciosPProveedorToolStripMenuItem.Click
        abrirForm(FrmRptRecargoPreciosPorProveedor)
    End Sub

    Private Sub RecepcionDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepcionDeProductosToolStripMenuItem.Click
        abrirForm(FrmRptRecepcionProductos)
    End Sub

    Private Sub RecepcionDeProductosCMargenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepcionDeProductosCMargenToolStripMenuItem.Click
        abrirForm(FrmRptRecepcionProductosMargen)
    End Sub

    Private Sub UnileverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnileverToolStripMenuItem.Click
        abrirForm(FrmRptUnilever)
    End Sub

    Private Sub VentasPorFamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorFamiliaToolStripMenuItem.Click
        abrirForm(FrmRptVentasPorFamilia)
    End Sub

    Private Sub VentasPormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPormToolStripMenuItem.Click
        abrirForm(FrmRptVentasPorMarca)
    End Sub

    Private Sub PromocionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abrirForm(FrmAppPromociones)
    End Sub

    Private Sub CerrarControlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarControlesToolStripMenuItem.Click
        abrirForm(FrmCerrarControlCajas)
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abrirForm(FrmEnviarCorreo)
    End Sub

    Private Sub BuscarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProductosToolStripMenuItem.Click
        abrirForm(FrmBuscarEnCaja)
    End Sub

    Private Sub ConsumoDeMateriaPrimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumoDeMateriaPrimaToolStripMenuItem.Click
        abrirForm(FrmConsumoMateriaPrima)
    End Sub

    Private Sub VentasDeProductosPorFamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasDeProductosPorFamiliasToolStripMenuItem.Click
        abrirForm(Frm_consultas_varias)
    End Sub

    Private Sub ProveedoresPorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresPorMesToolStripMenuItem.Click
        abrirForm(FrmRptComprasProveedorMeses)
    End Sub

    Private Sub PeriodosDeGestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeriodosDeGestionToolStripMenuItem.Click
        abrirForm(FrmFndPeriodosGestion)
    End Sub

    Private Sub PaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisesToolStripMenuItem.Click
        abrirForm(FrmFndPaises)
    End Sub

    Private Sub TerritoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerritoriosToolStripMenuItem.Click
        abrirForm(FrmFndTerritorios)
    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        abrirForm(FrmFndCiudades)
    End Sub

    Private Sub DefinicionDeSucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinicionDeSucursalesToolStripMenuItem.Click
        abrirForm(FrmFndSitios)
    End Sub

    Private Sub CargaDeProductosRemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaDeProductosRemToolStripMenuItem.Click
        abrirForm(FrmTraspasoProductosSuc)
    End Sub

    Private Sub GestionDeTraspasosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeTraspasosToolStripMenuItem.Click
        abrirForm(FrmGestionTraspasosProdSuc)
    End Sub

    Private Sub RecepcionDeProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecepcionDeProductosToolStripMenuItem1.Click
        abrirForm(FrmRecepcionProdSuc)
    End Sub

    Private Sub ExistenciaPorAlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciaPorAlmacenesToolStripMenuItem.Click
        abrirForm(FrmRptExistenciaPorAlmacenes)
    End Sub

    Private Sub DefinicionDeMenuesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DefinicionDeMenuesToolStripMenuItem.Click
        abrirForm(FrmFndMenues)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        abrirForm(FrmFndUsuarios)
    End Sub

    Private Sub AsignacionDePermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionDePermisosToolStripMenuItem.Click
        abrirForm(FrmAsignacionPermisosUsuario)
    End Sub

    Private Sub GenerarArchivoBalanzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarArchivoBalanzaToolStripMenuItem.Click
        abrirForm(FrmGenerarArchivoBalanza)
    End Sub

    Private Sub CambioPrecioDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioPrecioDeVentaToolStripMenuItem.Click
        abrirForm(FrmCambioPrecioVenta)
    End Sub

    Private Sub AToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        abrirForm(FrmActualizarPrecioRemision)
    End Sub

    Private Sub ArqueoDeCajasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ArqueoDeCajasToolStripMenuItem.Click
        abrirForm(FrmRptArqueoCajas)
    End Sub

    Private Sub GastosDiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosDiariosToolStripMenuItem.Click
        abrirForm(FrmCargaGastosDiarios)
    End Sub

    Private Sub PreciosDeVentaAplicadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosDeVentaAplicadosToolStripMenuItem.Click
        abrirForm(FrmPreciosVentaAplicados)
    End Sub

    Private Sub MatrizDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizDeProveedoresToolStripMenuItem.Click
        abrirForm(FrmRptPrMatrizProveedores)
    End Sub

    Private Sub RankingDeProductosVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RankingDeProductosVendidosToolStripMenuItem.Click
        abrirForm(FrmRptRankingProdVendidos)
    End Sub

    Private Sub PromocionesPorComprobantesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abrirForm(FrmAppVtaPromociones)
    End Sub

    Private Sub ExistenciaEnAlmcenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciaEnAlmcenesToolStripMenuItem.Click
        abrirForm(FrmExistenciasProducto)
    End Sub

    Private Sub TransaccionesDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaccionesDeInventarioToolStripMenuItem.Click
        abrirForm(frm_transacciones_inventario)
    End Sub

    Private Sub ControlesDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlesDeCajaToolStripMenuItem.Click
        abrirForm(FrmTcControlCaja)
    End Sub

    Private Sub CargaDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaDeInventarioToolStripMenuItem.Click
        abrirForm(FrmTomaInventario)
    End Sub

    Private Sub GestionDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeInventarioToolStripMenuItem.Click
        abrirForm(FrmTomaInventarioGestion)
    End Sub


    Private Sub PromocionesPorProveedorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PromocionesPorProveedorToolStripMenuItem1.Click
        abrirForm(FrmAppPromocionesProv)
    End Sub

    Private Sub PromocionesPorMontoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesPorMontoToolStripMenuItem.Click
        abrirForm(FrmAppVtaPromociones)
    End Sub

    Private Sub PromocionesDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesDeProductosToolStripMenuItem.Click
        abrirForm(FrmAppPromociones)
    End Sub

    Private Sub GenerarListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarListadoDeProductosToolStripMenuItem.Click
        abrirForm(FrmGenerarListaProd)
    End Sub
End Class