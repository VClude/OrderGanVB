Imports MySql.Data.MySqlClient
Module db

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub initdb()
        Try
            Dim str As String
            str = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=root;" _
            & "database=homestead"

            conn = New MySqlConnection(str)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
