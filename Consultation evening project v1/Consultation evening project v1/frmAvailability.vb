Public Class frmAvailability
    Dim appointmentlength As Integer = 5
    Dim nday As Integer = 1


    Private Sub frmAvailability_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If usertype = 1 Then
            lblname.Text = "welcome " + student.Forename + " " + student.Surname
        ElseIf usertype = 2 Then
            lblname.Text = "welcome " + Staff.Forename + " " = Staff.Surname
        End If
        If Appointmentlength = 5 Then
            For counter As Integer = 1 To NDay
                Day = GetDay(counter)
                Day.Start = 0
                Day.finish = 36
                For counter2 As Integer = 0 To (Day.finish - Day.Start) \ 6 - 2
                    chklst.Items.Add("Day " + counter.ToString + " " + militarytime(Day.Start + (counter2 * 6)) + " to " + militarytime(Day.Start + 12 + (counter2 * 6)))
                Next
            Next
        Else
            For counter As Integer = 1 To NDay
                Day = GetDay(counter)
                For counter2 As Integer = 1 To (Day.finish - Day.Start) \ 6 - 3
                    chklst.Items.Add("Day " + counter.ToString + " " + militarytime(Day.Start + (counter2 * 6)) + " to " + militarytime(Day.Start + 12 + (counter2 * 6)))
                Next
            Next
        End If
    End Sub

    Private Sub chklst_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chklst.ItemCheck
        Dim parts() As String = Split(chklst.SelectedItem, " ")
        If usertype = 1 Then
            If appointmentlength = 5 Then
                For counter As Integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) To ((parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) + 12)
                    StudAv.Appointment = counter
                    StudAv.DayNO = parts(1)
                Next
            End If
        End If
    End Sub
End Class