Imports System.Data.Odbc
Imports System.IO
Imports System.Configuration
Imports System.Data

Module ModCS
    Dim st As String
    Public Function ReadCS() As String
        st = System.Configuration.ConfigurationManager.ConnectionStrings("[CS]").ConnectionString
        'Dim settings As ConnectionStringSettingsCollection = ConfigurationManager.ConnectionStrings
        'For Each cs As ConnectionStringSettings In settings
        'st = cs.ConnectionString
        'Next
        Return st
    End Function
    Public ReadOnly cs As String = ReadCS()
End Module



Partial Public Class MAIN

    ////////////////////////////////////////////////////asdasda

End Class