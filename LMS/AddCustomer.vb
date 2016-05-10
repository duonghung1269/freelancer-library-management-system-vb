Public Class AddCustomer
    Public NameFrm, NameTo As String
    Public curr As String = My.Settings.CurrencyS
    Private Sub tbContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbContact.KeyDown

    End Sub
    Private Sub tbContact_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbContact.LostFocus
        tbContact.Text = tbContact.Text.Trim
    End Sub

    Private Sub tbContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbContact.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub tbCustomerName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbName.LostFocus
        NameFrm = tbName.Text
        Call Sentence()
        tbName.Text = NameTo
    End Sub

    Private Sub tbCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbName.TextChanged

    End Sub
    Sub Sentence()
        Dim a, b As Integer
        a = NameFrm.Length
        NameTo = ""
        For b = 0 To a - 1
            If b = 0 Then
                If Char.IsLower(NameFrm(0)) Then
                    NameTo = Char.ToUpper(NameFrm(0))
                Else
                    NameTo = NameFrm(0)
                End If
            Else
                If NameFrm(b - 1) = " " Then
                    NameTo = NameTo + Char.ToUpper(NameFrm(b))
                Else
                    NameTo = NameTo + NameFrm(b)
                End If
            End If
        Next
    End Sub

    Private Sub tbCustomerAddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbCustomerAddress.LostFocus
        NameFrm = tbCustomerAddress.Text
        Call Sentence()
        tbCustomerAddress.Text = NameTo
    End Sub

    Private Sub tbCustomerAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomerAddress.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tbCustomerId.Text = "" Then
            MsgBox("Please enter a Customer ID", 0, "")
        Else
            Try
                If objcon.State = ConnectionState.Closed Then objcon.Open()
                com = New OleDb.OleDbCommand("INSERT INTO Customer values('" & tbCustomerId.Text & "','" & tbName.Text & "','" & tbCustomerAddress.Text & "','" & tbContact.Text & "','" & TextBox5.Text & "','" & dtpActivationDate.Text & "','" & dtpValidTill.Text & "')", objcon)
                If com.ExecuteNonQuery() Then MsgBox("Saved Success!", 0, "")
                addCustomerListView.Clear()
                Call readData()
                objcon.Close()
                Call DisableThem()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "")
            End Try
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If tbCustomerId.Text = "" Then
            MsgBox("Please enter the ID to be deleted!", 0, "")
        Else
            Try
                objcon.Open()
                com = New OleDb.OleDbCommand("delete from Customer where CID='" & tbCustomerId.Text & "'", objcon)
                If com.ExecuteNonQuery() Then
                    addCustomerListView.Clear()
                    Call readData()
                    MsgBox("Deleted Success!", 0, "")
                Else
                    MsgBox("ID Not Found!", 0, "")
                End If

                objcon.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 0, "")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call enableControls()
        Call clearTextField()
    End Sub
    Sub enableControls()
        tbCustomerAddress.Enabled = True
        tbName.Enabled = True
        tbContact.Enabled = True
        tbCustomerId.Enabled = True
        TextBox5.Enabled = True
        dtpActivationDate.Enabled = True
        dtpValidTill.Enabled = True
    End Sub
    Sub DisableThem()
        'TextBox1.Enabled = False
        tbName.Enabled = False
        tbCustomerAddress.Enabled = False
        tbContact.Enabled = False
        TextBox5.Enabled = False
        dtpActivationDate.Enabled = False
        dtpValidTill.Enabled = False
    End Sub

    Private Sub AddCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DisableThem()
        Call readData()
    End Sub
    Sub readData()
        addCustomerListView.Columns.Add("CUSTOMER ID", 90, HorizontalAlignment.Center)
        addCustomerListView.Columns.Add("CUSTOMER NAME", 210, HorizontalAlignment.Center)
        addCustomerListView.Columns.Add("CUSTOMER ADDRESS", 130, HorizontalAlignment.Center)
        addCustomerListView.Columns.Add("CONTACT #", 90, HorizontalAlignment.Center)
        addCustomerListView.Columns.Add("SECURITY", 90, HorizontalAlignment.Center)
        addCustomerListView.Columns.Add("ACTIVATION DATE", 130, HorizontalAlignment.Center)
        addCustomerListView.Columns.Add("VALID TILL", 90, HorizontalAlignment.Center)
        Try

            If (objcon.State = ConnectionState.Closed) Then objcon.Open()
            com = New OleDb.OleDbCommand("SELECT * FROM Customer", objcon)
            dr = com.ExecuteReader
            While dr.Read()
                Call adddatatolistview(addCustomerListView, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            End While
            dr.Close()
            objcon.Close()
        Catch
            'MsgBox("Please Refresh", MsgBoxStyle.Information, "")
        End Try
    End Sub
    Public Sub adddatatolistview(ByVal lvw As ListView, ByVal CID As String, ByVal CName As String, ByVal CAddress As String, ByVal CCont As String, ByVal Sec As String, ByVal CAct As String, ByVal CVal As String)
        Dim lv As New ListViewItem
        lvw.Items.Add(lv)
        lv.Text = CID
        lv.SubItems.Add(CName)
        lv.SubItems.Add(CAddress)
        lv.SubItems.Add(CCont)
        lv.SubItems.Add(curr + " " + Sec)
        lv.SubItems.Add(CAct)
        lv.SubItems.Add(CVal)
    End Sub
    Sub clearTextField()
        tbCustomerId.Clear()
        tbName.Clear()
        tbCustomerAddress.Clear()
        tbContact.Clear()
        TextBox5.Clear()
        dtpActivationDate.Refresh()
        dtpValidTill.Refresh()
    End Sub
    Sub LoadInto()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim i As Integer
            For i = 0 To addCustomerListView.Items.Count - 1
                If addCustomerListView.Items(i).Selected = True Then
                    tbCustomerId.Text = addCustomerListView.Items(i - 1).SubItems(0).Text
                    Exit For
                End If
            Next
            addCustomerListView.Focus()
            addCustomerListView.FullRowSelect = True
        Catch ex As Exception
            MsgBox(ex.Message, 0, "")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim i As Integer
            For i = 0 To addCustomerListView.Items.Count - 1
                If addCustomerListView.Items(i).Selected = True Then
                    tbCustomerId.Text = addCustomerListView.Items(i + 1).SubItems(0).Text
                    Exit For
                End If
            Next
            addCustomerListView.Focus()
            addCustomerListView.FullRowSelect = True
        Catch ex As Exception
            MsgBox(ex.Message, 0, "")
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addCustomerListView.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To addCustomerListView.Items.Count - 1
            If addCustomerListView.Items(i).Selected = True Then
                tbCustomerId.Text = addCustomerListView.Items(i).SubItems(0).Text
                tbName.Text = addCustomerListView.Items(i).SubItems(1).Text
                tbCustomerAddress.Text = addCustomerListView.Items(i).SubItems(2).Text
                tbContact.Text = addCustomerListView.Items(i).SubItems(3).Text
                TextBox5.Text = addCustomerListView.Items(i).SubItems(4).Text
                dtpActivationDate.Text = addCustomerListView.Items(i).SubItems(5).Text
                dtpValidTill.Text = addCustomerListView.Items(i).SubItems(6).Text
                Exit For
            End If
        Next
        addCustomerListView.Focus()
        addCustomerListView.FullRowSelect = True
    End Sub

    Private Sub txCustomerId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustomerId.TextChanged
        Dim i As Integer
        addCustomerListView.SelectedItems.Clear()
        tbCustomerId.Focus()
        Try
            If Me.tbCustomerId.Text = "" Then
                tbName.Text = ""
            Else
                For i = 0 To addCustomerListView.Items.Count - 1
                    If tbCustomerId.Text = addCustomerListView.Items(i).SubItems(0).Text Then
                        tbName.Text = addCustomerListView.Items(i).SubItems(1).Text
                        addCustomerListView.Items(i).Selected = True
                        Exit For
                    End If
                Next
            End If
        Catch

        End Try
    End Sub
End Class
