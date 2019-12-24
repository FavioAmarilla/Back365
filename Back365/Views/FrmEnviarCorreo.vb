Imports System.Net.Mail

Public Class FrmEnviarCorreo
    Private Sub FrmEnviarCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub EnvioMail()

        Try
            Dim correo As New MailMessage
            Dim smtp As New SmtpClient()

            correo.From = New MailAddress(txtDe.Text, "Favio Amarilla", System.Text.Encoding.UTF8)
            correo.To.Add(txtPara.Text)
            correo.SubjectEncoding = System.Text.Encoding.UTF8
            correo.Subject = "Asunto de tu mensaje"
            correo.Body = "Pueba de envio de correo desde Visual.Net"
            correo.BodyEncoding = System.Text.Encoding.UTF8
            correo.IsBodyHtml = False
            correo.Priority = MailPriority.High

            smtp.Credentials = New Net.NetworkCredential(txtDe.Text, txtPass.Text)
            smtp.Port = 587
            smtp.Host = "smtp.gmail.com"
            smtp.EnableSsl = True

            smtp.Send(correo)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        EnvioMail()
    End Sub
End Class