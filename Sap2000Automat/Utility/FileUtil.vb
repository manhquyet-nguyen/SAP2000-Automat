Imports System.IO

Public Class FileUtil
    Public Shared Function duplicateFile(originalFilePath As String, newFolder As String) As String
        Dim newFilePath = newFolder + "\" + Path.GetFileName(originalFilePath)
        My.Computer.FileSystem.CopyFile(originalFilePath, newFilePath, False)
        Return newFilePath
    End Function
End Class
