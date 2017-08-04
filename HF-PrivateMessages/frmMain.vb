Imports System.Net
Imports Newtonsoft.Json
Imports System.Text
Imports System.Threading

Public Class frmMain

    Public apiURL As String = "https://hackforums.net/api/v1/"

    Public api As New HFAPI

    Private pageNumber As Integer = 1
    Private totalMessages As Integer = 0
    Private totalPages As Integer = 0
    Private unReadMessages As Integer = 0
    Private folderID As Integer = 1

    Private _PMInboxJSON As PMInbox


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Public Sub updateTimerInterval(ByVal interval As Integer)
        PMCheck.Stop()
        PMCheck.Interval = interval
        PMCheck.Start()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If api.setAPIKey(My.Settings.apiKey) = False Then
            frmSettings.ShowDialog()
        End If
        updateTimerInterval(My.Settings.updateInterval)
        cbFolder.SelectedIndex = folderID - 1

    End Sub

    Private Sub updateMessages(Optional ByVal pageNumber As Integer = 1, Optional ByVal folder As Integer = 1)
        lvMessages.Items.Clear()
        Dim PMInbox As PMInbox = api.getPMInbox(pageNumber, folder)

        unReadMessages = PMInbox.header.unreadpms
        totalMessages = PMInbox.result.pageInfo.total

        totalPages = totalMessages / 20

        lblTotalMessages.Text = String.Format("Total Messages: {0}", totalMessages)
        lblPageNumber.Text = String.Format("Page: {0}/{1}", pageNumber, totalPages)


        Dim i As Integer = 0
        For Each pmItem In PMInbox.result.pms

            Dim str(2) As String
            Dim itm As ListViewItem
            str(0) = pmItem.subject
            str(1) = pmItem.senderusername
            str(2) = pmItem.dateline

            itm = New ListViewItem(str)
            itm.Tag = pmItem.pmid

            lvMessages.Items.Add(itm)

            If pmItem.status = 0 Then
                lvMessages.Items.Item(i).Group = lvMessages.Groups(0)
                lvMessages.Items.Item(i).Font = New Font(lvMessages.Items.Item(i).Font, FontStyle.Bold)
            Else
                lvMessages.Items.Item(i).Group = lvMessages.Groups(1)
            End If
            i = i + 1
        Next

        If unReadMessages >= 1 Then
            Me.Icon = My.Resources.unreadIcon
            niTrayIcon.Icon = My.Resources.unreadIcon
            NotifyUser(String.Format("You have {0} unread Private Messages", unReadMessages), "New Private Message")
        Else
            Me.Icon = My.Resources.readIcon
            niTrayIcon.Icon = My.Resources.readIcon
        End If

        lblLastUpdated.Text = String.Format("Last Updated: {0}", Date.Now.ToLongTimeString)

    End Sub


    Private Sub lvMessages_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvMessages.MouseDoubleClick

        Dim form As New frmViewPrivateMessage(lvMessages.SelectedItems.Item(0).Tag)
        form.ShowDialog()

        Try
            If lvMessages.SelectedItems.Item(0).Group.Tag = 0 Then
                updateMessages()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateMessages()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        System.Media.SystemSounds.Question.Play()

        pageNumber = pageNumber + 1

        updateMessages(pageNumber)
        If pageNumber = totalPages Then
            btnNext.Enabled = False
            btnPrevious.Enabled = True
        Else
            btnNext.Enabled = True
            btnPrevious.Enabled = True
        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        pageNumber = pageNumber - 1
        updateMessages(pageNumber)
        If pageNumber = 1 Then
            btnPrevious.Enabled = False
        End If
    End Sub

    Private Sub cbFolder_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbFolder.SelectedValueChanged

        updateMessages(, cbFolder.SelectedIndex + 1)
    End Sub

    Private Sub PMCheck_Tick(sender As Object, e As EventArgs) Handles PMCheck.Tick
        updateMessages()
    End Sub

    Public Sub NotifyUser(message As String, title As String)
        niTrayIcon.BalloonTipTitle = title
        niTrayIcon.BalloonTipText = message
        niTrayIcon.BalloonTipIcon = ToolTipIcon.Info
        niTrayIcon.ShowBalloonTip(300)
    End Sub

    Private Sub btnSendToTray_Click(sender As Object, e As EventArgs) Handles btnSendToTray.Click
        'Me.WindowState = FormWindowState.Minimized
        Me.Hide()
        niTrayIcon.Visible = True


    End Sub

    Private Sub niTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles niTrayIcon.MouseDoubleClick
        Me.Show()
        niTrayIcon.Visible = False

    End Sub

    Private Sub niTrayIcon_BalloonTipClicked(sender As Object, e As EventArgs) Handles niTrayIcon.BalloonTipClicked
        Me.Show()
        niTrayIcon.Visible = False
    End Sub
End Class
