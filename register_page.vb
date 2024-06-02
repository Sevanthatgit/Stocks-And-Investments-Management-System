Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization
Public Class register_page
    Public con As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
    Private Sub register_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username_reg_txt.TextChanged

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        PerformRegistration()
    End Sub
    Private Sub PerformRegistration()
        Try
            ' Validate input: Check if both username and password are provided
            If String.IsNullOrWhiteSpace(username_reg_txt.Text) OrElse String.IsNullOrWhiteSpace(Password_reg_txt.Text) OrElse String.IsNullOrWhiteSpace(Email_reg_txt.Text) OrElse String.IsNullOrWhiteSpace(Phoneno_reg_txt.Text) OrElse String.IsNullOrWhiteSpace(Bankname_reg_txt.Text) OrElse String.IsNullOrWhiteSpace(cardnumber_reg_txt.Text) OrElse String.IsNullOrWhiteSpace(availabelbalance_reg_txt.Text) Then
                MessageBox.Show("Please enter all the credentials.")
                Return ' Exit the method without proceeding to database operations
            End If
            ' Open the database connection
            con.Open()

            ' Execute SQL command to insert new user registration
            Dim sql As String = "INSERT INTO Users (Username, Password, Email, Phoneno, Bank_name, Card_number, Available_balance) VALUES (@Username, @Password, @Email, @Phoneno, @Bank_name, @Card_number, @Available_balance)"
            Using cmd As New SqlCommand(sql, con)
                ' Replace these parameters with actual values or retrieve them from controls
                cmd.Parameters.AddWithValue("@Username", username_reg_txt.Text)
                cmd.Parameters.AddWithValue("@Password", Password_reg_txt.Text)
                cmd.Parameters.AddWithValue("@Email", Email_reg_txt.Text)
                cmd.Parameters.AddWithValue("@Phoneno", Phoneno_reg_txt.Text)
                cmd.Parameters.AddWithValue("@Bank_name", Bankname_reg_txt.Text)
                cmd.Parameters.AddWithValue("@Card_number", cardnumber_reg_txt.Text)
                cmd.Parameters.AddWithValue("@Available_balance", availabelbalance_reg_txt.Text)

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Display registration success message
                MessageBox.Show("Registration successful")
                Me.Hide()
                login_page.Show()

            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection in the finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs)
        Me.Close()
        login_page.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Username.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton1_Click_2(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        login_page.Show()

    End Sub
End Class