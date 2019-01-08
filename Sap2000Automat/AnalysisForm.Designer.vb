<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalysisForm
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
        Me.txtInstancesRunning = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.timerAnalyzing = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtInstancesRunning
        '
        Me.txtInstancesRunning.Location = New System.Drawing.Point(12, 34)
        Me.txtInstancesRunning.MaxLength = 327670
        Me.txtInstancesRunning.Multiline = True
        Me.txtInstancesRunning.Name = "txtInstancesRunning"
        Me.txtInstancesRunning.ReadOnly = True
        Me.txtInstancesRunning.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInstancesRunning.Size = New System.Drawing.Size(386, 122)
        Me.txtInstancesRunning.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Status:"
        '
        'timerAnalyzing
        '
        Me.timerAnalyzing.Interval = 1000
        '
        'AnalysisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 170)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtInstancesRunning)
        Me.Name = "AnalysisForm"
        Me.Text = "AnalysisForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInstancesRunning As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents timerAnalyzing As Timer
End Class
