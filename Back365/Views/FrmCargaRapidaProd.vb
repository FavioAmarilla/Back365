Public Class FrmCargaRapidaProd

    Dim frmActivo As String = ""
    Dim frmTomaInventario As FrmTomaInventario
    Dim frmTraspasoProductosSuc As FrmTraspasoProductosSuc
    Dim frmGenerarListaProd As FrmGenerarListaProd

    Private Sub FrmAgregarProdTomaInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub setFrmActivo(frm As String)
        frmActivo = frm
    End Sub

    Public Sub setFrmTomaInventario(frm As FrmTomaInventario)
        frmTomaInventario = frm
    End Sub

    Public Sub setFrmTraspasoProductosSuc(frm As FrmTraspasoProductosSuc)
        frmTraspasoProductosSuc = frm
    End Sub

    Public Sub setFrmGenerarListaProd(frm As FrmGenerarListaProd)
        frmGenerarListaProd = frm
    End Sub

    Function getCodigoBarras(codigo As String) As String
        Try
            Dim vector As String() = codigo.Split(",")
            Return vector(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Sub cargarProductos()
        Dim codigo As String = ""

        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", "Agregar productos") = False Then
            ControlMensajes.mensaje("Operacion no confirmada", "Agregar productos", "WAR")
            btnAceptar.Focus()
            Return
        End If

        If frmActivo = "FrmTomaInventario" Then
            For i As Integer = 0 To lstProductos.Lines.Count - 1
                codigo = lstProductos.Lines(i)
                If codigo IsNot "" Then
                    If codigo.Length < 13 Then
                        Dim ceros As String = ""
                        For j As Integer = 1 To 13 - getCodigoBarras(codigo).Length
                            ceros = ceros & "0"
                        Next
                        codigo = ceros + codigo
                    End If
                    frmTomaInventario.getProducto(codigo)
                End If
            Next
        End If

        If frmActivo = "FrmTraspasoProductosSuc" Then
            For i As Integer = 0 To lstProductos.Lines.Count - 1
                codigo = lstProductos.Lines(i)
                If codigo IsNot "" Then
                    If codigo.Length < 13 Then
                        Dim ceros As String = ""
                        For j As Integer = 1 To 13 - getCodigoBarras(codigo).Length
                            ceros = ceros & "0"
                        Next
                        codigo = ceros + codigo
                    End If
                    frmTraspasoProductosSuc.addProducto(codigo)
                End If
            Next
        End If

        If frmActivo = "FrmGenerarListaProd" Then
            For i As Integer = 0 To lstProductos.Lines.Count - 1
                codigo = lstProductos.Lines(i)
                If codigo IsNot "" Then
                    If codigo.Length < 13 Then
                        Dim ceros As String = ""
                        For j As Integer = 1 To 13 - getCodigoBarras(codigo).Length
                            ceros = ceros & "0"
                        Next
                        codigo = ceros + codigo
                    End If
                    frmGenerarListaProd.addProducto(codigo)
                End If
            Next
        End If


        Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        cargarProductos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

End Class