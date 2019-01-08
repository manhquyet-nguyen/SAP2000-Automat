Imports System.Globalization
Imports System.IO
Imports System.Security

Public Class MainForm

    Public Shared Property DEFAULT_ANALYSIS_OPTIONS As AnalysisOptions = New AnalysisOptions(SolverType.MULTI_THREADED_SOLVER, SolverProcessType.SEPARATE_PROCESS, 1)

    Private analysisOptions

    Public Sub New()
        InitializeComponent()
        analysisOptions = DEFAULT_ANALYSIS_OPTIONS.clone()
    End Sub

    Private Sub btnSap2000ExePathBrowser_Click(sender As Object, e As EventArgs) Handles btnSap2000ExePathBrowser.Click
        Dim browser = New OpenFileDialog With {
            .FileName = txtSap2000ExePath.Text,
            .Filter = "EXE files (*.exe)|*.exe"
        }

        Dim action = browser.ShowDialog()
        If (action = DialogResult.OK) Then
            txtSap2000ExePath.Text = browser.FileName
        End If
        browser.Dispose()
    End Sub

    Private Sub btnSdbModelFileBrowser_Click(sender As Object, e As EventArgs) Handles btnSdbModelFileBrowser.Click
        Dim browser = New OpenFileDialog With {
            .FileName = txtSdbModelFile.Text,
            .Filter = "SDB files (*.sdb)|*.sdb|All files (*.*)|*.*"
        }

        Dim action = browser.ShowDialog()
        If (action = DialogResult.OK) Then
            txtSdbModelFile.Text = browser.FileName
        End If
        browser.Dispose()
    End Sub

    Private Sub btnInputFolderBrowser_Click(sender As Object, e As EventArgs) Handles btnInputFolderBrowser.Click
        Dim browser = New FolderBrowserDialog With {
            .ShowNewFolderButton = False,
            .SelectedPath = txtInputFolder.Text
        }

        Dim action = browser.ShowDialog()
        If (action = DialogResult.OK) Then
            txtInputFolder.Text = browser.SelectedPath
            refreshScannedInput()
        End If
        browser.Dispose()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshScannedInput()
    End Sub

    Private Sub refreshScannedInput()
        Dim includeSubDirectory = ckboxIncludeSubdirectory.Checked
        Dim scannedInputs = New List(Of String)
        Try
            scannedInputs = getScannedInput(txtInputFolder.Text, includeSubDirectory)
        Catch ex As ArgumentNullException
        Catch ex As ArgumentException
            MessageBox.Show("The path is not valid: " & ex.Message & vbCrLf & "Stack Trace: " & vbCrLf & ex.StackTrace)
        Catch ex As DirectoryNotFoundException
            MessageBox.Show("Directory does not exist: " & ex.Message & vbCrLf & "Stack Trace: " & vbCrLf & ex.StackTrace)
        Catch ex As PathTooLongException
            MessageBox.Show("The path exceeds the system-defined maximum length: " & ex.Message & vbCrLf & "Stack Trace: " & vbCrLf & ex.StackTrace)
        Catch ex As IOException
            MessageBox.Show("Directory points to an existing file: " & ex.Message & vbCrLf & "Stack Trace: " & vbCrLf & ex.StackTrace)
        Catch ex As NotSupportedException
            MessageBox.Show("A file or directory name in the path contains a colon (:) or is in an invalid format: " & ex.Message & vbCrLf & "Stack Trace: " & vbCrLf & ex.StackTrace)
        Catch ex As SecurityException
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("The user lacks necessary permissions: " & ex.Message & vbCrLf & "Stack Trace: " & vbCrLf & ex.StackTrace)
        End Try
        txtScannedInput.Lines = scannedInputs.ToArray
        lblScannedInputCount.Text = scannedInputs.Count
        lblRefreshTimestamp.Text = "At: " & Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Function getScannedInput(folder As String, includeSubDirectory As Boolean) As List(Of String)
        Dim scannedInputs = New List(Of String)

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(folder)
            scannedInputs.Add(foundFile)
        Next

        If (includeSubDirectory) Then
            For Each directory As String In My.Computer.FileSystem.GetDirectories(folder)
                scannedInputs.AddRange(getScannedInput(directory, includeSubDirectory))
            Next
        End If

        Return scannedInputs
    End Function

    Private Sub btnWorkspaceBrowser_Click(sender As Object, e As EventArgs) Handles btnWorkspaceBrowser.Click
        Dim browser = New FolderBrowserDialog With {
            .SelectedPath = txtWorkspacePath.Text
        }

        Dim action = browser.ShowDialog()
        If (action = DialogResult.OK) Then
            txtWorkspacePath.Text = browser.SelectedPath
        End If
        browser.Dispose()
    End Sub

    Private Sub btnOutputFolderBrowser_Click(sender As Object, e As EventArgs) Handles btnOutputFolderBrowser.Click
        Dim browser = New FolderBrowserDialog With {
            .SelectedPath = txtOutputFolder.Text
        }

        Dim action = browser.ShowDialog()
        If (action = DialogResult.OK) Then
            txtOutputFolder.Text = browser.SelectedPath
        End If
        browser.Dispose()
    End Sub

    Private Sub txtSdbModelFile_TextChanged(sender As Object, e As EventArgs) Handles txtSdbModelFile.TextChanged
        If (Not String.IsNullOrWhiteSpace(txtSdbModelFile.Text) And ckboxInheritModelPath.Checked) Then
            txtWorkspacePath.Text = Path.GetDirectoryName(txtSdbModelFile.Text) + "\Workspace"
        End If
    End Sub

    Private Sub txtWorkspacePath_Changed(sender As Object, e As EventArgs) Handles txtWorkspacePath.TextChanged
        If (Not String.IsNullOrWhiteSpace(txtWorkspacePath.Text) And ckboxInheritFromWorkspace.Checked) Then
            txtOutputFolder.Text = txtWorkspacePath.Text + "\Output"
        End If
    End Sub

    Private Sub menuConfigAnalysis_Click(sender As Object, e As EventArgs) Handles menuConfigAnalysis.Click
        Dim analysisOptionsForm = New AnalysisOptionsForm(analysisOptions)
        analysisOptionsForm.ShowDialog()
        analysisOptionsForm.Dispose()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (Not IsValid()) Then
            Return
        End If
        Dim numberOutSetup As Dictionary(Of String, Integer)
        Dim timestepSetup As Dictionary(Of String, Double)
        Dim inputFiles = New List(Of String)
        For Each line In txtScannedInput.Lines
            If (Path.GetFileName(line).StartsWith("numberout")) Then
                numberOutSetup = readNumberOutput(line)
            ElseIf (Path.GetFileName(line).StartsWith("timestep")) Then
                timestepSetup = readTimesteps(line)
            Else
                inputFiles.Add(line)
            End If
        Next

        Dim inputSetting As InputSetting = New InputSetting With {
            .sap2000ExePath = txtSap2000ExePath.Text,
            .sdbModelFilePath = txtSdbModelFile.Text,
            .workspaceFolder = txtWorkspacePath.Text,
            .numberOutputSettings = numberOutSetup,
            .timestepSettings = timestepSetup,
            .inputFiles = inputFiles
        }

        Dim outputSetting As OutputSetting = New OutputSetting With {
            .outputFolder = txtOutputFolder.Text,
            .outputFileNameFormat = txtOutputFileNameFormat.Text,
            .interestedPoints = txtInterestedPoints.Text.Split(",").ToList
        }

        Dim processSetting As ProcessSetting = New ProcessSetting With {
            .hideGui = ckboxHideGui.Checked
        }

        Dim analysisOptionsForm = New AnalysisForm(inputSetting, outputSetting, processSetting, analysisOptions)
        analysisOptionsForm.ShowDialog()
        analysisOptionsForm.Dispose()
    End Sub

    Private Function readNumberOutput(filePath As String) As Dictionary(Of String, Integer)
        Dim result = New Dictionary(Of String, Integer)
        For Each line As String In IO.File.ReadAllLines(filePath)
            Dim parts() As String = line.Split("=")
            result.Add(parts(0), Decimal.Parse(parts(1), NumberStyles.Float))
        Next
        Return result
    End Function

    Private Function readTimesteps(filePath As String) As Dictionary(Of String, Double)
        Dim result = New Dictionary(Of String, Double)
        For Each line As String In IO.File.ReadAllLines(filePath)
            Dim parts() As String = line.Split("=")
            result.Add(parts(0), Double.Parse(parts(1), NumberStyles.Float))
        Next
        Return result
    End Function

    Private Sub ckboxInheritModelPath_CheckedChanged(sender As Object, e As EventArgs) Handles ckboxInheritModelPath.CheckedChanged
        txtWorkspacePath.Enabled = Not ckboxInheritModelPath.Checked
        btnWorkspaceBrowser.Enabled = Not ckboxInheritModelPath.Checked
    End Sub

    Private Sub ckboxInheritFromWorkspace_CheckedChanged(sender As Object, e As EventArgs) Handles ckboxInheritFromWorkspace.CheckedChanged
        txtOutputFolder.Enabled = Not ckboxInheritFromWorkspace.Checked
        btnOutputFolderBrowser.Enabled = Not ckboxInheritFromWorkspace.Checked
    End Sub

    Private Sub txtInputFolder_TextChanged(sender As Object, e As EventArgs) Handles txtInputFolder.TextChanged
        btnRefresh.Enabled = Not String.IsNullOrWhiteSpace(txtInputFolder.Text) And Directory.Exists(txtInputFolder.Text)

        If (btnRefresh.Enabled) Then
            refreshScannedInput()
        Else
            txtScannedInput.Lines = Nothing
            lblScannedInputCount.Text = 0
        End If
    End Sub

    Private Sub ckboxIncludeSubdirectory_CheckedChanged(sender As Object, e As EventArgs) Handles ckboxIncludeSubdirectory.CheckedChanged
        If (Not String.IsNullOrWhiteSpace(txtInputFolder.Text) And Directory.Exists(txtInputFolder.Text)) Then
            refreshScannedInput()
        End If
    End Sub

    Private Function IsValid() As Boolean
        If (String.IsNullOrWhiteSpace(txtSap2000ExePath.Text) Or Not File.Exists(txtSap2000ExePath.Text)) Then
            MessageBox.Show("SAP2000 executable file path is not set!")
            Return False
        End If

        If (String.IsNullOrWhiteSpace(txtSdbModelFile.Text) Or Not File.Exists(txtSdbModelFile.Text)) Then
            MessageBox.Show("Model file path is not set!")
            Return False
        End If

        If (String.IsNullOrWhiteSpace(txtWorkspacePath.Text)) Then
            MessageBox.Show("Workspace is not set!")
            Return False
        End If

        If (txtScannedInput.Lines.Count = 0) Then
            MessageBox.Show("Input files are not set!")
            Return False
        End If

        If (String.IsNullOrWhiteSpace(txtOutputFolder.Text)) Then
            MessageBox.Show("Output folder is not set!")
            Return False
        End If

        If (String.IsNullOrWhiteSpace(txtOutputFileNameFormat.Text)) Then
            MessageBox.Show("Output file name format is not set!")
            Return False
        End If

        If (String.IsNullOrWhiteSpace(txtInterestedPoints.Text)) Then
            MessageBox.Show("Interseted points are not set!")
            Return False
        End If
        Return True
    End Function

    Private Sub menuFileQuit_Click(sender As Object, e As EventArgs) Handles menuFileQuit.Click
        Me.Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(SavedSetting))
        Dim savedSetting = New SavedSetting With {
            .sap2000ExePath = txtSap2000ExePath.Text,
            .modelPath = txtSdbModelFile.Text,
            .inputFolder = txtInputFolder.Text,
            .outputFileNameFormat = txtOutputFileNameFormat.Text,
            .interestedPoints = txtInterestedPoints.Text
        }
        Dim file As New System.IO.StreamWriter("settings.xml")
        writer.Serialize(file, savedSetting)
        file.Close()
    End Sub

    Private Sub LoadPreviousSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadPreviousSettingsToolStripMenuItem.Click
        If (Not IO.File.Exists("settings.xml")) Then
            Return
        End If
        Dim file As New StreamReader("settings.xml")
        Dim reader As New Xml.Serialization.XmlSerializer(GetType(SavedSetting))

        Dim setting As SavedSetting = reader.Deserialize(file)
        txtSap2000ExePath.Text = setting.sap2000ExePath
        txtSdbModelFile.Text = setting.modelPath
        txtInputFolder.Text = setting.inputFolder
        txtOutputFileNameFormat.Text = setting.outputFileNameFormat
        txtInterestedPoints.Text = setting.interestedPoints
    End Sub

    Public Class SavedSetting
        Property sap2000ExePath As String
        Property modelPath As String
        Property inputFolder As String
        Property outputFileNameFormat As String
        Property interestedPoints As String
    End Class
End Class
