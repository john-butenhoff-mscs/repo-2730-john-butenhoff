﻿' Name:             Bakery Project
' Purpose:          Calculates the total number of
'                   items sold and the total sales
' Programmer:       John Butenhoff on 8/31/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        ' send the focus to the doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        ' lblTotalItems.Text = txtDonuts.Text + txtMuffins.Text
        ' Text = Val(txtDonuts.Text + txtMuffins.Text)
        lblTotalItems.Text = Format(Val(txtDonuts.Text) + Val(txtMuffins.Text), "0")
        lblTotalSales.Text = Format(Val(lblTotalItems.Text) * 0.5, "currency")
    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged

    End Sub

    Private Sub txtDonuts_TextChanged(sender As Object, e As EventArgs) Handles txtDonuts.TextChanged

    End Sub

    Private Sub txtMuffins_TextChanged(sender As Object, e As EventArgs) Handles txtMuffins.TextChanged

    End Sub

    Private Sub lblTotalItems_Click(sender As Object, e As EventArgs) Handles lblTotalItems.Click

    End Sub
End Class
