Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices

Public Class buy_stock

    Dim ConnectionString As String = "Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True"
    Dim transactionDate As Date = Date.Today
    Dim stockID As Integer
    Dim stockprice As Decimal
    Dim Quantity As Integer
    Dim username As String
    Dim stockName As String
    Dim userID As Integer




    Private Sub buystockbtn_Click(sender As Object, e As EventArgs) Handles buystockbtn.Click
        Dim transactionDate As Date = Date.Today
        Dim stockID As Integer = Convert.ToInt32(StockID_txt.Text)
        Dim stockprice As Decimal = Convert.ToDecimal(price_label.Text)
        Dim Quantity As Integer = If(Integer.TryParse(Quantity_txt.Text, Quantity), Quantity, 0)
        Dim username As String = home_page.usrnme_label.Text
        Dim stockName As String = GetStockNameByStockID(ConnectionString, stockID)
        Dim userID As Integer = GetUserIDByUsername(ConnectionString, username)
        Try
            If stockprice <= 0 Or Quantity <= 0 Then
                MessageBox.Show("Invalid Stock Price or Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Dim selectBalanceQuery As String = "SELECT Available_balance FROM Users WHERE UserID = @UserID"
                Using selectBalanceCommand As New SqlCommand(selectBalanceQuery, connection)
                    selectBalanceCommand.Parameters.AddWithValue("@UserID", userID)

                    Dim availableBalance As Decimal = Convert.ToDecimal(selectBalanceCommand.ExecuteScalar())

                    If availableBalance >= stockprice Then
                        Dim updateBalanceQuery As String = "UPDATE Users SET Available_balance = Available_balance - @StockPrice WHERE UserID = @UserID"
                        Using updateBalanceCommand As New SqlCommand(updateBalanceQuery, connection)
                            updateBalanceCommand.Parameters.AddWithValue("@UserID", userID)
                            updateBalanceCommand.Parameters.AddWithValue("@StockPrice", stockprice)

                            updateBalanceCommand.ExecuteNonQuery()

                            Dim insertTransactionQuery As String = "INSERT INTO Transactions (UserID, StockName, Price, QtyBought, Type, TransactionDate, StockID) VALUES (@UserID, @StockName, @Price, @QtyBought, @Type, @TransactionDate, @StockID)"

                            Using insertTransactionCommand As New SqlCommand(insertTransactionQuery, connection)
                                insertTransactionCommand.Parameters.AddWithValue("@UserID", userID)
                                insertTransactionCommand.Parameters.AddWithValue("@StockName", stockName) ' Replace with the actual stock name
                                insertTransactionCommand.Parameters.AddWithValue("@Price", stockprice)
                                insertTransactionCommand.Parameters.AddWithValue("@QtyBought", Quantity)
                                insertTransactionCommand.Parameters.AddWithValue("@Type", "Buy")
                                insertTransactionCommand.Parameters.AddWithValue("@TransactionDate", transactionDate)
                                insertTransactionCommand.Parameters.AddWithValue("@StockID", stockID)

                                insertTransactionCommand.ExecuteNonQuery()

                                MessageBox.Show($"Stocks purchased successfully! Amount deducted: {stockprice}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Using
                        End Using
                    Else
                        MessageBox.Show("Insufficient available balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Price As Decimal

        Try
            If String.IsNullOrEmpty(StockID_txt.Text) Then
                MessageBox.Show("Stock ID is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                Dim selectPriceQuery As String = "SELECT Price FROM Stocks WHERE StockID = @StockID"
                Using selectPriceCommand As New SqlCommand(selectPriceQuery, connection)
                    selectPriceCommand.Parameters.AddWithValue("@StockID", StockID_txt.Text)

                    Dim stockPrice As Decimal = Convert.ToDecimal(selectPriceCommand.ExecuteScalar())

                    Price = stockPrice
                End Using
            End Using
            If Quantity_txt.Text = "" Or "0" Then
                price_label.Text = ""
            Else
                price_label.Text = Price * Quantity_txt.Text
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Quantity_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Quantity_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
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

    Private Function GetStockNameByStockID(connectionString As String, stockID As Integer) As String
        Dim stockName As String = ""

        Try
            Using con As New SqlConnection(connectionString)
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim query As String = "SELECT StockName FROM Stocks WHERE StockID = @StockID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@StockID", stockID)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        stockName = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return stockName
    End Function

    Private Sub buy_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



