Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim input As String
        Dim small As Integer = 12521112
        Dim large As Integer
        Dim num As Integer

        Do
            Do 'getting input from user
                input = InputBox("Enter a sequence of positive numbers. When you've finished, enter '0'")
            Loop While (IsNumeric(input) = False)
            num = Val(input)
            If num > input Then
                large = input
            End If
            If num < input Then
                num = small
            End If
            If Val(input) = 0 Then
                Exit Do
            End If
        Loop While num <> 0

        lblSmall.Text = small
        lblLarge.Text = large

    End Sub
End Class
