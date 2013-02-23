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


End Module
