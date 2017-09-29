<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblEmployeeRate = New System.Windows.Forms.Label()
        Me.lblEmployerRate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmployeeRate = New System.Windows.Forms.TextBox()
        Me.txtEmployerRate = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployerCont = New System.Windows.Forms.Label()
        Me.lblTotalCont = New System.Windows.Forms.Label()
        Me.lblEmployeeCont = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGross
        '
        Me.lblGross.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(12, 26)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(155, 30)
        Me.lblGross.TabIndex = 0
        Me.lblGross.Text = "&Gross weekly pay:"
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeRate
        '
        Me.lblEmployeeRate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeRate.Location = New System.Drawing.Point(12, 72)
        Me.lblEmployeeRate.Name = "lblEmployeeRate"
        Me.lblEmployeeRate.Size = New System.Drawing.Size(344, 27)
        Me.lblEmployeeRate.TabIndex = 0
        Me.lblEmployeeRate.Text = "&Employee contribution rate (decimal form):"
        Me.lblEmployeeRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployerRate
        '
        Me.lblEmployerRate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployerRate.Location = New System.Drawing.Point(12, 109)
        Me.lblEmployerRate.Name = "lblEmployerRate"
        Me.lblEmployerRate.Size = New System.Drawing.Size(344, 49)
        Me.lblEmployerRate.TabIndex = 0
        Me.lblEmployerRate.Text = "Employe&r contribution rate (decimal form):"
        Me.lblEmployerRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total annual contribution:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 50)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee annual contribution:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Employer annual contribution:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmployeeRate
        '
        Me.txtEmployeeRate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeRate.Location = New System.Drawing.Point(382, 72)
        Me.txtEmployeeRate.Name = "txtEmployeeRate"
        Me.txtEmployeeRate.Size = New System.Drawing.Size(100, 30)
        Me.txtEmployeeRate.TabIndex = 1
        Me.txtEmployeeRate.Text = "0.05"
        Me.txtEmployeeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployerRate
        '
        Me.txtEmployerRate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployerRate.Location = New System.Drawing.Point(382, 119)
        Me.txtEmployerRate.Name = "txtEmployerRate"
        Me.txtEmployerRate.Size = New System.Drawing.Size(100, 30)
        Me.txtEmployerRate.TabIndex = 1
        Me.txtEmployerRate.Text = "0.07"
        Me.txtEmployerRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGross
        '
        Me.txtGross.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(344, 27)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(138, 30)
        Me.txtGross.TabIndex = 1
        Me.txtGross.Text = "1000"
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(223, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 23)
        Me.Label7.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(98, 359)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(98, 49)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(357, 359)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 49)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployerCont
        '
        Me.lblEmployerCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerCont.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployerCont.Location = New System.Drawing.Point(346, 247)
        Me.lblEmployerCont.Name = "lblEmployerCont"
        Me.lblEmployerCont.Size = New System.Drawing.Size(136, 38)
        Me.lblEmployerCont.TabIndex = 4
        '
        'lblTotalCont
        '
        Me.lblTotalCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCont.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCont.Location = New System.Drawing.Point(344, 295)
        Me.lblTotalCont.Name = "lblTotalCont"
        Me.lblTotalCont.Size = New System.Drawing.Size(136, 38)
        Me.lblTotalCont.TabIndex = 4
        '
        'lblEmployeeCont
        '
        Me.lblEmployeeCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeCont.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeCont.Location = New System.Drawing.Point(346, 197)
        Me.lblEmployeeCont.Name = "lblEmployeeCont"
        Me.lblEmployeeCont.Size = New System.Drawing.Size(136, 38)
        Me.lblEmployeeCont.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(219, 359)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 48)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 439)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblEmployeeCont)
        Me.Controls.Add(Me.lblTotalCont)
        Me.Controls.Add(Me.lblEmployerCont)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtEmployerRate)
        Me.Controls.Add(Me.txtEmployeeRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEmployerRate)
        Me.Controls.Add(Me.lblEmployeeRate)
        Me.Controls.Add(Me.lblGross)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGross As Label
    Friend WithEvents lblEmployeeRate As Label
    Friend WithEvents lblEmployerRate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmployeeRate As TextBox
    Friend WithEvents txtEmployerRate As TextBox
    Friend WithEvents txtGross As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployerCont As Label
    Friend WithEvents lblTotalCont As Label
    Friend WithEvents lblEmployeeCont As Label
    Friend WithEvents btnClear As Button
End Class
