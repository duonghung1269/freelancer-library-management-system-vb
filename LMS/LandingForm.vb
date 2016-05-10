Public Class LandingForm

    Private Sub pbCustomers_Click(sender As Object, e As EventArgs) Handles pbCustomers.Click
        Dim addCusstomerForm = New AddCustomer()
        addCusstomerForm.Show()
    End Sub

    Private Sub pbBooks_Click(sender As Object, e As EventArgs) Handles pbBooks.Click
        Dim addBooksForm = New AddBooks()
        addBooksForm.Show()
    End Sub

    Private Sub pbReports_Click(sender As Object, e As EventArgs) Handles pbReports.Click

    End Sub
End Class