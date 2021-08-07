Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Clear()
        txtNum2.Clear()
        txtNum3.Clear()
        txtNum4.Clear()
        txtSum.Clear()
        txtPer.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim num1, num2, num3, num4, sum As Integer
        Dim percentage As Double
        'Taking Input values'
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        num3 = txtNum3.Text
        num4 = txtNum4.Text
        'Calculating total marks'
        sum = num1 + num2 + num3 + num4
        'Calculating the percentage'
        percentage = (sum / 400) * 100
        'Displaying the output in textbox'
        txtSum.Text = sum
        txtPer.Text = percentage

    End Sub
End Class
