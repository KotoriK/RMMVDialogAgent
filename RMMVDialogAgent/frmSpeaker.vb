Imports System.ComponentModel

Public Class frmSpeaker
    Private SelectUpdating As Boolean
    Private Sub frmSpeaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstName.BeginUpdate()
        lstIndex.BeginUpdate()
        lstHeadset.BeginUpdate()
        For i = 0 To speakersCount - 1
            lstName.Items.Add(speakers(i).name)
            lstIndex.Items.Add(speakers(i).head.index)
            lstHeadset.Items.Add(speakers(i).head.headSet)
        Next
        lstName.EndUpdate()
        lstIndex.EndUpdate()
        lstHeadset.EndUpdate()
    End Sub

    Private Sub lstName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstName.SelectedIndexChanged
        If SelectUpdating = False Then
            SelectUpdating = True
            Try
                For j = 0 To (lstIndex.Items.Count - 1)
                    lstIndex.SetSelected(j, False)
                Next
                For k = 0 To (lstHeadset.Items.Count - 1)
                    lstHeadset.SetSelected(k, False)
                Next
                For i = 0 To (lstName.SelectedIndices.Count - 1)
                    lstIndex.SetSelected((lstName.SelectedIndices(i)), True)
                    lstHeadset.SetSelected((lstName.SelectedIndices(i)), True)
                Next
            Catch
            End Try
            SelectUpdating = False
        Else

        End If
    End Sub

    Private Sub lstHeadset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHeadset.SelectedIndexChanged
        If SelectUpdating = False Then
            SelectUpdating = True

            Try
                For j = 0 To (lstName.Items.Count - 1)
                    lstName.SetSelected(j, False)
                Next
                For k = 0 To (lstIndex.Items.Count - 1)
                    lstIndex.SetSelected(k, False)
                Next
                For i = 0 To (lstHeadset.SelectedIndices.Count - 1)
                    lstName.SetSelected((lstHeadset.SelectedIndices(i)), True)
                    lstIndex.SetSelected((lstHeadset.SelectedIndices(i)), True)
                Next
            Catch
            End Try
            SelectUpdating = False
        Else

        End If
    End Sub

    Private Sub lstIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIndex.SelectedIndexChanged
        If SelectUpdating = False Then
            SelectUpdating = True
            Try
                For j = 0 To (lstName.Items.Count - 1)
                    lstName.SetSelected(j, False)
                Next
                For k = 0 To (lstHeadset.Items.Count - 1)
                    lstHeadset.SetSelected(k, False)
                Next
                For i = 0 To (lstIndex.SelectedIndices.Count - 1)
                    lstName.SetSelected((lstIndex.SelectedIndices(i)), True)
                    lstHeadset.SetSelected((lstIndex.SelectedIndices(i)), True)
                Next
            Catch
            End Try
            SelectUpdating = False
        Else

        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        frmSpeakerAdd.Show()
    End Sub
    Public Function AddItem(addToList As listType, content As String) As String

        Select Case addToList
            Case 1
                If lstName.Items.IndexOf(content) = -1 Then
                    lstName.BeginUpdate()
                    lstName.Items.Add(content)
                    lstName.EndUpdate()
                Else
                    Return "这个角色已经存在。"
                    Exit Function
                End If
            Case 2
                lstHeadset.BeginUpdate()
                lstHeadset.Items.Add(content)
                lstHeadset.EndUpdate()
            Case 3
                lstIndex.BeginUpdate()
                lstIndex.Items.Add(content)
                lstIndex.EndUpdate()
        End Select
        Return ""
    End Function
    Private Sub frmSpeaker_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For i = 0 To lstName.Items.Count - 1
            With speakers(i)
                .name = lstName.Items(i)
                .head.headSet = lstHeadset.Items(i)
                .head.index = lstIndex.Items(i)
            End With
            speakersCount = lstName.Items.Count
        Next
    End Sub



    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        SelectUpdating = True
        For i = 0 To lstName.SelectedIndices.Count - 1
            lstName.BeginUpdate()
            lstIndex.BeginUpdate()
            lstHeadset.BeginUpdate()
            lstName.Items.RemoveAt(lstName.SelectedIndices(i))
            lstHeadset.Items.RemoveAt(lstHeadset.SelectedIndices(i))
            lstIndex.Items.RemoveAt(lstIndex.SelectedIndices(i))
            lstName.EndUpdate()
            lstIndex.EndUpdate()
            lstHeadset.EndUpdate()
        Next
        SelectUpdating = False
    End Sub
    Public Enum listType
        Name = 1
        Headset = 2
        Index = 3
    End Enum

    Private Sub cmdRefreshfromFile_Click(sender As Object, e As EventArgs) Handles cmdRefreshfromFile.Click
        loadspeakersFromFile(speakers)
        lstName.BeginUpdate()
        lstIndex.BeginUpdate()
        lstHeadset.BeginUpdate()
        For i = 0 To lstName.Items.Count - 1
            lstName.Items.RemoveAt(0)
            lstHeadset.Items.RemoveAt(0)
            lstIndex.Items.RemoveAt(0)
        Next
        lstName.EndUpdate()
        lstIndex.EndUpdate()
        lstHeadset.EndUpdate()
        Call frmSpeaker_Load(Me, e)
    End Sub
End Class