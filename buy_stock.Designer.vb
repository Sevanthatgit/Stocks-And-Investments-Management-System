<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buy_stock
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
        Me.StockID_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Quantity_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.buystockbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.price_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.StockID_txt.Location = New System.Drawing.Point(251, 60)
        Me.StockID_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockID_txt.Name = "StockID_txt"
        Me.StockID_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StockID_txt.PlaceholderText = ""
        Me.StockID_txt.SelectedText = ""
        Me.StockID_txt.Size = New System.Drawing.Size(163, 30)
        Me.StockID_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(82, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Stock ID"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(82, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(82, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price"
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
        Me.Quantity_txt.Location = New System.Drawing.Point(251, 115)
        Me.Quantity_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Quantity_txt.Name = "Quantity_txt"
        Me.Quantity_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Quantity_txt.PlaceholderText = ""
        Me.Quantity_txt.SelectedText = ""
        Me.Quantity_txt.Size = New System.Drawing.Size(163, 30)
        Me.Quantity_txt.TabIndex = 5
        '
        'buystockbtn
        '
        Me.buystockbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buystockbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buystockbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buystockbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buystockbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buystockbtn.ForeColor = System.Drawing.Color.White
        Me.buystockbtn.Location = New System.Drawing.Point(159, 239)
        Me.buystockbtn.Name = "buystockbtn"
        Me.buystockbtn.Size = New System.Drawing.Size(180, 45)
        Me.buystockbtn.TabIndex = 8
        Me.buystockbtn.Text = "BUY"
        '
        'price_label
        '
        Me.price_label.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_label.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.price_label.Location = New System.Drawing.Point(245, 168)
        Me.price_label.Name = "price_label"
        Me.price_label.Size = New System.Drawing.Size(169, 32)
        Me.price_label.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stocks___Investments_Management_System.My.Resources.Resources.reload__1_
        Me.PictureBox1.Location = New System.Drawing.Point(427, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'buy_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(529, 364)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.price_label)
        Me.Controls.Add(Me.buystockbtn)
        Me.Controls.Add(Me.Quantity_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StockID_txt)
        Me.Name = "buy_stock"
        Me.Text = "buy_stock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StockID_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Quantity_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents buystockbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents price_label As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
