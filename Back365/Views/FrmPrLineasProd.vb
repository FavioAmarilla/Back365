Imports DevExpress.XtraReports.UI

Public Class FrmPrLineasProd
    Dim dtLineas As New DataTable
    Dim dtItems As New DataTable
    Dim lineas As New ContPrLineasProd
    Dim titulo As String = "Lineas de productos"
    Dim dv As DataView

    Private Sub FrmPrLineasProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getFamilias()
        chkDescripcion.Checked = True
    End Sub

    Private Function getIdentificador(codigo As String) As String
        Dim dt As New DataTable
        Dim id As String
        dt = lineas.consultar("SELECT IDENTIFICADOR FROM PR_LINEAS_PROD WHERE ABREVIATURA='" & codigo & "'")

        If dt.Rows().Count() > 0 Then
            id = CStr(dt.Rows(0).Item(0).ToString)
        Else
            gridItems.DataSource = Nothing
            ControlMensajes.mensaje("Identificador de familia no obtenido", titulo, "WAR")
            id = 0
        End If
        Return id
    End Function

    Sub getFamilias()
        dtLineas = lineas.consultar("SELECT IDENTIFICADOR, DESCRIPCION, ABREVIATURA AS CODIGO, ID_LINEA_PADRE, NIVEL, ULTIMO_NIVEL FROM PR_LINEAS_PROD ORDER BY CODIGO ASC")

        trFamilias.DataSource = dtLineas
        trFamilias.KeyFieldName = "IDENTIFICADOR"
        trFamilias.ParentFieldName = "ID_LINEA_PADRE"
    End Sub

    Sub getItems(id As String, codigo As String)
        Dim sql As String = ""

        If id IsNot "" And codigo = "" Then
            sql = "SELECT PR.IDENTIFICADOR,PR.CODIGO_BARRAS, PR.DESCRIPCION, PR.CODIGO AS CODIGO_INTERNO
                    FROM PR_PRODUCTOS PR 
                    LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                    LEFT JOIN FND_TIPOS_IMPUESTO ON FND_TIPOS_IMPUESTO.IDENTIFICADOR = PR.ID_TIPO_IMPUESTO
                    WHERE PR.ACTIVO='S' AND PR.ID_LINEA=" & id & " ORDER BY CODIGO ASC, DESCRIPCION ASC"
        End If

        If codigo IsNot "" And id = "" Then
            sql = "SELECT NUMERO, ID_PRODUCTO AS IDENTIFICADOR, COALESCE(CODIGO_BARRAS,'-') AS CODIGO_BARRAS, 
                    DESCRIPCION, CODIGO AS CODIGO_INTERNO
                    FROM FAMILIAS_VW WHERE NUMERO2 LIKE '" & codigo & "%'"
        End If

        dtItems = lineas.consultar(sql)

        If dtItems.Rows.Count > 0 Then
            gridItems.DataSource = dtItems
        Else
            gridItems.DataSource = Nothing
            ControlMensajes.mensaje("Item no definidos", titulo, "WAR")
        End If
    End Sub

    Private Sub trFamilias_DoubleClick(sender As Object, e As EventArgs) Handles trFamilias.DoubleClick
        Dim codigo As String = ""

        If trFamilias.FocusedNode(3).ToString = "S" Then
            codigo = getIdentificador(trFamilias.FocusedNode(1).ToString)
            getItems(codigo, "")
            txtBuscar.Focus()
        End If
        If trFamilias.FocusedNode(3).ToString = "N" Then
            codigo = trFamilias.FocusedNode(1).ToString
            getItems("", codigo)
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub trFamilias_KeyDown(sender As Object, e As KeyEventArgs) Handles trFamilias.KeyDown
        Dim codigo As String = ""

        If trFamilias.FocusedNode(3).ToString = "S" Then
            codigo = getIdentificador(trFamilias.FocusedNode(1).ToString)
            getItems(codigo, "")
            txtBuscar.Focus()
        End If
        If trFamilias.FocusedNode(3).ToString = "N" Then
            codigo = trFamilias.FocusedNode(1).ToString
            getItems("", codigo)
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtItems.Rows.Count > 0 Then
            dv = dtItems.DefaultView
            If chkCodigo.Checked = False And chkDescripcion.Checked = False Then
                ControlMensajes.mensaje("Debe seleccionar tipo de busqueda", titulo, "WAR")
                txtBuscar.Text = ""
                chkDescripcion.Focus()
            End If
            If chkCodigo.Checked Then
                dv.RowFilter = "CODIGO_BARRAS LIKE '" & txtBuscar.Text & "%'"
                gridItems.DataSource = dv

            End If
            If chkDescripcion.Checked Then
                dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
                gridItems.DataSource = dv
            End If
        End If
    End Sub

    Private Sub chkDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles chkDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkDescripcion.Checked Then
                txtBuscar.Focus()
            Else
                chkCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub chkCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles chkCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkCodigo.Checked Then
                txtBuscar.Focus()
            Else
                chkDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub chkDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescripcion.CheckedChanged
        If chkDescripcion.Checked Then
            chkCodigo.Checked = False
        End If
        txtBuscar.Text = ""
    End Sub

    Private Sub chkCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigo.CheckedChanged
        If chkCodigo.Checked Then
            chkDescripcion.Checked = False
        End If
        txtBuscar.Text = ""
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim familia As String = ""
        familia = trFamilias.FocusedNode(0).ToString

        Dim report As New RptPrLineasProd

        report.DataSource = dtItems
        report.Parameters("familia").Value = familia
        report.Parameters("familia").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        trFamilias.ShowPrintPreview()
    End Sub


End Class