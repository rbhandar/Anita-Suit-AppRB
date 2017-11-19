
Public Class SignUpForm
    Protected db As db = New db
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles RetypePasswordTextBox.TextChanged

    End Sub

    Private Sub SignUpContinueButton_Click(sender As Object, e As EventArgs) Handles SignUpContinueButton.Click
        db.sql = "INSERT INTO Anita_Customer ( First_Name, Last_Name, Email_Address, User_Name, Password, Phone_Number)
                  VALUES (@First_Name, @Last_Name, @Email_Address, @User_Name, @Password, @Phone_Number);"
        db.bind("@First_Name", FirstNameTextBox.Text)
        db.bind("@Last_Name", LastNameTextBox.Text)
        db.bind("@Email_Address", EmailTextBox.Text)
        db.bind("@User_Name", EmailTextBox.Text)
        db.bind("@Password", PasswordTextBox.Text)
        db.bind("@Phone_Number", SignUpPhoneNumTextBox.Text)
        db.execute()

        BillingAddressForm.ShowDialog()
    End Sub
End Class