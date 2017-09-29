' Name:         Retirement Project
' Purpose:      Calculates projected sales
' Programmer:   John Butenhoff on 9/28/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmRetirement
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate Retirement Contribution    
        Const decEmployeeRate As Decimal = 0.05D
        Const decEmployerRate As Decimal = 0.07D
        Dim decGross As Decimal
        Dim decEmployeeCont As Decimal
        Dim decEmployerCont As Decimal
        Dim decTotalCont As Decimal
        Decimal.TryParse(txtGross.Text, decGross)
        Decimal.TryParse(txtEmployeeRate.Text, decEmployeeRate)
        Decimal.TryParse(txtEmployerRate.Text, decEmployerRate)


        decEmployeeCont = decGross * 52 * decEmployeeRate
        lblEmployeeCont.Text = Convert.ToString(decEmployeeCont)

        decEmployerCont = decGross * decEmployerRate
        lblEmployerCont.Text = Convert.ToString(decEmployerCont)

        decTotalCont = decEmployerCont + decEmployeeCont
        lblTotalCont.Text = Convert.ToString(decTotalCont)








    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare for next Calculation
        lblEmployeeCont.Text = String.Empty
        lblEmployerCont.Text = String.Empty
        lblTotalCont.Text = String.Empty

        txtGross.Focus()

    End Sub
End Class