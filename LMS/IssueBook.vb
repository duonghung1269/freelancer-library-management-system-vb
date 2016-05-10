Public Class IssueBook

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IssueBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadCustomerIds()
        Call BookID_Combo()
        Call readData()
    End Sub
    Sub loadCustomerIds()
        Try
            If objcon.State = ConnectionState.Closed Then objcon.Open()
            com = New OleDb.OleDbCommand("Select CID from Customer", objcon)
            dr = com.ExecuteReader
            While dr.Read
                cbbCustomerId.Items.Add(dr.Item(0))
            End While
            dr.Close()
            objcon.Close()
        Catch ex As Exception

        End Try
    End Sub
    Sub BookID_Combo()
        Try
            If objcon.State = ConnectionState.Closed Then objcon.Open()
            com = New OleDb.OleDbCommand("Select BookID from Books WHERE status='Available'", objcon)
            dr = com.ExecuteReader
            While dr.Read
                cbbBookId.Items.Add(dr.Item(0))
            End While
            dr.Close()
            objcon.Close()
        Catch ex As Exception

        End Try
    End Sub
    Sub readData()
        IssueBooksListView.Clear()
        IssueBooksListView.Columns.Add("BOOK ID", 90, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("GROUP ID", 90, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("BOOK NAME", 310, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("PUBLISHER", 90, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("AUTHOR", 90, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("PUBLISHING YEAR", 130, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("EDITION", 90, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("PRICE", 90, HorizontalAlignment.Center)
        IssueBooksListView.Columns.Add("STATUS", 90, HorizontalAlignment.Center)
        IssueBooksListView.GridLines = True
        IssueBooksListView.View = View.Details
        Try

            If (objcon.State = ConnectionState.Closed) Then objcon.Open()
            com = New OleDb.OleDbCommand("SELECT * FROM Books WHERE status='Available'", objcon)
            dr = com.ExecuteReader
            While dr.Read()
                Call adddatatolistview(IssueBooksListView, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8))
            End While
            dr.Close()
            objcon.Close()
        Catch
            'MsgBox("Please Refresh", MsgBoxStyle.Information, "")
        End Try
    End Sub
    Public Sub adddatatolistview(ByVal lvw As ListView, ByVal BookID As String, ByVal GroupID As String, ByVal BookName As String, ByVal Publisher As String, ByVal Author As String, ByVal PubYear As String, ByVal edi As String, ByVal pric As String, ByVal st As String)
        Dim lv As New ListViewItem
        lvw.Items.Add(lv)
        lv.Text = BookID
        lv.SubItems.Add(GroupID)
        lv.SubItems.Add(BookName)
        lv.SubItems.Add(Publisher)
        lv.SubItems.Add(Author)
        lv.SubItems.Add(PubYear)
        lv.SubItems.Add(edi)
        lv.SubItems.Add(pric)
        lv.SubItems.Add(st)
    End Sub
    Sub Retrive()
        objcon.Open()
        com = New OleDb.OleDbCommand("SELECT * FROM Books", objcon)
        com.ExecuteNonQuery()
        dr = com.ExecuteReader
        dr.Read()
        While (dr.NextResult)
            cbbBookId.Items.Add(dr(1))
        End While
        objcon.Close()
    End Sub

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If objcon.State = ConnectionState.Closed Then objcon.Open()
            com = New OleDb.OleDbCommand("UPDATE Books SET status='Rented' WHERE BookID='" & cbbBookId.Text & "'", objcon)
            com.ExecuteNonQuery()
            objcon.Close()
            Call readData()
            If objcon.State = ConnectionState.Closed Then objcon.Open()
            com = New OleDb.OleDbCommand("INSERT INTO Issue VALUES('" & cbbBookId.Text & "','" & cbbGroupId.Text & "','" & tbBookName.Text & "','" & cbbCustomerId.Text & "','" & tbCustomerName.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')", objcon)
            com.ExecuteNonQuery()
            MsgBox("Book has been Issued!", 0, "")
            Call readData()
            objcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 0, "")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbBookId.SelectedIndexChanged
        Dim i As Integer
        IssueBooksListView.SelectedItems.Clear()
        tbCustomerName.Focus()
        Try
            If Me.cbbBookId.Text = "" Then
                tbBookName.Text = ""
            Else
                For i = 0 To IssueBooksListView.Items.Count - 1
                    If cbbBookId.Text = IssueBooksListView.Items(i).SubItems(0).Text Then
                        cbbGroupId.Text = IssueBooksListView.Items(i).SubItems(1).Text
                        tbBookName.Text = IssueBooksListView.Items(i).SubItems(2).Text
                        tbPublisher.Text = IssueBooksListView.Items(i).SubItems(3).Text
                        tbAuthor.Text = IssueBooksListView.Items(i).SubItems(4).Text
                        cbbPublishYear.Text = IssueBooksListView.Items(i).SubItems(5).Text
                        tbEdition.Text = IssueBooksListView.Items(i).SubItems(6).Text
                        tbPrice.Text = IssueBooksListView.Items(i).SubItems(7).Text
                        cbbStatus.Text = IssueBooksListView.Items(i).SubItems(8).Text

                        IssueBooksListView.Items(i).Selected = True
                        Exit For
                    End If
                Next
            End If
        Catch

        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If cbbBookId.Text = "" Then
                MsgBox("Please mention the BookID", 0, "")
            Else
                If objcon.State = ConnectionState.Closed Then
                    com = New OleDb.OleDbCommand("delete from Issue where BookID='" & cbbBookId.Text & "'", objcon)
                    If MsgBox("Do you really want to delete?", MsgBoxStyle.YesNo, "Are you sure?") = Windows.Forms.DialogResult.Yes Then
                        com.ExecuteNonQuery()
                    End If
                    objcon.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueBooksListView.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To IssueBooksListView.Items.Count - 1
            If IssueBooksListView.Items(i).Selected = True Then
                cbbBookId.Text = IssueBooksListView.Items(i).SubItems(0).Text
                Exit For
            End If
        Next
        IssueBooksListView.Focus()
        IssueBooksListView.FullRowSelect = True
    End Sub

    Private Sub cbbCustomerId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbCustomerId.SelectedIndexChanged
        Try
            If objcon.State = ConnectionState.Closed Then objcon.Open()
            com = New OleDb.OleDbCommand("Select CID,CName from Customer", objcon)
            dr = com.ExecuteReader
            While dr.Read
                If dr.Item(0) = cbbCustomerId.Text Then
                    tbCustomerName.Text = dr.Item(1)
                End If

            End While
            dr.Close()
            objcon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim i As Integer
            For i = 0 To IssueBooksListView.Items.Count - 1
                If IssueBooksListView.Items(i).Selected = True Then
                    tbCustomerName.Text = IssueBooksListView.Items(i + 1).SubItems(0).Text
                    Exit For
                End If
            Next
            IssueBooksListView.Focus()
            IssueBooksListView.FullRowSelect = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim i As Integer
            For i = 0 To IssueBooksListView.Items.Count - 1
                If IssueBooksListView.Items(i).Selected = True Then
                    tbCustomerName.Text = IssueBooksListView.Items(i - 1).SubItems(0).Text
                    Exit For
                End If
            Next
            IssueBooksListView.Focus()
            IssueBooksListView.FullRowSelect = True
        Catch ex As Exception

        End Try
    End Sub
End Class