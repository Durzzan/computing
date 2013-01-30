<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_form
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultation evening organiser"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 100)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Import student and teacher data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 100)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(211, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 100)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Run algortithm"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(211, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 100)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "see results"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(380, 126)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 100)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Send results"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 523)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main_form"
        Me.Text = "Main_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
