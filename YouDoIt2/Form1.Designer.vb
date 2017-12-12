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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstForEachNext = New System.Windows.Forms.ListBox()
        Me.lstDoLoop = New System.Windows.Forms.ListBox()
        Me.lstForNext = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstForEachNext
        '
        Me.lstForEachNext.FormattingEnabled = True
        Me.lstForEachNext.ItemHeight = 16
        Me.lstForEachNext.Location = New System.Drawing.Point(22, 70)
        Me.lstForEachNext.Name = "lstForEachNext"
        Me.lstForEachNext.Size = New System.Drawing.Size(120, 148)
        Me.lstForEachNext.TabIndex = 1
        '
        'lstDoLoop
        '
        Me.lstDoLoop.FormattingEnabled = True
        Me.lstDoLoop.ItemHeight = 16
        Me.lstDoLoop.Location = New System.Drawing.Point(148, 70)
        Me.lstDoLoop.Name = "lstDoLoop"
        Me.lstDoLoop.Size = New System.Drawing.Size(120, 148)
        Me.lstDoLoop.TabIndex = 2
        '
        'lstForNext
        '
        Me.lstForNext.FormattingEnabled = True
        Me.lstForNext.ItemHeight = 16
        Me.lstForNext.Location = New System.Drawing.Point(274, 70)
        Me.lstForNext.Name = "lstForNext"
        Me.lstForNext.Size = New System.Drawing.Size(120, 148)
        Me.lstForNext.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 267)
        Me.Controls.Add(Me.lstForNext)
        Me.Controls.Add(Me.lstDoLoop)
        Me.Controls.Add(Me.lstForEachNext)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lstForEachNext As ListBox
    Friend WithEvents lstDoLoop As ListBox
    Friend WithEvents lstForNext As ListBox
End Class
