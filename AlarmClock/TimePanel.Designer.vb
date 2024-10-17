<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Digitled0 = New DigitLED()
        Digitled1 = New DigitLED()
        Digitled2 = New DigitLED()
        Digitled3 = New DigitLED()
        Label1 = New Label()
        AM = New RadioButton()
        GroupBox1 = New GroupBox()
        PM = New RadioButton()
        ResetClock = New Button()
        SetClock = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Digitled0
        ' 
        Digitled0.AutoSize = True
        Digitled0.BackColor = Color.Black
        Digitled0.DigitValue = 0
        Digitled0.Font = New Font("Courier New", 40F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled0.ForeColor = Color.Red
        Digitled0.Location = New Point(23, 29)
        Digitled0.MaxDigitValue = 0
        Digitled0.Name = "Digitled0"
        Digitled0.Size = New Size(57, 60)
        Digitled0.TabIndex = 4
        Digitled0.Text = "0"
        Digitled0.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled1
        ' 
        Digitled1.AutoSize = True
        Digitled1.BackColor = Color.Black
        Digitled1.DigitValue = 0
        Digitled1.Font = New Font("Courier New", 40F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled1.ForeColor = Color.Red
        Digitled1.Location = New Point(86, 29)
        Digitled1.MaxDigitValue = 0
        Digitled1.Name = "Digitled1"
        Digitled1.Size = New Size(57, 60)
        Digitled1.TabIndex = 5
        Digitled1.Text = "0"
        Digitled1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled2
        ' 
        Digitled2.AutoSize = True
        Digitled2.BackColor = Color.Black
        Digitled2.DigitValue = 0
        Digitled2.Font = New Font("Courier New", 40F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled2.ForeColor = Color.Red
        Digitled2.Location = New Point(178, 29)
        Digitled2.MaxDigitValue = 0
        Digitled2.Name = "Digitled2"
        Digitled2.Size = New Size(57, 60)
        Digitled2.TabIndex = 6
        Digitled2.Text = "0"
        Digitled2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Digitled3
        ' 
        Digitled3.AutoSize = True
        Digitled3.BackColor = Color.Black
        Digitled3.DigitValue = 0
        Digitled3.Font = New Font("Courier New", 40F, FontStyle.Bold, GraphicsUnit.Point)
        Digitled3.ForeColor = Color.Red
        Digitled3.Location = New Point(241, 29)
        Digitled3.MaxDigitValue = 0
        Digitled3.Name = "Digitled3"
        Digitled3.Size = New Size(57, 60)
        Digitled3.TabIndex = 7
        Digitled3.Text = "0"
        Digitled3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(149, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 37)
        Label1.TabIndex = 8
        Label1.Text = ":"
        ' 
        ' AM
        ' 
        AM.AutoSize = True
        AM.Location = New Point(63, 10)
        AM.Name = "AM"
        AM.Size = New Size(44, 19)
        AM.TabIndex = 9
        AM.TabStop = True
        AM.Text = "AM"
        AM.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PM)
        GroupBox1.Controls.Add(AM)
        GroupBox1.Location = New Point(23, 105)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(275, 35)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' PM
        ' 
        PM.AutoSize = True
        PM.Location = New Point(155, 10)
        PM.Name = "PM"
        PM.Size = New Size(43, 19)
        PM.TabIndex = 10
        PM.TabStop = True
        PM.Text = "PM"
        PM.UseVisualStyleBackColor = True
        ' 
        ' ResetClock
        ' 
        ResetClock.ForeColor = Color.Red
        ResetClock.Location = New Point(337, 105)
        ResetClock.Name = "ResetClock"
        ResetClock.Size = New Size(103, 40)
        ResetClock.TabIndex = 12
        ResetClock.Text = "Reset"
        ResetClock.UseVisualStyleBackColor = True
        ' 
        ' SetClock
        ' 
        SetClock.ForeColor = Color.Red
        SetClock.Location = New Point(337, 29)
        SetClock.Name = "SetClock"
        SetClock.Size = New Size(103, 40)
        SetClock.TabIndex = 11
        SetClock.Text = "Set"
        SetClock.UseVisualStyleBackColor = True
        ' 
        ' TimePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ResetClock)
        Controls.Add(SetClock)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(Digitled3)
        Controls.Add(Digitled2)
        Controls.Add(Digitled1)
        Controls.Add(Digitled0)
        Name = "TimePanel"
        Size = New Size(459, 177)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Digitled0 As DigitLED
    Friend WithEvents Digitled1 As DigitLED
    Friend WithEvents Digitled2 As DigitLED
    Friend WithEvents Digitled3 As DigitLED
    Friend WithEvents Label1 As Label
    Friend WithEvents AM As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PM As RadioButton
    Friend WithEvents ResetClock As Button
    Friend WithEvents SetClock As Button

End Class
