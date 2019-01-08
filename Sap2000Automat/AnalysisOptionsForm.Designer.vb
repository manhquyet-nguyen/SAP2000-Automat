<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalysisOptionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSolverType = New System.Windows.Forms.ComboBox()
        Me.cbSolverProcessType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtInstanceCount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solver Type"
        '
        'cbSolverType
        '
        Me.cbSolverType.FormattingEnabled = True
        Me.cbSolverType.Location = New System.Drawing.Point(175, 20)
        Me.cbSolverType.Name = "cbSolverType"
        Me.cbSolverType.Size = New System.Drawing.Size(220, 21)
        Me.cbSolverType.TabIndex = 1
        '
        'cbSolverProcessType
        '
        Me.cbSolverProcessType.FormattingEnabled = True
        Me.cbSolverProcessType.Location = New System.Drawing.Point(175, 60)
        Me.cbSolverProcessType.Name = "cbSolverProcessType"
        Me.cbSolverProcessType.Size = New System.Drawing.Size(220, 21)
        Me.cbSolverProcessType.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Solver Process Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Instance count"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(83, 142)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(175, 142)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 7
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(272, 142)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtInstanceCount
        '
        Me.txtInstanceCount.Location = New System.Drawing.Point(175, 101)
        Me.txtInstanceCount.Name = "txtInstanceCount"
        Me.txtInstanceCount.Size = New System.Drawing.Size(75, 20)
        Me.txtInstanceCount.TabIndex = 9
        '
        'AnalysisOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 189)
        Me.Controls.Add(Me.txtInstanceCount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSolverProcessType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbSolverType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AnalysisOptionsForm"
        Me.Text = "Analysis Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbSolverType As ComboBox
    Friend WithEvents cbSolverProcessType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDefault As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtInstanceCount As TextBox
End Class
