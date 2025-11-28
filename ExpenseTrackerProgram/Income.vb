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
            If String.IsNullOrWhiteSpace(incomeText) Or String.IsNullOrWhiteSpace(incomeSource) Or String.IsNullOrWhiteSpace(incomeCategory) Then
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

            ' Insert into database
            Dim connectionString As String = "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"
            Dim query As String = "INSERT INTO IncomeTB (Income_Amount, Income_Source, Income_Category) " &
                                  "VALUES (@Income_Amount, @Income_Source, @Income_Category)"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Income_Amount", incomeAmount)
                    command.Parameters.AddWithValue("@Income_Source", incomeSource)
                    command.Parameters.AddWithValue("@Income_Category", incomeCategory)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Clear inputs
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
End Class
