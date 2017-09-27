' COMC2730 Quiz 1 Part 2 Review
' John Butenhoff

Option Strict On


Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' txtName.Text = "MsgA"
        Label6.Text = "MsgB"
        ' lblNet.Text = Convert.ToString(Convert.ToInt32(txtHours.Text) + 10)
        ' lblNet.Text = Convert.ToString(convert.ToInt32(txtHours.Text) + PictureBox1.Top)
        ' PictureBox1.Top = 100
        ' PictureBox1.Top = PictureBox1.Top + Convert.ToInt32(txtHours.Text)
        ' txtName.Text = "MsgC" + "MsgD"
        ' txtName.Text = "MsgC" & "MsgD"
        ' txtName.Text = "Gross pay: "_
        '       + Convert.ToString(Convert.ToInt32(txtHours.Text) * Convert.ToDouble(txtPayRate.Text))
        ' lblNet.Text = Format(1000, "N2")
        ' lblNet.Text = 1000.ToString("N2")
        ' txtName.Text = "MsgD: " + (Convert.ToDouble(txtPayRate.Text) * 100).ToString("N2")
    End Sub
End Class
