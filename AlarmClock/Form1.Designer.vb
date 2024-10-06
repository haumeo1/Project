<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlarmClock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblClock = New Label()
        Timer2 = New Timer(components)
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        panelKeypadClock = New Panel()
        OKClock = New Button()
        Number9Clock = New Button()
        Number6Clock = New Button()
        Number3Clock = New Button()
        Number0Clock = New Button()
        Number8Clock = New Button()
        Number5Clock = New Button()
        Number2Clock = New Button()
        CancelClock = New Button()
        Number7Clock = New Button()
        Number4Clock = New Button()
        Number1Clock = New Button()
        ResetClock = New Button()
        SetClock = New Button()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        PMClock = New CheckBox()
        AMClock = New CheckBox()
        Alarm01 = New TabPage()
        cmbSoundSelection = New ComboBox()
        panelKeypad1 = New Panel()
        ButtonOK = New Button()
        Number9 = New Button()
        Number6 = New Button()
        Number3 = New Button()
        Number0 = New Button()
        Number8 = New Button()
        Number5 = New Button()
        Number2 = New Button()
        ButtonCancel = New Button()
        Number7 = New Button()
        Number4 = New Button()
        Number1 = New Button()
        btnReset = New Button()
        btnSet = New Button()
        Alarm1On = New CheckBox()
        PMAlarm1 = New CheckBox()
        AMAlarm1 = New CheckBox()
        Alarm1 = New Label()
        TabPage4 = New TabPage()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        panelKeypadClock.SuspendLayout()
        Alarm01.SuspendLayout()
        panelKeypad1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblClock
        ' 
        lblClock.AutoSize = True
        lblClock.BackColor = Color.Black
        lblClock.Font = New Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point)
        lblClock.ForeColor = Color.Red
        lblClock.Location = New Point(105, 0)
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(459, 177)
        lblClock.TabIndex = 0
        lblClock.Text = "Label1"
        lblClock.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Timer2
        ' 
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(Alarm01)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(-3, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(651, 844)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.BackgroundImageLayout = ImageLayout.Center
        TabPage1.Controls.Add(panelKeypadClock)
        TabPage1.Controls.Add(ResetClock)
        TabPage1.Controls.Add(SetClock)
        TabPage1.Controls.Add(CheckBox5)
        TabPage1.Controls.Add(CheckBox4)
        TabPage1.Controls.Add(CheckBox3)
        TabPage1.Controls.Add(PMClock)
        TabPage1.Controls.Add(AMClock)
        TabPage1.Controls.Add(lblClock)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(643, 816)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Clock"
        ' 
        ' panelKeypadClock
        ' 
        panelKeypadClock.Controls.Add(OKClock)
        panelKeypadClock.Controls.Add(Number9Clock)
        panelKeypadClock.Controls.Add(Number6Clock)
        panelKeypadClock.Controls.Add(Number3Clock)
        panelKeypadClock.Controls.Add(Number0Clock)
        panelKeypadClock.Controls.Add(Number8Clock)
        panelKeypadClock.Controls.Add(Number5Clock)
        panelKeypadClock.Controls.Add(Number2Clock)
        panelKeypadClock.Controls.Add(CancelClock)
        panelKeypadClock.Controls.Add(Number7Clock)
        panelKeypadClock.Controls.Add(Number4Clock)
        panelKeypadClock.Controls.Add(Number1Clock)
        panelKeypadClock.Location = New Point(86, 402)
        panelKeypadClock.Name = "panelKeypadClock"
        panelKeypadClock.Size = New Size(478, 348)
        panelKeypadClock.TabIndex = 16
        panelKeypadClock.Visible = False
        ' 
        ' OKClock
        ' 
        OKClock.Location = New Point(321, 262)
        OKClock.Name = "OKClock"
        OKClock.Size = New Size(153, 75)
        OKClock.TabIndex = 11
        OKClock.Text = "OK"
        OKClock.UseVisualStyleBackColor = True
        ' 
        ' Number9Clock
        ' 
        Number9Clock.Location = New Point(321, 181)
        Number9Clock.Name = "Number9Clock"
        Number9Clock.Size = New Size(153, 75)
        Number9Clock.TabIndex = 10
        Number9Clock.Text = "9"
        Number9Clock.UseVisualStyleBackColor = True
        ' 
        ' Number6Clock
        ' 
        Number6Clock.Location = New Point(321, 100)
        Number6Clock.Name = "Number6Clock"
        Number6Clock.Size = New Size(153, 75)
        Number6Clock.TabIndex = 9
        Number6Clock.Text = "6"
        Number6Clock.UseVisualStyleBackColor = True
        ' 
        ' Number3Clock
        ' 
        Number3Clock.Location = New Point(321, 19)
        Number3Clock.Name = "Number3Clock"
        Number3Clock.Size = New Size(153, 75)
        Number3Clock.TabIndex = 8
        Number3Clock.Text = "3"
        Number3Clock.UseVisualStyleBackColor = True
        ' 
        ' Number0Clock
        ' 
        Number0Clock.Location = New Point(162, 262)
        Number0Clock.Name = "Number0Clock"
        Number0Clock.Size = New Size(153, 75)
        Number0Clock.TabIndex = 7
        Number0Clock.Text = "0"
        Number0Clock.UseVisualStyleBackColor = True
        ' 
        ' Number8Clock
        ' 
        Number8Clock.Location = New Point(162, 181)
        Number8Clock.Name = "Number8Clock"
        Number8Clock.Size = New Size(153, 75)
        Number8Clock.TabIndex = 6
        Number8Clock.Text = "8"
        Number8Clock.UseVisualStyleBackColor = True
        ' 
        ' Number5Clock
        ' 
        Number5Clock.Location = New Point(162, 100)
        Number5Clock.Name = "Number5Clock"
        Number5Clock.Size = New Size(153, 75)
        Number5Clock.TabIndex = 5
        Number5Clock.Text = "5"
        Number5Clock.UseVisualStyleBackColor = True
        ' 
        ' Number2Clock
        ' 
        Number2Clock.Location = New Point(162, 19)
        Number2Clock.Name = "Number2Clock"
        Number2Clock.Size = New Size(153, 75)
        Number2Clock.TabIndex = 4
        Number2Clock.Text = "2"
        Number2Clock.UseVisualStyleBackColor = True
        ' 
        ' CancelClock
        ' 
        CancelClock.Location = New Point(3, 262)
        CancelClock.Name = "CancelClock"
        CancelClock.Size = New Size(153, 75)
        CancelClock.TabIndex = 3
        CancelClock.Text = "Cancel"
        CancelClock.UseVisualStyleBackColor = True
        ' 
        ' Number7Clock
        ' 
        Number7Clock.Location = New Point(3, 181)
        Number7Clock.Name = "Number7Clock"
        Number7Clock.Size = New Size(153, 75)
        Number7Clock.TabIndex = 2
        Number7Clock.Text = "7"
        Number7Clock.UseVisualStyleBackColor = True
        ' 
        ' Number4Clock
        ' 
        Number4Clock.Location = New Point(3, 100)
        Number4Clock.Name = "Number4Clock"
        Number4Clock.Size = New Size(153, 75)
        Number4Clock.TabIndex = 1
        Number4Clock.Text = "4"
        Number4Clock.UseVisualStyleBackColor = True
        ' 
        ' Number1Clock
        ' 
        Number1Clock.Location = New Point(3, 19)
        Number1Clock.Name = "Number1Clock"
        Number1Clock.Size = New Size(153, 75)
        Number1Clock.TabIndex = 0
        Number1Clock.Text = "1"
        Number1Clock.UseVisualStyleBackColor = True
        ' 
        ' ResetClock
        ' 
        ResetClock.Location = New Point(386, 280)
        ResetClock.Name = "ResetClock"
        ResetClock.Size = New Size(103, 40)
        ResetClock.TabIndex = 7
        ResetClock.Text = "Reset"
        ResetClock.UseVisualStyleBackColor = True
        ' 
        ' SetClock
        ' 
        SetClock.Location = New Point(386, 204)
        SetClock.Name = "SetClock"
        SetClock.Size = New Size(103, 40)
        SetClock.TabIndex = 6
        SetClock.Text = "Set"
        SetClock.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.ForeColor = Color.Red
        CheckBox5.Location = New Point(479, 364)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(67, 19)
        CheckBox5.TabIndex = 5
        CheckBox5.Text = "Alarm 3"
        CheckBox5.TextAlign = ContentAlignment.MiddleCenter
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.ForeColor = Color.Red
        CheckBox4.Location = New Point(284, 364)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(67, 19)
        CheckBox4.TabIndex = 4
        CheckBox4.Text = "Alarm 2"
        CheckBox4.TextAlign = ContentAlignment.MiddleCenter
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.ForeColor = Color.Red
        CheckBox3.Location = New Point(105, 364)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(67, 19)
        CheckBox3.TabIndex = 3
        CheckBox3.Text = "Alarm 1"
        CheckBox3.TextAlign = ContentAlignment.MiddleCenter
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' PMClock
        ' 
        PMClock.AutoSize = True
        PMClock.ForeColor = Color.Firebrick
        PMClock.Location = New Point(361, 158)
        PMClock.Name = "PMClock"
        PMClock.Size = New Size(44, 19)
        PMClock.TabIndex = 2
        PMClock.Text = "PM"
        PMClock.UseVisualStyleBackColor = True
        ' 
        ' AMClock
        ' 
        AMClock.AutoSize = True
        AMClock.ForeColor = Color.Firebrick
        AMClock.Location = New Point(209, 158)
        AMClock.Name = "AMClock"
        AMClock.Size = New Size(45, 19)
        AMClock.TabIndex = 1
        AMClock.Text = "AM"
        AMClock.UseVisualStyleBackColor = True
        ' 
        ' Alarm01
        ' 
        Alarm01.Controls.Add(cmbSoundSelection)
        Alarm01.Controls.Add(panelKeypad1)
        Alarm01.Controls.Add(btnReset)
        Alarm01.Controls.Add(btnSet)
        Alarm01.Controls.Add(Alarm1On)
        Alarm01.Controls.Add(PMAlarm1)
        Alarm01.Controls.Add(AMAlarm1)
        Alarm01.Controls.Add(Alarm1)
        Alarm01.Location = New Point(4, 24)
        Alarm01.Name = "Alarm01"
        Alarm01.Size = New Size(643, 816)
        Alarm01.TabIndex = 2
        Alarm01.Text = "Alarm1"
        Alarm01.UseVisualStyleBackColor = True
        ' 
        ' cmbSoundSelection
        ' 
        cmbSoundSelection.FormattingEnabled = True
        cmbSoundSelection.Location = New Point(140, 219)
        cmbSoundSelection.Name = "cmbSoundSelection"
        cmbSoundSelection.Size = New Size(136, 23)
        cmbSoundSelection.TabIndex = 16
        ' 
        ' panelKeypad1
        ' 
        panelKeypad1.Controls.Add(ButtonOK)
        panelKeypad1.Controls.Add(Number9)
        panelKeypad1.Controls.Add(Number6)
        panelKeypad1.Controls.Add(Number3)
        panelKeypad1.Controls.Add(Number0)
        panelKeypad1.Controls.Add(Number8)
        panelKeypad1.Controls.Add(Number5)
        panelKeypad1.Controls.Add(Number2)
        panelKeypad1.Controls.Add(ButtonCancel)
        panelKeypad1.Controls.Add(Number7)
        panelKeypad1.Controls.Add(Number4)
        panelKeypad1.Controls.Add(Number1)
        panelKeypad1.Location = New Point(86, 413)
        panelKeypad1.Name = "panelKeypad1"
        panelKeypad1.Size = New Size(478, 348)
        panelKeypad1.TabIndex = 15
        panelKeypad1.Visible = False
        ' 
        ' ButtonOK
        ' 
        ButtonOK.Location = New Point(321, 262)
        ButtonOK.Name = "ButtonOK"
        ButtonOK.Size = New Size(153, 75)
        ButtonOK.TabIndex = 11
        ButtonOK.Text = "OK"
        ButtonOK.UseVisualStyleBackColor = True
        ' 
        ' Number9
        ' 
        Number9.Location = New Point(321, 181)
        Number9.Name = "Number9"
        Number9.Size = New Size(153, 75)
        Number9.TabIndex = 10
        Number9.Text = "9"
        Number9.UseVisualStyleBackColor = True
        ' 
        ' Number6
        ' 
        Number6.Location = New Point(321, 100)
        Number6.Name = "Number6"
        Number6.Size = New Size(153, 75)
        Number6.TabIndex = 9
        Number6.Text = "6"
        Number6.UseVisualStyleBackColor = True
        ' 
        ' Number3
        ' 
        Number3.Location = New Point(321, 19)
        Number3.Name = "Number3"
        Number3.Size = New Size(153, 75)
        Number3.TabIndex = 8
        Number3.Text = "3"
        Number3.UseVisualStyleBackColor = True
        ' 
        ' Number0
        ' 
        Number0.Location = New Point(162, 262)
        Number0.Name = "Number0"
        Number0.Size = New Size(153, 75)
        Number0.TabIndex = 7
        Number0.Text = "0"
        Number0.UseVisualStyleBackColor = True
        ' 
        ' Number8
        ' 
        Number8.Location = New Point(162, 181)
        Number8.Name = "Number8"
        Number8.Size = New Size(153, 75)
        Number8.TabIndex = 6
        Number8.Text = "8"
        Number8.UseVisualStyleBackColor = True
        ' 
        ' Number5
        ' 
        Number5.Location = New Point(162, 100)
        Number5.Name = "Number5"
        Number5.Size = New Size(153, 75)
        Number5.TabIndex = 5
        Number5.Text = "5"
        Number5.UseVisualStyleBackColor = True
        ' 
        ' Number2
        ' 
        Number2.Location = New Point(162, 19)
        Number2.Name = "Number2"
        Number2.Size = New Size(153, 75)
        Number2.TabIndex = 4
        Number2.Text = "2"
        Number2.UseVisualStyleBackColor = True
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Location = New Point(3, 262)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(153, 75)
        ButtonCancel.TabIndex = 3
        ButtonCancel.Text = "Cancel"
        ButtonCancel.UseVisualStyleBackColor = True
        ' 
        ' Number7
        ' 
        Number7.Location = New Point(3, 181)
        Number7.Name = "Number7"
        Number7.Size = New Size(153, 75)
        Number7.TabIndex = 2
        Number7.Text = "7"
        Number7.UseVisualStyleBackColor = True
        ' 
        ' Number4
        ' 
        Number4.Location = New Point(3, 100)
        Number4.Name = "Number4"
        Number4.Size = New Size(153, 75)
        Number4.TabIndex = 1
        Number4.Text = "4"
        Number4.UseVisualStyleBackColor = True
        ' 
        ' Number1
        ' 
        Number1.Location = New Point(3, 19)
        Number1.Name = "Number1"
        Number1.Size = New Size(153, 75)
        Number1.TabIndex = 0
        Number1.Text = "1"
        Number1.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.ForeColor = Color.Red
        btnReset.Location = New Point(379, 271)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(105, 40)
        btnReset.TabIndex = 14
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSet
        ' 
        btnSet.ForeColor = Color.Red
        btnSet.Location = New Point(379, 209)
        btnSet.Name = "btnSet"
        btnSet.Size = New Size(105, 40)
        btnSet.TabIndex = 12
        btnSet.Text = "Set"
        btnSet.UseVisualStyleBackColor = True
        ' 
        ' Alarm1On
        ' 
        Alarm1On.AutoSize = True
        Alarm1On.ForeColor = Color.Red
        Alarm1On.Location = New Point(394, 366)
        Alarm1On.Name = "Alarm1On"
        Alarm1On.Size = New Size(77, 19)
        Alarm1On.TabIndex = 11
        Alarm1On.Text = "Alarm On"
        Alarm1On.TextAlign = ContentAlignment.MiddleCenter
        Alarm1On.UseVisualStyleBackColor = True
        ' 
        ' PMAlarm1
        ' 
        PMAlarm1.AutoSize = True
        PMAlarm1.ForeColor = Color.Firebrick
        PMAlarm1.Location = New Point(341, 158)
        PMAlarm1.Name = "PMAlarm1"
        PMAlarm1.Size = New Size(44, 19)
        PMAlarm1.TabIndex = 10
        PMAlarm1.Text = "PM"
        PMAlarm1.UseVisualStyleBackColor = True
        ' 
        ' AMAlarm1
        ' 
        AMAlarm1.AutoSize = True
        AMAlarm1.ForeColor = Color.Firebrick
        AMAlarm1.Location = New Point(189, 158)
        AMAlarm1.Name = "AMAlarm1"
        AMAlarm1.Size = New Size(45, 19)
        AMAlarm1.TabIndex = 9
        AMAlarm1.Text = "AM"
        AMAlarm1.UseVisualStyleBackColor = True
        ' 
        ' Alarm1
        ' 
        Alarm1.AutoSize = True
        Alarm1.BackColor = Color.Black
        Alarm1.Font = New Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point)
        Alarm1.ForeColor = Color.Red
        Alarm1.Location = New Point(117, 0)
        Alarm1.Name = "Alarm1"
        Alarm1.Size = New Size(459, 177)
        Alarm1.TabIndex = 8
        Alarm1.Text = "Label1"
        Alarm1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(643, 816)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' AlarmClock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(644, 827)
        Controls.Add(TabControl1)
        Name = "AlarmClock"
        Text = "Benjamin To' Alarm Clock"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        panelKeypadClock.ResumeLayout(False)
        Alarm01.ResumeLayout(False)
        Alarm01.PerformLayout()
        panelKeypad1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblClock As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PMClock As CheckBox
    Friend WithEvents AMClock As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Alarm01 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ResetClock As Button
    Friend WithEvents SetClock As Button
    Friend WithEvents Alarm1_ON As CheckBox
    Friend WithEvents panelKeypad As Panel
    Friend WithEvents btn1 As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents Number8 As Button
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents Alarm1On As CheckBox
    Friend WithEvents PMAlarm1 As CheckBox
    Friend WithEvents AMAlarm1 As CheckBox
    Friend WithEvents Alarm1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSet As Button
    Friend WithEvents panelKeypad1 As Panel
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Number7 As Button
    Friend WithEvents Number4 As Button
    Friend WithEvents Number1 As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents Number9 As Button
    Friend WithEvents Number6 As Button
    Friend WithEvents Number3 As Button
    Friend WithEvents Number0 As Button
    Friend WithEvents Number5 As Button
    Friend WithEvents Number2 As Button
    Friend WithEvents cmbSoundSelection As ComboBox
    Friend WithEvents panelKeypadClock As Panel
    Friend WithEvents OKClock As Button
    Friend WithEvents Number9Clock As Button
    Friend WithEvents Number6Clock As Button
    Friend WithEvents Number3Clock As Button
    Friend WithEvents Number0Clock As Button
    Friend WithEvents Number8Clock As Button
    Friend WithEvents Number5Clock As Button
    Friend WithEvents Number2Clock As Button
    Friend WithEvents CancelClock As Button
    Friend WithEvents Number7Clock As Button
    Friend WithEvents Number4Clock As Button
    Friend WithEvents Number1Clock As Button

End Class
