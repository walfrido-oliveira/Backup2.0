Public Class TasksXML

    Public APP_XML As String = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) & "\app.xml"

    Public Sub Add(ByVal task As Task)
        Dim xml As New Xml.XmlDocument()
        xml.Load(APP_XML)
        With xml.LastChild.CreateNavigator().AppendChild()
            .WriteStartElement("task")
            .WriteAttributeString("name", task.Name)
            .WriteElementString("source", task.Source)
            .WriteElementString("destination", task.Destination)
            .WriteElementString("time", task.Time.ToString())
            .WriteElementString("weekday", task.Weekday.ToString())
            .Close()
        End With
        xml.Save(APP_XML)
        xml.Clone()
    End Sub

    Public Sub Remove(ByVal name As String)
        Dim xml As New Xml.XmlDocument()
        xml.Load(APP_XML)
        Dim node As Xml.XmlNode = xml.DocumentElement.SelectSingleNode("task[@name='" & name & "']")
        If node IsNot Nothing Then
            xml.DocumentElement.RemoveChild(node)
            xml.Save(APP_XML)
        End If
        xml.Clone()
    End Sub

    Public Function Read() As Generic.List(Of Task)
        Dim xml As Xml.XmlTextReader = New Xml.XmlTextReader(APP_XML)
        Dim tasks As New Generic.List(Of Task)
        Dim lastName As String = String.Empty
        Dim task As Task = Nothing
        If IO.File.Exists(APP_XML) Then
            While xml.Read()
                If xml.NodeType = System.Xml.XmlNodeType.Element Then
                    lastName = xml.Name
                    If lastName.Equals("task") Then
                        task = New Task()
                        task.Name = xml.GetAttribute("name")
                    End If
                End If
                If xml.NodeType = System.Xml.XmlNodeType.Text Then
                    Select Case lastName
                        Case "source" : task.Source = xml.Value
                        Case "destination" : task.Destination = xml.Value
                        Case "time" : task.Time = TimeSpan.Parse(xml.Value)
                        Case "weekday"
                            task.Weekday = CType([Enum].Parse(GetType(DayOfWeek), xml.Value), DayOfWeek)
                            tasks.Add(task)
                    End Select
                End If
            End While
        End If
        xml.Close()
        Return tasks
    End Function

End Class
