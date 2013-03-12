<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaySettings
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
        Me.cmbNdays = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.rad5min = New System.Windows.Forms.RadioButton()
        Me.rad10min = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cmbNdays
        '
        Me.cmbNdays.FormattingEnabled = True
        Me.cmbNdays.Location = New System.Drawing.Point(55, 66)
        Me.cmbNdays.Name = "cmbNdays"
        Me.cmbNdays.Size = New System.Drawing.Size(121, 21)
        Me.cmbNdays.TabIndex = 0
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(55, 151)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(121, 21)
        Me.cmbDay.TabIndex = 1
        '
        'rad5min
        '
        Me.rad5min.AutoSize = True
        Me.rad5min.Location = New System.Drawing.Point(55, 93)
        Me.rad5min.Name = "rad5min"
        Me.rad5min.Size = New System.Drawing.Size(55, 17)
        Me.rad5min.TabIndex = 4
        Me.rad5min.TabStop = True
        Me.rad5min.Text = "5 mins"
        Me.rad5min.UseVisualStyleBackColor = True
        '
        'rad10min
        '
        Me.rad10min.AutoSize = True
        Me.rad10min.Location = New System.Drawing.Point(55, 116)
        Me.rad10min.Name = "rad10min"
        Me.rad10min.Size = New System.Drawing.Size(61, 17)
        Me.rad10min.TabIndex = 5
        Me.rad10min.TabStop = True
        Me.rad10min.Text = "10 mins"
        Me.rad10min.UseVisualStyleBackColor = True
        '
        'frmDaySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 324)
        Me.Controls.Add(Me.rad10min)
        Me.Controls.Add(Me.rad5min)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.cmbNdays)
        Me.Name = "frmDaySettings"
        Me.Text = "frmDaySettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbNdays As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents rad5min As System.Windows.Forms.RadioButton
    Friend WithEvents rad10min As System.Windows.Forms.RadioButton
End Class
