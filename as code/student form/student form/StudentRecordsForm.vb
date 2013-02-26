Public Class StudentRecordsForm

    Private Sub StudentRecordsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loads relevent information like name and points into a label
        lblPoints.Text = student.Forename.Trim & " " & student.Surname.Trim & " has " & student.points & " points"

        'populates grdrecords with all the points procedures protaining to the selected student
        For counter As Integer = 1 To NpointsP
            Dim OnPointsPRec = GetPointsP(counter)
            If OnPointsPRec.StudNO = student.studNO Then
                staff = GetStaff(pointsP.StaffNO)
                grdRecords.Rows.Add(staff.Surname, OnPointsPRec.pointstransfered, OnPointsPRec.reason)
            End If
        Next
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'closes the form
        Me.Close()
    End Sub
End Class