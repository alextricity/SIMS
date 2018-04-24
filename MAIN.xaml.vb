

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

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function

    Dim dataEntities As Registration1 = New MSDataSetGenerator
    Private Sub UserQuery()


        Dim query = "select * from Users"

        UserGrid.ItemsSource = query.ToList()
    End Sub
End Class
