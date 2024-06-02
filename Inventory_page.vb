Imports System.Data.SqlClient

Public Class Inventory_page

    Private Sub LoadStocks()
        Try

            Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
                connection.Open()
                Dim adapter As New SqlDataAdapter("SELECT * FROM Stocks", connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                Guna2DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Inventory_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StocksTableAdapter.Fill(Me.User_infoDataSet3.Stocks)

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        add_stock.Show()

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        LoadStocks()
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim stockID As String = InputBox("Enter the stock ID you want to delete:", "Delete Stock")

        If Not String.IsNullOrEmpty(stockID) Then
            Try
                Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
                    connection.Open()

                    Dim deleteCommand As New SqlCommand("DELETE FROM Stocks WHERE StockID = @StockID", connection)
                    deleteCommand.Parameters.AddWithValue("@StockID", stockID)

                    Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"Stock with ID {stockID} has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        LoadStocks()
                    Else
                        MessageBox.Show($"No stock found with ID {stockID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim stockID As String = InputBox("Enter the stock ID you want to update:", "Update Stock")

        If Not String.IsNullOrEmpty(stockID) Then
            Dim newStockName As String = InputBox("Enter the new Stock Name:", "Update Stock")
            Dim newQuantity As String = InputBox("Enter the new Quantity:", "Update Stock")
            Dim newPrice As String = InputBox("Enter the new Price:", "Update Stock")
            Dim newSector As String = InputBox("Enter the new Sector:", "Update Stock")
            Dim newROI As String = InputBox("Enter the new ROI:", "Update Stock")

            Try
                Using connection As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
                    connection.Open()

                    Dim updateCommand As New SqlCommand("UPDATE Stocks SET StockName = @StockName, Quantity = @Quantity, Price = @Price, Sector = @Sector, ROI = @ROI WHERE StockID = @StockID", connection)
                    updateCommand.Parameters.AddWithValue("@StockID", stockID)
                    updateCommand.Parameters.AddWithValue("@StockName", newStockName)
                    updateCommand.Parameters.AddWithValue("@Quantity", newQuantity)
                    updateCommand.Parameters.AddWithValue("@Price", newPrice)
                    updateCommand.Parameters.AddWithValue("@Sector", newSector)
                    updateCommand.Parameters.AddWithValue("@ROI", newROI)

                    Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"Stock with ID {stockID} has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        LoadStocks()
                    Else
                        MessageBox.Show($"No stock found with ID {stockID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        admin_login.Show()
        Me.Close()

    End Sub
End Class