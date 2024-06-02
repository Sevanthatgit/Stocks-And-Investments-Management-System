Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices
Public Class Expense_tracker
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Dim category As String = Guna2TextBox3.Text
            Dim amount As Decimal = Decimal.Parse(Guna2TextBox4.Text)
            Dim spendingDateTime As DateTime = DateTime.Now
            Dim userID As Integer = GetUserIDByUsername("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True", home_page.usrnme_label.Text)

            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                Dim insertQuery As String = "INSERT INTO Spendings (SpendingType, Category, Amount, SpendingDateTime, UserID) VALUES (@SpendingType, @Category, @Amount, @SpendingDateTime, @UserID)"

                Using command As New SqlCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@SpendingType", "expense")
                    command.Parameters.AddWithValue("@Category", category)
                    command.Parameters.AddWithValue("@Amount", amount)
                    command.Parameters.AddWithValue("@SpendingDateTime", spendingDateTime)
                    command.Parameters.AddWithValue("@UserID", userID)

                    command.ExecuteNonQuery()
                End Using
            End Using

            LoadSpendings() ' Refresh DataGridView
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            Dim category As String = Guna2TextBox6.Text
            Dim amount As Decimal = Decimal.Parse(Guna2TextBox5.Text)
            Dim spendingDateTime As DateTime = DateTime.Now
            Dim userID As Integer = GetUserIDByUsername("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True", home_page.usrnme_label.Text)

            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                Dim insertQuery As String = "INSERT INTO Spendings (SpendingType, Category, Amount, SpendingDateTime, UserID) VALUES (@SpendingType, @Category, @Amount, @SpendingDateTime, @UserID)"

                Using command As New SqlCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@SpendingType", "income")
                    command.Parameters.AddWithValue("@Category", category)
                    command.Parameters.AddWithValue("@Amount", amount)
                    command.Parameters.AddWithValue("@SpendingDateTime", spendingDateTime)
                    command.Parameters.AddWithValue("@UserID", userID)

                    command.ExecuteNonQuery()
                End Using
            End Using

            LoadSpendings() ' Refresh DataGridView
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadSpendings()
        Try
            Dim userID As Integer = GetUserIDByUsername("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True", home_page.usrnme_label.Text)

            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                Dim selectQuery As String = "SELECT Category, Amount, SpendingDateTime FROM Spendings WHERE UserID = @UserID"
                Dim adapter As New SqlDataAdapter(selectQuery, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userID)

                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                Guna2DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetUserIDByUsername(connectionString As String, username As String) As Integer
        Dim userID As Integer = 0

        Try
            Using con As New SqlConnection(connectionString)
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim query As String = "SELECT UserID FROM Users WHERE Username = @Username"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        userID = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return userID
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Dim userID As Integer = GetUserIDByUsername("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True", home_page.usrnme_label.Text)

            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                ' Calculate the sum of income
                Dim incomeQuery As String = "SELECT SUM(Amount) FROM Spendings WHERE UserID = @UserID AND SpendingType = 'income'"
                Using incomeCommand As New SqlCommand(incomeQuery, connection)
                    incomeCommand.Parameters.AddWithValue("@UserID", userID)
                    Dim incomeSum As Object = incomeCommand.ExecuteScalar()
                    If incomeSum IsNot DBNull.Value Then
                        Label12.Text = Convert.ToDecimal(incomeSum).ToString("0.00")
                    Else
                        Label12.Text = "0.00"
                    End If
                End Using

                ' Calculate the sum of expenses
                Dim expenseQuery As String = "SELECT SUM(Amount) FROM Spendings WHERE UserID = @UserID AND SpendingType = 'expense'"
                Using expenseCommand As New SqlCommand(expenseQuery, connection)
                    expenseCommand.Parameters.AddWithValue("@UserID", userID)
                    Dim expenseSum As Object = expenseCommand.ExecuteScalar()
                    If expenseSum IsNot DBNull.Value Then
                        Label13.Text = Convert.ToDecimal(expenseSum).ToString("0.00")
                    Else
                        Label13.Text = "0.00"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Expense_tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_infoDataSet5.Spendings' table. You can move, or remove it, as needed.
        Me.SpendingsTableAdapter.Fill(Me.User_infoDataSet5.Spendings)
        Try
            ' Connect to the database
            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                ' Define the SQL command to delete all records from the Spendings table
                Dim deleteCommandText As String = "DELETE FROM Spendings;"

                ' Execute the delete command
                Using deleteCommand As New SqlCommand(deleteCommandText, connection)
                    deleteCommand.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while deleting records from Spendings table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            ' Get the total expense from Label13
            Dim totalExpense As Decimal = Decimal.Parse(Label13.Text)

            ' Dictionary to store expense data
            Dim expenseData As New Dictionary(Of String, Decimal)()

            ' Connect to the database and retrieve expense data
            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                Dim query As String = "SELECT Category, Amount FROM Spendings WHERE SpendingType = 'expense'"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim category As String = reader.GetString(0)
                            Dim amount As Decimal = reader.GetDecimal(1)
                            ' Add category and normalized expense amount to the dictionary
                            expenseData.Add(category, amount / totalExpense)
                        End While
                    End Using
                End Using
            End Using

            ' Update the pie chart with expense data
            UpdateExpenseChart(expenseData)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateExpenseChart(expenseData As Dictionary(Of String, Decimal))
        ' Clear existing series in the chart
        Chart1.Series.Clear()

        ' Add a new series to the chart
        Dim series As New Series("Expenses")
        series.ChartType = SeriesChartType.Pie

        ' Add data points to the series
        For Each kvp As KeyValuePair(Of String, Decimal) In expenseData
            ' Calculate expense amount and percentage
            Dim expenseAmount As Decimal = kvp.Value * Label13.Text
            Dim percentage As Decimal = kvp.Value * 100

            ' Add data point with label showing both amount and percentage
            series.Points.AddXY($"{kvp.Key}: {expenseAmount.ToString("C")} ({percentage.ToString("F2")}%)", kvp.Value)
        Next

        ' Add the series to the chart
        Chart1.Series.Add(series)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        home_page.Show()
    End Sub
End Class