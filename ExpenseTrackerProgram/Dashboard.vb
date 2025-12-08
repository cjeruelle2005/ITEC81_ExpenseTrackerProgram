Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Dashboard

    ' Class to store transaction info
    Private Class TransactionInfo
        Public Property ID As Integer
        Public Property DateValue As Date
        Public Property Category As String
        Public Property Item As String
        Public Property AmountStr As String
        Public Property Description As String
        Public Property Source As String
        Public Property IsIncome As Boolean ' To differentiate Income vs Expense
    End Class

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure FlowLayoutPanel
        FLP_Transaction.Size = New Size(1000, 350)
        FLP_Transaction.AutoScroll = True
        FLP_Transaction.FlowDirection = FlowDirection.TopDown
        FLP_Transaction.WrapContents = False
        FLP_Transaction.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        ' Load all transactions initially
        LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
    End Sub

    Private Sub LoadTransactions(Optional searchTerm As String = "", Optional selectedDate As Date? = Nothing)
        FLP_Transaction.Controls.Clear()

        Dim connectionString As String =
            "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

        ' Get both Income and Expense transactions
        Dim query As String =
            "SELECT Transaction_ID, T_Date, Category, Money_Spend, Money_Added, Source, Descriptions, Item
             FROM Transaction_TB
             WHERE Users_ID=@Users_ID"

        ' Apply search filter
        If Not String.IsNullOrEmpty(searchTerm) Then
            query &= " AND (Category LIKE '%' + @Search + '%' 
                        OR Descriptions LIKE '%' + @Search + '%' 
                        OR Source LIKE '%' + @Search + '%'
                        OR Item LIKE '%' + @Search + '%')"
        End If

        ' Apply Date filter
        If selectedDate.HasValue Then
            query &= " AND CAST(T_Date AS DATE) = @SelectedDate"
        End If

        query &= " ORDER BY T_Date DESC"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Users_ID", Users_ID)
                If Not String.IsNullOrEmpty(searchTerm) Then cmd.Parameters.AddWithValue("@Search", searchTerm)
                If selectedDate.HasValue Then cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Value.Date)

                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim transactionID As Integer = reader("Transaction_ID")
                        Dim tDate As Date = Convert.ToDateTime(reader("T_Date"))
                        Dim category As String = reader("Category").ToString()
                        Dim item As String = If(IsDBNull(reader("Item")), "", reader("Item").ToString())
                        Dim spend As Decimal = If(IsDBNull(reader("Money_Spend")), 0D, Convert.ToDecimal(reader("Money_Spend")))
                        Dim added As Decimal = If(IsDBNull(reader("Money_Added")), 0D, Convert.ToDecimal(reader("Money_Added")))
                        Dim description As String = If(IsDBNull(reader("Descriptions")), "", reader("Descriptions").ToString())
                        Dim source As String = If(IsDBNull(reader("Source")), "", reader("Source").ToString())

                        Dim isIncome As Boolean = added > 0
                        Dim amount As Decimal = If(isIncome, added, spend)
                        Dim sign As String = If(isIncome, "+", "-")
                        Dim amountStr As String = sign & amount.ToString("N2")

                        ' Display Category for expenses, Category for income as well
                        Dim displayText As String = ""
                        If isIncome Then
                            displayText = tDate.ToString("yyyy/MM/dd").PadRight(15) & category.PadRight(20) & amountStr.PadLeft(12)
                        Else
                            displayText = tDate.ToString("yyyy/MM/dd").PadRight(15) & category.PadRight(20) & amountStr.PadLeft(12)
                        End If

                        Dim btn As New Button()
                        btn.Text = displayText
                        btn.Tag = New TransactionInfo With {
                            .ID = transactionID,
                            .DateValue = tDate,
                            .Category = category,
                            .Item = item,
                            .AmountStr = amountStr,
                            .Description = description,
                            .Source = source,
                            .IsIncome = isIncome
                        }
                        btn.Width = FLP_Transaction.ClientSize.Width - 25
                        btn.Height = 40
                        btn.Font = New Font("Consolas", 11, FontStyle.Regular)
                        btn.TextAlign = ContentAlignment.MiddleLeft
                        btn.BackColor = Color.WhiteSmoke

                        AddHandler btn.Click, AddressOf Transaction_Clicked
                        FLP_Transaction.Controls.Add(btn)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Transaction_Clicked(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim info As TransactionInfo = CType(btn.Tag, TransactionInfo)

        Dim fontRegular As New Font("Microsoft Sans Serif", 14, FontStyle.Regular)
        Dim fontBold As New Font("Microsoft Sans Serif", 14, FontStyle.Bold)

        Dim popup As New Form()
        popup.Text = "Transaction Details"
        popup.StartPosition = FormStartPosition.CenterParent
        popup.FormBorderStyle = FormBorderStyle.FixedDialog
        popup.MaximizeBox = False
        popup.MinimizeBox = False
        popup.AutoScroll = True

        Dim yPos As Integer = 20
        Dim labels As New Dictionary(Of String, String)

        If info.IsIncome Then
            labels = New Dictionary(Of String, String) From {
                {"Category:", info.Category},
                {"Source:", info.Source},
                {"Amount:", info.AmountStr},
                {"Date:", info.DateValue.ToString("yyyy/MM/dd")},
                {"Description:", info.Description}
            }
        Else
            labels = New Dictionary(Of String, String) From {
                {"Item:", info.Item},
                {"Category:", info.Category},
                {"Amount:", info.AmountStr},
                {"Description:", info.Description}
            }
        End If

        Dim maxWidth As Integer = 0
        For Each kvp In labels
            Dim lblBold As New Label()
            lblBold.Text = kvp.Key
            lblBold.Font = fontBold
            lblBold.Location = New Point(20, yPos)
            lblBold.AutoSize = True
            popup.Controls.Add(lblBold)

            Dim lblVal As New Label()
            lblVal.Text = kvp.Value
            lblVal.Font = fontRegular
            lblVal.Location = New Point(150, yPos)
            lblVal.AutoSize = True
            popup.Controls.Add(lblVal)

            yPos += Math.Max(lblBold.Height, lblVal.Height) + 10
            maxWidth = Math.Max(maxWidth, lblBold.Width + lblVal.Width + 50)
        Next

        ' Buttons
        Dim btnOK As New Button()
        btnOK.Text = "OK"
        btnOK.Size = New Size(100, 40)
        btnOK.Location = New Point(30, yPos)
        btnOK.Font = fontBold
        AddHandler btnOK.Click, Sub(s, ev) popup.Close()
        popup.Controls.Add(btnOK)

        Dim btnUpdate As New Button()
        btnUpdate.Text = "Update"
        btnUpdate.Size = New Size(100, 40)
        btnUpdate.Location = New Point(180, yPos)
        btnUpdate.Font = fontBold
        AddHandler btnUpdate.Click, Sub(s, ev) MessageBox.Show($"Update clicked for Transaction ID: {info.ID}")
        popup.Controls.Add(btnUpdate)

        Dim btnDelete As New Button()
        btnDelete.Text = "Delete"
        btnDelete.Size = New Size(100, 40)
        btnDelete.Location = New Point(330, yPos)
        btnDelete.Font = fontBold
        AddHandler btnDelete.Click, Sub(s, ev) MessageBox.Show($"Delete clicked for Transaction ID: {info.ID}")
        popup.Controls.Add(btnDelete)

        Dim maxHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height * 0.8
        popup.ClientSize = New Size(Math.Max(500, maxWidth), Math.Min(yPos + 80, maxHeight))
        popup.ShowDialog()
    End Sub

    ' Buttons for navigation
    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoToIncome As New Income()
        GoToIncome.Location = Me.Location()
        Me.Hide()
        GoToIncome.ShowDialog()
    End Sub

    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        Dim GoToExpense As New Expense()
        Me.Hide()
        GoToExpense.ShowDialog()
    End Sub

    Private Sub Search_Bar_TextChanged(sender As Object, e As EventArgs) Handles Search_Bar.TextChanged
        LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
    End Sub

    Private Sub T_DateTime_ValueChanged(sender As Object, e As EventArgs) Handles T_DateTime.ValueChanged
        LoadTransactions(Search_Bar.Text.Trim(), T_DateTime.Value.Date)
    End Sub
End Class
