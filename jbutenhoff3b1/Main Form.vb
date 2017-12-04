' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   John Butenhoff on 11/22/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        'displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("Do Loop:")
        Integer.TryParse(txtNumber.Text, number)

        count = 1
        product = number * count
        'Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
        'lstMultTable.Items.Add(strOutput)

        'do loop
        Do While (count <= 9)
            lstMultTable.Items.Add(number & " * " & count & " = " & product)
            count += 1
            product = number * count
        Loop


    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        'displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'for loop
        count = 1
        product = number * count
        'Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()

        For count = 1 To 9
            product = number * count
            lstMultTable.Items.Add(number & " * " & count & " = " & product)
        Next count


    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        'lblTable.Text = String.Empty
        'Code for clear listbox
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load ListBox with test data:
        '       repeat for each number 1 to 4
        '           add the number to the ListBox
        '       next index        

        For i As Integer = 1 To 4
            lstPrices.Items.Add(i.ToString("n2"))
        Next i

        ' calculate pretax total:
        '       declare dblPreTaxTotal and initialzie to 0
        '       repeat for each index 0 to lstPrices.Items.Count -1
        '           set ListBox SelectedIndex to index
        '           set strSelectedItem and to the ListBox SelectedItem
        '           convert strSelectedPrice to Double and set dblSelectedPrice
        '           add dblSelectedPrice to dblPreTaxTotal
        '       next index
        Dim dblPreTaxTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTaxRate As Double = 0.05
        Dim dblTax As Double = 0.0
        Dim dblTotal As Double = 0.0

        lstPrices.SelectedIndex = 0

        For i As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = i
            strSelectedItem = Convert.ToString(lstPrices.SelectedItem)
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPreTaxTotal += dblSelectedPrice
        Next i

        '       display dblPreTaxTotal
        '       calculate and display dblTax
        '       calculate and display dblTotal
        '       deselect ListBox items
        'dblPreTaxTotal = dblSelectedPrice

        dblTax = dblTaxRate * dblPreTaxTotal
        dblTotal = dblTax + dblPreTaxTotal
        lblPreTaxTotal.Text = dblPreTaxTotal.ToString("n2")
        lblTax.Text = dblTax.ToString("n2")
        lblTotal.Text = dblTotal.ToString("N2")

        lstPrices.SelectedIndex = -1

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'get strPrice using InputBox
        'convert strPrice to Double: dblPrice
        'repeat as long as price is invalid: outside of range 1 to 9.99
        '   get strPrice using InputBox
        '   convert strPrice to double: dblPrice
        'end repeat
        'add dblPrice to Listbox
        'Calculate and display totals       
        Dim strPrice As String
        Dim dblPrice As Double = 0.0
        Const strPROMPT As String =
            "Enter a number from 1.00 to 9.99"
        strPrice = InputBox(strPROMPT, "", "0.00")
        Double.TryParse(strPrice, dblPrice)

        Do While dblPrice < 1 OrElse dblPrice > 10.0
            strPrice = InputBox(strPROMPT, "", "0.00")
            Double.TryParse(strPrice, dblPrice)
        Loop

        'strPrice = strPROMPT
        'Double.TryParse(strPrice, dblPrice)

        '    strPrice = Convert.ToString(dblPrice)
        lstPrices.Items.Add(dblPrice)

        Dim dblPreTaxTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTaxRate As Double = 0.05
        Dim dblTax As Double = 0.0
        Dim dblTotal As Double = 0.0

        lstPrices.SelectedIndex = 0

        For i As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = i
            strSelectedItem = Convert.ToString(lstPrices.SelectedItem)
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPreTaxTotal += dblSelectedPrice
        Next i

        dblTax = dblTaxRate * dblPreTaxTotal
        dblTotal = dblTax + dblPreTaxTotal
        lblPreTaxTotal.Text = dblPreTaxTotal.ToString("n2")
        lblTax.Text = dblTax.ToString("n2")
        lblTotal.Text = dblTotal.ToString("N2")

        lstPrices.SelectedIndex = -1
    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        'if an item is selected and the user pressed 'Del' or Back'
        '   remove the ListBox item at the selected index
        '   calculate and display totals
        'end if


    End Sub
End Class
