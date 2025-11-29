Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Expense
    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Label_Status.Text = ""

        Try
            Dim categoryText As String = Combo_Category.Text
            Dim amountText As String = Text_Amount.Text
            Dim dateValue As DateTime = DateTimeExpense.Value
            Dim descriptionText As String = Text_Description.Text

            ' Check if required fields are empty
            If String.IsNullOrWhiteSpace(categoryText) Or
               String.IsNullOrWhiteSpace(amountText) Then

                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please fill in all required fields."
                Exit Sub
            End If

            ' Validate amount
            Dim amountValue As Decimal
            If Not Decimal.TryParse(amountText, amountValue) Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please enter a valid amount."
                Exit Sub
            End If

            ' Insert into database
            Dim connectionString As String =
                "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

            Dim query As String =
                "INSERT INTO Expense_TB (Category, ExpenseAmount, Expense_Date, Users_ID) " &
                "VALUES (@Category, @ExpenseAmount, @Expense_Date, @Users_ID)"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Category", categoryText)
                    command.Parameters.AddWithValue("@ExpenseAmount", amountValue)
                    command.Parameters.AddWithValue("@Expense_Date", dateValue)

                    command.Parameters.AddWithValue("@Users_ID", Users_ID)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Clear inputs
            Combo_Category.SelectedIndex = -1
            Text_Amount.Clear()
            Text_Description.Clear()
            DateTimeExpense.Value = DateTime.Now

            Label_Status.ForeColor = Color.Green
            Label_Status.Text = "Added"

        Catch ex As Exception
            Label_Status.ForeColor = Color.Red
            Label_Status.Text = "Error: " & ex.Message
        End Try

    End Sub

    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoToIncome As New Income()
        GoToIncome.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Transaction_Click(sender As Object, e As EventArgs) Handles Btn_Transaction.Click
        Dim GoToTransaction As New Dashboard()
        GoToTransaction.Show()
        Me.Hide()
    End Sub
End Class
