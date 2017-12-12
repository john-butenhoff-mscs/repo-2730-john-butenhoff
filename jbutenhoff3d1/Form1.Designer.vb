<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplayDays = New System.Windows.Forms.Button()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.btnForEachNext = New System.Windows.Forms.Button()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.lblLessThanAvg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAvgSold = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnWholesale = New System.Windows.Forms.Button()
        Me.lstRetail = New System.Windows.Forms.ListBox()
        Me.btnRetail = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstWholesale = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnDisplayDays)
        Me.GroupBox1.Controls.Add(Me.txtMonth)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Days in Month"
        '
        'lblDays
        '
        Me.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDays.Location = New System.Drawing.Point(145, 45)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(49, 23)
        Me.lblDays.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of days:"
        '
        'btnDisplayDays
        '
        Me.btnDisplayDays.Location = New System.Drawing.Point(64, 89)
        Me.btnDisplayDays.Name = "btnDisplayDays"
        Me.btnDisplayDays.Size = New System.Drawing.Size(144, 31)
        Me.btnDisplayDays.TabIndex = 4
        Me.btnDisplayDays.Text = "&Display Days"
        Me.btnDisplayDays.UseVisualStyleBackColor = True
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(145, 13)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(49, 22)
        Me.txtMonth.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Month number: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDoLoop)
        Me.GroupBox2.Controls.Add(Me.btnForEachNext)
        Me.GroupBox2.Controls.Add(Me.btnForNext)
        Me.GroupBox2.Controls.Add(Me.lblLessThanAvg)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblAvgSold)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(239, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 142)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p522 #9 Avg, min sold"
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(310, 97)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(120, 29)
        Me.btnDoLoop.TabIndex = 9
        Me.btnDoLoop.Text = "Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'btnForEachNext
        '
        Me.btnForEachNext.Location = New System.Drawing.Point(310, 62)
        Me.btnForEachNext.Name = "btnForEachNext"
        Me.btnForEachNext.Size = New System.Drawing.Size(120, 29)
        Me.btnForEachNext.TabIndex = 8
        Me.btnForEachNext.Text = "For Each...Next"
        Me.btnForEachNext.UseVisualStyleBackColor = True
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(310, 27)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(120, 29)
        Me.btnForNext.TabIndex = 7
        Me.btnForNext.Text = "For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'lblLessThanAvg
        '
        Me.lblLessThanAvg.BackColor = System.Drawing.SystemColors.Info
        Me.lblLessThanAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLessThanAvg.Location = New System.Drawing.Point(146, 104)
        Me.lblLessThanAvg.Name = "lblLessThanAvg"
        Me.lblLessThanAvg.Size = New System.Drawing.Size(100, 23)
        Me.lblLessThanAvg.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Values: 250, 225, 193, 260"
        '
        'lblAvgSold
        '
        Me.lblAvgSold.BackColor = System.Drawing.SystemColors.Info
        Me.lblAvgSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgSold.Location = New System.Drawing.Point(146, 68)
        Me.lblAvgSold.Name = "lblAvgSold"
        Me.lblAvgSold.Size = New System.Drawing.Size(100, 23)
        Me.lblAvgSold.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Avg Sold:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "< avg:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnWholesale)
        Me.GroupBox3.Controls.Add(Me.lstRetail)
        Me.GroupBox3.Controls.Add(Me.btnRetail)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lstWholesale)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 253)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "p523 #13 Wholesale, Retail Prices"
        '
        'btnWholesale
        '
        Me.btnWholesale.Location = New System.Drawing.Point(244, 159)
        Me.btnWholesale.Name = "btnWholesale"
        Me.btnWholesale.Size = New System.Drawing.Size(110, 74)
        Me.btnWholesale.TabIndex = 8
        Me.btnWholesale.Text = "Return Array to Wholesale Prices"
        Me.btnWholesale.UseVisualStyleBackColor = True
        '
        'lstRetail
        '
        Me.lstRetail.FormattingEnabled = True
        Me.lstRetail.ItemHeight = 16
        Me.lstRetail.Location = New System.Drawing.Point(145, 53)
        Me.lstRetail.Name = "lstRetail"
        Me.lstRetail.Size = New System.Drawing.Size(76, 180)
        Me.lstRetail.TabIndex = 6
        '
        'btnRetail
        '
        Me.btnRetail.Location = New System.Drawing.Point(244, 53)
        Me.btnRetail.Name = "btnRetail"
        Me.btnRetail.Size = New System.Drawing.Size(110, 74)
        Me.btnRetail.TabIndex = 7
        Me.btnRetail.Text = "Update Array to Retail Prices"
        Me.btnRetail.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Wholesale:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Retail:"
        '
        'lstWholesale
        '
        Me.lstWholesale.FormattingEnabled = True
        Me.lstWholesale.ItemHeight = 16
        Me.lstWholesale.Location = New System.Drawing.Point(44, 53)
        Me.lstWholesale.Name = "lstWholesale"
        Me.lstWholesale.Size = New System.Drawing.Size(76, 180)
        Me.lstWholesale.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 439)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDays As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDisplayDays As Button
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAvgSold As Label
    Friend WithEvents lblLessThanAvg As Label
    Friend WithEvents btnDoLoop As Button
    Friend WithEvents btnForEachNext As Button
    Friend WithEvents btnForNext As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnWholesale As Button
    Friend WithEvents lstRetail As ListBox
    Friend WithEvents btnRetail As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lstWholesale As ListBox
End Class
