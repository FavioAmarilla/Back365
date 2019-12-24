Public Class FrmAgregarProductosFamilia
    Private Sub FrmAgregarProductosFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub cargarProductos()
        Dim codigo As String = ""

        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", "Agregar productos") = False Then
            ControlMensajes.mensaje("Operacion no confirmada", "Agregar productos", "WAR")
            btnAceptar.Focus()
            Return
        End If

        For i As Integer = 0 To lstProductos.Lines.Count - 1
            codigo = lstProductos.Lines(i)
            If codigo IsNot "" Then
                If codigo.Length < 13 Then
                    Dim ceros As String = ""
                    For j As Integer = 1 To 13 - codigo.Length
                        ceros = ceros & "0"
                    Next
                    codigo = ceros + codigo
                End If

                FrmProductosPorFamilia.getProductos(codigo)
            End If
        Next

        Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        cargarProductos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class