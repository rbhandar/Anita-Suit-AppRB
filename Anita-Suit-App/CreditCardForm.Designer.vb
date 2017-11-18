<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditCardForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PayPerUseRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.StandardRadioButton = New System.Windows.Forms.RadioButton()
        Me.PremiumRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddCardButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.NameOnCardTextBox = New System.Windows.Forms.TextBox()
        Me.CardNumTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PayPerUseRadioButton3)
        Me.GroupBox1.Controls.Add(Me.StandardRadioButton)
        Me.GroupBox1.Controls.Add(Me.PremiumRadioButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.AddCardButton)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.NameOnCardTextBox)
        Me.GroupBox1.Controls.Add(Me.CardNumTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.GroupBox1.Location = New System.Drawing.Point(106, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 498)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credit or Debit Card Information"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(47, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PayPerUseRadioButton3
        '
        Me.PayPerUseRadioButton3.AutoSize = True
        Me.PayPerUseRadioButton3.Location = New System.Drawing.Point(47, 323)
        Me.PayPerUseRadioButton3.Name = "PayPerUseRadioButton3"
        Me.PayPerUseRadioButton3.Size = New System.Drawing.Size(215, 24)
        Me.PayPerUseRadioButton3.TabIndex = 17
        Me.PayPerUseRadioButton3.TabStop = True
        Me.PayPerUseRadioButton3.Text = "Pay per use $0 per month"
        Me.PayPerUseRadioButton3.UseVisualStyleBackColor = True
        '
        'StandardRadioButton
        '
        Me.StandardRadioButton.AutoSize = True
        Me.StandardRadioButton.Location = New System.Drawing.Point(47, 292)
        Me.StandardRadioButton.Name = "StandardRadioButton"
        Me.StandardRadioButton.Size = New System.Drawing.Size(229, 24)
        Me.StandardRadioButton.TabIndex = 16
        Me.StandardRadioButton.TabStop = True
        Me.StandardRadioButton.Text = "Standard $19.99 per month"
        Me.StandardRadioButton.UseVisualStyleBackColor = True
        '
        'PremiumRadioButton
        '
        Me.PremiumRadioButton.AutoSize = True
        Me.PremiumRadioButton.Location = New System.Drawing.Point(47, 261)
        Me.PremiumRadioButton.Name = "PremiumRadioButton"
        Me.PremiumRadioButton.Size = New System.Drawing.Size(225, 24)
        Me.PremiumRadioButton.TabIndex = 15
        Me.PremiumRadioButton.TabStop = True
        Me.PremiumRadioButton.Text = "Premium $29.99 per month"
        Me.PremiumRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Membership type:"
        '
        'AddCardButton
        '
        Me.AddCardButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.AddCardButton.ForeColor = System.Drawing.Color.White
        Me.AddCardButton.Location = New System.Drawing.Point(359, 412)
        Me.AddCardButton.Name = "AddCardButton"
        Me.AddCardButton.Size = New System.Drawing.Size(110, 32)
        Me.AddCardButton.TabIndex = 13
        Me.AddCardButton.Text = "Submit"
        Me.AddCardButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Anita_Suit_App.My.Resources.Resources.credit_card_logos
        Me.PictureBox1.Location = New System.Drawing.Point(402, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Expiration date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name on Card:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Card number:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Silver
        Me.TextBox4.Location = New System.Drawing.Point(103, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(55, 23)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "Year"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Silver
        Me.TextBox3.Location = New System.Drawing.Point(45, 187)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(52, 23)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Month"
        '
        'NameOnCardTextBox
        '
        Me.NameOnCardTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameOnCardTextBox.ForeColor = System.Drawing.Color.Silver
        Me.NameOnCardTextBox.Location = New System.Drawing.Point(45, 117)
        Me.NameOnCardTextBox.Name = "NameOnCardTextBox"
        Me.NameOnCardTextBox.Size = New System.Drawing.Size(329, 23)
        Me.NameOnCardTextBox.TabIndex = 1
        Me.NameOnCardTextBox.Text = "As appear on card"
        '
        'CardNumTextBox
        '
        Me.CardNumTextBox.Location = New System.Drawing.Point(45, 62)
        Me.CardNumTextBox.Name = "CardNumTextBox"
        Me.CardNumTextBox.Size = New System.Drawing.Size(329, 26)
        Me.CardNumTextBox.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Anita_Suit_App.My.Resources.Resources.Anita_Suit_Logo_New
        Me.PictureBox2.Location = New System.Drawing.Point(265, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(211, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'CreditCardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 658)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CreditCardForm"
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents NameOnCardTextBox As TextBox
    Friend WithEvents CardNumTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddCardButton As Button
    Friend WithEvents PayPerUseRadioButton3 As RadioButton
    Friend WithEvents StandardRadioButton As RadioButton
    Friend WithEvents PremiumRadioButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
