Public Class Admin_Student

    Private Sub Admin_Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populates grdstudent
        For counter As Integer = 1 To NStudents
            student = GetStudent(counter)
            grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points, Decrypt(student.password))
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim counter As Integer
        'checks if there is a word in txtforename, serves as presence check and word check
        If IsAlpha(txtForname.Text.Trim) = True Then
            'checks if there is a word in txtsurname, serves as presence check and word check
            If IsAlpha(txtSurname.Text.Trim) = True Then
                'clears grdstudnets populates the grdstudents with only students whose first name starts with the 
                'text in txtforename and whose last name starts with the text in txtsurname
                grdStudents.Rows.Clear()
                For counter = 1 To NStudents
                    student = GetStudent(counter)
                    If student.Forename.ToUpper.StartsWith(txtForname.Text.Trim.ToUpper) And student.Surname.ToUpper.StartsWith(txtSurname.Text.ToUpper.Trim) Then
                        grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points, Decrypt(student.password))
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
                        grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points, Decrypt(student.password))
                    End If
                Next
                'txtstudent contains invalid data so error message sent
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
                        grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points, Decrypt(student.password))
                    End If
                Next
                'if neither box contains letters
            ElseIf txtSurname.Text = "" Then
                'clears grdstudents then populates it with all students
                grdStudents.Rows.Clear()
                For counter = 1 To NStudents
                    student = GetStudent(counter)
                    grdStudents.Rows.Add(student.studID, student.Forename.Trim, student.Surname.Trim, student.points, Decrypt(student.password))
                Next
                'txtsurname contains invalid data so error message sent
            Else : MsgBox("surname must be only letters with no spaces")
            End If
            'txtforname contains invalid data so error message sent
        Else : MsgBox("the forename must be only letters with no spaces")
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'show admin directory and close adminStudent form
        AdminDirectory.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'sets global variable adding to true so that studentedit will open in adding mode then opens studentedit
        Adding = True
        StudentEdit.Show()

    End Sub

    Private Sub grdStudents_CellContentdoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStudents.CellContentClick
        Dim ID As Integer
        'intialise variable but if it doesnt work because content sellected is a header it will exit sub
        Try
            ID = grdStudents.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
            Exit Sub
        End Try
        'compares the studID of each student against the one in the row that was clicked on till a match is found.
        For counter As Integer = 1 To NStudents
            student = GetStudent(counter)
            If student.studID = ID Then
                'match has been found so global variable adding set to false so that studentedit will open in change
                'mode then opens studentedit
                Adding = False
                StudentEdit.Show()
                Exit Sub
            End If
        Next
    End Sub
End Class