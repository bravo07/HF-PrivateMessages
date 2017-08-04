Imports System.Net
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json


Public Class frmViewPrivateMessage

    Public PMid As Integer

    Private _PMDetails As PMDetails


    Sub New(ByVal _PMID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        PMid = _PMID


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmViewPrivateMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim PMInbox As New WebClient()
        Dim apiKey As String = My.Settings.apiKey
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey & ":"))
        PMInbox.Headers(HttpRequestHeader.Authorization) = String.Format("Basic {0}", credentials)
        PMInbox.Headers(HttpRequestHeader.UserAgent) = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; EasyBits GO v1.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; Tablet PC 2.0; InfoPath.3)"

        Dim PMDetails As String = PMInbox.DownloadString(frmMain.apiURL & "pm/" & PMid & "/?raw")

        _PMDetails = JsonConvert.DeserializeObject(Of PMDetails)(PMDetails)


        txtMessage.Text = _PMDetails.result.message
        lblSenderText.Text = String.Format("{0}", _PMDetails.result.tousername)
        lblSubjectText.Text = String.Format("{0}", _PMDetails.result.subject)


        'txtMessage.Text = HFAPI.ConvertHtmlToText(_PMDetails.result.message)



    End Sub
End Class