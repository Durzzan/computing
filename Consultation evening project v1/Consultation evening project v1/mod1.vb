Module mod1
    'structures

    'Student structure

    Public Structure StudRec
        Public StudNO As Integer
        Public StudID As Integer
        Public Forename As String
        Public Surname As String
        Public Year As Byte
    End Structure

    'staff structure

    Public Structure StaffRec
        Public StaffNO As Integer
        Public Forename As String
        Public Surname As String
        Public admin As Boolean
    End Structure

    'Student availabity structure

    Public Structure StudAvRec
        Public Appointment As Integer
        Public StudNo As Integer
        Public Day As Byte
        Public Block As Byte
        Public available As Boolean
    End Structure

    'staff availability structure

    Public Structure StaffAvRec
        Public Appointment As Integer
        Public StaffNO As Integer
        Public Day As Byte
        Public Block As Byte
        Public Available As Boolean
    End Structure

    'day stucture

    Public Structure DayRec
        Public DayNO As Byte
        Public Start As Integer
        Public finish As Integer
    End Structure

    'appointments structure

    Public Structure AppointmentsRec
        Public DayNO As Byte
        Public LessonNO As Integer
        Public AppointmentNO As Byte
    End Structure

    'Lesson structure

    Public Structure LessonRec
        Public LessonNO As Integer
        Public StudNO As Integer
        Public StaffNO As Integer
    End Structure

    'variables


    'general variables 
    'contains the users username
    Public user As String

    'student variables

    Public student As StudRec = Nothing
    Public Nstudents As Integer = -1

    'staff variables

    Public Staff As StaffRec = Nothing
    Public Nstaff As Integer = -1

    'student availability variables

    Public StudAv As StudAvRec = Nothing
    Public NStudAv As Integer = -1

    'staff availablitiy variables

    Public StaffAv As StaffAvRec = Nothing
    Public NStaffAv As Integer = -1

    'Day variables

    Public Daylength As Byte
    Public Day As DayRec = Nothing
    Public NDay As Integer = -1

    'Appointment variables

    Public Appointment As AppointmentsRec = Nothing
    Public NAppointment As Integer = -1

    'Lesson variables

    Public Lesson As LessonRec = Nothing
    Public Nlesson As Integer = -1

    'reading csv files

    'imports the students into thier csv file
    Public Sub ImportStudents()
        'opnes up file reader and sets it to read students.csv the file in which the student data is stored
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("students.csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim CurrentRow As String()
        Dim OnRec As Integer = 0
        Dim FileNum As Integer = FreeFile()
        'opens file
        FileOpen(FileNum, "Student.csv", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(student))

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    OnRec = OnRec + 1
                    'puts data into the studet structure
                    With student
                        .studNO = CurrentRow(0)
                        .studID = CurrentRow(1)
                        .Surname = CurrentRow(2)
                        .Forename = CurrentRow(3)
                        .Year = CurrentRow(4)
                    End With
                    'puts data from the student structure into the student csv file
                    FilePut(FileNum, student + vbnewline, OnRec)
                End If
            Catch ex As  _
                Microsoft.VisualBasic.FileIO.MalformedLineException
                'if error then error message is sent and try ends
                MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
            End Try
        End While
        'message box is sent saying that the students are imported and how many
        MsgBox(NStudents & " students imported")
        'file is closed
        FileClose(FileNum)
        TextFileReader.Dispose()
    End Sub

    'imports staff into thier csv file
    Public Sub ImportStaff()
        'opens microsoft file reader and sets the file to be read as staffdata.csv
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("tutor.csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim CurrentRow As String()
        Dim OnRec As Integer = 0
        Dim FileNum As Integer = FreeFile()
	Dim parts() as string
        'opens the file
        FileOpen(FileNum, "Staff.csv", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Staff))

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    OnRec = OnRec + 1
                    'puts data into file structure staff
                    With staff
                        .staffNO = CurrentRow(0)
			parts() = split(currentrow(1), " " )
			.surname = parts(1)
			.Forename = parts(0)
                        .admin = CurrentRow(2)
                        .staffID = (parts(0).Chars(0) + parts(1).Chars(0) + parts(1).Chars(1)).tostring.toupper
                    End With
                    'puts data in file structure staff into the staff dat file
                    FilePut(FileNum, staff, OnRec)
                End If
            Catch ex As  _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                'error in text sends error message and ends try
                MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
            End Try
        End While
        Nstaff = OnRec
        'sends message box notifying student that staff have been imported and how many have been
        MsgBox(Nstaff & " Staff imported")
        FileClose(FileNum)
        TextFileReader.Dispose()
    End Sub
End Module
