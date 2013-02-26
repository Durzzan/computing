Public Class loginFrom

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'student part from class staff part based on it.
        Dim onrec As Integer = 0
        'checks if a username was inputed if not then ends sub and sends error message
        If txtUsername.Text.Trim = "" Then
            MsgBox("error please enter username")
            Exit Sub
            'checks if a password was inputed if not then ends sub and sends error message
        ElseIf txtPassword.Text.Trim = "" Then
            MsgBox("error please enter password")
            Exit Sub
            'checks if the username is numeric if so then the username is form as student if not its a member of staff
        ElseIf IsNumeric(txtUsername.Text.Trim) = True Then
            'username was numeric so checks the username against that of all the students
            Try
                Do
                    onrec += 1
                    student = GetStudent(onrec)
                    If Val(txtUsername.Text) = student.studID Then
                        'found student that matches the username so checks if the password matches
                        If txtPassword.Text.Trim = Decrypt(student.password.Trim) Then
                            'password was correct so student form opens and logon form opens
                            StudentForm1.Show()
                            Me.Close()
                            Exit Sub
                        Else
                            'password did not match so error message sent and sub ended
                            MsgBox("invalid password")
                            Exit Sub
                        End If
                    End If

                Loop
            Catch ex As Exception
                'nothing found so error message sent and sub ended
                MsgBox("invalid username")
            End Try
        ElseIf IsAlpha(txtUsername.Text) = True Then
            'username was a word so it is compared againts that of all the staff
            Try
                Do
                    onrec += 1
                    staff = GetStaff(onrec)
                    If txtUsername.Text.Trim.ToUpper = staff.staffID.Trim.ToUpper Then
                        'found member of staff so checking to see if the passwords match
                        If txtPassword.Text.Trim = Decrypt(staff.password.Trim) Then
                            'staff's password matches so staffform opens and logonform closes 
                            staffform.Show()
                            Me.Hide()
                            Exit Sub
                        Else
                            'passwords did not match so error message sent and sub ended
                            MsgBox("invalid password")
                            Exit Sub
                        End If
                    End If

                Loop
            Catch ex As Exception
                ' matching logon not found so error message sent and sub ended
                MsgBox("invalid username")
            End Try
        Else
            'nothing found so error message sent and sub ended
            MsgBox("invalid username")
        End If
    End Sub

    Private Sub loginFrom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'from class

        'checks if the dat files for the staff, students and rewards has been created if not then they are
        If My.Computer.FileSystem.FileExists("Student.dat") = False Then Call ImportStudents()
        If My.Computer.FileSystem.FileExists("staff.dat") = False Then Call ImportStaff()
        If My.Computer.FileSystem.FileExists("rewards.dat") = False Then Call ImportRewards()

        'intialises global variables for numbers of data structures
        NRewards = FileLen("Rewards.dat") / Len(reward)
        Nstaff = FileLen("staff.dat") / Len(staff)
        NStudents = FileLen("student.dat") / Len(student)
        NrewardsP = FileLen("Rewardsprocedure.dat") / Len(RewardsP)
        NpointsP = FileLen("pointsprocedure.dat") / Len(pointsP)

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'close logonform closing the program
        Me.Close()
    End Sub

    
End Class