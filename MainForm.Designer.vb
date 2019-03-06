<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picDrawOnScreen = New System.Windows.Forms.PictureBox()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblLevelNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Heart0 = New System.Windows.Forms.PictureBox()
        Me.Heart2 = New System.Windows.Forms.PictureBox()
        Me.Heart1 = New System.Windows.Forms.PictureBox()
        Me.BackPackMilk = New System.Windows.Forms.PictureBox()
        CType(Me.picDrawOnScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackPackMilk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 70
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
        Me.lblLives.Location = New System.Drawing.Point(636, 38)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(117, 39)
        Me.lblLives.TabIndex = 2
        Me.lblLives.Text = "Lives:  "
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 500)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(53, 494)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(125, 39)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "Score:  "
        '
        'Heart0
        '
        Me.Heart0.BackColor = System.Drawing.Color.Transparent
        Me.Heart0.Image = CType(resources.GetObject("Heart0.Image"), System.Drawing.Image)
        Me.Heart0.Location = New System.Drawing.Point(647, 100)
        Me.Heart0.Name = "Heart0"
        Me.Heart0.Size = New System.Drawing.Size(35, 34)
        Me.Heart0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Heart0.TabIndex = 6
        Me.Heart0.TabStop = False
        '
        'Heart2
        '
        Me.Heart2.BackColor = System.Drawing.Color.Transparent
        Me.Heart2.Image = CType(resources.GetObject("Heart2.Image"), System.Drawing.Image)
        Me.Heart2.Location = New System.Drawing.Point(727, 100)
        Me.Heart2.Name = "Heart2"
        Me.Heart2.Size = New System.Drawing.Size(35, 34)
        Me.Heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Heart2.TabIndex = 7
        Me.Heart2.TabStop = False
        '
        'Heart1
        '
        Me.Heart1.BackColor = System.Drawing.Color.Transparent
        Me.Heart1.Image = CType(resources.GetObject("Heart1.Image"), System.Drawing.Image)
        Me.Heart1.Location = New System.Drawing.Point(688, 100)
        Me.Heart1.Name = "Heart1"
        Me.Heart1.Size = New System.Drawing.Size(35, 34)
        Me.Heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Heart1.TabIndex = 8
        Me.Heart1.TabStop = False
        '
        'BackPackMilk
        '
        Me.BackPackMilk.Image = CType(resources.GetObject("BackPackMilk.Image"), System.Drawing.Image)
        Me.BackPackMilk.Location = New System.Drawing.Point(688, 274)
        Me.BackPackMilk.Name = "BackPackMilk"
        Me.BackPackMilk.Size = New System.Drawing.Size(36, 24)
        Me.BackPackMilk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BackPackMilk.TabIndex = 9
        Me.BackPackMilk.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.BackPackMilk)
        Me.Controls.Add(Me.Heart1)
        Me.Controls.Add(Me.Heart2)
        Me.Controls.Add(Me.Heart0)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLevelNumber)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.picDrawOnScreen)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MainForm"
        Me.Text = "Galacticat"
        CType(Me.picDrawOnScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackPackMilk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picDrawOnScreen As PictureBox
    Friend WithEvents lblLives As Label
    Friend WithEvents lblLevelNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Heart0 As PictureBox
    Friend WithEvents Heart2 As PictureBox
    Friend WithEvents Heart1 As PictureBox
    Friend WithEvents BackPackMilk As PictureBox
End Class
