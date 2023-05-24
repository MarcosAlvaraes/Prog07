Public Class Form4
    Private Sub BtnSomar_Click(sender As Object, e As EventArgs) Handles BtnSomar.Click
        Dim soma As Double
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            soma = Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text)
            TxtBoxResul.Text = soma.ToString
        End If
    End Sub

    Private Sub BtnSubtrair_Click(sender As Object, e As EventArgs) Handles BtnSubtrair.Click
        Dim subt As Double
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            subt = Convert.ToDouble(TextBox1.Text) - Convert.ToDouble(TextBox2.Text)
            TxtBoxResul.Text = subt.ToString
        End If

    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click
        Dim prod As Double
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            prod = Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox2.Text)
            TxtBoxResul.Text = prod.ToString
        End If

    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click
        Dim div As Double
        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            div = Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(TextBox2.Text)
            TxtBoxResul.Text = div.ToString
        End If

    End Sub
End Class