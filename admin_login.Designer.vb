<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_login
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
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Login_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Username_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1119, 599)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoRoundedCorners = True
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Guna2Panel1.BorderRadius = 247
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel1.Controls.Add(Me.LinkLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Login_btn)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Password_txt)
        Me.Guna2Panel1.Controls.Add(Me.Username_txt)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(48, 29)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1006, 497)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Login_btn
        '
        Me.Login_btn.BorderRadius = 20
        Me.Login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Login_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Login_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Login_btn.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.Login_btn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_btn.ForeColor = System.Drawing.Color.White
        Me.Login_btn.Location = New System.Drawing.Point(568, 379)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(351, 45)
        Me.Login_btn.TabIndex = 13
        Me.Login_btn.Text = "Log_in"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(567, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(563, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Username"
        '
        'Password_txt
        '
        Me.Password_txt.BorderRadius = 20
        Me.Password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password_txt.DefaultText = ""
        Me.Password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password_txt.FillColor = System.Drawing.Color.Snow
        Me.Password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password_txt.ForeColor = System.Drawing.Color.Black
        Me.Password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password_txt.Location = New System.Drawing.Point(557, 285)
        Me.Password_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password_txt.PlaceholderText = ""
        Me.Password_txt.SelectedText = ""
        Me.Password_txt.Size = New System.Drawing.Size(351, 40)
        Me.Password_txt.TabIndex = 10
        '
        'Username_txt
        '
        Me.Username_txt.BorderRadius = 20
        Me.Username_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username_txt.DefaultText = ""
        Me.Username_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username_txt.FillColor = System.Drawing.Color.Snow
        Me.Username_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Username_txt.ForeColor = System.Drawing.Color.Black
        Me.Username_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username_txt.Location = New System.Drawing.Point(557, 166)
        Me.Username_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Username_txt.Name = "Username_txt"
        Me.Username_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username_txt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.Username_txt.PlaceholderText = ""
        Me.Username_txt.SelectedText = ""
        Me.Username_txt.Size = New System.Drawing.Size(351, 40)
        Me.Username_txt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(632, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ADMIN LOGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(107, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Management System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(53, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 57)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INVESTMENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(186, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 40)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "AND"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(124, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 57)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "STOCKS "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(27, 460)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(103, 18)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "USERS PAGE"
        '
        'admin_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 552)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Name = "admin_login"
        Me.Text = "admin_login"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Login_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Username_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
