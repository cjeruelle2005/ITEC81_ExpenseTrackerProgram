Public Class Dashboard
    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoToIncome As New Income()
        GoToIncome.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        Dim GoToExpense As New Expense()
        GoToExpense.Show()
        Me.Hide()
    End Sub
End Class