<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbCustomerId = New System.Windows.Forms.TextBox
        Me.tbName = New System.Windows.Forms.TextBox
        Me.tbCustomerAddress = New System.Windows.Forms.TextBox
        Me.tbContact = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.dtpActivationDate = New System.Windows.Forms.DateTimePicker
        Me.dtpValidTill = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.addCustomerListView = New System.Windows.Forms.ListView
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUSTOMER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CUSTOMER ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CUSTOMER CONTACT #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CUSTOMER SECURITY DEPOSIT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ACTIVATION DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "VALID TILL"
        '
        'TextBox1
        '
        Me.tbCustomerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCustomerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomerId.Location = New System.Drawing.Point(345, 43)
        Me.tbCustomerId.MaxLength = 30
        Me.tbCustomerId.Name = "TextBox1"
        Me.tbCustomerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbCustomerId.Size = New System.Drawing.Size(311, 20)
        Me.tbCustomerId.TabIndex = 7
        '
        'TextBox2
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.tbName.Location = New System.Drawing.Point(345, 77)
        Me.tbName.MaxLength = 50
        Me.tbName.Name = "TextBox2"
        Me.tbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbName.Size = New System.Drawing.Size(311, 20)
        Me.tbName.TabIndex = 8
        '
        'TextBox3
        '
        Me.tbCustomerAddress.Location = New System.Drawing.Point(345, 112)
        Me.tbCustomerAddress.Multiline = True
        Me.tbCustomerAddress.Name = "TextBox3"
        Me.tbCustomerAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbCustomerAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCustomerAddress.Size = New System.Drawing.Size(311, 63)
        Me.tbCustomerAddress.TabIndex = 9
        '
        'TextBox4
        '
        Me.tbContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContact.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.tbContact.Location = New System.Drawing.Point(531, 191)
        Me.tbContact.MaxLength = 12
        Me.tbContact.Name = "TextBox4"
        Me.tbContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbContact.Size = New System.Drawing.Size(125, 20)
        Me.tbContact.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.ForeColor = System.Drawing.Color.Crimson
        Me.TextBox5.Location = New System.Drawing.Point(531, 229)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox5.Size = New System.Drawing.Size(125, 20)
        Me.TextBox5.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.dtpActivationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpActivationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpActivationDate.Location = New System.Drawing.Point(345, 261)
        Me.dtpActivationDate.Name = "DateTimePicker1"
        Me.dtpActivationDate.Size = New System.Drawing.Size(311, 20)
        Me.dtpActivationDate.TabIndex = 12
        '
        'DateTimePicker2
        '
        Me.dtpValidTill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpValidTill.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpValidTill.Location = New System.Drawing.Point(345, 293)
        Me.dtpValidTill.Name = "DateTimePicker2"
        Me.dtpValidTill.Size = New System.Drawing.Size(311, 20)
        Me.dtpValidTill.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 435)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 53)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONTROL"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(361, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(99, 20)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Exit"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(239, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 20)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(132, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 20)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(516, 435)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 53)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MOVES"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(102, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 20)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "->"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(11, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 20)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "<-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.addCustomerListView.FullRowSelect = True
        Me.addCustomerListView.GridLines = True
        Me.addCustomerListView.Location = New System.Drawing.Point(23, 332)
        Me.addCustomerListView.Name = "ListView1"
        Me.addCustomerListView.Size = New System.Drawing.Size(689, 97)
        Me.addCustomerListView.TabIndex = 16
        Me.addCustomerListView.UseCompatibleStateImageBehavior = False
        Me.addCustomerListView.View = System.Windows.Forms.View.Details
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 501)
        Me.Controls.Add(Me.addCustomerListView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtpValidTill)
        Me.Controls.Add(Me.dtpActivationDate)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.tbContact)
        Me.Controls.Add(Me.tbCustomerAddress)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbCustomerId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddCustomer"
        Me.ShowIcon = False
        Me.Text = "ADD CUSTOMER"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbContact As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents dtpActivationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpValidTill As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents addCustomerListView As System.Windows.Forms.ListView
End Class
