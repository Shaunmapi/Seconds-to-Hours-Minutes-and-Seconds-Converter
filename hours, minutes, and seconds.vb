Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Get the input value
        Dim totalSeconds As Integer

        ' Try to parse the input value to an integer
        If Integer.TryParse(TextBox1.Text, totalSeconds) Then
            ' Calculate hours, minutes, and seconds
            Dim hours As Integer = totalSeconds \ 3600
            Dim remainingSeconds As Integer = totalSeconds Mod 3600
            Dim minutes As Integer = remainingSeconds \ 60
            Dim seconds As Integer = remainingSeconds Mod 60

            ' Display the results in the corresponding text boxes
            TextBox2.Text = hours.ToString()
            TextBox3.Text = minutes.ToString()
            TextBox4.Text = seconds.ToString()
        Else
            ' Display an error message if the input is not a valid integer
            MessageBox.Show("Please enter a valid number of seconds.")
            End If
        End Sub

    End Class


