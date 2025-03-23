<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RolloftheDice2
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
        Me.DiceDisplay = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiceDisplay
        '
        Me.DiceDisplay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DiceDisplay.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiceDisplay.FormattingEnabled = True
        Me.DiceDisplay.ItemHeight = 15
        Me.DiceDisplay.Location = New System.Drawing.Point(12, 12)
        Me.DiceDisplay.Name = "DiceDisplay"
        Me.DiceDisplay.Size = New System.Drawing.Size(776, 214)
        Me.DiceDisplay.TabIndex = 0
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(12, 246)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(172, 82)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(190, 246)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(172, 82)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(368, 246)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(172, 82)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 469)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.DiceDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DiceDisplay As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
