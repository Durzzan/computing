<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class see_results
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
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "title"
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Location = New System.Drawing.Point(45, 102)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(163, 199)
        Me.lst1.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(234, 273)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 28)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "back"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'see_results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 316)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.lst1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "see_results"
        Me.Text = "see_results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lst1 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
