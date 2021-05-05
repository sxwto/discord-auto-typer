Imports Discord
Imports Discord.WebSocket
Public Class Form1
    Dim interval As Integer
    Dim i As Integer = 0
    Dim delayTime As Integer
    Dim d As Integer = 0
    Dim delayDone As Boolean = False
    Dim isActive As Boolean
    Dim cancel = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeDisplayLabel.Text = "Not running."
        Me.Text = "Auto Typer - By Dilusionz#0001"
    End Sub

    Private Sub timerStart_Click(sender As Object, e As EventArgs) Handles timerStart.Click
        StartType()
    End Sub

    Private Sub StartType()
        If timer.Enabled = False Then
            If IsNumeric(intervalInput.Text) Then
                interval = Int(intervalInput.Text)
                i = 0
                timeDisplayLabel.Text = "Typing in " + (interval - i).ToString() + " Seconds"
                timer.Enabled = True
            End If
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        i += 1
        timeDisplayLabel.Text = "Typing in " + (interval - i).ToString() + " Seconds"
        If i = interval Then
            timer.Enabled = False
            doType()
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Reset()
    End Sub

    Private Sub doType()
        Dim curLineText
        For x = 0 To messageBox.Lines.Count - 1
            If cancel Then
                Exit For
            End If
            curLineText = messageBox.Lines(x)
            If x > 0 Then
                If doDelay.Checked And IsNumeric(delayBox.Text) Then
                    d = 0
                    delayTime = delayBox.Text
                    delayTimer.Enabled = True
                    timeDisplayLabel.Text = "Line delay " + (delayTime - d).ToString() + " Seconds"
                    While Not delayDone
                        Application.DoEvents()
                    End While
                    delayDone = False
                End If
                typeIt(curLineText)
            Else
                typeIt(curLineText)
            End If
        Next
        timer.Enabled = False
        If loopCheck.Checked Then
            Reset()
            StartType()
        Else
            timeDisplayLabel.Text = "Operation completed."
        End If
    End Sub

    Private Sub typeIt(ByVal e)
        If Not isActive Then
            For i As Integer = 0 To e.Length - 1
                Dim s = e.Substring(i, 1)
                My.Computer.Keyboard.SendKeys(s)
            Next
            My.Computer.Keyboard.SendKeys("{ENTER}")
        Else
            Reset()
            MsgBox("Operation cancelled, attempted to type into this form.")
        End If
    End Sub

    Private Sub Reset()
        timer.Enabled = False
        delayTimer.Enabled = False
        i = 0
        d = 0
        timeDisplayLabel.Text = "Not running."
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        d += 1
        timeDisplayLabel.Text = "Line delay " + (delayTime - d).ToString() + " Seconds"
        If d = delayTime Then
            delayDone = True
            d = 0
            delayTimer.Enabled = False
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        isActive = True
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        isActive = False
    End Sub
End Class