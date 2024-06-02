<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sell_stock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.price_label = New System.Windows.Forms.Label()
        Me.sellstockbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Quantity_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StockID_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'price_label
        '
        Me.price_label.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_label.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.price_label.Location = New System.Drawing.Point(224, 130)
        Me.price_label.Name = "price_label"
        Me.price_label.Size = New System.Drawing.Size(227, 32)
        Me.price_label.TabIndex = 17
        '
        'sellstockbtn
        '
        Me.sellstockbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.sellstockbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.sellstockbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.sellstockbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.sellstockbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sellstockbtn.ForeColor = System.Drawing.Color.White
        Me.sellstockbtn.Location = New System.Drawing.Point(145, 344)
        Me.sellstockbtn.Name = "sellstockbtn"
        Me.sellstockbtn.Size = New System.Drawing.Size(180, 45)
        Me.sellstockbtn.TabIndex = 16
        Me.sellstockbtn.Text = "SELL"
        '
        'Quantity_txt
        '
        Me.Quantity_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Quantity_txt.DefaultText = ""
        Me.Quantity_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Quantity_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Quantity_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Quantity_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Quantity_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Quantity_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Quantity_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Quantity_txt.Location = New System.Drawing.Point(230, 77)
        Me.Quantity_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Quantity_txt.Name = "Quantity_txt"
        Me.Quantity_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Quantity_txt.PlaceholderText = ""
        Me.Quantity_txt.SelectedText = ""
        Me.Quantity_txt.Size = New System.Drawing.Size(163, 30)
        Me.Quantity_txt.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(37, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(37, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Stock ID"
        '
        'StockID_txt
        '
        Me.StockID_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StockID_txt.DefaultText = ""
        Me.StockID_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StockID_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StockID_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StockID_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StockID_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockID_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StockID_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockID_txt.Location = New System.Drawing.Point(230, 22)
        Me.StockID_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockID_txt.Name = "StockID_txt"
        Me.StockID_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StockID_txt.PlaceholderText = ""
        Me.StockID_txt.SelectedText = ""
        Me.StockID_txt.Size = New System.Drawing.Size(163, 30)
        Me.StockID_txt.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stocks___Investments_Management_System.My.Resources.Resources.reload__1_
        Me.PictureBox1.Location = New System.Drawing.Point(470, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(37, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 32)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total Amount"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(224, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 32)
        Me.Label5.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(37, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 32)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "ROI"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(224, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 32)
        Me.Label8.TabIndex = 24
        '
        'sell_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(529, 430)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.price_label)
        Me.Controls.Add(Me.sellstockbtn)
        Me.Controls.Add(Me.Quantity_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StockID_txt)
        Me.Name = "sell_stock"
        Me.Text = "sell_stock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents price_label As Label
    Friend WithEvents sellstockbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Quantity_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StockID_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
