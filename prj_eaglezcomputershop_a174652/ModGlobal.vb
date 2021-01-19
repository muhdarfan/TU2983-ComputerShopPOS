Imports System.IO

Module ModGlobal
    Public DB As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='DB_EAGLEZCOMPUTERSHOP_A174652.accdb';Persist Security Info=False;"
    Public connection2 As New OleDb.OleDbConnection(DB)

    Public Function run_sql_query(mysql As String) As DataTable
        Dim mydatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, DB)

        Try
            myreader.Fill(mydatable)
        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try

        Return mydatable
    End Function

    Public Function run_sql_command(thissql As String) As Boolean
        Dim mywriter As New OleDb.OleDbCommand(thissql, New OleDb.OleDbConnection(DB))

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            Return True
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try

        Return False
    End Function


    Public Function SafeImageFromFile(path As String) As Image
        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using
    End Function
End Module
