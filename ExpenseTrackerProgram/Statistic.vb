Public Class Statistic
    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        Dim GoToExpense As New Expense()
        GoToExpense.Show()
        Me.Hide()
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

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Dim GoToLogin As New LoginForm()
        GoToLogin.Show()
        Me.Hide()
    End Sub
End Class