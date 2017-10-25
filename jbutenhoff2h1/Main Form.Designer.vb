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
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcIf = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCommissionOnly = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.chkOver10 = New System.Windows.Forms.CheckBox()
        Me.chkTravel = New System.Windows.Forms.CheckBox()
        Me.btnCalcNestedIf = New System.Windows.Forms.Button()
        Me.btnCalcIfElseIf = New System.Windows.Forms.Button()
        Me.btnCalcSelect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSales
        '
        Me.txtSales.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.Location = New System.Drawing.Point(12, 35)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 30)
        Me.txtSales.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Sales:"
        '
        'btnCalcIf
        '
        Me.btnCalcIf.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcIf.Location = New System.Drawing.Point(205, 35)
        Me.btnCalcIf.Name = "btnCalcIf"
        Me.btnCalcIf.Size = New System.Drawing.Size(179, 35)
        Me.btnCalcIf.TabIndex = 3
        Me.btnCalcIf.Text = "&Calculate If"
        Me.btnCalcIf.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(503, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Commission only:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Additional amount:"
        '
        'lblCommissionOnly
        '
        Me.lblCommissionOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissionOnly.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommissionOnly.Location = New System.Drawing.Point(11, 164)
        Me.lblCommissionOnly.Name = "lblCommissionOnly"
        Me.lblCommissionOnly.Size = New System.Drawing.Size(101, 26)
        Me.lblCommissionOnly.TabIndex = 6
        '
        'lblAdditional
        '
        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditional.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditional.Location = New System.Drawing.Point(12, 222)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(101, 26)
        Me.lblAdditional.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total due salesperson:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.Location = New System.Drawing.Point(12, 294)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(139, 52)
        Me.lblTotalDue.TabIndex = 9
        '
        'chkOver10
        '
        Me.chkOver10.AutoSize = True
        Me.chkOver10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOver10.Location = New System.Drawing.Point(16, 71)
        Me.chkOver10.Name = "chkOver10"
        Me.chkOver10.Size = New System.Drawing.Size(135, 27)
        Me.chkOver10.TabIndex = 1
        Me.chkOver10.Text = "&Over 10 years"
        Me.chkOver10.UseVisualStyleBackColor = True
        '
        'chkTravel
        '
        Me.chkTravel.AutoSize = True
        Me.chkTravel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTravel.Location = New System.Drawing.Point(16, 101)
        Me.chkTravel.Name = "chkTravel"
        Me.chkTravel.Size = New System.Drawing.Size(100, 27)
        Me.chkTravel.TabIndex = 2
        Me.chkTravel.Text = "&Traveling"
        Me.chkTravel.UseVisualStyleBackColor = True
        '
        'btnCalcNestedIf
        '
        Me.btnCalcNestedIf.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcNestedIf.Location = New System.Drawing.Point(205, 100)
        Me.btnCalcNestedIf.Name = "btnCalcNestedIf"
        Me.btnCalcNestedIf.Size = New System.Drawing.Size(179, 35)
        Me.btnCalcNestedIf.TabIndex = 4
        Me.btnCalcNestedIf.Text = "Calculate Nested if"
        Me.btnCalcNestedIf.UseVisualStyleBackColor = True
        '
        'btnCalcIfElseIf
        '
        Me.btnCalcIfElseIf.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcIfElseIf.Location = New System.Drawing.Point(205, 164)
        Me.btnCalcIfElseIf.Name = "btnCalcIfElseIf"
        Me.btnCalcIfElseIf.Size = New System.Drawing.Size(179, 35)
        Me.btnCalcIfElseIf.TabIndex = 5
        Me.btnCalcIfElseIf.Text = "Calculate If Else-if"
        Me.btnCalcIfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalcSelect
        '
        Me.btnCalcSelect.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcSelect.Location = New System.Drawing.Point(205, 222)
        Me.btnCalcSelect.Name = "btnCalcSelect"
        Me.btnCalcSelect.Size = New System.Drawing.Size(179, 35)
        Me.btnCalcSelect.TabIndex = 6
        Me.btnCalcSelect.Text = "Calculate Select"
        Me.btnCalcSelect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(390, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 256)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission calculation's"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(411, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sales"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(534, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Commission"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(408, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "1-5,999.99"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(408, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "6,000-29,999.99"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(408, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "> 30,000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(531, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "10% of sales"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(531, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "$120 + 13% of sales > 6,000"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(531, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "$3,120 + 14% of sales > 30,000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(408, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Additional Amounts"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(408, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "> 10 years"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(408, 218)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 17)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Traveling"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(509, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "$500"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(509, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 17)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "$700"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 355)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalcSelect)
        Me.Controls.Add(Me.btnCalcIfElseIf)
        Me.Controls.Add(Me.btnCalcNestedIf)
        Me.Controls.Add(Me.chkTravel)
        Me.Controls.Add(Me.chkOver10)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.lblCommissionOnly)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcIf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSales)
        Me.Name = "frmMain"
        Me.Text = "jbutenhoff2h1 Marshall Solution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcIf As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCommissionOnly As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents chkOver10 As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents btnCalcNestedIf As Button
    Friend WithEvents btnCalcIfElseIf As Button
    Friend WithEvents btnCalcSelect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
