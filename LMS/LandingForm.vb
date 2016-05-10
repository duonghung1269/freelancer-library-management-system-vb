Public Class LandingForm

    Private Sub pbCustomers_Click(sender As Object, e As EventArgs) Handles pbCustomers.Click
        'CustomersLandingForm.MdiParent = Me
        CustomersLandingForm.Show()
    End Sub

    Private Sub pbBooks_Click(sender As Object, e As EventArgs) Handles pbBooks.Click
        'BooksLandingForm.MdiParent = Me
        BooksLandingForm.Show()
    End Sub

    Private Sub pbReports_Click(sender As Object, e As EventArgs) Handles pbReports.Click
        'ReportsLandingForm.MdiParent = Me
        ReportsLandingForm.Show()
    End Sub
End Class