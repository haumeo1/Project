Public Class TimePanel
    Private digits As DigitLED()
    Private currentDigitIndex As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        digits = {Digitled0, Digitled1, Digitled2, Digitled3}
        currentDigitIndex = 0
    End Sub

    Public Sub InputDigit(digit As Integer)
        If currentDigitIndex = 0 Then
            digits(currentDigitIndex).MaxDigitValue = 1
        ElseIf currentDigitIndex = 1 AndAlso digits(currentDigitIndex - 1).DigitValue() = 1 Then
            digits(currentDigitIndex).MaxDigitValue = 2
        ElseIf currentDigitIndex = 1 Then
            digits(currentDigitIndex).MaxDigitValue = 9
        ElseIf currentDigitIndex = 2 Then
            digits(currentDigitIndex).MaxDigitValue = 5
        Else
            digits(currentDigitIndex).MaxDigitValue = 9
        End If

        If currentDigitIndex < digits.Length Then
            Dim digitLED As DigitLED = digits(currentDigitIndex)
            If digit <= digitLED.MaxDigitValue() Then
                digitLED.DigitValue = digit
                currentDigitIndex += 1 ' Move to the next digit
            End If
        End If
    End Sub

    Public Function IsDigitValid(digit As Integer) As Boolean
        If currentDigitIndex < digits.Length Then
            Dim maxDigit As Integer = digits(currentDigitIndex).MaxDigitValue()
            Return digit <= maxDigit
        End If
        Return False
    End Function

    Public Sub CancelInput()
        currentDigitIndex = 0
        For Each digitLED As DigitLED In digits
            digitLED.DigitValue = 0 ' Reset each digit to 0
        Next
    End Sub

    Private Sub SetClock_Click(sender As Object, e As EventArgs) Handles SetClock.Click

    End Sub
End Class
