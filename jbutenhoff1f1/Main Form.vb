' Name:         Cranston Berries Project
' Purpose:      Calculates projected sales
' Programmer:   John Butenhoff on 9/10/2017

Option Strict On

Public Class frmMain
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblProjectedIncrease_Click(sender As Object, e As EventArgs) Handles lblProjectedIncrease.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblProjStraw.Click

    End Sub

    Private Sub lblCurrentSales_Click(sender As Object, e As EventArgs) Handles lblCurrentSales.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblRasberries_Click(sender As Object, e As EventArgs) Handles lblRasp.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate Projected Sales Increase

        lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        lblProjRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare for next caluculation
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRasp.Text = String.Empty
        txtProjIncrease.Text = String.Empty

        ' Send to Focus
        txtProjIncrease.Focus()


    End Sub
End Class
