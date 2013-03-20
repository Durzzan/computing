Public Class frmDaySettings

    Private Sub rad5min_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad5min.CheckedChanged
        'checks if the the 5 min radio button is checked and if it is sets the appointmetn length to 5 mins
        'otherwise it sets the appointment length to 10 mins
        If rad5min.Checked = True Then
            Appointmentlength = 5
        Else
            Appointmentlength = 10
        End If

        Call secondhalf()
    End Sub

    Private Sub frmDaySettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'populates the dropdown combobox with numbers 1 to 255
        For counter As Integer = 1 To 255
            cmbNdays.Items.Add(counter)
        Next
    End Sub

    Private Sub cmbNdays_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNdays.SelectedIndexChanged
        'records the number of dayz
        NDay = cmbNdays.SelectedItem

        Call secondhalf()


    End Sub

    Public Sub secondhalf()
        'sub to check if the appointment length and day numbers have been chosen. if so it populates the
        'day.dat file
        If NDay <> -1 And Appointmentlength <> -1 Then
            For counter As Integer = 1 To NDay
                Day.DayNO = counter
                Day.Start = 0
                Day.finish = 287
                Putday(Day, counter)
            Next
        Else
            Exit Sub
        End If

        cmbDay.Visible = True
        cmbStart.Visible = True
        cmbEnd.Visible = True

        'populates the day selector combo box with each of the days
        cmbDay.Items.Clear()
        For counter = 1 To NDay
            cmbDay.Items.Add(counter)
        Next
    End Sub

    Private Sub rad10min_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rad10min.CheckedChanged
        'records the new value of appintment length and checks if its ready to start hte second half
        Appointmentlength = 10
        Call secondhalf()
    End Sub

    Private Sub cmbDay_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDay.SelectedIndexChanged
        Call populateStartEndDaySettings()
    End Sub

    Private Sub cmbStart_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbStart.SelectedIndexChanged
        Dim hours As Integer = (cmbStart.SelectedItem) \ 100
        Dim minuets As Integer = ((cmbStart.SelectedItem) - (((cmbStart.SelectedItem) \ 100) * 100)) / 5
        Day.Start = (hours * 12) + minuets
        Call populateStartEndDaySettings()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class