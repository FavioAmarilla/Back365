Imports DevExpress.XtraEditors

Public Class ControlMensajes

    Public Sub New()

    End Sub

    Public Shared Sub mensaje(mensaje As String, titulo As String, tipo As String)
        If tipo = "INF" Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show(mensaje, titulo, Nothing, MessageBoxIcon.Information)
        End If
        If tipo = "WAR" Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show(mensaje, titulo, Nothing, MessageBoxIcon.Warning)
        End If
        If tipo = "ERR" Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show(mensaje, titulo, Nothing, MessageBoxIcon.Error)
        End If
    End Sub

    Public Shared Function msj_confirmacion(mensaje As String, titulo As String) As Boolean
        Dim result As DialogResult = XtraMessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return result = DialogResult.Yes
    End Function

End Class
