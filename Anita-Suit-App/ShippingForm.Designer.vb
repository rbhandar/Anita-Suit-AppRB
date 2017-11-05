<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingForm
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
        Me.ShipCityTextBox = New System.Windows.Forms.TextBox()
        Me.AhipHouseNumTextBox = New System.Windows.Forms.TextBox()
        Me.ShipStreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ShipCountryTextBox = New System.Windows.Forms.TextBox()
        Me.ShipStateTextBox = New System.Windows.Forms.TextBox()
        Me.ShipZipTextBox = New System.Windows.Forms.TextBox()
        Me.ShipGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShipCheckBox = New System.Windows.Forms.CheckBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ShipContinueButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ShipGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShipCityTextBox
        '
        Me.ShipCityTextBox.Location = New System.Drawing.Point(132, 172)
        Me.ShipCityTextBox.Name = "ShipCityTextBox"
        Me.ShipCityTextBox.Size = New System.Drawing.Size(261, 26)
        Me.ShipCityTextBox.TabIndex = 0
        '
        'AhipHouseNumTextBox
        '
        Me.AhipHouseNumTextBox.Location = New System.Drawing.Point(132, 103)
        Me.AhipHouseNumTextBox.Name = "AhipHouseNumTextBox"
        Me.AhipHouseNumTextBox.Size = New System.Drawing.Size(261, 26)
        Me.AhipHouseNumTextBox.TabIndex = 1
        '
        'ShipStreetAddressTextBox
        '
        Me.ShipStreetAddressTextBox.Location = New System.Drawing.Point(132, 42)
        Me.ShipStreetAddressTextBox.Name = "ShipStreetAddressTextBox"
        Me.ShipStreetAddressTextBox.Size = New System.Drawing.Size(261, 26)
        Me.ShipStreetAddressTextBox.TabIndex = 2
        '
        'ShipCountryTextBox
        '
        Me.ShipCountryTextBox.Location = New System.Drawing.Point(132, 380)
        Me.ShipCountryTextBox.Name = "ShipCountryTextBox"
        Me.ShipCountryTextBox.Size = New System.Drawing.Size(261, 26)
        Me.ShipCountryTextBox.TabIndex = 3
        '
        'ShipStateTextBox
        '
        Me.ShipStateTextBox.Location = New System.Drawing.Point(132, 242)
        Me.ShipStateTextBox.Name = "ShipStateTextBox"
        Me.ShipStateTextBox.Size = New System.Drawing.Size(261, 26)
        Me.ShipStateTextBox.TabIndex = 4
        '
        'ShipZipTextBox
        '
        Me.ShipZipTextBox.Location = New System.Drawing.Point(132, 311)
        Me.ShipZipTextBox.Name = "ShipZipTextBox"
        Me.ShipZipTextBox.Size = New System.Drawing.Size(261, 26)
        Me.ShipZipTextBox.TabIndex = 5
        '
        'ShipGroupBox
        '
        Me.ShipGroupBox.Controls.Add(Me.Label7)
        Me.ShipGroupBox.Controls.Add(Me.PhoneNumberTextBox)
        Me.ShipGroupBox.Controls.Add(Me.ShipCheckBox)
        Me.ShipGroupBox.Controls.Add(Me.BackButton)
        Me.ShipGroupBox.Controls.Add(Me.ShipContinueButton)
        Me.ShipGroupBox.Controls.Add(Me.Label6)
        Me.ShipGroupBox.Controls.Add(Me.Label5)
        Me.ShipGroupBox.Controls.Add(Me.Label4)
        Me.ShipGroupBox.Controls.Add(Me.Label3)
        Me.ShipGroupBox.Controls.Add(Me.Label2)
        Me.ShipGroupBox.Controls.Add(Me.Label1)
        Me.ShipGroupBox.Controls.Add(Me.ShipCountryTextBox)
        Me.ShipGroupBox.Controls.Add(Me.ShipZipTextBox)
        Me.ShipGroupBox.Controls.Add(Me.ShipCityTextBox)
        Me.ShipGroupBox.Controls.Add(Me.ShipStateTextBox)
        Me.ShipGroupBox.Controls.Add(Me.AhipHouseNumTextBox)
        Me.ShipGroupBox.Controls.Add(Me.ShipStreetAddressTextBox)
        Me.ShipGroupBox.ForeColor = System.Drawing.Color.Chocolate
        Me.ShipGroupBox.Location = New System.Drawing.Point(110, 76)
        Me.ShipGroupBox.Name = "ShipGroupBox"
        Me.ShipGroupBox.Size = New System.Drawing.Size(531, 568)
        Me.ShipGroupBox.TabIndex = 6
        Me.ShipGroupBox.TabStop = False
        Me.ShipGroupBox.Text = "Shipping Address"
        '
        'ShipCheckBox
        '
        Me.ShipCheckBox.AutoSize = True
        Me.ShipCheckBox.Location = New System.Drawing.Point(130, 484)
        Me.ShipCheckBox.Name = "ShipCheckBox"
        Me.ShipCheckBox.Size = New System.Drawing.Size(279, 24)
        Me.ShipCheckBox.TabIndex = 14
        Me.ShipCheckBox.Text = "Biiling address is same as shipping"
        Me.ShipCheckBox.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(6, 518)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(110, 32)
        Me.BackButton.TabIndex = 13
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ShipContinueButton
        '
        Me.ShipContinueButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.ShipContinueButton.ForeColor = System.Drawing.Color.White
        Me.ShipContinueButton.Location = New System.Drawing.Point(415, 518)
        Me.ShipContinueButton.Name = "ShipContinueButton"
        Me.ShipContinueButton.Size = New System.Drawing.Size(110, 32)
        Me.ShipContinueButton.TabIndex = 12
        Me.ShipContinueButton.Text = "Contiue"
        Me.ShipContinueButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zip code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(128, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "House, Apt or Suite:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Street address:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anita_Suit_App.My.Resources.Resources.Anita_Suit_Logo_New
        Me.PictureBox1.Location = New System.Drawing.Point(291, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Phone number:"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.ForeColor = System.Drawing.Color.DimGray
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(130, 452)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(261, 26)
        Me.PhoneNumberTextBox.TabIndex = 15
        Me.PhoneNumberTextBox.Text = "(---) --- ----"
        '
        'ShippingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 671)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShipGroupBox)
        Me.Name = "ShippingForm"
        Me.Text = "Shipping"
        Me.ShipGroupBox.ResumeLayout(False)
        Me.ShipGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShipCityTextBox As TextBox
    Friend WithEvents AhipHouseNumTextBox As TextBox
    Friend WithEvents ShipStreetAddressTextBox As TextBox
    Friend WithEvents ShipCountryTextBox As TextBox
    Friend WithEvents ShipStateTextBox As TextBox
    Friend WithEvents ShipZipTextBox As TextBox
    Friend WithEvents ShipGroupBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents ShipContinueButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShipCheckBox As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PhoneNumberTextBox As TextBox
End Class
