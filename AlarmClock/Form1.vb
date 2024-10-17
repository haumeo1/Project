Imports System.Media
Imports System.Runtime.CompilerServices


Public Class AlarmClock
    Private activeTimePanel As TimePanel
    Private keypadButtons As Button()
    Private soundPlayer As SoundPlayer
    Private soundPath As String = ""
    Private originalHeight As Integer
    Private currentInput_Alarm1 As String = ""
    Private currentInput_Clock As String = ""
    Private previousAlarm As String = "00:00" ' Variable to store the previous alarm time
    Private customClockTime As DateTime = DateTime.Now 'Variable to store the time


    Public Sub StopAlarmSound()
        If soundPlayer IsNot Nothing Then
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
        'UpdateTimePanel()
    End Sub

    Private Sub UpdateTimePanel()
        Dim hours As Integer = customClockTime.Hour Mod 12
        If hours = 0 Then hours = 12 ' Handle 12-hour format
        TimePanelClock.Digitled0.DigitValue = hours \ 10 ' Tens place for hours
        TimePanelClock.Digitled1.DigitValue = hours Mod 10 ' Ones place for hours
        TimePanelClock.Digitled2.DigitValue = customClockTime.Minute \ 10 ' Tens place for minutes
        TimePanelClock.Digitled3.DigitValue = customClockTime.Minute Mod 10 ' Ones place for minutes
        TimePanelClock.AM.Checked = customClockTime.Hour < 12
        TimePanelClock.PM.Checked = customClockTime.Hour >= 12
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
        keypadButtons = {Number1Clock, Number2Clock, Number3Clock, Number4Clock, Number5Clock, Number6Clock, Number7Clock, Number8Clock, Number9Clock, Number0Clock}
        AddHandler AlarmPanel1.AlarmOn.CheckedChanged, AddressOf CheckBoxWithAlarm
        For Each button In keypadButtons
            AddHandler button.Click, AddressOf KeypadButton_Click
        Next



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

    'Show Panel When the Set button Is pressed
    Public Sub ShowKeypadPanel(timePanel As TimePanel)
        activeTimePanel = timePanel ' Reference the active TimePanel (Clock or Alarm)
        panelKeypadClock.Visible = True
        ' Adjust form size to fit the keypad
        Me.Height += panelKeypadClock.Height
        UpdateKeypadButtons()
    End Sub

    'Button reset Is pressed
    Public Sub ResetCLock1(sender As Object, e As EventArgs)
        customClockTime = DateTime.Now
        SetLabel(lblClock)
    End Sub
    Public Sub HideKeypadPanel()
        If activeTimePanel IsNot Nothing Then
            activeTimePanel = Nothing
        End If
        panelKeypadClock.Visible = False
        Me.Height -= panelKeypadClock.Height
    End Sub

    'Keypad Button Click
    Private Sub KeypadButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim digit As Integer = Integer.Parse(button.Text)
        If activeTimePanel IsNot Nothing Then
            activeTimePanel.InputDigit(digit)
            UpdateKeypadButtons()
        End If
    End Sub

    ''Update Keypad Buttons
    Private Sub UpdateKeypadButtons()
        If activeTimePanel IsNot Nothing Then
            For Each button As Button In keypadButtons
                Dim digit As Integer = Integer.Parse(button.Text)
                button.Enabled = activeTimePanel.IsDigitValid(digit)
            Next
        End If
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
        'tab.Height += panelKeypadClock.Height
        Height += panelKeypadClock.Height
        SetClock.Enabled = False
        ResetClock.Enabled = False
        AMClock.Checked = True
        PMClock.Checked = False

    End Sub

    'Private Sub ResetClock_Click(sender As Object, e As EventArgs) Handles ResetClock.Click
    '    customClockTime = DateTime.Now
    '    SetLabel(lblClock)
    'End Sub

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
