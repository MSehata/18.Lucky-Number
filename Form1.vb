Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Dim age As Integer, name As String, luckyNumber As Integer

        age = Val(txtAge.Text)
        name = txtName.Text
        luckyNumber = Int(Rnd() * 200) + 1
        txtYourLuckyNumber.Text = luckyNumber

        If luckyNumber > 120 And age > 50 Then
            txtComment.Text = "Congratulations " & name & ", you WON a lucky prize"
        Else
            txtComment.Text = "Sorry " & name & ", you did not win any prize"
        End If



    End Sub
End Class
