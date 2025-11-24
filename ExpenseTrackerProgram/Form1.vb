Public Class LoginForm
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

    End Sub

    Private Sub Btn_SignUp_Click(sender As Object, e As EventArgs) Handles Btn_SignUp.Click
        Dim GoSignUp As New SignUp()
        GoSignUp.Show()
        Me.Hide()
    End Sub
End Class
