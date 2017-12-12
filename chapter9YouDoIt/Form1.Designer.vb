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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblUpperBound = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblLength
        '
        Me.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLength.Location = New System.Drawing.Point(142, 63)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(100, 23)
        Me.lblLength.TabIndex = 1
        '
        'lblUpperBound
        '
        Me.lblUpperBound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpperBound.Location = New System.Drawing.Point(23, 63)
        Me.lblUpperBound.Name = "lblUpperBound"
        Me.lblUpperBound.Size = New System.Drawing.Size(100, 23)
        Me.lblUpperBound.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 176)
        Me.Controls.Add(Me.lblUpperBound)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblLength As Label
    Friend WithEvents lblUpperBound As Label
End Class
