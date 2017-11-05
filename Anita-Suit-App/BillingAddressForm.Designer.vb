<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingAddressForm
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
        Me.BillCountryTextBox = New System.Windows.Forms.TextBox()
        Me.BillZipTextBox = New System.Windows.Forms.TextBox()
        Me.BillCityTextBox = New System.Windows.Forms.TextBox()
        Me.BillStateTextBox = New System.Windows.Forms.TextBox()
        Me.BillHouseNumTextBox = New System.Windows.Forms.TextBox()
        Me.BillStreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BillingAddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ShipContinueButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BillingAddressGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BillCountryTextBox
        '
        Me.BillCountryTextBox.Location = New System.Drawing.Point(132, 402)
        Me.BillCountryTextBox.Name = "BillCountryTextBox"
        Me.BillCountryTextBox.Size = New System.Drawing.Size(261, 26)
        Me.BillCountryTextBox.TabIndex = 3
        '
        'BillZipTextBox
        '
        Me.BillZipTextBox.Location = New System.Drawing.Point(132, 331)
        Me.BillZipTextBox.Name = "BillZipTextBox"
        Me.BillZipTextBox.Size = New System.Drawing.Size(261, 26)
        Me.BillZipTextBox.TabIndex = 5
        '
        'BillCityTextBox
        '
        Me.BillCityTextBox.Location = New System.Drawing.Point(132, 188)
        Me.BillCityTextBox.Name = "BillCityTextBox"
        Me.BillCityTextBox.Size = New System.Drawing.Size(261, 26)
        Me.BillCityTextBox.TabIndex = 0
        '
        'BillStateTextBox
        '
        Me.BillStateTextBox.Location = New System.Drawing.Point(132, 261)
        Me.BillStateTextBox.Name = "BillStateTextBox"
        Me.BillStateTextBox.Size = New System.Drawing.Size(261, 26)
        Me.BillStateTextBox.TabIndex = 4
        '
        'BillHouseNumTextBox
        '
        Me.BillHouseNumTextBox.Location = New System.Drawing.Point(132, 119)
        Me.BillHouseNumTextBox.Name = "BillHouseNumTextBox"
        Me.BillHouseNumTextBox.Size = New System.Drawing.Size(261, 26)
        Me.BillHouseNumTextBox.TabIndex = 1
        '
        'BillStreetAddressTextBox
        '
        Me.BillStreetAddressTextBox.Location = New System.Drawing.Point(132, 52)
        Me.BillStreetAddressTextBox.Name = "BillStreetAddressTextBox"
        Me.BillStreetAddressTextBox.Size = New System.Drawing.Size(261, 26)
        Me.BillStreetAddressTextBox.TabIndex = 2
        '
        'BillingAddressGroupBox
        '
        Me.BillingAddressGroupBox.Controls.Add(Me.BackButton)
        Me.BillingAddressGroupBox.Controls.Add(Me.ShipContinueButton)
        Me.BillingAddressGroupBox.Controls.Add(Me.Label6)
        Me.BillingAddressGroupBox.Controls.Add(Me.Label5)
        Me.BillingAddressGroupBox.Controls.Add(Me.Label4)
        Me.BillingAddressGroupBox.Controls.Add(Me.Label3)
        Me.BillingAddressGroupBox.Controls.Add(Me.Label2)
        Me.BillingAddressGroupBox.Controls.Add(Me.Label1)
        Me.BillingAddressGroupBox.Controls.Add(Me.BillCountryTextBox)
        Me.BillingAddressGroupBox.Controls.Add(Me.BillZipTextBox)
        Me.BillingAddressGroupBox.Controls.Add(Me.BillCityTextBox)
        Me.BillingAddressGroupBox.Controls.Add(Me.BillStateTextBox)
        Me.BillingAddressGroupBox.Controls.Add(Me.BillHouseNumTextBox)
        Me.BillingAddressGroupBox.Controls.Add(Me.BillStreetAddressTextBox)
        Me.BillingAddressGroupBox.ForeColor = System.Drawing.Color.Chocolate
        Me.BillingAddressGroupBox.Location = New System.Drawing.Point(124, 76)
        Me.BillingAddressGroupBox.Name = "BillingAddressGroupBox"
        Me.BillingAddressGroupBox.Size = New System.Drawing.Size(485, 525)
        Me.BillingAddressGroupBox.TabIndex = 8
        Me.BillingAddressGroupBox.TabStop = False
        Me.BillingAddressGroupBox.Text = "Billing Address"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(39, 460)
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
        Me.ShipContinueButton.Location = New System.Drawing.Point(316, 460)
        Me.ShipContinueButton.Name = "ShipContinueButton"
        Me.ShipContinueButton.Size = New System.Drawing.Size(110, 32)
        Me.ShipContinueButton.TabIndex = 12
        Me.ShipContinueButton.Text = "Contiue"
        Me.ShipContinueButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Country:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(128, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hour, Apt or Suite:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Street address:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anita_Suit_App.My.Resources.Resources.Anita_Suit_Logo_New
        Me.PictureBox1.Location = New System.Drawing.Point(287, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BillingAddressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 649)
        Me.Controls.Add(Me.BillingAddressGroupBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BillingAddressForm"
        Me.Text = "Billing Address"
        Me.BillingAddressGroupBox.ResumeLayout(False)
        Me.BillingAddressGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BillCountryTextBox As TextBox
    Friend WithEvents BillZipTextBox As TextBox
    Friend WithEvents BillCityTextBox As TextBox
    Friend WithEvents BillStateTextBox As TextBox
    Friend WithEvents BillHouseNumTextBox As TextBox
    Friend WithEvents BillStreetAddressTextBox As TextBox
    Friend WithEvents BillingAddressGroupBox As GroupBox
    Friend WithEvents BackButton As Button
    Friend WithEvents ShipContinueButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
