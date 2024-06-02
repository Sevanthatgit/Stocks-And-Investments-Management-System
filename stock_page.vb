Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization
Imports System.Drawing.Text

Public Class stock_page
    Dim ConnectionString As String = "Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True"

    Private Sub stock_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_infoDataSet1.Stocks' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'User_infoDataSet1.Stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.User_infoDataSet1.Stocks)

        ' Hide the "Sector" column if it exists
        Dim sectorColumn As DataGridViewColumn = Guna2DataGridView1.Columns.Cast(Of DataGridViewColumn)().FirstOrDefault(Function(col) col.Name = "Sector")

        If sectorColumn IsNot Nothing Then
            sectorColumn.Visible = False
        End If

        Guna2ComboBox1.Items.AddRange({"Manufacturing", "Technology", "Pharmaceuticals/Biotechnology", "Energy"})
    End Sub

    Private Sub Guna2TileButton9_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        portfolio_page.Show()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        home_page.Show()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Guna2DataGridView1.ReadOnly = True
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Dim SelectedOption As String = Guna2ComboBox1.SelectedItem.ToString
        DisplayData(SelectedOption)
    End Sub

    Private Sub DisplayData(SelectedOption As String)
        Dim DataTable As New DataTable()
        Dim ColumnsToSelect As String = ""

        ' Determine the columns to select based on the selected option
        If SelectedOption = "Manufacturing" OrElse
       SelectedOption = "Technology" OrElse
       SelectedOption = "Pharmaceuticals/Biotechnology" OrElse
       SelectedOption = "Energy" Then

            ColumnsToSelect = "StockId,StockName, Quantity, Price, ROI"

            ' Build the SQL query with the selected columns
            Dim Sector As String = $"SELECT {ColumnsToSelect} FROM stocks WHERE Sector = '{SelectedOption}'"

            Using connection As New SqlConnection(ConnectionString)
                Using command As New SqlCommand(Sector, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        DataTable.Load(reader)
                    End Using
                    connection.Close()
                End Using
            End Using

            ' Set the DataSource for the DataGridView
            Guna2DataGridView1.DataSource = DataTable

            ' Set DataGridView properties
            Guna2DataGridView1.ReadOnly = True

            ' Check if the column exists before hiding
            If Guna2DataGridView1.Columns.Contains("Sector") Then
                Guna2DataGridView1.Columns("Sector").Visible = False
            End If
        End If
    End Sub

    Private Sub buybtn_Click(sender As Object, e As EventArgs) Handles buybtn.Click
        buy_stock.ShowDialog()
    End Sub

    Private Sub sellbtn_Click(sender As Object, e As EventArgs) Handles sellbtn.Click
        sell_stock.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        home_page.Show()


    End Sub
End Class
