Public Class CustomesReport

    Private Sub cutomerReportFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadCustomerBorrowedBooks()
    End Sub

    Sub loadCustomerBorrowedBooks()
        CustomerListView.Clear()
        CustomerListView.Columns.Add("CUSTOMER NAME", 90, HorizontalAlignment.Center)
        CustomerListView.Columns.Add("ADDRESS", 90, HorizontalAlignment.Center)
        CustomerListView.Columns.Add("BOOK NAME", 310, HorizontalAlignment.Center)
        CustomerListView.Columns.Add("LEND DATE", 90, HorizontalAlignment.Center)
        CustomerListView.Columns.Add("STATUS", 90, HorizontalAlignment.Center)
        CustomerListView.GridLines = True
        CustomerListView.View = View.Details
        Try

            If (objcon.State = ConnectionState.Closed) Then objcon.Open()

            com = New OleDb.OleDbCommand("SELECT c.CName, c.CAddress, b.BookName, s.IssueDate, b.Status FROM Books b inner join Issue s on b.BookID = s.BookID inner join Customer c on s.IssueTo = c.CID WHERE status='Rented'", objcon)

            dr = com.ExecuteReader

            While dr.Read()
                Call addCustomerToListView(CustomerListView, dr(0), dr(1), dr(2), dr(3), dr(4))
            End While
            dr.Close()
            objcon.Close()
        Catch
            'MsgBox("Please Refresh!", MsgBoxStyle.Information, "")
        End Try
    End Sub

    Public Sub addCustomerToListView(ByVal lvw As ListView, ByVal CName As String, ByVal CAddress As String, ByVal BookName As String, ByVal IssueDate As String, ByVal Status As String)
        Dim lv As New ListViewItem
        lvw.Items.Add(lv)
        lv.Text = CName
        lv.SubItems.Add(CAddress)
        lv.SubItems.Add(BookName)
        lv.SubItems.Add(IssueDate)
        lv.SubItems.Add(Status)
    End Sub

End Class