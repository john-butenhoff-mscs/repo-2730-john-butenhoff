' Name:         Pizza Project
' Purpose:      A game that allows the user to guess a
'               word letter-by-letter
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private strWord As String
    Private intIncorrect As Integer

    Private Sub AssignImage()
        ' assign appropriate image

        Select Case intIncorrect
            Case 1
                picPizzaStatus.Image = pic6Slices.Image
            Case 2
                picPizzaStatus.Image = pic5Slices.Image
            Case 3
                picPizzaStatus.Image = pic4Slices.Image
            Case 4
                picPizzaStatus.Image = pic3Slices.Image
            Case 5
                picPizzaStatus.Image = pic2Slices.Image
            Case 6
                picPizzaStatus.Image = pic1Slice.Image
            Case Else
                picPizzaStatus.Image = picTray.Image
        End Select
    End Sub

    Private Sub DetermineGameOver(ByVal blnADashWasReplaced As Boolean)
        ' determine whether the game is over and
        ' take the appropriate action

        If blnADashWasReplaced Then
            ' if the word does not contain any dashes, the game
            ' is over because player 2 guessed the word
            If lblWord.Text.Contains("-") = False Then
                MessageBox.Show("Great guessing!", "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                btnCheck.Enabled = False
            End If
        Else
            ' if 7 incorrect guesses, the game is over
            If intIncorrect = 7 Then
                MessageBox.Show("Sorry, the word is " &
                                strWord & ".", "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                btnCheck.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' check if the letter appears in the word

        Dim strLetter As String
        Dim blnDashReplaced As Boolean

        strLetter = txtLetter.Text

        ' look at each letter in the word
        For intIndex As Integer = 0 To 5
            If strWord.Substring(intIndex, 1) = strLetter Then
                ' if the letter appears in the word, replace
                ' the corresponding dash with the letter
                lblWord.Text =
                    lblWord.Text.Remove(intIndex, 1)
                lblWord.Text =
                    lblWord.Text.Insert(intIndex, strLetter)
                blnDashReplaced = True
            End If
        Next intIndex

        If blnDashReplaced Then
            Call DetermineGameOver(blnDashReplaced)
        Else  ' no dash was replaced
            lblIncorrect.Text =
                lblIncorrect.Text & " " & strLetter
            intIncorrect += 1
            Call AssignImage()
            Call DetermineGameOver(blnDashReplaced)
        End If

        ' clear text box and set focus
        txtLetter.Text = String.Empty
        txtLetter.Focus()
    End Sub

    Private Sub txtLetter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetter.KeyPress
        ' allows only letters and the Backspace key


    End Sub
End Class
