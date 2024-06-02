Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices


Public Class sell_stock



    Dim ConnectionString As String = "Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True"
    Dim transactionDate As Date = Date.Today
    Dim stockID As Integer
        Dim stockprice As Decimal
        Dim Quantity As Integer
        Dim username As String
        Dim stockName As String
        Dim userID As Integer




    Private Sub sellstockbtn_Click(sender As Object, e As EventArgs) Handles sellstockbtn.Click
        Dim transactionDate As Date = Date.Today
        Dim stockID As Integer = Convert.ToInt32(StockID_txt.Text)
        Dim stockprice As Decimal = Convert.ToDecimal(price_label.Text)
        Dim quantity As Integer = If(Integer.TryParse(Quantity_txt.Text, quantity), quantity, 0)
        Dim username As String = home_page.usrnme_label.Text
        Dim stockName As String = GetStockNameByStockID(ConnectionString, stockID)
        Dim userID As Integer = GetUserIDByUsername(ConnectionString, username)

        Try
            If stockprice <= 0 OrElse quantity <= 0 Then
                MessageBox.Show("Invalid Stock Price or Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Dim selectStockQuery As String = "SELECT SUM(QtyBought) FROM Transactions WHERE UserID = @UserID AND StockID = @StockID AND Type = 'Buy'"
                Using selectStockCommand As New SqlCommand(selectStockQuery, connection)
                    selectStockCommand.Parameters.AddWithValue("@UserID", userID)
                    selectStockCommand.Parameters.AddWithValue("@StockID", stockID)
                    Dim boughtQuantity As Integer = Convert.ToInt32(selectStockCommand.ExecuteScalar())

                    If boughtQuantity < quantity Then
                        MessageBox.Show("You don't have enough stocks to sell.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                Dim selectBalanceQuery As String = "SELECT Available_balance FROM Users WHERE UserID = @UserID"
                Using selectBalanceCommand As New SqlCommand(selectBalanceQuery, connection)
                    selectBalanceCommand.Parameters.AddWithValue("@UserID", userID)

                    Dim availableBalance As Decimal = Convert.ToDecimal(selectBalanceCommand.ExecuteScalar())

                    If availableBalance >= stockprice Then
                        Dim totalAmount = Label5.Text
                        Dim updateBalanceQuery As String = "UPDATE Users SET Available_balance = Available_balance + @StockPrice WHERE UserID = @UserID"

                        Using updateBalanceCommand As New SqlCommand(updateBalanceQuery, connection)
                            updateBalanceCommand.Parameters.AddWithValue("@UserID", userID)
                            updateBalanceCommand.Parameters.AddWithValue("@StockPrice", totalAmount)
                            updateBalanceCommand.ExecuteNonQuery()

                            Dim insertTransactionQuery As String = "INSERT INTO Transactions (UserID, StockName, Price, QtyBought, Type, TransactionDate, StockID) VALUES (@UserID, @StockName, @Price, @QtyBought, @Type, @TransactionDate, @StockID)"

                            Using insertTransactionCommand As New SqlCommand(insertTransactionQuery, connection)
                                insertTransactionCommand.Parameters.AddWithValue("@UserID", userID)
                                insertTransactionCommand.Parameters.AddWithValue("@StockName", stockName)
                                insertTransactionCommand.Parameters.AddWithValue("@Price", totalAmount)
                                insertTransactionCommand.Parameters.AddWithValue("@QtyBought", quantity)
                                insertTransactionCommand.Parameters.AddWithValue("@Type", "Sell")
                                insertTransactionCommand.Parameters.AddWithValue("@TransactionDate", transactionDate)
                                insertTransactionCommand.Parameters.AddWithValue("@StockID", stockID)

                                insertTransactionCommand.ExecuteNonQuery()

                                MessageBox.Show($"Stocks Sold successfully! Amount: {totalAmount}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()

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
        Try
            Dim stockID As Integer = Convert.ToInt32(StockID_txt.Text)

            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Dim selectPriceAndROIQuery As String = "SELECT Price, ROI FROM Stocks WHERE StockID = @StockID"
                Using selectPriceAndROICommand As New SqlCommand(selectPriceAndROIQuery, connection)
                    selectPriceAndROICommand.Parameters.AddWithValue("@StockID", stockID)

                    ' Execute the query and retrieve stock price and ROI
                    Using reader As SqlDataReader = selectPriceAndROICommand.ExecuteReader()
                        If reader.Read() Then
                            ' Display stock price in the price_label
                            Dim stockPrice As Decimal = Convert.ToDecimal(reader("Price"))
                            price_label.Text = stockPrice.ToString()

                            ' Calculate total amount and display it in Label5
                            Dim quantity As Integer = If(Integer.TryParse(Quantity_txt.Text, quantity), quantity, 0)
                            Dim totalAmount As Decimal = stockPrice * quantity * (1 + (Convert.ToDecimal(reader("ROI")) / 100))
                            Label5.Text = totalAmount.ToString()

                            ' Calculate the price increase and display it in Label8
                            Dim priceIncrease As Decimal = totalAmount - (stockPrice * quantity)
                            Label8.Text = priceIncrease.ToString()
                        Else
                            MessageBox.Show("Stock ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function getroi() As Decimal
        Dim roi As Decimal = 0

        Try
            ' Connect to the database
            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True")
                connection.Open()

                ' Retrieve ROI from Stocks table based on StockID
                Dim selectROIQuery As String = "SELECT ROI FROM Stocks WHERE StockID = @StockID"
                Using selectROICommand As New SqlCommand(selectROIQuery, connection)
                    selectROICommand.Parameters.AddWithValue("@StockID", StockID_txt.Text)

                    ' Execute the query and retrieve the ROI
                    Dim roiObject As Object = selectROICommand.ExecuteScalar()

                    If roiObject IsNot Nothing AndAlso Not DBNull.Value.Equals(roiObject) Then
                        roi = Convert.ToDecimal(roiObject)
                    Else
                        MessageBox.Show("ROI not found for the given StockID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while fetching ROI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return roi
    End Function


    Private Sub Quantity_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Quantity_txt.KeyPress
            ' Allowing only numbers and control characters (such as backspace)
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                ' If the entered character is not a digit and not a control character, ignore it
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




        ' Your other form code...
    End Class
