Public Class frmSettings

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.Settings.apiKey = txtAPIKey.Text
        My.Settings.Save()

        frmMain.api.setAPIKey(txtAPIKey.Text)

        MessageBox.Show("API Key Updated", "API Key Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAPIKey.Text = My.Settings.apiKey
        nupUpdateInterval.Value = My.Settings.updateInterval / 60000
    End Sub

    Private Sub btnUpdateInterval_Click(sender As Object, e As EventArgs) Handles btnUpdateInterval.Click
        Dim updateInt As Integer
        updateInt = nupUpdateInterval.Value * 60000

        My.Settings.updateInterval = updateInt
        My.Settings.Save()

        frmMain.updateTimerInterval(updateInt)

        MessageBox.Show("Update interval has been updated.", "Update Interval", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class