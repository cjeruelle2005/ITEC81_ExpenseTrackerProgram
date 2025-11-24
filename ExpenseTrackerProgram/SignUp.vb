Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Enter.Click
        Dim firstName As String
        Dim lastName As String
        Dim Email As String
        Dim password As String
        Dim contact As Int32
        Dim status As String

        firstName = Text_FirstName.Text
        lastName = Text_LastName.Text
        Email = Text_Email.Text
        password = Text_Password.Text
        contact = Text_Contact.Text
        status = Label_Status.Text

        If firstName = "" Or lastName = "" Or Email = "" Or password = "" Or contact = "" Then
            status = "Please fill in all fields."
            Exit Sub
        End If
        status = "Sign up successful"


    End Sub


End Class