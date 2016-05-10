<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueBook
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
        Me.cbbPublishYear = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbStatus = New System.Windows.Forms.ComboBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbEdition = New System.Windows.Forms.TextBox()
        Me.cbbGroupId = New System.Windows.Forms.ComboBox()
        Me.tbAuthor = New System.Windows.Forms.TextBox()
        Me.tbPublisher = New System.Windows.Forms.TextBox()
        Me.tbBookName = New System.Windows.Forms.TextBox()
        Me.cbbBookId = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tbCustomerName = New System.Windows.Forms.TextBox()
        Me.cbbCustomerId = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.IssueBooksListView = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbPublishYear
        '
        Me.cbbPublishYear.Enabled = False
        Me.cbbPublishYear.FormattingEnabled = True
        Me.cbbPublishYear.Items.AddRange(New Object() {"Available", "Rented"})
        Me.cbbPublishYear.Location = New System.Drawing.Point(180, 190)
        Me.cbbPublishYear.Name = "cbbPublishYear"
        Me.cbbPublishYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbbPublishYear.Size = New System.Drawing.Size(158, 21)
        Me.cbbPublishYear.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbbStatus)
        Me.GroupBox1.Controls.Add(Me.cbbPublishYear)
        Me.GroupBox1.Controls.Add(Me.tbPrice)
        Me.GroupBox1.Controls.Add(Me.tbEdition)
        Me.GroupBox1.Controls.Add(Me.cbbGroupId)
        Me.GroupBox1.Controls.Add(Me.tbAuthor)
        Me.GroupBox1.Controls.Add(Me.tbPublisher)
        Me.GroupBox1.Controls.Add(Me.tbBookName)
        Me.GroupBox1.Controls.Add(Me.cbbBookId)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 232)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOOKS DETAIL"
        '
        'cbbStatus
        '
        Me.cbbStatus.Enabled = False
        Me.cbbStatus.FormattingEnabled = True
        Me.cbbStatus.Location = New System.Drawing.Point(499, 90)
        Me.cbbStatus.Name = "cbbStatus"
        Me.cbbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbbStatus.Size = New System.Drawing.Size(158, 21)
        Me.cbbStatus.TabIndex = 14
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(500, 61)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.ReadOnly = True
        Me.tbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbPrice.Size = New System.Drawing.Size(158, 20)
        Me.tbPrice.TabIndex = 13
        '
        'tbEdition
        '
        Me.tbEdition.Location = New System.Drawing.Point(500, 28)
        Me.tbEdition.Name = "tbEdition"
        Me.tbEdition.ReadOnly = True
        Me.tbEdition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbEdition.Size = New System.Drawing.Size(158, 20)
        Me.tbEdition.TabIndex = 12
        '
        'cbbGroupId
        '
        Me.cbbGroupId.Enabled = False
        Me.cbbGroupId.FormattingEnabled = True
        Me.cbbGroupId.Location = New System.Drawing.Point(180, 61)
        Me.cbbGroupId.Name = "cbbGroupId"
        Me.cbbGroupId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbbGroupId.Size = New System.Drawing.Size(158, 21)
        Me.cbbGroupId.TabIndex = 7
        '
        'tbAuthor
        '
        Me.tbAuthor.Location = New System.Drawing.Point(180, 160)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.ReadOnly = True
        Me.tbAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbAuthor.Size = New System.Drawing.Size(158, 20)
        Me.tbAuthor.TabIndex = 10
        '
        'tbPublisher
        '
        Me.tbPublisher.Location = New System.Drawing.Point(180, 126)
        Me.tbPublisher.Name = "tbPublisher"
        Me.tbPublisher.ReadOnly = True
        Me.tbPublisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbPublisher.Size = New System.Drawing.Size(158, 20)
        Me.tbPublisher.TabIndex = 9
        '
        'tbBookName
        '
        Me.tbBookName.Location = New System.Drawing.Point(180, 94)
        Me.tbBookName.Name = "tbBookName"
        Me.tbBookName.ReadOnly = True
        Me.tbBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbBookName.Size = New System.Drawing.Size(158, 20)
        Me.tbBookName.TabIndex = 8
        '
        'cbbBookId
        '
        Me.cbbBookId.FormattingEnabled = True
        Me.cbbBookId.Location = New System.Drawing.Point(180, 31)
        Me.cbbBookId.Name = "cbbBookId"
        Me.cbbBookId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbbBookId.Size = New System.Drawing.Size(158, 21)
        Me.cbbBookId.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(370, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "STATUS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(370, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "PRICE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(370, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "EDITION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PUBLISHING YEAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "AUTHOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PUBLISHER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BOOK NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GROUP ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOK ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.tbCustomerName)
        Me.GroupBox2.Controls.Add(Me.cbbCustomerId)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 97)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ISSUE DETAIL"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(499, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(158, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(500, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(158, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'tbCustomerName
        '
        Me.tbCustomerName.Location = New System.Drawing.Point(180, 58)
        Me.tbCustomerName.Name = "tbCustomerName"
        Me.tbCustomerName.ReadOnly = True
        Me.tbCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbCustomerName.Size = New System.Drawing.Size(158, 20)
        Me.tbCustomerName.TabIndex = 19
        '
        'cbbCustomerId
        '
        Me.cbbCustomerId.FormattingEnabled = True
        Me.cbbCustomerId.Location = New System.Drawing.Point(180, 25)
        Me.cbbCustomerId.Name = "cbbCustomerId"
        Me.cbbCustomerId.Size = New System.Drawing.Size(158, 21)
        Me.cbbCustomerId.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(349, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "DUE DATE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(349, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "ISSUING DATE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "NAME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "ISSUE TO"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(368, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(99, 20)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Exit"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(246, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 20)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(139, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 20)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Issue"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 477)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 53)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONTROL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Issue New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(104, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 20)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "->"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(15, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 20)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "<-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Location = New System.Drawing.Point(525, 477)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(196, 53)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MOVES"
        '
        'IssueBooksListView
        '
        Me.IssueBooksListView.FullRowSelect = True
        Me.IssueBooksListView.GridLines = True
        Me.IssueBooksListView.Location = New System.Drawing.Point(23, 373)
        Me.IssueBooksListView.Name = "IssueBooksListView"
        Me.IssueBooksListView.Size = New System.Drawing.Size(697, 98)
        Me.IssueBooksListView.TabIndex = 14
        Me.IssueBooksListView.UseCompatibleStateImageBehavior = False
        Me.IssueBooksListView.View = System.Windows.Forms.View.Details
        '
        'IssueBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LMS.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(751, 551)
        Me.Controls.Add(Me.IssueBooksListView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "IssueBook"
        Me.ShowIcon = False
        Me.Text = "ISSUE BOOK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbbPublishYear As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbPrice As System.Windows.Forms.TextBox
    Friend WithEvents tbEdition As System.Windows.Forms.TextBox
    Friend WithEvents cbbGroupId As System.Windows.Forms.ComboBox
    Friend WithEvents tbAuthor As System.Windows.Forms.TextBox
    Friend WithEvents tbPublisher As System.Windows.Forms.TextBox
    Friend WithEvents tbBookName As System.Windows.Forms.TextBox
    Friend WithEvents cbbBookId As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents cbbCustomerId As System.Windows.Forms.ComboBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents IssueBooksListView As System.Windows.Forms.ListView
End Class
