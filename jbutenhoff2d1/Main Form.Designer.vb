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
        Me.txtDollar = New System.Windows.Forms.TextBox()
        Me.btnConvertNE = New System.Windows.Forms.Button()
        Me.btnConvertEQ = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnCalcTea = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnCalc2 = New System.Windows.Forms.Button()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSecond = New System.Windows.Forms.Label()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.lblQuo = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalc3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDollar
        '
        Me.txtDollar.Location = New System.Drawing.Point(48, 62)
        Me.txtDollar.Name = "txtDollar"
        Me.txtDollar.Size = New System.Drawing.Size(100, 27)
        Me.txtDollar.TabIndex = 0
        '
        'btnConvertNE
        '
        Me.btnConvertNE.Location = New System.Drawing.Point(167, 65)
        Me.btnConvertNE.Name = "btnConvertNE"
        Me.btnConvertNE.Size = New System.Drawing.Size(102, 29)
        Me.btnConvertNE.TabIndex = 2
        Me.btnConvertNE.Text = "Convert <>"
        Me.btnConvertNE.UseVisualStyleBackColor = True
        '
        'btnConvertEQ
        '
        Me.btnConvertEQ.Location = New System.Drawing.Point(167, 26)
        Me.btnConvertEQ.Name = "btnConvertEQ"
        Me.btnConvertEQ.Size = New System.Drawing.Size(102, 29)
        Me.btnConvertEQ.TabIndex = 1
        Me.btnConvertEQ.Text = "Convert ="
        Me.btnConvertEQ.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "American &dollar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Euro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "British &pound:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "South African &rand:"
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(295, 62)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(100, 23)
        Me.lblEuro.TabIndex = 7
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(421, 62)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(100, 23)
        Me.lblPound.TabIndex = 8
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(561, 62)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(100, 23)
        Me.lblRand.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.txtDollar)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.btnConvertNE)
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Controls.Add(Me.btnConvertEQ)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 112)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Currency Converter"
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(48, 46)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(100, 27)
        Me.txtPounds.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(167, 46)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 27)
        Me.txtPrice.TabIndex = 1
        '
        'btnCalcTea
        '
        Me.btnCalcTea.Location = New System.Drawing.Point(339, 40)
        Me.btnCalcTea.Name = "btnCalcTea"
        Me.btnCalcTea.Size = New System.Drawing.Size(92, 38)
        Me.btnCalcTea.TabIndex = 2
        Me.btnCalcTea.Text = "Calculate"
        Me.btnCalcTea.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(499, 46)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(499, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 27)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total due:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(163, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Price/lb:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Pounds:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCalcTea)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtPounds)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 110)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tea time"
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(48, 46)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(100, 27)
        Me.txtPrevious.TabIndex = 0
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(167, 46)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 27)
        Me.txtCurrent.TabIndex = 1
        '
        'btnCalc2
        '
        Me.btnCalc2.Location = New System.Drawing.Point(339, 40)
        Me.btnCalc2.Name = "btnCalc2"
        Me.btnCalc2.Size = New System.Drawing.Size(92, 38)
        Me.btnCalc2.TabIndex = 2
        Me.btnCalc2.Text = "Calculate"
        Me.btnCalc2.UseVisualStyleBackColor = True
        '
        'lblBill
        '
        Me.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBill.Location = New System.Drawing.Point(495, 50)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(100, 23)
        Me.lblBill.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(499, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Monthly bill:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Previous:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(163, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Current:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCalc2)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtPrevious)
        Me.GroupBox3.Controls.Add(Me.txtCurrent)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblBill)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(638, 104)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tri County Electric w/validation"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSecond)
        Me.GroupBox4.Controls.Add(Me.txtSec)
        Me.GroupBox4.Controls.Add(Me.lblQuo)
        Me.GroupBox4.Controls.Add(Me.txtFirst)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.btnCalc3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 356)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(638, 100)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Division Calculator"
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(163, 18)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(100, 23)
        Me.txtSecond.TabIndex = 34
        Me.txtSecond.Text = "Second#:"
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(167, 49)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(100, 27)
        Me.txtSec.TabIndex = 1
        '
        'lblQuo
        '
        Me.lblQuo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuo.Location = New System.Drawing.Point(499, 51)
        Me.lblQuo.Name = "lblQuo"
        Me.lblQuo.Size = New System.Drawing.Size(100, 23)
        Me.lblQuo.TabIndex = 33
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(48, 49)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 27)
        Me.txtFirst.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "First#:"
        '
        'btnCalc3
        '
        Me.btnCalc3.Location = New System.Drawing.Point(339, 43)
        Me.btnCalc3.Name = "btnCalc3"
        Me.btnCalc3.Size = New System.Drawing.Size(92, 38)
        Me.btnCalc3.TabIndex = 2
        Me.btnCalc3.Text = "Calculate"
        Me.btnCalc3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(495, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Quotient:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(253, 462)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(199, 45)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 535)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDollar As TextBox
    Friend WithEvents btnConvertNE As Button
    Friend WithEvents btnConvertEQ As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblRand As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnCalcTea As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents btnCalc2 As Button
    Friend WithEvents lblBill As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtSecond As Label
    Friend WithEvents txtSec As TextBox
    Friend WithEvents lblQuo As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalc3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
End Class
