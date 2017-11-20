Option Strict On

Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAvg.Click

    End Sub

    Private Sub btnPreDoWhile_Click(sender As Object, e As EventArgs) Handles btnPreDoWhile.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPreDoUntil_Click(sender As Object, e As EventArgs) Handles btnPreDoUntil.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPreLoopWhile_Click(sender As Object, e As EventArgs) Handles btnPreLoopWhile.Click
        lblEven.Text = "Posttest: Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub btnPreLoopUntil_Click(sender As Object, e As EventArgs) Handles btnPreLoopUntil.Click
        lblEven.Text = "Posttest: Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub btnPreFor_Click(sender As Object, e As EventArgs) Handles btnPreFor.Click
        lblEven.Text = "Pretest: For" & ControlChars.NewLine
        'Dim i As Integer = 2
        For i As Integer = 2 To 20 Step 0
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Next i
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")
        ' convert the input to a number
        Int32.TryParse(strNum, intNum)

        ' *** Begin loop here: repeat as long as input is not empty
        Do While intNum > 0
            ' display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** Update control variable
            strNum = InputBox(strPROMPT, strTITLE, "0")
            ' convert the input to a number
            Int32.TryParse(strNum, intNum)
            ' *** End loop here
        Loop


        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount >= 1 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")
        ' convert the input to a number
        Int32.TryParse(strNum, intNum)

        ' *** Begin loop here: repeat as long as input is not empty
        Do
            ' display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** Update control variable
            strNum = InputBox(strPROMPT, strTITLE, "0")
            Int32.TryParse(strNum, intNum)

            ' *** End loop here
        Loop Until intNum < 1


        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intInput As Integer

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")
        Int32.TryParse(strNum, intCount)

        ' *** Begin loop here: repeat as long as input is not empty
        For intNum = 1 To intCount
            strNum = InputBox(strPROMPT, strTITLE, "0")
            ' convert the input to a number
            Int32.TryParse(strNum, intInput)

            ' display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intSum = intSum + intNum

            ' *** Update control variable

            ' *** End loop here
        Next intNum


        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
