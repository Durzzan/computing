Public Class StudentForm1

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'shows the logon form and closes the studnet form
        loginFrom.Show()
        Me.Close()
    End Sub

    Private Sub btnPassword_Click(sender As System.Object, e As System.EventArgs) Handles btnPassword.Click
        'checks if grppassword is visible
        If grpPassword.Visible = False Then
            'password changing tools are made visible
            grpPassword.Visible = True
            btnBack.Visible = True
            btnPassword.Text = "execute"
        ElseIf Encrypt(txtOldPassword.Text) = student.password.Trim Then
            'txtoldpassword is compared to the students current password. if incorrect then an error message will be
            'sent and the sub ended.
            'check the newpassword to make sure it is more then 5 characters. if it isnt then an error message will be
            'sent and the sub ended
            If Len(txtNewPassword1.Text) >= 6 Then
                'check if the new password is alphanumeric. if not then an error message will be sent and the sub ended
                If IsAlpha(txtNewPassword1.Text) = False And IsNumeric(txtNewPassword1.Text) = False Then
                    'check if the newpassword is the same as the retype. if not then an error message will be sent and
                    'the sub ended
                    If txtNewPassword1.Text = txtNewPassword2.Text Then
                        'the student password will be changed and put into the dat file
                        student.password = Encrypt(txtNewPassword1.Text.Trim)
                        PutStudent(student, student.studNO)
                        'the password changeing tools are made invisible again
                        grpPassword.Visible = False
                        btnBack.Visible = False
                        btnPassword.Text = "change password"
                        'a message is sent telling the studnet that the password has changed
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
        'the password changing tools are made invisible and reset
        grpPassword.Visible = False
        txtNewPassword1.Text = ""
        txtNewPassword2.Text = ""
        txtOldPassword.Text = ""
        btnBack.Visible = False
        btnPassword.Text = "change password"
    End Sub


    Private Sub StudentForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'puts relevent information into a lable which says who is logged on and how many points they have
        lblName.Text = "welcome " & student.Forename.Trim & " " & student.Surname.Trim & vbNewLine & "you have " & student.points & " points"

        'populate the grdrewards
        For counter As Integer = 1 To NRewards
            Dim onreward = GetReward(counter)
            If student.points > onreward.cost Then
                grdRewards.Rows.Add(onreward.RewardID, onreward.name.Trim, onreward.cost)
            End If
        Next
        'populates grdrecords with all the points procedure that protain to the student
        For counter = 1 To NpointsP
            Dim OnPointsPRec = getPointsP(counter)
            If OnPointsPRec.StudNO = student.studNO Then
                staff = GetStaff(pointsP.StaffNO)
                grdRecords.Rows.Add(staff.Surname, OnPointsPRec.pointstransfered, OnPointsPRec.reason)
            End If
        Next

    End Sub

    Private Sub grdRewards_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRewards.CellContentClick
        Dim RewardSelected As Integer
        'works out which reward was clicked on
        RewardSelected = grdRewards.Rows(e.RowIndex).Cells(0).Value
        'gets the data for the reward clicked on
        reward = GetReward(RewardSelected)
        'checks if the student is sure they want to buy the reward. 
            If MsgBox("Are you sure you would like to buy " & reward.name.Trim & " for " & reward.cost & " points", vbYesNo) = vbYes Then
            'answer was yes so the the students points total has the cost of the points deducted from it and is put
            'back into the dat file
            student.points -= reward.cost
            PutStudent(student, student.studNO)
                'refreshing lblname
                lblName.Text = "welcome " & student.Forename.Trim & " " & student.Surname.Trim & vbNewLine & "you have " & student.points & " points"
            'adding rewardsprocedure
                RewardsP.RewardID = reward.RewardID
            RewardsP.studNO = student.studNO
                NrewardsP += 1
                PutRewardP(RewardsP, NrewardsP)
            End If
    End Sub
End Class
