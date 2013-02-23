Public Class frmStart
    
    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'splits up the user data to seperate out the users username
        Dim parts() As String = Split(My.User.Name, "\")
        user = parts(1)
    End Sub

    Private Sub btnAvailability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvailability.Click
        'checks whether the user is a student to decide what form the user will be sent to.
        If IsNumeric(user) = True Then
            frmStudent.Show()
            Me.Hide()
        Else
            frmStaff.Show()
            Me.Hide()
        End If
    End Sub
End Class