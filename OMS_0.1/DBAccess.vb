Imports System.Data.Odbc

Public Class DBAccess
    Private connectionString As String = "Driver={MySQL ODBC 5.3 ANSI Driver}; server=141.209.241.47; database=bis635c2g3; user=bis635c2g3; password=initpass"

    Public DBConnection As New OdbcConnection(connectionString)

    Private DBCommand As OdbcCommand

    Public DBDataAdapter As OdbcDataAdapter

    Public DBDataTable As DataTable

    Public params As New List(Of OdbcParameter)

    Public RecordCount As Integer

    Public Exception As String

    Public Sub ExecuteQuery(QueryString As String)

        RecordCount = 0

        Exception = String.Empty

        Try
            DBConnection.Open()

            DBCommand = New OdbcCommand(QueryString, DBConnection)

            For Each p As OdbcParameter In params
                DBCommand.Parameters.Add(p)
            Next

            params.Clear()
            DBDataTable = New DataTable
            DBDataAdapter = New OdbcDataAdapter(DBCommand)
            RecordCount = DBDataAdapter.Fill(DBDataTable)

        Catch ex As Exception

            Exception = ex.Message

        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub

    Public Sub AddParam(Name As String, value As Object)
        Dim newParam As New OdbcParameter(Name, value)
        params.Add(newParam)

    End Sub

End Class
