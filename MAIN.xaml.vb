Imports System.Data.Odbc
Public Class MAIN
    Private Sub Ribbon_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

    End Sub
    Sub Shutdown()
        System.Windows.Application.Current.Shutdown()
    End Sub
    Sub MAIN_Closing()
        System.Windows.Application.Current.Shutdown()
    End Sub

    Sub Window_OnLoad()
        Dim Str As String = "SELECT * from Users"
        Dim OdbcCon As OdbcConnection = New OdbcConnection(My.Settings.ConnectionStrings)
        OdbcCon.Open()
        Using (OdbcCon)
            Dim adapter As OdbcDataAdapter = New OdbcDataAdapter(Str, OdbcCon)
            Dim table As New DataTable
            adapter.Fill(table)
            table.Rows(0)("Invoice") = "Invoice"
            dgrid.ItemsSource = table.AsDataView
        End Using
        If OdbcCon.State = ConnectionState.Open Then OdbcCon.Close()
    End Sub
End Class
