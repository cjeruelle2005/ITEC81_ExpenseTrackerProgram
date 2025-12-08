Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class LoginForm

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Dim email As String = Text_Email.Text
        Dim password As String = Text_Password.Text

        ' Reset ProgressBar
        Progress_Bar.Value = 0
        Progress_Bar.Visible = True

        ' Start login process using a timer to simulate progress
        Timer1.Interval = 50 ' Adjust speed of progress
        Timer1.Start()
    End Sub

    ' Timer Tick event to increment progress bar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Progress_Bar.Value < 100 Then
            Progress_Bar.Increment(2) ' Increase by 5 each tick
        Else
            Timer1.Stop()
            Progress_Bar.Visible = False
            PerformLogin()
        End If
    End Sub

    ' Actual login logic
    Private Sub PerformLogin()
        Dim connectionString As String = "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"
        Dim email As String = Text_Email.Text
        Dim password As String = Text_Password.Text

        Dim query As String = "SELECT Users_ID FROM UserTB WHERE Email = @Email AND Passcode = @Passcode"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Passcode", password)

                con.Open()
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Users_ID = CInt(result)
                    Label_Status.ForeColor = Color.Green
                    Label_Status.Text = "Login successful!"

                    Dim dashboardForm As New Dashboard()
                    dashboardForm.Location = Me.Location()
                    Me.Hide()
                    dashboardForm.Show()

                Else
                    Label_Status.ForeColor = Color.Red
                    Label_Status.Text = "Invalid email or password."
                End If
            End Using
        End Using
    End Sub

    Private Sub Btn_SignUp_Click(sender As Object, e As EventArgs) Handles Btn_SignUp.Click
        Dim signupForm As New SignUp()
        signupForm.Location = Me.Location()
        Me.Hide()
        signupForm.Show()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub

End Class
