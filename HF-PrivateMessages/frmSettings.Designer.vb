<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.txtAPIKey = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateInterval = New System.Windows.Forms.Button()
        Me.nupUpdateInterval = New System.Windows.Forms.NumericUpDown()
        Me.gbAPIKey = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nupUpdateInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAPIKey.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAPIKey
        '
        Me.txtAPIKey.Location = New System.Drawing.Point(6, 18)
        Me.txtAPIKey.MaxLength = 32
        Me.txtAPIKey.Name = "txtAPIKey"
        Me.txtAPIKey.Size = New System.Drawing.Size(252, 20)
        Me.txtAPIKey.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(6, 44)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(253, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update API Key"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nupUpdateInterval)
        Me.GroupBox1.Controls.Add(Me.btnUpdateInterval)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 80)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Refresh Interval (Minutes)"
        '
        'btnUpdateInterval
        '
        Me.btnUpdateInterval.Location = New System.Drawing.Point(6, 46)
        Me.btnUpdateInterval.Name = "btnUpdateInterval"
        Me.btnUpdateInterval.Size = New System.Drawing.Size(252, 23)
        Me.btnUpdateInterval.TabIndex = 5
        Me.btnUpdateInterval.Text = "Update Refresh Interval"
        Me.btnUpdateInterval.UseVisualStyleBackColor = True
        '
        'nupUpdateInterval
        '
        Me.nupUpdateInterval.Location = New System.Drawing.Point(7, 20)
        Me.nupUpdateInterval.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nupUpdateInterval.Name = "nupUpdateInterval"
        Me.nupUpdateInterval.Size = New System.Drawing.Size(251, 20)
        Me.nupUpdateInterval.TabIndex = 6
        '
        'gbAPIKey
        '
        Me.gbAPIKey.Controls.Add(Me.txtAPIKey)
        Me.gbAPIKey.Controls.Add(Me.btnUpdate)
        Me.gbAPIKey.Location = New System.Drawing.Point(12, 12)
        Me.gbAPIKey.Name = "gbAPIKey"
        Me.gbAPIKey.Size = New System.Drawing.Size(264, 81)
        Me.gbAPIKey.TabIndex = 5
        Me.gbAPIKey.TabStop = False
        Me.gbAPIKey.Text = "API Key"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 192)
        Me.Controls.Add(Me.gbAPIKey)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nupUpdateInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAPIKey.ResumeLayout(False)
        Me.gbAPIKey.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAPIKey As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateInterval As System.Windows.Forms.Button
    Friend WithEvents nupUpdateInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbAPIKey As System.Windows.Forms.GroupBox
End Class
