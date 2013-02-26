Module modVariables
    Public Adding As Boolean = True

    Public Structure studentrec
        Public studNO As Short
        Public studID As Integer
        <VBFixedString(20)> Public Surname As String
        <VBFixedString(20)> Public Forename As String
        Public DOB As Date
        Public points As Short
        <VBFixedString(64)> Public password As String
    End Structure
    Public student As studentrec = Nothing
    Public NStudents As Integer = 0

    Public Structure Staffrec
        Public staffNO As Short
        <VBFixedString(3)> Public staffID As String
        <VBFixedString(20)> Public Surname As String
        <VBFixedString(20)> Public Forename As String
        Public PointsLeft As Short
        <VBFixedString(64)> Public password As String
        Public DOB As Date
        Public admin As Boolean
    End Structure
    Public staff As Staffrec = Nothing
    Public Nstaff As Integer = 0

    Public Structure Rewards
        Public RewardID As Byte
        <VBFixedString(50)> Public name As String
        Public cost As Short
    End Structure
    Public reward As Rewards = Nothing
    Public NRewards As Integer = 0

    Public Structure pointsprocedure
        Public StudNO As Integer
        Public StaffNO As Short
        Public pointstransfered As Short
        <VBFixedString(50)> Public reason As String
    End Structure
    Public pointsP As pointsprocedure = Nothing
    Public NpointsP As Integer = 0

    Public Structure Rewardsprocedure
        Public studNO As Short
        Public RewardID As Byte
    End Structure
    Public RewardsP As Rewardsprocedure = Nothing
    Public NrewardsP As Integer = 0

End Module
