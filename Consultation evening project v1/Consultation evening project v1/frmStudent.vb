Public Class frmStudent

    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim correction As String
        For counter As Integer = 1 To NDay
            'get the record here


            If Daylength = 5 Then
                For counter2 As Integer = 0 To ((Day.finish = Day.Start) - 2)
                    If (Day.Start + counter2) \ 2 = Day.Start + counter2 / 2 Then correction = ":00" Else correction = ":30"
                    chklstStudent.Items.Add(((Day.Start + counter2) \ 2) + correction + " to " + (((Day.Start + counter2) \ 2) + 1) + correction, False)
                Next
            Else
                For counter2 As Integer = 0 To ((Day.finish = Day.Start) - 3)
                    If (Day.Start + counter2) \ 2 = Day.Start + counter2 / 2 Then
                        correction = ":00"
                        chklstStudent.Items.Add(((Day.Start + counter2) \ 2) + correction + " to " + (((Day.Start + counter2) \ 2) + 1) + ":30", False)
                    Else
                        correction = ":30"
                        chklstStudent.Items.Add(((Day.Start + counter2) \ 2) + correction + " to " + (((Day.Start + counter2) \ 2) + 1) + ":00", False)
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub chklstStudent_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklstStudent.SelectedValueChanged

    End Sub
End Class