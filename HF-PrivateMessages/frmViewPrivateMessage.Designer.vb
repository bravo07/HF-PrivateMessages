<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPrivateMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewPrivateMessage))
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.lblSenderText = New System.Windows.Forms.Label()
        Me.lblSubjectText = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(12, 36)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 13)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Subject:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(5, 62)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(53, 13)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Message:"
        '
        'lblSender
        '
        Me.lblSender.AutoSize = True
        Me.lblSender.Location = New System.Drawing.Point(14, 10)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(44, 13)
        Me.lblSender.TabIndex = 4
        Me.lblSender.Text = "Sender:"
        '
        'lblSenderText
        '
        Me.lblSenderText.AutoSize = True
        Me.lblSenderText.Location = New System.Drawing.Point(61, 10)
        Me.lblSenderText.Name = "lblSenderText"
        Me.lblSenderText.Size = New System.Drawing.Size(39, 13)
        Me.lblSenderText.TabIndex = 7
        Me.lblSenderText.Text = "Label1"
        '
        'lblSubjectText
        '
        Me.lblSubjectText.AutoSize = True
        Me.lblSubjectText.Location = New System.Drawing.Point(61, 36)
        Me.lblSubjectText.Name = "lblSubjectText"
        Me.lblSubjectText.Size = New System.Drawing.Size(39, 13)
        Me.lblSubjectText.TabIndex = 8
        Me.lblSubjectText.Text = "Label2"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(64, 59)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(479, 227)
        Me.txtMessage.TabIndex = 9
        Me.txtMessage.Text = ""
        '
        'btnReply
        '
        Me.btnReply.Enabled = False
        Me.btnReply.Location = New System.Drawing.Point(468, 292)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(75, 23)
        Me.btnReply.TabIndex = 10
        Me.btnReply.Text = "Reply"
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Enabled = False
        Me.btnForward.Location = New System.Drawing.Point(387, 292)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(75, 23)
        Me.btnForward.TabIndex = 11
        Me.btnForward.Text = "Forward"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(64, 292)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmViewPrivateMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 327)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblSubjectText)
        Me.Controls.Add(Me.lblSenderText)
        Me.Controls.Add(Me.lblSender)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblSubject)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewPrivateMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HF Private Message Notifications - View Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblSender As System.Windows.Forms.Label
    Friend WithEvents lblSenderText As System.Windows.Forms.Label
    Friend WithEvents lblSubjectText As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents btnReply As System.Windows.Forms.Button
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
