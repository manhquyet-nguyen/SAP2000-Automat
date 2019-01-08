Imports System.IO
Imports Microsoft.Office.Interop.Excel

Public Class SapWorker
    Property inputSetting As InputSetting
    Property outputSetting As OutputSetting
    Property processSetting As ProcessSetting
    Property analysisOptions As AnalysisOptions
    Public ReadOnly name = "Worker-" & Guid.NewGuid.ToString

    Dim sapCore As SAP2000v20.cOAPI
    Dim sapHelper As SAP2000v20.cHelper
    Dim sapModel As SAP2000v20.cSapModel


    Public Sub New(inputSetting As InputSetting, outputSetting As OutputSetting, processSetting As ProcessSetting, analysisOptions As AnalysisOptions)
        Me.inputSetting = inputSetting
        Me.outputSetting = outputSetting
        Me.processSetting = processSetting
        Me.analysisOptions = analysisOptions
    End Sub

    Private Sub init()
        sapHelper = New SAP2000v20.Helper
        sapCore = sapHelper.CreateObject(inputSetting.sap2000ExePath)
        sapCore.ApplicationStart()
        If (processSetting.hideGui) Then
            sapCore.Hide()
        End If
        sapModel = sapCore.SapModel
        sapModel.InitializeNewModel()

        Dim workspaceFolder = inputSetting.workspaceFolder + "\" + name
        sapModel.File.OpenFile(FileUtil.duplicateFile(inputSetting.sdbModelFilePath, workspaceFolder))
    End Sub

    Public Sub analyze()
        init()

        Dim data = New Dictionary(Of String, String)

        For Each inputFile In inputSetting.inputFiles
            Dim inputFileName = Path.GetFileNameWithoutExtension(inputFile)
            Dim inputPrefix = inputFileName.Split("_")(0)
            'Define function
            Dim funcName = "func_" + inputFileName
            defineTimeFunction(funcName, inputFile, inputSetting.timestepSettings.Item(inputPrefix))
            'Define load case
            Dim caseName = "case_" + inputFileName
            defineLoadCase(caseName, inputSetting.numberOutputSettings.Item(inputPrefix), inputSetting.timestepSettings.Item(inputPrefix))
            'Load predefined function
            loadCase(caseName, funcName)
            'Remember case name
            data.Add(inputFileName, caseName)
        Next

        'Analyze
        sapModel.Analyze.SetSolverOption_1(analysisOptions.solverType, analysisOptions.solverProcessType, analysisOptions.force32Bit)
        sapModel.Analyze.RunAnalysis()

        createFolderIfNotExists(outputSetting.outputFolder)
        'Extract result
        For Each entry In data
            extractResult(entry.Key, entry.Value)
        Next
    End Sub

    'Define a function and return function name
    Private Sub defineTimeFunction(funcName As String, inputFile As String, timestep As Double)
        sapModel.Func.FuncTH.SetFromFile_1(funcName, inputFile, 0, 0, 1, 1, True, False, timestep)
    End Sub

    Private Sub defineLoadCase(caseName As String, outputSteps As Integer, stepSize As Double)
        Dim loadCase = sapModel.LoadCases.DirHistNonlinear
        loadCase.SetCase(caseName)
        loadCase.SetGeometricNonlinearity(caseName, 1)
        loadCase.SetMassSource(caseName, "")
        loadCase.SetInitialCase(caseName, "GRAVITY")
        loadCase.SetTimeStep(caseName, outputSteps, stepSize)
        loadCase.SetTimeIntegration(caseName, 4, 0, 0, 0, 0, 0)
        loadCase.SetDampProportional(caseName, 2, 0, 0, 3.8212, 1.3641, 0.015, 0.015)
        loadCase.SetSolControlParameters(caseName, 0, 0, 10, 40, 0.0001, False, 0, 20, 0.1, 1.618)
    End Sub

    Private Sub loadCase(caseName As String, funcName As String)
        Dim loadCase = sapModel.LoadCases.DirHistNonlinear
        Dim loadType(1) As String
        Dim loadName(1) As String
        Dim funcNames(1) As String
        Dim gravityScaleFactor(1) As Double
        Dim timeScaleFactor(1) As Double
        Dim arrivalTime(1) As Double
        Dim coordinateSystem(1) As String
        Dim angle(1) As Double
        loadType(0) = "Accel"
        loadName(0) = "U1"
        funcNames(0) = funcName
        gravityScaleFactor(0) = 981.0
        timeScaleFactor(0) = 1.0
        arrivalTime(0) = 0.0
        coordinateSystem(0) = "Global"
        angle(0) = 0.0
        loadCase.SetLoads(caseName, 1, loadType, loadName, funcNames, gravityScaleFactor, timeScaleFactor, arrivalTime, coordinateSystem, angle)
    End Sub

    Private Sub extractResult(inputFileName As String, caseName As String)
        Dim NumberResults As Long
        Dim Obj() As String
        Dim Elm() As String
        Dim LoadCases() As String
        Dim StepType() As String
        Dim StepNum() As Double
        Dim U1() As Double
        Dim U2() As Double
        Dim U3() As Double
        Dim R1() As Double
        Dim R2() As Double
        Dim R3() As Double

        sapModel.Results.Setup.DeselectAllCasesAndCombosForOutput()
        For Each point In outputSetting.interestedPoints
            sapModel.PointObj.SetSelected(point, True)
        Next

        sapModel.Results.Setup.SetCaseSelectedForOutput(caseName, True)
        sapModel.Results.Setup.SetOptionModeShape(0, 0, True)
        sapModel.Results.Setup.SetOptionBaseReactLoc(0, 0, 0)
        '2 = Step-by-step
        sapModel.Results.Setup.SetOptionNLStatic(2)
        '2 = Step-by-step
        sapModel.Results.Setup.SetOptionDirectHist(2)
        sapModel.Results.JointDispl("", SAP2000v20.eItemTypeElm.SelectionElm, NumberResults, Obj, Elm, LoadCases, StepType, StepNum, U1, U2, U3, R1, R2, R3)
        'Save to excel
        Dim excelApp As Application = CreateObject("Excel.Application")
        Dim excelBook As Workbook = excelApp.Workbooks.Add(Type.Missing)
        Dim sheet As Worksheet = excelBook.Worksheets(1)
        'Excel header
        sheet.Cells(1, 1) = "Join text"
        sheet.Cells(1, 2) = "Output case"
        sheet.Cells(1, 3) = "Step type text"
        sheet.Cells(1, 4) = "Step num unitless"
        sheet.Cells(1, 5) = "U1 (cm)"
        sheet.Cells(1, 6) = "U2 (cm)"
        sheet.Cells(1, 7) = "U3 (cm)"
        sheet.Cells(1, 8) = "R1 (rad)"
        sheet.Cells(1, 9) = "R2 (rad)"
        sheet.Cells(1, 10) = "R3 (rad)"

        For row As Integer = 1 To NumberResults
            sheet.Cells(row + 1, 1) = Elm(row - 1)
            sheet.Cells(row + 1, 2) = LoadCases(row - 1)
            sheet.Cells(row + 1, 3) = StepType(row - 1)
            sheet.Cells(row + 1, 4) = StepNum(row - 1)
            sheet.Cells(row + 1, 5) = U1(row - 1)
            sheet.Cells(row + 1, 6) = U2(row - 1)
            sheet.Cells(row + 1, 7) = U3(row - 1)
            sheet.Cells(row + 1, 8) = R1(row - 1)
            sheet.Cells(row + 1, 9) = R2(row - 1)
            sheet.Cells(row + 1, 10) = R3(row - 1)
        Next

        sheet.Columns.AutoFit()
        'Set final path
        Dim fileName As String = generateOutputFileName(inputFileName)
        Dim finalPath = outputSetting.outputFolder + "\" + fileName
        excelBook.SaveAs(finalPath, XlFileFormat.xlOpenXMLWorkbook, Type.Missing,
                        Type.Missing, False, False, XlSaveAsAccessMode.xlNoChange,
                        XlSaveConflictResolution.xlUserResolution, True,
                        Type.Missing, Type.Missing, Type.Missing)
        excelBook.Close(False, Type.Missing, Type.Missing)

        excelApp.Quit()
        GC.Collect()

    End Sub

    Private Function generateOutputFileName(inputFileName As String) As String
        Dim out As String = outputSetting.outputFileNameFormat
        out = out.Replace("${input}", inputFileName)
        out = out.Replace("${timestamp}", Now.ToString("dd/MM/yyyy HH:mm:ss"))
        Return out
    End Function

    Private Sub createFolderIfNotExists(path As String)
        If (Not Directory.Exists(path)) Then
            Directory.CreateDirectory(path)
        End If
    End Sub


End Class
