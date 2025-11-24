
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Enter.Click
        Dim connectionString As String = "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security = True;Encrypt = False;"
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()
            Dim firstName As String = Text_FirstName.Text
            Dim lastName As String = Text_LastName.Text
            Dim email As String = Text_Email.Text
            Dim password As String = Text_Password.Text
            Dim contact As String = Text_Contact.Text

            If firstName = "" Or lastName = "" Or email = "" Or password = "" Or contact = "" Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please fill in all fields."

            Else
                Dim command As New SqlCommand("INSERT INTO User_TB (FirstName, LastName, Email, Passcode, Contact) VALUES (@FirstName, @LastName, @Email, @Passcode, @Contact)", connection)
                command.Parameters.AddWithValue("@FirstName", firstName)
                command.Parameters.AddWithValue("@LastName", lastName)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Passcode", password)
                command.Parameters.AddWithValue("@Contact", contact)
                command.ExecuteNonQuery()
                Label_Status.ForeColor = Color.Green
                Label_Status.Text = "Sign up successful"
            End If
        Catch ex As Exception
            Label_Status.ForeColor = Color.Red
            Label_Status.Text = "Error: " & ex.Message
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Dim GoBack As New LoginForm()
        GoBack.Show()
        Me.Hide()
    End Sub
End Class