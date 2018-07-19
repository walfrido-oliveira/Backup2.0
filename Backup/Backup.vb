Imports System.IO

Public Class Backup

    Private timer As System.Threading.Timer
    Private exe As TaskExecute
    Private Shared block As Boolean = False

    Protected Overrides Sub OnStart(ByVal args() As String)
        exe = New TaskExecute
        SetLog("Serviço iniciado " & Now.ToString())
        Me.timer = New System.Threading.Timer(New System.Threading.TimerCallback(AddressOf Timer1_Tick), Nothing, 1000, 1000)
    End Sub

    Protected Overrides Sub OnStop()
        SetLog("Serviço parado " & Now.ToString())
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object)
        Try
            exe.Execute()
        Catch ex As Exception
            SetLog(ex.Message)
        End Try
    End Sub

    Public Shared Sub SetLog(ByVal value As String)
        Try
            If block Then Exit Sub Else block = True
            Dim ws As StreamWriter = New StreamWriter(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) & "\log.txt", True)
            ws.WriteLine(value)
            ws.Flush()
            ws.Close()
            block = False
        Catch ex As Exception
        End Try
    End Sub

End Class
