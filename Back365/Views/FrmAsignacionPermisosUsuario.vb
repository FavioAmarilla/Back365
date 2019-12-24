Public Class FrmAsignacionPermisosUsuario

    Dim contFndUsuario As New ContFndUsuarios
    Dim dtMenues As New DataTable
    Dim titulo As String = "Asignacion"
    Dim idUsuario As Integer = 0

    Private Sub FrmAsignacionPermisosUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub limpiar()
        txtUsuario.Text = ""
        dtMenues = Nothing
        gridMenues.DataSource = dtMenues
    End Sub

    Sub crearCursor()
        dtMenues = New DataTable
        dtMenues.Columns.Add("IDENTIFICADOR")
        dtMenues.Columns.Add("NOMBRE")
        dtMenues.Columns.Add("NUEVO")

        gridMenues.DataSource = dtMenues
    End Sub

    Sub eliminarFilasVacias()
        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "IDENTIFICADOR")) Then
                GridView1.DeleteRow(i)
            Else
                If CInt(GridView1.GetRowCellValue(i, "IDENTIFICADOR")) <= 0 Then
                    GridView1.DeleteRow(i)
                End If
            End If
        Next
    End Sub

    Public Sub getUsuario(id As Integer)
        Dim dt As New DataTable
        dt = contFndUsuario.consultar("SELECT NOMBRE, IDENTIFICADOR FROM FND_USUARIOS WHERE IDENTIFICADOR=" & CStr(id))
        txtUsuario.Text = CStr(dt.Rows(0).Item(0))
        idUsuario = CInt(dt.Rows(0).Item(1))

        crearCursor()
        eliminarFilasVacias()
        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = 0

        getMenuesUsuario(txtUsuario.Text)
    End Sub

    Public Sub getMenu(id As Integer)
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim dt As New DataTable
        dt = contFndUsuario.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_MENUES WHERE IDENTIFICADOR=" & CStr(id))

        GridView1.SetRowCellValue(rowhandle, "IDENTIFICADOR", CInt(dt.Rows(0).Item(0)))
        GridView1.SetRowCellValue(rowhandle, "NOMBRE", CStr(dt.Rows(0).Item(1)))
        GridView1.SetRowCellValue(rowhandle, "NUEVO", "S")
    End Sub

    Sub getMenuesUsuario(usr As String)
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim dt As New DataTable
        dt = contFndUsuario.consultar("SELECT ME.ID_MENU AS IDENTIFICADOR, FND_MENUES.NOMBRE, 'N' AS NUEVO
                                        FROM FND_MENUES_USR ME
                                        INNER JOIN FND_MENUES ON FND_MENUES.IDENTIFICADOR = ME.ID_MENU
                                        WHERE ME.USUARIO='" & usr & "'
                                        ORDER BY ME.FEC_CRE DESC")

        If dt.Rows.Count > 0 Then
            gridMenues.DataSource = dt
        Else
            ControlMensajes.mensaje("Permisos no definidos", titulo, "WAR")
            crearCursor()
        End If
    End Sub

    Sub vistas(verificador As String)
        If verificador = "US" Then
            Dim frm As New FrmVistaFndUsuarios
            frm.setFrmActivo("FrmAsignacionPermisosUsuario")
            frm.setFrmAsignacionPermisosUsuario(Me)
            frm.ShowDialog()
        End If
        If verificador = "ME" Then
            Dim frm As New FrmVistaFndMenues
            frm.setFrmActivo("FrmAsignacionPermisosUsuario")
            frm.setFrmAsignacionPermisosUsuario(Me)
            frm.ShowDialog()
        End If
    End Sub


    Sub insertarMenues()
        If txtUsuario.Text = "" Then
            ControlMensajes.mensaje("El campo usuario no puede estar vacio", titulo, "WAR")
            txtUsuario.Focus()
            Return
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe asignar permisos al usuario", titulo, "WAR")
            txtUsuario.Focus()
            Return
        End If

        If ControlMensajes.msj_confirmacion("Confirmar transaccion", titulo) = False Then
            ControlMensajes.mensaje("Transaccion no confirmada", titulo, "WAR")
            Return
        End If

        eliminarFilasVacias()

        For i As Integer = 0 To GridView1.RowCount - 1
            Dim idMenu As Integer = GridView1.GetRowCellValue(i, "IDENTIFICADOR")
            Dim nuevo As String = GridView1.GetRowCellValue(i, "NUEVO")

            If nuevo = "S" Then
                If contFndUsuario.insertarMenues(txtUsuario.Text, idMenu) = False Then
                    ControlMensajes.mensaje("Permiso no registrado", titulo, "WAR")
                    Return
                End If
            End If
        Next

        ControlMensajes.mensaje("Permisos asignados al usuario", titulo, "INF")
        getUsuario(idUsuario)
    End Sub

    Sub eliminarMenu()

        If ControlMensajes.msj_confirmacion("Eliminar item", titulo) = False Then
            ControlMensajes.mensaje("Item no eliminado", titulo, "WAR")
            Return
        End If

        Dim rowhandle As Integer = GridView1.FocusedRowHandle

        If IsDBNull(GridView1.GetRowCellValue(rowhandle, "NUEVO")) Then
            GridView1.DeleteRow(rowhandle)
        Else
            If CStr(GridView1.GetRowCellValue(rowhandle, "NUEVO")) = "S" Then
                GridView1.DeleteRow(rowhandle)
            Else
                If contFndUsuario.eliminarMenu(txtUsuario.Text, GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR")) Then
                    ControlMensajes.mensaje("Item eliminado", titulo, "INF")
                    GridView1.DeleteRow(rowhandle)
                Else
                    ControlMensajes.mensaje("Item no eliminado", titulo, "INF")
                End If
            End If
        End If

    End Sub

    Sub nuevaFila()
        eliminarFilasVacias()
        GridView1.AddNewRow()
        GridView1.Focus()
        GridView1.FocusedRowHandle = GridView1.RowCount - 1
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter And txtUsuario.Text IsNot "" Then
            nuevaFila()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("US")
        End If
    End Sub

    Private Sub rpsNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR")) Then
            Else
                If CInt(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR")) > 0 Then
                    nuevaFila()
                End If
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("ME")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        nuevaFila()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarMenu()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        insertarMenues()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        txtUsuario.Focus()
    End Sub

End Class