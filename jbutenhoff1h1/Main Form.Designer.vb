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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFWTC = New System.Windows.Forms.Label()
        Me.lblFICAC = New System.Windows.Forms.Label()
        Me.lblStateC = New System.Windows.Forms.Label()
        Me.lblNetC = New System.Windows.Forms.Label()
        Me.lblGrossC = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(287, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 22)
        Me.txtName.TabIndex = 0
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(271, 131)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(72, 22)
        Me.txtHours.TabIndex = 2
        Me.txtHours.Text = "0.00"
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(118, 131)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(72, 22)
        Me.txtRate.TabIndex = 1
        Me.txtRate.Text = "0.00"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(128, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(140, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Employee &Name:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(267, 87)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(103, 23)
        Me.lblRate.TabIndex = 2
        Me.lblRate.Text = "&Rate of Pay:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(114, 87)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(125, 23)
        Me.lblHours.TabIndex = 3
        Me.lblHours.Text = "&Hours Worked:"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(410, 87)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(89, 23)
        Me.lblGross.TabIndex = 4
        Me.lblGross.Text = "&Gross Pay:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(423, 194)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(42, 23)
        Me.lblNet.TabIndex = 5
        Me.lblNet.Text = "&Net:"
        '
        'lblFWT
        '
        Me.lblFWT.AutoSize = True
        Me.lblFWT.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWT.Location = New System.Drawing.Point(12, 194)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(48, 23)
        Me.lblFWT.TabIndex = 6
        Me.lblFWT.Text = "F&WT:"
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(144, 194)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(50, 23)
        Me.lblFICA.TabIndex = 7
        Me.lblFICA.Text = "&FICA:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(279, 194)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(53, 23)
        Me.lblState.TabIndex = 8
        Me.lblState.Text = "&State:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(56, 262)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 39)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(448, 262)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(254, 262)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 39)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jbutenhoff1h1.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblFWTC
        '
        Me.lblFWTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFWTC.Location = New System.Drawing.Point(66, 193)
        Me.lblFWTC.Name = "lblFWTC"
        Me.lblFWTC.Size = New System.Drawing.Size(72, 29)
        Me.lblFWTC.TabIndex = 12
        Me.lblFWTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFICAC
        '
        Me.lblFICAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFICAC.Location = New System.Drawing.Point(196, 194)
        Me.lblFICAC.Name = "lblFICAC"
        Me.lblFICAC.Size = New System.Drawing.Size(72, 29)
        Me.lblFICAC.TabIndex = 12
        Me.lblFICAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStateC
        '
        Me.lblStateC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStateC.Location = New System.Drawing.Point(338, 194)
        Me.lblStateC.Name = "lblStateC"
        Me.lblStateC.Size = New System.Drawing.Size(72, 29)
        Me.lblStateC.TabIndex = 12
        Me.lblStateC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetC
        '
        Me.lblNetC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetC.Location = New System.Drawing.Point(471, 194)
        Me.lblNetC.Name = "lblNetC"
        Me.lblNetC.Size = New System.Drawing.Size(72, 29)
        Me.lblNetC.TabIndex = 12
        Me.lblNetC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossC
        '
        Me.lblGrossC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossC.Location = New System.Drawing.Point(427, 131)
        Me.lblGrossC.Name = "lblGrossC"
        Me.lblGrossC.Size = New System.Drawing.Size(72, 22)
        Me.lblGrossC.TabIndex = 12
        Me.lblGrossC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 313)
        Me.Controls.Add(Me.lblGrossC)
        Me.Controls.Add(Me.lblNetC)
        Me.Controls.Add(Me.lblStateC)
        Me.Controls.Add(Me.lblFICAC)
        Me.Controls.Add(Me.lblFWTC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jbutenhoff1h1; Photo Workshop Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblFWT As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblState As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFWTC As Label
    Friend WithEvents lblFICAC As Label
    Friend WithEvents lblStateC As Label
    Friend WithEvents lblNetC As Label
    Friend WithEvents lblGrossC As Label
End Class
