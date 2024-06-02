Imports System.Data.SqlClient

Public Class portfolio_page

    Public ConnectionString As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
        stock_page.Show()

    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
        home_page.Show()

    End Sub

    Private Sub portfolio_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_infoDataSet4.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.User_infoDataSet4.Transactions)
        Dim ConnectionString As String = "Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False"
        Dim ConnectonString As New SqlConnection(ConnectionString)
        Try
            Dim username As String = usrnme_label.Text
            Dim availableBalance As Decimal = GetAvailableBalanceByUsername(ConnectionString, username)

            ' Display the available balance in the label
            Label5.Text = $"{availableBalance}"
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Function GetAvailableBalanceByUsername(ConnectionString As String, username As String) As Decimal
        Dim availableBalance As Decimal = 0

        Try
            Using con As New SqlConnection(ConnectionString)
                con.Open()

                Dim query As String = "SELECT Available_balance FROM Users WHERE Username = @Username"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        availableBalance = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception($"Error fetching available balance: {ex.Message}")
        End Try

        Return availableBalance
    End Function

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Close()
        home_page.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
            Try
                ' Get the current user's ID based on their username
                Dim username As String = home_page.usrnme_label.Text ' Assuming this is how you get the username
            Dim userID As Integer = GetUserIDByUsername("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False", username)

            ' Connect to the database
            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
                connection.Open()

                ' SQL query to fetch stock details for Buy transactions of the current user
                Dim query As String = "SELECT StockName, Price, QtyBought, TransactionDate FROM Transactions WHERE UserID = @UserID AND Type = 'Buy'"

                ' Create a command with parameters
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)

                    ' Create a data adapter and a data table
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()

                        ' Fill the data table with the results of the query
                        adapter.Fill(dataTable)

                        ' Bind the data table to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable

                        ' Display column names in the DataGridView
                        Guna2DataGridView1.ColumnHeadersVisible = True
                    End Using
                End Using
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
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Try
            ' Get the current user's ID based on their username
            Dim username As String = home_page.usrnme_label.Text ' Assuming this is how you get the username
            Dim userID As Integer = GetUserIDByUsername("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False", username)

            ' Connect to the database
            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
                connection.Open()

                ' SQL query to fetch stock details for Sell transactions of the current user
                Dim query As String = "SELECT StockName, Price, QtyBought, TransactionDate FROM Transactions WHERE UserID = @UserID AND Type = 'Sell'"

                ' Create a command with parameters
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)

                    ' Create a data adapter and a data table
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()

                        ' Fill the data table with the results of the query
                        adapter.Fill(dataTable)

                        ' Bind the data table to the DataGridView
                        Guna2DataGridView2.DataSource = dataTable

                        ' Display column names in the DataGridView
                        Guna2DataGridView2.ColumnHeadersVisible = True
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        home_page.Show()

    End Sub
End Class

