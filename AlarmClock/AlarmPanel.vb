Imports Microsoft.VisualBasic.Devices
Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class AlarmPanel
    Public Event AlarmOnChanged(sender As Object, e As EventArgs)
    Private soundPlayer As SoundPlayer
    Private soundPath As String = ""
    Private originalHeight As Integer
    Private currentInput_Alarm1 As String = ""

    Private previousAlarm As String = "00:00" ' Variable to store the previous alarm time

    Private customClockTime As DateTime = DateTime.Now 'Variable to store the time
    'Set the picture for alarm tab


    Public Sub StopAlarmSound()
        If soundPlayer IsNot Nothing Then
            soundPlayer.Stop() ' Stop 
            soundPath = "" 'path
        End If
    End Sub


    Public Sub PlayAlarm()
        Select Case cmbSoundSelection.SelectedIndex
            Case 0

            Case 1
                soundPath = "C:\Users\benja\Downloads\mixkit-retro-game-emergency-alarm-1000.wav"
            Case 2
                soundPath = "C:\Users\benja\Downloads\mixkit-vintage-warning-alarm-990.wav"
            Case 3
                soundPath = "C:\Users\benja\Downloads\mixkit-slot-machine-win-alarm-1995.wav"
            Case 4
                soundPath = "C:\Users\benja\Downloads\mixkit-spaceship-alarm-998.wav"

        End Select
        soundPlayer = New SoundPlayer(soundPath)
        soundPlayer.Play()
        soundPlayer.Play()
    End Sub



    'Alarm set time 1
    Private Sub Alarm_Set(ByVal label As Label)
        label.Text = "00:00"
        previousAlarm = label.Text ' Store the default alarm timeDate
        AMAlarm.Checked = True
        PMAlarm.Checked = False
    End Sub


    Private Sub AlarmClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SetLabel(lblClock)
        Alarm_Set(Alarm)
        'Alarm_Set2(Alarm2)
        'Alarm_Set3(Alarm3)
        originalHeight = Me.Height
        cmbSoundSelection.Items.Add("Sound 1 - Default")
        cmbSoundSelection.Items.Add("Sound 2 - Retro")
        cmbSoundSelection.Items.Add("Sound 3 - Vintage")
        cmbSoundSelection.Items.Add("Sound 4 - Slot Machine")
        cmbSoundSelection.Items.Add("Sound 5 - Spaceship")
        cmbSoundSelection.SelectedIndex = 0


    End Sub


    Private Sub btnSetclick(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim parentForm As AlarmClock = TryCast(FindForm(), AlarmClock)
        parentForm.Height += panelKeypadClock.Height
        btnSet.Enabled = False
        btnReset.Enabled = False
        panelKeypadClock.Visible = True
        Height += panelKeypadClock.Height


    End Sub

    Private Sub CancelClock_Click(sender As Object, e As EventArgs) Handles CancelClock.Click
        Dim parentForm As AlarmClock = TryCast(FindForm(), AlarmClock)
        parentForm.Height -= panelKeypadClock.Height
        Height -= panelKeypadClock.Height
        panelKeypadClock.Visible = False
        btnSet.Enabled = True
        btnReset.Enabled = True
        currentInput_Alarm1 = ""
        Alarm.Text = previousAlarm
    End Sub








    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Alarm.Text = previousAlarm
        AMAlarm.Checked = True
        PMAlarm.Checked = False
    End Sub


    Private Sub KeypadButton_Click(sender As Object, e As EventArgs) Handles Number1Clock.Click, Number2Clock.Click, Number3Clock.Click, Number4Clock.Click, Number5Clock.Click, Number6Clock.Click, Number7Clock.Click, Number8Clock.Click, Number9Clock.Click, Number0Clock.Click
        Dim buttonValue = DirectCast(sender, Button).Text
        currentInput_Alarm1 &= buttonValue
        UpdateAlarmDisplay(currentInput_Alarm1)
    End Sub

    Private Sub UpdateAlarmDisplay(input As String)
        'Dim firstHourDigit As String = "0"
        'Dim secondHourDigit As String = "0"
        'Dim firstMinuteDigit As String = "0"
        'Dim secondMinuteDigit As String = "0"

        Select Case input.Length
            Case 1

                If input(0) > "1"c Then
                    currentInput_Alarm1 = ""
                Else

                    Alarm.Text = input & "0" & ":00" ' "0X:00"
                End If
            Case 2
                Dim firstDigit As Char = input(0)
                Dim secondDigit As Char = input(1)


                If firstDigit = "0"c And secondDigit = "0"c Then
                    'Alarm1.Text = "Invalid Input"
                    currentInput_Alarm1 = firstDigit + ""
                ElseIf firstDigit = "1"c And secondDigit > "2"c Then
                    'Alarm1.Text = "Invalid Input"
                    currentInput_Alarm1 = firstDigit + ""
                Else
                    Alarm.Text = input & ":00"
                End If
            Case 3

                If input(2) > "5"c Then
                    'Alarm1.Text = "Invalid Input"
                    currentInput_Alarm1 = input(0) + input(1) + ""
                Else
                    Alarm.Text = input.Substring(0, 2) & ":" & input(2) & "0" ' "XX:X0"
                End If
            Case 4


                Alarm.Text = input.Substring(0, 2) & ":" & input.Substring(2) ' "XX:XX"
            Case Else
                'Alarm1.Text = "Invalid Input"
        End Select
    End Sub





    'Button cancel for alarm 1




    'Button OK for alarm 1
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles OKClock.Click
        Dim parentForm As AlarmClock = TryCast(FindForm(), AlarmClock)
        parentForm.Height -= panelKeypadClock.Height
        Height -= panelKeypadClock.Height
        If currentInput_Alarm1.Length > 0 Then
            previousAlarm = Alarm.Text ' Save the current alarm time before updating
            UpdateAlarmDisplay(currentInput_Alarm1) ' Update the alarm display
        End If
        currentInput_Alarm1 = "" ' Clear the current input after confirming

        panelKeypadClock.Visible = False
        btnSet.Enabled = True
        btnReset.Enabled = True
    End Sub






    Private Sub AMAlarm_CheckedChanged(sender As Object, e As EventArgs) Handles AMAlarm.CheckedChanged
        If AMAlarm.Checked Then
            PMAlarm.Checked = False
        End If
    End Sub

    Private Sub PMAlarm_CheckedChanged(sender As Object, e As EventArgs) Handles PMAlarm.CheckedChanged
        If PMAlarm.Checked Then
            AMAlarm.Checked = False
        End If

    End Sub

    Private Sub AlarmOn_CheckedChanged(sender As Object, e As EventArgs) Handles AlarmOn.CheckedChanged
        RaiseEvent AlarmOnChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub PictureBoxAlarm_Click(sender As Object, e As EventArgs) Handles PictureAlarm.Click
        StopAlarmSound()
        PictureBoxAlarm.Visible = True
        PictureAlarm.Visible = False
    End Sub






    '    Private Sub PictureAlarm1_Click(sender As Object, e As EventArgs) Handles PictureAlarm1.Click, PictureAlarm2.Click, PictureAlarm3.Click
    '        StopAlarmSound()
    '        PictureBoxAlarm1.Visible = True
    '        PictureBoxAlarm2.Visible = True
    '        PictureBoxAlarm3.Visible = True

    '        PictureAlarm1.Visible = False
    '        PictureAlarm2.Visible = False
    '        PictureAlarm3.Visible = False
    '        Picture()
    '    End Sub
End Class
