Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Income

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label_Status.Text = ""

        Try
            Dim incomeText As String = Text_incomeAmount.Text
            Dim incomeSource As String = Combo_Source.Text
            Dim incomeCategory As String = Combo_Category.Text

            ' Check if any field is empty
            If String.IsNullOrWhiteSpace(incomeText) OrElse
               String.IsNullOrWhiteSpace(incomeSource) OrElse
               String.IsNullOrWhiteSpace(incomeCategory) Then

                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please fill in all fields."
                Exit Sub
            End If

            ' Validate amount
            Dim incomeAmount As Decimal
            If Not Decimal.TryParse(incomeText, incomeAmount) Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please enter a valid amount."
                Exit Sub
            End If

            ' Database connection
            Dim connectionString As String =
                "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' -------------------------------
                ' 1st INSERT → IncomeTB
                ' -------------------------------
                Dim query As String =
                    "INSERT INTO IncomeTB (Income_Amount, Income_Source, Income_Category, Users_ID)
                     VALUES (@Income_Amount, @Income_Source, @Income_Category, @Users_ID)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Income_Amount", incomeAmount)
                    command.Parameters.AddWithValue("@Income_Source", incomeSource)
                    command.Parameters.AddWithValue("@Income_Category", incomeCategory)
                    command.Parameters.AddWithValue("@Users_ID", Users_ID)

                    command.ExecuteNonQuery()
                End Using

                ' -------------------------------
                ' 2nd INSERT → Transaction_TB
                ' -------------------------------
                Dim query2 As String =
                    "INSERT INTO Transaction_TB (Category, Money_Added, Users_ID)
                     VALUES (@Category, @Money_Added, @Users_ID)"

                Using command2 As New SqlCommand(query2, connection)
                    command2.Parameters.AddWithValue("@Category", incomeCategory)
                    command2.Parameters.AddWithValue("@Money_Added", incomeAmount)
                    command2.Parameters.AddWithValue("@Users_ID", Users_ID)
                    command2.ExecuteNonQuery()
                End Using

            End Using  ' Connection closes here

            ' Clear input fields
            Text_incomeAmount.Clear()
            Combo_Source.SelectedIndex = -1
            Combo_Category.SelectedIndex = -1

            Label_Status.ForeColor = Color.Green
            Label_Status.Text = "Added"

        Catch ex As Exception
            Label_Status.ForeColor = Color.Red
            Label_Status.Text = "Error: " & ex.Message
        End Try

    End Sub

    Private Sub Btn_Transaction_Click(sender As Object, e As EventArgs) Handles Btn_Transaction.Click
        Dim GoToTransaction As New Dashboard()
        GoToTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Statistic_Click(sender As Object, e As EventArgs) Handles Btn_Statistic.Click
        Dim GoToStatistic As New Statistic()
        GoToStatistic.Show()
        Me.Hide()
    End Sub

End Class
