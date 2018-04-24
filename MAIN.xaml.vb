

Public Class MAIN
    Private Sub MAIN_MouseLeftButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Me.MouseLeftButtonDown
        e.Handled = True
        Me.DragMove()
    End Sub
    Sub Shutdown()
        System.Windows.Application.Current.Shutdown()
    End Sub
    Sub MAIN_Closing()
        System.Windows.Application.Current.Shutdown()
    End Sub


End Class
