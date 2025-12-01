Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Expense
    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Label_Status.Text = ""

        Try
            Dim ItemName As String = Text_Item.Text
            Dim categoryText As String = Combo_Category.Text
            Dim amountText As String = Text_Amount.Text
            Dim dateValue As DateTime = DateTimeExpense.Value
            Dim descriptionText As String = Text_Description.Text

            ' Check if required fields are empty
            If String.IsNullOrWhiteSpace(categoryText) Or
               String.IsNullOrWhiteSpace(ItemName) Or
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




            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query1 As String =
                "INSERT INTO Expense_TB (Item, Category, ExpenseAmount, Expense_Date, Users_ID) " &
                "VALUES (@Item, @Category, @ExpenseAmount, @Expense_Date, @Users_ID)"
                Using command1 As New SqlCommand(query1, connection)
                    command1.Parameters.AddWithValue("@Item", ItemName)
                    command1.Parameters.AddWithValue("@Category", categoryText)
                    command1.Parameters.AddWithValue("@ExpenseAmount", amountValue)
                    command1.Parameters.AddWithValue("@Expense_Date", dateValue)

                    command1.Parameters.AddWithValue("@Users_ID", Users_ID)


                    command1.ExecuteNonQuery()
                End Using

                Dim query2 As String =
                "INSERT INTO Transaction_TB (Item, Category, Money_Spend, Users_ID) " &
                "VALUES (@Item, @Category, @Money_Spend, @Users_ID)"

                Using command2 As New SqlCommand(query2, connection)
                    command2.Parameters.AddWithValue("@Item", ItemName)
                    command2.Parameters.AddWithValue("@Category", categoryText)
                    command2.Parameters.AddWithValue("@Money_Spend", amountValue)
                    command2.Parameters.AddWithValue("@Users_ID", Users_ID)
                    command2.ExecuteNonQuery()
                End Using
            End Using

            ' Update global balance
            SessionModule.Balance -= amountValue

            ' Update Dashboard label if open
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is Dashboard Then
                    CType(frm, Dashboard).Label_Balance.Text = "Balance: " & SessionModule.Balance.ToString("C2")
                End If
            Next

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

    Private Sub Text_Amount_TextChanged(sender As Object, e As EventArgs) Handles Text_Amount.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
End Class
