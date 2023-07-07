Public Class Form5
    Dim col As Double = 1
    Dim num As Int16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim col1, col2, col3 As Double
        col1 = (col * 5 + 1 + num * 3) Mod 256
        col2 = (col * 3 + col1 * 2 + 7 + num * 15) Mod 256
        col3 = (col * 7 + col1 * 5 + col2 * 9 + 20 + num * 27) Mod 256
        Dim cor As Color = Color.FromArgb(col1, col2, col3)
        Label1.BackColor = cor
        col = (col * 17 + col1 * 13 + col2 * 23 + col3 * 27 + 37 + num * 11) Mod 750

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim col1, col2, col3 As Double
        col1 = (col * 65 + 7 + num * 13) Mod 256
        col2 = (col * 35 + col1 * 91 + 3 + num * 5) Mod 256
        col3 = (col * 27 + col1 * 59 + col2 * 57 + 33 + num * 43) Mod 256
        Dim cor As Color = Color.FromArgb(col1, col2, col3)
        Me.BackColor = cor
        col = (col * 67 + col1 * 93 + col2 * 77 + col3 * 69 + 99 + num * 101) Mod 900
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num = (100 * Rnd(col * num * 11 + col * 7 + num * 3) + 1)
        col = (col * 321 + 45 + num * 543 + num*col*259) Mod 1100
        Label1.Text = num

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Text = "Isto é uma legenda"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.BackColor = DefaultBackColor
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.BackColor = DefaultBackColor
    End Sub
End Class