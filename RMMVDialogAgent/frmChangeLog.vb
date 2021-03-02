Public Class frmChangeLog
    Private Sub frmChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = System.Windows.Forms.Application.ProductName & "更新记录"
        Me.Icon = frmMain.Icon
        txt.Text = RMMVDialogAgent.My.Resources.mainRes.ChangeLog
        txt.Select(txt.Text.Length, 0)
    End Sub
End Class