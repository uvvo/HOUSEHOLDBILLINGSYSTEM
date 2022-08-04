<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillSystemDataSet = New HOUSEHOLDBILLINGSYSTEM.billSystemDataSet2()
        Me.InfoTableAdapter = New HOUSEHOLDBILLINGSYSTEM.billSystemDataSet2TableAdapters.InfoTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel6.SuspendLayout()
        CType(Me.InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel6.Controls.Add(Me.Button9)
        Me.Panel6.Controls.Add(Me.Button6)
        Me.Panel6.Controls.Add(Me.Button8)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Label15)
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Name = "Panel6"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.fullscreen
        resources.ApplyResources(Me.Button9, "Button9")
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Name = "Button9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.minimize_sign
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.cancel
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'InfoBindingSource
        '
        Me.InfoBindingSource.DataMember = "Info"
        Me.InfoBindingSource.DataSource = Me.BillSystemDataSet
        '
        'BillSystemDataSet
        '
        Me.BillSystemDataSet.DataSetName = "billSystemDataSet2"
        Me.BillSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InfoTableAdapter
        '
        Me.InfoTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.log_out
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.reset
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.trash
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.refresh
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.add
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtSearch
        '
        resources.ApplyResources(Me.txtSearch, "txtSearch")
        Me.txtSearch.Name = "txtSearch"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.txtEmail)
        Me.Panel4.Controls.Add(Me.txtPhoneNo)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtAddress)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtSurname)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtFirtName)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtClientId)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.Name = "txtEmail"
        '
        'txtPhoneNo
        '
        resources.ApplyResources(Me.txtPhoneNo, "txtPhoneNo")
        Me.txtPhoneNo.Name = "txtPhoneNo"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtAddress
        '
        resources.ApplyResources(Me.txtAddress, "txtAddress")
        Me.txtAddress.Name = "txtAddress"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtSurname
        '
        resources.ApplyResources(Me.txtSurname, "txtSurname")
        Me.txtSurname.Name = "txtSurname"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtFirtName
        '
        resources.ApplyResources(Me.txtFirtName, "txtFirtName")
        Me.txtFirtName.Name = "txtFirtName"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtClientId
        '
        resources.ApplyResources(Me.txtClientId, "txtClientId")
        Me.txtClientId.Name = "txtClientId"
        Me.txtClientId.TabStop = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Magenta
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label17.Name = "Label17"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources._return
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = Global.HOUSEHOLDBILLINGSYSTEM.My.Resources.Resources.printing
        resources.ApplyResources(Me.Button10, "Button10")
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Name = "Button10"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        resources.ApplyResources(Me.PrintPreviewDialog1, "PrintPreviewDialog1")
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        '
        'Form3
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BillSystemDataSet As billSystemDataSet2
    Friend WithEvents InfoBindingSource As BindingSource
    Friend WithEvents InfoTableAdapter As billSystemDataSet2TableAdapters.InfoTableAdapter
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtClientId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
