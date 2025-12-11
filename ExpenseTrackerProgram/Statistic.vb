Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Data.SqlClient

Public Class Statistic

    Private Sub Statistic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
        Try
            ' Load Pie Chart
            LoadExpensePieChart()

            ' Setup ComboBox for period selection
            Combo_Dates.Items.Clear()
            Combo_Dates.Items.AddRange({"Daily", "Monthly", "Yearly"})
            Combo_Dates.SelectedIndex = 0

            ' Load initial Bar Chart
            LoadExpenseBarChart(Combo_Dates.SelectedItem.ToString())
        Catch ex As Exception
            MessageBox.Show("Error loading Statistic: " & ex.Message)
        End Try
    End Sub

    ' ------------------- PIE CHART -------------------
    Private Sub LoadExpensePieChart()
        Dim connectionString As String =
            "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String =
                "SELECT Category, SUM(ExpenseAmount) AS TotalSpent
                 FROM Expense_TB
                 WHERE Users_ID=@Users_ID
                 GROUP BY Category
                 ORDER BY TotalSpent DESC"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Users_ID", Users_ID)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                Expense_Chart.Series.Clear()
                Expense_Chart.ChartAreas.Clear()
                Expense_Chart.Legends.Clear()
                Expense_Chart.ChartAreas.Add(New ChartArea("PieArea"))

                Dim legend As New Legend("Legend")
                legend.Docking = Docking.Right
                legend.Font = New Font("Microsoft Sans Serif", 11)
                legend.LegendStyle = LegendStyle.Table
                legend.TableStyle = LegendTableStyle.Wide
                Expense_Chart.Legends.Add(legend)

                Dim totalExpense As Decimal = dt.AsEnumerable().Sum(Function(r) Convert.ToDecimal(r("TotalSpent")))
                Dim series As New Series("Expenses")
                series.ChartType = SeriesChartType.Pie
                series.ChartArea = "PieArea"
                series.Legend = "Legend"
                series.IsValueShownAsLabel = True
                series.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
                series.LabelForeColor = Color.White

                For Each row As DataRow In dt.Rows
                    Dim categoryName As String = row("Category").ToString()
                    Dim total As Decimal = Convert.ToDecimal(row("TotalSpent"))
                    Dim percent As Decimal = If(totalExpense > 0, Math.Round(total / totalExpense * 100, 1), 0)
                    Dim point As New DataPoint()
                    point.YValues = New Double() {CDbl(percent)}
                    point.Label = percent.ToString("0.#") & "%"
                    point.LegendText = categoryName
                    series.Points.Add(point)
                Next

                Expense_Chart.Series.Add(series)
            End Using
        End Using
    End Sub

    ' ------------------- BAR CHART -------------------
    Private Sub LoadExpenseBarChart(periodType As String)
        Dim connectionString As String =
            "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = ""

            Select Case periodType
                Case "Daily"
                    query = "SELECT CONVERT(VARCHAR(10), Expense_Date, 120) AS Period, Category, SUM(ExpenseAmount) AS TotalSpent
                             FROM Expense_TB
                             WHERE Users_ID=@Users_ID
                             GROUP BY CONVERT(VARCHAR(10), Expense_Date, 120), Category
                             ORDER BY Period ASC"
                Case "Monthly"
                    query = "SELECT FORMAT(Expense_Date,'yyyy-MM') AS Period, Category, SUM(ExpenseAmount) AS TotalSpent
                             FROM Expense_TB
                             WHERE Users_ID=@Users_ID
                             GROUP BY FORMAT(Expense_Date,'yyyy-MM'), Category
                             ORDER BY Period ASC"
                Case "Yearly"
                    query = "SELECT YEAR(Expense_Date) AS Period, Category, SUM(ExpenseAmount) AS TotalSpent
                             FROM Expense_TB
                             WHERE Users_ID=@Users_ID
                             GROUP BY YEAR(Expense_Date), Category
                             ORDER BY Period ASC"
            End Select

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Users_ID", Users_ID)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                Expense_Bar.Series.Clear()
                Expense_Bar.ChartAreas.Clear()
                Expense_Bar.Legends.Clear()
                Expense_Bar.ChartAreas.Add(New ChartArea("BarArea"))

                Dim legend As New Legend("Legend")
                legend.Docking = Docking.Top
                legend.Font = New Font("Microsoft Sans Serif", 11)
                Expense_Bar.Legends.Add(legend)

                Dim categories = dt.AsEnumerable().Select(Function(r) r("Category").ToString()).Distinct().ToList()
                Dim periods = dt.AsEnumerable().Select(Function(r) r("Period").ToString()).Distinct().OrderBy(Function(p) p).ToList()

                ' Create series for each category
                For Each cat In categories
                    Dim series As New Series(cat)
                    series.ChartType = SeriesChartType.Column
                    series.ChartArea = "BarArea"
                    series.Legend = "Legend"
                    series.IsValueShownAsLabel = True
                    series.Font = New Font("Microsoft Sans Serif", 10)
                    Expense_Bar.Series.Add(series)
                Next

                ' Add data points for each period
                For Each period In periods
                    Dim totalPeriod As Decimal = dt.AsEnumerable().
                        Where(Function(r) r("Period").ToString() = period).
                        Sum(Function(r) Convert.ToDecimal(r("TotalSpent")))

                    For Each cat In categories
                        Dim found = dt.AsEnumerable().FirstOrDefault(Function(r) r("Period").ToString() = period And r("Category").ToString() = cat)
                        Dim value As Decimal = If(found IsNot Nothing And totalPeriod > 0,
                                                   Math.Round(Convert.ToDecimal(found("TotalSpent")) / totalPeriod * 100, 1),
                                                   0D)
                        Expense_Bar.Series(cat).Points.AddXY(period, value)
                        Expense_Bar.Series(cat).Points.Last().Label = value.ToString("0.#") & "%"
                    Next
                Next

                ' Format X-axis
                With Expense_Bar.ChartAreas("BarArea").AxisX
                    .Interval = 1
                    .LabelStyle.Angle = 0
                    .LabelStyle.IsStaggered = False
                    .LabelStyle.Font = New Font("Microsoft Sans Serif", 10)
                End With

                ' Format Y-axis
                With Expense_Bar.ChartAreas("BarArea").AxisY
                    .LabelStyle.Font = New Font("Microsoft Sans Serif", 10)
                    .Title = "Percentage (%)"
                    .TitleFont = New Font("Microsoft Sans Serif", 12)
                    .Maximum = 100
                End With
            End Using
        End Using
    End Sub

    ' ------------------- COMBOBOX CHANGE -------------------
    Private Sub Combo_Dates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Dates.SelectedIndexChanged
        LoadExpenseBarChart(Combo_Dates.SelectedItem.ToString())
    End Sub

    ' ------------------- NAVIGATION BUTTONS -------------------

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Dim Logout As New LoginForm()
        Logout.StartPosition = FormStartPosition.CenterScreen
        Logout.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Transaction_Click(sender As Object, e As EventArgs) Handles Btn_Transaction.Click
        Dim GoToTransaction As New Dashboard()
        GoToTransaction.StartPosition = FormStartPosition.CenterScreen
        GoToTransaction.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Income_Click(sender As Object, e As EventArgs) Handles Btn_Income.Click
        Dim GoToIncome As New Income()
        GoToIncome.StartPosition = FormStartPosition.CenterScreen
        GoToIncome.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Expense_Click(sender As Object, e As EventArgs) Handles Btn_Expense.Click
        Dim GoToExpense As New Expense()
        GoToExpense.StartPosition = FormStartPosition.CenterScreen
        GoToExpense.Show()
        Me.Close()
    End Sub

End Class
