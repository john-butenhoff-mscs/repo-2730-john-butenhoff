'Name:          jbutenhoff3e1
'Purpose:       Display counts of salespeople commissions
'Programmer:    John Butenhoff on 12/12/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 750, 900,
            150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}
    Private Sub DisplayCommission()
        Dim intHighSub As Integer = intCommission.GetUpperBound(0)

        'display the array in the lblCommissions.Text 
        For Each intSub As Integer In intCommission
            lblCommissions.Text &= intSub.ToString & ", "
        Next intSub

        'Remove extra ", " from lblLessThanAvg.Text:
        If lblCommissions.Text.EndsWith(", ") Then
            lblCommissions.Text = lblCommissions.Text.Substring(0, lblCommissions.Text.Length - 2)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommission()
        cboSearchValues.SelectedIndex = 0
        cboSearchRanges.SelectedIndex = 0
    End Sub

    'Convert input to intSearchValue
    'If intSearchValue is valid
    '       Call CountValue, display result in lblValueCount
    'Otherwise
    '       Display message box
    'End if
    Private Sub cboSearchValues_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValues.TextChanged
        Dim intSearchValue As Integer
        Dim intCount As Integer
        Dim strMSG As String = ""
        Integer.TryParse(cboSearchValues.Text, intSearchValue)

        If intSearchValue >= 0 AndAlso intSearchValue <= 1000 Then
            intCount = CountValue(intSearchValue)
        Else
            MessageBox.Show(strMSG, "Invalid Entry",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        End If
        lblValueCount.Text = intCount.ToString()

    End Sub

    Private Function CountValue(intSearchValue As Integer) As Integer
        Dim intCount As Integer

        For Each intSub As Integer In intCommission
            If intSub = intSearchValue Then
                intCount += 1
            End If
        Next intSub
        Return intCount
    End Function

    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        Dim intCount As Integer

        For Each intSub As Integer In intCommission
            If intSub >= intSearchMin AndAlso intSub <= intSearchMax Then
                intCount += 1
            End If
        Next intSub
        Return intCount

    End Function
    Private Sub cboSearchRanges_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRanges.TextChanged
        'blank out the label
        lblRangeCount.Text = String.Empty

        'declare some variables
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        'search for the hyphen. everything before the hyphen is the "min", everything after the hyphen is the "max."
        Dim intHyphenIndex As Integer = cboSearchRanges.Text.IndexOf("-")

        'if it doesn't find the hyphen the hyphen index will be -1, if it does find it the hyphen index will be >= 0.
        'if it's >= 0 and if the length of the text in the cbo is > the index +1. then find everything
        If intHyphenIndex >= 0 AndAlso cboSearchRanges.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRanges.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                  cboSearchRanges.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)

            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString

            End If

        End If
    End Sub
End Class
