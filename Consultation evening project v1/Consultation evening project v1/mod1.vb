﻿Module mod1
    'structures

    'Student structure

    Public Structure StudRec
        Public StudNO As Short
        Public StudID As Integer
        <VBFixedString(20)> Public Forename As String
        <VBFixedString(20)> Public Surname As String
        Public Year As Byte
    End Structure

    'staff structure

    Public Structure StaffRec
        Public StaffNO As Byte
        <VBFixedString(3)> Public staffID As String
        <VBFixedString(20)> Public Forename As String
        <VBFixedString(20)> Public Surname As String
        Public admin As Boolean
    End Structure

    'Student availabity structure

    Public Structure StudAvRec
        Public Appointment As Integer
        Public StudNo As Short
        Public Day As Byte
        Public Block As Byte
        Public available As Boolean
    End Structure

    'staff availability structure

    Public Structure StaffAvRec
        Public Appointment As Integer
        Public StaffNO As Byte
        Public Day As Byte
        Public Block As Byte
        Public Available As Boolean
    End Structure

    'day stucture

    Public Structure DayRec
        Public DayNO As Byte
        Public Start As Byte
        Public finish As Byte
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
        Public StudNO As Byte
        Public StaffNO As Byte
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

    Public Appointmentlength As Byte
    Public Day As DayRec = Nothing
    Public NDay As Integer = -1

    'Appointment variables

    Public Appointment As AppointmentsRec = Nothing
    Public NAppointment As Integer = -1

    'Lesson variables

    Public Lesson As LessonRec = Nothing
    Public Nlesson As Integer = -1

    'reading csv files and creating dat files

    'imports the students into thier dat file
    Public Sub ImportStudents()
        'opnes up file reader and sets it to read students.csv the file in which the student data is stored
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("students.csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim CurrentRow As String()
        Dim OnRec As Integer = 0
        Dim FileNum As Integer = FreeFile()
        'opens file
        FileOpen(FileNum, "Student.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(student))

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
                    'puts data from the student structure into the student dat file
                    FilePut(FileNum, student, OnRec)
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

    'imports staff into thier dat file
    Public Sub ImportStaff()
        'opens microsoft file reader and sets the file to be read as tutor.csv
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("tutor.csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim CurrentRow As String()
        Dim OnRec As Integer = 0
        Dim FileNum As Integer = FreeFile()

        'opens the file
        FileOpen(FileNum, "Staff.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Staff))

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    OnRec = OnRec + 1
                    'puts data into file structure staff
                    With staff
                        .StaffNO = CurrentRow(0)
                        'forename and surname are saved in the same field on the parent file so need to be broken up
                        Dim parts() As String = Split(CurrentRow(1), " ")
                        .Surname = parts(1)
                        .Forename = parts(0)
                        .staffID = CurrentRow(2)
                        If CurrentRow(2) = 0 Then
                            .admin = False
                        Else : .admin = True
                        End If
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

    ' retrives a student record
    Public Function GetStudent(ByVal RecNo As Integer) As StudRec
        'function for getting data from student dat file
        Dim Filenum As Integer = FreeFile()
        GetStudent = Nothing
        'opens the student dat file
        FileOpen(Filenum, "Student.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(student))
        'gets data
        FileGet(Filenum, GetStudent, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    'retrives a staff record
    Public Function GetStaff(ByVal RecNo As Integer) As StaffRec
        'function for getting data from staff dat file
        Dim Filenum As Integer = FreeFile()
        GetStaff = Nothing
        'opens the staff dat file
        FileOpen(Filenum, "Staff.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(staff))
        'gets data
        FileGet(Filenum, GetStaff, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    'retrives a student availability record
    Public Function GetStudAV(ByVal RecNo As Integer) As StudAvRec
        'function for getting data from studAV dat file
        Dim Filenum As Integer = FreeFile()
        GetStudAV = Nothing
        'opens the studav dat file
        FileOpen(Filenum, "StudAV.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(StudAv))
        'gets data
        FileGet(Filenum, GetStudAV, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    'retrives a staff availiability record
    Public Function GetStaffAV(ByVal RecNo As Integer) As StaffAvRec
        'function for getting data from staffav dat file
        Dim Filenum As Integer = FreeFile()
        GetStaffAV = Nothing
        'opens the staffav dat file
        FileOpen(Filenum, "StaffAV.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(StaffAv))
        'gets data
        FileGet(Filenum, GetStaffAV, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    'retrives a day record
    Public Function GetDay(ByVal RecNo As Integer) As DayRec
        'function for getting data from day dat file
        Dim Filenum As Integer = FreeFile()
        GetDay = Nothing
        'opens the day dat file
        FileOpen(Filenum, "Day.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Day))
        'gets data
        FileGet(Filenum, GetDay, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    'retrives a lesson record
    Public Function Getlesson(ByVal RecNo As Integer) As LessonRec
        'function for getting data from lesson dat file
        Dim Filenum As Integer = FreeFile()
        Getlesson = Nothing
        'opens the lesson dat file
        FileOpen(Filenum, "Lesson.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Lesson))
        'gets data
        FileGet(Filenum, Getlesson, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    'retreives a appointment record
    Public Function Getappointmentrec(ByVal RecNo As Integer) As AppointmentsRec
        'function for getting data from Appointments dat file
        Dim Filenum As Integer = FreeFile()
        Getappointmentrec = Nothing
        'opens the appointments dat file
        FileOpen(Filenum, "Appointments.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Appointment))
        'gets data
        FileGet(Filenum, Getappointmentrec, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    'overwrites an student onto the student dat file
    Public Sub PutStudent(ByVal EditedStudent As StudRec, ByVal RecNo As Integer)
        'sub for putting data into the student dat file
        Dim Filenum As Integer = FreeFile()
        'opens student dat file
        FileOpen(Filenum, "Student.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(student))
        'puts data into student dat file
        FilePut(Filenum, EditedStudent, RecNo)
        'closes student dat file
        FileClose(Filenum)
    End Sub

    'overwrites an staff onto the staff dat file
    Public Sub PutStaff(ByVal EditedStaff As StaffRec, ByVal RecNo As Integer)
        'sub for putting data into the staff dat file
        Dim Filenum As Integer = FreeFile()
        'opens staff dat file
        FileOpen(Filenum, "Staff.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Staff))
        'puts data into staff dat file
        FilePut(Filenum, EditedStaff, RecNo)
        'closes staff dat file
        FileClose(Filenum)
    End Sub

    'overwrites an studavrec onto the studav dat file
    Public Sub PutStudAv(ByVal EditedStudAv As StudAvRec, ByVal RecNo As Integer)
        'sub for putting data into the studAv dat file
        Dim Filenum As Integer = FreeFile()
        'opens studAv dat file
        FileOpen(Filenum, "StudAv.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(StudAv))
        'puts data into studAv dat file
        FilePut(Filenum, EditedStudAv, RecNo)
        'closes studAv dat file
        FileClose(Filenum)
    End Sub

    'overwrites an staffAv onto the staffAv dat file
    Public Sub PutStaffAv(ByVal EditedStaffAv As StaffAvRec, ByVal RecNo As Integer)
        'sub for putting data into the staffAv dat file
        Dim Filenum As Integer = FreeFile()
        'opens staffAv dat file
        FileOpen(Filenum, "StaffAv.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(StaffAv))
        'puts data into staffAv dat file
        FilePut(Filenum, EditedStaffAv, RecNo)
        'closes staffAv dat file
        FileClose(Filenum)
    End Sub

    'overwrites an Day onto the day dat file
    Public Sub Putday(ByVal Editedday As DayRec, ByVal RecNo As Integer)
        'sub for putting data into the day dat file
        Dim Filenum As Integer = FreeFile()
        'opens day dat file
        FileOpen(Filenum, "day.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Day))
        'puts data into day dat file
        FilePut(Filenum, Editedday, RecNo)
        'closes day dat file
        FileClose(Filenum)
    End Sub
End Module
