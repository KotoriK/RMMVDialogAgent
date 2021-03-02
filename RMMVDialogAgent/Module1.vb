Imports System.IO
Imports System.Text

Module StaticMain
    Public LoadingText As String
    Public speakers() As Speaker
    Public speakersCount As Integer
    Public Function loadspeakersFromFile(loadTo As Speaker(), Optional fromFile As String = "")
        If fromFile = "" Then
            fromFile = CStr(My.Settings.Item("SpeakerSave"))
        End If
        Dim reader As StreamReader = New StreamReader(fromFile, Encoding.Default)
        Dim nextChar As String
        Dim validLineCount As Integer = 0
        Dim cache As String = ""
        Dim cacheType As cacheType = 0
        Dim nowLine As String
        Do
            nowLine = reader.ReadLine
            For i = 0 To nowLine.Length - 1
                nextChar = nowLine.Chars(i)
                ' Console.Write(nextChar)
                Select Case nextChar
                    Case "/" '/ description
                        cacheType = cacheType.Useless
                    Case "{"    '新行 {
                        'start line
                        cacheType = cacheType.Name
                        cache = ""'flush cache
                    Case "}"    '换行 }
                        'end line
                        'read the last
                        loadTo(validLineCount).head.index = cache
                        validLineCount += 1
                        'flush cache
                        cacheType = 0
                        cache = ""
                    Case ","      ', 字段的结束
                        'read from cache
                        Select Case cacheType
                            Case cacheType.Name
                                loadTo(validLineCount).name = cache
                            Case cacheType.Headset
                                loadTo(validLineCount).head.headSet = cache
                            Case Else

                        End Select
                        cache = "" 'flush cache
                        cacheType += 1 'change type
                    Case Else
                        cache &= nextChar

                End Select
            Next
        Loop Until reader.EndOfStream = True
        reader.Close()

        Return validLineCount
    End Function
    Private Enum cacheType
        Useless = 0
        Name = 1
        Headset = 2
        Index = 3
    End Enum

End Module
