'Name:          Ex3D: Array subscripts, totals, avg, min
'Purpose:       Display the average number sold
'Programmer:    John Butenhoff on 12/11/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intSold() As Integer = {250, 225, 193, 260}
    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}
    Private intMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
    'declare and initialize daysInMonth array
    ' if month entered by user is valid
    '       display days in selected month
    'otherwise
    '       display error message
    'set focus to txtMonth and select all text

    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        Dim intHighSub As Integer = intMonth.GetUpperBound(0)
        Dim intDays As Integer
        Dim strMSG As String = "Invalid entry"

        Integer.TryParse(txtMonth.Text, intDays)

        If intDays > 0 AndAlso intDays <= 12 Then
            lblDays.Text = intMonth(intDays - 1).ToString
        Else
            MessageBox.Show(strMSG, "Invalid Entry",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If

        txtMonth.Focus()

    End Sub

    Private Sub txtMonth_GotFocus(sender As Object, e As EventArgs) Handles txtMonth.GotFocus
        txtMonth.SelectAll()
    End Sub


    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        'Clear Labels
        lblAvgSold.Text = ""
        lblLessThanAvg.Text = ""

        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim intTotal As Integer
        Dim dblAvg As Double

        'Use loop to calculate total of elements in intSold array
        For intSub As Integer = 0 To intHighSub
            intTotal += intSold(intSub)
        Next intSub

        'Calculate and display average
        dblAvg = intTotal / intSold.Length
        lblAvgSold.Text = dblAvg.ToString()

        'Use same loop to find and display intSold elements < average:
        '       lblLessThanAvg.Text &= intSold(intSub).ToString & ", "
        For intSub As Integer = 0 To intHighSub
            If intSold(intSub) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intSub).ToString & ", "
            End If
        Next intSub

        'Remove extra ", " from lblLessThanAvg.Text:
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        'Clear Labels
        lblAvgSold.Text = ""
        lblLessThanAvg.Text = ""

        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim intTotal As Integer
        Dim dblAvg As Double

        'Use loop to calculate total of elements in intSold array
        For Each intSub As Integer In intSold
            intTotal += intSub
        Next intSub

        'Calculate and display average
        dblAvg = intTotal / intSold.Length
        lblAvgSold.Text = dblAvg.ToString()

        'Use same loop to find and display intSold elements < average:
        '       lblLessThanAvg.Text &= intSold(intSub).ToString & ", "
        For Each intSub As Integer In intSold
            If intSub < dblAvg Then
                lblLessThanAvg.Text &= intSub.ToString & ", "
            End If
        Next intSub

        'Remove extra ", " from lblLessThanAvg.Text:
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        'Clear Labels
        lblAvgSold.Text = ""
        lblLessThanAvg.Text = ""

        Dim intHighSub As Integer = intSold.GetUpperBound(0)
        Dim intTotal As Integer
        Dim dblAvg As Double
        Dim intSub As Integer

        'Use loop to calculate total of elements in intSold array
        Do While intSub <= intHighSub
            intTotal += intSold(intSub)
            intSub += 1
        Loop

        'Calculate and display average
        dblAvg = intTotal / intSold.Length
        lblAvgSold.Text = dblAvg.ToString()

        'Use same loop to find and display intSold elements < average:
        '       lblLessThanAvg.Text &= intSold(intSub).ToString & ", "
        Do While intSub <= intHighSub
            If intSold(intSub) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intSub).ToString & ", "
            End If
        Loop

        'Remove extra ", " from lblLessThanAvg.Text:
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fill lstWholesale with array values

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        ' returns array to the original wholesale prices
        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        'dblWholesale(0) = 100.0
        'lstRetail.Items.Clear()

        'For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
        '    lstRetail.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        'Next intSub
    End Sub
End Class
