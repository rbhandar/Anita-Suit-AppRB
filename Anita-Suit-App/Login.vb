Imports System.Data.SqlClient
Public Class LoginForm
    Protected db As db = New db


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=ISYS4283F1702;Trusted_Connection=yes;")
        Dim command As New SqlCommand("SELECT * from Anita_Customer WHERE [User_Name] = @User_Name and [Password] = @Password", connection)
        command.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = UserIDTextBox.Text
        command.Parameters.Add("@Password", SqlDbType.VarChar).Value = PasswordTextBox.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim Dataset As New DataTable()

        adapter.Fill(Dataset)

        If Dataset.Rows.Count() <= 0 Then
            MsgBox("Invalid Username or Password!", MsgBoxStyle.Critical, "Error")
        Else
            Me.Hide()
            MyHomePageform.Show()


            MsgBox("Login successful!", MsgBoxStyle.Information, "Congratulations")
        End If

        'db.sql = "SELECT * from Anita_Customer WHERE [User_Name] = @User_Name and [Password] = @Password;"
        'db.bind("@User_Name", UserIDTextBox.Text)
        'db.bind("@Password", PasswordTextBox.Text)
        'db.execute()

        'If DataSet.Rows.Count() <= 0 Then
        '    MsgBox("Invalid Username or Password!", MsgBoxStyle.Critical, "Error")
        'Else
        '    Me.Hide()
        '    MyHomePageform.Show()
        '    MsgBox("Login successful!", MsgBoxStyle.Information, "Congratulations")
        'End If



    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        Me.Hide()
        SignUpForm.ShowDialog()

    End Sub
End Class
