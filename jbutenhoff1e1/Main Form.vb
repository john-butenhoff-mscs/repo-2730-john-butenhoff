' Name:         Richardson County Property Tax Project
' Purpose:      Calculates property tax
' Programmer:   John Butenhoff on 9/6/2017
Public Class frmMain
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate property tax

        txtTax.Text = Val(txtAssessed.Text * 0.015)
        txtTax.Text = Format(txtTax.Text, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare screen for the next evaluation

        txtAssessed.Text = String.Empty
        txtTax.Text = String.Empty
        ' send the focus to the Assessed box
        txtAssessed.Focus()


    End Sub
End Class
