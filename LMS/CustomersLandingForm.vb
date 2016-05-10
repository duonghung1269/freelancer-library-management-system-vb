Public Class CustomersLandingForm

    Private Sub pbAddCustomer_Click(sender As Object, e As EventArgs) Handles pbAddCustomer.Click
        AddCustomer.Show()
    End Sub

    Private Sub pbSearchCustomer_Click(sender As Object, e As EventArgs) Handles pbSearchCustomer.Click
        CustomerDetail.Show()
    End Sub
End Class