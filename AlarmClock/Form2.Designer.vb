<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        AlarmRinging = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' AlarmRinging
        ' 
        AlarmRinging.AutoSize = True
        AlarmRinging.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        AlarmRinging.Location = New Point(207, 51)
        AlarmRinging.Name = "AlarmRinging"
        AlarmRinging.Size = New Size(186, 37)
        AlarmRinging.TabIndex = 0
        AlarmRinging.Text = "Alarm Ringing"
        AlarmRinging.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(230, 146)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 43)
        Button1.TabIndex = 1
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(614, 251)
        Controls.Add(Button1)
        Controls.Add(AlarmRinging)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AlarmRinging As Label
    Friend WithEvents Button1 As Button
End Class
