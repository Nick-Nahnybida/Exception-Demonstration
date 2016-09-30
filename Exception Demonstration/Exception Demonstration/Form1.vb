Public Class Form1

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Declare a variable to hold the user's salary.
        Dim decSalary As Decimal

        Try
            ' Get the users input and convert it to a Decimal.
            decSalary = CDec(txtSalary.Text)

            ' Display the user's salary.
            lblResult.Text = "Your salary is " & decSalary.ToString("c")
        Catch
            ' Display an error message.
            lblResult.Text = "Please try again, and enter a number."
        End Try
    End Sub
End Class
