Imports System.Threading

Public Class AnalysisForm
    Property inputSetting As InputSetting
    Property outputSetting As OutputSetting
    Property processSetting As ProcessSetting
    Property analysisOptions As AnalysisOptions
    Private threads As List(Of Thread)

    Public Sub New(inputSetting As InputSetting, outputSetting As OutputSetting, processSetting As ProcessSetting, analysisOptions As AnalysisOptions)
        ' This call is required by the designer.
        InitializeComponent()

        Me.inputSetting = inputSetting
        Me.outputSetting = outputSetting
        Me.processSetting = processSetting
        Me.analysisOptions = analysisOptions
    End Sub

    Private Sub AnalysisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "Status: Initializing..."
        timerAnalyzing.Start()
    End Sub

    Private Sub AnalysisForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim sapManager = New SapManager(inputSetting, outputSetting, processSetting, analysisOptions)
        threads = sapManager.start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerAnalyzing.Tick
        If (pollThreadsStatus(threads)) Then
            lblStatus.Text = "Status: Complete!"
        End If
    End Sub

    Private Function pollThreadsStatus(threads As List(Of Thread)) As Boolean
        If (threads.Count = 0) Then
            Return False
        End If

        lblStatus.Text = "Status: Analyzing..."

        Dim status = New List(Of String)
        Dim allFinished = True
        For Each thread In threads
            If (thread.IsAlive) Then
                status.Add("Instance " & thread.Name & ": Running...")
                allFinished = False
            Else
                status.Add("Instance " & thread.Name & ": Finished")
            End If
        Next
        txtInstancesRunning.Lines = status.ToArray
        Return allFinished
    End Function
End Class