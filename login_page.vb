Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization



Public Class login_page
    Public con As New SqlConnection("Data Source=LAPTOP-N6QJ5U6O\SQLEXPRESS01;Initial Catalog=user_info;Integrated Security=True;Encrypt = False")
    Private Sub login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        register_page.Show()

    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        PerformLogin()
    End Sub
    Private Sub PerformLogin()

        Try



            If String.IsNullOrWhiteSpace(Username_txt.Text) OrElse String.IsNullOrWhiteSpace(Password_txt.Text) Then
                MessageBox.Show("Please enter username and password.")
                Return
            End If

            con.Open()

            Dim sql As String = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Username", Username_txt.Text)
                cmd.Parameters.AddWithValue("@Password", Password_txt.Text)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    ' User is authenticated
                    MessageBox.Show("Login successful")

                    Me.Hide()
                    home_page.Show()

                    home_page.usrnme_label.Text = Username_txt.Text
                    stock_page.usrnme2_label.Text = Username_txt.Text
                    portfolio_page.usrnme_label.Text = Username_txt.Text


                    Username_txt.Text = ""
                    Password_txt.Text = ""
                Else
                    MessageBox.Show("Invalid username or password")
                End If

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Password_txt.PasswordChar = ControlChars.NullChar
        Else
            Password_txt.PasswordChar = "*"
        End If
    End Sub

    Private Sub Password_txt_TextChanged(sender As Object, e As EventArgs) Handles Password_txt.TextChanged
        Password_txt.PasswordChar = "*"
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        admin_login.Show()
        Me.Hide()

    End Sub
End Class
