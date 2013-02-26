<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffform
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
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.grpPassword = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword2 = New System.Windows.Forms.TextBox()
        Me.txtNewPassword1 = New System.Windows.Forms.TextBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtForname = New System.Windows.Forms.TextBox()
        Me.btnPoints = New System.Windows.Forms.Button()
        Me.grdStudents = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdPoints = New System.Windows.Forms.DataGridView()
        Me.StudID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Records = New System.Windows.Forms.Label()
        Me.lblPointsLeft = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.chkGive = New System.Windows.Forms.CheckBox()
        Me.chkTake = New System.Windows.Forms.CheckBox()
        Me.btnPointsBack = New System.Windows.Forms.Button()
        Me.Lblreason = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.grpPassword.SuspendLayout()
        CType(Me.grdStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(581, 458)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(93, 29)
        Me.btnAdmin.TabIndex = 40
        Me.btnAdmin.Text = "Admin Form"
        Me.btnAdmin.UseVisualStyleBackColor = True
        Me.btnAdmin.Visible = False
        '
        'grpPassword
        '
        Me.grpPassword.Controls.Add(Me.Label7)
        Me.grpPassword.Controls.Add(Me.Label6)
        Me.grpPassword.Controls.Add(Me.Label8)
        Me.grpPassword.Controls.Add(Me.txtOldPassword)
        Me.grpPassword.Controls.Add(Me.txtNewPassword2)
        Me.grpPassword.Controls.Add(Me.txtNewPassword1)
        Me.grpPassword.Location = New System.Drawing.Point(172, 459)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(355, 76)
        Me.grpPassword.TabIndex = 39
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "change password"
        Me.grpPassword.Visible = False
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "new password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "old password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(8, 35)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(102, 20)
        Me.txtOldPassword.TabIndex = 16
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword2
        '
        Me.txtNewPassword2.Location = New System.Drawing.Point(224, 35)
        Me.txtNewPassword2.Name = "txtNewPassword2"
        Me.txtNewPassword2.Size = New System.Drawing.Size(102, 20)
        Me.txtNewPassword2.TabIndex = 15
        Me.txtNewPassword2.UseSystemPasswordChar = True
        '
        'txtNewPassword1
        '
        Me.txtNewPassword1.Location = New System.Drawing.Point(116, 34)
        Me.txtNewPassword1.Name = "txtNewPassword1"
        Me.txtNewPassword1.Size = New System.Drawing.Size(102, 20)
        Me.txtNewPassword1.TabIndex = 14
        Me.txtNewPassword1.UseSystemPasswordChar = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(12, 463)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(130, 36)
        Me.btnChangePassword.TabIndex = 38
        Me.btnChangePassword.Text = "change password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(581, 493)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 24)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Transfer Points"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(529, 426)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(92, 20)
        Me.txtSurname.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 429)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Forename"
        '
        'txtForname
        '
        Me.txtForname.Location = New System.Drawing.Point(380, 426)
        Me.txtForname.Name = "txtForname"
        Me.txtForname.Size = New System.Drawing.Size(92, 20)
        Me.txtForname.TabIndex = 32
        '
        'btnPoints
        '
        Me.btnPoints.Location = New System.Drawing.Point(18, 422)
        Me.btnPoints.Name = "btnPoints"
        Me.btnPoints.Size = New System.Drawing.Size(92, 35)
        Me.btnPoints.TabIndex = 31
        Me.btnPoints.Text = "Execute points" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " transfer"
        Me.btnPoints.UseVisualStyleBackColor = True
        '
        'grdStudents
        '
        Me.grdStudents.AllowUserToAddRows = False
        Me.grdStudents.AllowUserToDeleteRows = False
        Me.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.grdStudents.Location = New System.Drawing.Point(326, 51)
        Me.grdStudents.Name = "grdStudents"
        Me.grdStudents.ReadOnly = True
        Me.grdStudents.Size = New System.Drawing.Size(349, 365)
        Me.grdStudents.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "StudID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Forename"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Surname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Points"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'grdPoints
        '
        Me.grdPoints.AllowUserToAddRows = False
        Me.grdPoints.AllowUserToDeleteRows = False
        Me.grdPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPoints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudID, Me.Column5, Me.Column6})
        Me.grdPoints.Location = New System.Drawing.Point(13, 163)
        Me.grdPoints.Name = "grdPoints"
        Me.grdPoints.ReadOnly = True
        Me.grdPoints.Size = New System.Drawing.Size(292, 253)
        Me.grdPoints.TabIndex = 29
        '
        'StudID
        '
        Me.StudID.HeaderText = "StudID"
        Me.StudID.Name = "StudID"
        Me.StudID.ReadOnly = True
        Me.StudID.Width = 50
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
        Me.Column6.HeaderText = "Reason"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Records
        '
        Me.Records.AutoSize = True
        Me.Records.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Records.Location = New System.Drawing.Point(322, 24)
        Me.Records.Name = "Records"
        Me.Records.Size = New System.Drawing.Size(83, 24)
        Me.Records.TabIndex = 28
        Me.Records.Text = "Students"
        '
        'lblPointsLeft
        '
        Me.lblPointsLeft.AutoSize = True
        Me.lblPointsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsLeft.Location = New System.Drawing.Point(14, 84)
        Me.lblPointsLeft.Name = "lblPointsLeft"
        Me.lblPointsLeft.Size = New System.Drawing.Size(153, 32)
        Me.lblPointsLeft.TabIndex = 27
        Me.lblPointsLeft.Text = "Welcome Joe Blogs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have 0000 points left"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(172, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 121)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Staff form"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 499)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(130, 36)
        Me.btnBack.TabIndex = 41
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(629, 422)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(59, 27)
        Me.btnSearch.TabIndex = 43
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtStudID
        '
        Me.txtStudID.Location = New System.Drawing.Point(102, 194)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(76, 20)
        Me.txtStudID.TabIndex = 44
        Me.txtStudID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "students ID"
        Me.Label2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 26)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "amount of points" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to be transfered"
        Me.Label9.Visible = False
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(102, 232)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(76, 20)
        Me.txtPoints.TabIndex = 47
        Me.txtPoints.Visible = False
        '
        'chkGive
        '
        Me.chkGive.AutoSize = True
        Me.chkGive.Checked = True
        Me.chkGive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGive.Location = New System.Drawing.Point(17, 332)
        Me.chkGive.Name = "chkGive"
        Me.chkGive.Size = New System.Drawing.Size(83, 17)
        Me.chkGive.TabIndex = 49
        Me.chkGive.Text = "To be given"
        Me.chkGive.UseVisualStyleBackColor = True
        Me.chkGive.Visible = False
        '
        'chkTake
        '
        Me.chkTake.AutoSize = True
        Me.chkTake.Location = New System.Drawing.Point(102, 332)
        Me.chkTake.Name = "chkTake"
        Me.chkTake.Size = New System.Drawing.Size(112, 17)
        Me.chkTake.TabIndex = 50
        Me.chkTake.Text = "To be taken away"
        Me.chkTake.UseVisualStyleBackColor = True
        Me.chkTake.Visible = False
        '
        'btnPointsBack
        '
        Me.btnPointsBack.Location = New System.Drawing.Point(116, 422)
        Me.btnPointsBack.Name = "btnPointsBack"
        Me.btnPointsBack.Size = New System.Drawing.Size(64, 34)
        Me.btnPointsBack.TabIndex = 51
        Me.btnPointsBack.Text = "Back"
        Me.btnPointsBack.UseVisualStyleBackColor = True
        Me.btnPointsBack.Visible = False
        '
        'Lblreason
        '
        Me.Lblreason.AutoSize = True
        Me.Lblreason.Location = New System.Drawing.Point(16, 266)
        Me.Lblreason.Name = "Lblreason"
        Me.Lblreason.Size = New System.Drawing.Size(39, 13)
        Me.Lblreason.TabIndex = 52
        Me.Lblreason.Text = "reason"
        Me.Lblreason.Visible = False
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(18, 290)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(196, 36)
        Me.txtReason.TabIndex = 53
        Me.txtReason.Visible = False
        '
        'staffform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Lblreason)
        Me.Controls.Add(Me.btnPointsBack)
        Me.Controls.Add(Me.chkTake)
        Me.Controls.Add(Me.chkGive)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStudID)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.grpPassword)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtForname)
        Me.Controls.Add(Me.btnPoints)
        Me.Controls.Add(Me.grdStudents)
        Me.Controls.Add(Me.grdPoints)
        Me.Controls.Add(Me.Records)
        Me.Controls.Add(Me.lblPointsLeft)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "staffform"
        Me.Text = "staffform"
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        CType(Me.grdStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents grpPassword As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtForname As System.Windows.Forms.TextBox
    Friend WithEvents btnPoints As System.Windows.Forms.Button
    Friend WithEvents grdStudents As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdPoints As System.Windows.Forms.DataGridView
    Friend WithEvents StudID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Records As System.Windows.Forms.Label
    Friend WithEvents lblPointsLeft As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtStudID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPoints As System.Windows.Forms.TextBox
    Friend WithEvents chkGive As System.Windows.Forms.CheckBox
    Friend WithEvents chkTake As System.Windows.Forms.CheckBox
    Friend WithEvents btnPointsBack As System.Windows.Forms.Button
    Friend WithEvents Lblreason As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
End Class
