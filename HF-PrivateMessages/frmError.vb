Public Class frmError


    Public Sub New(messageError As Boolean, ByVal message As String)

        If messageError Then
            TextBox1.Text = message
        Else
            TextBox1.Text = "An unexpected error has occurred." & vbNewLine & vbNewLine & message
        End If

        Me.ShowDialog()


    End Sub

    Private Sub frmError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = SystemIcons.Error.ToBitmap

        

    End Sub

End Class