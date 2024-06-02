Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class add_stock
    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox5.TextChanged

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub
    Private Sub addstockbtn_Click(sender As Object, e As EventArgs) Handles addstockbtn.Click
        Try
            ' Retrieve input values from textboxes
            Dim stockName As String = Guna2TextBox1.Text.Trim()
            Dim quantity As Integer = Convert.ToInt32(Guna2TextBox2.Text.Trim())
            Dim price As Decimal = Convert.ToDecimal(Guna2TextBox3.Text.Trim())
            Dim sector As String = Guna2TextBox4.Text.Trim()
            Dim roi As Decimal = Convert.ToDecimal(Guna2TextBox5.Text.Trim())

            ' Insert the new stock into the database
            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
                connection.Open()
                Dim insertQuery As String = "INSERT INTO Stocks (StockName, Quantity, Price, Sector, ROI) VALUES (@StockName, @Quantity, @Price, @Sector, @ROI); SELECT SCOPE_IDENTITY();"
                Using command As New SqlCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@StockName", stockName)
                    command.Parameters.AddWithValue("@Quantity", quantity)
                    command.Parameters.AddWithValue("@Price", price)
                    command.Parameters.AddWithValue("@Sector", sector)
                    command.Parameters.AddWithValue("@ROI", roi)

                    ' Execute the insert query and get the newly generated StockID
                    Dim newStockID As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Notify the user about the successful addition
                    MessageBox.Show("Stock added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Close the form after adding the stock
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class