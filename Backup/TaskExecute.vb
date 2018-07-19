Imports Backup.Core

Public Class TaskExecute
    Public Sub Execute()
        Try
            Dim xml As New TasksXML()
            For Each item As Task In xml.Read()
                If item.Time.Hours = Now.Hour And item.Time.Minutes = Now.Minute And _
                   item.Time.Seconds = Now.Second And Now.DayOfWeek = item.Weekday Then
                    Backup.SetLog("Backup [" & item.Name & "] inicializado - " & item.Source & " --> " & item.Destination & " - " & Now.ToString())
                    Dim thread As Threading.Thread = New Threading.Thread(New Threading.ParameterizedThreadStart(AddressOf Copy))
                    thread.IsBackground = True
                    thread.Start(item)
                    System.Threading.Thread.Sleep(1000)
                End If
            Next
        Catch ex As Exception
            Backup.SetLog(ex.Message)
        End Try
    End Sub

    Public Sub Copy(ByVal item As Task)
        Try
            My.Computer.FileSystem.CopyDirectory(item.Source, item.Destination & "\" & Utils.GetLastFolder(item.Source), True)
            Backup.SetLog("Backup [" & item.Name & "] finalizado " & " - " & Now.ToString())
        Catch ex As Exception
            Backup.SetLog(ex.Message)
        End Try
    End Sub
End Class
