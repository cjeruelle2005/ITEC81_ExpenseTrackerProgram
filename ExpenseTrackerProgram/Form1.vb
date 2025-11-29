Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class LoginForm

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim connectionString As String = "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"
        Dim email As String = Text_Email.Text
        Dim password As String = Text_Password.Text

        ' Get UserID instead of COUNT(*)
        Dim query As String = "SELECT Users_ID FROM UserTB WHERE Email = @Email AND Passcode = @Passcode"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Passcode", password)

                con.Open()

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    ' Save UserID globally
                    Users_ID = CInt(result)

                    Label_Status.ForeColor = Color.Green
                    Label_Status.Text = "Login successful!"

                    Dim dashboardForm As New Dashboard()
                    dashboardForm.Show()
                    Me.Hide()

                Else
                    Label_Status.ForeColor = Color.Red
                    Label_Status.Text = "Invalid email or password."
                End If
            End Using
        End Using

    End Sub

    Private Sub Btn_SignUp_Click(sender As Object, e As EventArgs) Handles Btn_SignUp.Click
        Dim signupForm As New SignUp()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub
End Class
