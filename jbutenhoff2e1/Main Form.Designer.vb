<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrders = New System.Windows.Forms.TextBox()
        Me.btnCalcOr = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblShipFee = New System.Windows.Forms.Label()
        Me.btnCalc2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.btnCalcEqual = New System.Windows.Forms.Button()
        Me.btnCalcNotEqual = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(22, 33)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(125, 23)
        Me.Label.TabIndex = 0
        Me.Label.Text = "&Order Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Shipping Charge:"
        '
        'txtOrders
        '
        Me.txtOrders.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrders.Location = New System.Drawing.Point(26, 66)
        Me.txtOrders.Name = "txtOrders"
        Me.txtOrders.Size = New System.Drawing.Size(148, 30)
        Me.txtOrders.TabIndex = 0
        '
        'btnCalcOr
        '
        Me.btnCalcOr.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcOr.Location = New System.Drawing.Point(480, 82)
        Me.btnCalcOr.Name = "btnCalcOr"
        Me.btnCalcOr.Size = New System.Drawing.Size(136, 35)
        Me.btnCalcOr.TabIndex = 3
        Me.btnCalcOr.Text = "&Calculate(Or)"
        Me.btnCalcOr.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(271, 311)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(176, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 29)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "&Savannah (Y/N):"
        '
        'lblShipFee
        '
        Me.lblShipFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipFee.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipFee.Location = New System.Drawing.Point(330, 66)
        Me.lblShipFee.Name = "lblShipFee"
        Me.lblShipFee.Size = New System.Drawing.Size(108, 26)
        Me.lblShipFee.TabIndex = 7
        '
        'btnCalc2
        '
        Me.btnCalc2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc2.Location = New System.Drawing.Point(480, 21)
        Me.btnCalc2.Name = "btnCalc2"
        Me.btnCalc2.Size = New System.Drawing.Size(136, 35)
        Me.btnCalc2.TabIndex = 2
        Me.btnCalc2.Text = "C&alculate(And)"
        Me.btnCalc2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCC)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblShipFee)
        Me.GroupBox1.Controls.Add(Me.txtOrders)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnCalcOr)
        Me.GroupBox1.Controls.Add(Me.btnCalc2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 143)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free Shipping for orders over $100 with Savannah CC"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(82, 60)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 30)
        Me.txtSales.TabIndex = 1
        Me.txtSales.Text = "100000"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(9, 60)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(57, 30)
        Me.txtID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "&ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Commission:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "&Sales:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(276, 59)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(100, 31)
        Me.lblCommission.TabIndex = 15
        '
        'btnCalcEqual
        '
        Me.btnCalcEqual.Location = New System.Drawing.Point(464, 28)
        Me.btnCalcEqual.Name = "btnCalcEqual"
        Me.btnCalcEqual.Size = New System.Drawing.Size(136, 32)
        Me.btnCalcEqual.TabIndex = 2
        Me.btnCalcEqual.Text = "Calculate ( = )"
        Me.btnCalcEqual.UseVisualStyleBackColor = True
        '
        'btnCalcNotEqual
        '
        Me.btnCalcNotEqual.Location = New System.Drawing.Point(464, 76)
        Me.btnCalcNotEqual.Name = "btnCalcNotEqual"
        Me.btnCalcNotEqual.Size = New System.Drawing.Size(136, 34)
        Me.btnCalcNotEqual.TabIndex = 3
        Me.btnCalcNotEqual.Text = "Calculate (<>)"
        Me.btnCalcNotEqual.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnCalcNotEqual)
        Me.GroupBox2.Controls.Add(Me.btnCalcEqual)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.lblCommission)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(618, 128)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "15% commission for sales > 25000 with codes A1, B2, C3"
        '
        'txtCC
        '
        Me.txtCC.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCC.Location = New System.Drawing.Point(190, 65)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(61, 30)
        Me.txtCC.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 361)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMain"
        Me.Text = "jbutenhoff2e1 AndAlso, OrElse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrders As TextBox
    Friend WithEvents btnCalcOr As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblShipFee As Label
    Friend WithEvents btnCalc2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents btnCalcEqual As Button
    Friend WithEvents btnCalcNotEqual As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCC As TextBox
End Class
