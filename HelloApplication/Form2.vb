Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' Change word in text label to Spanish.
        lblMessage.Text = "Hola!"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ' Change the text color.
        lblMessage.ForeColor = Color.LimeGreen

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Close the application.
        Me.Close()

    End Sub
End Class