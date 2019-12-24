Public Class FrmFndSitios


    Dim contFndSitios As New ContFndSitios

    Dim identificador As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idEmpresa As Integer = 0
    Dim idPais As Integer = 0
    Dim idCiudad As Integer = 0
    Dim titulo As String = "Mensaje"

    Private Sub FrmFndSitios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Sub limpiar()
        identificador = 0
        idUnidad = 0
        idEmpresa = 0
        idPais = 0
        idCiudad = 0
        txtUnidadOperat.Text = ""
        txtDescripcion.Text = ""
        txtPais.Text = ""
        txtCiudad.Text = ""
        txtDireccion.Text = ""
        txtCodCtrlComprob.Text = ""
    End Sub

    Sub listar()
        Dim dt As New DataTable
        dt = contFndSitios.consultar("SELECT SI.IDENTIFICADOR, CO_UNIDADES_OPERAT.DESCRIPCION AS UNIDAD,
                                    FND_PAISES.NOMBRE AS PAIS, FND_CIUDADES.NOMBRE, SI.DIRECCION, SI.CODIGO_CTRL_COMP
                                    FROM FND_SITIOS SI
                                    INNER JOIN CO_UNIDADES_OPERAT ON CO_UNIDADES_OPERAT.IDENTIFICADOR = SI.ID_UNIDAD
                                    INNER JOIN FND_PAISES ON FND_PAISES.IDENTIFICADOR = SI.ID_PAIS
                                    INNER JOIN FND_CIUDADES ON FND_CIUDADES.IDENTIFICADOR = SI.ID_CIUDAD
                                    ORDER BY CO_UNIDADES_OPERAT.DESCRIPCION ASC, SI.IDENTIFICADOR ASC")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        End If
    End Sub

    Sub getsitio(id As Integer)
        Dim dt As New DataTable
        dt = contFndSitios.consultar("SELECT IDENTIFICADOR, ID_UNIDAD, ID_PAIS, ID_CIUDAD, DESCRIPCION, DIRECCION, CODIGO_CTRL_COMP 
                                        FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            identificador = CInt(dt.Rows(0).Item(0))
            getUnidadOperat(CInt(dt.Rows(0).Item(1)))
            getPais(CInt(dt.Rows(0).Item(2)))
            getCiudad(CInt(dt.Rows(0).Item(3)))
            txtDescripcion.Text = CStr(dt.Rows(0).Item(4))
            txtDireccion.Text = CStr(dt.Rows(0).Item(5))
            txtCodCtrlComprob.Text = CStr(dt.Rows(0).Item(6))
        End If
    End Sub

    Sub getUnidadOperat(id As Integer)
        Dim dt As New DataTable
        dt = contFndSitios.consultar("SELECT IDENTIFICADOR, ID_EMPRESA, NOMBRE FROM CO_UNIDADES_OPERAT WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idUnidad = CInt(dt.Rows(0).Item(0))
            idEmpresa = CInt(dt.Rows(0).Item(1))
            txtUnidadOperat.Text = CStr(dt.Rows(0).Item(2))
        End If
    End Sub

    Sub getPais(id As Integer)
        Dim dt As New DataTable
        dt = contFndSitios.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PAISES WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idPais = CInt(dt.Rows(0).Item(0))
            txtPais.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getCiudad(id As Integer)
        Dim dt As New DataTable
        dt = contFndSitios.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_CIUDADES WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idCiudad = CInt(dt.Rows(0).Item(0))
            txtCiudad.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Function validarCampos() As Boolean
        If idUnidad <= 0 Then
            ControlMensajes.mensaje("El campo unidad operativa no puede estar vacio", titulo, "WAR")
            txtPais.Focus()
            Return False
        End If
        If Util.eliminarEspacios(txtDescripcion.Text) Then
            ControlMensajes.mensaje("El campo descripcion no puede estar vacio", titulo, "WAR")
            txtDescripcion.Focus()
            Return False
        End If
        If idPais <= 0 Then
            ControlMensajes.mensaje("El campo paisno puede estar vacio", titulo, "WAR")
            txtPais.Focus()
            Return False
        End If
        If idCiudad <= 0 Then
            ControlMensajes.mensaje("El campo ciudad no puede estar vacio", titulo, "WAR")
            txtPais.Focus()
            Return False
        End If
        If Util.eliminarEspacios(txtDireccion.Text) Then
            ControlMensajes.mensaje("El campo direccion no puede estar vacio", titulo, "WAR")
            txtDescripcion.Focus()
            Return False
        End If
        If Util.eliminarEspacios(txtCodCtrlComprob.Text) Then
            ControlMensajes.mensaje("El campo codigo comprobante no puede estar vacio", titulo, "WAR")
            txtDescripcion.Focus()
            Return False
        End If

        Return True
    End Function


    Sub insertar()
        If validarCampos() Then
            Dim descripcion As String = txtDescripcion.Text
            Dim direccion As String = txtDireccion.Text
            Dim codigo As String = txtCodCtrlComprob.Text
            identificador = contFndSitios.getIdentificador()

            If contFndSitios.insertar(identificador, descripcion, idEmpresa, idUnidad, direccion, codigo) Then
                ControlMensajes.mensaje("Sucursal registrada", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Sucursal no registrada", titulo, "WAR")
            End If
        End If
    End Sub


    Sub actiualizar()
        If validarCampos() Then
            Dim descripcion As String = txtDescripcion.Text
            Dim direccion As String = txtDireccion.Text
            Dim codigo As String = txtCodCtrlComprob.Text

            If contFndSitios.actualizar(descripcion, idEmpresa, idUnidad, direccion, codigo, identificador) Then
                ControlMensajes.mensaje("Sucursal actualizada", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Sucursal no actualizada", titulo, "WAR")
            End If
        End If
    End Sub

    Sub aceptar()
        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion?", titulo) Then
            If identificador > 0 Then
                actiualizar()
            Else
                insertar()
            End If
        Else
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "INF")
        End If
    End Sub

    Sub cancelar()
        If ControlMensajes.msj_confirmacion("Deseas cancelar la operacion?", titulo) Then
            limpiar()
            txtUnidadOperat.Focus()
        End If
    End Sub


    Sub listarUnidades()
        Dim frm As New FrmVistaCoUnidadesOperat
        frm.setFrmActivo("FrmFndSitios")
        frm.setFrmFndSitios(Me)
        frm.ShowDialog()
    End Sub
    Sub listarPaises()
        Dim frm As New FrmVistaFndPaises
        frm.setFrmActivo("FrmFndSitios")
        frm.setFrmFndSitios(Me)
        frm.ShowDialog()
    End Sub

    Sub listarCiudades()
        Dim frm As New FrmVistaFndCiudades
        frm.setFrmActivo("FrmFndSitios")
        frm.setFrmFndSitios(Me)
        frm.ShowDialog()
    End Sub

    Private Sub txtUnidadOperat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnidadOperat.KeyDown
        If e.KeyCode = Keys.Enter And idUnidad > 0 Then
            txtDescripcion.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarUnidades()
        End If
    End Sub

    Private Sub btnUnidadesOperat_Click(sender As Object, e As EventArgs) Handles btnUnidadesOperat.Click
        listarUnidades()
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtDescripcion.Text) IsNot "" Then
            txtPais.Focus()
        End If
    End Sub

    Private Sub txtPais_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPais.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtPais.Text) IsNot "" Then
            txtCiudad.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarPaises()
        End If
    End Sub

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        listarPaises()
    End Sub

    Private Sub txtCiudad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCiudad.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtCiudad.Text) IsNot "" Then
            txtDireccion.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarCiudades()
        End If
    End Sub

    Private Sub btnCiudades_Click(sender As Object, e As EventArgs) Handles btnCiudades.Click
        listarCiudades()
    End Sub

    Private Sub txtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDireccion.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtDireccion.Text) IsNot "" Then
            txtCodCtrlComprob.Focus()
        End If
    End Sub

    Private Sub txtCodCtrlComprob_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCtrlComprob.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtCodCtrlComprob.Text) IsNot "" Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        aceptar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If GridView1.RowCount > 0 Then
            Dim filter As String = ""
            filter = "UNIDAD LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR DESCRIPCION LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR PAIS LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR CIUDAD LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR DIRECCION LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR CODIGO_CTRL_COMP LIKE '%" & txtBuscar.Text & "%' "

            Dim dv As DataView
            dv = gridListado.DataSource.DefaultView
            dv.RowFilter = filter
            gridListado.DataSource = dv
        End If
    End Sub

    Private Sub gridListado_DoubleClick(sender As Object, e As EventArgs) Handles gridListado.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim id As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR"))
        getPais(id)
    End Sub

End Class