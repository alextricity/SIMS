Public Class MAIN
    Private Sub Ribbon_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

    End Sub
    Sub Shutdown()
        System.Windows.Application.Current.Shutdown()
    End Sub
    Sub MAIN_Closing()
        System.Windows.Application.Current.Shutdown()
    End Sub
End Class
