Public Class AdminDirectory

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        'opens staffform and closes admindirectory
        staffform.Show()
        Me.Close()
    End Sub

    Private Sub btnAdminStaff_Click(sender As System.Object, e As System.EventArgs) Handles btnAdminStaff.Click
        'opens admin_staff and hides adminDirectory
        Admin_Staff.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminStudents.Click
        'opens admin_students and hides adminDirectory
        Admin_Student.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminRewards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminRewards.Click
        'opens admin_rewards and hides adminDirectory
        Admin_Rewards.Show()
        Me.Hide()
    End Sub
End Class
