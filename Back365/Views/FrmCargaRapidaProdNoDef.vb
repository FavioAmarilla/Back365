Public Class FrmCargaRapidaProdNoDef

    Private Sub FrmCargaRapidaProdNoDef_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

    End Sub

    Public Sub setNoDefinidos(list As List(Of String))
        For Each codigo In list
            lstProductos.Text += codigo + vbCrLf
        Next
    End Sub

End Class