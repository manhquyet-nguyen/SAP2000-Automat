Imports System.ComponentModel
Imports System.Reflection

Public Class EnumUtil
    Public Shared Function enumsAsMap(enumType As Type) As Dictionary(Of String, Object)
        Dim result = New Dictionary(Of String, Object)
        For Each e In [Enum].GetValues(enumType)
            result.Add(GetEnumDescription(e), e)
        Next
        Return result
    End Function

    Friend Shared Function GetEnumDescription(Of TEnum)(enumObj As TEnum) As String
        Dim fi As FieldInfo = enumObj.GetType().GetField(enumObj.ToString())

        Dim attributes As DescriptionAttribute() = fi.GetCustomAttributes(GetType(DescriptionAttribute), False)

        If attributes IsNot Nothing AndAlso attributes.Length > 0 Then
            Return attributes(0).Description
        Else
            Return enumObj.ToString()
        End If
    End Function
End Class
