<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsLandingForm
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
        Me.pbCustomerReport = New System.Windows.Forms.PictureBox()
        Me.pbRentedBooks = New System.Windows.Forms.PictureBox()
        Me.pbMembership = New System.Windows.Forms.PictureBox()
        CType(Me.pbCustomerReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRentedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMembership, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCustomerReport
        '
        Me.pbCustomerReport.Image = Global.LMS.My.Resources.Resources.customer_report
        Me.pbCustomerReport.Location = New System.Drawing.Point(192, 70)
        Me.pbCustomerReport.Name = "pbCustomerReport"
        Me.pbCustomerReport.Size = New System.Drawing.Size(80, 80)
        Me.pbCustomerReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCustomerReport.TabIndex = 2
        Me.pbCustomerReport.TabStop = False
        '
        'pbRentedBooks
        '
        Me.pbRentedBooks.Image = Global.LMS.My.Resources.Resources.rented_book
        Me.pbRentedBooks.Location = New System.Drawing.Point(102, 70)
        Me.pbRentedBooks.Name = "pbRentedBooks"
        Me.pbRentedBooks.Size = New System.Drawing.Size(80, 80)
        Me.pbRentedBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRentedBooks.TabIndex = 1
        Me.pbRentedBooks.TabStop = False
        '
        'pbMembership
        '
        Me.pbMembership.Image = Global.LMS.My.Resources.Resources.membership_report
        Me.pbMembership.Location = New System.Drawing.Point(12, 70)
        Me.pbMembership.Name = "pbMembership"
        Me.pbMembership.Size = New System.Drawing.Size(80, 80)
        Me.pbMembership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMembership.TabIndex = 0
        Me.pbMembership.TabStop = False
        '
        'ReportsLandingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LMS.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.pbCustomerReport)
        Me.Controls.Add(Me.pbRentedBooks)
        Me.Controls.Add(Me.pbMembership)
        Me.IsMdiContainer = True
        Me.Name = "ReportsLandingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        CType(Me.pbCustomerReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRentedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMembership, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbMembership As System.Windows.Forms.PictureBox
    Friend WithEvents pbRentedBooks As System.Windows.Forms.PictureBox
    Friend WithEvents pbCustomerReport As System.Windows.Forms.PictureBox
End Class
