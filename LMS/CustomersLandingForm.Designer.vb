<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersLandingForm
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
        Me.pbSearchCustomer = New System.Windows.Forms.PictureBox()
        Me.pbAddCustomer = New System.Windows.Forms.PictureBox()
        CType(Me.pbSearchCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSearchCustomer
        '
        Me.pbSearchCustomer.Image = Global.LMS.My.Resources.Resources.search_customer
        Me.pbSearchCustomer.Location = New System.Drawing.Point(158, 77)
        Me.pbSearchCustomer.Name = "pbSearchCustomer"
        Me.pbSearchCustomer.Size = New System.Drawing.Size(80, 80)
        Me.pbSearchCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSearchCustomer.TabIndex = 1
        Me.pbSearchCustomer.TabStop = False
        '
        'pbAddCustomer
        '
        Me.pbAddCustomer.Image = Global.LMS.My.Resources.Resources.add_customer
        Me.pbAddCustomer.Location = New System.Drawing.Point(58, 77)
        Me.pbAddCustomer.Name = "pbAddCustomer"
        Me.pbAddCustomer.Size = New System.Drawing.Size(80, 80)
        Me.pbAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAddCustomer.TabIndex = 0
        Me.pbAddCustomer.TabStop = False
        '
        'CustomersLandingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LMS.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.pbSearchCustomer)
        Me.Controls.Add(Me.pbAddCustomer)
        Me.IsMdiContainer = True
        Me.Name = "CustomersLandingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomersForm"
        CType(Me.pbSearchCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbAddCustomer As System.Windows.Forms.PictureBox
    Friend WithEvents pbSearchCustomer As System.Windows.Forms.PictureBox
End Class
