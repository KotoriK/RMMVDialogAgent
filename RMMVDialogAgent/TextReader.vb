Public Class TextReader
    Private rawText As String()
    Private dialogs(） As Dialog
    Private mStartLine As Integer
    Private status As contentType
    Private nowDialog As Integer
    Public endDialog As Integer
    Public Sub Initialize(rawInlines As String(), startLine As Integer)
        rawText = rawInlines
        mStartLine = startLine
        ReDim dialogs(rawInlines.Length - startLine + 1)
    End Sub
    Public Function read() As Dialog()
        nowDialog = 0
        Call dialogs(nowDialog).doReady()
        Dim para() = {-1, -1}
        For nowLine = (mStartLine - 1) To (rawText.Length - 1)
            Select Case status
                Case contentType.ctUnrecognized

                Case contentType.ctName
                    'Expecting dialog

                    '检查这一行是否为空，若是 标记现在正在操作的dialog填写完毕，切换至下一个dialog
                    If rawText(nowLine).Trim(" ") = "" Then
                        status = contentType.ctEndOfDialog
                        doRead()
                        Exit Select
                    End If
                    status = contentType.ctDialog
                    doRead(nowLine)
                Case contentType.ctDialog
                    '检查这一行是否为空，若是 标记现在正在操作的dialog填写完毕，切换至下一个dialog
                    If rawText(nowLine).Trim(" ") = "" Then
                        status = contentType.ctEndOfDialog
                        doRead()
                        Exit Select
                    End If
                    status = contentType.ctDialog
                    doRead(nowLine)
                Case contentType.ctDescription
                    '检查这一行是否为空，若是 标记现在正在操作的dialog填写完毕，切换至下一个dialog
                    If rawText(nowLine).Trim(" ") = "" Then
                        status = contentType.ctEndOfDialog
                        doRead()
                        Exit Select
                    End If
                    status = contentType.ctDescription
                    doRead(nowLine)
                Case Else

                    If rawText(nowLine).LastIndexOf("：") <= 0 Then
                        If rawText(nowLine).LastIndexOf(":") <= 0 Then
                            'description line
                            '检查这一行是否为空，若是 标记ctNothing
                            If rawText(nowLine).Trim(" ") = "" Then
                                status = contentType.ctNothing
                                Exit Select
                            Else
                                status = contentType.ctDescription
                                doRead(nowLine)
                            End If
                        Else
                            'Name Line
                            status = contentType.ctName
                            doRead(nowLine, rawText(nowLine).LastIndexOf(":"))
                            '传递这一行冒号的位置
                        End If
                    Else
                        'Name Line
                        status = contentType.ctName
                        doRead(nowLine, rawText(nowLine).LastIndexOf("：")) '传递这一行冒号的位置                 
                    End If


            End Select

        Next
        endDialog = nowDialog - 1
        Return dialogs
    End Function
    Private Sub doRead(ParamArray ByVal para() As Object)
        Select Case status
            Case contentType.ctName
                Dim temp As String
                temp = String.Empty
                For j = 0 To para(1) - 1
                    temp = temp & rawText(para(0)).Chars(j)

                Next
                dialogs(nowDialog).dialogType = DialogType.Dialog
                dialogs(nowDialog).speaker.name = temp
                dialogs(nowDialog).speaker.fillHead()'根据角色列表自动填充
            Case contentType.ctDialog
                Dim temp As String
                temp = String.Empty
                For j = 0 To rawText(para(0)).Length - 1
                    temp = temp & rawText(para(0)).Chars(j)

                Next
                Call dialogs(nowDialog).addContent(temp)
            Case contentType.ctDescription
                Dim temp As String
                temp = String.Empty
                For j = 0 To rawText(para(0)).Length - 1
                    temp = temp & rawText(para(0)).Chars(j)

                Next
                dialogs(nowDialog).dialogType = DialogType.Description
                Call dialogs(nowDialog).addContent(temp)
            Case contentType.ctEndOfDialog
                nowDialog = nowDialog + 1
                Call dialogs(nowDialog).doReady()
        End Select
    End Sub


End Class
Public Enum contentType
    ctNothing = 0
    ctName = 1
    ctDialog = 2
    ctEndOfDialog = 3
    ctDescription = 4
    ctUnrecognized = 255
End Enum

