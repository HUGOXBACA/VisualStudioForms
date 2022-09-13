'This code belongs to a form with a button and label, click the button, the label changes the displayed text
Public Class Form1

    Private Sub btnClickThis_Click(sender As Object, e As EventArgs) Handles btnClickThis.Click
        lblHelloWorld.Text = "Hello World!"

    End Sub

End Class
