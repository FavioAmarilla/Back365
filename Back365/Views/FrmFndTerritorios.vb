﻿Public Class FrmFndTerritorios

    Dim contFndTerritorios As New ContFndTerritorios

    Dim identificador As Integer = 0
    Dim idPais As Integer = 0
    Dim titulo As String = "Mensaje"

    Private Sub FrmFndTerritorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Sub limpiar()
        identificador = 0
        idPais = 0
        txtPais.Text = ""
        txtNombre.Text = ""
        txtAbreviatura.Text = ""
    End Sub

    Sub listar()
        Dim dt As New DataTable
        dt = contFndTerritorios.consultar("SELECT TE.IDENTIFICADOR, FND_PAISES.NOMBRE AS PAIS, TE.NOMBRE, TE.ABREVIATURA
                                        FROM FND_TERRITORIOS TE 
                                        INNER JOIN FND_PAISES ON FND_PAISES.IDENTIFICADOR = TE.ID_PAIS
                                        ORDER BY FND_PAISES.NOMBRE ASC")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        End If
    End Sub

    Sub getTerritorio(id As Integer)
        Dim dt As New DataTable
        dt = contFndTerritorios.consultar("SELECT IDENTIFICADOR, ID_PAIS, NOMBRE, ABREVIATURA FROM FND_TERRITORIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            identificador = CInt(dt.Rows(0).Item(0))
            getPais(CInt(dt.Rows(0).Item(1)))
            txtNombre.Text = CStr(dt.Rows(0).Item(2))
            txtAbreviatura.Text = CStr(dt.Rows(0).Item(3))
        End If
    End Sub

    Sub getPais(id As Integer)
        Dim dt As New DataTable
        dt = contFndTerritorios.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PAISES WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idPais = CInt(dt.Rows(0).Item(0))
            txtPais.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Function validarCampos() As Boolean
        If idPais <= 0 Then
            ControlMensajes.mensaje("El campo pais no puede estar vacio", titulo, "WAR")
            txtPais.Focus()
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

            If contFndTerritorios.insertar(identificador, idPais, nombre, abreviatura) Then
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

            If contFndTerritorios.actualizar(identificador, idPais, nombre, abreviatura) Then
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


    Sub listarPaises()
        Dim frm As New FrmVistaFndPaises
        frm.setFrmActivo("FrmFndTerritorios")
        frm.setFrmFndTerritorios(Me)
        frm.ShowDialog()
    End Sub

    Private Sub txtPais_Properties_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPais.KeyDown
        If e.KeyCode = Keys.Enter And Util.eliminarEspacios(txtPais.Text) IsNot "" Then
            txtNombre.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then

        End If
    End Sub

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click

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
        getTerritorio(id)
    End Sub
End Class