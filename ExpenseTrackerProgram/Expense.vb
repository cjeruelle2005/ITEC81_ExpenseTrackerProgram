Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Expense

    Private Sub Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Label_Status.Text = ""

        Try
            Dim ItemName As String = Text_Item.Text.Trim()
            Dim categoryText As String = Combo_Category.Text.Trim()
            Dim amountText As String = Text_Amount.Text.Trim()
            Dim dateValue As DateTime = DateTimeExpense.Value
            Dim description As String = Text_Description.Text.Trim()   ' OPTIONAL FIELD

            ' Validate required fields (Description NOT required)
            If String.IsNullOrWhiteSpace(ItemName) OrElse
               String.IsNullOrWhiteSpace(categoryText) OrElse
               String.IsNullOrWhiteSpace(amountText) Then

                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please fill in ALL required fields."
                Exit Sub
            End If

            ' Validate Amount
            Dim amountValue As Decimal
            If Not Decimal.TryParse(amountText, amountValue) Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please enter a valid amount."
                Exit Sub
            End If

            Dim connectionString As String =
                "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' INSERT INTO Expense_TB
                Dim query1 As String =
                    "INSERT INTO Expense_TB (Item, Category, ExpenseAmount, Descriptions, Expense_Date, Users_ID) 
                     VALUES (@Item, @Category, @ExpenseAmount, @Descriptions, @Expense_Date, @Users_ID)"

                Using command1 As New SqlCommand(query1, connection)
                    command1.Parameters.AddWithValue("@Item", ItemName)
                    command1.Parameters.AddWithValue("@Category", categoryText)
                    command1.Parameters.AddWithValue("@ExpenseAmount", amountValue)
                    command1.Parameters.AddWithValue("@Descriptions", description)
                    command1.Parameters.AddWithValue("@Expense_Date", dateValue)
                    command1.Parameters.AddWithValue("@Users_ID", Users_ID)
                    command1.ExecuteNonQuery()
                End Using

                ' INSERT INTO Transaction_TB (INCLUDING DESCRIPTION)
                Dim query2 As String =
                    "INSERT INTO Transaction_TB (Item, Category, Money_Spend, Descriptions, Users_ID)
                     VALUES (@Item, @Category, @Money_Spend, @Descriptions, @Users_ID)"

                Using command2 As New SqlCommand(query2, connection)
                    command2.Parameters.AddWithValue("@Item", ItemName)
                    command2.Parameters.AddWithValue("@Category", categoryText)
                    command2.Parameters.AddWithValue("@Money_Spend", amountValue)
                    command2.Parameters.AddWithValue("@Descriptions", description)
                    command2.Parameters.AddWithValue("@Users_ID", Users_ID)
                    command2.ExecuteNonQuery()
                End Using

            End Using

            ' Update Dashboard Balances
            UpdateBalancesFromDatabase()

            ' Clear Inputs
            Combo_Category.SelectedIndex = -1
            Text_Item.Clear()
            Text_Amount.Clear()
            Text_Description.Clear()
            DateTimeExpense.Value = DateTime.Now

            Label_Status.ForeColor = Color.Green
            Label_Status.Text = "Added!"

        Catch ex As Exception
            Label_Status.ForeColor = Color.Red
            Label_Status.Text = "Error: " & ex.Message
        End Try
    End Sub

    ' Recalculate balances and update Dashboard
    Private Sub UpdateBalancesFromDatabase()
        Dim connectionString As String =
            "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Total Income
                Dim incomeCmd As New SqlCommand(
                    "SELECT ISNULL(SUM(Income_Amount),0) FROM IncomeTB WHERE Users_ID=@Users_ID", connection)
                incomeCmd.Parameters.AddWithValue("@Users_ID", Users_ID)
                Dim totalIncome = Convert.ToDecimal(incomeCmd.ExecuteScalar())

                ' Total Spend
                Dim spendCmd As New SqlCommand(
                    "SELECT ISNULL(SUM(ExpenseAmount),0) FROM Expense_TB WHERE Users_ID=@Users_ID", connection)
                spendCmd.Parameters.AddWithValue("@Users_ID", Users_ID)
                Dim totalSpend = Convert.ToDecimal(spendCmd.ExecuteScalar())

                ' Update Session
                SessionModule.Balance = totalIncome - totalSpend
                SessionModule.TotalSpend = totalSpend
            End Using

            ' Update Dashboard UI if open
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is Dashboard Then
                    CType(frm, Dashboard).Label_Balance.Text = SessionModule.Balance.ToString("C2")
                    CType(frm, Dashboard).Label_TotalSpend.Text = SessionModule.TotalSpend.ToString("C2")
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error updating balances: " & ex.Message)
        End Try
    End Sub

    ' -----------------------------------
    '       FIXED NAVIGATION BUTTONS
    ' -----------------------------------

    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoToIncome As New Income()
        GoToIncome.StartPosition = FormStartPosition.CenterScreen
        GoToIncome.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Transaction_Click(sender As Object, e As EventArgs) Handles Btn_Transaction.Click
        Dim GoToTransaction As New Dashboard()
        GoToTransaction.StartPosition = FormStartPosition.CenterScreen
        GoToTransaction.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Dim Logout As New LoginForm()
        Logout.StartPosition = FormStartPosition.CenterScreen
        Logout.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Statistic_Click(sender As Object, e As EventArgs) Handles Btn_Statistic.Click
        Dim GoToStatistic As New Statistic()
        GoToStatistic.StartPosition = FormStartPosition.CenterScreen
        GoToStatistic.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        ' Already in Expense page
    End Sub

    Private Sub Combo_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Category.SelectedIndexChanged

    End Sub

    Private Sub Label_Status_Click(sender As Object, e As EventArgs) Handles Label_Status.Click

    End Sub
End Class
