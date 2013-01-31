<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class results
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
        Me.studnets = New System.Windows.Forms.ListBox()
        Me.staff = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'studnets
        '
        Me.studnets.FormattingEnabled = True
        Me.studnets.Location = New System.Drawing.Point(31, 74)
        Me.studnets.Name = "studnets"
        Me.studnets.Size = New System.Drawing.Size(152, 225)
        Me.studnets.TabIndex = 0
        '
        'staff
        '
        Me.staff.FormattingEnabled = True
        Me.staff.Location = New System.Drawing.Point(224, 74)
        Me.staff.Name = "staff"
        Me.staff.Size = New System.Drawing.Size(152, 225)
        Me.staff.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "results"
        '
        'results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.staff)
        Me.Controls.Add(Me.studnets)
        Me.Name = "results"
        Me.Text = "results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents studnets As System.Windows.Forms.ListBox
    Friend WithEvents staff As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
