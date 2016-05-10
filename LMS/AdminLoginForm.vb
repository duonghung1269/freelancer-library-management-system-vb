Public Class AdminLoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If "admin".Equals(tbUsername.Text) And "admin123".Equals(tbPassword.Text) Then
            Dim landingForm = New LandingForm()

            landingForm.Show()
        Else
            'MsgBox("Incorrect Username/Password!", 0, "")
        End If




    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class