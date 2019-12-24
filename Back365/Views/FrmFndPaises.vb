Public Class FrmFndPaises

    Dim contfndPaises As New ContFndPaises

    Dim identificador As Integer = 0
    Dim titulo As String = "Mensaje"

    Private Sub FrmFndPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Sub limpiar()
        identificador = 0
        txtNombre.Text = ""
        txtAbreviatura.Text = ""
    End Sub

    Sub listar()
        Dim dt As New DataTable
        dt = contfndPaises.consultar("SELECT IDENTIFICADOR, NOMBRE, ABREVIATURA FROM FND_PAISES ORDER BY NOMBRE ASC")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        End If
    End Sub

    Sub getPais(id As Integer)
        Dim dt As New DataTable
        dt = contfndPaises.consultar("SELECT IDENTIFICADOR, NOMBRE, ABREVIATURA FROM FND_PAISES WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            identificador = CInt(dt.Rows(0).Item(0))
            txtNombre.Text = CStr(dt.Rows(0).Item(1))
            txtAbreviatura.Text = CStr(dt.Rows(0).Item(2))
        End If
    End Sub

    Function validarCampos() As Boolean
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
            identificador = contfndPaises.getIdentificador()

            If contfndPaises.insertar(identificador, nombre, abreviatura) Then
                ControlMensajes.mensaje("Pais registrado", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Pais no registrado", titulo, "WAR")
            End If
        End If
    End Sub


    Sub actiualizar()
        If validarCampos() Then
            Dim nombre As String = txtNombre.Text
            Dim abreviatura As String = txtAbreviatura.Text

            If contfndPaises.actualizar(identificador, nombre, abreviatura) Then
                ControlMensajes.mensaje("Pais actualizado", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Pais no actualizado", titulo, "WAR")
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

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
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
        getPais(id)
    End Sub
End Class