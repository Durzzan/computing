Public Class frmDaySettings

    Private Sub rad5min_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad5min.CheckedChanged
        'checks if the the 5 min radio button is checked and if it is sets the appointmetn length to 5 mins
        'otherwise it sets the appointment length to 10 mins
        If rad5min.Checked = True Then
            Appointmentlength = 5
        Else
            Appointmentlength = 10
        End If
    End Sub

    Private Sub frmDaySettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For counter As Integer = 1 To 255
            cmbNdays.Text.Insert(counter, counter)
        Next
    End Sub
End Class