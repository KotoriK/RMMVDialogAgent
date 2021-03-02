



Public Class frmSetting

    Private Sub cmdActor_Click(sender As Object, e As EventArgs) Handles cmdActor.Click
        frmSpeaker.Show()
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = RMMVDialogAgent.My.Resources.mainRes.bitbug_favicon_32x32
        txtSpeakerFile.Text = RMMVDialogAgent.My.Settings.Item("SpeakerSave")
    End Sub

    Private Sub frmSetting_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSpeakerFile_Click(sender As Object, e As EventArgs) Handles cmdSpeakerFile.Click
        diaOpenFile.Multiselect = False
        diaOpenFile.InitialDirectory = txtSpeakerFile.Text
        Select Case diaOpenFile.ShowDialog()
            Case DialogResult.OK
                Dim t(100) As Speaker
                txtSpeakerFile.Text = diaOpenFile.FileName
                If Not loadspeakersFromFile(t, txtSpeakerFile.Text) > 1 Then
                    MsgBox("文件中没有效数据。")
                End If

                Erase t
            Case DialogResult.Cancel
        End Select
    End Sub

    Private Sub txtSpeakerFile_TextChanged(sender As Object, e As EventArgs) Handles txtSpeakerFile.TextChanged
        RMMVDialogAgent.My.Settings.Item("SpeakerSave") = txtSpeakerFile.Text
    End Sub


End Class