<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.CreditCardTextBox = New System.Windows.Forms.TextBox()
        Me.NameOnCardTextBox = New System.Windows.Forms.TextBox()
        Me.ExpirationMonthTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExpirationYearTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShipContinueButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShipContinueButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ExpirationYearTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ExpirationMonthTextBox)
        Me.GroupBox1.Controls.Add(Me.NameOnCardTextBox)
        Me.GroupBox1.Controls.Add(Me.CreditCardTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credit Card:"
        '
        'CreditCardTextBox
        '
        Me.CreditCardTextBox.Location = New System.Drawing.Point(149, 42)
        Me.CreditCardTextBox.Name = "CreditCardTextBox"
        Me.CreditCardTextBox.Size = New System.Drawing.Size(242, 26)
        Me.CreditCardTextBox.TabIndex = 0
        '
        'NameOnCardTextBox
        '
        Me.NameOnCardTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.NameOnCardTextBox.Location = New System.Drawing.Point(149, 98)
        Me.NameOnCardTextBox.Name = "NameOnCardTextBox"
        Me.NameOnCardTextBox.Size = New System.Drawing.Size(289, 26)
        Me.NameOnCardTextBox.TabIndex = 1
        Me.NameOnCardTextBox.Text = "as appear on card"
        '
        'ExpirationMonthTextBox
        '
        Me.ExpirationMonthTextBox.Location = New System.Drawing.Point(158, 175)
        Me.ExpirationMonthTextBox.Name = "ExpirationMonthTextBox"
        Me.ExpirationMonthTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ExpirationMonthTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Card number:"
        '
        'ExpirationYearTextBox
        '
        Me.ExpirationYearTextBox.Location = New System.Drawing.Point(277, 174)
        Me.ExpirationYearTextBox.Name = "ExpirationYearTextBox"
        Me.ExpirationYearTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ExpirationYearTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name on card:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'ShipContinueButton
        '
        Me.ShipContinueButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.ShipContinueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ShipContinueButton.ForeColor = System.Drawing.Color.White
        Me.ShipContinueButton.Location = New System.Drawing.Point(186, 238)
        Me.ShipContinueButton.Name = "ShipContinueButton"
        Me.ShipContinueButton.Size = New System.Drawing.Size(86, 31)
        Me.ShipContinueButton.TabIndex = 12
        Me.ShipContinueButton.Text = "Continue"
        Me.ShipContinueButton.UseVisualStyleBackColor = False
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 604)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PaymentForm"
        Me.Text = "PaymentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExpirationYearTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExpirationMonthTextBox As TextBox
    Friend WithEvents NameOnCardTextBox As TextBox
    Friend WithEvents CreditCardTextBox As TextBox
    Friend WithEvents ShipContinueButton As Button
End Class
