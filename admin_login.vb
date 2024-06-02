Public Class admin_login
    Private Sub admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        ' Check if the entered username and password match the admin credentials
        If Username_txt.Text.Trim().ToLower() = "admin" AndAlso Password_txt.Text.Trim() = "admin" Then
            MessageBox.Show("Logged in successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Redirect to the inventory page form (assuming InventoryPageForm is the name of your form)
            Inventory_page.Show()
            Me.Hide() ' Hide the current login form
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        login_page.Show()

    End Sub
End Class