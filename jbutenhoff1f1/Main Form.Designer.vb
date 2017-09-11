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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.lblProjectedIncrease = New System.Windows.Forms.Label()
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblProjectedSales = New System.Windows.Forms.Label()
        Me.lblCurrentSales = New System.Windows.Forms.Label()
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.txtRasp = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.lblProjBlue = New System.Windows.Forms.Label()
        Me.lblProjRasp = New System.Windows.Forms.Label()
        Me.lblProjStraw = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(36, 322)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(84, 41)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(158, 322)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(84, 41)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(289, 322)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 41)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(416, 322)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 41)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(75, 216)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(92, 20)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "&Blueberries:"
        '
        'lblRasp
        '
        Me.lblRasp.AutoSize = True
        Me.lblRasp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRasp.Location = New System.Drawing.Point(72, 262)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(95, 20)
        Me.lblRasp.TabIndex = 5
        Me.lblRasp.Text = "&Raspberries:"
        '
        'lblProjectedIncrease
        '
        Me.lblProjectedIncrease.AutoSize = True
        Me.lblProjectedIncrease.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectedIncrease.Location = New System.Drawing.Point(126, 61)
        Me.lblProjectedIncrease.Name = "lblProjectedIncrease"
        Me.lblProjectedIncrease.Size = New System.Drawing.Size(287, 20)
        Me.lblProjectedIncrease.TabIndex = 10
        Me.lblProjectedIncrease.Text = "Projected &increase % (in decimal form): "
        '
        'lblStraw
        '
        Me.lblStraw.AutoSize = True
        Me.lblStraw.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraw.Location = New System.Drawing.Point(66, 170)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(101, 20)
        Me.lblStraw.TabIndex = 1
        Me.lblStraw.Text = "&Strawberries:"
        '
        'lblProjectedSales
        '
        Me.lblProjectedSales.AutoSize = True
        Me.lblProjectedSales.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectedSales.Location = New System.Drawing.Point(340, 130)
        Me.lblProjectedSales.Name = "lblProjectedSales"
        Me.lblProjectedSales.Size = New System.Drawing.Size(114, 20)
        Me.lblProjectedSales.TabIndex = 12
        Me.lblProjectedSales.Text = "Projected Sales"
        '
        'lblCurrentSales
        '
        Me.lblCurrentSales.AutoSize = True
        Me.lblCurrentSales.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSales.Location = New System.Drawing.Point(173, 130)
        Me.lblCurrentSales.Name = "lblCurrentSales"
        Me.lblCurrentSales.Size = New System.Drawing.Size(101, 20)
        Me.lblCurrentSales.TabIndex = 11
        Me.lblCurrentSales.Text = "Current Sales"
        '
        'txtStraw
        '
        Me.txtStraw.Location = New System.Drawing.Point(177, 167)
        Me.txtStraw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(92, 27)
        Me.txtStraw.TabIndex = 2
        Me.txtStraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRasp
        '
        Me.txtRasp.Location = New System.Drawing.Point(177, 262)
        Me.txtRasp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRasp.Name = "txtRasp"
        Me.txtRasp.Size = New System.Drawing.Size(92, 27)
        Me.txtRasp.TabIndex = 6
        Me.txtRasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(177, 216)
        Me.txtBlue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(92, 27)
        Me.txtBlue.TabIndex = 4
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProjBlue
        '
        Me.lblProjBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjBlue.Location = New System.Drawing.Point(344, 216)
        Me.lblProjBlue.Name = "lblProjBlue"
        Me.lblProjBlue.Size = New System.Drawing.Size(92, 27)
        Me.lblProjBlue.TabIndex = 14
        Me.lblProjBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjRasp
        '
        Me.lblProjRasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjRasp.Location = New System.Drawing.Point(344, 262)
        Me.lblProjRasp.Name = "lblProjRasp"
        Me.lblProjRasp.Size = New System.Drawing.Size(92, 27)
        Me.lblProjRasp.TabIndex = 15
        Me.lblProjRasp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjStraw
        '
        Me.lblProjStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjStraw.Location = New System.Drawing.Point(344, 167)
        Me.lblProjStraw.Name = "lblProjStraw"
        Me.lblProjStraw.Size = New System.Drawing.Size(92, 27)
        Me.lblProjStraw.TabIndex = 13
        Me.lblProjStraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jbutenhoff1f1.My.Resources.Resources.berrires1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 86)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.Location = New System.Drawing.Point(414, 58)
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(86, 27)
        Me.txtProjIncrease.TabIndex = 0
        Me.txtProjIncrease.Text = "0.05"
        Me.txtProjIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 385)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblProjStraw)
        Me.Controls.Add(Me.lblProjRasp)
        Me.Controls.Add(Me.txtRasp)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtStraw)
        Me.Controls.Add(Me.lblProjBlue)
        Me.Controls.Add(Me.lblCurrentSales)
        Me.Controls.Add(Me.lblProjectedSales)
        Me.Controls.Add(Me.lblProjectedIncrease)
        Me.Controls.Add(Me.lblStraw)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents lblProjectedIncrease As Label
    Friend WithEvents lblStraw As Label
    Friend WithEvents lblProjectedSales As Label
    Friend WithEvents lblCurrentSales As Label
    Friend WithEvents txtStraw As TextBox
    Friend WithEvents txtRasp As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents lblProjBlue As Label
    Friend WithEvents lblProjRasp As Label
    Friend WithEvents lblProjStraw As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtProjIncrease As TextBox
End Class
