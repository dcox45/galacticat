<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picDrawOnScreen = New System.Windows.Forms.PictureBox()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblLevelNumber = New System.Windows.Forms.Label()
        CType(Me.picDrawOnScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'picDrawOnScreen
        '
        Me.picDrawOnScreen.Location = New System.Drawing.Point(306, 121)
        Me.picDrawOnScreen.Name = "picDrawOnScreen"
        Me.picDrawOnScreen.Size = New System.Drawing.Size(100, 50)
        Me.picDrawOnScreen.TabIndex = 1
        Me.picDrawOnScreen.TabStop = False
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.BackColor = System.Drawing.Color.Transparent
        Me.lblLives.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.White
        Me.lblLives.Location = New System.Drawing.Point(636, 29)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(136, 39)
        Me.lblLives.TabIndex = 2
        Me.lblLives.Text = "Lives:  3"
        '
        'lblLevelNumber
        '
        Me.lblLevelNumber.AutoSize = True
        Me.lblLevelNumber.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelNumber.ForeColor = System.Drawing.Color.White
        Me.lblLevelNumber.Location = New System.Drawing.Point(636, 499)
        Me.lblLevelNumber.Name = "lblLevelNumber"
        Me.lblLevelNumber.Size = New System.Drawing.Size(126, 39)
        Me.lblLevelNumber.TabIndex = 3
        Me.lblLevelNumber.Text = "Level: 1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblLevelNumber)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.picDrawOnScreen)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MainForm"
        Me.Text = "Galacticat"
        CType(Me.picDrawOnScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picDrawOnScreen As PictureBox
    Friend WithEvents lblLives As Label
    Friend WithEvents lblLevelNumber As Label
End Class
