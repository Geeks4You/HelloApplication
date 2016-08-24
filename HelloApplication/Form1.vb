Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        ' Click the button and create a new window with the word Hello!
        Dim Form1 As Form2
        Form1 = New Form2()
        Form1.Show()
        Form1 = Nothing
        Me.Hide()
    End Sub
End Class
