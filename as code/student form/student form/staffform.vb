Public Class staffform

    Private Sub staffform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'puts relevent information into a lable which says who is logged on and how many points they have
        lblPointsLeft.Text = "welcome " & staff.Forename.Trim & " " & staff.Surname.Trim & vbNewLine & "you have " & staff.PointsLeft & " points left"

        'checks weather the staff are admin, if they are it makes the button that will take the member of staff to the
        'admin form visible
        If staff.admin = True Then btnAdmin.Visible = True

        'populates the grdpoints with all the different pointsprocedures that the staff member has been apart of
        For counter As Integer = 1 To NpointsP
            pointsP = GetPointsP(counter)
            If pointsP.StaffNO = staff.staffNO Then
                student = GetStudent(pointsP.StudNO)
                grdPoints.Rows.Add(student.studID, pointsP.pointstransfered, pointsP.reason)
            End If
        Next

        'populates the grdstudents with all the students
        For counter = 1 To NStudents
            student = GetStudent(counter)
            grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points)
        Next
    End Sub

    Private Sub btnchangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click
        'checks if the password boxes are visible
        If grpPassword.Visible = False Then
            'they arent so that is changed also the btnchangepassword has its text changed to execute
            grpPassword.Visible = True
            btnBack.Visible = True
            btnChangePassword.Text = "execute"
        ElseIf Encrypt(txtOldPassword.Text) = staff.password.Trim Then
            'the password boxes are visible so it checks if txtoldpassword is the same as the member of
            'staffs current password. if not then error message sent and sub ended
            'it then checks if the new password has greater then 5 characters if not then error message sent and sub ended
            If Len(txtNewPassword1.Text) >= 6 Then
                'it then checks if the new password is alpha numeric if not then an error message is sent and sub ended
                If IsAlpha(txtNewPassword1.Text) = False And IsNumeric(txtNewPassword1.Text) = False Then
                    'it then checks if the retype of the new password is the same as the first type. if not then
                    'an error message is sent and the sub ended
                    If txtNewPassword1.Text = txtNewPassword2.Text Then
                        'the new password checked out so it is put into staff structure and that is put into the staff dat
                        'file, the password changeing tools are then made invisible and a message box then notifys
                        'the member of staff that the password has been changed
                        staff.password = Encrypt(txtNewPassword1.Text.Trim)
                        PutStaff(staff, staff.staffNO)
                        grpPassword.Visible = False
                        btnBack.Visible = False
                        btnChangePassword.Text = "change password"
                        MsgBox("password changed")
                    Else : MsgBox("your repeat of your new password does not match that of your intial input")
                    End If
                Else : MsgBox("your password must be alpha numeric")
                End If
            Else : MsgBox("your password must be at least 6 characters")
            End If
        Else : MsgBox("you have incorrectly input your old password")
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'makes all the different password changeing tools invisible and refreshes the text boxs and 
        'changes the text of btnchangepassword to change password
        grpPassword.Visible = False
        txtNewPassword1.Text = ""
        txtNewPassword2.Text = ""
        txtOldPassword.Text = ""
        btnBack.Visible = False
        btnChangePassword.Text = "change password"
    End Sub

  
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'makes logonform visible and close staffform
        loginFrom.Visible = True
        Me.Close()
    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim counter As Integer
        'checks if there is a word in txtforename, serves as presence check and word check
        If IsAlpha(txtForname.Text.Trim) = True Then
            'checks if there is a word in txtsurname, serves as presence check and word check
            If IsAlpha(txtSurname.Text.Trim) = True Then
                'clears grdstudents populates grdstudents with only students whose first name starts with the 
                'text in txtforename and whose last name starts with the text in txtsurname
                grdStudents.Rows.Clear()
                For counter = 1 To NStudents
                    student = GetStudent(counter)
                    If student.Forename.ToUpper.StartsWith(txtForname.Text.Trim.ToUpper) And student.Surname.ToUpper.StartsWith(txtSurname.Text.ToUpper.Trim) Then
                        grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points)
                    End If
                Next

                'if only the forname box contains letters and txtsurname is empty
            ElseIf txtSurname.Text = "" Then
                'clears grdstudents then populates the grdstudents with only students whose first name 
                'starts with the text in txtforename
                grdStudents.Rows.Clear()
                For counter = 1 To NStudents
                    student = GetStudent(counter)
                    If student.Forename.ToUpper.StartsWith(txtForname.Text.Trim.ToUpper) Then
                        grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points)
                    End If
                Next
                'txtsurname contains invalid data so error message sent
            Else : MsgBox("the surname must be only letters with no spaces")
            End If
        ElseIf txtForname.Text = "" Then
            'checks if there is a word in txtsurname, serves as presence check and word check
            If IsAlpha(txtSurname.Text) = True Then
                'clears grdstudents then populates the grdstudents with only students whose second name 
                'starts with the text in txtsurname
                grdStudents.Rows.Clear()
                For counter = 1 To NStudents
                    student = GetStudent(counter)
                    If student.Surname.ToUpper.StartsWith(txtSurname.Text.Trim.ToUpper) Then
                        grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points)
                    End If
                Next
                'if neither box contains letters
            ElseIf txtSurname.Text = "" Then
                'clears grdstudents then populates it with all students
                grdStudents.Rows.Clear()
                For counter = 1 To NStudents
                    student = GetStudent(counter)
                    grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points)
                Next
                'txtsurname contains invalid data so error message sent
            Else : MsgBox("surname must be only letters with no spaces")
            End If
            'txtforname contains invalid data so error message sent
        Else : MsgBox("the forename must be only letters with no spaces")
        End If
    End Sub

    Private Sub grdStudents_CellContentdoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStudents.CellContentClick
        Dim ID As Integer
        'intialise variable but if it doesnt work because content selected is a header it will exit sub
        Try
            ID = grdStudents.Rows(e.RowIndex).Cells(0).Value
        Catch
            Exit Sub
        End Try
        'gets student by comparing the ID in the row against the studID of each student till a match is made
        For counter As Integer = 1 To NStudents
            student = GetStudent(counter)
            If student.studID = ID Then
                'match found student records form opens
                StudentRecordsForm.Show()
                Exit Sub
            End If
        Next
    End Sub


    Private Sub btnPoints_Click(sender As System.Object, e As System.EventArgs) Handles btnPoints.Click
        Dim counter As Integer
        'checks if grid points is visible
        If grdPoints.Visible = True Then
            'grdpoints is visible so it is made invisible and all the different points transfer tools are made
            'visible
            grdPoints.Visible = False
            btnPointsBack.Visible = True
            txtStudID.Visible = True
            txtPoints.Visible = True
            Label2.Visible = True
            Label9.Visible = True
            chkGive.Visible = True
            chkTake.Visible = True
            Lblreason.Visible = True
            txtReason.Visible = True
            lblPointsLeft.Text = "welcome " & staff.Forename.Trim & " " & staff.Surname.Trim & vbNewLine & "you have " & staff.PointsLeft & " points left"
        ElseIf grdPoints.Visible = False Then
            'grdpoints isnt visible so txtstudId is checked if it is numeric. if not then an error message is sent and
            'the sub ended
            If IsNumeric(txtStudID.Text) Then
                'checks if the txtpoints is numberic. if not then an error message is sent and the sub ended
                If IsNumeric(txtPoints.Text) Then
                    'checks if there is a reason inputed. if not then an error message is sent and the sub ended
                    If txtReason.Text <> "" Then
                        'checks whether the staff member is giving points or not
                        If chkGive.Checked = True Then
                            'give points was checked so it is checked wether the member of staff has enough points to give
                            'the amount they want to. if they dont then an error message is sent and the sub ended
                            If staff.PointsLeft >= txtPoints.Text Then
                                'the member of staff does have enough points so the records of the student who is
                                'being given the points is gotten
                                For counter = 1 To NStudents
                                    student = GetStudent(counter)
                                    If student.studID = txtStudID.Text Then
                                        Exit For
                                    End If
                                Next
                                'the student is given the points
                                student.points += txtPoints.Text
                                'the students edited records are put into the student dat file
                                PutStudent(student, student.studNO)
                                'the points are then taken away from the staffs points
                                staff.PointsLeft -= txtPoints.Text
                                'the staff members edited records are put into the staff dat file
                                PutStaff(staff, staff.staffNO)
                                'the data is put into the pointsprocedure structure
                                NpointsP += 1
                                pointsP.StaffNO = staff.staffNO
                                pointsP.StudNO = student.studNO
                                pointsP.reason = txtReason.Text
                                pointsP.pointstransfered = txtPoints.Text
                                'the data in the points procedure structure is transfered to the pointsprocedure dat file
                                PutPointsP(pointsP, NpointsP)
                                ' a message box notifies the member of staff that the transfer is complete
                                MsgBox("points transfered")
                                'grdpoints is made visible again and the pointsprocedure tools are made invisible
                                grdPoints.Visible = True
                                btnPointsBack.Visible = False
                                txtStudID.Visible = False
                                txtPoints.Visible = False
                                Label2.Visible = False
                                Label9.Visible = False
                                chkGive.Visible = False
                                chkTake.Visible = False
                                Lblreason.Visible = False
                                txtReason.Visible = False
                                txtReason.Text = ""
                                txtPoints.Text = ""
                                txtStudID.Text = ""
                                'lblPointsLeft is refreshed
                                lblPointsLeft.Text = "welcome " & staff.Forename.Trim & " " & staff.Surname.Trim & vbNewLine & "you have " & staff.PointsLeft & " points left"
                                'grdpoints is updated
                                grdPoints.Rows.Clear()
                                For counter = 1 To NpointsP
                                    pointsP = GetPointsP(counter)
                                    If pointsP.StaffNO = staff.staffNO Then
                                        student = GetStudent(pointsP.StudNO)
                                        grdPoints.Rows.Add(student.studID, pointsP.pointstransfered, pointsP.reason)
                                    End If
                                Next
                                'grdstudents is updated
                                grdStudents.Rows.Clear()
                                For counter = 1 To NStudents
                                    student = GetStudent(counter)
                                    grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points)
                                Next
                            Else : MsgBox("you do not have enough points left")
                            End If
                        Else
                            'points are being deducted
                            'gets the records of the student the points are being deducted from
                            For counter = 1 To NStudents
                                student = GetStudent(counter)
                                If student.studID = txtStudID.Text Then
                                    Exit For
                                End If
                            Next
                            'checks if the student has less points then the amount being deducted if so then students
                            'points become 0 instead of a minus number
                            If txtPoints.Text > student.points Then
                                student.points = 0
                            Else
                                student.points -= txtPoints.Text
                            End If
                            'students edited data is put into the studnet dat file
                            PutStudent(student, student.studNO)
                            'relevent data is put into the points procedure structure
                            NpointsP += 1
                            pointsP.StaffNO = staff.staffNO
                            pointsP.StudNO = student.studNO
                            pointsP.reason = txtReason.Text
                            pointsP.pointstransfered = -(txtPoints.Text)
                            'data is from the pointsprocedure structure is put into the pointsprocedure dat file
                            PutPointsP(pointsP, NpointsP)
                            'a message is sent notifying staff member that points transfer has been completed
                            MsgBox("points deducted")
                            'grdpoints is made visible and the points transfer tools are made inivisible
                            grdPoints.Visible = True
                            btnPointsBack.Visible = False
                            txtStudID.Visible = False
                            txtPoints.Visible = False
                            Label2.Visible = False
                            Label9.Visible = False
                            chkGive.Visible = False
                            chkTake.Visible = False
                            Lblreason.Visible = False
                            txtReason.Visible = False
                            txtReason.Text = ""
                            txtPoints.Text = ""
                            txtStudID.Text = ""
                            'grdpoints are refreshed
                            grdPoints.Rows.Clear()
                            For counter = 1 To NpointsP
                                pointsP = GetPointsP(counter)
                                If pointsP.StaffNO = staff.staffNO Then
                                    student = GetStudent(pointsP.StudNO)
                                    grdPoints.Rows.Add(student.studID, pointsP.pointstransfered, pointsP.reason)
                                End If
                            Next
                            'grdstudents are refreshed
                            grdStudents.Rows.Clear()
                            For counter = 1 To NStudents
                                student = GetStudent(counter)
                                grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points)
                            Next
                        End If
                    Else : MsgBox("there must be a reason")
                    End If
                Else : MsgBox("the points must be a number")
                End If
            Else : MsgBox("the student ID must be a number")
            End If
        End If



    End Sub


    Private Sub btnPointsBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPointsBack.Click
        'hides the change password tools
        grdPoints.Visible = True
        btnPointsBack.Visible = False
        txtStudID.Visible = False
        txtPoints.Visible = False
        Label2.Visible = False
        Label9.Visible = False
        chkGive.Visible = False
        chkTake.Visible = False
        Lblreason.Visible = False
        txtReason.Visible = False
        txtStudID.Text = ""
        txtPoints.Text = ""
        txtReason.Text = ""
    End Sub

    Private Sub chkGive_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGive.CheckedChanged
        'makes sure only one of the check boxes can be checked at one time
        If chkGive.Checked = True Then
            chkTake.Checked = False
        Else : chkTake.Checked = True
        End If
    End Sub

    Private Sub chkTake_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTake.CheckedChanged
        'makes sure only one of the check boxes can be checked at one time
        If chkTake.Checked = True Then
            chkGive.Checked = False
        Else : chkGive.Checked = True
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As System.Object, e As System.EventArgs) Handles btnAdmin.Click
        'opens the admin directory form and hides the staffform
        AdminDirectory.Show()
        Me.Hide()

    End Sub
End Class