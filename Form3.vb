Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub BtnCalcVol_Click(sender As Object, e As EventArgs) Handles BtnCalcVol.Click
        Dim vol As Double
        If TxtBoxComp.TextLength <> 0 And TxtBoxLarg.TextLength <> 0 And TxtBoxAltu.TextLength <> 0 Then
            vol = Convert.ToDouble(TxtBoxComp.Text) * Convert.ToDouble(TxtBoxLarg.Text) * Convert.ToDouble(TxtBoxAltu.Text)
            TxtBoxOutVol.Text = vol.ToString
        End If
    End Sub
End Class