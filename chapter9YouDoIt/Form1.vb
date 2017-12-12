Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaration of the Array & the Initialization List {2, 4, 6, etc...}
        Dim intNums() As Integer = {2, 4, 6, 8, 10, 12}

        'To find the Length: Array Name .Length, convert to a string, and store it in lblLength.Text
        lblLength.Text = intNums.Length.ToString
        'To find the UpperBound: Array Name, Call .GetUpperBound(0), Add 1 for display purposes (otherwise it would be 5), convert to a string, and store it in lblUpperBound.Text. *Side* they haven't explained the (0) in the UpperBound parenthese.
        lblUpperBound.Text = (intNums.GetUpperBound(0) + 1).ToString


    End Sub
End Class
