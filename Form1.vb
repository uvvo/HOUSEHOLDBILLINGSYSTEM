Public Class Form1
    'LogOut
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "123" Then
            'Show Billing Form
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Username or Password is Incorrect", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    'Hide show password
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
            Button3.Text = ""

        Else
            TextBox2.UseSystemPasswordChar = True
            Button3.Text = ""

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub


    'Close
    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class