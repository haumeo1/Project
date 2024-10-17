Public Class DigitLED
    Private MaxDigit As Integer
    Private Digit As Integer
    Public Property MaxDigitValue() As Integer
        Get
            Return MaxDigit
        End Get
        Set(ByVal value As Integer)
            MaxDigit = value
        End Set
    End Property
    Public Property DigitValue() As Integer
        Get
            Return Digit
        End Get
        Set(ByVal value As Integer)
            Digit = value
            Me.Text = Digit.ToString()
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        Me.AutoSize = False
        Me.Size = New Size(20, 40)
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.Font = New Font("Courier New", 40, FontStyle.Bold)
        Me.ForeColor = Color.Red
        Me.BackColor = Color.Black
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here

    End Sub

End Class
