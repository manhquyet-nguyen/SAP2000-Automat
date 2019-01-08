Public Class AnalysisOptions
    Public Property solverType As SolverType
    Public Property solverProcessType As SolverProcessType
    Public Property instancesCount As Integer
    ' Should let the program choose 32/64 bit based on the host computer
    Public Property force32Bit = False
    ' Don't know this setting
    Public Property stiffPath = ""

    Public Sub New()

    End Sub

    Public Sub New(solverType As SolverType, solverProcessType As SolverProcessType, instancesCount As Integer)
        Me.solverType = solverType
        Me.solverProcessType = solverProcessType
        Me.instancesCount = instancesCount
    End Sub

    Public Function clone() As AnalysisOptions
        Dim obj = New AnalysisOptions()
        obj.solverType = solverType
        obj.solverProcessType = solverProcessType
        obj.instancesCount = instancesCount
        obj.force32Bit = force32Bit
        obj.stiffPath = stiffPath
        Return obj
    End Function


End Class
