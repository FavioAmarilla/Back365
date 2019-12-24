Public Class FrmFndUsuarios

    Dim contFndUsuario As New ContFndUsuarios
    Dim dtUsuarios As New DataTable
    Dim titulo As String = "Definicion de usuarios"

    Dim identificador As Integer = 0
    Dim idPerfil As Integer = 0

    Private Sub FrmFndUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Sub limpiar()
        identificador = 0
        idPerfil = 0
        txtNombreCompleto.Text = ""
        txtPerfil.Text = ""
        txtUsuario.Text = ""
        txtClave.Text = ""
        chkActivo.Checked = False
    End Sub

    Sub listar()
        Dim dt As New DataTable
        dt = contFndUsuario.consultar("Select US.IDENTIFICADOR, US.NOMBRE_COMPLETO, US.NOMBRE, FND_PERFILES.NOMBRE AS PERFIL, US.ACTIVO
                                        FROM FND_USUARIOS US
                                        INNER JOIN FND_PERFILES ON FND_PERFILES.IDENTIFICADOR = US.ID_PERFIL
                                        ORDER BY US.FEC_CRE DESC")

        gridListado.DataSource = dt
    End Sub

    Sub getPerfil(id As Integer)
        Dim dt As New DataTable
        dt = contFndUsuario.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PERFILES WHERE IDENTIFICADOR=" & CStr(id))

        If dt.Rows.Count > 0 Then
            idPerfil = CInt(dt.Rows(0).Item(0))
            txtPerfil.Text = CStr(dt.Rows(0).Item(1))
        Else
            ControlMensajes.mensaje("Perfil no definido", titulo, "WAR")
        End If
    End Sub

    Sub getUsuario(id As Integer)
        Dim dt As New DataTable
        dt = contFndUsuario.consultar("SELECT IDENTIFICADOR, NOMBRE_COMPLETO, ID_PERFIL, NOMBRE, CLAVE_ACCESO, ACTIVO
                                        FROM FND_USUARIOS WHERE IDENTIFICADOR=" & CStr(id))

        If dt.Rows.Count > 0 Then
            identificador = CInt(dt.Rows(0).Item(0))
            txtNombreCompleto.Text = CStr(dt.Rows(0).Item(1))
            getPerfil(CInt(dt.Rows(0).Item(2)))
            txtUsuario.Text = CStr(dt.Rows(0).Item(3))
            txtClave.Text = CStr(dt.Rows(0).Item(4))
        Else
            ControlMensajes.mensaje("Usuario no definido", titulo, "WAR")
        End If
    End Sub

    Sub listarUsuario()
        Dim frm As New FrmVistaFndPerfiles
        frm.setFrmActivo("FrmFndUsuarios")
        frm.setFrmFndUsuarios(Me)
        frm.ShowDialog()
    End Sub

    Function validarCampos() As Boolean
        If Util.eliminarEspacios(txtNombreCompleto.Text) = "" Then
            ControlMensajes.mensaje("El campo nombre completo no puede estar vacio", titulo, "WAR")
            txtNombreCompleto.Focus()
            Return False
        End If
        If idPerfil <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar perfil del usuario", titulo, "WAR")
            txtNombreCompleto.Focus()
            Return False
        End If
        If Util.eliminarEspacios(txtUsuario.Text) = "" Then
            ControlMensajes.mensaje("El campo usuario no puede estar vacio", titulo, "WAR")
            txtUsuario.Focus()
            Return False
        End If
        If Util.eliminarEspacios(txtClave.Text) = "" Then
            ControlMensajes.mensaje("El campo clave de acceso no puede estar vacio", titulo, "WAR")
            txtClave.Focus()
            Return False
        End If

        Return True
    End Function

    Sub insertar()
        If validarCampos() Then
            Dim nombreCompleto As String = txtNombreCompleto.Text
            Dim nombre As String = txtUsuario.Text
            Dim claveAcceso As String = txtClave.Text
            Dim activo As String = "S"

            If chkActivo.Checked Then
                activo = "S"
            Else
                activo = "N"
            End If

            If contFndUsuario.insertarUsuario(nombreCompleto, idPerfil, nombre, claveAcceso, activo) Then
                ControlMensajes.mensaje("Usuario registrado", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Usuario no registrado", titulo, "WAR")
            End If

        End If
    End Sub

    Sub actualizar()
        If validarCampos() Then
            Dim nombreCompleto As String = txtNombreCompleto.Text
            Dim nombre As String = txtUsuario.Text
            Dim claveAcceso As String = txtClave.Text
            Dim activo As String = "S"

            If chkActivo.Checked Then
                activo = "S"
            Else
                activo = "N"
            End If

            If contFndUsuario.actualizarUsuario(identificador, nombreCompleto, idPerfil, nombre, claveAcceso, activo) Then
                ControlMensajes.mensaje("Usuario actualizado", titulo, "INF")
                limpiar()
                listar()
            Else
                ControlMensajes.mensaje("Usuario no actualizado", titulo, "WAR")
            End If

        End If
    End Sub
    Sub aceptar()
        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion?", titulo) Then
            If identificador > 0 Then
                actualizar()
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
            txtNombreCompleto.Focus()
        End If
    End Sub

    Private Sub txtNombreCompleto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreCompleto.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtNombreCompleto.Text) IsNot "" Then
            txtPerfil.Focus()
        End If
    End Sub

    Private Sub txtPerfil_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPerfil.KeyDown
        If e.KeyCode = Keys.Enter And idPerfil > 0 Then
            txtUsuario.Focus()
        End If
        If e.KeyCode = Keys.Space OrElse e.KeyCode = Keys.F9 Then
            listarUsuario()
        End If
    End Sub

    Private Sub btnPerfiles_Click(sender As Object, e As EventArgs) Handles btnPerfiles.Click
        listarUsuario()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtUsuario.Text) IsNot "" Then
            txtClave.Focus()
        End If
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtClave.Text) IsNot "" Then
            chkActivo.Focus()
        End If
    End Sub

    Private Sub chkActivo_KeyDown(sender As Object, e As KeyEventArgs) Handles chkActivo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If GridView1.RowCount > 0 Then
            Dim dv As DataView
            Dim filter As String = ""
            filter = " NOMBRE_COMPLETO LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR NOMBRE LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR PERFIL LIKE '%" & txtBuscar.Text & "%' "
            dv = gridListado.DataSource.DefaultView
            dv.RowFilter = filter
            gridListado.DataSource = dv
        End If
    End Sub

    Private Sub gridListado_DoubleClick(sender As Object, e As EventArgs) Handles gridListado.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim id As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR"))
        getUsuario(id)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        aceptar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub
End Class