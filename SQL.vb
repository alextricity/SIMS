Imports System.Data.Odbc
Imports System.IO
Imports System.Configuration
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

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

    Dim MysqlConn As MySqlConnection
    Sub Runner()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=192.186.251.228;Database=SIMSdb904t3085h21408; User=SIMSdb00z2rsdfg; Password=e2sn6WzH9b45H4H;"

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successful")
            'INSERT INTO `SIMSdb904t3085h21408`.`Users` (`UserID`, `UserType`, `UserName`, `Password`, `Email`, `Phone`, `Active`, `DateCreated`, `DateModified`, `ModificationHistory`) VALUES (NULL, 'Admin', 'a', '1', 'email@email.com', '000-000-0000', '1', '04-25-2018', '04-25-2018', '');

            Dim sqladapter As New MySqlDataAdapter("SELECT * FROM Users", MysqlConn)
            Dim sqlcmd As New MySqlCommand
            Dim dr As MySqlDataReader
            Dim DataGridUsers As New DataGridView()

            sqlcmd = New MySqlCommand("SELECT * FROM Users", MysqlConn)
            'dr = sqlcmd.ExecuteReader()
            ' MsgBox(dr.FieldCount & "FieldCount")

            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM Users", MysqlConn)

            Dim ds As DataTable = New DataTable()
            adapter.Fill(ds)
            '
            'Dim rowData As String
            'For Each row As DataRow In ds.Rows
            'For Each column As DataColumn In ds.Columns
            'rowData = rowData & column.ColumnName & “=” & row(column) & ” ”
            'Next
            'rowData = rowData & vbNewLine & vbNewLine
            'Next
            ' MessageBox.Show(rowData)

            Dim dtb As New DataTable()
            dtb.Columns.Add("Col1", GetType(String))
            dtb.Columns.Add("Col2", GetType(String))
            dtb.Rows.Add("Hello", "World")
            dtb.Rows.Add("Green", "Apple")
            dtb.Rows.Add("Big", "Orange")
            dtb.Rows.Add("Fresh", "Water")


            DataGridUsers.DataSource = dtb
            DataGridUsers.Update()
            DataGridUsers.Refresh()



            MsgBox("Here?")

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message & "IF YOU SEE THIS ERROR, MAKE SURE YOU HAVE LOGGED INTO THE REMOTE DATABASE SECTION OF GODADDY AND ADDED THE IP THAT APPEARS AFTER THE @ ABOVE THIS NOTE")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

End Class