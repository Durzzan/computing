<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.grdRewards = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdRecords = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.txtNewPassword1 = New System.Windows.Forms.TextBox()
        Me.txtNewPassword2 = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpPassword = New System.Windows.Forms.GroupBox()
        Me.Rewards = New System.Windows.Forms.GroupBox()
        Me.grpRecords = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.grdRewards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPassword.SuspendLayout()
        Me.Rewards.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "student form"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(27, 87)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(133, 32)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Welcome Joe Blogs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have 0000 points"
        '
        'grdRewards
        '
        Me.grdRewards.AllowUserToAddRows = False
        Me.grdRewards.AllowUserToDeleteRows = False
        Me.grdRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRewards.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colPrice})
        Me.grdRewards.Location = New System.Drawing.Point(10, 25)
        Me.grdRewards.Name = "grdRewards"
        Me.grdRewards.ReadOnly = True
        Me.grdRewards.Size = New System.Drawing.Size(245, 196)
        Me.grdRewards.TabIndex = 7
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 50
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rewards"
        '
        'grdRecords
        '
        Me.grdRecords.AllowUserToAddRows = False
        Me.grdRecords.AllowUserToDeleteRows = False
        Me.grdRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.grdRecords.Location = New System.Drawing.Point(13, 21)
        Me.grdRecords.Name = "grdRecords"
        Me.grdRecords.ReadOnly = True
        Me.grdRecords.Size = New System.Drawing.Size(347, 319)
        Me.grdRecords.TabIndex = 9
        '
        'Column4
        '
        Me.Column4.HeaderText = "Teacher"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Points"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "reason"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(569, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPassword
        '
        Me.btnPassword.Location = New System.Drawing.Point(12, 378)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(130, 37)
        Me.btnPassword.TabIndex = 12
        Me.btnPassword.Text = "change password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'txtNewPassword1
        '
        Me.txtNewPassword1.Location = New System.Drawing.Point(116, 35)
        Me.txtNewPassword1.Name = "txtNewPassword1"
        Me.txtNewPassword1.Size = New System.Drawing.Size(102, 20)
        Me.txtNewPassword1.TabIndex = 14
        Me.txtNewPassword1.UseSystemPasswordChar = True
        '
        'txtNewPassword2
        '
        Me.txtNewPassword2.Location = New System.Drawing.Point(224, 35)
        Me.txtNewPassword2.Name = "txtNewPassword2"
        Me.txtNewPassword2.Size = New System.Drawing.Size(102, 20)
        Me.txtNewPassword2.TabIndex = 15
        Me.txtNewPassword2.UseSystemPasswordChar = True
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(8, 35)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(102, 20)
        Me.txtOldPassword.TabIndex = 16
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "old password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "new password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "repeat new password"
        '
        'grpPassword
        '
        Me.grpPassword.Controls.Add(Me.Label7)
        Me.grpPassword.Controls.Add(Me.Label6)
        Me.grpPassword.Controls.Add(Me.Label5)
        Me.grpPassword.Controls.Add(Me.txtOldPassword)
        Me.grpPassword.Controls.Add(Me.txtNewPassword2)
        Me.grpPassword.Controls.Add(Me.txtNewPassword1)
        Me.grpPassword.Location = New System.Drawing.Point(152, 372)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(355, 76)
        Me.grpPassword.TabIndex = 20
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "change password"
        Me.grpPassword.Visible = False
        '
        'Rewards
        '
        Me.Rewards.Controls.Add(Me.grdRewards)
        Me.Rewards.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rewards.Location = New System.Drawing.Point(2, 137)
        Me.Rewards.Name = "Rewards"
        Me.Rewards.Size = New System.Drawing.Size(270, 235)
        Me.Rewards.TabIndex = 21
        Me.Rewards.TabStop = False
        Me.Rewards.Text = "Rewards"
        '
        'grpRecords
        '
        Me.grpRecords.Controls.Add(Me.grdRecords)
        Me.grpRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRecords.Location = New System.Drawing.Point(293, 12)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Size = New System.Drawing.Size(370, 360)
        Me.grpRecords.TabIndex = 22
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "Records"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 416)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(130, 32)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'StudentForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.Rewards)
        Me.Controls.Add(Me.grpPassword)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentForm1"
        Me.Text = "student interface form"
        CType(Me.grdRewards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        Me.Rewards.ResumeLayout(False)
        Me.grpRecords.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents grdRewards As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grdRecords As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPassword As System.Windows.Forms.Button
    Friend WithEvents txtNewPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpPassword As System.Windows.Forms.GroupBox
    Friend WithEvents Rewards As System.Windows.Forms.GroupBox
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
