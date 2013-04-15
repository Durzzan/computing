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
        if chklst.selecteditem.checked = true then
		If usertype = 1 Then
            		If appointmentlength = 5 Then
                		For counter As Integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) To ((parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) + 5)
					for counter1 as integer = 0 to nstudav
						getstudav(counter1)
						if studav.studNO = stud.studno and studAV.appoinment = counter and studAV.day = parts(1) then
							exit for
						end if
					next
					StudAv.available = true
                    			StudAv.block += 1
					putstudav(studav, studav.studavno)
                		Next
                		for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) + 6 to ((parts(2) \ 100) + (((parts(2)) - (((parts(3)) \ 100) * 100)) / 5) + 11)
					for counter1 as integer = 0 to nstudav
						getstudav(counter1)
						if studav.studNO = stud.studno and studav.appoinment = counter and studAv.dayno = parts(1) then
							exit for
						end if
					next
					studav.available = true
					studav.block +=2
					putstudav(studav, studav.studavno)
				next
			else
				for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) to ((parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) + 4) step 2
					for counter1 as integer = 0 to nstudav
						getstudav(counter1)
						if studav.studNO = stud.studno and studav.appoinment = counter and studav.dayno = parts(1)then
							exit for
						end if
					next
					studav.available = true
					studav.block += 1
					putstudav(studav, studav.studavno)
				next
				for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) *100)) / 5)+ 6 to ((parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) *100)) / 5) + 10) step 2
            				for counter1 as integer = 0 to nstudav
						getstudav(counter1)
						if studav.studno = stud.studno and studav.appointment = counter and studav.dayno = parts(1) then
							exit for
						end if
					next
					studav.available = true
					studav.block += 2
					putstudav(studav, studav.studavno)
				next
				for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts2)) \ 100) * 100)) / 5) + 12 to ((parts(2) \100 + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) +16) step 2
					for counter1 as integer = 0 to nstudav
						getstdav(counter1)
						if studav.studno = stud.studno and studav.appointment = counter and studav.dayno = parts(1) then
							exit for
						end if
					next 
					studav.abailable = true
					studav.block += 4
					putstudav(studav, studav.studavno)
				next
			End If
		else
			If appointmentlength = 5 Then
				For counter As Integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) To ((parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) + 5)			
 					for counter1 as integer = 0 to nstudav
						getstudav(counter1)
						if studav.studNO = stud.studno and studAV.appoinment = counter and studAV.day = parts(1) then
							EXIT FOR
						end if
					next
					StudAv.available = true 
					StudAv.block += 1	
					putstudav(studav, studav.studavno)                
				Next                	
				for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) + 6 to ((parts(2) \ 100) + (((parts(2)) - (((parts(3)) \ 100) * 100)) / 5) + 11)				
					for counter1 as integer = 0 to nstudav						getstudav(counter1)					
						if studav.studNO = stud.studno and studav.appoinment = counter and studAv.dayno = parts(1) then							
							exit for					
						end if					
					next					
					studav.available = true					
					studav.block +=2					
					putstudav(studav, studav.studavno)				
				next			
			else				
				for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) to ((parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) + 4) step 2				
					for counter1 as integer = 0 to nstudav						
						getstudav(counter1)						
						if studav.studNO = stud.studno and studav.appoinment = counter and studav.dayno = parts(1)then							
							exit for						
						end if					
					next					
					studav.available = true					
					studav.block += 1					
					putstudav(studav, studav.studavno)				
				next				
				for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) *100)) / 5)+ 6 to ((parts(2) \ 100) + (((parts(2)) - (((parts(2)) \ 100) *100)) / 5) + 10) step 2            				
					for counter1 as integer = 0 to nstudav						
						getstudav(counter1)						
						if studav.studno = stud.studno and studav.appointment = counter and studav.dayno = parts(1) then							
							exit for						
						end if					
					next					
					studav.available = true					
					studav.block += 2					
					putstudav(studav, studav.studavno)				
				next				
				for counter as integer = (parts(2) \ 100) + (((parts(2)) - (((parts2)) \ 100) * 100)) / 5) + 12 to ((parts(2) \100 + (((parts(2)) - (((parts(2)) \ 100) * 100)) / 5) +16) step 2					
					for counter1 as integer = 0 to nstudav						
						getstdav(counter1)						
						if studav.studno = stud.studno and studav.appointment = counter and studav.dayno = parts(1) then							
							exit for						
						end if					
					next 					
					studav.abailable = true					
					studav.block += 4					
					putstudav(studav, studav.studavno)				
				next
			end if	
		End If
	else
	end if
    End Sub
End Class
