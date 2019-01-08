Public Class InputSetting
    Property sap2000ExePath As String
    Property sdbModelFilePath As String
    Property workspaceFolder As String
    Property inputFiles As List(Of String)
    Property numberOutputSettings As Dictionary(Of String, Integer)
    Property timestepSettings As Dictionary(Of String, Double)

    Public Function clone() As InputSetting
        Dim cloned = New InputSetting With {
            .sap2000ExePath = sap2000ExePath,
            .sdbModelFilePath = sdbModelFilePath,
            .workspaceFolder = workspaceFolder,
            .inputFiles = New List(Of String)(inputFiles),
            .numberOutputSettings = New Dictionary(Of String, Integer)(numberOutputSettings),
            .timestepSettings = New Dictionary(Of String, Double)(timestepSettings)
        }
        Return cloned
    End Function
End Class
