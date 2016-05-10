Public Class ReportsLandingForm

    Private Sub pbMembership_Click(sender As Object, e As EventArgs) Handles pbMembership.Click
        CustomerDetail.readData()
        CustomerDetail.Show()
    End Sub

    Private Sub pbRentedBooks_Click(sender As Object, e As EventArgs) Handles pbRentedBooks.Click
        AllRented.loadRentedBooks()
        AllRented.Show()
    End Sub

    Private Sub pbCustomerReport_Click(sender As Object, e As EventArgs) Handles pbCustomerReport.Click
        CustomesReport.loadCustomerBorrowedBooks()
        CustomesReport.Show()
    End Sub
End Class