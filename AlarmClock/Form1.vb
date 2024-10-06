Imports System.Media
Imports System.Runtime.CompilerServices


Public Class AlarmClock
    Private soundPlayer As SoundPlayer
    Private soundPath As String = ""
    Private originalHeight As Integer
    Private currentInput_Alarm1 As String = ""
    Private currentInput_Clock As String = ""
    Private previousAlarmTime As String = "00:00" ' Variable to store the previous alarm time
    Private customClockTime As DateTime = DateTime.Now 'Variable to store the time
    Public Sub StopAlarmSound()
        If SoundPlayer IsNot Nothing Then
            SoundPlayer.Stop() ' Stop the sound player
            soundPath = "" ' Clear the sound path to ensure no further sound is played
        End If
    End Sub
    Private Sub SetLabel(ByVal label As Label)
        Timer2.Interval = 600
        Timer2.Start()
        label.Text = customClockTime.ToString("hh:mm")
    End Sub

    Private Sub Alarm_Set(ByVal label As Label)
        label.Text = "00:00"
        previousAlarmTime = label.Text ' Store the default alarm timeDate
    End Sub

    Private Sub AlarmClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLabel(lblClock)
        Alarm_Set(Alarm1)
        originalHeight = Me.Height
        cmbSoundSelection.Items.Add("Sound 1 - Default")
        cmbSoundSelection.Items.Add("Sound 2 - Retro")
        cmbSoundSelection.Items.Add("Sound 3 - Vintage")
        cmbSoundSelection.Items.Add("Sound 4 - Slot Machine")
        cmbSoundSelection.Items.Add("Sound 5 - Spaceship")
        cmbSoundSelection.SelectedIndex = 0

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'lblClock.Text = DateTime.Now.ToString("hh:mm")
        customClockTime = customClockTime.AddSeconds(1)
        lblClock.Text = customClockTime.ToString("hh:mm")
        CheckAlarm()
    End Sub

    Private Sub CheckAlarm()
        ' Alarm checking logic here
        If lblClock.Text = Alarm1.Text And Alarm1On.Checked Then
            Timer2.Stop()
            ' Alarm1 is triggered
            'Alarm1On.Checked = False
            'Alarm1On.Enabled = False
            PlayAlarm()
            Dim alarmForm As New Form2(Me)
            alarmForm.ShowDialog()

        End If
    End Sub

    Private Sub PlayAlarm()
        Select Case cmbSoundSelection.SelectedIndex
            Case 0
                soundPath = "C:\Users\benja\Downloads\mixkit-classic-alarm-995.wav"  ' Path to Sound 1 
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
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnSet.Click
        panelKeypad1.Visible = True
        TabControl1.Height += panelKeypad1.Height
        Height += panelKeypad1.Height
        btnSet.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub Cancel_btn()
        TabControl1.Height -= panelKeypad1.Height
        Height -= panelKeypad1.Height
        panelKeypad1.Visible = False
        btnSet.Enabled = True
        btnReset.Enabled = True
        currentInput_Alarm1 = ""
        Alarm1.Text = previousAlarmTime ' Restore the previous alarm time
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Alarm_Set(Alarm1)
    End Sub

    Private Sub KeypadButton_Click(sender As Object, e As EventArgs) Handles Number1.Click, Number2.Click, Number3.Click, Number4.Click, Number5.Click, Number6.Click, Number7.Click, Number8.Click, Number9.Click, Number0.Click
        Dim buttonValue = DirectCast(sender, Button).Text
        currentInput_Alarm1 &= buttonValue
        UpdateAlarmDisplay(currentInput_Alarm1)
    End Sub

    Private Sub UpdateAlarmDisplay(input As String)
        ' Format the alarm time based on the length of the input
        Select Case input.Length
            Case 1
                If input(0) > "1"c Then
                    currentInput_Alarm1 = ""
                Else

                    Alarm1.Text = input & "0" & ":00" ' "0X:00"
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
                    Alarm1.Text = input & ":00"
                End If
            Case 3
                If input(2) > "5"c Then
                    'Alarm1.Text = "Invalid Input"
                    currentInput_Alarm1 = input(0) + input(1) + ""
                Else
                    Alarm1.Text = input.Substring(0, 2) & ":" & input(2) & "0" ' "XX:X0"
                End If
            Case 4
                Alarm1.Text = input.Substring(0, 2) & ":" & input.Substring(2) ' "XX:XX"
            Case Else
                'Alarm1.Text = "Invalid Input"
        End Select
    End Sub



    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Cancel_btn()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If currentInput_Alarm1.Length > 0 Then
            previousAlarmTime = Alarm1.Text ' Save the current alarm time before updating
            UpdateAlarmDisplay(currentInput_Alarm1) ' Update the alarm display
        End If
        currentInput_Alarm1 = "" ' Clear the current input after confirming
        TabControl1.Height -= panelKeypad1.Height
        Height -= panelKeypad1.Height
        panelKeypad1.Visible = False
        btnSet.Enabled = True
        btnReset.Enabled = True
    End Sub


    Private Sub SetClock_Click(sender As Object, e As EventArgs) Handles SetClock.Click
        'Dim inputTime As String = "" 'InputBox("Enter time in hh:mm format", "Set Clock") ' Ask user for time input
        'Dim resultTime As DateTime

        '' Validate the input
        'If DateTime.TryParseExact(inputTime, "hh:mm", Nothing, Globalization.DateTimeStyles.None, resultTime) Then
        '    customClockTime = resultTime ' Update the clock to the custom time
        '    lblClock.Text = customClockTime.ToString("hh:mm") ' Display the new time
        'Else
        '    MessageBox.Show("Invalid time format. Please enter in hh:mm format.")
        'End If
        customClockTime = New DateTime(1, 1, 1, 0, 0, 0) ' Represents "00:00"
        lblClock.Text = customClockTime.ToString("HH:mm")
        Timer2.Stop()
        panelKeypadClock.Visible = True
        TabControl1.Height += panelKeypadClock.Height
        Height += panelKeypadClock.Height
        SetClock.Enabled = False
        ResetClock.Enabled = False

    End Sub

    Private Sub ResetClock_Click(sender As Object, e As EventArgs) Handles ResetClock.Click
        customClockTime = DateTime.Now
        SetLabel(lblClock)
    End Sub

    Private Sub ClockPad_Click(sender As Object, e As EventArgs) Handles Number1Clock.Click, Number2Clock.Click, Number3Clock.Click, Number4Clock.Click, Number5Clock.Click, Number6Clock.Click, Number7Clock.Click, Number8Clock.Click, Number9Clock.Click, Number0Clock.Click
        Dim buttonValueClock = DirectCast(sender, Button).Text
        currentInput_Clock &= buttonValueClock
        UpdateClockDisplay(currentInput_Clock)
    End Sub
    Private Sub UpdateClockDisplay(input As String)
        ' Format the clock time based on the length of the input
        Select Case input.Length
            Case 1

                If input(0) > "1"c Then
                    currentInput_Clock = ""
                Else

                    lblClock.Text = input & "0" & ":00" ' "0X:00"
                End If
            Case 2
                Dim firstDigit As Char = input(0)
                Dim secondDigit As Char = input(1)

                If firstDigit = "0"c And secondDigit = "0"c Then
                    currentInput_Clock = ""
                ElseIf firstDigit = "1"c And secondDigit > "2"c Then
                    currentInput_Clock = firstDigit + ""
                Else
                    lblClock.Text = input & ":00"
                End If
            Case 3
                If input(2) > "5"c Then
                    currentInput_Clock = input.Substring(0, 2)
                Else
                    lblClock.Text = input.Substring(0, 2) & ":" & input(2) & "0"
                End If
            Case 4
                lblClock.Text = input.Substring(0, 2) & ":" & input.Substring(2)
            Case Else

        End Select
    End Sub

    Private Sub CancelClock_Click(sender As Object, e As EventArgs) Handles CancelClock.Click
        TabControl1.Height -= panelKeypadClock.Height
        Height -= panelKeypadClock.Height
        panelKeypadClock.Visible = False
        SetClock.Enabled = True
        ResetClock.Enabled = True
        customClockTime = DateTime.Now
        SetLabel(lblClock)
    End Sub

    Private Sub OKClock_Click(sender As Object, e As EventArgs) Handles OKClock.Click
        If currentInput_Clock.Length > 0 Then
            ' Validate and set customClockTime based on the currentInput_Clock
            Dim resultTime As DateTime

            ' Validate if the current input is a valid time format
            If DateTime.TryParseExact(currentInput_Clock, "HHmm", Nothing, Globalization.DateTimeStyles.None, resultTime) Then
                ' Update customClockTime to the parsed time
                customClockTime = New DateTime(1, 1, 1, resultTime.Hour, resultTime.Minute, 0)
                lblClock.Text = customClockTime.ToString("hh:mm") ' Display the new time on the label
                Timer2.Start() ' Restart the timer to keep updating the clock
            Else
                MessageBox.Show("Invalid time format. Please enter in HHmm format.")
            End If
        End If

        currentInput_Clock = "" ' Clear the current input after confirming
        TabControl1.Height -= panelKeypadClock.Height
        Height -= panelKeypadClock.Height
        panelKeypadClock.Visible = False
        SetClock.Enabled = True
        ResetClock.Enabled = True
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Alarm1On.Checked = CheckBox3.Checked
    End Sub

    Private Sub Alarm1On_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm1On.CheckedChanged
        CheckBox3.Checked = Alarm1On.Checked
    End Sub

    Private Sub AMAlarm1_CheckedChanged(sender As Object, e As EventArgs) Handles AMAlarm1.CheckedChanged

    End Sub

    Private Sub PMAlarm1_CheckedChanged(sender As Object, e As EventArgs) Handles PMAlarm1.CheckedChanged

    End Sub

    Private Sub AMClock_CheckedChanged(sender As Object, e As EventArgs) Handles AMClock.CheckedChanged

    End Sub

    Private Sub PMClock_CheckedChanged(sender As Object, e As EventArgs) Handles PMClock.CheckedChanged

    End Sub
End Class
