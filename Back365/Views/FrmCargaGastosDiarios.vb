Public Class FrmCargaGastosDiarios

    Dim contAppGastosDiarios As New ContAppGastosDiarios
    Dim dtGastos As New DataTable
    Dim titulo As String = "Gastos diarios"


    Private Sub FrmCargaGastosDiarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getParametros()
        getGastosDelDia()
    End Sub

    Sub limpiar()
        dtGastos = Nothing
        gridGastos.DataSource = dtGastos
    End Sub

    Sub getParametros()
        Dim dt As New DataTable
        dt = contAppGastosDiarios.consultar("SELECT DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(FrmMenuPrincipal.SITIO_USR))
        If dt.Rows.Count > 0 Then
            txtSucursal.Text = CStr(dt.Rows(0).Item(0))
        End If

        txtFecha.Text = Now.ToString("dd/MM/yyyy")
    End Sub

    Sub crearCursor()
        dtGastos = New DataTable
        dtGastos.Columns.Add("IDENTIFICADOR")
        dtGastos.Columns.Add("CONCEPTO")
        dtGastos.Columns.Add("TOTAL")

        gridGastos.DataSource = dtGastos
    End Sub

    Sub getGastosDelDia()
        crearCursor()
        dtGastos = contAppGastosDiarios.consultar("SELECT IDENTIFICADOR, CONCEPTO, TOTAL FROM APP_GASTOS_DIARIOS WHERE ID_SITIO=" & CStr(FrmMenuPrincipal.SITIO_USR) & " AND TRUNC(FECHA) = TO_DATE('" & txtFecha.Text & "','dd/MM/yyyy')")

        If dtGastos.Rows.Count > 0 Then
            gridGastos.DataSource = dtGastos
        End If

        GridView1.AddNewRow()
    End Sub

    Sub insertar()
        If FrmMenuPrincipal.SITIO_USR <= 0 Then
            ControlMensajes.mensaje("Sucursal no definida", titulo, "WAR")
            Return
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe agregar gastos a la operacion", titulo, "WAR")
            Return
        End If

        Dim identificador As Integer = 0
        Dim concepto As String = ""
        Dim total As Integer = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "TOTAL")) Then
            Else
                If GridView1.GetRowCellValue(i, "TOTAL") IsNot "" Then
                    If CInt(GridView1.GetRowCellValue(i, "TOTAL")) > 0 Then
                        total = CStr(GridView1.GetRowCellValue(i, "TOTAL"))
                    End If
                End If
            End If


            If total <= 0 Then
                ControlMensajes.mensaje("Totales deben ser mayor a cero(0)" & CStr(i), titulo, "WAR")
                Return
            End If
        Next


        For i As Integer = 0 To GridView1.RowCount - 1
            identificador = 0
            concepto = ""
            total = 0

            If IsDBNull(GridView1.GetRowCellValue(i, "IDENTIFICADOR")) Then
            Else
                If GridView1.GetRowCellValue(i, "IDENTIFICADOR") IsNot "" Then
                    If CInt(GridView1.GetRowCellValue(i, "IDENTIFICADOR")) > 0 Then
                        identificador = CInt(GridView1.GetRowCellValue(i, "IDENTIFICADOR"))
                    End If
                End If
            End If

            If IsDBNull(GridView1.GetRowCellValue(i, "CONCEPTO")) Then
            Else
                If GridView1.GetRowCellValue(i, "CONCEPTO") IsNot "" Then
                    concepto = CStr(GridView1.GetRowCellValue(i, "CONCEPTO"))
                End If
            End If

            If IsDBNull(GridView1.GetRowCellValue(i, "TOTAL")) Then
            Else
                If GridView1.GetRowCellValue(i, "TOTAL") IsNot "" Then
                    If CInt(GridView1.GetRowCellValue(i, "TOTAL")) > 0 Then
                        total = CStr(GridView1.GetRowCellValue(i, "TOTAL"))
                    End If
                End If
            End If

            If total > 0 And concepto IsNot "" Then
                If identificador <= 0 Then
                    If contAppGastosDiarios.insertar(contAppGastosDiarios.getIdentificador(), FrmMenuPrincipal.SITIO_USR, concepto, txtFecha.Text, total) = False Then
                        ControlMensajes.mensaje("Gasto no registrado: " & CStr(i), titulo, "WAR")
                        Return
                    End If
                Else
                    If contAppGastosDiarios.actualizar(identificador, concepto, total) = False Then
                        ControlMensajes.mensaje("Gasto no actualizado: " & CStr(i), titulo, "WAR")
                        Return
                    End If
                End If
            End If
        Next

        ControlMensajes.mensaje("Gastos registrados", titulo, "INF")
        getGastosDelDia()
    End Sub

    Private Sub eliminarFilasVacias()
        Try
            For i As Integer = 0 To GridView1.RowCount - 1
                If IsDBNull(GridView1.GetRowCellValue(i, "CONCEPTO")) Then
                    GridView1.DeleteRow(i)
                Else
                    If GridView1.GetRowCellValue(i, "CONCEPTO") = "" Then
                        GridView1.DeleteRow(i)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rpsConcepto_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsConcepto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "CONCEPTO")) Then
            Else
                If GridView1.GetRowCellValue(rowhandle, "CONCEPTO") = "" Then
                Else
                    GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                End If
            End If
        End If
        If e.KeyCode = Keys.F8 Then
            getGastosDelDia()
        End If
        If e.KeyCode = Keys.F10 Then
            eliminarFilasVacias()
            insertar()
        End If
    End Sub

    Private Sub rpsTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "TOTAL")) Then
            Else
                If CStr(GridView1.GetRowCellValue(rowhandle, "TOTAL")) = "" Then
                Else
                    If CInt(GridView1.GetRowCellValue(rowhandle, "TOTAL")) > 0 Then
                        eliminarFilasVacias()
                        GridView1.AddNewRow()
                        GridView1.FocusedRowHandle = rowhandle + 1
                        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                        SendKeys.Send("{ENTER}")
                    End If
                End If
            End If
        End If
        If e.KeyCode = Keys.F8 Then
            getGastosDelDia()
        End If
        If e.KeyCode = Keys.F10 Then
            eliminarFilasVacias()
            insertar()
        End If
    End Sub

    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFecha.Focus()
        End If
        If e.KeyCode = Keys.F8 Then
            getGastosDelDia()
        End If
        If e.KeyCode = Keys.F10 Then
            eliminarFilasVacias()
            insertar()
        End If
    End Sub

    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.Focus()
            GridView1.FocusedRowHandle = 0
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            SendKeys.Send("{ENTER}")
        End If
        If e.KeyCode = Keys.F8 Then
            getGastosDelDia()
        End If
        If e.KeyCode = Keys.F10 Then
            eliminarFilasVacias()
            insertar()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        eliminarFilasVacias()
        insertar()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        getGastosDelDia()
    End Sub
End Class