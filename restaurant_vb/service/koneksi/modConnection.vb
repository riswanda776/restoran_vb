Imports MySql.Data.MySqlClient

Module modConnection
    Public conn As MySqlConnection
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet
    Public simpan, ubah, hapus, cari As String

    Public Sub bukaDB()
        Try
            Dim sql As String
            sql = "server=localhost;Uid=root;pwd=;Database=db_kasir_restoran"
            conn = New MySqlConnection(sql)
            conn.Open()
        Catch ex As Exception
            MsgBox("koneksi gagal karena " + ex.ToString)
        End Try
    End Sub
End Module
