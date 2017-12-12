Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strName() As String = {"Alpha", "Beta", "Delta", "Kappa"}

        Dim intHighSub As Integer = strName.GetUpperBound(0)
        'for next
        For intSub As Integer = 0 To intHighSub
            lstForNext.Items.Add(strName(intSub))
        Next intSub

        'do loop
        Dim intHiSub As Integer = strName.GetUpperBound(0)
        Dim intS As Integer

        Do While intS <= intHiSub
            lstDoLoop.Items.Add(strName(intS))
            intS += 1
        Loop

        'For Each
        For Each strN As String In strName
            lstForEachNext.Items.Add(strN)
        Next strN
    End Sub
End Class
