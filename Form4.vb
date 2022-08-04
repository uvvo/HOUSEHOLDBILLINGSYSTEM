
'Source code For Emanil applicatiion
Imports System.Net.Mail
Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mail As New MailMessage()
        Dim smtServers As New SmtpClient("smtp.gmail.com")
        'Email clients
        mail.From = New MailAddress("haroldmenor25@gmail.com")
        mail.From = New MailAddress("menor.hm.bscs@gmail.com")
        'Input details clients
        mail.To.Add(TextBox1.Text)
        mail.Subject = TextBox2.Text
        mail.Body = TextBox3.Text


        Dim attach As System.Net.Mail.Attachment
        attach = New System.Net.Mail.Attachment(Label4.Text)
        mail.Attachments.Add(attach)
        smtServers.Port = 587
        smtServers.Credentials = New System.Net.NetworkCredential("haroldmenor25@gmail.com", "hveyrccbiudsagdq")
        smtServers.Credentials = New System.Net.NetworkCredential("menor.hm.bscs@gmail.com", "zogxfsleexfyttzf")
        smtServers.EnableSsl = True
        smtServers.Send(mail)
        'Show message successe send email
        MessageBox.Show("Mail send")
    End Sub

    'Attach file
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        Label4.Text = OpenFileDialog1.FileName
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show() 'Show billing form
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class