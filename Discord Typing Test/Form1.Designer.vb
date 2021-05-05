<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.timerStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.intervalInput = New System.Windows.Forms.TextBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.timeDisplayLabel = New System.Windows.Forms.Label()
        Me.messageBox = New System.Windows.Forms.RichTextBox()
        Me.loopCheck = New System.Windows.Forms.CheckBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.delayBox = New System.Windows.Forms.TextBox()
        Me.doDelay = New System.Windows.Forms.CheckBox()
        Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timerStart
        '
        Me.timerStart.Font = New System.Drawing.Font("Plumpfull", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerStart.Location = New System.Drawing.Point(403, 90)
        Me.timerStart.Name = "timerStart"
        Me.timerStart.Size = New System.Drawing.Size(75, 23)
        Me.timerStart.TabIndex = 0
        Me.timerStart.Text = "Start"
        Me.timerStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Plumpfull", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Auto Typer"
        '
        'intervalInput
        '
        Me.intervalInput.Location = New System.Drawing.Point(445, 154)
        Me.intervalInput.Name = "intervalInput"
        Me.intervalInput.Size = New System.Drawing.Size(100, 20)
        Me.intervalInput.TabIndex = 2
        Me.intervalInput.Text = "Interval (seconds)"
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'timeDisplayLabel
        '
        Me.timeDisplayLabel.AutoSize = True
        Me.timeDisplayLabel.Location = New System.Drawing.Point(444, 59)
        Me.timeDisplayLabel.Name = "timeDisplayLabel"
        Me.timeDisplayLabel.Size = New System.Drawing.Size(101, 13)
        Me.timeDisplayLabel.TabIndex = 3
        Me.timeDisplayLabel.Text = "Typing in . Seconds"
        '
        'messageBox
        '
        Me.messageBox.Location = New System.Drawing.Point(21, 90)
        Me.messageBox.Name = "messageBox"
        Me.messageBox.Size = New System.Drawing.Size(343, 236)
        Me.messageBox.TabIndex = 4
        Me.messageBox.Text = ""
        '
        'loopCheck
        '
        Me.loopCheck.AutoSize = True
        Me.loopCheck.Location = New System.Drawing.Point(465, 119)
        Me.loopCheck.Name = "loopCheck"
        Me.loopCheck.Size = New System.Drawing.Size(56, 17)
        Me.loopCheck.TabIndex = 5
        Me.loopCheck.Text = "Loop?"
        Me.loopCheck.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Plumpfull", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(500, 90)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 0
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'delayBox
        '
        Me.delayBox.Location = New System.Drawing.Point(445, 226)
        Me.delayBox.Name = "delayBox"
        Me.delayBox.Size = New System.Drawing.Size(100, 20)
        Me.delayBox.TabIndex = 2
        Me.delayBox.Text = "Line delay (seconds)"
        '
        'doDelay
        '
        Me.doDelay.AutoSize = True
        Me.doDelay.Location = New System.Drawing.Point(432, 192)
        Me.doDelay.Name = "doDelay"
        Me.doDelay.Size = New System.Drawing.Size(127, 17)
        Me.doDelay.TabIndex = 6
        Me.doDelay.Text = "Delay between lines?"
        Me.doDelay.UseVisualStyleBackColor = True
        '
        'delayTimer
        '
        Me.delayTimer.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Plumpfull", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "For Discord"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(597, 351)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.doDelay)
        Me.Controls.Add(Me.loopCheck)
        Me.Controls.Add(Me.messageBox)
        Me.Controls.Add(Me.timeDisplayLabel)
        Me.Controls.Add(Me.delayBox)
        Me.Controls.Add(Me.intervalInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.timerStart)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Auto Typer - By Dilusionz#0001"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timerStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents intervalInput As TextBox
    Friend WithEvents timer As Timer
    Friend WithEvents timeDisplayLabel As Label
    Friend WithEvents messageBox As RichTextBox
    Friend WithEvents loopCheck As CheckBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents delayBox As TextBox
    Friend WithEvents doDelay As CheckBox
    Friend WithEvents delayTimer As Timer
    Friend WithEvents Label2 As Label
End Class
