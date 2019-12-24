Public Class FrmRedondeo
    Private Sub FrmRedondeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function redondeo(valor As Double) As Integer
        Dim returnVal As Integer = 0

        If valor - CInt(valor) >= 0.1 Then
            returnVal = valor + 1
        Else
            returnVal = valor
        End If

        Return returnVal
    End Function

    Sub setResultado()
        Dim result As Integer = 0
        Dim numero As Integer = 0

        Try
            numero = CInt(txtNumero.Text)
            result = redondeo(numero / 50) * 50

            txtResultado.Text = CStr(result)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNumero.Text.Replace(" ", "") IsNot "" Then
                setResultado()
                txtResultado.Focus()
            End If
        End If
    End Sub

    Private Sub txtResultado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResultado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtResultado.Text.Replace(" ", "") IsNot "" Then
                btnAceptar.Focus()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        setResultado()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNumero.Text = ""
        txtResultado.Text = ""
        txtNumero.Focus()
    End Sub

End Class