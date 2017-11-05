<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.SignUpGroupBox = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RetypePasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SignUpContinueButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SignUpGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SignUpGroupBox
        '
        Me.SignUpGroupBox.Controls.Add(Me.LinkLabel1)
        Me.SignUpGroupBox.Controls.Add(Me.SignUpContinueButton)
        Me.SignUpGroupBox.Controls.Add(Me.Label5)
        Me.SignUpGroupBox.Controls.Add(Me.RetypePasswordTextBox)
        Me.SignUpGroupBox.Controls.Add(Me.Label4)
        Me.SignUpGroupBox.Controls.Add(Me.Label3)
        Me.SignUpGroupBox.Controls.Add(Me.Label2)
        Me.SignUpGroupBox.Controls.Add(Me.Label1)
        Me.SignUpGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.SignUpGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.SignUpGroupBox.Controls.Add(Me.EmailTextBox)
        Me.SignUpGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.SignUpGroupBox.ForeColor = System.Drawing.Color.Chocolate
        Me.SignUpGroupBox.Location = New System.Drawing.Point(178, 73)
        Me.SignUpGroupBox.Name = "SignUpGroupBox"
        Me.SignUpGroupBox.Size = New System.Drawing.Size(421, 505)
        Me.SignUpGroupBox.TabIndex = 0
        Me.SignUpGroupBox.TabStop = False
        Me.SignUpGroupBox.Text = "Become a Member"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(99, 62)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(233, 26)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(99, 137)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(233, 26)
        Me.LastNameTextBox.TabIndex = 2
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(99, 212)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(233, 26)
        Me.EmailTextBox.TabIndex = 3
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Silver
        Me.PasswordTextBox.Location = New System.Drawing.Point(99, 280)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(233, 26)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.Text = "6 characters minimum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Re-type password:"
        '
        'RetypePasswordTextBox
        '
        Me.RetypePasswordTextBox.Location = New System.Drawing.Point(99, 359)
        Me.RetypePasswordTextBox.Name = "RetypePasswordTextBox"
        Me.RetypePasswordTextBox.Size = New System.Drawing.Size(233, 26)
        Me.RetypePasswordTextBox.TabIndex = 9
        '
        'SignUpContinueButton
        '
        Me.SignUpContinueButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.SignUpContinueButton.ForeColor = System.Drawing.Color.White
        Me.SignUpContinueButton.Location = New System.Drawing.Point(154, 420)
        Me.SignUpContinueButton.Name = "SignUpContinueButton"
        Me.SignUpContinueButton.Size = New System.Drawing.Size(124, 32)
        Me.SignUpContinueButton.TabIndex = 11
        Me.SignUpContinueButton.Text = "Contiue"
        Me.SignUpContinueButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anita_Suit_App.My.Resources.Resources.Anita_Suit_Logo_New
        Me.PictureBox1.Location = New System.Drawing.Point(300, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 470)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 20)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cancel"
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 607)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SignUpGroupBox)
        Me.Name = "SignUpForm"
        Me.Text = "Sign Up"
        Me.SignUpGroupBox.ResumeLayout(False)
        Me.SignUpGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SignUpGroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RetypePasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SignUpContinueButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
