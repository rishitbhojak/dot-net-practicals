﻿Public Class Form1
    Dim value1, value2 As Integer
    Dim sign As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "+"
    End Sub

    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "-"
    End Sub

    Private Sub ButtonProd_Click(sender As Object, e As EventArgs) Handles ButtonProd.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "X"
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "/"
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        value2 = TextBox1.Text
        If sign = "+" Then
            TextBox1.Text = value1 + value2
        ElseIf sign = "-" Then
            TextBox1.Text = value1 - value2
        ElseIf sign = "X" Then
            TextBox1.Text = value1 * value2
        ElseIf sign = "/" Then
            TextBox1.Text = value1 / value2
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub
End Class
