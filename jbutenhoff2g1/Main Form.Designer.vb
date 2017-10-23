<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalcIf = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDiscRates = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpBoxSampRes = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnCalcNestedIf = New System.Windows.Forms.Button()
        Me.btnCalcIfElseIf = New System.Windows.Forms.Button()
        Me.btnCalcSelect = New System.Windows.Forms.Button()
        Me.grpDiscRates.SuspendLayout()
        Me.grpBoxSampRes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(96, 248)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(81, 31)
        Me.txtPrice.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(199, 248)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(81, 31)
        Me.txtQuantity.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(333, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discount:"
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(336, 248)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(81, 29)
        Me.lblDiscount.TabIndex = 7
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(445, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.Location = New System.Drawing.Point(450, 248)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(81, 29)
        Me.lblTotalDue.TabIndex = 9
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcIf
        '
        Me.btnCalcIf.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcIf.Location = New System.Drawing.Point(5, 299)
        Me.btnCalcIf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcIf.Name = "btnCalcIf"
        Me.btnCalcIf.Size = New System.Drawing.Size(144, 32)
        Me.btnCalcIf.TabIndex = 2
        Me.btnCalcIf.Text = "Calc: If"
        Me.btnCalcIf.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(264, 339)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpDiscRates
        '
        Me.grpDiscRates.Controls.Add(Me.Label5)
        Me.grpDiscRates.Controls.Add(Me.Label6)
        Me.grpDiscRates.Controls.Add(Me.Label7)
        Me.grpDiscRates.Controls.Add(Me.Label8)
        Me.grpDiscRates.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDiscRates.Location = New System.Drawing.Point(89, 22)
        Me.grpDiscRates.Name = "grpDiscRates"
        Me.grpDiscRates.Size = New System.Drawing.Size(191, 152)
        Me.grpDiscRates.TabIndex = 10
        Me.grpDiscRates.TabStop = False
        Me.grpDiscRates.Text = "Discount Rates:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "1-10:  0%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "11-15: 2%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "16-20: 2.5%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "> 20:   3%"
        '
        'grpBoxSampRes
        '
        Me.grpBoxSampRes.Controls.Add(Me.Label20)
        Me.grpBoxSampRes.Controls.Add(Me.Label19)
        Me.grpBoxSampRes.Controls.Add(Me.Label18)
        Me.grpBoxSampRes.Controls.Add(Me.Label17)
        Me.grpBoxSampRes.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxSampRes.Location = New System.Drawing.Point(336, 22)
        Me.grpBoxSampRes.Name = "grpBoxSampRes"
        Me.grpBoxSampRes.Size = New System.Drawing.Size(211, 152)
        Me.grpBoxSampRes.TabIndex = 11
        Me.grpBoxSampRes.TabStop = False
        Me.grpBoxSampRes.Text = "Sample Results:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(139, 25)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "$10, Qty 10:  $0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(139, 25)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "$10, Qty 15:  $3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 25)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "$10, Qty 20:  $5"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(139, 25)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "$10, Qty 30:  $9"
        '
        'btnCalcNestedIf
        '
        Me.btnCalcNestedIf.Location = New System.Drawing.Point(155, 299)
        Me.btnCalcNestedIf.Name = "btnCalcNestedIf"
        Me.btnCalcNestedIf.Size = New System.Drawing.Size(144, 32)
        Me.btnCalcNestedIf.TabIndex = 3
        Me.btnCalcNestedIf.Text = "Calc: Nested If"
        Me.btnCalcNestedIf.UseVisualStyleBackColor = True
        '
        'btnCalcIfElseIf
        '
        Me.btnCalcIfElseIf.Location = New System.Drawing.Point(305, 299)
        Me.btnCalcIfElseIf.Name = "btnCalcIfElseIf"
        Me.btnCalcIfElseIf.Size = New System.Drawing.Size(144, 32)
        Me.btnCalcIfElseIf.TabIndex = 4
        Me.btnCalcIfElseIf.Text = "Calc: If Esle-If"
        Me.btnCalcIfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalcSelect
        '
        Me.btnCalcSelect.Location = New System.Drawing.Point(455, 299)
        Me.btnCalcSelect.Name = "btnCalcSelect"
        Me.btnCalcSelect.Size = New System.Drawing.Size(144, 32)
        Me.btnCalcSelect.TabIndex = 5
        Me.btnCalcSelect.Text = "Calc: Select"
        Me.btnCalcSelect.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 384)
        Me.Controls.Add(Me.btnCalcSelect)
        Me.Controls.Add(Me.btnCalcIfElseIf)
        Me.Controls.Add(Me.btnCalcNestedIf)
        Me.Controls.Add(Me.grpBoxSampRes)
        Me.Controls.Add(Me.grpDiscRates)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcIf)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jbutenhoff2g1 Jetters"
        Me.grpDiscRates.ResumeLayout(False)
        Me.grpDiscRates.PerformLayout()
        Me.grpBoxSampRes.ResumeLayout(False)
        Me.grpBoxSampRes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents btnCalcIf As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpDiscRates As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grpBoxSampRes As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnCalcNestedIf As Button
    Friend WithEvents btnCalcIfElseIf As Button
    Friend WithEvents btnCalcSelect As Button
End Class
