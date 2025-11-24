
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Enter.Click
        Dim firstName As String
        Dim lastName As String
        Dim Email As String
        Dim password As String
        Dim contact As String

        firstName = Text_FirstName.Text
        lastName = Text_LastName.Text
        Email = Text_Email.Text
        password = Text_Password.Text
        contact = Text_Contact.Text

        If firstName = "" Or lastName = "" Or Email = "" Or password = "" Or contact = "" Then
            Label_Status.ForeColor = Color.Red
            Label_Status.Text = "Please fill in all fields."
            Exit Sub
        End If

        Label_Status.ForeColor = Color.Green
        Label_Status.Text = "Sign up successful."
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click

        Dim GoBack As New LoginForm()
        GoBack.Show()
        Me.Hide()
    End Sub

End Class