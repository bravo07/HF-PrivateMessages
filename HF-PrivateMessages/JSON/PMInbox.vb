Public Class Header
    Public Property unreadpms As Integer
End Class

Public Class PageInfo
    Public Property total As Integer
End Class

Public Class Pm
    Public Property dateline As DateTime
    Public Property pmid As Integer
    Public Property recipient As Integer
    Public Property recipientusername As String
    Public Property sender As Integer
    Public Property senderusername As String
    Public Property status As Integer
    Public Property subject As String
End Class

Public Class Result
    Public Property pageInfo As PageInfo
    Public Property pmbox As String
    Public Property pms As Pm()
End Class

Public Class PMInbox
    Public Property header As Header
    Public Property message As String
    Public Property result As Result
    Public Property success As Boolean
End Class