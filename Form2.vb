'Billing form
Public Class Form2

    Dim iBilling As New BillingCost

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbLocation.Items.Add("Pasig")               'Location 
        cmbLocation.Items.Add("Makati")
        cmbLocation.Items.Add("Manila")
        cmbLocation.Items.Add("Bulacan")
        cmbLocation.Items.Add("Taytay")
        cmbLocation.Items.Add("Others")

        cmbProveofID.Items.Add("Student ID")          'ID client
        cmbProveofID.Items.Add("Any prove ID")
        cmbProveofID.Items.Add("Valid ID")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Calculate Bill 
        iBilling.iCustomer.cdeposit = Val(txtDeposite.Text)
        iBilling.iCustomer.cdownPayment = Val(txtDownpayment.Text)
        iBilling.iUtilities.celectricity = Val(txtElectricity.Text)
        iBilling.iUtilities.clocalTax = Val(txtLocaltax.Text)
        iBilling.iUtilities.cwaterBill = Val(txtWaterbill.Text)
        iBilling.iUtilities.cRent = Val(txtRentBill.Text)
        iBilling.iRental.cCost = Val(txtCost.Text)
        iBilling.iRental.cnumberofroom = Val(NumericUpDown1.Value)
        'Print total
        txtTotalPayment.Text = (iBilling.TotalBill)

        TextBox.AppendText("Sandoval Ave, Nagpayong, pinagbuhatan, pasig city." + vbNewLine + vbNewLine)
        TextBox.AppendText("ContactNo:#########" + vbNewLine + vbNewLine)
        TextBox.AppendText("Email:Sample@gmail.com" + vbNewLine + vbNewLine)
        TextBox.AppendText("" + vbNewLine)
        TextBox.AppendText("                                                     INVOICE BILL" + vbNewLine + "--------------------------------------------------------------------------------------------------" + vbNewLine)
        TextBox.AppendText(" InvoiceNo:" + vbTab + vbTab + txtInvoiceNo.Text + vbNewLine)
        TextBox.AppendText(" Customer ID:" + vbTab + vbTab + txtCustomerID.Text + vbNewLine)
        TextBox.AppendText(" Date Bill:" + vbTab + vbTab + vbTab + DateTimePicker1.Text + vbNewLine)
        TextBox.AppendText(" Due Date Bill:" + vbTab + vbTab + DateTimePicker2.Text + vbNewLine)
        TextBox.AppendText(" Firstname:" + vbTab + vbTab + txtFirstname.Text + vbNewLine)
        TextBox.AppendText(" Surname:" + vbTab + vbTab + txtSurname.Text + vbNewLine)
        TextBox.AppendText(" Address:" + vbTab + vbTab + vbTab + txtAddress.Text + vbNewLine)
        TextBox.AppendText(" Prove ID:" + vbTab + vbTab + cmbProveofID.Text + vbNewLine)
        TextBox.AppendText(" Location:" + vbTab + vbTab + vbTab + cmbLocation.Text + vbNewLine)
        TextBox.AppendText(" Town:" + vbTab + vbTab + vbTab + txtTown.Text + vbNewLine)
        TextBox.AppendText("--------------------------------------------------------------------------------------------------" + vbNewLine)
        TextBox.AppendText(" Deposit:" + vbTab + vbTab + vbTab + txtDeposite.Text + vbNewLine)
        TextBox.AppendText(" Down Payment:" + vbTab + vbTab + txtDownpayment.Text + vbNewLine)
        TextBox.AppendText(" Number of Room:" + vbTab + vbTab + NumericUpDown1.Text + vbNewLine)
        TextBox.AppendText(" Electricty Bill:" + vbTab + vbTab + txtElectricity.Text + vbNewLine)
        TextBox.AppendText(" Local Bill:" + vbTab + vbTab + txtLocaltax.Text + vbNewLine)
        TextBox.AppendText(" Water Bill:" + vbTab + vbTab + txtWaterbill.Text + vbNewLine)
        TextBox.AppendText(" Rent Bill:" + vbTab + vbTab + vbTab + txtRentBill.Text + vbNewLine)
        TextBox.AppendText("--------------------------------------------------------------------------------------------------" + vbNewLine)
        TextBox.AppendText(" Total Payment:" + vbTab + vbTab + txtTotalPayment.Text + vbNewLine)
        TextBox.AppendText("--------------------------------------------------------------------------------------------------" + vbNewLine)
        TextBox.AppendText("" + vbNewLine)
        TextBox.AppendText("" + vbNewLine)
        TextBox.AppendText("You may pay with Gcash[No:###] BDO[AccNo:###] Maya[No:###]" + vbNewLine + vbNewLine)
        TextBox.AppendText("" + vbNewLine)
        TextBox.AppendText("Payment is due within 30 days." + vbNewLine + vbNewLine)
        TextBox.AppendText("If you have any questions, concerning this invoice, contact this [PhoneNo:###]" + vbNewLine + vbNewLine)
        TextBox.AppendText("" + vbNewLine)
        TextBox.AppendText("                                                      Thank you!" + vbNewLine + vbNewLine)
    End Sub

    'Reset bill
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each txt In Panel3.Controls.OfType(Of TextBox)
            txt.Text = ""

        Next

        For Each txt In Panel1.Controls.OfType(Of TextBox)
            txt.Text = ""

        Next

        For Each txt In Panel5.Controls.OfType(Of TextBox)
            txt.Text = ""

        Next

        NumericUpDown1.Value = 1
        TextBox.Clear()
        cmbLocation.Text = ""
        cmbProveofID.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""


    End Sub
    'LogOut
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        systemExit.ExitSystem()
    End Sub
    'Print Bill
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim logoing As Image = My.Resources.ResourceManager.GetObject("logo")
        e.Graphics.DrawString(TextBox.Text, New Font("Ariel", 14, FontStyle.Bold), Brushes.Black, New Point(90, 90))
        e.Graphics.DrawImage(logoing, CInt((e.PageBounds.Width - 150) / 1.1), 35, 150, 120)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'show client info
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Show Email application  
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        systemExit.ExitSystem()
    End Sub

    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Minimized form
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '    Maximized form
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
'Exit System
Public Class systemExit
    Public Shared Function ExitSystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to Exit", "Billing System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()

        End If
    End Function
End Class