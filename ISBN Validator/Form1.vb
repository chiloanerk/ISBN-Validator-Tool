Public Class Form1
  Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
    Dim ISBN(9) As Integer
    Dim input As String = mtbISBN.Text
    Dim sum As Integer
    Dim multiplier As Integer = 10
    Dim index As Integer = 0

    'Check if the last digit is a number or X
    If input.EndsWith("X".ToUpper()) Then
      ISBN(9) = 10
      sum += 10
    ElseIf IsNumeric(input.Substring(12, 1)) Then
      ISBN(9) = CInt(input.Substring(12, 1))
      sum += ISBN(9)
    Else
      MessageBox.Show("You entered invalid charachter!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If

    'Create the loop for the input ISBN including the hyphens and exclude them in the array
    For i As Integer = 0 To input.Length - 2
      If IsNumeric(input.Substring(i, 1)) Then
        ISBN(index) = CInt(input.Substring(i, 1))
        sum += multiplier * ISBN(index)
        multiplier -= 1
        index += 1
      End If
    Next
    'Check if divisible by 10 and print an output
    If sum Mod 11 = 0 Then
      txtOutput.Text = "YES"
    Else
      txtOutput.Text = "NO"
    End If

  End Sub
End Class
