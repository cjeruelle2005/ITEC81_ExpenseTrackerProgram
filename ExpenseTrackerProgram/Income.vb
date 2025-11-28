Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Income
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label_Status.Text = ""

        Try
            ' Validate amount
            Dim incomeAmount As Decimal
            If Not Decimal.TryParse(Text_incomeAmount.Text, incomeAmount) Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Please enter a valid amount."
                Exit Sub
            End If

            Dim incomeSource As String = Combo_Source.Text
            Dim incomeCategory As String = Combo_Category.Text

            If incomeAmount = "" Or incomeSource = "" Or incomeCategory = "" Then
                Label_Status.ForeColor = Color.Red
                Label_Status.Text = "Pleaser fill in all fields."
            End If

            Dim connectionString As String = "Server=DESKTOP-M517C16\SQLEXPRESS;Database=ExpenseTracker_DB;Integrated Security=True;Encrypt=False;"
            Dim query As String = "INSERT INTO Income_TB (Income_Amount, Income_Source, Income_Category) " &
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

