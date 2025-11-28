Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Enter.Click
        Dim connectionString As String = "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()

            Dim firstName As String = Text_FirstName.Text
            Dim lastName As String = Text_LastName.Text
            Dim email As String = Text_Email.Text
            Dim password As String = Text_Password.Text
            Dim contact As String = Text_Contact.Text

            ' Check for empty fields
            If firstName = "" Or lastName = "" Or email = "" Or password = "" Or contact = "" Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please fill in all fields."
                Exit Sub
            End If

            ' Check if password already exists
            Dim checkCommand As New SqlCommand("SELECT COUNT(*) FROM UserTB WHERE Passcode = @Passcode", connection)
            checkCommand.Parameters.AddWithValue("@Passcode", password)
            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

            ' check if password is already used
            If count > 0 Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Password is already used."
                Exit Sub
            End If

            ' check password length
            If password.Length < 8 Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Password must be at least 8 characters long."
                Exit Sub
            End If

            ' Insert new user
            Dim insertCommand As New SqlCommand("INSERT INTO UserTB (FirstName, LastName, Email, Passcode, ContactNumber) VALUES (@FirstName, @LastName, @Email, @Passcode, @ContactNumber)", connection)
            insertCommand.Parameters.AddWithValue("@FirstName", firstName)
            insertCommand.Parameters.AddWithValue("@LastName", lastName)
            insertCommand.Parameters.AddWithValue("@Email", email)
            insertCommand.Parameters.AddWithValue("@Passcode", password)
            insertCommand.Parameters.AddWithValue("@ContactNumber", contact)
            insertCommand.ExecuteNonQuery()

            ' Show success message
            Label_Status.ForeColor = Color.Green
            Label_Status.Text = "Sign up successful"

            ' Clear textboxes
            Text_FirstName.Text = ""
            Text_LastName.Text = ""
            Text_Email.Text = ""
            Text_Password.Text = ""
            Text_Contact.Text = ""

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
