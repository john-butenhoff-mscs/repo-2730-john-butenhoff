' Name:         Average Test Score Project
' Purpose:      Calculates Average Test Score
' Programmer:   John Butenhoff on 9/11/2017

Option Strict On

Public Class frmMain
    Private Sub lblTest3_Click(sender As Object, e As EventArgs) Handles lblTest3.Click, lblAvgTest.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare for next calculation
        txtTest1.Text = String.Empty
        txtTest2.Text = String.Empty
        txtTest3.Text = String.Empty
        txtAvgTest.Text = String.Empty

        'Send to focus
        txtTest1.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtAvgTest.Text = Str((Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text)) / 3)
        txtAvgTest.Text = Format(txtAvgTest.Text, "fixed")

    End Sub

    Private Sub txtTest1_TextChanged(sender As Object, e As EventArgs) Handles txtTest1.TextChanged

    End Sub
End Class
