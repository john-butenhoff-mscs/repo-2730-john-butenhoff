' Name:             Ch4 Lesson B, If statements, message boxes
' Purpose:          Currency, Tea, Electric, Quotient
' Programmer:       John Butenhoff on 10/8/2017

Public Class frmMain
    Private Sub btnConvertEQ_Click(sender As Object, e As EventArgs) Handles btnConvertEQ.Click
        ' convert American dollars to the Euro, the
        ' British pound, and the South African rand

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        Double.TryParse(txtDollar.Text, dblDollar)
        Double.TryParse(lblEuro.Text, dblEuro)
        Double.TryParse(lblPound.Text, dblPound)
        Double.TryParse(lblRand.Text, dblRand)

        If txtDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        Else
            dblEuro = dblEURO_RATE * dblDollar
            dblPound = dblPOUND_RATE * dblDollar
            dblRand = dblRAND_RATE * dblDollar

            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")

        End If


    End Sub

    Private Sub btnConvertNE_Click(sender As Object, e As EventArgs) Handles btnConvertNE.Click

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        Double.TryParse(txtDollar.Text, dblDollar)
        Double.TryParse(lblEuro.Text, dblEuro)
        Double.TryParse(lblPound.Text, dblPound)
        Double.TryParse(lblRand.Text, dblRand)

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtDollar.Text <> String.Empty Then
            dblEuro = dblEURO_RATE * dblDollar
            dblPound = dblPOUND_RATE * dblDollar
            dblRand = dblRAND_RATE * dblDollar

            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")

        Else
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click
        ' Calculate Price per pound of tea
        Dim dblPounds As Double
        Dim dblPrice As Double
        Dim dblTotal As Double

        Double.TryParse(txtPounds.Text, dblPounds)
        Double.TryParse(txtPrice.Text, dblPrice)
        Double.TryParse(lblTotal.Text, dblTotal)

        lblTotal.Text = String.Empty

        ' If 20lbs, or more charge for shipping.
        If txtPounds.Text < 20 Then
            ' Price w/out shipping
            dblTotal = dblPounds * dblPrice

            lblTotal.Text = dblTotal.ToString("c2")

        Else
            ' Price with shipping
            MessageBox.Show("Charge for shipping?", "Price/lb", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation)
            dblTotal = dblPounds * dblPrice + 15

            lblTotal.Text = dblTotal.ToString("c2")
        End If

    End Sub

    Private Sub btnCalc2_Click(sender As Object, e As EventArgs) Handles btnCalc2.Click
        ' Calculate Bill

        Dim decPrevious As Decimal
        Dim decCurrent As Decimal
        Dim decBill As Decimal

        Decimal.TryParse(txtPrevious.Text, decPrevious)
        Decimal.TryParse(txtCurrent.Text, decCurrent)
        Decimal.TryParse(lblBill.Text, decBill)

        lblBill.Text = String.Empty

        If decPrevious < decCurrent Then
            decBill = decPrevious * 0.13
            decBill = decCurrent * 0.13

            lblBill.Text = decBill.ToString("c2")

        Else MessageBox.Show("The current reading must be greater than or equal to the previous reading.", "Units",
                                 MessageBoxButtons.OK,
                             MessageBoxIcon.Information)
            decBill = decPrevious * 0.13
            decBill = decCurrent * 0.13

            lblBill.Text = decBill.ToString("c2")

        End If

    End Sub

    Private Sub btnCalc3_Click(sender As Object, e As EventArgs) Handles btnCalc3.Click
        ' Division Calculator
        Dim dblFirst As Double
        Dim dblSec As Double
        Dim dblQuo As Double

        Double.TryParse(txtFirst.Text, dblFirst)
        Double.TryParse(txtSec.Text, dblSec)
        Double.TryParse(lblQuo.Text, dblQuo)

        lblQuo.Text = String.Empty


        ' Swap if necessary
        If dblFirst < dblSec Then
            Dim dblTemp As Double
            dblTemp = dblFirst
            dblFirst = dblSec
            dblSec = dblTemp

            dblQuo = dblFirst / dblSec
        Else
            dblQuo = dblFirst / dblSec


        End If

        lblQuo.Text = dblQuo.ToString("n2")

        If dblFirst = 0 Or dblSec = 0 Then
            MessageBox.Show("Cannot divide by 0", "Quotient",
                                 MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
