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
        Me.btnPreDoWhile = New System.Windows.Forms.Button()
        Me.btnPreDoUntil = New System.Windows.Forms.Button()
        Me.btnPreLoopWhile = New System.Windows.Forms.Button()
        Me.btnPreLoopUntil = New System.Windows.Forms.Button()
        Me.btnPreFor = New System.Windows.Forms.Button()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtList = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreDoWhile
        '
        Me.btnPreDoWhile.Location = New System.Drawing.Point(141, 42)
        Me.btnPreDoWhile.Name = "btnPreDoWhile"
        Me.btnPreDoWhile.Size = New System.Drawing.Size(146, 33)
        Me.btnPreDoWhile.TabIndex = 0
        Me.btnPreDoWhile.Text = "Pretest: Do While"
        Me.btnPreDoWhile.UseVisualStyleBackColor = True
        '
        'btnPreDoUntil
        '
        Me.btnPreDoUntil.Location = New System.Drawing.Point(141, 81)
        Me.btnPreDoUntil.Name = "btnPreDoUntil"
        Me.btnPreDoUntil.Size = New System.Drawing.Size(146, 33)
        Me.btnPreDoUntil.TabIndex = 1
        Me.btnPreDoUntil.Text = "Pretest: Do Until"
        Me.btnPreDoUntil.UseVisualStyleBackColor = True
        '
        'btnPreLoopWhile
        '
        Me.btnPreLoopWhile.Location = New System.Drawing.Point(141, 120)
        Me.btnPreLoopWhile.Name = "btnPreLoopWhile"
        Me.btnPreLoopWhile.Size = New System.Drawing.Size(146, 33)
        Me.btnPreLoopWhile.TabIndex = 2
        Me.btnPreLoopWhile.Text = "Pretest: Loop While"
        Me.btnPreLoopWhile.UseVisualStyleBackColor = True
        '
        'btnPreLoopUntil
        '
        Me.btnPreLoopUntil.Location = New System.Drawing.Point(141, 159)
        Me.btnPreLoopUntil.Name = "btnPreLoopUntil"
        Me.btnPreLoopUntil.Size = New System.Drawing.Size(146, 33)
        Me.btnPreLoopUntil.TabIndex = 3
        Me.btnPreLoopUntil.Text = "Pretest: Loop Until"
        Me.btnPreLoopUntil.UseVisualStyleBackColor = True
        '
        'btnPreFor
        '
        Me.btnPreFor.Location = New System.Drawing.Point(141, 198)
        Me.btnPreFor.Name = "btnPreFor"
        Me.btnPreFor.Size = New System.Drawing.Size(146, 33)
        Me.btnPreFor.TabIndex = 4
        Me.btnPreFor.Text = "Pretest: For"
        Me.btnPreFor.UseVisualStyleBackColor = True
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(206, 120)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(178, 33)
        Me.btnSumDoWhile.TabIndex = 5
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(206, 164)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(178, 33)
        Me.btnSumLoopUntil.TabIndex = 6
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(206, 207)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(178, 33)
        Me.btnSumForNext.TabIndex = 7
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.btnPreDoWhile)
        Me.GroupBox1.Controls.Add(Me.btnPreDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnPreLoopWhile)
        Me.GroupBox1.Controls.Add(Me.btnPreLoopUntil)
        Me.GroupBox1.Controls.Add(Me.btnPreFor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 263)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347 #13 Loop 2-20"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(17, 32)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(118, 199)
        Me.lblEven.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Average:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Count:"
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(206, 78)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(77, 36)
        Me.lblAvg.TabIndex = 11
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(307, 78)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(77, 36)
        Me.lblCount.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(363, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 263)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332_348 #22 Addition"
        '
        'txtList
        '
        Me.txtList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtList.Location = New System.Drawing.Point(47, 69)
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(144, 171)
        Me.txtList.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 298)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "jbutenhoff 3a1 Loops, sum, count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPreDoWhile As Button
    Friend WithEvents btnPreDoUntil As Button
    Friend WithEvents btnPreLoopWhile As Button
    Friend WithEvents btnPreLoopUntil As Button
    Friend WithEvents btnPreFor As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblEven As Label
    Friend WithEvents txtList As Label
End Class
