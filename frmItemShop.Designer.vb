<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemShop))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPortableMilk = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(653, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Greetings Stranger.  How can I help you? "
        '
        'BtnPortableMilk
        '
        Me.BtnPortableMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPortableMilk.Image = CType(resources.GetObject("BtnPortableMilk.Image"), System.Drawing.Image)
        Me.BtnPortableMilk.Location = New System.Drawing.Point(234, 164)
        Me.BtnPortableMilk.Name = "BtnPortableMilk"
        Me.BtnPortableMilk.Size = New System.Drawing.Size(189, 158)
        Me.BtnPortableMilk.TabIndex = 1
        Me.BtnPortableMilk.Text = "Portable Milk"
        Me.BtnPortableMilk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPortableMilk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "1000 Points"
        '
        'frmItemShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(689, 500)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPortableMilk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmItemShop"
        Me.Text = "frmItemShop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPortableMilk As Button
    Friend WithEvents Label2 As Label
End Class
