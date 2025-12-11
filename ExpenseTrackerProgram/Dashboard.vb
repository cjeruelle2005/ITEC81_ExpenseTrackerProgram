Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Dashboard

    ' Class to store transaction info
    Private Class TransactionInfo
        Public Property ID As Integer
        Public Property DateValue As Date
        Public Property Category As String
        Public Property AmountStr As String
        Public Property Description As String
        Public Property Source As String
        Public Property Type As String ' "Income" or "Expense"
    End Class

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Configure FlowLayoutPanel
        FLP_Transaction.Size = New Size(1420, 350)
        FLP_Transaction.AutoScroll = True
        FLP_Transaction.FlowDirection = FlowDirection.TopDown
        FLP_Transaction.WrapContents = False
        FLP_Transaction.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        ' Load transactions for the current user
        LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
        UpdateBalances()
    End Sub

    ' Load transactions filtered by search term and date
    Public Sub LoadTransactions(Optional searchTerm As String = "", Optional selectedDate As Date? = Nothing)
        FLP_Transaction.Controls.Clear()

        Dim connectionString As String =
            "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

        ' Base query
        Dim baseQuery As String =
            "SELECT 
                Transaction_ID,
                T_Date,
                Category,
                Money_Added,
                Money_Spend,
                Descriptions,
                Source,
                Type
            FROM
            (
                SELECT 
                    Transaction_ID,
                    T_Date,
                    Category,
                    Money_Added,
                    Money_Spend,
                    Descriptions,
                    Source,
                    'Income' AS Type
                FROM Transaction_TB
                WHERE Users_ID=@Users_ID AND Money_Added IS NOT NULL

                UNION ALL

                SELECT 
                    Transaction_ID,
                    T_Date,
                    Category,
                    Money_Added,
                    Money_Spend,
                    Descriptions,
                    Source,
                    'Expense' AS Type
                FROM Transaction_TB
                WHERE Users_ID=@Users_ID AND Money_Spend IS NOT NULL
            ) AS T WHERE 1=1
            "

        ' Search filter
        If Not String.IsNullOrEmpty(searchTerm) Then
            baseQuery &= " AND (Category LIKE '%' + @Search + '%' 
                            OR Descriptions LIKE '%' + @Search + '%' 
                            OR Source LIKE '%' + @Search + '%')"
        End If

        ' Date filter
        If selectedDate.HasValue Then
            baseQuery &= " AND CAST(T_Date AS DATE) = @SelectedDate"
        End If

        baseQuery &= " ORDER BY T_Date DESC"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(baseQuery, conn)
                cmd.Parameters.AddWithValue("@Users_ID", Users_ID)
                If Not String.IsNullOrEmpty(searchTerm) Then cmd.Parameters.AddWithValue("@Search", searchTerm)
                If selectedDate.HasValue Then cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Value.Date)

                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim transactionID As Integer = reader("Transaction_ID")
                        Dim tDate As Date = Convert.ToDateTime(reader("T_Date"))
                        Dim category As String = reader("Category").ToString()
                        Dim added As Decimal = If(IsDBNull(reader("Money_Added")), 0D, Convert.ToDecimal(reader("Money_Added")))
                        Dim spend As Decimal = If(IsDBNull(reader("Money_Spend")), 0D, Convert.ToDecimal(reader("Money_Spend")))
                        Dim description As String = If(IsDBNull(reader("Descriptions")), "", reader("Descriptions").ToString())
                        Dim source As String = If(IsDBNull(reader("Source")), "", reader("Source").ToString())
                        Dim type As String = reader("Type").ToString()

                        Dim amount As Decimal
                        Dim sign As String
                        If type = "Income" Then
                            amount = added
                            sign = "+"
                        Else
                            amount = spend
                            sign = "-"
                        End If
                        Dim amountStr As String = sign & amount.ToString("N2")

                        Dim lineText As String = category.PadRight(20) & amountStr.PadLeft(12)

                        Dim btn As New Button()
                        btn.Text = lineText
                        btn.Tag = New TransactionInfo With {
                            .ID = transactionID,
                            .DateValue = tDate,
                            .Category = category,
                            .AmountStr = amountStr,
                            .Description = description,
                            .Source = source,
                            .Type = type
                        }
                        btn.Width = FLP_Transaction.ClientSize.Width - 25
                        btn.Height = 40
                        btn.Font = New Font("Consolas", 11, FontStyle.Regular)
                        btn.TextAlign = ContentAlignment.MiddleLeft
                        btn.BackColor = If(type = "Income", Color.LightGreen, Color.LightSalmon)

                        AddHandler btn.Click, AddressOf Transaction_Clicked
                        FLP_Transaction.Controls.Add(btn)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Display dynamic popup with Update & Delete
    Private Sub Transaction_Clicked(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim info As TransactionInfo = CType(btn.Tag, TransactionInfo)

        Dim fontRegular As New Font("Microsoft Sans Serif", 14, FontStyle.Regular)
        Dim fontBold As New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        Dim fontTextBox As New Font("Microsoft Sans Serif", 14, FontStyle.Regular)

        Dim popup As New Form()
        popup.Text = info.Type & " Details"
        popup.StartPosition = FormStartPosition.CenterParent
        popup.FormBorderStyle = FormBorderStyle.FixedDialog
        popup.MaximizeBox = False
        popup.MinimizeBox = False
        popup.AutoScroll = True

        Dim yPos As Integer = 20

        ' Category
        Dim lblCategory As New Label() With {.Text = "Category:", .Font = fontBold, .Location = New Point(20, yPos), .AutoSize = True}
        Dim txtCategory As New TextBox() With {.Text = info.Category, .Location = New Point(150, yPos), .Width = 200, .Font = fontTextBox}
        popup.Controls.Add(lblCategory)
        popup.Controls.Add(txtCategory)
        yPos += 40

        ' Amount - decimal only
        Dim lblAmount As New Label() With {.Text = "Amount:", .Font = fontBold, .Location = New Point(20, yPos), .AutoSize = True}
        Dim txtAmount As New TextBox() With {.Text = info.AmountStr.Replace("+", "").Replace("-", ""), .Location = New Point(150, yPos), .Width = 200, .Font = fontTextBox}
        AddHandler txtAmount.KeyPress, Sub(sender2, e2)
                                           Dim tb = CType(sender2, TextBox)
                                           If Char.IsControl(e2.KeyChar) Then Return
                                           If Char.IsDigit(e2.KeyChar) Then Return
                                           If e2.KeyChar = "."c AndAlso Not tb.Text.Contains(".") Then Return
                                           e2.Handled = True
                                       End Sub
        popup.Controls.Add(lblAmount)
        popup.Controls.Add(txtAmount)
        yPos += 40

        ' Description
        Dim lblDescription As New Label() With {.Text = "Description:", .Font = fontBold, .Location = New Point(20, yPos), .AutoSize = True}
        Dim txtDescription As New TextBox() With {.Text = info.Description, .Location = New Point(150, yPos), .Width = 200, .Font = fontTextBox}
        popup.Controls.Add(lblDescription)
        popup.Controls.Add(txtDescription)
        yPos += 40

        ' Date
        Dim lblDate As New Label() With {.Text = "Date:", .Font = fontBold, .Location = New Point(20, yPos), .AutoSize = True}
        Dim dtPicker As New DateTimePicker() With {.Value = info.DateValue, .Location = New Point(150, yPos), .Font = fontTextBox}
        popup.Controls.Add(lblDate)
        popup.Controls.Add(dtPicker)
        yPos += 50

        ' OK button
        Dim btnOK As New Button() With {.Text = "OK", .Size = New Size(100, 40), .Location = New Point(30, yPos), .Font = fontBold}
        AddHandler btnOK.Click, Sub(s, ev) popup.Close()
        popup.Controls.Add(btnOK)

        ' UPDATE button
        Dim btnUpdate As New Button() With {.Text = "Update", .Size = New Size(100, 40), .Location = New Point(150, yPos), .Font = fontBold}
        AddHandler btnUpdate.Click, Sub(s, ev)
                                        Try
                                            Dim connectionString As String =
                                                "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

                                            Using conn As New SqlConnection(connectionString)
                                                conn.Open()
                                                Dim updateCmd As New SqlCommand(
                                                    "UPDATE Transaction_TB 
                                                     SET Category=@Category, Money_Added=@Money_Added, Money_Spend=@Money_Spend, 
                                                         Descriptions=@Descriptions, T_Date=@T_Date
                                                     WHERE Transaction_ID=@ID", conn)

                                                Dim amountValue As Decimal
                                                Decimal.TryParse(txtAmount.Text, amountValue)

                                                If info.Type = "Income" Then
                                                    updateCmd.Parameters.AddWithValue("@Money_Added", amountValue)
                                                    updateCmd.Parameters.AddWithValue("@Money_Spend", DBNull.Value)
                                                Else
                                                    updateCmd.Parameters.AddWithValue("@Money_Added", DBNull.Value)
                                                    updateCmd.Parameters.AddWithValue("@Money_Spend", amountValue)
                                                End If

                                                updateCmd.Parameters.AddWithValue("@Category", txtCategory.Text)
                                                updateCmd.Parameters.AddWithValue("@Descriptions", txtDescription.Text)
                                                updateCmd.Parameters.AddWithValue("@T_Date", dtPicker.Value.Date)
                                                updateCmd.Parameters.AddWithValue("@ID", info.ID)
                                                updateCmd.ExecuteNonQuery()

                                                ' Update Expense_TB if Expense
                                                If info.Type = "Expense" Then
                                                    Dim updateExpense As New SqlCommand(
                                                        "UPDATE Expense_TB 
                                                         SET Category=@Category, ExpenseAmount=@Amount, Descriptions=@Description, Expense_Date=@Date
                                                         WHERE Users_ID=@Users_ID AND Item=@Item", conn)
                                                    updateExpense.Parameters.AddWithValue("@Category", txtCategory.Text)
                                                    updateExpense.Parameters.AddWithValue("@Amount", amountValue)
                                                    updateExpense.Parameters.AddWithValue("@Description", txtDescription.Text)
                                                    updateExpense.Parameters.AddWithValue("@Date", dtPicker.Value.Date)
                                                    updateExpense.Parameters.AddWithValue("@Users_ID", Users_ID)
                                                    updateExpense.Parameters.AddWithValue("@Item", info.Category)
                                                    updateExpense.ExecuteNonQuery()
                                                End If
                                            End Using

                                            LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
                                            UpdateBalances()
                                            MessageBox.Show("Transaction updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            popup.Close()
                                        Catch ex As Exception
                                            MessageBox.Show("Error updating transaction: " & ex.Message)
                                        End Try
                                    End Sub
        popup.Controls.Add(btnUpdate)

        ' DELETE button
        Dim btnDelete As New Button() With {.Text = "Delete", .Size = New Size(100, 40), .Location = New Point(270, yPos), .Font = fontBold}
        AddHandler btnDelete.Click, Sub(s, ev)
                                        Dim result = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                                        If result = DialogResult.Yes Then
                                            Try
                                                Dim connectionString As String =
                                                    "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"
                                                Using conn As New SqlConnection(connectionString)
                                                    conn.Open()
                                                    Dim deleteCmd As New SqlCommand("DELETE FROM Transaction_TB WHERE Transaction_ID=@ID", conn)
                                                    deleteCmd.Parameters.AddWithValue("@ID", info.ID)
                                                    deleteCmd.ExecuteNonQuery()

                                                    ' Remove from Expense_TB if Expense
                                                    If info.Type = "Expense" Then
                                                        Dim deleteExpense As New SqlCommand("DELETE FROM Expense_TB WHERE Item=@Item AND Category=@Category AND Users_ID=@Users_ID", conn)
                                                        deleteExpense.Parameters.AddWithValue("@Item", info.Category)
                                                        deleteExpense.Parameters.AddWithValue("@Category", info.Category)
                                                        deleteExpense.Parameters.AddWithValue("@Users_ID", Users_ID)
                                                        deleteExpense.ExecuteNonQuery()
                                                    End If
                                                End Using

                                                MessageBox.Show("Transaction deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
                                                UpdateBalances()
                                                popup.Close()
                                            Catch ex As Exception
                                                MessageBox.Show("Error deleting transaction: " & ex.Message)
                                            End Try
                                        End If
                                    End Sub
        popup.Controls.Add(btnDelete)

        Dim maxHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height * 0.8
        popup.ClientSize = New Size(500, Math.Min(yPos + 80, maxHeight))
        popup.ShowDialog()
    End Sub

    ' Update balances
    Private Sub UpdateBalances()
        Dim connectionString As String =
            "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim incomeCmd As New SqlCommand("SELECT ISNULL(SUM(Income_Amount),0) FROM IncomeTB WHERE Users_ID=@Users_ID", connection)
            incomeCmd.Parameters.AddWithValue("@Users_ID", Users_ID)
            Dim totalIncome = Convert.ToDecimal(incomeCmd.ExecuteScalar())

            Dim spendCmd As New SqlCommand("SELECT ISNULL(SUM(ExpenseAmount),0) FROM Expense_TB WHERE Users_ID=@Users_ID", connection)
            spendCmd.Parameters.AddWithValue("@Users_ID", Users_ID)
            Dim totalSpend = Convert.ToDecimal(spendCmd.ExecuteScalar())

            SessionModule.Balance = totalIncome - totalSpend
            SessionModule.TotalSpend = totalSpend

            Label_Balance.Text = SessionModule.Balance.ToString("C2")
            Label_TotalSpend.Text = SessionModule.TotalSpend.ToString("C2")
        End Using
    End Sub

    ' Navigation buttons and search/date filter

    ' FIXED — Income
    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoToIncome As New Income()
        GoToIncome.StartPosition = FormStartPosition.CenterScreen
        GoToIncome.Show()
        Me.Close()
    End Sub

    ' FIXED — Expense
    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        Dim GoToExpense As New Expense()
        GoToExpense.StartPosition = FormStartPosition.CenterScreen
        GoToExpense.Show()
        Me.Close()
    End Sub

    ' FIXED — Back
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Dim Logout As New LoginForm()
        Logout.StartPosition = FormStartPosition.CenterScreen
        Logout.Show()
        Me.Close()
    End Sub

    ' FIXED — Statistic
    Private Sub Btn_Statistic_Click(sender As Object, e As EventArgs) Handles Btn_Statistic.Click
        Dim GoToStatistic As New Statistic()
        GoToStatistic.StartPosition = FormStartPosition.CenterScreen
        GoToStatistic.Show()
        Me.Close()
    End Sub

    Private Sub Search_Bar_TextChanged(sender As Object, e As EventArgs) Handles Search_Bar.TextChanged
        LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
    End Sub

    Private Sub T_DateTime_ValueChanged(sender As Object, e As EventArgs) Handles T_DateTime.ValueChanged
        LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
    End Sub

End Class
