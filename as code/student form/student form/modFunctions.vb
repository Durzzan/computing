Module modFunctions
    'microsofts code for encryption and decryption
    Dim DES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
    Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider
    Private Const Key = "Some key that you think appropriate!"

    Public Function Encrypt(ByVal strText As String) As String
        'microsofts code that encrypts strings
        Encrypt = ""
        Try
            DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(Key))
            DES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(strText)
            Encrypt = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Encrypt = strText
        End Try
    End Function

    Public Function Decrypt(ByVal strText As String) As String
        'microsofts code that decrypts strings
        Decrypt = ""
        Try
            DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(Key))
            DES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(strText)
            Decrypt = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Decrypt = strText
        End Try
    End Function

    Public Function IsName(ByVal InString As String) As Boolean
        Dim Counter As Integer
        Dim strLetters As Char()
        'removes spaces
        InString = Trim(InString)
        'checks if empty
        If InString.Length = 0 Then
            IsName = False
        Else
            strLetters = InString.ToUpper.ToCharArray
            IsName = True
            For Counter = 0 To InString.Length - 1
                'checks each chacater for being a letter or a hyfin
                If IsAlpha(strLetters(Counter)) = True Or strLetters(Counter) = "-" Then
                    'OK
                Else
                    'Error
                    IsName = False
                End If
            Next
        End If
    End Function

    Public Function IsAlpha(ByVal InString As String) As Boolean
        Dim Counter As Integer
        Dim strLetters As Char()
        InString = Trim(InString)
        'checks if empty
        If InString.Length = 0 Then
            IsAlpha = False
        Else
            strLetters = InString.ToUpper.ToCharArray
            IsAlpha = True
            'checks each character for being a letter if not isalpha is reterned as false
            For Counter = 0 To InString.Length - 1
                If strLetters(Counter) < "A" Or strLetters(Counter) > "Z" Then
                    IsAlpha = False
                End If
            Next
        End If
    End Function

    Public Sub ImportStudents()
        'opnes up file reader and sets it to read collegedata.csv the file in which the student data is stored
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("collegedata.csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim CurrentRow As String()
        Dim OnRec As Integer = 0
        Dim FileNum As Integer = FreeFile()
        'opens file
        FileOpen(FileNum, "Student.Dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(student))

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
                        .DOB = CurrentRow(4)
                        .password = Encrypt("db" & Format(.DOB, "ddMMyyyy"))
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

    Public Sub ImportStaff()
        'opens microsoft file reader and sets the file to be read as staffdata.csv
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("staffdata.csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim CurrentRow As String()
        Dim OnRec As Integer = 0
        Dim FileNum As Integer = FreeFile()
        'opens the file
        FileOpen(FileNum, "Staff.Dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(staff))

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    OnRec = OnRec + 1
                    'puts data into file structure staff
                    With staff
                        .staffNO = CurrentRow(0)
                        .admin = CurrentRow(1)
                        .staffID = CurrentRow(2)
                        .Forename = CurrentRow(3)
                        .Surname = CurrentRow(4)
                        .DOB = CurrentRow(5)
                        .password = Encrypt("db" & Format(.DOB, "ddMMyyyy"))
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

    Public Sub ImportRewards()
        'opens microsoft file reader and sets the file to be read as rewards.csv
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("rewards.csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim CurrentRow As String()
        Dim OnRec As Integer = 0
        Dim FileNum As Integer = FreeFile()
        'opens the file
        FileOpen(FileNum, "rewards.Dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(reward))

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    OnRec = OnRec + 1
                    With reward
                        'puts data into file structure rewards
                        .RewardID = CurrentRow(0)
                        .name = CurrentRow(1)
                        .cost = CurrentRow(2)
                    End With
                    'puts data from file structure rewards into the rewards dat file
                    FilePut(FileNum, reward, OnRec)
                End If

            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                'error found so error message sent and try ended
                MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
            End Try
        End While
        NRewards = OnRec
        'import completed so message notafying user sent also saying how many imported
        MsgBox(NRewards & " rewards imported")
        FileClose(FileNum)
        TextFileReader.Dispose()
    End Sub
    Public Function GetStudent(ByVal RecNo As Integer) As studentrec
        'function for getting data from student dat file
        Dim Filenum As Integer = FreeFile()
        GetStudent = Nothing
        'opens the student dat file
        FileOpen(Filenum, "Student.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(Student))
        'gets data
        FileGet(Filenum, GetStudent, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    Public Function GetStaff(ByVal RecNo As Integer) As Staffrec
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

    Public Function GetReward(ByVal RecNo As Integer) As Rewards
        'function for getting data from reward dat file
        Dim Filenum As Integer = FreeFile()
        GetReward = Nothing
        'opens the reward dat file
        FileOpen(Filenum, "rewards.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(reward))
        'gets data
        FileGet(Filenum, GetReward, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    Public Function GetRewardP(ByVal RecNo As Integer) As Rewardsprocedure
        'function for getting data from the rewardsP dat file
        Dim Filenum As Integer = FreeFile()
        GetRewardP = Nothing
        'opens the rewardsP dat file
        FileOpen(Filenum, "rewardsP.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(RewardsP))
        'gets data
        FileGet(Filenum, GetRewardP, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    Public Function GetPointsP(ByVal RecNo As Integer) As pointsprocedure
        'function for getting data from the pointsp dat file
        Dim Filenum As Integer = FreeFile()
        GetPointsP = Nothing
        'opens the pointsp dat file
        FileOpen(Filenum, "pointsprocedure.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(pointsP))
        'gets data
        FileGet(Filenum, GetPointsP, RecNo)
        'closes file
        FileClose(Filenum)
    End Function

    Public Sub PutStudent(ByVal EditedStudent As studentrec, ByVal RecNo As Integer)
        'sub for putting data into the student dat file
        Dim Filenum As Integer = FreeFile()
        'opens student dat file
        FileOpen(Filenum, "Student.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(student))
        'puts data into student dat file
        FilePut(Filenum, EditedStudent, RecNo)
        'closes student dat file
        FileClose(Filenum)
    End Sub

    Public Sub PutStaff(ByVal EditedStaff As Staffrec, ByVal RecNo As Integer)
        'sub for puttin data into the staff dat file
        Dim Filenum As Integer = FreeFile()
        'opens staff dat file
        FileOpen(Filenum, "Staff.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(staff))
        'puts data into staff dat file
        FilePut(Filenum, EditedStaff, RecNo)
        'close staff dat file
        FileClose(Filenum)
    End Sub

    Public Sub PutReward(ByVal EditedReward As Rewards, ByVal RecNo As Integer)
        'sub for putting data into teh rewards dat file
        Dim Filenum As Integer = FreeFile()
        'opens rewards dat file
        FileOpen(Filenum, "Rewards.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(reward))
        'puts data into rewards dat file
        FilePut(Filenum, EditedReward, RecNo)
        'close rewards dat file
        FileClose(Filenum)
    End Sub

    Public Sub PutRewardP(ByVal EditedRewardP As Rewardsprocedure, ByVal RecNo As Integer)
        'sub for putting data into the rewardsp dat file
        Dim Filenum As Integer = FreeFile()
        'opens rewardsp dat file
        FileOpen(Filenum, "RewardsProcedure.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(RewardsP))
        'puts data into rewardsp dat file
        FilePut(Filenum, EditedRewardP, RecNo)
        'close rewardsp dat file
        FileClose(Filenum)
    End Sub

    Public Sub PutPointsP(ByVal EditedPointsP As pointsprocedure, ByVal RecNo As Integer)
        'sub for putting data into the pointsp dat file
        Dim Filenum As Integer = FreeFile()
        'opens pointsp dat file
        FileOpen(Filenum, "pointsProcedure.dat", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(pointsP))
        'puts data into pointsp dat file
        FilePut(Filenum, EditedPointsP, RecNo)
        'closes pointsp dat file
        FileClose(Filenum)
    End Sub
End Module
