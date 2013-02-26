<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDirectory
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
        Me.btnAdminStaff = New System.Windows.Forms.Button()
        Me.btnAdminStudents = New System.Windows.Forms.Button()
        Me.btnAdminRewards = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin"
        '
        'btnAdminStaff
        '
        Me.btnAdminStaff.Location = New System.Drawing.Point(48, 62)
        Me.btnAdminStaff.Name = "btnAdminStaff"
        Me.btnAdminStaff.Size = New System.Drawing.Size(188, 43)
        Me.btnAdminStaff.TabIndex = 1
        Me.btnAdminStaff.Text = "Staff"
        Me.btnAdminStaff.UseVisualStyleBackColor = True
        '
        'btnAdminStudents
        '
        Me.btnAdminStudents.Location = New System.Drawing.Point(48, 111)
        Me.btnAdminStudents.Name = "btnAdminStudents"
        Me.btnAdminStudents.Size = New System.Drawing.Size(188, 43)
        Me.btnAdminStudents.TabIndex = 2
        Me.btnAdminStudents.Text = "Students"
        Me.btnAdminStudents.UseVisualStyleBackColor = True
        '
        'btnAdminRewards
        '
        Me.btnAdminRewards.Location = New System.Drawing.Point(48, 160)
        Me.btnAdminRewards.Name = "btnAdminRewards"
        Me.btnAdminRewards.Size = New System.Drawing.Size(188, 43)
        Me.btnAdminRewards.TabIndex = 3
        Me.btnAdminRewards.Text = "Rewards"
        Me.btnAdminRewards.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(159, 229)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 29)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AdminDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdminRewards)
        Me.Controls.Add(Me.btnAdminStudents)
        Me.Controls.Add(Me.btnAdminStaff)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminDirectory"
        Me.Text = "Admin Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdminStaff As System.Windows.Forms.Button
    Friend WithEvents btnAdminStudents As System.Windows.Forms.Button
    Friend WithEvents btnAdminRewards As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button

End Class
