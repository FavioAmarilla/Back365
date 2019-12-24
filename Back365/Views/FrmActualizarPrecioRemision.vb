Public Class FrmActualizarPrecioRemision

    Dim contPsPreciosAplicar As New ContPsPreciosAplicar
    Dim contAudiCambioPrecio As New ContPrAudCambiosPrec
    Dim contProducto As New ContPrProductos
    Dim contUmProducto As New ContPrUmProducto

    Dim dt As New DataTable

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        dt = contPsPreciosAplicar.consultar("SELECT  id_producto, id_proveedor, codigo_barras, id_und_medida, precio_venta FROM APP_ITEMS_REMISION WHERE FEC_CRE >= TO_DATE('30/05/2019','dd/MM/yyyy')")
        GridControl1.DataSource = dt
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim idEmpresa As Integer = 1
        Dim idUnidad As Integer = 1
        Dim idSitio As Integer = 2
        Dim idproducto As Integer = 0
        Dim idUnidadMedida As Integer = 0
        Dim idCaja As Integer = 0
        Dim precioNuevo As Integer = 0
        Dim fechaAplicacion As String = 0
        Dim precioAnterior As Integer = 0
        Dim codigoBarras As String = ""


        For i As Integer = 0 To dt.Rows.Count - 1
            idproducto = CInt(dt.Rows(i).Item(0))
            idUnidadMedida = CInt(dt.Rows(i).Item(3))
            precioNuevo = CInt(dt.Rows(i).Item(4))
            fechaAplicacion = Now.ToString("dd/MM/yyyy hh:mm:ss")
            precioAnterior = 0
            codigoBarras = CStr(dt.Rows(i).Item(2))


            'Dim dtCajas As New DataTable
            'dtCajas = contPsPreciosAplicar.consultar("SELECT IDENTIFICADOR FROM TC_CAJAS WHERE ID_SITIO=" & idSitio & " ORDER BY NUMERO ASC")
            'If dtCajas.Rows.Count > 0 Then
            '    For c As Integer = 0 To dtCajas.Rows.Count - 1
            '        Dim id As Integer = contPsPreciosAplicar.identificador()
            '        idCaja = CInt(dtCajas.Rows(c).Item(0))
            '        If contPsPreciosAplicar.insertarPrecioAplicar(id, idEmpresa, idUnidad, idSitio, idproducto, idUnidadMedida, idCaja, precioNuevo, fechaAplicacion, precioAnterior, codigoBarras) = False Then
            '            ControlMensajes.mensaje("Precio a aplicar no registrado", "", "WAR")
            '            Return
            '        End If
            '    Next
            'Else
            '    ControlMensajes.mensaje("No se encontraron cajas", "", "WAR")
            '    Return
            'End If

            'Se registra la auditoria de cambio de precio
            Dim idAudCambioPrecio = contAudiCambioPrecio.identificador()
            If contAudiCambioPrecio.insertarAudCambio(idproducto, idUnidadMedida, "PV", precioNuevo, CStr(fechaAplicacion), precioAnterior, 0, "APPTRADE", codigoBarras, "N", 0, "S", idEmpresa, idUnidad, idSitio, idAudCambioPrecio, fechaAplicacion) = False Then
                ControlMensajes.mensaje("Auditoria de cambio de precio no registrado", "", "WAR")
                Return
            End If


            'Se actualizan los precios de ventas

            If contProducto.actualizarPrecioVenta(idproducto, precioNuevo) = False Then
                ControlMensajes.mensaje("Precio Venta no actualizado", "", "WAR")
                Return
            End If

            If contUmProducto.actualizarPrecioVenta(idproducto, precioNuevo) = False Then
                ControlMensajes.mensaje("Precio Venta no actualizado (UM)", "", "WAR")
                Return
            End If

        Next

        ControlMensajes.mensaje("Precios aplicados", "", "INF")

    End Sub
End Class