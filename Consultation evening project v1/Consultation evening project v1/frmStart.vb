Public Class frmStart

    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'splits up the user data to seperate out the users username
        Dim parts() As String = Split(My.User.Name, "\")
        user = parts(1)
        If Len(user) = 6 Then
            For counter As Integer = 1 To Nstudents
                student = GetStudent(counter)
                If user = student.StudID Then
                    usertype = 1
                    Exit For
                End If
            Next
        Else
            For counter = 1 To Nstaff
                Staff = GetStaff(counter)
                If user = Staff.staffID Then
                    usertype = 2
                    If Staff.admin = True Then
                        btnAvailability.Text = "Your Availability"
                        btnadmin.Visible = True
                    End If
                End If
            Next
        End If

        If usertype = 0 Then
            btnAvailability.Visible = False
            MsgBox("Your username is not recognised by the system. If this is an error please contact the it technicians.", , "ERROR")

        End If


    End Sub

    Private Sub btnAvailability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvailability.Click
        'checks if the user files are empty
        If FileLen("Staff.dat") = 0 And IsNumeric(user) = False Then
            frmAdmin.Show()
            Me.Hide()
        Else
            If usertype = 1 Then
                frmStudent.Show()
                Me.Close()
            ElseIf usertype = 2 Then
                frmStaff.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnadmin_Click(sender As System.Object, e As System.EventArgs) Handles btnadmin.Click
        frmAdmin.Show()
        Me.Close()
    End Sub
End Class