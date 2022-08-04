﻿'Source code for info
'Data base connection
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Form3
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    'MySQL account
    Dim server As String = "127.0.0.1"
    Dim username As String = "root"
    Dim password As String = "!Qwerty12"
    Dim database As String = "myconnector"

    Private bitmap As Bitmap
    'Update client info
    Private Sub updateTable()
        sqlConn.ConnectionString = "Server= " + server + ";" + " user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From myconnector.myconnector"
        'Close connection
        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Connection data table
        sqlConn.ConnectionString = "Server= " + server + ";" + " user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            sqlConn.Open()
            sqlQuery = "insert into myconnector.myconnector (ClientID, Firstname, Surname, Address, PhoneNo, Email)
                  value('" & txtClientId.Text & "','" & txtFirtName.Text & "','" & txtSurname.Text & "','" & txtAddress.Text & "','" & txtPhoneNo.Text & "','" & TextBox1.Text & "')"

            'Query Connection
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            For Each txt In Panel4.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If

            Next
            txtSearch.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn.ConnectionString = "Server= " + server + ";" + " user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        sqlConn.Open()

        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update myconnector.myconnector set ClientID = @ClientID, Firstname = @Firstname,Surname = @Surname, Address = @Address, PhoneNo = @PhoneNo,
                             Email = @Email where ClientID = @ClientID"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@ClientID", txtClientId.Text)
            .Parameters.AddWithValue("@Firstname", txtFirtName.Text)
            .Parameters.AddWithValue("@Surname", txtSurname.Text)
            .Parameters.AddWithValue("@Address", txtAddress.Text)
            .Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text)
            .Parameters.AddWithValue("@Email", TextBox1.Text)
        End With

        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()

    End Sub
    'DataGrideView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtClientId.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            txtFirtName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            txtSurname.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            txtAddress.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            txtPhoneNo.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            TextBox1.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Remove info
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        Update()
    End Sub

    'Search client info
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("Firstname like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = dv.ToTable
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Show main form
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

        DataGridView1.Height = height

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recp As RectangleF = e.PageSettings.PrintableArea

        If Me.DataGridView1.Height - recp.Height > 0 Then e.HasMorePages = True
    End Sub
End Class
