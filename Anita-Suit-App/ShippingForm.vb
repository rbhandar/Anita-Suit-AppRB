Public Class ShippingForm
    Protected db As db = New db
    Private Sub PhoneNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneNumberTextBox.TextChanged

    End Sub

    Private Sub ShipContinueButton_Click(sender As Object, e As EventArgs) Handles ShipContinueButton.Click

        db.sql = " INSERT INTO Anita_Shipping(Shipping_Address, Customer_ID, Billing_Address_ID, City, [State], Zip, Country)
                  VALUES (@Shipping_Address, @Customer_ID., @Billing_Address_ID, @City, @State, @Phone_Number);"
        db.bind("@Shipping_Address", ShipStreetAddressTextBox.Text)
        db.bind("@Customer_ID", db.sql = "select MAX(Customer_ID) from Anita_Customer;")
        db.bind("@Billing_Address_ID", "")
        db.bind("@City", ShipCityTextBox.Text)
        db.bind("@State", ShipStateTextBox.Text)
        db.bind("@Zip", ShipZipTextBox.Text)
        db.bind("@Country", ShipCountryTextBox.Text)
        db.execute()

        BillingAddressForm.ShowDialog()
    End Sub
End Class