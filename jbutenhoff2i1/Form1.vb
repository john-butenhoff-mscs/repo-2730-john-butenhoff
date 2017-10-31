'Name:          String Manipulation
'Purpose:       test various string manipulation method's
'Programmer:    John Butenhoff

Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04.Text
        Dim strColor As String = txt04.Text
        strItem = "YMBlueX"
        strColor = strItem.Substring(2, 4)
        lbl04.Text = strColor

        '05a: Length
        Dim strMSG As String = txt05a.Text
        Dim intDigits As Integer
        strMSG = "Disk Full"
        intDigits = strMSG.Length

        lbl05a.Text = intDigits.ToString

        '05b: Trim
        Dim strCity As String = txt05b.Text

        strCity = txt05b.Text.Trim
        lbl05b.Text = strCity

        '05c: Remove/Insert
        Dim strWord2 As String = txt05c.Text

        strWord2 = strWord2.Remove(1, 1)
        strWord2 = strWord2.Insert(1, "rit")

        lbl05c.Text = strWord2

        '05d: Insert
        Dim strWord3 As String = txt05d.Text

        strWord3 = strWord3.Insert(0, "Mon")

        lbl05d.Text = strWord3

        '05e: Pad
        Dim dblPay As Double
        Dim strPay As String = txt05e.Text
        dblPay = 764.44
        strPay = dblPay.ToString.PadLeft(10, "*"c)

        lbl05e.Text = strPay

        '06: Remove
        Dim strAmount As String = txt06.Text

        strAmount = "3,123,560"
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)

        lbl06.Text = strAmount

        '07: Contains
        Dim strAddress As String
        Dim blnIsContained As Boolean

        'strAddress = "308 JEfFeRsOn StReEt"
        strAddress = txt07.Text
        blnIsContained = strAddress.ToUpper.Contains("JEFFERSON STREET")

        If blnIsContained = True Then
            lbl07.Text = "Jeff St. Found"
        Else
            lbl07.Text = "Jeff St. Not Found"
        End If

        '12: Len/Remove
        Dim strTax_Rate As String = txt12.Text
        Dim intNumChars As Integer = strTax_Rate.Length

        If strTax_Rate.Substring(intNumChars - 1) = "%" Then
            strTax_Rate = strTax_Rate.Remove(intNumChars - 2)
        End If

        Dim dblTaxRate As Double = 0.0
        Double.TryParse(strTax_Rate, dblTaxRate)
        Dim dblTax As Double = 1000 * dblTaxRate * 0.01

        lbl12.Text = dblTax.ToString()

        '13: Like
        Dim dblShip_605 As Double = 25
        Dim dblShip_606 As Double = 30
        Dim strZip As String = txt13.Text
        Dim dblShipCost As Double

        If strZip Like "605*" Then
            dblShipCost = dblShip_605
        ElseIf strZip Like "606*" Then
            dblShipCost = dblShip_606
        Else
            MessageBox.Show("Invalid Zip",
                            "Zip", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)

        End If

        lbl13.Text = dblShipCost.ToString
















    End Sub
End Class
