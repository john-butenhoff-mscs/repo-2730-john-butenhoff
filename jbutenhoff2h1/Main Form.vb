' Name:         Marshall Solution 
' Purpose:      Calculate appropriate sales commission
' Programmer:   John Butenhoff on 10/23/2017
Public Class frmMain
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
        (e.KeyChar <> ControlChars.Back) AndAlso
        (e.KeyChar <> ".") Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkOver10.CheckedChanged, chkTravel.CheckedChanged
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalcIf_Click(sender As Object, e As EventArgs) Handles btnCalcIf.Click

        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOk As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        If boolSalesOk AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOk AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOk AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOk AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalDue = dblCommissionOnly + dblAdditional

        If boolSalesOk Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("C2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalcNestedIf_Click(sender As Object, e As EventArgs) Handles btnCalcNestedIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOk As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        If boolSalesOk AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        Else
            If dblSales < 6000.0 Then
                dblCommissionOnly = dblSales * 0.1
            Else
                If dblSales < 30000.0 Then
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Else
                    dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
                End If
            End If
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalDue = dblCommissionOnly + dblAdditional


        lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
        lblAdditional.Text = dblAdditional.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")


        txtSales.Focus()
    End Sub

    Private Sub btnCalcIfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalcIfElseIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOk As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        If dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000.0) * 0.14
        ElseIf dblSales >= 6000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf dblSales >= 1.0 Then
            dblCommissionOnly = dblSales * 0.1
        Else
            dblCommissionOnly = 0.0
        End If


        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalDue = dblCommissionOnly + dblAdditional

        If boolSalesOk Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("C2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalcSelect_Click(sender As Object, e As EventArgs) Handles btnCalcSelect.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOk As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOk Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        Select Case dblSales
            Case 0 To 0.99
                dblCommissionOnly = 0
            Case 1 To 5999.99
                dblCommissionOnly = dblSales * 0.1
            Case 6000.0 To 29999.99
                dblCommissionOnly = 120 + (dblSales - 6000.0) * 0.13
            Case Else
                dblCommissionOnly = 3120 + (dblSales - 30000.0) * 0.14

        End Select



        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalDue = dblCommissionOnly + dblAdditional

        If boolSalesOk Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("C2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        End If

        txtSales.Focus()
    End Sub
End Class
