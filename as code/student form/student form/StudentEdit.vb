Public Class StudentEdit

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'shows the adminstudent form and closes the studentedit form
        Admin_Student.Show()
        Me.Close()
    End Sub

    Private Sub StudentEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Adding = True Then
            'adding is true so the text boxes are empty and a new studnet Number is put into lblstudNo
            lblStudNO.Text = NStudents + 1
            student = GetStudent(NStudents)
            txtStudID.Text = student.studID + 1
        Else
            'adding is false there for the form is in change mode so the data of the student selected to be changed
            'was put into the student structure is now put into the text boxes and the text on the btn is changed to change
            lblStudNO.Text = student.studNO
            txtForename.Text = student.Forename
            txtSurname.Text = student.Surname
            txtStudID.Text = student.studID
            txtPoints.Text = student.points
            txtPassword.Text = Decrypt(student.password)
            btnEnd.Text = "change"
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        'checks if studID is numeric if not then an error message is sent and the sub is ended
        If IsNumeric(txtStudID.Text) = True Then
            'checks if the Id is 6 figures and positive if not then an error message is sent and the sub ended
            If Int(txtStudID.Text) > 0 And Int(txtStudID.Text) < 1000000 Then
                'checks if the studID is unique, if not then an error messages is sent and the sub is ended
                ' if it is then it is put into the studnet structure
                For counter As Integer = 1 To NStudents
                    student = GetStudent(counter)
                    If student.studID = Int(txtStudID.Text) Then
                        If student.studNO <> lblStudNO.Text Then
                            MsgBox("ID already in use try another")
                            Exit Sub
                        End If
                    Else : student.studID = Int(txtStudID.Text)
                    End If
                Next
            Else : MsgBox("the id must be greater then 0 and less then 1000000")
                Exit Sub
            End If
        Else : MsgBox("the Id must be a number")
            Exit Sub
        End If

        'checks if the forname is a name. if not then an error message is sent and the sub is ended
        'if so it is put into the student structure
        If IsName(txtForename.Text) Then
            student.Forename = txtForename.Text
        Else : MsgBox("forename must be a name")
            Exit Sub
        End If

        'checks if the surname is a name. if not then an error message is sent and the sub is ended
        'if so it is put into the student structure
        If IsName(txtSurname.Text) Then
            student.Surname = txtSurname.Text
        Else : MsgBox("surname must be a name")
            Exit Sub
        End If

        'checks if the password is greater then 5 characters if not then an error message is sent and the sub ended
        'if so it is put into the student structure
        If Len(txtPassword.Text) > 5 Then
            student.password = Encrypt(txtPassword.Text)
        Else
            MsgBox("the password must be at least 6 characters")
            Exit Sub
        End If

        'checks if the points are numeric if not then an error message is sent and the sub ended
        'if so it is put into the student structure
        If IsNumeric(txtPoints.Text) Then
            student.points = txtPoints.Text
        Else : MsgBox("points must be a number")
            Exit Sub
        End If

        'lblstudNo is put into the student structure
        student.studNO = lblStudNO.Text

        'the student structure is put into the studnet dat file
        PutStudent(student, student.studNO)

        'refeshes grdstudents on adminstudnet
        If Adding = True Then
            NStudents += 1
            Admin_Student.grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points, Decrypt(student.password))
        Else
            Admin_Student.grdStudents.Rows.Clear()
            For counter As Integer = 1 To NStudents
                student = GetStudent(counter)
                Admin_Student.grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points, Decrypt(student.password))
            Next
        End If

        'closes the form
        Me.Close()
    End Sub
End Class