<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register_page))
        Me.username_reg_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Email_reg_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Phoneno_reg_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Password_reg_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.emailLB = New System.Windows.Forms.Label()
        Me.PhonenoLB = New System.Windows.Forms.Label()
        Me.EnterpassLB = New System.Windows.Forms.Label()
        Me.Register_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bankname_reg_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cardnumber_reg_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.availabelbalance_reg_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'username_reg_txt
        '
        Me.username_reg_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username_reg_txt.BorderRadius = 20
        Me.username_reg_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_reg_txt.DefaultText = ""
        Me.username_reg_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username_reg_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username_reg_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_reg_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_reg_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_reg_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.username_reg_txt.ForeColor = System.Drawing.Color.Black
        Me.username_reg_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_reg_txt.Location = New System.Drawing.Point(3, 29)
        Me.username_reg_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.username_reg_txt.Name = "username_reg_txt"
        Me.username_reg_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_reg_txt.PlaceholderText = ""
        Me.username_reg_txt.SelectedText = ""
        Me.username_reg_txt.Size = New System.Drawing.Size(351, 40)
        Me.username_reg_txt.TabIndex = 8
        '
        'Email_reg_txt
        '
        Me.Email_reg_txt.BorderRadius = 20
        Me.Email_reg_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Email_reg_txt.DefaultText = ""
        Me.Email_reg_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Email_reg_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Email_reg_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Email_reg_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Email_reg_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Email_reg_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Email_reg_txt.ForeColor = System.Drawing.Color.Black
        Me.Email_reg_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Email_reg_txt.Location = New System.Drawing.Point(3, 114)
        Me.Email_reg_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Email_reg_txt.Name = "Email_reg_txt"
        Me.Email_reg_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email_reg_txt.PlaceholderText = ""
        Me.Email_reg_txt.SelectedText = ""
        Me.Email_reg_txt.Size = New System.Drawing.Size(351, 40)
        Me.Email_reg_txt.TabIndex = 9
        '
        'Phoneno_reg_txt
        '
        Me.Phoneno_reg_txt.BorderRadius = 20
        Me.Phoneno_reg_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Phoneno_reg_txt.DefaultText = ""
        Me.Phoneno_reg_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Phoneno_reg_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Phoneno_reg_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Phoneno_reg_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Phoneno_reg_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Phoneno_reg_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Phoneno_reg_txt.ForeColor = System.Drawing.Color.Black
        Me.Phoneno_reg_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Phoneno_reg_txt.Location = New System.Drawing.Point(3, 199)
        Me.Phoneno_reg_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Phoneno_reg_txt.Name = "Phoneno_reg_txt"
        Me.Phoneno_reg_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Phoneno_reg_txt.PlaceholderText = ""
        Me.Phoneno_reg_txt.SelectedText = ""
        Me.Phoneno_reg_txt.Size = New System.Drawing.Size(351, 40)
        Me.Phoneno_reg_txt.TabIndex = 10
        '
        'Password_reg_txt
        '
        Me.Password_reg_txt.BorderRadius = 20
        Me.Password_reg_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password_reg_txt.DefaultText = ""
        Me.Password_reg_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password_reg_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password_reg_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password_reg_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password_reg_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password_reg_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password_reg_txt.ForeColor = System.Drawing.Color.Black
        Me.Password_reg_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password_reg_txt.Location = New System.Drawing.Point(3, 284)
        Me.Password_reg_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Password_reg_txt.Name = "Password_reg_txt"
        Me.Password_reg_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password_reg_txt.PlaceholderText = ""
        Me.Password_reg_txt.SelectedText = ""
        Me.Password_reg_txt.Size = New System.Drawing.Size(351, 40)
        Me.Password_reg_txt.TabIndex = 11
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(3, 0)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(102, 25)
        Me.Username.TabIndex = 12
        Me.Username.Text = "Username"
        '
        'emailLB
        '
        Me.emailLB.AutoSize = True
        Me.emailLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLB.ForeColor = System.Drawing.Color.White
        Me.emailLB.Location = New System.Drawing.Point(3, 73)
        Me.emailLB.Name = "emailLB"
        Me.emailLB.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.emailLB.Size = New System.Drawing.Size(67, 37)
        Me.emailLB.TabIndex = 13
        Me.emailLB.Text = "E-mail"
        '
        'PhonenoLB
        '
        Me.PhonenoLB.AutoSize = True
        Me.PhonenoLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhonenoLB.ForeColor = System.Drawing.Color.White
        Me.PhonenoLB.Location = New System.Drawing.Point(3, 158)
        Me.PhonenoLB.Name = "PhonenoLB"
        Me.PhonenoLB.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.PhonenoLB.Size = New System.Drawing.Size(98, 37)
        Me.PhonenoLB.TabIndex = 14
        Me.PhonenoLB.Text = "Phone-no"
        '
        'EnterpassLB
        '
        Me.EnterpassLB.AutoSize = True
        Me.EnterpassLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterpassLB.ForeColor = System.Drawing.Color.White
        Me.EnterpassLB.Location = New System.Drawing.Point(3, 243)
        Me.EnterpassLB.Name = "EnterpassLB"
        Me.EnterpassLB.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.EnterpassLB.Size = New System.Drawing.Size(193, 37)
        Me.EnterpassLB.TabIndex = 15
        Me.EnterpassLB.Text = "Enter New Password"
        '
        'Register_btn
        '
        Me.Register_btn.BorderRadius = 20
        Me.Register_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Register_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Register_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Register_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Register_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Register_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Register_btn.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.Register_btn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Register_btn.ForeColor = System.Drawing.Color.White
        Me.Register_btn.Location = New System.Drawing.Point(591, 472)
        Me.Register_btn.Name = "Register_btn"
        Me.Register_btn.Size = New System.Drawing.Size(351, 49)
        Me.Register_btn.TabIndex = 16
        Me.Register_btn.Text = "Register"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(93, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Management System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 57)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "INVESTMENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(166, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 40)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "AND"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(102, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 57)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "STOCKS "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(762, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Username)
        Me.FlowLayoutPanel1.Controls.Add(Me.username_reg_txt)
        Me.FlowLayoutPanel1.Controls.Add(Me.emailLB)
        Me.FlowLayoutPanel1.Controls.Add(Me.Email_reg_txt)
        Me.FlowLayoutPanel1.Controls.Add(Me.PhonenoLB)
        Me.FlowLayoutPanel1.Controls.Add(Me.Phoneno_reg_txt)
        Me.FlowLayoutPanel1.Controls.Add(Me.EnterpassLB)
        Me.FlowLayoutPanel1.Controls.Add(Me.Password_reg_txt)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Bankname_reg_txt)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.cardnumber_reg_txt)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.availabelbalance_reg_txt)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(591, 76)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(402, 368)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(114, 37)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Bank Name"
        '
        'Bankname_reg_txt
        '
        Me.Bankname_reg_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bankname_reg_txt.BorderRadius = 20
        Me.Bankname_reg_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Bankname_reg_txt.DefaultText = ""
        Me.Bankname_reg_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Bankname_reg_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Bankname_reg_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Bankname_reg_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Bankname_reg_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bankname_reg_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bankname_reg_txt.ForeColor = System.Drawing.Color.Black
        Me.Bankname_reg_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bankname_reg_txt.Location = New System.Drawing.Point(3, 369)
        Me.Bankname_reg_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bankname_reg_txt.Name = "Bankname_reg_txt"
        Me.Bankname_reg_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Bankname_reg_txt.PlaceholderText = ""
        Me.Bankname_reg_txt.SelectedText = ""
        Me.Bankname_reg_txt.Size = New System.Drawing.Size(351, 40)
        Me.Bankname_reg_txt.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(129, 37)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Card Number"
        '
        'cardnumber_reg_txt
        '
        Me.cardnumber_reg_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cardnumber_reg_txt.BorderRadius = 20
        Me.cardnumber_reg_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cardnumber_reg_txt.DefaultText = ""
        Me.cardnumber_reg_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cardnumber_reg_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cardnumber_reg_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cardnumber_reg_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cardnumber_reg_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cardnumber_reg_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cardnumber_reg_txt.ForeColor = System.Drawing.Color.Black
        Me.cardnumber_reg_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cardnumber_reg_txt.Location = New System.Drawing.Point(3, 454)
        Me.cardnumber_reg_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cardnumber_reg_txt.Name = "cardnumber_reg_txt"
        Me.cardnumber_reg_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cardnumber_reg_txt.PlaceholderText = ""
        Me.cardnumber_reg_txt.SelectedText = ""
        Me.cardnumber_reg_txt.Size = New System.Drawing.Size(351, 40)
        Me.cardnumber_reg_txt.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 498)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(168, 37)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Availabel Balance"
        '
        'availabelbalance_reg_txt
        '
        Me.availabelbalance_reg_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.availabelbalance_reg_txt.BorderRadius = 20
        Me.availabelbalance_reg_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.availabelbalance_reg_txt.DefaultText = ""
        Me.availabelbalance_reg_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.availabelbalance_reg_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.availabelbalance_reg_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.availabelbalance_reg_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.availabelbalance_reg_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.availabelbalance_reg_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.availabelbalance_reg_txt.ForeColor = System.Drawing.Color.Black
        Me.availabelbalance_reg_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.availabelbalance_reg_txt.Location = New System.Drawing.Point(3, 539)
        Me.availabelbalance_reg_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.availabelbalance_reg_txt.Name = "availabelbalance_reg_txt"
        Me.availabelbalance_reg_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.availabelbalance_reg_txt.PlaceholderText = ""
        Me.availabelbalance_reg_txt.SelectedText = ""
        Me.availabelbalance_reg_txt.Size = New System.Drawing.Size(351, 40)
        Me.availabelbalance_reg_txt.TabIndex = 29
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BorderRadius = 20
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(56, 472)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(351, 49)
        Me.Guna2GradientButton1.TabIndex = 23
        Me.Guna2GradientButton1.Text = "Back"
        '
        'register_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 552)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Register_btn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "register_page"
        Me.Text = "register_page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username_reg_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Email_reg_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Phoneno_reg_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password_reg_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Username As Label
    Friend WithEvents emailLB As Label
    Friend WithEvents PhonenoLB As Label
    Friend WithEvents EnterpassLB As Label
    Friend WithEvents Register_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Bankname_reg_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cardnumber_reg_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents availabelbalance_reg_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
End Class
