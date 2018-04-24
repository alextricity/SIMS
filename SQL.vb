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

    Sub Getdata()
        Dim dgw As New DataGrid
        Dim myConnection As OdbcConnection = New OdbcConnection
        myConnection.ConnectionString = "Dsn=sims;dbq=MEDIA\SIMS.mdb;defaultdir=MEDIA;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;uid=admin" 'cs
        ' create a data adapter 
        Dim da As OdbcDataAdapter = New OdbcDataAdapter("Select * from Users", myConnection)


        ' create a new dataset 
        Dim ds As DataSet = New DataSet
        ' fill dataset 
        da.Fill(ds, "Users")

        dgw.DataContext = ds.DefaultViewManager
    End Sub




End Class