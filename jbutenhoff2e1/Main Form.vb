' Purpose:      Calculate shipping.
' Programmer:   John Butenhoff on 10/16/2017

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalc2.Click
        'declare variables
        Const decSHIPPING_FEE As Decimal = 9
        Const decNO_SHIPPING_FEE As Decimal = 0
        Dim decOrders As Decimal
        Dim decCC As Decimal
        Dim decShipFee As Decimal
        Dim strCC As String


        strCC = txtCC.Text.ToUpper
        Decimal.TryParse(txtOrders.Text, decOrders)
        Decimal.TryParse(txtCC.Text, decCC)
        Decimal.TryParse(lblShipFee.Text, decShipFee)

        'Decide if shipping applies
        If strCC.ToUpper = "Y" AndAlso decOrders >= 100 Then
            decShipFee = decSHIPPING_FEE
        Else
            decShipFee = decNO_SHIPPING_FEE
        End If

        lblShipFee.Text = decShipFee.ToString("c2")

    End Sub

    Private Sub btnCalcOr_Click_1(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        'declare variables
        Const decSHIPPING_FEE As Decimal = 9
        Const decNO_SHIPPING_FEE As Decimal = 0
        Dim decOrders As Decimal
        Dim decCC As Decimal
        Dim decShipFee As Decimal
        Dim strCC As String


        strCC = txtCC.Text.ToUpper
        Decimal.TryParse(txtOrders.Text, decOrders)
        Decimal.TryParse(txtCC.Text, decCC)
        Decimal.TryParse(lblShipFee.Text, decShipFee)

        'Decide if shipping applies
        If strCC.ToUpper <> "Y" OrElse decOrders < 100 Then
            decShipFee = decNO_SHIPPING_FEE
        Else
            decShipFee = decSHIPPING_FEE
        End If

        lblShipFee.Text = decShipFee.ToString("c2")
    End Sub

    Private Sub btnCalcEqual_Click(sender As Object, e As EventArgs) Handles btnCalcEqual.Click

        Dim strID As String
        Dim decSales As Decimal
        Dim decCommission As Decimal

        Decimal.TryParse(txtSales.Text, decSales)
        Decimal.TryParse(lblCommission.Text, decCommission)
        strID = txtID.Text.ToUpper

        If strID = "A1" OrElse strID = "B2" OrElse strID = "C3" AndAlso decSales >= 25000 Then
            decCommission = decSales * 0.15
        Else
            decCommission = decSales * 0.12
        End If

        lblCommission.Text = decCommission.ToString("c2")
    End Sub

    Private Sub btnCalcNotEqual_Click(sender As Object, e As EventArgs) Handles btnCalcNotEqual.Click
        Dim strID As String
        Dim decSales As Decimal
        Dim decCommission As Decimal

        Decimal.TryParse(txtSales.Text, decSales)
        Decimal.TryParse(lblCommission.Text, decCommission)
        strID = txtID.Text.ToUpper

        If strID <> "A1" OrElse strID = "B2" OrElse strID = "C3" AndAlso decSales < 25000 Then
            decCommission = decSales * 0.12
        Else
            decCommission = decSales * 0.15
        End If

        lblCommission.Text = decCommission.ToString("c2")
    End Sub
End Class
