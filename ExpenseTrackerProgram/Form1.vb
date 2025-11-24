Public Class LoginForm

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim connectionString As String = "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security = True;Encrypt = False;"
        Dim email As String = Text_Email.Text
        Dim password As String = Text_Password.Text


    End Sub

    Private Sub Btn_SignUp_Click(sender As Object, e As EventArgs) Handles Btn_SignUp.Click
        Dim GosignUp As New SignUp()
        GosignUp.Show()
        Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
