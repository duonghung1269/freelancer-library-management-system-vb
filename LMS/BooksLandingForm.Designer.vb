<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksLandingForm
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
        Me.pbAddGroup = New System.Windows.Forms.PictureBox()
        Me.pbReturnBook = New System.Windows.Forms.PictureBox()
        Me.pbIssueBook = New System.Windows.Forms.PictureBox()
        Me.pbAddBook = New System.Windows.Forms.PictureBox()
        CType(Me.pbAddGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReturnBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIssueBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAddGroup
        '
        Me.pbAddGroup.Image = Global.LMS.My.Resources.Resources.add_group
        Me.pbAddGroup.Location = New System.Drawing.Point(138, 139)
        Me.pbAddGroup.Name = "pbAddGroup"
        Me.pbAddGroup.Size = New System.Drawing.Size(80, 80)
        Me.pbAddGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAddGroup.TabIndex = 3
        Me.pbAddGroup.TabStop = False
        '
        'pbReturnBook
        '
        Me.pbReturnBook.Image = Global.LMS.My.Resources.Resources.return_book
        Me.pbReturnBook.Location = New System.Drawing.Point(29, 139)
        Me.pbReturnBook.Name = "pbReturnBook"
        Me.pbReturnBook.Size = New System.Drawing.Size(80, 80)
        Me.pbReturnBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReturnBook.TabIndex = 2
        Me.pbReturnBook.TabStop = False
        '
        'pbIssueBook
        '
        Me.pbIssueBook.Image = Global.LMS.My.Resources.Resources.issue_book
        Me.pbIssueBook.Location = New System.Drawing.Point(138, 35)
        Me.pbIssueBook.Name = "pbIssueBook"
        Me.pbIssueBook.Size = New System.Drawing.Size(80, 80)
        Me.pbIssueBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIssueBook.TabIndex = 1
        Me.pbIssueBook.TabStop = False
        '
        'pbAddBook
        '
        Me.pbAddBook.Image = Global.LMS.My.Resources.Resources.add_book
        Me.pbAddBook.Location = New System.Drawing.Point(29, 35)
        Me.pbAddBook.Name = "pbAddBook"
        Me.pbAddBook.Size = New System.Drawing.Size(80, 80)
        Me.pbAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAddBook.TabIndex = 0
        Me.pbAddBook.TabStop = False
        '
        'BooksLandingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LMS.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(252, 262)
        Me.Controls.Add(Me.pbAddGroup)
        Me.Controls.Add(Me.pbReturnBook)
        Me.Controls.Add(Me.pbIssueBook)
        Me.Controls.Add(Me.pbAddBook)
        Me.IsMdiContainer = True
        Me.Name = "BooksLandingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BooksLandingForm"
        CType(Me.pbAddGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReturnBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIssueBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbAddBook As System.Windows.Forms.PictureBox
    Friend WithEvents pbIssueBook As System.Windows.Forms.PictureBox
    Friend WithEvents pbReturnBook As System.Windows.Forms.PictureBox
    Friend WithEvents pbAddGroup As System.Windows.Forms.PictureBox
End Class
