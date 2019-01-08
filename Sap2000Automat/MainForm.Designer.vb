<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSap2000ExePath = New System.Windows.Forms.TextBox()
        Me.btnSap2000ExePathBrowser = New System.Windows.Forms.Button()
        Me.btnSdbModelFileBrowser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckboxHideGui = New System.Windows.Forms.CheckBox()
        Me.btnInputFolderBrowser = New System.Windows.Forms.Button()
        Me.txtInputFolder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckboxIncludeSubdirectory = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ckboxInheritFromWorkspace = New System.Windows.Forms.CheckBox()
        Me.txtInterestedPoints = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOutputFileNameFormat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnOutputFolderBrowser = New System.Windows.Forms.Button()
        Me.txtOutputFolder = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSdbModelFile = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckboxInheritModelPath = New System.Windows.Forms.CheckBox()
        Me.btnWorkspaceBrowser = New System.Windows.Forms.Button()
        Me.txtWorkspacePath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtScannedInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblScannedInputCount = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRefreshTimestamp = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfigAnalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.LoadPreviousSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sap2000 Exe File"
        '
        'txtSap2000ExePath
        '
        Me.txtSap2000ExePath.Location = New System.Drawing.Point(134, 58)
        Me.txtSap2000ExePath.Name = "txtSap2000ExePath"
        Me.txtSap2000ExePath.Size = New System.Drawing.Size(357, 20)
        Me.txtSap2000ExePath.TabIndex = 1
        '
        'btnSap2000ExePathBrowser
        '
        Me.btnSap2000ExePathBrowser.Location = New System.Drawing.Point(497, 57)
        Me.btnSap2000ExePathBrowser.Name = "btnSap2000ExePathBrowser"
        Me.btnSap2000ExePathBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnSap2000ExePathBrowser.TabIndex = 2
        Me.btnSap2000ExePathBrowser.Text = "Browse"
        Me.btnSap2000ExePathBrowser.UseVisualStyleBackColor = True
        '
        'btnSdbModelFileBrowser
        '
        Me.btnSdbModelFileBrowser.Location = New System.Drawing.Point(497, 100)
        Me.btnSdbModelFileBrowser.Name = "btnSdbModelFileBrowser"
        Me.btnSdbModelFileBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnSdbModelFileBrowser.TabIndex = 5
        Me.btnSdbModelFileBrowser.Text = "Browse"
        Me.btnSdbModelFileBrowser.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SDB Model File"
        '
        'ckboxHideGui
        '
        Me.ckboxHideGui.AutoSize = True
        Me.ckboxHideGui.Location = New System.Drawing.Point(581, 61)
        Me.ckboxHideGui.Name = "ckboxHideGui"
        Me.ckboxHideGui.Size = New System.Drawing.Size(70, 17)
        Me.ckboxHideGui.TabIndex = 6
        Me.ckboxHideGui.Text = "Hide GUI"
        Me.ckboxHideGui.UseVisualStyleBackColor = True
        '
        'btnInputFolderBrowser
        '
        Me.btnInputFolderBrowser.Location = New System.Drawing.Point(497, 144)
        Me.btnInputFolderBrowser.Name = "btnInputFolderBrowser"
        Me.btnInputFolderBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnInputFolderBrowser.TabIndex = 9
        Me.btnInputFolderBrowser.Text = "Browse"
        Me.btnInputFolderBrowser.UseVisualStyleBackColor = True
        '
        'txtInputFolder
        '
        Me.txtInputFolder.Location = New System.Drawing.Point(134, 145)
        Me.txtInputFolder.Name = "txtInputFolder"
        Me.txtInputFolder.Size = New System.Drawing.Size(357, 20)
        Me.txtInputFolder.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Input Folder"
        '
        'ckboxIncludeSubdirectory
        '
        Me.ckboxIncludeSubdirectory.AutoSize = True
        Me.ckboxIncludeSubdirectory.Checked = True
        Me.ckboxIncludeSubdirectory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckboxIncludeSubdirectory.Location = New System.Drawing.Point(582, 149)
        Me.ckboxIncludeSubdirectory.Name = "ckboxIncludeSubdirectory"
        Me.ckboxIncludeSubdirectory.Size = New System.Drawing.Size(123, 17)
        Me.ckboxIncludeSubdirectory.TabIndex = 10
        Me.ckboxIncludeSubdirectory.Text = "Include Subdirectory"
        Me.ckboxIncludeSubdirectory.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ckboxInheritFromWorkspace)
        Me.GroupBox3.Controls.Add(Me.txtInterestedPoints)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtOutputFileNameFormat)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btnOutputFolderBrowser)
        Me.GroupBox3.Controls.Add(Me.txtOutputFolder)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(694, 143)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output Setting"
        '
        'ckboxInheritFromWorkspace
        '
        Me.ckboxInheritFromWorkspace.AutoSize = True
        Me.ckboxInheritFromWorkspace.Checked = True
        Me.ckboxInheritFromWorkspace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckboxInheritFromWorkspace.Location = New System.Drawing.Point(550, 29)
        Me.ckboxInheritFromWorkspace.Name = "ckboxInheritFromWorkspace"
        Me.ckboxInheritFromWorkspace.Size = New System.Drawing.Size(139, 17)
        Me.ckboxInheritFromWorkspace.TabIndex = 20
        Me.ckboxInheritFromWorkspace.Text = "Inherit From Workspace"
        Me.ckboxInheritFromWorkspace.UseVisualStyleBackColor = True
        '
        'txtInterestedPoints
        '
        Me.txtInterestedPoints.CausesValidation = False
        Me.txtInterestedPoints.Location = New System.Drawing.Point(136, 102)
        Me.txtInterestedPoints.Name = "txtInterestedPoints"
        Me.txtInterestedPoints.Size = New System.Drawing.Size(324, 20)
        Me.txtInterestedPoints.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Interested Join Points"
        '
        'txtOutputFileNameFormat
        '
        Me.txtOutputFileNameFormat.CausesValidation = False
        Me.txtOutputFileNameFormat.Location = New System.Drawing.Point(136, 63)
        Me.txtOutputFileNameFormat.Name = "txtOutputFileNameFormat"
        Me.txtOutputFileNameFormat.Size = New System.Drawing.Size(324, 20)
        Me.txtOutputFileNameFormat.TabIndex = 24
        Me.txtOutputFileNameFormat.Text = "V-${input}.xlsx"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Output File Name Format"
        '
        'btnOutputFolderBrowser
        '
        Me.btnOutputFolderBrowser.Enabled = False
        Me.btnOutputFolderBrowser.Location = New System.Drawing.Point(466, 25)
        Me.btnOutputFolderBrowser.Name = "btnOutputFolderBrowser"
        Me.btnOutputFolderBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnOutputFolderBrowser.TabIndex = 22
        Me.btnOutputFolderBrowser.Text = "Browse"
        Me.btnOutputFolderBrowser.UseVisualStyleBackColor = True
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.CausesValidation = False
        Me.txtOutputFolder.Enabled = False
        Me.txtOutputFolder.Location = New System.Drawing.Point(136, 26)
        Me.txtOutputFolder.Name = "txtOutputFolder"
        Me.txtOutputFolder.Size = New System.Drawing.Size(324, 20)
        Me.txtOutputFolder.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Output Folder"
        '
        'txtSdbModelFile
        '
        Me.txtSdbModelFile.Location = New System.Drawing.Point(134, 101)
        Me.txtSdbModelFile.Name = "txtSdbModelFile"
        Me.txtSdbModelFile.Size = New System.Drawing.Size(357, 20)
        Me.txtSdbModelFile.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckboxInheritModelPath)
        Me.GroupBox1.Controls.Add(Me.btnWorkspaceBrowser)
        Me.GroupBox1.Controls.Add(Me.txtWorkspacePath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(694, 191)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Setting"
        '
        'ckboxInheritModelPath
        '
        Me.ckboxInheritModelPath.AutoSize = True
        Me.ckboxInheritModelPath.Checked = True
        Me.ckboxInheritModelPath.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckboxInheritModelPath.Location = New System.Drawing.Point(551, 155)
        Me.ckboxInheritModelPath.Name = "ckboxInheritModelPath"
        Me.ckboxInheritModelPath.Size = New System.Drawing.Size(138, 17)
        Me.ckboxInheritModelPath.TabIndex = 17
        Me.ckboxInheritModelPath.Text = "Inherit From Model Path"
        Me.ckboxInheritModelPath.UseVisualStyleBackColor = True
        '
        'btnWorkspaceBrowser
        '
        Me.btnWorkspaceBrowser.Enabled = False
        Me.btnWorkspaceBrowser.Location = New System.Drawing.Point(466, 150)
        Me.btnWorkspaceBrowser.Name = "btnWorkspaceBrowser"
        Me.btnWorkspaceBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnWorkspaceBrowser.TabIndex = 19
        Me.btnWorkspaceBrowser.Text = "Browse"
        Me.btnWorkspaceBrowser.UseVisualStyleBackColor = True
        '
        'txtWorkspacePath
        '
        Me.txtWorkspacePath.CausesValidation = False
        Me.txtWorkspacePath.Enabled = False
        Me.txtWorkspacePath.Location = New System.Drawing.Point(103, 151)
        Me.txtWorkspacePath.Name = "txtWorkspacePath"
        Me.txtWorkspacePath.Size = New System.Drawing.Size(357, 20)
        Me.txtWorkspacePath.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Workspace"
        '
        'txtScannedInput
        '
        Me.txtScannedInput.Location = New System.Drawing.Point(6, 19)
        Me.txtScannedInput.MaxLength = 327670
        Me.txtScannedInput.Multiline = True
        Me.txtScannedInput.Name = "txtScannedInput"
        Me.txtScannedInput.ReadOnly = True
        Me.txtScannedInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtScannedInput.Size = New System.Drawing.Size(386, 114)
        Me.txtScannedInput.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Scanned Input:"
        '
        'lblScannedInputCount
        '
        Me.lblScannedInputCount.AutoSize = True
        Me.lblScannedInputCount.Location = New System.Drawing.Point(94, 156)
        Me.lblScannedInputCount.Name = "lblScannedInputCount"
        Me.lblScannedInputCount.Size = New System.Drawing.Size(13, 13)
        Me.lblScannedInputCount.TabIndex = 2
        Me.lblScannedInputCount.Text = "0"
        '
        'btnRefresh
        '
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.Location = New System.Drawing.Point(317, 151)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblRefreshTimestamp)
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.lblScannedInputCount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtScannedInput)
        Me.GroupBox2.Location = New System.Drawing.Point(731, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 191)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scanned Input"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 5
        '
        'lblRefreshTimestamp
        '
        Me.lblRefreshTimestamp.AutoSize = True
        Me.lblRefreshTimestamp.Location = New System.Drawing.Point(163, 156)
        Me.lblRefreshTimestamp.Name = "lblRefreshTimestamp"
        Me.lblRefreshTimestamp.Size = New System.Drawing.Size(80, 13)
        Me.lblRefreshTimestamp.TabIndex = 4
        Me.lblRefreshTimestamp.Text = "At: d/m/y h:m:s"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(867, 273)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(202, 69)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadPreviousSettingsToolStripMenuItem, Me.menuFileQuit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "File"
        '
        'menuFileQuit
        '
        Me.menuFileQuit.Name = "menuFileQuit"
        Me.menuFileQuit.Size = New System.Drawing.Size(180, 22)
        Me.menuFileQuit.Text = "Exit"
        '
        'menuConfig
        '
        Me.menuConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuConfigAnalysis})
        Me.menuConfig.Name = "menuConfig"
        Me.menuConfig.Size = New System.Drawing.Size(55, 20)
        Me.menuConfig.Text = "Config"
        '
        'menuConfigAnalysis
        '
        Me.menuConfigAnalysis.Name = "menuConfigAnalysis"
        Me.menuConfigAnalysis.Size = New System.Drawing.Size(162, 22)
        Me.menuConfigAnalysis.Text = "Analysis Options"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuConfig})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip2.Size = New System.Drawing.Size(1167, 24)
        Me.MenuStrip2.TabIndex = 15
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'LoadPreviousSettingsToolStripMenuItem
        '
        Me.LoadPreviousSettingsToolStripMenuItem.Name = "LoadPreviousSettingsToolStripMenuItem"
        Me.LoadPreviousSettingsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LoadPreviousSettingsToolStripMenuItem.Text = "Load Previous Settings"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 400)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ckboxIncludeSubdirectory)
        Me.Controls.Add(Me.btnInputFolderBrowser)
        Me.Controls.Add(Me.txtInputFolder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ckboxHideGui)
        Me.Controls.Add(Me.btnSdbModelFileBrowser)
        Me.Controls.Add(Me.txtSdbModelFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSap2000ExePathBrowser)
        Me.Controls.Add(Me.txtSap2000ExePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "MainForm"
        Me.Text = "SAP2000 Automat"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSap2000ExePath As TextBox
    Friend WithEvents btnSap2000ExePathBrowser As Button
    Friend WithEvents btnSdbModelFileBrowser As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ckboxHideGui As CheckBox
    Friend WithEvents btnInputFolderBrowser As Button
    Friend WithEvents txtInputFolder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ckboxIncludeSubdirectory As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSdbModelFile As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtScannedInput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblScannedInputCount As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRefreshTimestamp As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnWorkspaceBrowser As Button
    Friend WithEvents txtWorkspacePath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnOutputFolderBrowser As Button
    Friend WithEvents txtOutputFolder As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOutputFileNameFormat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInterestedPoints As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ckboxInheritModelPath As CheckBox
    Friend WithEvents ckboxInheritFromWorkspace As CheckBox
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuFileQuit As ToolStripMenuItem
    Friend WithEvents menuConfig As ToolStripMenuItem
    Friend WithEvents menuConfigAnalysis As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents LoadPreviousSettingsToolStripMenuItem As ToolStripMenuItem
End Class
