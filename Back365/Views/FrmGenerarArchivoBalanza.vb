Public Class FrmGenerarArchivoBalanza

    Dim contPrProductos As New ContPrProductos
    Dim dt As New DataTable
    Dim titulo As String = ""
    Dim idSitio As Integer = 0

    Private Sub FrmGenerar_ArchivoBalanza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        idSitio = 0
        txtSucursal.Text = ""

        dt = Nothing
        gridProductos.DataSource = dt
    End Sub

    Sub listarSucursales()
        Dim frm As New FrmVistaFndSitios
        frm.setFrmActivo("FrmGenerarArchivoBalanza")
        frm.setFrmGenerarArchivoBalanza(Me)
        frm.ShowDialog()
    End Sub

    Sub getSitio(id As Integer)
        Dim dt As New DataTable
        dt = contPrProductos.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub consultar()
        If idSitio <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar sucursal", titulo, "WAR")
            txtSucursal.Focus()
            Return
        End If

        dt = contPrProductos.consultar("select  TRIM(codigo_balanza || unidad_medida) as codigo_balanza, descripcion, precio_nuevo || '1999' as precio, precio_nuevo as precio_venta  from 
                                            (
                                                select 
                                                    CASE ID_CATEGORIA WHEN 1663 THEN LPAD(codigo_balanza,6,400)else LPAD(codigo_balanza,6,0) end AS CODIGO_BALANZA,
                                                    CASE id_categoria WHEN 1663 THEN 'U'  else 'P' end as unidad_medida,substr(descripcion,1,23)as descripcion,
                                                    id_auditoria
                                                from pr_productos a, 
                                                (
                                                    select id_producto,max(identificador)as id_auditoria from pr_aud_cambios_prec where id_sitio=" & CStr(idSitio) & " GROUP BY id_producto
                                                )b
                                                where a.identificador=b.id_producto and a.Activo='S' and a.codigo_balanza is not null
                                            )xx
                                            LEFT JOIN pr_aud_cambios_prec on pr_aud_cambios_prec.identificador = id_auditoria")

        If dt.Rows.Count > 0 Then
            gridProductos.DataSource = dt
        Else
            ControlMensajes.mensaje("Productos no definidos", titulo, "WAR")
        End If

    End Sub

    Sub generarArchivoTxt()
        Dim obj As New Object
        Dim archivo As New Object
        Dim ruta As String = "\\192.168.10.10\Datos\exe\CADTXT.TXT"
        'Dim ruta As String = "D:\CADTXT.TXT"

        obj = CreateObject("Scripting.FileSystemObject")
        archivo = obj.CreateTextFile(ruta, True)

        Dim codigo As String = ""
        Dim codigoformateado As String = ""
        Dim descripcion As String = ""
        Dim descripcionCorta As String = ""
        Dim precio As String = ""
        Dim precioFormateado As String = ""


        For i As Integer = 0 To GridView1.RowCount - 1
            codigo = CStr(GridView1.GetRowCellValue(i, "CODIGO_BALANZA"))
            If codigo.Length < 7 Then
                Dim ceros As String = ""

                For j As Integer = 1 To 7 - codigo.Length
                    ceros += "0"
                Next

                codigoformateado = ceros & codigo
            Else
                codigoformateado = codigo
            End If

            descripcion = CStr(GridView1.GetRowCellValue(i, "DESCRIPCION"))
            If descripcion.Length > 22 Then
                descripcionCorta = descripcion.Substring(0, 22)
            Else
                If descripcion.Length < 22 Then
                    descripcionCorta = descripcion

                    For j As Integer = 1 To 22 - descripcion.Length
                        descripcionCorta += " "
                    Next
                Else
                    descripcionCorta = descripcion
                End If
            End If

            precio = CStr(GridView1.GetRowCellValue(i, "PRECIO"))
            If precio.Length < 10 Then
                Dim ceros As String = ""

                For j As Integer = 1 To 10 - precio.Length
                    ceros += "0"
                Next

                precioFormateado = ceros & precio
            Else
                precioFormateado = precio
            End If

            archivo.WriteLine(codigoformateado & descripcionCorta & precioFormateado)
        Next

        archivo.close()
        ControlMensajes.mensaje("Archivo generado", titulo, "INF")
    End Sub


    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter And idSitio > 0 Then
            btnGenerar.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            listarSucursales()
        End If
    End Sub

    Private Sub btnSucursales_Click(sender As Object, e As EventArgs) Handles btnSucursales.Click
        listarSucursales()
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        generarArchivoTxt()
    End Sub

End Class