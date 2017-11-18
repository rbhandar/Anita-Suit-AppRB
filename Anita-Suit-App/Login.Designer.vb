<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.ViewAsGuestButton = New System.Windows.Forms.Button()
        Me.ForgotPasswordLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ForgotIDLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.HelpLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TakeMeToGuestPagePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.TakeMeToGuestPagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Location = New System.Drawing.Point(169, 92)
        Me.UserIDTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(109, 20)
        Me.UserIDTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(169, 140)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(109, 20)
        Me.PasswordTextBox.TabIndex = 1
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Location = New System.Drawing.Point(111, 92)
        Me.UserIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(43, 13)
        Me.UserIDLabel.TabIndex = 2
        Me.UserIDLabel.Text = "User ID"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(111, 140)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password"
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(114, 194)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(57, 20)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'SignUpButton
        '
        Me.SignUpButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.SignUpButton.ForeColor = System.Drawing.Color.White
        Me.SignUpButton.Location = New System.Drawing.Point(114, 257)
        Me.SignUpButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(108, 21)
        Me.SignUpButton.TabIndex = 5
        Me.SignUpButton.Text = "Become a Member"
        Me.SignUpButton.UseVisualStyleBackColor = False
        '
        'ViewAsGuestButton
        '
        Me.ViewAsGuestButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.ViewAsGuestButton.ForeColor = System.Drawing.Color.White
        Me.ViewAsGuestButton.Location = New System.Drawing.Point(264, 257)
        Me.ViewAsGuestButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ViewAsGuestButton.Name = "ViewAsGuestButton"
        Me.ViewAsGuestButton.Size = New System.Drawing.Size(101, 20)
        Me.ViewAsGuestButton.TabIndex = 6
        Me.ViewAsGuestButton.Text = "View as Guest"
        Me.ViewAsGuestButton.UseVisualStyleBackColor = False
        '
        'ForgotPasswordLinkLabel
        '
        Me.ForgotPasswordLinkLabel.AutoSize = True
        Me.ForgotPasswordLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordLinkLabel.Location = New System.Drawing.Point(285, 140)
        Me.ForgotPasswordLinkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel"
        Me.ForgotPasswordLinkLabel.Size = New System.Drawing.Size(76, 9)
        Me.ForgotPasswordLinkLabel.TabIndex = 9
        Me.ForgotPasswordLinkLabel.TabStop = True
        Me.ForgotPasswordLinkLabel.Text = "I forgot my password"
        '
        'ForgotIDLinkLabel
        '
        Me.ForgotIDLinkLabel.AutoSize = True
        Me.ForgotIDLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.ForgotIDLinkLabel.Location = New System.Drawing.Point(288, 92)
        Me.ForgotIDLinkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ForgotIDLinkLabel.Name = "ForgotIDLinkLabel"
        Me.ForgotIDLinkLabel.Size = New System.Drawing.Size(51, 9)
        Me.ForgotIDLinkLabel.TabIndex = 10
        Me.ForgotIDLinkLabel.TabStop = True
        Me.ForgotIDLinkLabel.Text = "I forgot my ID"
        '
        'HelpLinkLabel
        '
        Me.HelpLinkLabel.AutoSize = True
        Me.HelpLinkLabel.Location = New System.Drawing.Point(451, 6)
        Me.HelpLinkLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HelpLinkLabel.Name = "HelpLinkLabel"
        Me.HelpLinkLabel.Size = New System.Drawing.Size(29, 13)
        Me.HelpLinkLabel.TabIndex = 11
        Me.HelpLinkLabel.TabStop = True
        Me.HelpLinkLabel.Text = "Help"
        '
        'TakeMeToGuestPagePictureBox
        '
        Me.TakeMeToGuestPagePictureBox.Image = Global.Anita_Suit_App.My.Resources.Resources.Anita_Suit_Logo_New
        Me.TakeMeToGuestPagePictureBox.Location = New System.Drawing.Point(122, 8)
        Me.TakeMeToGuestPagePictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TakeMeToGuestPagePictureBox.Name = "TakeMeToGuestPagePictureBox"
        Me.TakeMeToGuestPagePictureBox.Size = New System.Drawing.Size(218, 53)
        Me.TakeMeToGuestPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TakeMeToGuestPagePictureBox.TabIndex = 7
        Me.TakeMeToGuestPagePictureBox.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(502, 376)
        Me.Controls.Add(Me.HelpLinkLabel)
        Me.Controls.Add(Me.ForgotIDLinkLabel)
        Me.Controls.Add(Me.ForgotPasswordLinkLabel)
        Me.Controls.Add(Me.TakeMeToGuestPagePictureBox)
        Me.Controls.Add(Me.ViewAsGuestButton)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserIDLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        CType(Me.TakeMeToGuestPagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserIDLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents SignUpButton As Button
    Friend WithEvents ViewAsGuestButton As Button
    Friend WithEvents TakeMeToGuestPagePictureBox As PictureBox
    Friend WithEvents ForgotPasswordLinkLabel As LinkLabel
    Friend WithEvents ForgotIDLinkLabel As LinkLabel
    Friend WithEvents HelpLinkLabel As LinkLabel
End Class
