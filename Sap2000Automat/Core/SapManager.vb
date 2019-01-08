Imports System.Threading
Imports Sap2000Automat

Public Class SapManager
    Property inputSetting As InputSetting
    Property outputSetting As OutputSetting
    Property processSetting As ProcessSetting
    Property analysisOptions As AnalysisOptions

    Public Sub New(inputSetting As InputSetting, outputSetting As OutputSetting, processSetting As ProcessSetting, analysisOptions As AnalysisOptions)
        Me.inputSetting = inputSetting
        Me.outputSetting = outputSetting
        Me.processSetting = processSetting
        Me.analysisOptions = analysisOptions
    End Sub

    Public Function start() As List(Of Thread)
        'n = c * l + r = (c - r) * l + r * (l + 1)
        Dim n = inputSetting.inputFiles.Count
        Dim c = analysisOptions.instancesCount
        Dim l = n \ c
        Dim r = n Mod c

        Dim threads = New List(Of Thread)
        For i = 1 To c - r
            Dim subInput = inputSetting.clone
            subInput.inputFiles = inputSetting.inputFiles.GetRange((i - 1) * l, l)
            threads.Add(delegateToWorker(subInput, outputSetting, processSetting, analysisOptions))
        Next

        Dim offset = (c - r) * l
        For i = 1 To r
            Dim subInput = inputSetting.clone
            subInput.inputFiles = inputSetting.inputFiles.GetRange(offset + (i - 1) * (l + 1), l + 1)
            threads.Add(delegateToWorker(subInput, outputSetting, processSetting, analysisOptions))
        Next
        Return threads
    End Function

    Private Function delegateToWorker(inputSetting As InputSetting, outputSetting As OutputSetting, processSetting As ProcessSetting, analysisOptions As AnalysisOptions) As Thread
        Console.Out.WriteLine(String.Join(", ", inputSetting.inputFiles))
        Dim worker = New SapWorker(inputSetting, outputSetting, processSetting, analysisOptions)
        Dim thread = New Thread(AddressOf worker.analyze) With {
            .IsBackground = True
        }
        thread.Name = worker.name
        thread.Start()
        Return thread
    End Function
End Class
