Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
Imports DojoNorthSoftware.Pushover

Public Class HFAPI

    Private apiURL As String = "https://hackforums.net/api/v1/"
    Private apiKey As String

    Private PMBoxJSON As PMInbox
    Private UserInfoList As MultiUserInfo




    Public Function setAPIKey(ByVal _apiKey As String) As Boolean

        If checkAPIKey(_apiKey) Then
            apiKey = _apiKey
            Return True
        End If

        Return False


    End Function


    Public Function getPMInbox(Optional ByVal pageNumber As Integer = 1, Optional ByVal folder As Integer = 1) As PMInbox

        Dim webClient As New WebClient()
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey & ":"))
        webClient.Headers(HttpRequestHeader.Authorization) = String.Format("Basic {0}", credentials)
        webClient.Headers(HttpRequestHeader.UserAgent) = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; EasyBits GO v1.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; Tablet PC 2.0; InfoPath.3)"

        Dim PMListResponse As String = webClient.DownloadString(apiURL & "pmbox/" & folder & "?page=" & pageNumber & "&include=header")
        PMBoxJSON = JsonConvert.DeserializeObject(Of PMInbox)(PMListResponse)

        Return PMBoxJSON
    End Function

    Private Function checkAPIKey(ByVal apiKey As String) As Boolean
        Try
            Dim webClient As New WebClient()
            Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey & ":"))
            webClient.Headers(HttpRequestHeader.Authorization) = String.Format("Basic {0}", credentials)
            webClient.Headers(HttpRequestHeader.UserAgent) = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; EasyBits GO v1.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; Tablet PC 2.0; InfoPath.3)"

            Dim checkAPIKeyResponse As JObject = JObject.Parse(webClient.DownloadString(apiURL & "user/"))

            If checkAPIKeyResponse.SelectToken("success") = "True" Then
                Return True
            End If
            MessageBox.Show("The API Key you have entered is INVALID. Please check the Key and try again. ", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("An Error has occurred." & vbNewLine & vbNewLine & ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Application.Exit()
        End Try


        Return False


    End Function


End Class
