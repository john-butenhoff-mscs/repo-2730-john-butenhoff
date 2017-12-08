' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   John Butenhoff on 12/07/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged,
        radSubInches.CheckedChanged, radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged
        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        'Get the user's input
        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        'display the result
        If radSubCentimeters.Checked Then
            'Book says to use "Call" here, but most programmers don't
            CalcCentimetersSub(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurement)
        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurement)
        End If

        'display the result
        lblResult.Text = dblResult.ToString("N2")
        txtMeasurement.SelectAll()
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        'Inches to centimeters using Sub procedure
        dblRes = dblMeas * 2.54
        lblResult.Text = dblRes.ToString("N2")
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        'Centimeters to Inches using Sub Procedure
        dblRes = dblMeas / 2.54
        lblResult.Text = dblRes.ToString("N2")
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double
        'Inches to Centimeters using Function Procedure
        Return dblMeas * 2.54
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double) As Double
        'Centimeters to Inches using Function Procedure
        Return dblMeas / 2.54
    End Function

    '-----------------------------------------------------------
    'Add planets to cboPlanets
    'Set selected item to Earth
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"
    End Sub

    'Allow only numbers and the Backspace
    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    'Select all text in txtEarthWeight
    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        txtEarthWeight.SelectAll()
    End Sub

    'Set dblGravity according to selected text in cboPlanets
    'Calculate weight
    Private Function CalcWeightFunc(ByVal dblWeight As Double) As Double
        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        Return dblWeight * dblGravity
    End Function

    'Set dblGravity according To selected text In cboPlanets
    'Calculate weight
    Private Sub CalcWeightSub(ByVal dblWeight As Double, ByRef dblWeightOnPlanet As Double)

        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select

        dblWeightOnPlanet = dblWeight * dblGravity
    End Sub

    'Parse value in txtEarthWeight   
    'If user selected "sub" radio button
    '   Use Sub to calculate weight
    'ElseIf user selected "func" radio button
    Private Sub WeightInputChanged(sender As Object, e As EventArgs) Handles txtEarthWeight.TextChanged, cboPlanets.TextChanged, radSub.CheckedChanged
        Dim dblGravity As Double
        Dim dblWeight As Double
        Double.TryParse(txtEarthWeight.Text, dblWeight)

        If radSub.Checked Then
            CalcWeightSub(dblWeight, dblGravity)
        ElseIf radFunc.Checked Then

        End If

        lblWeight.Text = dblGravity.ToString("n2")
    End Sub
End Class
