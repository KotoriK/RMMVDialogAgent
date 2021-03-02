'JSON Tamplate
'/////////
'dialog
'{
'"code":101,
'"indent":0,
'"parameters":["Actor1",0,0,2]
'},
'{"code":401,
'"indent":0,
'"parameters":["等一下，里面好像有人！\\n<公孙炑>"]
' }
'增添新的一行也是401
'///
'description
'{"code":108,"indent":0,"parameters":["2018.8.20"]},{"code":408,"indent":0,"parameters":["移动了位置后无法触发"]}
'command108注释首行 command408注释次行
'/////////char unicode
'ChrW(34)="
Public Structure  Dialog
    Public speaker As Speaker
    Public contents() As String
    Public LastEmptyIndexOfcontent As Integer
    Public dialogType As DialogType
    Public Sub doReady()
        ReDim contents(100)
    End Sub
    Public Sub addContent(add As String)
        If LastEmptyIndexOfcontent = Nothing Then
            LastEmptyIndexOfcontent = 0

        End If
        contents.SetValue(add, (LastEmptyIndexOfcontent))
        LastEmptyIndexOfcontent += 1
    End Sub

    Public Function summonJSONbyIndex(contentsIndex As Integer, Optional attachSpeakerName As Boolean = False, Optional isFirstLineDesc As Boolean = False) As String '返回command401相关
        Dim temp As String
        Select Case dialogType
            Case DialogType.Dialog
                temp = "{" & ChrW(34) & "code" & ChrW(34） & ":401," & ChrW(34） & "indent" & ChrW(34） & ":0," & ChrW(34） & "parameters" & ChrW(34） & ":["
                Select Case attachSpeakerName
                    Case False
                        temp = temp & ChrW(34) & contents(contentsIndex) & ChrW(34) & "]}"
                    Case True
                        temp = temp & ChrW(34) & contents(contentsIndex) & speaker.getControlString() & ChrW(34) & "]}"
                End Select
            Case DialogType.Description
                '若为首行 则返回code为108的反之返回code为408的
                If isFirstLineDesc = True Then
                    temp = "{" & ChrW(34) & "code" & ChrW(34） & ":108," & ChrW(34） & "indent" & ChrW(34） & ":0," & ChrW(34） & "parameters" & ChrW(34） & ":["
                Else
                    temp = "{" & ChrW(34) & "code" & ChrW(34） & ":408," & ChrW(34） & "indent" & ChrW(34） & ":0," & ChrW(34） & "parameters" & ChrW(34） & ":["
                End If
                temp &= ChrW(34) & contents(contentsIndex) & ChrW(34) & "]}"
        End Select
        Return temp
    End Function
    Public Function summonJSONAll() As String
        Dim temp = ""
        If dialogType = DialogType.Dialog Then
            temp &= speaker.head.summonJSON & ","
        End If
        If LastEmptyIndexOfcontent >= 2 Then

            For i = 0 To (LastEmptyIndexOfcontent - 2)
                temp = temp & summonJSONbyIndex(i) & ","

            Next
            '若speaker非空，在最后一行json上附加控制符号
            'description类型的dialog正常来讲不会有speaker
            If speaker.isEmpty = False Then
                temp = temp & summonJSONbyIndex(LastEmptyIndexOfcontent - 1, True)
            Else
                temp = temp & summonJSONbyIndex(LastEmptyIndexOfcontent - 1, False)
            End If
        Else
            If LastEmptyIndexOfcontent = 1 Then

            Else
                LastEmptyIndexOfcontent = 1
                '简单暴力解决空content
                '若之后需要使用LastEmptyIndexOfcontent的准确值 需要修改
            End If
            If speaker.isEmpty = False Then 'LastEmptyIndexOfcontent=1
                temp = temp & summonJSONbyIndex(LastEmptyIndexOfcontent - 1, True, True)
            Else
                temp = temp & summonJSONbyIndex(LastEmptyIndexOfcontent - 1, False, True)
            End If '此处没有区分dialog和description
        End If
        Return temp
    End Function

End Structure
Public Structure Speaker
    Public head As SpeakerHead
    Public name As String
    Public Function getControlString() As String
        Return "\\n<" & name & ">"
    End Function '返回控制字符\n <name>
    Public ReadOnly Property isEmpty As Boolean
        Get '若姓名非空则返回非空
            If name = "" Then Return True Else Return False
        End Get
    End Property
    Public Sub fillHead()
        Dim temp
        For i = 0 To speakersCount - 1
            If speakers(i).name = name Then
                temp = i
                head.headSet = speakers(temp).head.headSet
                head.index = speakers(temp).head.index
                Exit For
            End If
        Next

    End Sub
End Structure
Public Structure SpeakerHead
    Public headSet As String
    Public index As Integer

    Public Function summonJSON() As String
        Dim temp As String
        temp = "{" & ChrW(34) & "code" & ChrW(34） & ":101," & ChrW(34） & "indent" & ChrW(34） & ":0," & ChrW(34） & "parameters" & ChrW(34） & ":["
        temp = temp & ChrW(34） & headSet & ChrW(34） & "," & index.ToString & ",0,2]}"
        Return temp
    End Function '返回command101相关json
End Structure
Public Enum DialogType
    Dialog = 1
    Description = 2
End Enum
