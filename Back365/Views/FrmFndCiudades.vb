Public Class FrmFndCiudades

    Dim contFndTerritorios As New ContFndTerritorios

    Dim identificador As Integer = 0
    Dim idTerritorio As Integer = 0
    Dim titulo As String = "Mensaje"

    Private Sub FrmFndCiudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Sub limpiar()
        identificador = 0
        idTerritorio = 0
        txtTerritorio.Text = ""
        txtNombre.Text = ""
        txtAbreviatura.Text = ""
    End Sub

    Sub listar()
        Dim dt As New DataTable
        dt = contFndTerritorios.consultar("SELECT CI.IDENTIFICADOR, FND_TERRITORIOS.NOMBRE AS PAIS, CI.NOMBRE, CI.ABREVIATURA
                                        FROM FND_CIUDADES CI 
                                        INNER JOIN FND_TERRITORIOS ON FND_TERRITORIOS.IDENTIFICADOR = CI.ID_TERRITORIO
                                        ORDER BY FND_TERRITORIOS.NOMBRE ASC, CI.NOMBRE ASC")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        End If
    End Sub

    Sub getCiudad(id As Integer)
        Dim dt As New DataTable
        dt = contFndTerritorios.consultar("SELECT IDENTIFICADOR, ID_TERRITORIO, NOMBRE, ABREVIATURA FROM FND_CIUDADES  WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            identificador = CInt(dt.Rows(0).Item(0))
            getTerritorio(CInt(dt.Rows(0).Item(1)))
            txtNombre.Text = CStr(dt.Rows(0).Item(2))
            txtAbreviatura.Text = CStr(dt.Rows(0).Item(3))
        End If
    End Sub

    Sub getTerritorio(id As Integer)
        Dim dt As New DataTable
        dt = contFndTerritorios.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_TERRITORIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idTerritorio = CInt(dt.Rows(0).Item(0))
            txtTerritorio.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Function validarCampos() As Boolean
        If idTerritorio <= 0 Then
            ControlMensajes.mensaje("El campo territorio no puede estar vacio", titulo, "WAR")
            txtTerritorio.Focus()
            Return False
        End If
        If Util.eliminarEspacios(txtNombre.Text) Then
            ControlMensajes.mensaje("El campo nombre no puede estar vacio", titulo, "WAR")
            txtNombre.Focus()
            Return False
        End If

        Return True
    End Function


    Sub insertar()
        If validarCampos() Then
            Dim nombre As String = txtNombre.Text
            Dim abreviatura As String = txtAbreviatura.Text
            identificador = contFndTerritorios.getIdentificador()

            If contFndTerritorios.insertar(identificador, idTerritorio, nombre, abreviatura) Then
                ControlMensajes.mensaje("Territorio registrado", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Territorio no registrado", titulo, "WAR")
            End If
        End If
    End Sub


    Sub actiualizar()
        If validarCampos() Then
            Dim nombre As String = txtNombre.Text
            Dim abreviatura As String = txtAbreviatura.Text

            If contFndTerritorios.insertar(identificador, idTerritorio, nombre, abreviatura) Then
                ControlMensajes.mensaje("Territorio actualizado", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Territorio no actualizado", titulo, "WAR")
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
            txtNombre.Focus()
        End If
    End Sub


    Sub listarTerritorios()
        Dim frm As New FrmVistaFndTerritorios
        frm.setFrmActivo("FrmFndCiudades")
        frm.setFrmFndCiudades(Me)
        frm.ShowDialog()
    End Sub

    Private Sub txtTerritorio_Properties_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTerritorio.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtTerritorio.Text) IsNot "" Then
            txtNombre.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then

        End If
    End Sub

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnTerritorios.Click

    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtNombre.Text) IsNot "" Then
            txtAbreviatura.Focus()
        End If
    End Sub

    Private Sub txtAbreviatura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAbreviatura.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtAbreviatura.Text) IsNot "" Then
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
            Dim dv As DataView
            dv = gridListado.DataSource.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%' OR ABREVIATURA LIKE '%" & txtBuscar.Text & "%'"
            gridListado.DataSource = dv
        End If
    End Sub

    Private Sub gridListado_DoubleClick(sender As Object, e As EventArgs) Handles gridListado.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim id As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR"))
        getCiudad(id)
    End Sub

End Class