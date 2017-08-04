Public Class Result2
    Public Property additionalgroups As Integer()
    Public Property avatar As String
    Public Property avatartype As String
    Public Property displaygroup As Integer
    Public Property lastactive As DateTime
    Public Property postnum As Integer
    Public Property regdate As DateTime
    Public Property reputation As Integer
    Public Property timeonline As Integer
    Public Property usergroup As Integer
    Public Property username As String
    Public Property usertitle As String
End Class

Public Class Uid
    Public Property message As String
    Public Property result As Result2
    Public Property success As Boolean
    Public Property uid As Integer
End Class

Public Class MultiUserInfo
    Public Property message As String
    Public Property success As Boolean
    Public Property uids As Uid()
End Class