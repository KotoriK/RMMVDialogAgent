Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbCap.Text = LoadingText
        Me.Icon = RMMVDialogAgent.My.Resources.mainRes.bitbug_favicon_32x32
    End Sub
End Class