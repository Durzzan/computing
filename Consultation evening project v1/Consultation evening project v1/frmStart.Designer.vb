﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.btnAvailability = New System.Windows.Forms.Button()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consoltation evening form"
        '
        'btnAvailability
        '
        Me.btnAvailability.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAvailability.Location = New System.Drawing.Point(136, 131)
        Me.btnAvailability.Name = "btnAvailability"
        Me.btnAvailability.Size = New System.Drawing.Size(106, 51)
        Me.btnAvailability.TabIndex = 1
        Me.btnAvailability.Text = "Enter"
        Me.btnAvailability.UseVisualStyleBackColor = True
        '
        'btnadmin
        '
        Me.btnadmin.Location = New System.Drawing.Point(136, 188)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(106, 51)
        Me.btnadmin.TabIndex = 2
        Me.btnadmin.Text = "Admin"
        Me.btnadmin.UseVisualStyleBackColor = True
        Me.btnadmin.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(279, 273)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 31)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnadmin)
        Me.Controls.Add(Me.btnAvailability)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStart"
        Me.Text = "Start form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAvailability As System.Windows.Forms.Button
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
