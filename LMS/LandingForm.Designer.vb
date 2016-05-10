<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingForm
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
        Me.pbReports = New System.Windows.Forms.PictureBox()
        Me.pbBooks = New System.Windows.Forms.PictureBox()
        Me.pbCustomers = New System.Windows.Forms.PictureBox()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbReports
        '
        Me.pbReports.Image = Global.LMS.My.Resources.Resources.report_image
        Me.pbReports.Location = New System.Drawing.Point(198, 56)
        Me.pbReports.Name = "pbReports"
        Me.pbReports.Size = New System.Drawing.Size(80, 80)
        Me.pbReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReports.TabIndex = 2
        Me.pbReports.TabStop = False
        '
        'pbBooks
        '
        Me.pbBooks.Image = Global.LMS.My.Resources.Resources.books_icon
        Me.pbBooks.Location = New System.Drawing.Point(105, 56)
        Me.pbBooks.Name = "pbBooks"
        Me.pbBooks.Size = New System.Drawing.Size(80, 80)
        Me.pbBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBooks.TabIndex = 1
        Me.pbBooks.TabStop = False
        '
        'pbCustomers
        '
        Me.pbCustomers.Image = Global.LMS.My.Resources.Resources.Customer_Icon
        Me.pbCustomers.Location = New System.Drawing.Point(12, 56)
        Me.pbCustomers.Name = "pbCustomers"
        Me.pbCustomers.Size = New System.Drawing.Size(80, 80)
        Me.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCustomers.TabIndex = 0
        Me.pbCustomers.TabStop = False
        '
        'LandingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LMS.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.pbReports)
        Me.Controls.Add(Me.pbBooks)
        Me.Controls.Add(Me.pbCustomers)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "LandingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LandingForm"
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbCustomers As System.Windows.Forms.PictureBox
    Friend WithEvents pbBooks As System.Windows.Forms.PictureBox
    Friend WithEvents pbReports As System.Windows.Forms.PictureBox
End Class
