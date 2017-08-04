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
    End Sub
End Class