<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'YesButton
        '
        Me.YesButton.Font = New System.Drawing.Font("Century Schoolbook", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesButton.Location = New System.Drawing.Point(239, 348)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(125, 61)
        Me.YesButton.TabIndex = 3
        Me.YesButton.Text = "YES"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.Font = New System.Drawing.Font("Century Schoolbook", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoButton.Location = New System.Drawing.Point(471, 348)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(125, 61)
        Me.NoButton.TabIndex = 4
        Me.NoButton.Text = "NO"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Broadway", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(86, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(701, 122)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Game Over"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Broadway", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(208, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(468, 72)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Play Again? "
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(836, 491)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Name = "frmGameOver"
        Me.Text = "frmGameOver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
