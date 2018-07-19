Imports Backup.Core

Public Class Conf

    Private taskXML As New TasksXML()

    Private Sub Conf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFields()
    End Sub

    Private Sub LoadFields()
        Me.dgv.DataSource = taskXML.Read()
    End Sub

    Private Sub SertFields()
        If Me.dgv.CurrentRow IsNot Nothing Then
            Dim task As Task = CType(Me.dgv.CurrentRow.DataBoundItem, Task)
            Me.txtName.Text = task.Name
            Me.txtSource.Text = task.Source
            Me.txtDestination.Text = task.Destination
            Me.dtpTime.Value = New Date(Now.Year, Now.Month, Now.Day, task.Time.Hours, task.Time.Minutes, task.Time.Seconds)
            Me.cboWeekDay.SelectedIndex = task.Weekday
        End If
    End Sub

    Private Sub dgv_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv.CurrentCellChanged
        SertFields()
    End Sub

    Private Sub Add()
        If Not String.IsNullOrEmpty(Me.txtName.Text) _
           And Not String.IsNullOrEmpty(Me.txtSource.Text) _
           And Not String.IsNullOrEmpty(Me.txtDestination.Text) _
           And Me.cboWeekDay.SelectedIndex > -1 Then
            Dim task As New Task()
            task.Name = Me.txtName.Text
            task.Source = Me.txtSource.Text
            task.Destination = Me.txtDestination.Text
            task.Time = New TimeSpan(Me.dtpTime.Value.Hour, Me.dtpTime.Value.Minute, Me.dtpTime.Value.Second)
            task.Weekday = CType(cboWeekDay.SelectedIndex, DayOfWeek)
            taskXML.Add(task)
            LoadFields()
        End If
    End Sub

    Private Sub Remove()
        taskXML.Remove(Me.txtName.Text)
        LoadFields()
    End Sub

 
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearFields()
        EnableFields(False)
        SertFields()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearFields()
        EnableFields(True)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Add()
        ClearFields()
        EnableFields(False)
        SertFields()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Remove()
        ClearFields()
        EnableFields(False)
        SertFields()
    End Sub

    Private Sub ClearFields()
        Me.txtName.Clear()
        Me.txtSource.Clear()
        Me.txtDestination.Clear()
        Me.dtpTime.Value = Now
        Me.cboWeekDay.SelectedIndex = -1
    End Sub

    Private Sub EnableFields(ByVal enable As Boolean)
        Me.pnl.Enabled = enable
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    If Me.dgv.CurrentRow IsNot Nothing Then
    '        Dim task As Task = CType(Me.dgv.CurrentRow.DataBoundItem, Task)
    '        Copy(task)
    '    End If

    'End Sub

    'Public Sub Copy(ByVal item As Task)
    '    Try
    '        My.Computer.FileSystem.CopyDirectory(item.Source, item.Destination, True)
    '        'Dim full() As String = IO.Directory.GetDirectories(item.Source)
    '        'For Each dir As String In full
    '        '    MsgBox(dir)
    '        '    'IO.Directory.CreateDirectory(item.Destination & "\" & Utils.GetLastFolder(dir))
    '        '    'Dim fullFiles() As String = IO.Directory.GetFiles(dir, "*.*", IO.SearchOption.AllDirectories)
    '        '    'For Each file As String In fullFiles
    '        '    '    MsgBox(file)
    '        '    'Next
    '        'Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
End Class
