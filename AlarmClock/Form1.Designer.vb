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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlarmClock))
        lblClock = New Label()
        Timer2 = New Timer(components)
        tab = New TabControl()
        TabPage1 = New TabPage()
        TimePanelClock = New TimePanel()
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
        PictureBox1 = New PictureBox()
        SetClock = New Button()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        PMClock = New CheckBox()
        AMClock = New CheckBox()
        Alarm01 = New TabPage()
        AlarmPanel1 = New AlarmPanel()
        Alarm02 = New TabPage()
        AlarmPanel2 = New AlarmPanel()
        Alarm03 = New TabPage()
        AlarmPanel3 = New AlarmPanel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        tab.SuspendLayout()
        TabPage1.SuspendLayout()
        panelKeypadClock.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Alarm01.SuspendLayout()
        Alarm02.SuspendLayout()
        Alarm03.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblClock
        ' 
        lblClock.AutoSize = True
        lblClock.BackColor = Color.Black
        lblClock.Font = New Font("Segoe UI", 100.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblClock.ForeColor = Color.Red
        lblClock.Location = New Point(89, 0)
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(459, 177)
        lblClock.TabIndex = 0
        lblClock.Text = "Label1"
        lblClock.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Timer2
        ' 
        ' 
        ' tab
        ' 
        tab.Controls.Add(TabPage1)
        tab.Controls.Add(Alarm01)
        tab.Controls.Add(Alarm02)
        tab.Controls.Add(Alarm03)
        tab.Location = New Point(-3, 1)
        tab.Name = "tab"
        tab.SelectedIndex = 0
        tab.Size = New Size(1021, 809)
        tab.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.BackgroundImageLayout = ImageLayout.Center
        TabPage1.Controls.Add(TimePanelClock)
        TabPage1.Controls.Add(panelKeypadClock)
        TabPage1.Controls.Add(PictureBox1)
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
        TabPage1.Size = New Size(1013, 781)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Clock"
        ' 
        ' TimePanelClock
        ' 
        TimePanelClock.Location = New Point(548, 3)
        TimePanelClock.Name = "TimePanelClock"
        TimePanelClock.Size = New Size(459, 177)
        TimePanelClock.TabIndex = 18
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
        panelKeypadClock.TabIndex = 17
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
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(105, 204)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ResetClock
        ' 
        ResetClock.ForeColor = Color.Red
        ResetClock.Location = New Point(386, 280)
        ResetClock.Name = "ResetClock"
        ResetClock.Size = New Size(103, 40)
        ResetClock.TabIndex = 7
        ResetClock.Text = "Reset"
        ResetClock.UseVisualStyleBackColor = True
        ' 
        ' SetClock
        ' 
        SetClock.ForeColor = Color.Red
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
        CheckBox4.Location = New Point(293, 364)
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
        Alarm01.Controls.Add(AlarmPanel1)
        Alarm01.Location = New Point(4, 24)
        Alarm01.Name = "Alarm01"
        Alarm01.Size = New Size(192, 72)
        Alarm01.TabIndex = 2
        Alarm01.Text = "Alarm1"
        Alarm01.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel1
        ' 
        AlarmPanel1.Location = New Point(0, 0)
        AlarmPanel1.Name = "AlarmPanel1"
        AlarmPanel1.Size = New Size(643, 412)
        AlarmPanel1.TabIndex = 0
        ' 
        ' Alarm02
        ' 
        Alarm02.Controls.Add(AlarmPanel2)
        Alarm02.Location = New Point(4, 24)
        Alarm02.Name = "Alarm02"
        Alarm02.Size = New Size(192, 72)
        Alarm02.TabIndex = 3
        Alarm02.Text = "Alarm2"
        Alarm02.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel2
        ' 
        AlarmPanel2.Location = New Point(0, 0)
        AlarmPanel2.Name = "AlarmPanel2"
        AlarmPanel2.Size = New Size(651, 403)
        AlarmPanel2.TabIndex = 0
        ' 
        ' Alarm03
        ' 
        Alarm03.Controls.Add(AlarmPanel3)
        Alarm03.Location = New Point(4, 24)
        Alarm03.Name = "Alarm03"
        Alarm03.Padding = New Padding(3)
        Alarm03.Size = New Size(192, 72)
        Alarm03.TabIndex = 4
        Alarm03.Text = "Alarm3"
        Alarm03.UseVisualStyleBackColor = True
        ' 
        ' AlarmPanel3
        ' 
        AlarmPanel3.Location = New Point(0, 0)
        AlarmPanel3.Name = "AlarmPanel3"
        AlarmPanel3.Size = New Size(647, 414)
        AlarmPanel3.TabIndex = 0
        ' 
        ' AlarmClock
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1030, 925)
        Controls.Add(tab)
        Name = "AlarmClock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Benjamin To' Alarm Clock"
        tab.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        panelKeypadClock.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Alarm01.ResumeLayout(False)
        Alarm02.ResumeLayout(False)
        Alarm03.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblClock As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents tab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PMClock As CheckBox
    Friend WithEvents AMClock As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Alarm01 As TabPage
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
    Friend WithEvents Alarm03 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
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
    Friend WithEvents Alarm02 As TabPage
    Friend WithEvents AlarmPanel1 As AlarmPanel
    Friend WithEvents AlarmPanel2 As AlarmPanel
    Friend WithEvents AlarmPanel3 As AlarmPanel
    Friend WithEvents TimePanelClock As TimePanel

End Class
