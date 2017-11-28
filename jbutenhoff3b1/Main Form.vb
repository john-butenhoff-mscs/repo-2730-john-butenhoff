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
        Do While (count <= 10)
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

        For count = 1 To 10 Step 1
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

    End Sub
End Class
