<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.chklstStudent = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'chklstStudent
        '
        Me.chklstStudent.FormattingEnabled = True
        Me.chklstStudent.Location = New System.Drawing.Point(92, 94)
        Me.chklstStudent.Name = "chklstStudent"
        Me.chklstStudent.Size = New System.Drawing.Size(120, 94)
        Me.chklstStudent.TabIndex = 0
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 341)
        Me.ControlBox = False
        Me.Controls.Add(Me.chklstStudent)
        Me.Name = "frmStudent"
        Me.Text = "Availability checklist"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chklstStudent As System.Windows.Forms.CheckedListBox
End Class
