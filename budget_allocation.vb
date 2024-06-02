Public Class budget_allocation
    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        home_page.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            ' Get user input values
            Dim income As Decimal = Decimal.Parse(Guna2TextBox1.Text)
            Dim expense As Decimal = Decimal.Parse(Guna2TextBox3.Text)
            Dim investment As Decimal = Decimal.Parse(Guna2TextBox4.Text)

            ' Calculate percentages
            Dim total As Decimal = income
            Dim expensePercentage As Decimal = (expense / total) * 100
            Dim investmentPercentage As Decimal = (investment / total) * 100
            Dim savingPercentage As Decimal = 100 - (expensePercentage + investmentPercentage)

            ' Calculate amounts allocated
            Dim expenseAmount As Decimal = expense
            Dim investmentAmount As Decimal = investment
            Dim savingAmount As Decimal = total - (expenseAmount + investmentAmount)

            ' Display data in pie chart (Chart1)
            Chart1.Series.Clear()
            Chart1.Series.Add("Budget")
            Chart1.Series("Budget").ChartType = DataVisualization.Charting.SeriesChartType.Pie
            Chart1.Series("Budget").Points.AddXY("Expense", expensePercentage)
            Chart1.Series("Budget").Points.AddXY("Investment", investmentPercentage)
            Chart1.Series("Budget").Points.AddXY("Saving", savingPercentage)

            ' Display data in bar chart (Chart2)
            Chart2.Series.Clear()
            Chart2.Series.Add("Amount")
            Chart2.Series("Amount").Points.AddXY("Expense", expenseAmount)
            Chart2.Series("Amount").Points.AddXY("Investment", investmentAmount)
            Chart2.Series("Amount").Points.AddXY("Saving", savingAmount)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class