<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlarmPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        PictureBoxAlarm = New PictureBox()
        PictureAlarm = New Button()
        cmbSoundSelection = New ComboBox()
        btnReset = New Button()
        btnSet = New Button()
        AlarmOn = New CheckBox()
        PMAlarm = New CheckBox()
        AMAlarm = New CheckBox()
        Alarm = New Label()
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
        CType(PictureBoxAlarm, ComponentModel.ISupportInitialize).BeginInit()
        panelKeypadClock.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBoxAlarm
        ' 
        PictureBoxAlarm.Location = New Point(105, 204)
        PictureBoxAlarm.Name = "PictureBoxAlarm"
        PictureBoxAlarm.Size = New Size(233, 137)
        PictureBoxAlarm.TabIndex = 28
        PictureBoxAlarm.TabStop = False
        ' 
        ' PictureAlarm
        ' 
        PictureAlarm.Location = New Point(105, 204)
        PictureAlarm.Name = "PictureAlarm"
        PictureAlarm.Size = New Size(233, 137)
        PictureAlarm.TabIndex = 27
        PictureAlarm.UseVisualStyleBackColor = True
        PictureAlarm.Visible = False
        ' 
        ' cmbSoundSelection
        ' 
        cmbSoundSelection.FormattingEnabled = True
        cmbSoundSelection.Location = New Point(160, 362)
        cmbSoundSelection.Name = "cmbSoundSelection"
        cmbSoundSelection.Size = New Size(136, 23)
        cmbSoundSelection.TabIndex = 26
        ' 
        ' btnReset
        ' 
        btnReset.ForeColor = Color.Red
        btnReset.Location = New Point(386, 280)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(105, 40)
        btnReset.TabIndex = 24
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSet
        ' 
        btnSet.ForeColor = Color.Red
        btnSet.Location = New Point(386, 204)
        btnSet.Name = "btnSet"
        btnSet.Size = New Size(105, 40)
        btnSet.TabIndex = 23
        btnSet.Text = "Set"
        btnSet.UseVisualStyleBackColor = True
        ' 
        ' AlarmOn
        ' 
        AlarmOn.AutoSize = True
        AlarmOn.ForeColor = Color.Red
        AlarmOn.Location = New Point(394, 366)
        AlarmOn.Name = "AlarmOn"
        AlarmOn.Size = New Size(77, 19)
        AlarmOn.TabIndex = 22
        AlarmOn.Text = "Alarm On"
        AlarmOn.TextAlign = ContentAlignment.MiddleCenter
        AlarmOn.UseVisualStyleBackColor = True
        ' 
        ' PMAlarm
        ' 
        PMAlarm.AutoSize = True
        PMAlarm.ForeColor = Color.Firebrick
        PMAlarm.Location = New Point(361, 158)
        PMAlarm.Name = "PMAlarm"
        PMAlarm.Size = New Size(44, 19)
        PMAlarm.TabIndex = 21
        PMAlarm.Text = "PM"
        PMAlarm.UseVisualStyleBackColor = True
        ' 
        ' AMAlarm
        ' 
        AMAlarm.AutoSize = True
        AMAlarm.ForeColor = Color.Firebrick
        AMAlarm.Location = New Point(209, 158)
        AMAlarm.Name = "AMAlarm"
        AMAlarm.Size = New Size(45, 19)
        AMAlarm.TabIndex = 20
        AMAlarm.Text = "AM"
        AMAlarm.UseVisualStyleBackColor = True
        ' 
        ' Alarm
        ' 
        Alarm.AutoSize = True
        Alarm.BackColor = Color.Black
        Alarm.Font = New Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point)
        Alarm.ForeColor = Color.Red
        Alarm.Location = New Point(105, 0)
        Alarm.Name = "Alarm"
        Alarm.Size = New Size(459, 177)
        Alarm.TabIndex = 19
        Alarm.Text = "Label1"
        Alarm.TextAlign = ContentAlignment.TopCenter
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
        panelKeypadClock.Location = New Point(86, 405)
        panelKeypadClock.Name = "panelKeypadClock"
        panelKeypadClock.Size = New Size(478, 348)
        panelKeypadClock.TabIndex = 29
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
        ' AlarmPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(panelKeypadClock)
        Controls.Add(PictureBoxAlarm)
        Controls.Add(PictureAlarm)
        Controls.Add(cmbSoundSelection)
        Controls.Add(btnReset)
        Controls.Add(btnSet)
        Controls.Add(AlarmOn)
        Controls.Add(PMAlarm)
        Controls.Add(AMAlarm)
        Controls.Add(Alarm)
        Name = "AlarmPanel"
        Size = New Size(651, 765)
        CType(PictureBoxAlarm, ComponentModel.ISupportInitialize).EndInit()
        panelKeypadClock.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxAlarm As PictureBox
    Friend WithEvents PictureAlarm As Button
    Friend WithEvents cmbSoundSelection As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSet As Button
    Friend WithEvents AlarmOn As CheckBox
    Friend WithEvents PMAlarm As CheckBox
    Friend WithEvents AMAlarm As CheckBox
    Friend WithEvents Alarm As Label

    Private Sub AlarmPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
