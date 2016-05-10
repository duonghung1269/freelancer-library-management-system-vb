Public Class BooksLandingForm

    Private Sub pbAddBook_Click(sender As Object, e As EventArgs) Handles pbAddBook.Click
        'Dim addBookForm = New AddBooks()
        'AddBooks.MdiParent = Me
        'addBookForm.Show()
        AddBooks.Show()
    End Sub

    Private Sub pbIssueBook_Click(sender As Object, e As EventArgs) Handles pbIssueBook.Click
        IssueBook.Show()
    End Sub

    Private Sub pbReturnBook_Click(sender As Object, e As EventArgs) Handles pbReturnBook.Click
        ReturnBook.Show()
    End Sub

    Private Sub pbAddGroup_Click(sender As Object, e As EventArgs) Handles pbAddGroup.Click
        GroupID.Show()
    End Sub
End Class