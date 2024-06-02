Imports System.Windows.Forms.DataVisualization.Charting

Public Class home_page
    Private Sub Random_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'User_infoDataSet1.Stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.User_infoDataSet1.Stocks)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        stock_page.Show()

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        stock_page.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub usrnme_label_Click(sender As Object, e As EventArgs) Handles usrnme_label.Click

    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        stock_page.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        portfolio_page.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Expense_tracker.Show()


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Blogs_page.Show()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        budget_allocation.Show()

    End Sub
End Class