﻿' Name:         Photo Project
' Purpose:      Displays the gross pay, FWT, FICA, State Income Tax, and Net Pay
' Programmer:   John Butenhoff

Option Strict On

Public Class frmMain
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblHours.Click

    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate Net Pay

        lblGrossC.Text = Format(Val(txtRate.Text) * Val(txtHours.Text), "fixed")
        lblFWTC.Text = Format(Val(lblGrossC.Text) * 0.2, "fixed")
        lblFICAC.Text = Format(Val(lblGrossC.Text) * 0.08, "fixed")
        lblStateC.Text = Format(Val(lblGrossC.Text) * 0.03, "fixed")
        lblNetC.Text = Format(Val(lblGrossC.Text) - Val(lblFWTC.Text) - Val(lblFICAC.Text) - Val(lblStateC.Text), "fixed")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare for next Employee

        txtName.Text = String.Empty
        txtRate.Text = String.Empty
        txtHours.Text = String.Empty
        lblGrossC.Text = String.Empty
        lblFWTC.Text = String.Empty
        lblFICAC.Text = String.Empty
        lblStateC.Text = String.Empty
        lblNetC.Text = String.Empty

        'Send to focus
        txtName.Focus()
    End Sub
End Class
