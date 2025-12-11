Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Income

    Private Sub Income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen

        Try
            Dim connectionString As String =
                "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT ISNULL(SUM(Income_Amount),0) FROM IncomeTB WHERE Users_ID=@Users_ID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Users_ID", Users_ID)
                    Dim result = command.ExecuteScalar()
                    SessionModule.Balance = Convert.ToDecimal(result)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error fetching balance: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label_Status.Text = ""

        Try
            Dim incomeText As String = Text_incomeAmount.Text
            Dim incomeSource As String = Combo_Source.Text
            Dim incomeCategory As String = Combo_Category.Text
            Dim description As String = Text_Description.Text

            If String.IsNullOrWhiteSpace(incomeText) OrElse
               String.IsNullOrWhiteSpace(incomeSource) OrElse
               String.IsNullOrWhiteSpace(incomeCategory) OrElse
               String.IsNullOrWhiteSpace(description) Then

                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please fill in all fields."
                Exit Sub
            End If

            Dim incomeAmount As Decimal
            If Not Decimal.TryParse(incomeText, incomeAmount) Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please enter a valid amount."
                Exit Sub
            End If

            Dim connectionString As String =
                "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String =
                    "INSERT INTO IncomeTB (Income_Amount, Income_Source, Income_Category, Users_ID, Descriptions)
                     VALUES (@Income_Amount, @Income_Source, @Income_Category, @Users_ID, @Descriptions)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Income_Amount", incomeAmount)
                    command.Parameters.AddWithValue("@Income_Source", incomeSource)
                    command.Parameters.AddWithValue("@Income_Category", incomeCategory)
                    command.Parameters.AddWithValue("@Users_ID", Users_ID)
                    command.Parameters.AddWithValue("@Descriptions", description)
                    command.ExecuteNonQuery()
                End Using

                Dim query2 As String =
                    "INSERT INTO Transaction_TB (Source, Category, Money_Added, Users_ID, Descriptions)
                     VALUES (@Source, @Category, @Money_Added, @Users_ID, @Descriptions)"

                Using command2 As New SqlCommand(query2, connection)
                    command2.Parameters.AddWithValue("@Source", incomeSource)
                    command2.Parameters.AddWithValue("@Category", incomeCategory)
                    command2.Parameters.AddWithValue("@Money_Added", incomeAmount)
                    command2.Parameters.AddWithValue("@Users_ID", Users_ID)
                    command2.Parameters.AddWithValue("@Descriptions", description)
                    command2.ExecuteNonQuery()
                End Using

            End Using

            SessionModule.Balance += incomeAmount

            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is Dashboard Then
                    CType(frm, Dashboard).Label_Balance.Text = SessionModule.Balance.ToString("C2")
                End If
            Next

            Text_incomeAmount.Clear()
            Combo_Source.SelectedIndex = -1
            Combo_Category.SelectedIndex = -1
            Text_Description.Clear()

            Label_Status.ForeColor = Color.Green
            Label_Status.Text = "Added"

        Catch ex As Exception
            Label_Status.ForeColor = Color.Red
            Label_Status.Text = "Error: " & ex.Message
        End Try
    End Sub

    ' -------------------------------
    '         FIXED NAVIGATION
    ' -------------------------------

    Private Sub Btn_Transaction_Click(sender As Object, e As EventArgs) Handles Btn_Transaction.Click
        Dim transactionForm As New Dashboard()
        transactionForm.StartPosition = FormStartPosition.CenterScreen
        transactionForm.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        Dim GoToExpense As New Expense()
        GoToExpense.StartPosition = FormStartPosition.CenterScreen
        GoToExpense.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Statistic_Click(sender As Object, e As EventArgs) Handles Btn_Statistic.Click
        Dim GoToStatistic As New Statistic()
        GoToStatistic.StartPosition = FormStartPosition.CenterScreen
        GoToStatistic.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Dim Logout As New LoginForm()
        Logout.StartPosition = FormStartPosition.CenterScreen
        Logout.Show()
        Me.Close()
    End Sub

    Private Sub Label_Status_Click(sender As Object, e As EventArgs) Handles Label_Status.Click

    End Sub
End Class
