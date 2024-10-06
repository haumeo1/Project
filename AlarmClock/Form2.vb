Public Class Form2
    Private alarmClockRef As AlarmClock
    Public Sub New(alarmClock As AlarmClock)

        InitializeComponent()
        alarmClockRef = alarmClock
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        alarmClockRef.StopAlarmSound()
        Me.Close()
    End Sub
End Class