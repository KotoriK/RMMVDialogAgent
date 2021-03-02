Imports System.ComponentModel

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = System.Windows.Forms.Application.ProductName

        'speakers(0).name = "A"
        'speakers(0).head.headSet = "asd"
        'speakers(0).head.index = 1
        'speakers(1).name = "B"
        'speakers(1).head.headSet = "bsa"
        'speakers(1).head.index = 2
        'speakers(2).name = "C"
        'speakers(2).head.headSet = "cfg"
        'speakers(2).head.index = 3
        'loadspeakersFromFile()
    End Sub

    Private Sub cmdTransform_Click(sender As Object, e As EventArgs) Handles cmdTransform.Click

        If txtStartLine.Text = "" Then
            MsgBox("未输入起始行位置。")
        Else
            txtTransformed.Text = "" '清空
            LoadingText = "正在转换"
            frmLoading.Show()


            Dim a As New TextReader
            Dim b As Dialog()

            a.Initialize(txtRaw.Lines, txtStartLine.Text)

            b = a.read()
            If Not a.endDialog = 0 Then
                For i = 0 To a.endDialog
                    txtTransformed.Text &= b(i).summonJSONAll() & "," & ChrW(10)
                    frmLoading.pBar.Value = i / a.endDialog * 100
                Next
            Else
                For i = 0 To a.endDialog
                    txtTransformed.Text &= b(i).summonJSONAll() & "," & ChrW(10)

                Next
            End If
            frmLoading.Close()

        End If
    End Sub

    Private Sub txtStartLine_TextChanged(sender As Object, e As EventArgs) Handles txtStartLine.TextChanged

    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        spC.Left = grpCtrl.Width + grpCtrl.Left + 5
        spC.Width = Me.Width - grpCtrl.Width - 20
        spC.Height = Me.Height - spC.Top - StatusStrip1.Height - 36
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub cmdSetting_Click(sender As Object, e As EventArgs) Handles cmdSetting.Click
        frmSetting.Show()
        'loadspeakersFromFile()
    End Sub


    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Item("SpeakerCount") = speakersCount
    End Sub

    Private Sub bgW_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgW.DoWork
        Dim result
        result = loadspeakersFromFile(speakers)
        e.Result = result
        speakersCount = result
    End Sub

    Private Sub bgW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgW.RunWorkerCompleted
        cmdTransform.Enabled = True
        lbStatus.Text = "就绪。"
    End Sub

    Public Sub startLoad()
        bgW.RunWorkerAsync()
        cmdTransform.Enabled = False
        lbStatus.Text = "正在从" & ChrW(34) & My.Settings.Item("SpeakerSave") & ChrW(34) & "读取角色列表。"
    End Sub
End Class
