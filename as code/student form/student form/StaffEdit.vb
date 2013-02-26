Public Class StaffEdit

    Private Sub StaffEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Adding = True Then
            'adding is true so the text boxes are empty and a new staff Number is put into lblstaffNo
            lblStaffNO.Text = Nstaff + 1
        Else
            'adding is false there for the form is in change mode so the data of the staff member selected to be changed
            'was put into the staff structure is now put into the text boxes and the text on the btn is changed to change
            btnEnd.Text = "change"
            lblStaffNO.Text = staff.staffNO
            txtStaffID.Text = staff.staffID
            txtForename.Text = staff.Forename
            txtSurname.Text = staff.Surname
            txtPointsLeft.Text = staff.PointsLeft
            txtPassword.Text = Decrypt(staff.password)
            If staff.admin = True Then
                chkAdmin.Checked = True
            End If
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'closes staffedit form and opens adminstaff
        Admin_Staff.Show()
        Me.Close()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        'checks that the length of txtstaffID is 3 or less and if not then the sub is ended and an error message sent
        If Len(txtStaffID.Text) > 3 Then
            MsgBox("the length of the id must be 3 or less")
            Exit Sub
        End If
        'checks if the staff id is made up only of letters if not then the sub is ended and an error message sent
        If IsAlpha(txtStaffID.Text) Then
            'the id is made up of only letters and is now being compared against the ID of other members of staff to
            'make sure it is unique and if it is not and it isnt due to the fact that the record is being changed then
            'the sub is ended and an error message is sent
            For counter As Integer = 1 To Nstaff
                staff = GetStaff(counter)
                If staff.staffID = txtStaffID.Text Then
                    If staff.staffNO <> lblStaffNO.Text Then
                        MsgBox("ID already in use try another")
                        Exit Sub
                    End If
                    'the id is made of letters and is unique so is being put into the staff structure
                Else : staff.staffID = txtStaffID.Text
                End If
            Next
        Else
            MsgBox("the staff id must be the intials of the member of staff")
        End If
        'the staffNo in lblstaffno is being put into the staff structure
        staff.staffNO = lblStaffNO.Text

        'checks if the forname is made up of letters if not then the sub is ended and an error message sent
        If IsName(txtForename.Text) Then
            'txtforename is ok so is put into the staff structure
            staff.Forename = txtForename.Text
        Else : MsgBox("forename must be a name")
            Exit Sub
        End If

        'checks if the surname is made of letters if not then the sub is ended and an error message sent
        If IsName(txtSurname.Text) Then
            'surname is ok so is put into the staff sturcture
            staff.Surname = txtSurname.Text
        Else : MsgBox("surname must be a name")
            Exit Sub
        End If

        'checks if the password is 6 or more letters if not then the sub is ended and an error message sent
        If Len(txtPassword.Text) > 5 Then
            'password good so is put into the staff stucture
            staff.password = Encrypt(txtPassword.Text)
        Else
            MsgBox("the password must be at least 6 symbols")
        End If

        'checks if the points left is numeric if not then an error messesage is sent and the sub ended
        If IsNumeric(txtPointsLeft.Text) Then
            'the points is ok so is put into the staff structure
            staff.PointsLeft = txtPointsLeft.Text
        Else : MsgBox("points must be a number")
            Exit Sub
        End If

        'checks if the admin check box is checked or not if true then true put into the staff structure else a false put in
        If chkAdmin.Checked = True Then
            staff.admin = True
        Else : staff.admin = False
        End If

        'staff structure put into the staff dat file
        PutStaff(staff, staff.staffNO)

        'opens the adminstaff form
        Admin_Staff.Show()

        'updates the adminstaff forms data grid
        If Adding = True Then
            Nstaff += 1
            Admin_Staff.grdStaff.Rows.Add(staff.staffNO, staff.staffID, staff.Forename, staff.Surname, staff.PointsLeft, staff.admin, Decrypt(staff.password))
        Else
            Admin_Staff.grdStaff.Rows.Clear()
            For counter As Integer = 1 To Nstaff
                staff = GetStaff(counter)
                Admin_Staff.grdStaff.Rows.Add(staff.staffNO, staff.staffID, staff.Forename, staff.Surname, staff.PointsLeft, staff.admin, Decrypt(staff.password))
            Next
        End If
        Me.Close()
    End Sub
End Class