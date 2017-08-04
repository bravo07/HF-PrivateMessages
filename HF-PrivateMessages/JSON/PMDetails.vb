Public Class Result1
    Public Property dateline As DateTime
    Public Property folder As Integer
    Public Property from As Integer
    Public Property fromusername As String
    Public Property message As String
    Public Property subject As String
    Public Property userTo As Integer
    Public Property tousername As String
End Class

Public Class PMDetails
    Public Property message As String
    Public Property result As Result1
    Public Property success As Boolean
End Class