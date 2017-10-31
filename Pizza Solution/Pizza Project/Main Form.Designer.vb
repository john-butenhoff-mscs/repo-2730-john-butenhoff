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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.picPizzaStatus = New System.Windows.Forms.PictureBox()
        Me.pic6Slices = New System.Windows.Forms.PictureBox()
        Me.pic5Slices = New System.Windows.Forms.PictureBox()
        Me.pic4Slices = New System.Windows.Forms.PictureBox()
        Me.pic3Slices = New System.Windows.Forms.PictureBox()
        Me.pic2Slices = New System.Windows.Forms.PictureBox()
        Me.pic1Slice = New System.Windows.Forms.PictureBox()
        Me.picTray = New System.Windows.Forms.PictureBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.picFullPizza = New System.Windows.Forms.PictureBox()
        CType(Me.picPizzaStatus,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pic6Slices,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pic5Slices,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pic4Slices,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pic3Slices,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pic2Slices,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pic1Slice,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picTray,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picFullPizza,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(295, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Secret word:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(458, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Incorrect letters:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(299, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Enter a letter:"
        '
        'lblWord
        '
        Me.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWord.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblWord.Location = New System.Drawing.Point(299, 62)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(134, 32)
        Me.lblWord.TabIndex = 4
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncorrect
        '
        Me.lblIncorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncorrect.Location = New System.Drawing.Point(462, 62)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(258, 32)
        Me.lblIncorrect.TabIndex = 6
        Me.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLetter
        '
        Me.txtLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLetter.Location = New System.Drawing.Point(402, 112)
        Me.txtLetter.MaxLength = 1
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(31, 27)
        Me.txtLetter.TabIndex = 1
        '
        'picPizzaStatus
        '
        Me.picPizzaStatus.Image = Global.Pizza_Project.My.Resources.Resources.FullPizza
        Me.picPizzaStatus.Location = New System.Drawing.Point(13, 38)
        Me.picPizzaStatus.Name = "picPizzaStatus"
        Me.picPizzaStatus.Size = New System.Drawing.Size(246, 222)
        Me.picPizzaStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizzaStatus.TabIndex = 6
        Me.picPizzaStatus.TabStop = false
        '
        'pic6Slices
        '
        Me.pic6Slices.Image = Global.Pizza_Project.My.Resources.Resources.Pizza6
        Me.pic6Slices.Location = New System.Drawing.Point(364, 183)
        Me.pic6Slices.Name = "pic6Slices"
        Me.pic6Slices.Size = New System.Drawing.Size(41, 33)
        Me.pic6Slices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6Slices.TabIndex = 7
        Me.pic6Slices.TabStop = false
        Me.pic6Slices.Visible = false
        '
        'pic5Slices
        '
        Me.pic5Slices.Image = Global.Pizza_Project.My.Resources.Resources.Pizza5
        Me.pic5Slices.Location = New System.Drawing.Point(411, 183)
        Me.pic5Slices.Name = "pic5Slices"
        Me.pic5Slices.Size = New System.Drawing.Size(41, 33)
        Me.pic5Slices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5Slices.TabIndex = 8
        Me.pic5Slices.TabStop = false
        Me.pic5Slices.Visible = false
        '
        'pic4Slices
        '
        Me.pic4Slices.Image = Global.Pizza_Project.My.Resources.Resources.Pizza4
        Me.pic4Slices.Location = New System.Drawing.Point(458, 183)
        Me.pic4Slices.Name = "pic4Slices"
        Me.pic4Slices.Size = New System.Drawing.Size(41, 33)
        Me.pic4Slices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4Slices.TabIndex = 9
        Me.pic4Slices.TabStop = false
        Me.pic4Slices.Visible = false
        '
        'pic3Slices
        '
        Me.pic3Slices.Image = Global.Pizza_Project.My.Resources.Resources.Pizza3
        Me.pic3Slices.Location = New System.Drawing.Point(505, 183)
        Me.pic3Slices.Name = "pic3Slices"
        Me.pic3Slices.Size = New System.Drawing.Size(41, 33)
        Me.pic3Slices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3Slices.TabIndex = 10
        Me.pic3Slices.TabStop = false
        Me.pic3Slices.Visible = false
        '
        'pic2Slices
        '
        Me.pic2Slices.Image = Global.Pizza_Project.My.Resources.Resources.Pizza2
        Me.pic2Slices.Location = New System.Drawing.Point(552, 183)
        Me.pic2Slices.Name = "pic2Slices"
        Me.pic2Slices.Size = New System.Drawing.Size(41, 33)
        Me.pic2Slices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2Slices.TabIndex = 11
        Me.pic2Slices.TabStop = false
        Me.pic2Slices.Visible = false
        '
        'pic1Slice
        '
        Me.pic1Slice.Image = Global.Pizza_Project.My.Resources.Resources.Pizza1
        Me.pic1Slice.Location = New System.Drawing.Point(599, 183)
        Me.pic1Slice.Name = "pic1Slice"
        Me.pic1Slice.Size = New System.Drawing.Size(41, 33)
        Me.pic1Slice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1Slice.TabIndex = 12
        Me.pic1Slice.TabStop = false
        Me.pic1Slice.Visible = false
        '
        'picTray
        '
        Me.picTray.Image = Global.Pizza_Project.My.Resources.Resources.Tray
        Me.picTray.Location = New System.Drawing.Point(646, 183)
        Me.picTray.Name = "picTray"
        Me.picTray.Size = New System.Drawing.Size(41, 33)
        Me.picTray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTray.TabIndex = 13
        Me.picTray.TabStop = false
        Me.picTray.Visible = false
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = false
        Me.btnCheck.Location = New System.Drawing.Point(462, 112)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(93, 29)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "&Check"
        Me.btnCheck.UseVisualStyleBackColor = true
        '
        'picFullPizza
        '
        Me.picFullPizza.Image = Global.Pizza_Project.My.Resources.Resources.FullPizza
        Me.picFullPizza.Location = New System.Drawing.Point(317, 183)
        Me.picFullPizza.Name = "picFullPizza"
        Me.picFullPizza.Size = New System.Drawing.Size(41, 33)
        Me.picFullPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFullPizza.TabIndex = 14
        Me.picFullPizza.TabStop = false
        Me.picFullPizza.Visible = false
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 279)
        Me.Controls.Add(Me.picFullPizza)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.picTray)
        Me.Controls.Add(Me.pic1Slice)
        Me.Controls.Add(Me.pic2Slices)
        Me.Controls.Add(Me.pic3Slices)
        Me.Controls.Add(Me.pic4Slices)
        Me.Controls.Add(Me.pic5Slices)
        Me.Controls.Add(Me.pic6Slices)
        Me.Controls.Add(Me.picPizzaStatus)
        Me.Controls.Add(Me.txtLetter)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Game"
        CType(Me.picPizzaStatus,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pic6Slices,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pic5Slices,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pic4Slices,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pic3Slices,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pic2Slices,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pic1Slice,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picTray,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picFullPizza,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWord As Label
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents picPizzaStatus As PictureBox
    Friend WithEvents pic6Slices As PictureBox
    Friend WithEvents pic5Slices As PictureBox
    Friend WithEvents pic4Slices As PictureBox
    Friend WithEvents pic3Slices As PictureBox
    Friend WithEvents pic2Slices As PictureBox
    Friend WithEvents pic1Slice As PictureBox
    Friend WithEvents picTray As PictureBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents picFullPizza As PictureBox
End Class
