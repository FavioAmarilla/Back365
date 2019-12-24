Public Class FrmLogin

    Dim titulo As String = "Acceso al Sistemas"

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub login()
        If txtUsuario.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("Debe ingresar usuario", titulo, "WAR")
            Return
        End If
        If txtClave.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("Debe ingresar clave de acceso", titulo, "WAR")
            Return
        End If

        Dim dt As New DataTable
        Dim contUsuario As New ContFndUsuarios
        dt = contUsuario.consultar("SELECT FND_USUARIOS.IDENTIFICADOR, FND_USUARIOS.NOMBRE, FND_USUARIOS.NOMBRE_COMPLETO, 
                                    FND_PERFILES.SUPER_USUARIO, FND_USUARIOS.ID_SITIO
                                    FROM FND_USUARIOS 
                                    INNER JOIN FND_PERFILES ON FND_PERFILES.IDENTIFICADOR = FND_USUARIOS.ID_PERFIL
                                    WHERE UPPER(FND_USUARIOS.NOMBRE)='" & txtUsuario.Text.ToUpper & "' 
                                    AND UPPER(FND_USUARIOS.CLAVE_ACCESO)='" & txtClave.Text.ToUpper & "'")
        If dt.Rows.Count > 0 Then
            FrmMenuPrincipal.ID_USUARIO = dt.Rows(0).Item(0)
            FrmMenuPrincipal.USUARIO = dt.Rows(0).Item(1)
            FrmMenuPrincipal.NOMBRE_USUARIO = dt.Rows(0).Item(2)
            FrmMenuPrincipal.SUPER_USUARIO = dt.Rows(0).Item(3)
            FrmMenuPrincipal.SITIO_USR = dt.Rows(0).Item(4)
            FrmMenuPrincipal.validarSesionUsuario()
            Close()
        Else
            ControlMensajes.mensaje("Acceso denegado", titulo, "ERR")
            txtUsuario.Text = ""
            txtClave.Text = ""
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter And txtUsuario.Text.Replace(" ", "") IsNot "" Then
            txtClave.Focus()
        End If
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter And txtClave.Text.Replace(" ", "") IsNot "" Then
            login()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        login()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
        FrmMenuPrincipal.Close()
    End Sub

End Class