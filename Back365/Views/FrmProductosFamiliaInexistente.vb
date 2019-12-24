Public Class FrmProductosFamiliaInexistente
    Dim contador As Integer = 0

    Private Sub FrmProductosFamiliaInexistente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub addProducto(codigo)
        lstProductos.Text += codigo & vbCrLf
        contador = contador + 1

        lblRecuento.Text = contador.ToString
    End Sub

End Class