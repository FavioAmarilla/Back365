Public Class FrmFndMenues

    Dim contFndMenues As New ContFndMenues

    Dim identificador As Integer = 0
    Dim titulo As String = "Mensaje"

    Private Sub FrmFndMenues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Sub limpiar()
        identificador = 0
        txtNombre.Text = ""
        txtDescripcion.Text = ""
    End Sub

    Sub listar()
        Dim dt As New DataTable
        dt = contFndMenues.consultar("SELECT IDENTIFICADOR, NOMBRE, DESCRIPCION 
                                        FROM FND_MENUES 
                                        ORDER BY FEC_CRE DESC, NOMBRE ASC")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
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
            Dim descripcion As String = txtDescripcion.Text
            identificador = contFndMenues.getIdMenu()

            If contFndMenues.insertar(identificador, nombre, descripcion) Then
                ControlMensajes.mensaje("Menu registrado", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Menu no registrado", titulo, "WAR")
            End If
        End If
    End Sub


    Sub aceptar()
        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion?", titulo) Then
            insertar()
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

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtNombre.Text) IsNot "" Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtNombre.Text) IsNot "" Then
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
            dv.RowFilter = "NOMBRE LIKE '%" & txtBuscar.Text & "%' OR DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
            gridListado.DataSource = dv
        End If
    End Sub

End Class