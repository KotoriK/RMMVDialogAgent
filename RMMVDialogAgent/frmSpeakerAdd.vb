Public Class frmSpeakerAdd
    Private Sub frmSpeakerAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = RMMVDialogAgent.My.Resources.mainRes.bitbug_favicon_32x32
        lbMore.Text = ""
    End Sub

    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
        If txtHeadset.Text = String.Empty Xor txtIndex.Text = String.Empty Then
            lbMore.Text = ChrW(34) & lbHeadset.Text.Trim(":") & ChrW(34) & "和" & ChrW(34) & lbIndex.Text.Trim(":") & ChrW(34) & "不能单独为空！"
            Exit Sub
        End If
        If IsNumeric(txtIndex.Text) = False Then
            lbMore.Text = ChrW(34) & lbIndex.Text.Trim(":") & ChrW(34) & "应为数字！"
            Exit Sub
        End If
        Dim a = ""
        a = frmSpeaker.AddItem(frmSpeaker.listType.Name, txtName.Text)
        If a = "" Then
            frmSpeaker.AddItem(frmSpeaker.listType.Headset, txtHeadset.Text)
            frmSpeaker.AddItem(frmSpeaker.listType.Index, txtIndex.Text)
            Me.Close()
        Else
            lbMore.Text = a
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class