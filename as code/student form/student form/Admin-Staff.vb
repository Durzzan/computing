Public Class Admin_Staff

    Private Sub Admin_Staff_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'populate the grdstaff data grid
        For counter As Integer = 1 To Nstaff
            staff = GetStaff(counter)
            grdStaff.Rows.Add(staff.staffNO, staff.staffID, staff.Forename, staff.Surname, staff.PointsLeft, staff.admin, Decrypt(staff.password))
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim counter As Integer
        'checks if there is a word in txtforename, serves as presence check and word check
        If IsAlpha(txtForname.Text.Trim) = True Then
            'checks if there is a word in txtsurname, serves as presence check and word check
            If IsAlpha(txtSurname.Text.Trim) = True Then
                'clears grdstaff populates grdstaff with only staff whose first name starts with the 
                'text in txtforename and whose last name starts with the text in txtsurname
                grdStaff.Rows.Clear()
                For counter = 1 To Nstaff
                    staff = GetStaff(counter)
                    If staff.Forename.ToUpper.StartsWith(txtForname.Text.Trim.ToUpper) And staff.Surname.ToUpper.StartsWith(txtSurname.Text.ToUpper.Trim) Then
                        grdStaff.Rows.Add(staff.staffNO, staff.staffID, staff.Forename, staff.Surname, staff.PointsLeft, staff.admin, Decrypt(staff.password))
                    End If
                Next

                'if only the forname box contains letters and txtsurname is empty
            ElseIf txtSurname.Text = "" Then
                'clears grdstaff then populates the grdstaff with only staff whose first name 
                'starts with the text in txtforename
                grdStaff.Rows.Clear()
                For counter = 1 To Nstaff
                    staff = GetStaff(counter)
                    If staff.Forename.ToUpper.StartsWith(txtForname.Text.Trim.ToUpper) Then
                        grdStaff.Rows.Add(staff.staffNO, staff.staffID, staff.Forename, staff.Surname, staff.PointsLeft, staff.admin, Decrypt(staff.password))
                    End If
                Next
                'txtsurname contains invalid data so error message sent
            Else : MsgBox("the surname must be only letters with no spaces")
            End If
        ElseIf txtForname.Text = "" Then
            'checks if there is a word in txtsurname, serves as presence check and word check
            If IsAlpha(txtSurname.Text) = True Then
                'clears grdstaff then populates the grdstaff with only staff whose second name 
                'starts with the text in txtsurname
                grdStaff.Rows.Clear()
                For counter = 1 To Nstaff
                    staff = GetStaff(counter)
                    If staff.Surname.ToUpper.StartsWith(txtSurname.Text.Trim.ToUpper) Then
                        grdStaff.Rows.Add(staff.staffNO, staff.staffID, staff.Forename, staff.Surname, staff.PointsLeft, staff.admin, Decrypt(staff.password))
                    End If
                Next
                'if neither box contains letters
            ElseIf txtSurname.Text = "" Then
                'clears grdstaff then populates it with all staff
                grdStaff.Rows.Clear()
                For counter = 1 To Nstaff
                    staff = GetStaff(counter)
                    grdStaff.Rows.Add(staff.staffNO, staff.staffID, staff.Forename, staff.Surname, staff.PointsLeft, staff.admin, Decrypt(staff.password))
                Next
                'txtsurname contains invalid data so error message sent
            Else : MsgBox("surname must be only letters with no spaces")
            End If
            'txtforname contains invalid data so error message sent
        Else : MsgBox("the forename must be only letters with no spaces")
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'opens admindirectory and close admin staff
        AdminDirectory.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'sets global variable adding to true so that staffedit will open in adding mode then opens staffedit
        Adding = True
        StaffEdit.Show()
    End Sub

    Private Sub grdStaff_CellContentdoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStaff.CellContentClick
        Dim ID As Integer
        'intialise variable but if it doesnt work because content sellected is a header it will exit sub
        Try
            ID = grdStaff.Rows(e.RowIndex).Cells(0).Value
        Catch
            Exit Sub
        End Try
        'gets staff data
        staff = GetStaff(ID)
        'sets global variable adding to false so that staffedit will open in change mode then opens staffedit
        Adding = False
        StaffEdit.Show()
    End Sub
End Class