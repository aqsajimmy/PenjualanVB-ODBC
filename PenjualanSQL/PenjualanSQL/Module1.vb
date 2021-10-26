Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public rd As OdbcDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public cmd As OdbcCommand

    Sub koneksi()
        conn = New OdbcConnection("Driver={Mysql ODBC 3.51 Driver};Database=db_toko;server=localhost;uid=root")
        Try
            conn.Open()
            'MsgBox("ok")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
