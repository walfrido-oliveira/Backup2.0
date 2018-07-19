Imports System.ComponentModel

Public Class Task

    Private nameValue As String
    <DisplayName("Tarefa")> _
    Public Property Name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property

    Private sourceValue As String
    <DisplayName("Origem")> _
    Public Property Source() As String
        Get
            Return sourceValue
        End Get
        Set(ByVal value As String)
            sourceValue = value

        End Set
    End Property

    Private destinationValue As String
    <DisplayName("Destino")> _
    Public Property Destination() As String
        Get
            Return destinationValue
        End Get
        Set(ByVal value As String)
            destinationValue = value
        End Set
    End Property

    Private timeValue As TimeSpan
    <DisplayName("Horário")> _
    Public Property Time() As TimeSpan
        Get
            Return timeValue
        End Get
        Set(ByVal value As TimeSpan)
            timeValue = value
        End Set
    End Property

    Private weekdayValue As DayOfWeek
    <Browsable(False)> _
    Public Property Weekday() As DayOfWeek
        Get
            Return weekdayValue
        End Get
        Set(ByVal value As DayOfWeek)
            weekdayValue = value
        End Set
    End Property

    <DisplayName("Dia da Semana")> _
    Public ReadOnly Property Week() As String
        Get
            Return WeekdayName(weekdayValue + 1, False, FirstDayOfWeek.Sunday)
        End Get
    End Property

End Class
