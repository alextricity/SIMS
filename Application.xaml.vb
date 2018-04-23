Imports System.Threading
Imports System.Net
Imports System.Net.NetworkInformation

Class Application


    Public Property Logoscreen As SplashScreen
    Dim MINIMUM_SPLASH_TIME As Integer = 1000


    Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
        Dim Logoscreen As New Logoscreen

        Logoscreen.Show()
        ' Step 2 - Start a stop watch  
        Dim timer As Stopwatch = New Stopwatch
        timer.Start()
        ' Step 3 - Load your windows but don't show it yet  
        MyBase.OnStartup(e)
        Dim main As MAIN = New MAIN
        timer.Stop()
        Dim remainingTimeToShowSplash As Integer = (MINIMUM_SPLASH_TIME - CType(timer.ElapsedMilliseconds, Integer))
        If ((remainingTimeToShowSplash > 0)) Then
            Thread.Sleep(remainingTimeToShowSplash)
            Dim pPing As New Ping
            If pPing.Send("127.0.0.1", 500).Status = NetworkInformation.IPStatus.Success Then
                Logoscreen.Close()
            Else
                MsgBox("Unable to contact database server")
                Environment.Exit(0)
            End If

        End If
    End Sub
    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
End Class
