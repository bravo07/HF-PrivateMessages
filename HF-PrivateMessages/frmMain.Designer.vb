<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Unread Messages", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Read Messages", System.Windows.Forms.HorizontalAlignment.Center)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.niTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lvMessages = New System.Windows.Forms.ListView()
        Me.chMessageTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblFolder = New System.Windows.Forms.Label()
        Me.cbFolder = New System.Windows.Forms.ComboBox()
        Me.PMCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lblTotalMessages = New System.Windows.Forms.Label()
        Me.lblPageNumber = New System.Windows.Forms.Label()
        Me.btnSendToTray = New System.Windows.Forms.Button()
        Me.lblLastUpdated = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'niTrayIcon
        '
        Me.niTrayIcon.Text = "HF Notifications"
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.Location = New System.Drawing.Point(12, 485)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(104, 23)
        Me.btnSettings.TabIndex = 0
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'lvMessages
        '
        Me.lvMessages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chMessageTitle, Me.chSender, Me.chDateTime})
        Me.lvMessages.FullRowSelect = True
        Me.lvMessages.GridLines = True
        ListViewGroup1.Header = "Unread Messages"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup1.Name = "lvgUnreadMessages"
        ListViewGroup1.Tag = "0"
        ListViewGroup2.Header = "Read Messages"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup2.Name = "lvgReadMessages"
        ListViewGroup2.Tag = "1"
        Me.lvMessages.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvMessages.Location = New System.Drawing.Point(12, 39)
        Me.lvMessages.Name = "lvMessages"
        Me.lvMessages.Size = New System.Drawing.Size(653, 440)
        Me.lvMessages.TabIndex = 1
        Me.lvMessages.UseCompatibleStateImageBehavior = False
        Me.lvMessages.View = System.Windows.Forms.View.Details
        '
        'chMessageTitle
        '
        Me.chMessageTitle.Text = "Message Title"
        Me.chMessageTitle.Width = 305
        '
        'chSender
        '
        Me.chSender.Text = "Sender"
        Me.chSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chSender.Width = 163
        '
        'chDateTime
        '
        Me.chDateTime.Text = "Date/Time Received"
        Me.chDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDateTime.Width = 165
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(591, 485)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.Location = New System.Drawing.Point(384, 485)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(561, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(104, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblFolder
        '
        Me.lblFolder.AutoSize = True
        Me.lblFolder.Location = New System.Drawing.Point(9, 15)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(39, 13)
        Me.lblFolder.TabIndex = 5
        Me.lblFolder.Text = "Folder:"
        '
        'cbFolder
        '
        Me.cbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFolder.FormattingEnabled = True
        Me.cbFolder.Items.AddRange(New Object() {"Inbox", "Sent Items", "Drafts", "Trash"})
        Me.cbFolder.Location = New System.Drawing.Point(54, 12)
        Me.cbFolder.Name = "cbFolder"
        Me.cbFolder.Size = New System.Drawing.Size(121, 21)
        Me.cbFolder.TabIndex = 6
        '
        'PMCheck
        '
        Me.PMCheck.Interval = 300000
        '
        'lblTotalMessages
        '
        Me.lblTotalMessages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalMessages.Location = New System.Drawing.Point(122, 485)
        Me.lblTotalMessages.Name = "lblTotalMessages"
        Me.lblTotalMessages.Size = New System.Drawing.Size(256, 23)
        Me.lblTotalMessages.TabIndex = 7
        Me.lblTotalMessages.Text = "Total Messages: {0}"
        Me.lblTotalMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPageNumber
        '
        Me.lblPageNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPageNumber.Location = New System.Drawing.Point(465, 485)
        Me.lblPageNumber.Name = "lblPageNumber"
        Me.lblPageNumber.Size = New System.Drawing.Size(120, 23)
        Me.lblPageNumber.TabIndex = 8
        Me.lblPageNumber.Text = "Page: {0}/{1}"
        Me.lblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSendToTray
        '
        Me.btnSendToTray.Location = New System.Drawing.Point(468, 10)
        Me.btnSendToTray.Name = "btnSendToTray"
        Me.btnSendToTray.Size = New System.Drawing.Size(87, 23)
        Me.btnSendToTray.TabIndex = 9
        Me.btnSendToTray.Text = "Send to Tray"
        Me.btnSendToTray.UseVisualStyleBackColor = True
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastUpdated.Location = New System.Drawing.Point(181, 10)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(281, 23)
        Me.lblLastUpdated.TabIndex = 10
        Me.lblLastUpdated.Text = "Last Updated: {0}"
        Me.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 520)
        Me.Controls.Add(Me.lblLastUpdated)
        Me.Controls.Add(Me.btnSendToTray)
        Me.Controls.Add(Me.lblPageNumber)
        Me.Controls.Add(Me.lblTotalMessages)
        Me.Controls.Add(Me.cbFolder)
        Me.Controls.Add(Me.lblFolder)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lvMessages)
        Me.Controls.Add(Me.btnSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HF Private Message Notifications"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents niTrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents chMessageTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSender As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDateTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Public WithEvents lvMessages As System.Windows.Forms.ListView
    Friend WithEvents lblFolder As System.Windows.Forms.Label
    Friend WithEvents cbFolder As System.Windows.Forms.ComboBox
    Friend WithEvents PMCheck As System.Windows.Forms.Timer
    Friend WithEvents lblTotalMessages As System.Windows.Forms.Label
    Friend WithEvents lblPageNumber As System.Windows.Forms.Label
    Friend WithEvents btnSendToTray As System.Windows.Forms.Button
    Friend WithEvents lblLastUpdated As System.Windows.Forms.Label

End Class
