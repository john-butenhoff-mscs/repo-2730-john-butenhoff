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
        Me.lblTest1 = New System.Windows.Forms.Label()
        Me.lblTest2 = New System.Windows.Forms.Label()
        Me.lblTest3 = New System.Windows.Forms.Label()
        Me.txtTest1 = New System.Windows.Forms.TextBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        Me.txtTest3 = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAvgTest = New System.Windows.Forms.Label()
        Me.txtAvgTest = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTest1
        '
        Me.lblTest1.AutoSize = True
        Me.lblTest1.Location = New System.Drawing.Point(13, 58)
        Me.lblTest1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTest1.Name = "lblTest1"
        Me.lblTest1.Size = New System.Drawing.Size(119, 25)
        Me.lblTest1.TabIndex = 0
        Me.lblTest1.Text = "Test score &1:"
        '
        'lblTest2
        '
        Me.lblTest2.AutoSize = True
        Me.lblTest2.Location = New System.Drawing.Point(13, 140)
        Me.lblTest2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTest2.Name = "lblTest2"
        Me.lblTest2.Size = New System.Drawing.Size(119, 25)
        Me.lblTest2.TabIndex = 2
        Me.lblTest2.Text = "Test score &2:"
        '
        'lblTest3
        '
        Me.lblTest3.AutoSize = True
        Me.lblTest3.Location = New System.Drawing.Point(13, 229)
        Me.lblTest3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTest3.Name = "lblTest3"
        Me.lblTest3.Size = New System.Drawing.Size(119, 25)
        Me.lblTest3.TabIndex = 4
        Me.lblTest3.Text = "Test score &3:"
        '
        'txtTest1
        '
        Me.txtTest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTest1.Location = New System.Drawing.Point(139, 58)
        Me.txtTest1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTest1.Name = "txtTest1"
        Me.txtTest1.Size = New System.Drawing.Size(83, 31)
        Me.txtTest1.TabIndex = 0
        Me.txtTest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTest2
        '
        Me.txtTest2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTest2.Location = New System.Drawing.Point(139, 140)
        Me.txtTest2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(83, 31)
        Me.txtTest2.TabIndex = 1
        Me.txtTest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTest3
        '
        Me.txtTest3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTest3.Location = New System.Drawing.Point(139, 229)
        Me.txtTest3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTest3.Name = "txtTest3"
        Me.txtTest3.Size = New System.Drawing.Size(83, 31)
        Me.txtTest3.TabIndex = 2
        Me.txtTest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(252, 47)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(104, 42)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(252, 129)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 42)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(252, 222)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAvgTest
        '
        Me.lblAvgTest.AutoSize = True
        Me.lblAvgTest.Location = New System.Drawing.Point(15, 305)
        Me.lblAvgTest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvgTest.Name = "lblAvgTest"
        Me.lblAvgTest.Size = New System.Drawing.Size(179, 25)
        Me.lblAvgTest.TabIndex = 6
        Me.lblAvgTest.Text = "Average test score:"
        '
        'txtAvgTest
        '
        Me.txtAvgTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvgTest.Location = New System.Drawing.Point(202, 305)
        Me.txtAvgTest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAvgTest.Name = "txtAvgTest"
        Me.txtAvgTest.Size = New System.Drawing.Size(121, 31)
        Me.txtAvgTest.TabIndex = 3
        Me.txtAvgTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 368)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtAvgTest)
        Me.Controls.Add(Me.txtTest3)
        Me.Controls.Add(Me.txtTest2)
        Me.Controls.Add(Me.txtTest1)
        Me.Controls.Add(Me.lblAvgTest)
        Me.Controls.Add(Me.lblTest3)
        Me.Controls.Add(Me.lblTest2)
        Me.Controls.Add(Me.lblTest1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jbutenhoff1g1 Average Test Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTest1 As Label
    Friend WithEvents lblTest2 As Label
    Friend WithEvents lblTest3 As Label
    Friend WithEvents txtTest1 As TextBox
    Friend WithEvents txtTest2 As TextBox
    Friend WithEvents txtTest3 As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAvgTest As Label
    Friend WithEvents txtAvgTest As TextBox
End Class
