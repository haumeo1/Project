Imports System.Media
Imports System.Runtime.CompilerServices


Public Class AlarmClock
    Private soundPlayer As SoundPlayer
    Private soundPath As String = ""
    Private originalHeight As Integer
    Private currentInput_Alarm1 As String = ""
    Private currentInput_Alarm2 As String = ""
    Private currentInput_Alarm3 As String = ""
    Private currentInput_Clock As String = ""
    Private previousAlarm As String = "00:00" ' Variable to store the previous alarm time
    Private previousAlarm3 As String = "00:00"
    Private previousAlarm2 As String = "00:00"
    Private customClockTime As DateTime = DateTime.Now 'Variable to store the time
    'Set the picture for alarm tab



    Public Sub StopAlarmSound()
        If SoundPlayer IsNot Nothing Then
            soundPlayer.Stop() ' Stop 
            soundPath = "" 'path
        End If
    End Sub

    Private Sub UpdateAMPMCheckbox()
        Dim currentHour As Integer = customClockTime.Hour
        If currentHour >= 12 AndAlso currentHour < 24 Then
            'PM
            PMClock.Checked = True
            AMClock.Checked = False
        Else
            'AM
            AMClock.Checked = True
            PMClock.Checked = False
        End If
    End Sub


    Private Sub SetLabel(ByVal label As Label)
        Timer2.Interval = 600
        Timer2.Start()
        label.Text = customClockTime.ToString("hh:mm")
    End Sub

    Private Sub Picture()
        AlarmPanel1.PictureBoxAlarm.Image = My.Resources.gif1
        AlarmPanel2.PictureBoxAlarm.Image = My.Resources.gif21
        AlarmPanel2.PictureBoxAlarm.SizeMode = PictureBoxSizeMode.StretchImage
        AlarmPanel3.PictureBoxAlarm.Image = My.Resources.gif31
        AlarmPanel3.PictureBoxAlarm.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub


    Private Sub AlarmClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Picture()
        SetLabel(lblClock)
        originalHeight = Me.Height

        AddHandler AlarmPanel1.AlarmOn.CheckedChanged, AddressOf CheckBoxWithAlarm




        'Hadler for the set button
        'AddHandler alarm1.btnSet.Click, AddressOf AlarmPanel


    End Sub

    Private Sub AlarmPanel1_Load(sender As Object, e As EventArgs) Handles AlarmPanel1.Load

    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'lblClock.Text = DateTime.Now.ToString("hh:mm")
        customClockTime = customClockTime.AddSeconds(1)
        UpdateAMPMCheckbox()
        lblClock.Text = customClockTime.ToString("hh:mm")
        CheckAlarm()


    End Sub

    Private Sub CheckAlarm()
        Dim currentClockTime As String = lblClock.Text
        Dim alarm1Time As String = AlarmPanel1.Alarm.Text
        'Dim alarm2Time As String = Alarm2.Text
        'Dim alarm3Time As String = Alarm3.Text
        Dim isClockAM As Boolean = AMClock.Checked
        Dim isAlarmAM As Boolean = AlarmPanel1.AMAlarm.Checked
        'Dim isAlarm2AM As Boolean = AMAlarm2.Checked
        'Dim isAlarm3AM As Boolean = AMAlarm3.Checked
        'Alarm checking logic here
        If currentClockTime = alarm1Time AndAlso isClockAM = isAlarmAM AndAlso CheckBox3.Checked Then

            AlarmPanel1.PictureBoxAlarm.Visible = False
            AlarmPanel1.PlayAlarm()
            CheckBox3.Checked = False
            AlarmPanel1.PictureAlarm.Visible = True
            AlarmPanel1.PictureAlarm.Image = My.Resources.gif11


        End If

    End Sub



    'button set Alarm1'

    'Show the keypad panel


    'button set Alarm2
    'Private Sub btnSetAlarm2_Click(sender As Object, e As EventArgs) Handles btnSetAlarm2.Click
    '    panelKeypad2.Visible = True
    '    tab.Height += panelKeypad2.Height
    '    Height += panelKeypad2.Height
    '    btnSetAlarm2.Enabled = False
    '    btnResetAlarm2.Enabled = False
    'End Sub

    ''button set Alarm3
    'Private Sub ButtonSet3_Click(sender As Object, e As EventArgs) Handles btnSetAlarm3.Click
    '    panelKeypad3.Visible = True
    '    tab.Height += panelKeypad3.Height
    '    Height += panelKeypad3.Height
    '    btnSetAlarm3.Enabled = False
    '    btnResetAlarm3.Enabled = False
    'End Sub

    ''button cancel for alarm 1
    'Private Sub Cancel_btn()
    '    'tab.Height -= panelKeypad1.Height
    '    Height -= panelKeypadClock.Height
    '    panelKeypadClock.Visible = False
    '    btnSet.Enabled = True
    '    btnReset.Enabled = True
    '    currentInput_Alarm1 = ""
    '    Alarm1.Text = previousAlarm ' Restore the previous alarm time
    'End Sub


    ''button reset for alarm 3
    'Private Sub btnResetAlarm3_Click(sender As Object, e As EventArgs) Handles btnResetAlarm3.Click
    '    Alarm_Set3(Alarm3)
    'End Sub
    'Private Sub btnResetAlarm2_Click(sender As Object, e As EventArgs) Handles btnResetAlarm2.Click
    '    Alarm_Set2(Alarm2)
    'End Sub
    ''Private Sub btnReset_Click(sender As Object, e As EventArgs)
    ''    Alarm_Set(Alarm1)
    ''End Sub

    'Alarm 1 Keypad button click

    'Private Sub KeypadButton_Click(sender As Object, e As EventArgs) Handles Number1Clock.Click, Number2Clock.Click, Number3Clock.Click, Number4Clock.Click, Number5Clock.Click, Number6Clock.Click, Number7Clock.Click, Number8Clock.Click, Number9Clock.Click, Number0Clock.Click
    '    Dim buttonValue = DirectCast(sender, Button).Text
    '    currentInput_Alarm1 &= buttonValue
    '    UpdateAlarmDisplay(currentInput_Alarm1)
    'End Sub

    ''Private Sub UpdateAlarmDisplay(input As String)
    ''    'Dim firstHourDigit As String = "0"
    ''    'Dim secondHourDigit As String = "0"
    ''    'Dim firstMinuteDigit As String = "0"
    ''    'Dim secondMinuteDigit As String = "0"

    ''    Select Case input.Length
    ''        Case 1

    ''            If input(0) > "1"c Then
    ''                currentInput_Alarm1 = ""
    ''            Else

    ''                Alarm1.Text = input & "0" & ":00" ' "0X:00"
    ''            End If
    ''        Case 2
    ''            Dim firstDigit As Char = input(0)
    ''            Dim secondDigit As Char = input(1)


    ''            If firstDigit = "0"c And secondDigit = "0"c Then
    ''                'Alarm1.Text = "Invalid Input"
    ''                currentInput_Alarm1 = firstDigit + ""
    ''            ElseIf firstDigit = "1"c And secondDigit > "2"c Then
    ''                'Alarm1.Text = "Invalid Input"
    ''                currentInput_Alarm1 = firstDigit + ""
    ''            Else
    ''                Alarm1.Text = input & ":00"
    ''            End If
    ''        Case 3

    ''            If input(2) > "5"c Then
    ''                'Alarm1.Text = "Invalid Input"
    ''                currentInput_Alarm1 = input(0) + input(1) + ""
    ''            Else
    ''                Alarm1.Text = input.Substring(0, 2) & ":" & input(2) & "0" ' "XX:X0"
    ''            End If
    ''        Case 4


    ''            Alarm1.Text = input.Substring(0, 2) & ":" & input.Substring(2) ' "XX:XX"
    ''        Case Else
    ''            'Alarm1.Text = "Invalid Input"
    ''    End Select
    ''End Sub

    ''Button cancel for alarm 1
    'Private Sub ButtonCancel_Click(sender As Object, e As EventArgs)
    '    Cancel_btn()
    'End Sub


    ''Button OK for alarm 1
    'Private Sub ButtonOK_Click(sender As Object, e As EventArgs)
    '    If currentInput_Alarm1.Length > 0 Then
    '        previousAlarm = Alarm1.Text ' Save the current alarm time before updating
    '        UpdateAlarmDisplay(currentInput_Alarm1) ' Update the alarm display
    '    End If
    '    currentInput_Alarm1 = "" ' Clear the current input after confirming
    '    'tab.Height -= panelKeypadClock.Height
    '    Height -= panelKeypadClock.Height
    '    panelKeypadClock.Visible = False
    '    btnSet.Enabled = True
    '    btnReset.Enabled = True
    'End Sub


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
        'tab.Height += panelKeypadClock.Height
        Height += panelKeypadClock.Height
        SetClock.Enabled = False
        ResetClock.Enabled = False
        AMClock.Checked = True
        PMClock.Checked = False

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


        End Select
    End Sub

    Private Sub CancelClock_Click(sender As Object, e As EventArgs) Handles CancelClock.Click
        'tab.Height -= panelKeypadClock.Height
        Height -= panelKeypadClock.Height
        panelKeypadClock.Visible = False
        SetClock.Enabled = True
        ResetClock.Enabled = True
        customClockTime = Date.Now
        SetLabel(lblClock)
    End Sub

    Private Sub OKClock_Click(sender As Object, e As EventArgs) Handles OKClock.Click
        If currentInput_Clock.Length > 0 Then

            Dim resultTime As Date
            If Date.TryParseExact(currentInput_Clock, "HHmm", Nothing, Globalization.DateTimeStyles.None, resultTime) Then
                If PMClock.Checked = True Then
                    If resultTime.Hour < 12 Then
                        resultTime = resultTime.AddHours(12)
                    End If
                Else
                    If resultTime.Hour = 12 Then
                        resultTime = resultTime.AddHours(-12)
                    End If
                End If
                customClockTime = New DateTime(1, 1, 1, resultTime.Hour, resultTime.Minute, 0)
                lblClock.Text = customClockTime.ToString("hh:mm")
                Timer2.Start()
                'Else
                '    MessageBox.Show("Invalid time format. Please enter in hh:mm format.")
            End If
        End If

        currentInput_Clock = ""
        'tab.Height -= panelKeypadClock.Height
        Height -= panelKeypadClock.Height
        panelKeypadClock.Visible = False
        SetClock.Enabled = True
        ResetClock.Enabled = True
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged

        AlarmPanel1.AlarmOn.Checked = CheckBox3.Checked
    End Sub

    Private Sub CheckBoxWithAlarm(sender As Object, e As EventArgs)
        CheckBox3.Checked = AlarmPanel1.AlarmOn.Checked
    End Sub

    'Private Sub AlarmOn_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm2On.CheckedChanged, Alarm3On.CheckedChanged
    '    CheckBox3.Checked = Alarm1On.Checked
    '    CheckBox4.Checked = Alarm2On.Checked
    '    CheckBox5.Checked = Alarm3On.Checked
    'End Sub



    Private Sub AMClock_CheckedChanged(sender As Object, e As EventArgs) Handles AMClock.CheckedChanged
        If AMClock.Checked Then
            PMClock.Checked = False
        End If
    End Sub

    Private Sub PMClock_CheckedChanged(sender As Object, e As EventArgs) Handles PMClock.CheckedChanged
        If PMClock.Checked Then
            AMClock.Checked = False
        End If
    End Sub

    Private Sub AlarmPanel3_Load(sender As Object, e As EventArgs) Handles AlarmPanel3.Load

    End Sub





    ''Private Sub PictureAlarm1_Click(sender As Object, e As EventArgs) Handles PictureAlarm2.Click, PictureAlarm3.Click
    ''    StopAlarmSound()
    ''    PictureBoxAlarm1.Visible = True
    ''    PictureBoxAlarm2.Visible = True
    ''    PictureBoxAlarm3.Visible = True

    ''    PictureAlarm1.Visible = False
    ''    PictureAlarm2.Visible = False
    ''    PictureAlarm3.Visible = False
    ''    Picture()
    ''End Sub

    'Private Sub PictureBoxAlarm2_Click(sender As Object, e As EventArgs) Handles PictureBoxAlarm2.Click

    'End Sub

    'Private Sub Alarm1_Click(sender As Object, e As EventArgs)

    'End Sub





    '' Gif and image control
End Class
